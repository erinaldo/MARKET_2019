
Public Class ClsUsu
    Public COD_USER As String
    Public PSW_USER As String
    Public DESC_USER As String

    'Function GRsValidarUsuario(ByVal UID As String, ByVal strPWD As String, ByVal Cn As ADODB.Connection) As ADODB.Recordset
    Function GRsValidarUsuario() As Integer
        On Error GoTo merror

        'Dim Rs As ADODB.Recordset
        Dim DREADER As SqlDataReader

        'Rs = New ADODB.Recordset
        'Rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient

        'Dim SQL As String
        'Sql = "EXEC VALIDA_USUARIOProc '" & UID & "','" & strPWD & "'"

        Dim OCOMANDO As New SqlCommand("EXEC VALIDA_USUARIOProc '" & COD_USER & "','" & PSW_USER & "'", CN_NET)
        CN_NET.Open()
        DREADER = OCOMANDO.ExecuteReader
        While DREADER.Read
            GRsValidarUsuario = DREADER("FLAG")
            DESC_USER = NULO(DREADER("DSUSUARIO"), "S")
        End While
        DREADER.Close()
        CN_NET.Close()
        'GRsValidarUsuario = Rs

merror:
        'Rs = Nothing
        If Err.Number <> 0 Then Err.Raise(Err.Number, "ClsUsu.GrsValidarUsuario()", Err.Description)
    End Function
    Function ObtenerCorrelativo(ByVal UID As String) As Integer
        On Error GoTo merror


        Dim CMN As New SqlClient.SqlCommand


        CMN.CommandText = "CORRELATIVOObtProc"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CN_NET

        CMN.Parameters.Add("@USERID", SqlDbType.VarChar)
        CMN.Parameters("@USERID").Value = GUSERID
        CMN.Parameters.Add("@CORR", SqlDbType.Float)
        CMN.Parameters("@CORR").Direction = ParameterDirection.Output

        CN_NET.Open()

        CMN.ExecuteNonQuery()

        ObtenerCorrelativo = CMN.Parameters("@CORR").Value

merror:

        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Obtener Correlativo", Err.Description)
    End Function
    Function GListarUsuarios(ByVal IntModo As Integer) As SqlDataReader
        On Error GoTo merror
        'Dim Rs As ADODB.Recordset
        'Rs = New ADODB.Recordset
        'Rs.CursorLocation = adUseClient
        Dim OCOMANDO As New SqlCommand("EXEC USUARIOSelProc " & IntModo & "", CN_NET)
        CN_NET.Open()
        GListarUsuarios = OCOMANDO.ExecuteReader
merror:

        If Err.Number <> 0 Then Err.Raise(Err.Number, "", Err.Description)
    End Function
    Function GListarAccesosUsu(ByVal strUSUARIO As String, ByVal intMODULO As Object) As SqlDataReader
        On Error GoTo merror



        'Rs.CursorLocation = adUseClient
        Dim OCOMANDO As New SqlCommand("EXEC AccesoSelProc '" & strUSUARIO & "'," & intMODULO & "", CN_NET)
        CN_NET.Open()
        GListarAccesosUsu = OCOMANDO.ExecuteReader
merror:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "", Err.Description)
    End Function
    Public Function MANT_USUARIOS(ByVal strCod As String, ByVal strDes As String, ByVal strPASSW As String, clavenum As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_USUARIOS"
        Cmn.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
        Cmn.Parameters("@COD_USER").Value = strCod
        Cmn.Parameters.Add("@PSW_USER", SqlDbType.VarChar, 15)
        Cmn.Parameters("@PSW_USER").Value = strPASSW
        Cmn.Parameters.Add("@DESC_USER", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_USER").Value = strDes
        Cmn.Parameters.Add("@AUSUNUM", SqlDbType.Char, 6)
        Cmn.Parameters("@AUSUNUM").Value = clavenum
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_USUARIOS = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando USUARIO", Err.Description)
    End Function
    Sub LLENAR_USUARIOS(ByVal COMBO As Object)
        Dim Adapter As New SqlClient.SqlDataAdapter("EXEC LISTAR_USUARIOS 0,'" & "" & "','" & "" & "'", CAD_CON)
        Dim table As New DataTable
        Adapter.Fill(table)
        COMBO.DisplayMember = "DESCRIPCION"
        COMBO.ValueMember = "USUARIO"
        COMBO.DataSource = table

    End Sub
    Function Validar_PERMISO(ByVal MODULO As String, ByVal COD_USER As String) As Boolean
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "IAM_VERIFICAR_PERMISO"
        Cmn.Parameters.Add("@MODULO", SqlDbType.VarChar, 6)
        Cmn.Parameters("@MODULO").Value = MODULO
        Cmn.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
        Cmn.Parameters("@COD_USER").Value = COD_USER
        Cmn.Parameters.Add("@SW", SqlDbType.Bit)
        Cmn.Parameters("@SW").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        Validar_PERMISO = Cmn.Parameters("@SW").Value
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando USUARIO", Err.Description)
    End Function
    Sub BUSCAR_USER_NUM(CLAVENUM As String)
        Dim RS As SqlDataReader
        Try
            Dim OCOMANDO As New SqlCommand("EXEC IAM_BUSCAR_USER_NUM '" & CLAVENUM & "'", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                COD_USER = RS("COD_USER")
                PSW_USER = RS("PSW_USER")
            End While

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            CN_NET.Close()
        End Try
    End Sub

End Class

