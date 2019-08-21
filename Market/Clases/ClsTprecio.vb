Public Class ClsTprecio
    Public Function MANT_TPRECIOS(ByVal strCod As String, ByVal strDes As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_TPRECIOS"
        Cmn.Parameters.Add("@COD_TPRECIO", SqlDbType.Char, 2)
        Cmn.Parameters("@COD_TPRECIO").Value = strCod
        Cmn.Parameters.Add("@DESC_TPRECIO", SqlDbType.VarChar, 50)
        Cmn.Parameters("@DESC_TPRECIO").Value = strDes
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_TPRECIOS = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando TPRECIOS", Err.Description)
    End Function
End Class
