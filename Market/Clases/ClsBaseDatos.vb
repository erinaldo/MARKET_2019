
Public Class ClsBaseDatos

    Dim CN As ADODB.Connection

    'Dim CN_ALMACEN As ADODB.Connection
    'Dim CN_CVF As ADODB.Connection
    'Dim CN_ESTACION As ADODB.Connection

    Dim strServidor As String
    Dim strDataBase As String
    Dim strUID As String
    Dim strPWD As String
    Dim CVF As String
    Dim ALMACEN As String
    Dim ESTACION As String

    Public strCIA As String
    Public StrReportes As String
    Public strPC As String
    Public cadcon As String

    'Public cad_CVF As String

    'Public CAD_ALMACEN As String

    'Public CAD_ESTACION As String

    Dim intTIPODB As Integer

    Const intACCESS = 0
    Const intSQLSERVER = 1

    Private Sub reset_parametros_conexion()
        strServidor = ""
        strDataBase = ""
        strUID = ""
        strPWD = ""
    End Sub

    Private Function obtener_parametro(ByVal strCADENA As String)
        On Error GoTo Merror
        obtener_parametro = Mid(strCADENA, InStr(1, strCADENA, "=") + 1)
Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "obtener_parametro", Err.Description)
    End Function

    Private Sub cargar_parametros_conexion()
        On Error GoTo Merror


        strPC = "" '"SISTEMAS-ITALO"

        strServidor = "SISTEMAS-ITALO"

        strDataBase = "MARKET"

        strUID = "SA"

        strPWD = ""

        'strCIA = "01"

        'CVF = "CVF"

        'ALMACEN = "ALMACEN_HERCO"

        'ESTACION = "ESTACION_HERCO"

        'StrReportes = obtener_parametro(strLinea)

Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Cargar_Parametros_Conexion", Err.Description)
    End Sub

    Private Function Encriptar(ByVal strCADENA As String)
        Encriptar = strCADENA
    End Function


    Sub crear_conexion()
        'On Error GoTo Merror
        CN = New ADODB.Connection
        'CN_ALMACEN = New ADODB.Connection
        'CN_CVF = New ADODB.Connection
        'CN_ESTACION = New ADODB.Connection

        Call cargar_parametros_conexion()
        'Merror:
        '       If Err.Number <> 0 Then Err.Raise(Err.Number, "crear_conexion", Err.Description)
    End Sub

    Sub quitar_conexion()
        On Error GoTo Merror
        CN = Nothing
Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "quitar_conexion", Err.Description)
    End Sub

    Sub conectar()
        On Error GoTo Merror


        CN.ConnectionString = "driver={SQL Server};SERVER=" & strServidor & ";database=" & strDataBase & ";UID=" & strUID & ";pwd=" & strPWD
        CN_NET.ConnectionString = "SERVER=" & strServidor & ";database=" & strDataBase & ";UID=" & strUID & ";pwd=" & strPWD
        'CN_ALMACEN.ConnectionString = "driver={SQL Server};SERVER=" & strServidor & ";database=" & ALMACEN & ";UID=" & strUID & ";pwd=" & strPWD
        'CN_CVF.ConnectionString = "driver={SQL Server};SERVER=" & strServidor & ";database=" & CVF & ";UID=" & strUID & ";pwd=" & strPWD
        'CN_ESTACION.ConnectionString = "driver={SQL Server};SERVER=" & strServidor & ";database=" & ESTACION & ";UID=" & strUID & ";pwd=" & strPWD


        cadcon = "SERVER=" & strServidor & ";database=" & strDataBase & ";UID=" & strUID & ";pwd=" & strPWD
        'cad_CVF = "SERVER=" & strServidor & ";database=" & CVF & ";UID=" & strUID & ";pwd=" & strPWD
        'CAD_ALMACEN = "SERVER=" & strServidor & ";database=" & ALMACEN & ";UID=" & strUID & ";pwd=" & strPWD
        'CAD_ESTACION = "SERVER=" & strServidor & ";database=" & ESTACION & ";UID=" & strUID & ";pwd=" & strPWD

        CN.Open()

        'CN_ALMACEN.Open()

        'CN_CVF.Open()

        'CN_ESTACION.Open()

Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "conectar", Err.Description)
    End Sub

    Sub desconectar()
        On Error GoTo Merror
        If CN.State = 1 Then CN.Close()
        'If CN_ALMACEN.State = 1 Then CN_ALMACEN.Close()
        'If CN_CVF.State = 1 Then CN_CVF.Close()
        'If CN_ESTACION.State = 1 Then CN_ESTACION.Close()

Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "desconectar", Err.Description)
    End Sub

    Function conexion() As ADODB.Connection
        On Error GoTo Merror
        conexion = CN
Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "conexion", Err.Description)
    End Function
    '    Function conexion_ALMACEN() As ADODB.Connection
    '        On Error GoTo Merror
    '        conexion_ALMACEN = CN_ALMACEN
    'Merror:
    '        If Err.Number <> 0 Then Err.Raise(Err.Number, "conexion", Err.Description)
    '    End Function
    '    Function conexion_CVF() As ADODB.Connection
    '        On Error GoTo Merror
    '        conexion_CVF = CN_CVF
    'Merror:
    '        If Err.Number <> 0 Then Err.Raise(Err.Number, "conexion", Err.Description)
    '    End Function
    '    Function conexion_ESTACION() As ADODB.Connection
    '        On Error GoTo Merror
    '        conexion_ESTACION = CN_ESTACION
    'Merror:
    '        If Err.Number <> 0 Then Err.Raise(Err.Number, "conexion", Err.Description)
    '    End Function

    Function conectado() As Boolean
        On Error GoTo Merror
        conectado = False
        If CN.State = 1 Then conectado = True

Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "conectado", Err.Description)
    End Function

End Class
