Public Class ClsCliente
    Public Function MANT_CLIENTES(ByVal strCod As String, ByVal strDes As String,
        ByVal RUC As String, ByVal DIREC As String, ByVal TELEF1 As String,
        ByVal TIPO_PAGO As String, ByVal LC As Double, ByVal DNI_CLIENTE As String,
        MAIL_CLIENTE As String,
        ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_CLIENTES"
        Cmn.Parameters.Add("@COD_CLIENTE", SqlDbType.Char, 20)
        Cmn.Parameters("@COD_CLIENTE").Value = strCod
        Cmn.Parameters.Add("@DESC_CLIENTE", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_CLIENTE").Value = strDes
        Cmn.Parameters.Add("@RUC_CLIENTE", SqlDbType.Char, 11)
        Cmn.Parameters("@RUC_CLIENTE").Value = RUC
        Cmn.Parameters.Add("@DIR_CLIENTE", SqlDbType.VarChar, 850)
        Cmn.Parameters("@DIR_CLIENTE").Value = DIREC
        Cmn.Parameters.Add("@TELF_CLIENTE", SqlDbType.Char, 10)
        Cmn.Parameters("@TELF_CLIENTE").Value = TELEF1
        Cmn.Parameters.Add("@COD_FP", SqlDbType.Char, 3)
        Cmn.Parameters("@COD_FP").Value = TIPO_PAGO
        Cmn.Parameters.Add("@LC_CLIENTE", SqlDbType.Float)
        Cmn.Parameters("@LC_CLIENTE").Value = LC
        Cmn.Parameters.Add("@DNI_CLIENTE", SqlDbType.Char, 8)
        Cmn.Parameters("@DNI_CLIENTE").Value = DNI_CLIENTE
        Cmn.Parameters.Add("@MAIL_CLIENTE", SqlDbType.VarChar, 250)
        Cmn.Parameters("@MAIL_CLIENTE").Value = MAIL_CLIENTE
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_CLIENTES = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDORES", Err.Description)

    End Function
    Public Function LISTAR_CLIE(ByVal COD_CLIE As String, ByVal CAMPO As String) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            SQL = "EXEC LISTAR_CLIENTES 2,'" & COD_CLIE & "'," & CAMPO & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            CN_NET.Open()
            LISTAR_CLIE = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function BUSCAR_CLIE(ByVal COD_CLIE As String, ByVal CAMPO As String) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            SQL = "EXEC BUSCAR_CLIENTE 2,'" & COD_CLIE & "'," & CAMPO & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            CN_NET.Open()
            BUSCAR_CLIE = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub LLENAR_CLIENTES(ByVal COMBO As Object)
        Dim RS As SqlDataReader 'New ADODB.Recordset
        Dim SQL As String
        SQL = "EXEC LISTAR_CLIENTES_CREDITO 0,'" & "" & "','" & "" & "'"
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
