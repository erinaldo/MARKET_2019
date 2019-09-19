Public Class ClsMovimiento
    Public Function CODIGO(ByVal TIPO As String) As String
        On Error GoTo TrataError

        Dim CMN As New SqlClient.SqlCommand


        CMN.CommandText = "MOVIMIENTO_CODIGO"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CN_NET
        ''
        CMN.Parameters.Add("@TIPO", SqlDbType.VarChar)
        CMN.Parameters("@TIPO").Value = TIPO
        CMN.Parameters.Add("@COD", SqlDbType.Int)
        CMN.Parameters("@COD").Direction = ParameterDirection.Output

        CN_NET.Open()

        CMN.ExecuteNonQuery()

        CODIGO = CMN.Parameters("@COD").Value

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Codigo MOVIMIENTOS", Err.Description)
    End Function
    Public Function GRABAR(ByVal COD_MOV As String, ByVal TIPO_MOV As String, ByVal COD_TMOV As String, ByVal FECHA_MOV As Date,
    ByVal MON_MOV As String, ByVal TC_MOV As Double, ByVal OBS_MOV As String, ByVal TOTAL_MOV As Double,
    ByVal COD_ALMACEN As Double, ByVal ALM_DESTINO As Double,
    ByVal TIPO As String, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid) As Integer
        On Error GoTo TrataError
        Dim CMN As New SqlClient.SqlCommand
        Dim intValidar As Integer
        Dim F As Integer
        Dim SQL As String



        CMN.CommandText = "MOVIMIENTO_GRABAR"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CN_NET
        ''
        CMN.Parameters.Add("@COD_MOV", SqlDbType.VarChar)
        CMN.Parameters("@COD_MOV").Value = COD_MOV
        CMN.Parameters.Add("@TIPO_MOV", SqlDbType.Char)
        CMN.Parameters("@TIPO_MOV").Value = TIPO_MOV
        CMN.Parameters.Add("@COD_TMOV", SqlDbType.VarChar)
        CMN.Parameters("@COD_TMOV").Value = COD_TMOV
        CMN.Parameters.Add("@FECHA_MOV", SqlDbType.DateTime)
        CMN.Parameters("@FECHA_MOV").Value = FECHA_MOV
        CMN.Parameters.Add("@MON_MOV", SqlDbType.Char)
        CMN.Parameters("@MON_MOV").Value = MON_MOV
        CMN.Parameters.Add("@TC_MOV", SqlDbType.Float)
        CMN.Parameters("@TC_MOV").Value = TC_MOV
        CMN.Parameters.Add("@OBS_MOV", SqlDbType.VarChar)
        CMN.Parameters("@OBS_MOV").Value = OBS_MOV
        CMN.Parameters.Add("@TOTAL_MOV", SqlDbType.Float)
        CMN.Parameters("@TOTAL_MOV").Value = TOTAL_MOV
        CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
        CMN.Parameters("@COD_USER").Value = GUSERID

        CMN.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        CMN.Parameters("@COD_ALMACEN").Value = COD_ALMACEN
        CMN.Parameters.Add("@ALM_DESTINO", SqlDbType.BigInt)
        CMN.Parameters("@ALM_DESTINO").Value = ALM_DESTINO

        CMN.Parameters.Add("@TIPO", SqlDbType.Char)
        CMN.Parameters("@TIPO").Value = TIPO
        CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
        CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output

        CN_NET.Open()

        CMN.ExecuteNonQuery()

        intValidar = CMN.Parameters("@ingproc_001").Value

        GRABAR = intValidar
        ''GRABAR DETALLE
        If intValidar = 0 Then
            For F = 1 To FLEX.Rows.Count - 1

                SQL = "EXEC MOVIMIENTO_GRABAR_DETALLE '" & COD_MOV & "','" & TIPO_MOV & "'," & F & ",'" & FLEX.Item(F, 0) & "'," & FLEX.Item(F, 3) & "," & FLEX.Item(F, 4) & ",'" & Format(FECHA_MOV, "dd/MM/yyyy") & "','" & MON_MOV & "','" & GUSERID & "'," & TC_MOV & "," & COD_ALMACEN & "," & ALM_DESTINO & ""
                Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
                OCOMANDO.ExecuteNonQuery()
                'Cnscb.conexion.Execute(SQL)
            Next
        End If
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando MOVIMIENTO", Err.Description)
    End Function
    Public Function ANULAR(ByVal COD_MOV As String, ByVal TIPO_MOV As String) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand


            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "MOVIMIENTO_ANULAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_MOV", SqlDbType.VarChar)
            CMN.Parameters("@COD_MOV").Value = COD_MOV
            CMN.Parameters.Add("@TIPO_MOV", SqlDbType.VarChar)
            CMN.Parameters("@TIPO_MOV").Value = TIPO_MOV
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            ANULAR = CMN.Parameters("@SW").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Public Function BUSCAR(ByVal COD_MOV As String, ByVal TIPO_MOV As String) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            'Dim RS As New ADODB.Recordset
            SQL = "EXEC MOVIMIENTO_BUSCAR '" & COD_MOV & "','" & TIPO_MOV & "'"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            CN_NET.Open()
            BUSCAR = OCOMANDO.ExecuteReader
        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)
        End Try

    End Function

    Sub LISTAR_TMP_DETALLE(ByVal CORR As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, CAD_CON As String)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("LISTAR_TMP_DETALLE_MOV", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@CORRNBR", SqlDbType.BigInt)
            da.SelectCommand.Parameters("@CORRNBR").Value = CORR
            da.Fill(dt)


            FLEX.DataSource = dt
            FLEX.AutoSizeCols()



        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class
