Public Class ClsBanco
    Public Function MANT_BANCOS(ByVal strCod As String, ByVal strDes As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_BANCOS"
        Cmn.Parameters.Add("@COD_BANCO", SqlDbType.Char, 2)
        Cmn.Parameters("@COD_BANCO").Value = strCod
        Cmn.Parameters.Add("@DESC_BANCO", SqlDbType.VarChar, 50)
        Cmn.Parameters("@DESC_BANCO").Value = strDes
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        Mant_Bancos = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando BANCOS", Err.Description)
    End Function
    Sub LISTAR_BANCOS(ByVal COMBO As Object)
        Dim Adapter As New SqlClient.SqlDataAdapter("EXEC LISTAR_BANCOS 0,'" & "" & "','" & "" & "'", CAD_CON)
        Dim table As New DataTable
        Adapter.Fill(table)
        COMBO.DisplayMember = "DESCRIPCION"
        COMBO.ValueMember = "CODIGO"
        COMBO.DataSource = table

    End Sub
End Class
