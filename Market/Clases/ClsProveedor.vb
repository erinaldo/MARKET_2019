Public Class ClsProveedor
    Public Function MANT_PROVEEDORES(ByVal strCod As String, ByVal strDes As String,
    ByVal RUC As String, ByVal DIREC As String, ByVal TELEF1 As String,
    ByVal TELEF2 As String, ByVal CONTACT As String, PORC_PERCEP As Double,
                                     ByVal STRTIPO As String) As Integer


        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_PROVEEDORES"
        Cmn.Parameters.Add("@COD_PROVED", SqlDbType.Char, 20)
        Cmn.Parameters("@COD_PROVED").Value = strCod
        Cmn.Parameters.Add("@DESC_PROVED", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_PROVED").Value = strDes
        Cmn.Parameters.Add("@RUC_PROVED", SqlDbType.Char, 11)
        Cmn.Parameters("@RUC_PROVED").Value = RUC
        Cmn.Parameters.Add("@DIR_PROVED", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DIR_PROVED").Value = DIREC
        Cmn.Parameters.Add("@TELF_PROVED", SqlDbType.Char, 10)
        Cmn.Parameters("@TELF_PROVED").Value = TELEF1
        Cmn.Parameters.Add("@TELF2_PROVED", SqlDbType.Char, 10)
        Cmn.Parameters("@TELF2_PROVED").Value = TELEF2
        Cmn.Parameters.Add("@CONTACTO_PROVED", SqlDbType.VarChar, 150)
        Cmn.Parameters("@CONTACTO_PROVED").Value = CONTACT
        Cmn.Parameters.Add("@PERCEP_PROVED", SqlDbType.Float)
        Cmn.Parameters("@PERCEP_PROVED").Value = PORC_PERCEP
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_PROVEEDORES = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDORES", Err.Description)
    End Function
    Public Function LISTAR_PROV(ByVal COD_PROV As String) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String

            SQL = "EXEC LISTAR_PROVEEDORES 2,'" & COD_PROV & "',COD_PROVED"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            LISTAR_PROV = OCOMANDO.ExecuteReader
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'LISTAR_PROV = RS
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub LLENAR_PROVEEDORES(ByVal COMBO As Object)
        Dim RS As SqlDataReader 'New ADODB.Recordset
        Dim SQL As String
        SQL = "EXEC LISTAR_PROVEEDORES 0,'" & "" & "','" & "" & "'"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        CN_NET.Open()
        RS = OCOMANDO.ExecuteReader
        'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        While RS.Read
            COMBO.Items.Add(RS("DESCRIPCION") & Space(150) & RS("CODIGO"))
        End While
        RS.Close()
        CN_NET.Close()

    End Sub
End Class
