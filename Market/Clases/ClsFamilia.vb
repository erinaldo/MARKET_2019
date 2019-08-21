Public Class ClsFamilia
    Public Function MANT_FAMILIAS(ByVal strCod As String, ByVal strDes As String, TIPO_FAMILIA As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer

        'Cmn = New ADODB.Command
        Cmn.Connection = CN_NET ' Cnscb.conexion
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_FAMILIAS"
        Cmn.Parameters.Add("@COD_FAMILIA", SqlDbType.VarChar, 4)
        Cmn.Parameters("@COD_FAMILIA").Value = strCod
        Cmn.Parameters.Add("@DESC_FAMILIA", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_FAMILIA").Value = strDes
        Cmn.Parameters.Add("@TIPO_FAMILIA", SqlDbType.Char, 1)
        Cmn.Parameters("@TIPO_FAMILIA").Value = TIPO_FAMILIA
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_FAMILIAS = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando FAMILIAS", Err.Description)
    End Function
End Class
