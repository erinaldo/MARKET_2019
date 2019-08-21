Public Class ClsPago
    Public CODIGO As Integer
    Function NRO_PAGO() As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "PAGO_CORR_NRO"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@NRO", SqlDbType.Int)
            CMN.Parameters("@NRO").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            NRO_PAGO = CMN.Parameters("@NRO").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Sub LLENAR_DEUDA(ByVal COD_PROV As String, ByVal MONEDA As String, ByVal TC As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("PAGO_DEUDA_PROV", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD_PROV", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@COD_PROV").Value = COD_PROV
            da.SelectCommand.Parameters.Add("@MON", SqlDbType.Char)
            da.SelectCommand.Parameters("@MON").Value = MONEDA
            da.SelectCommand.Parameters.Add("@TC", SqlDbType.Float)
            da.SelectCommand.Parameters("@TC").Value = TC
            da.Fill(dt)
            FLEX.DataSource = dt

            FLEX.Cols(7).Format = "###,###,###.000"
            FLEX.Cols(8).Format = "###,###,###.000"
            FLEX.Cols(9).Width = 50
            FLEX.AutoSizeCol(7)
            FLEX.AutoSizeCol(8)
            FLEX.Cols(1).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Function GRABAR_PAGO(ByVal COD_PROVED As String, ByVal MON_PAGO As String, ByVal TOTAL_PAGO As Double, ByVal PAGADOR As String, _
    ByVal TIPO_PAGO As String, ByVal COD_BANCO As String, ByVal CHEQUE_PAGO As String, ByVal CUENTA_PAGO As String, ByVal FECHA_PAGO As Date, _
    ByVal CAMBIO_PAGO As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            Dim COD As Double

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "PAGO_GRABAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_PROVED", SqlDbType.VarChar)
            CMN.Parameters("@COD_PROVED").Value = COD_PROVED
            CMN.Parameters.Add("@MON_PAGO", SqlDbType.Char)
            CMN.Parameters("@MON_PAGO").Value = MON_PAGO
            CMN.Parameters.Add("@TOTAL_PAGO", SqlDbType.Float)
            CMN.Parameters("@TOTAL_PAGO").Value = TOTAL_PAGO
            CMN.Parameters.Add("@PAGADOR", SqlDbType.VarChar)
            CMN.Parameters("@PAGADOR").Value = PAGADOR
            CMN.Parameters.Add("@TIPO_PAGO", SqlDbType.VarChar)
            CMN.Parameters("@TIPO_PAGO").Value = TIPO_PAGO
            CMN.Parameters.Add("@COD_BANCO", SqlDbType.VarChar)
            CMN.Parameters("@COD_BANCO").Value = COD_BANCO
            CMN.Parameters.Add("@CHEQUE_PAGO", SqlDbType.VarChar)
            CMN.Parameters("@CHEQUE_PAGO").Value = CHEQUE_PAGO
            CMN.Parameters.Add("@CUENTA_PAGO", SqlDbType.VarChar)
            CMN.Parameters("@CUENTA_PAGO").Value = CUENTA_PAGO
            CMN.Parameters.Add("@FECHA_PAGO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_PAGO").Value = FECHA_PAGO
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@CAMBIO_PAGO", SqlDbType.Float)
            CMN.Parameters("@CAMBIO_PAGO").Value = CAMBIO_PAGO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output
            CMN.Parameters.Add("@ID", SqlDbType.Int)
            CMN.Parameters("@ID").Direction = ParameterDirection.Output
            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR_PAGO = CMN.Parameters("@SW").Value
            COD = CMN.Parameters("@ID").Value

            CMN = Nothing
            'GRABAMOS DETALLE
            Dim F As Integer
            Dim SQL As String
            Dim OCOMANDO As SqlCommand
            If GRABAR_PAGO = 0 Then
                For F = 1 To FLEX.Rows.Count - 1
                    If FLEX.Item(F, 8) > 0 Then
                        SQL = "EXEC PAGO_GRABAR_DETALLE " & COD & "," & FLEX.Item(F, 9) & ",'" & FLEX.Item(F, 1) & "','" & MON_PAGO & "'," & CAMBIO_PAGO & ""
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
    Public Function BUSCAR(ByVal COD_PAGO As Integer) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            'Dim RS As New ADODB.Recordset
            SQL = "EXEC PAGO_BUSCAR " & COD_PAGO & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            BUSCAR = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub LLENAR_DETALLE_PAGO(ByVal COD_PAGO As Integer, ByVal MONEDA As String, ByVal TC As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("PAGO_LLENAR_DETALLE_PAGO", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD_PAGO", SqlDbType.Int)
            da.SelectCommand.Parameters("@COD_PAGO").Value = COD_PAGO
            da.SelectCommand.Parameters.Add("@MON", SqlDbType.Char)
            da.SelectCommand.Parameters("@MON").Value = MONEDA
            da.SelectCommand.Parameters.Add("@TC", SqlDbType.Float)
            da.SelectCommand.Parameters("@TC").Value = TC
            da.Fill(dt)
            FLEX.DataSource = dt

            FLEX.Cols(8).Format = "###,###,###.000"
            FLEX.Cols(9).Format = "###,###,###.000"
            'FLEX.Cols(7).Width = 50
            'FLEX.AutoSizeCol(5)
            FLEX.AutoSizeCol(8)
            FLEX.AutoSizeCol(9)
            FLEX.Cols(1).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Function ANULAR_PAGO(ByVal COD_PAGO As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "PAGO_ANULAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_PAGO", SqlDbType.Int)
            CMN.Parameters("@COD_PAGO").Value = COD_PAGO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            ANULAR_PAGO = CMN.Parameters("@SW").Value

            CMN = Nothing
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    
End Class
