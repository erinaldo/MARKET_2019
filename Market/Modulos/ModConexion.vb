Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Module ModConexion
    Public CN_NET As SqlConnection
    'Public Cnscb As ClsBaseDatos
    Public CAD_CON As String

    Public strServidor As String
    Public strDataBase As String
    Public strUID As String
    Public strPWD As String

    Public Sub conectar() '(ByRef CN As MAClsBaseDatos)
        'Try


        'Call inicializar_login
        cargar_parametros_conexion()
        Call inicializar_conexion() '(CN)

        'CN.conectar()

        'C'atch ex As Exception
        ' If Err.Number = 0 Then Exit Sub

        'End Try


    End Sub
    Private Sub cargar_parametros_conexion()
        On Error GoTo Merror
        ''CALLAO
        ''strServidor = "SERVCALLAO\sqlexpress"
        ''strDataBase = "MARKET_2017"
        ''strUID = "SA"
        ''strPWD = "ccaj_172003"

        ''CHANCAY
        ''\\Microserver\setup_market_electronico
        'strServidor = "MICROSERVER\sqlexpress"
        'strDataBase = "MARKET"
        'strUID = "sistemas"
        'strPWD = "sistemas"

        ''CELESTE LURIN
        ''\\Server\setup_market
        ''strServidor = "SERVER\sqlexpress"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''MARKET CHACLACAYO
        '''\\Servidor\setup_market_chaclacayo
        ''strServidor = "SERVidor\sqlexpress"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''MARKET BAUTISTA
        '''\\MARKET\setup_market
        ''strServidor = "MARKET\sqlexpress"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"


        ''TIENDA BAUTISTA 
        '''\\TIENDA\setup_market
        ''strServidor = "TIENDA\sqlexpress"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''ONG PACHACAMAC
        ''\\GLORIA_PC\setup_market
        ''strServidor = "SERVIDOR-PC\sqlexpress"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        strServidor = "italo-pc\sqlexpress"
        strDataBase = "market_celeste"


        strUID = "sa"
        strPWD = "sa"

        ''copacabana externo
        ''strServidor = "192.168.5.200\SQLEXPRESS"
        ''strDataBase = "market"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''CORAZON DE JESUS
        ''\\server\SETUP_MARKET'
        ''strServidor = "SERVER\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''''GRIFO ASESORES
        '\\server\SETUP_MARKET
        ''strServidor = "SERVER\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        '''GRIFO SANTA RITA
        '\\servidor\SETUP_MARKET
        ''strServidor = "SERVIDOR\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''GRIFO SAN DIEGO
        '''\\servER\SETUP_MARKET
        ''strServidor = "SERVER\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''SEVEN
        ''\\servER\SETUP_MARKET
        ''strServidor = "SERVER\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        ''ONG jockey
        ''strServidor = "SERVIDOR-PC\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"


        ''ONG AEROPUERTO
        ''\\servER\SETUP_MARKET
        '''strServidor = "SERVER\SQLEXPRESS"
        '''strDataBase = "MARKET"
        '''strUID = "sa"
        '''strPWD = "ccaj_172003"


        ''GRIFO QUILCA
        ''\\CELESTEservER\SETUP_MARKET
        ''strServidor = "CELESTESERVER\SQLEXPRESS"
        ''strDataBase = "MARKET"
        ''strUID = "sa"
        ''strPWD = "ccaj_172003"

        'strCIA = "01"

        'CVF = "CVF"

        'ALMACEN = "ALMACEN_HERCO"

        'ESTACION = "ESTACION_HERCO"

        'StrReportes = obtener_parametro(strLinea)

Merror:
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Cargar_Parametros_Conexion", Err.Description)
    End Sub
    Sub inicializar_conexion() '(ByRef CN As ClsBaseDatos)
        CN_NET = New SqlConnection
        CN_NET.ConnectionString = "SERVER=" & strServidor & ";database=" & strDataBase & ";UID=" & strUID & ";pwd=" & strPWD
        CAD_CON = "SERVER=" & strServidor & ";database=" & strDataBase & ";UID=" & strUID & ";pwd=" & strPWD
        'CN = New ClsBaseDatos
        'Call CN.crear_conexion()
        'Call CN.crear_conexion()

    End Sub
    'Sub desconectar(ByVal CN As ClsBaseDatos)
    '    Try


    '        Call CN.desconectar()
    '        Call destruir_conexion(CN)
    '    Catch ex As Exception
    '        If Err.Number <> 0 Then MsgBox(Err.Description)
    '    End Try
    'End Sub
    'Sub destruir_conexion(ByVal CN As ClsBaseDatos)
    '    Call CN.quitar_conexion()
    'End Sub



End Module

