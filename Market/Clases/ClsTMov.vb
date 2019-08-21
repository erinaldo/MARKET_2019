Public Class ClsTMov
    Public Function MANT_TMOV(ByVal strCod As String, ByVal strDes As String, ByVal TIPO As Integer, TRANSF_ALMACEN As Integer, AJUSTE_TMOV As Integer, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_TMOV"
        Cmn.Parameters.Add("@COD_TMOV", SqlDbType.Char, 2)
        Cmn.Parameters("@COD_TMOV").Value = strCod
        Cmn.Parameters.Add("@DESC_TMOV", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_TMOV").Value = strDes
        Cmn.Parameters.Add("@INOUT_TMOV", SqlDbType.Bit)
        Cmn.Parameters("@INOUT_TMOV").Value = TIPO

        Cmn.Parameters.Add("@TRANSF_TMOV", SqlDbType.Bit)
        Cmn.Parameters("@TRANSF_TMOV").Value = TRANSF_ALMACEN
        Cmn.Parameters.Add("@AJUSTE_TMOV", SqlDbType.Bit)
        Cmn.Parameters("@AJUSTE_TMOV").Value = AJUSTE_TMOV

        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_TMOV = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando Tipo de Movimiento", Err.Description)
    End Function
    Public Function BUSCAR_TRANSF_TMOV(ByVal strCod As String) As Boolean

        On Error GoTo TrataError
        Dim CNN As New SqlConnection
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer
        CNN.ConnectionString = CAD_CON

        Cmn.Connection = CNN
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "BUSCAR_TRANSF_TMOV"
        Cmn.Parameters.Add("@COD_TMOV", SqlDbType.Char, 2)
        Cmn.Parameters("@COD_TMOV").Value = strCod
        Cmn.Parameters.Add("@TRANSF", SqlDbType.Bit)
        Cmn.Parameters("@TRANSF").Direction = ParameterDirection.Output
        CNN.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@TRANSF").Value

        BUSCAR_TRANSF_TMOV = intValidar
TrataError:
        CNN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando Tipo de Movimiento", Err.Description)
    End Function
End Class
