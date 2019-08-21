Public Class ClsCobro
    Public CODIGO As Integer
    Function NRO_COBRO() As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "COBRO_CORR_NRO"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@NRO", SqlDbType.Int)
            CMN.Parameters("@NRO").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            NRO_COBRO = CMN.Parameters("@NRO").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Sub LLENAR_DEUDA(ByVal COD_CLIE As String, ByVal MONEDA As String, ByVal TC As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("COBRO_DEUDA_CLIENTE", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD_CLIE", SqlDbType.Char)
            da.SelectCommand.Parameters("@COD_CLIE").Value = COD_CLIE
            da.SelectCommand.Parameters.Add("@MON", SqlDbType.Char)
            da.SelectCommand.Parameters("@MON").Value = MONEDA
            da.SelectCommand.Parameters.Add("@TC", SqlDbType.Float)
            da.SelectCommand.Parameters("@TC").Value = TC
            da.Fill(dt)
            FLEX.DataSource = dt

            FLEX.Cols(5).Format = "###,###,###.000"
            FLEX.Cols(6).Format = "###,###,###.000"
            FLEX.Cols(7).Width = 50
            FLEX.AutoSizeCol(5)
            FLEX.AutoSizeCol(6)
            FLEX.Cols(1).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Function GRABAR_COBRO(ByVal COD_CLIENTE As String, ByVal MON_COBRO As String, ByVal TOTAL_COBRO As Double, ByVal COBRADOR As String, _
    ByVal TIPO_COBRO As String, ByVal COD_BANCO As String, ByVal CHEQUE_COBRO As String, ByVal CUENTA_COBRO As String, ByVal FECHA_COBRO As Date, _
    ByVal CAMBIO_COBRO As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            Dim COD As Double

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "COBRO_GRABAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_CLIENTE", SqlDbType.VarChar)
            CMN.Parameters("@COD_CLIENTE").Value = COD_CLIENTE
            CMN.Parameters.Add("@MON_COBRO", SqlDbType.Char)
            CMN.Parameters("@MON_COBRO").Value = MON_COBRO
            CMN.Parameters.Add("@TOTAL_COBRO", SqlDbType.Float)
            CMN.Parameters("@TOTAL_COBRO").Value = TOTAL_COBRO
            CMN.Parameters.Add("@COBRADOR", SqlDbType.VarChar)
            CMN.Parameters("@COBRADOR").Value = COBRADOR
            CMN.Parameters.Add("@TIPO_COBRO", SqlDbType.VarChar)
            CMN.Parameters("@TIPO_COBRO").Value = TIPO_COBRO
            CMN.Parameters.Add("@COD_BANCO", SqlDbType.VarChar)
            CMN.Parameters("@COD_BANCO").Value = COD_BANCO
            CMN.Parameters.Add("@CHEQUE_COBRO", SqlDbType.VarChar)
            CMN.Parameters("@CHEQUE_COBRO").Value = CHEQUE_COBRO
            CMN.Parameters.Add("@CUENTA_COBRO", SqlDbType.VarChar)
            CMN.Parameters("@CUENTA_COBRO").Value = CUENTA_COBRO
            CMN.Parameters.Add("@FECHA_COBRO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_COBRO").Value = FECHA_COBRO
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@CAMBIO_COBRO", SqlDbType.Float)
            CMN.Parameters("@CAMBIO_COBRO").Value = CAMBIO_COBRO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output
            CMN.Parameters.Add("@ID", SqlDbType.Int)
            CMN.Parameters("@ID").Direction = ParameterDirection.Output
            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR_COBRO = CMN.Parameters("@SW").Value
            COD = CMN.Parameters("@ID").Value

            CMN = Nothing
            'GRABAMOS DETALLE
            Dim F As Integer
            Dim SQL As String
            Dim OCOMANDO As New SqlCommand
            If GRABAR_COBRO = 0 Then
                For F = 1 To FLEX.Rows.Count - 1
                    If FLEX.Item(F, 8) > 0 Then
                        SQL = "EXEC COBRO_GRABAR_DETALLE " & COD & ",'" & COD_CLIENTE & "'," & FLEX.Item(F, 8) & ",'" & FLEX.Item(F, 1) & "'," & FLEX.Item(F, 2) & ",'" & MON_COBRO & "'," & CAMBIO_COBRO & ""
                        OCOMANDO = New SqlCommand(SQL, CNN)
                        OCOMANDO.ExecuteNonQuery()
                    End If
                Next
            End If
            CNN.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function BUSCAR(ByVal COD_COBRO As Integer) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            'Dim RS As New ADODB.Recordset
            SQL = "EXEC COBRO_BUSCAR " & COD_COBRO & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            BUSCAR = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub LLENAR_DETALLE_COBRO(ByVal COD_COBRO As Integer, ByVal MONEDA As String, ByVal TC As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("COBRO_LLENAR_DETALLE_PAGO", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD_COBRO", SqlDbType.Char)
            da.SelectCommand.Parameters("@COD_COBRO").Value = COD_COBRO
            da.SelectCommand.Parameters.Add("@MON", SqlDbType.Char)
            da.SelectCommand.Parameters("@MON").Value = MONEDA
            da.SelectCommand.Parameters.Add("@TC", SqlDbType.Float)
            da.SelectCommand.Parameters("@TC").Value = TC
            da.Fill(dt)
            FLEX.DataSource = dt

            FLEX.Cols(6).Format = "###,###,###.000"
            FLEX.Cols(7).Format = "###,###,###.000"
            'FLEX.Cols(7).Width = 50
            FLEX.AutoSizeCol(5)
            FLEX.AutoSizeCol(6)
            FLEX.AutoSizeCol(7)
            FLEX.Cols(1).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Function ANULAR_COBRO(ByVal COD_COBRO As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "COBRO_ANULAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_COBRO", SqlDbType.Int)
            CMN.Parameters("@COD_COBRO").Value = COD_COBRO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            ANULAR_COBRO = CMN.Parameters("@SW").Value

            CMN = Nothing
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function GRABAR_COBRO_MASIVO(ByVal COD_CLIENTE As String, ByVal MON_COBRO As String, ByVal TOTAL_COBRO As Double, ByVal COBRADOR As String, _
   ByVal TIPO_COBRO As String, ByVal COD_BANCO As String, ByVal CHEQUE_COBRO As String, ByVal CUENTA_COBRO As String, ByVal FECHA_COBRO As Date, _
   ByVal CAMBIO_COBRO As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, ByVal FI As DateTime, ByVal FF As DateTime) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            Dim COD As Double

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "COBRO_GRABAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_CLIENTE", SqlDbType.VarChar)
            CMN.Parameters("@COD_CLIENTE").Value = COD_CLIENTE
            CMN.Parameters.Add("@MON_COBRO", SqlDbType.Char)
            CMN.Parameters("@MON_COBRO").Value = MON_COBRO
            CMN.Parameters.Add("@TOTAL_COBRO", SqlDbType.Float)
            CMN.Parameters("@TOTAL_COBRO").Value = TOTAL_COBRO
            CMN.Parameters.Add("@COBRADOR", SqlDbType.VarChar)
            CMN.Parameters("@COBRADOR").Value = COBRADOR
            CMN.Parameters.Add("@TIPO_COBRO", SqlDbType.VarChar)
            CMN.Parameters("@TIPO_COBRO").Value = TIPO_COBRO
            CMN.Parameters.Add("@COD_BANCO", SqlDbType.VarChar)
            CMN.Parameters("@COD_BANCO").Value = COD_BANCO
            CMN.Parameters.Add("@CHEQUE_COBRO", SqlDbType.VarChar)
            CMN.Parameters("@CHEQUE_COBRO").Value = CHEQUE_COBRO
            CMN.Parameters.Add("@CUENTA_COBRO", SqlDbType.VarChar)
            CMN.Parameters("@CUENTA_COBRO").Value = CUENTA_COBRO
            CMN.Parameters.Add("@FECHA_COBRO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_COBRO").Value = Format(FECHA_COBRO, "dd/MM/yyyy")
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@CAMBIO_COBRO", SqlDbType.Float)
            CMN.Parameters("@CAMBIO_COBRO").Value = CAMBIO_COBRO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output
            CMN.Parameters.Add("@ID", SqlDbType.Int)
            CMN.Parameters("@ID").Direction = ParameterDirection.Output
            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR_COBRO_MASIVO = CMN.Parameters("@SW").Value
            COD = CMN.Parameters("@ID").Value
            CODIGO = COD
            CMN = Nothing
            'GRABAMOS DETALLE
            Dim F As Integer
            Dim SQL As String
            Dim OCOMANDO As New SqlCommand
            If GRABAR_COBRO_MASIVO = 0 Then
                For F = 1 To FLEX.Rows.Count - 1
                    If FLEX.Item(F, 5).ToString <> 0 Then
                        SQL = "EXEC COBRO_GRABAR_DEUDA_CLIENTE_RESUMEN " & COD & ",'" & Format(FI, "dd/MM/yyyy") & "', '" & Format(FF, "dd/MM/yyyy") & "','" & FLEX.Item(F, 6) & "'"
                        'Cnscb.conexion.Execute(SQL)
                        OCOMANDO = New SqlCommand(SQL, CNN)
                        OCOMANDO.ExecuteNonQuery()
                    End If
                Next
            End If
            CNN.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
End Class
