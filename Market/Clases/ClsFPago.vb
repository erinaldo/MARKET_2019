Public Class ClsFPago
    Public Function MANT_FPAGO(ByVal strCod As String, ByVal strDes As String, ByVal DIAS As Integer, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_FPAGOS"
        Cmn.Parameters.Add("@COD_FP", SqlDbType.VarChar, 3)
        Cmn.Parameters("@COD_FP").Value = strCod
        Cmn.Parameters.Add("@DESC_FP", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_FP").Value = strDes
        Cmn.Parameters.Add("@DIAS_FP", SqlDbType.Int)
        Cmn.Parameters("@DIAS_FP").Value = DIAS
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_FPAGO = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando FORMA DE PAGOS", Err.Description)
    End Function
End Class
