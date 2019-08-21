Public Class ClsCajaOfic
    Public Function MANT_CAJAOFIC(ByVal TIPO_MCAJA As String, ByVal COD_MCAJA As Double, _
        ByVal FECHA_MCAJA As Date, ByVal MON_MCAJA As String, ByVal COD_PLANCTA As String, _
        ByVal SUB_PLANCTA As String, ByVal ENTREGAMOS_MCAJA As String, _
        ByVal MONTO_MCAJA As Double, ByVal OBSERV_MCAJA As String, _
        ByVal TC_MCAJA As Double, _
        ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_CAJAOFIC"
        Cmn.Parameters.Add("@TIPO_MCAJA", SqlDbType.Char, 1)
        Cmn.Parameters("@TIPO_MCAJA").Value = TIPO_MCAJA
        Cmn.Parameters.Add("@COD_MCAJA", SqlDbType.BigInt)
        Cmn.Parameters("@COD_MCAJA").Value = COD_MCAJA
        Cmn.Parameters.Add("@FECHA_MCAJA", SqlDbType.DateTime)
        Cmn.Parameters("@FECHA_MCAJA").Value = Format(FECHA_MCAJA, "dd/MM/yyyy")
        Cmn.Parameters.Add("@MON_MCAJA", SqlDbType.Char, 1)
        Cmn.Parameters("@MON_MCAJA").Value = MON_MCAJA
        Cmn.Parameters.Add("@COD_PLANCTA", SqlDbType.Char, 4)
        Cmn.Parameters("@COD_PLANCTA").Value = COD_PLANCTA
        Cmn.Parameters.Add("@SUB_PLANCTA", SqlDbType.Char, 2)
        Cmn.Parameters("@SUB_PLANCTA").Value = SUB_PLANCTA
        Cmn.Parameters.Add("@ENTREGAMOS_MCAJA", SqlDbType.VarChar, 150)
        Cmn.Parameters("@ENTREGAMOS_MCAJA").Value = ENTREGAMOS_MCAJA
        Cmn.Parameters.Add("@MONTO_MCAJA", SqlDbType.Float)
        Cmn.Parameters("@MONTO_MCAJA").Value = MONTO_MCAJA
        Cmn.Parameters.Add("@OBSERV_MCAJA", SqlDbType.VarChar, 1500)
        Cmn.Parameters("@OBSERV_MCAJA").Value = OBSERV_MCAJA

        Cmn.Parameters.Add("@TC_MCAJA", SqlDbType.Float)
        Cmn.Parameters("@TC_MCAJA").Value = TC_MCAJA

        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_CAJAOFIC = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDORES", Err.Description)

    End Function
    Sub IAM_LISTAR_RECIBOS_OFIC(ByVal FI As String, ByVal FF As String, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("IAM_LISTAR_RECIBOS_OFIC", CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@FI", SqlDbType.Char, 8)
            da.SelectCommand.Parameters("@FI").Value = FI
            da.SelectCommand.Parameters.Add("@FF", SqlDbType.Char, 8)
            da.SelectCommand.Parameters("@FF").Value = FF
            da.Fill(dt)
            FLEX.DataSource = dt
            FLEX.Cols(10).Visible = False
            FLEX.Cols(8).Format = "###,###,###.000"
            'FLEX.Cols(6).Format = "###,###,###.000"
            'FLEX.AutoSizeCol(5)
            'FLEX.AutoSizeCol(6)
            'FLEX.Cols(0).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Function CORR_CAJA(ByVal TIPO_MCAJA As String) As Double

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Double


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "CORR_CAJA"
        Cmn.Parameters.Add("@TIPO_MCAJA", SqlDbType.Char, 1)
        Cmn.Parameters("@TIPO_MCAJA").Value = TIPO_MCAJA
        Cmn.Parameters.Add("@COD_MCAJA", SqlDbType.BigInt)
        Cmn.Parameters("@COD_MCAJA").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@COD_MCAJA").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        CORR_CAJA = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDORES", Err.Description)

    End Function
    Public Function BUSCAR_CAJA_OFICINA(ByVal TIPO_MCAJA As String, ByVal COD_MCAJA As Double) As SqlDataReader
        Dim SQL As String
        Try
            SQL = "EXEC BUSCAR_CAJA_OFICINA '" & TIPO_MCAJA & "'," & COD_MCAJA & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
            BUSCAR_CAJA_OFICINA = OCOMANDO.ExecuteReader

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function IAM_SALDO_INI_MON(ByVal FI As String, MON As String) As Double

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Double


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "IAM_SALDO_INI_MON"
        Cmn.Parameters.Add("@FI", SqlDbType.Char, 8)
        Cmn.Parameters("@FI").Value = FI
        Cmn.Parameters.Add("@MON", SqlDbType.Char, 1)
        Cmn.Parameters("@MON").Value = MON
        Cmn.Parameters.Add("@SALDO", SqlDbType.Float)
        Cmn.Parameters("@SALDO").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@SALDO").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        IAM_SALDO_INI_MON = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDORES", Err.Description)

    End Function
    Public Function IAM_SALDO_INI(ByVal FI As String) As Double

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Double


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "IAM_SALDO_INI"
        Cmn.Parameters.Add("@FI", SqlDbType.Char, 8)
        Cmn.Parameters("@FI").Value = FI
        Cmn.Parameters.Add("@SALDO", SqlDbType.Float)
        Cmn.Parameters("@SALDO").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@SALDO").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        IAM_SALDO_INI = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDORES", Err.Description)

    End Function
End Class
