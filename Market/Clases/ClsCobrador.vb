Public Class ClsCobrador
    Public Function MANT_COBRADOR(ByVal strCod As String, ByVal strDes As String, ByVal STRDIR As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError

        'Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CMN.CommandText = "MANT_COBRADOR"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CN_NET
        ''
        CMN.Parameters.Add("@COD_COBRADOR", SqlDbType.VarChar)
        CMN.Parameters("@COD_COBRADOR").Value = strCod
        CMN.Parameters.Add("@NOM_COBRADOR", SqlDbType.VarChar)
        CMN.Parameters("@NOM_COBRADOR").Value = strDes
        CMN.Parameters.Add("@DIR_COBRADOR", SqlDbType.VarChar)
        CMN.Parameters("@DIR_COBRADOR").Value = STRDIR
        CMN.Parameters.Add("@TIP", SqlDbType.Char)
        CMN.Parameters("@TIP").Value = STRTIPO
        CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
        CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output

        CN_NET.Open()

        CMN.ExecuteNonQuery()

        MANT_COBRADOR = CMN.Parameters("@ingproc_001").Value
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando Cobradores", Err.Description)
    End Function
    Sub LISTAR_COBRADORES(ByVal COMBO As Object)
        Dim Adapter As New SqlClient.SqlDataAdapter("EXEC LISTAR_COBRADOR 0,'" & "" & "','" & "" & "'", CAD_CON)
        Dim table As New DataTable
        Adapter.Fill(table)
        COMBO.DisplayMember = "DESCRIPCION"
        COMBO.ValueMember = "CODIGO"
        COMBO.DataSource = table

    End Sub
End Class
