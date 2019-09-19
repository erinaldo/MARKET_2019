Module Module1
    Public GUSERID As String
    Public GUSERDS As String

    Public Const intNUEVO = "N"
    Public Const intMODIFICAR = "M"
    Public Const intANULAR = "A"
    Public Const intELIMINAR = "E"

    ''Public Const DEFAULT_FPAGO = "006"


    Public Const SISTEMA_FELECTRONICA = "N"
    Public Const SISTEMA_MOVIMI_CAJA = "N"

    ''ITALO ELECTRONICA MATRICIAL
    Public Const SISTEMA_ITALO = "S"

    ''ASPNET
    Public Const SISTEMA_ASPNET = "N"
    ''asesor
    'Public Const SISTEMA_ASPNET_RUTA_HASH = "\\SERVER\out" '"D:\reail\out"
    'Public Const SISTEMA_ASPNET_RUTA = "\\SERVER\in" '"D:\reail\out"

    ''SANTA RITA
    Public Const SISTEMA_ASPNET_RUTA_HASH = "\\SERVIDOR\out" '"D:\reail\out"
    Public Const SISTEMA_ASPNET_RUTA = "\\SERVIDOR\in" '"D:\reail\out"

    'Public Const SISTEMA_ASPNET_RUTA_HASH = "D:\reail\out"
    'Public Const SISTEMA_ASPNET_RUTA = "D:\reail\out"

    Public CFG_DRESULT As Integer = 2



    Public CONFIG_VALIDAR_STOCK As Boolean = True
    Public CONFIG_RESUMEN_X_ARTICULOS As Boolean = False

    Public IGV As Double
    Public TURNO As Integer
    Public CFG_FPAGO As String
    Public CFG_MONVENTA As String

    Public COD_FACT As String
    Public COD_BOL As String

    Public CONFIG_TURNO As Integer

    Public GEditprecio As Boolean
    Public GFechaProceso As Date
    Public GPTOVTA As String

    Public GC_ColorEnfoque = Color.Yellow
    Public GC_ColorDefecto = Color.White
    Public GC_ColorDefecto_TECLADO = Color.Black


    '********************************************************
    '********** VARIABLES PARA EL FORMATO DE TICKET *********
    '********************************************************
    Public GHEAD1 As String
    Public GHEAD2 As String
    Public GHEAD3 As String
    Public GHEAD4 As String
    Public GHEAD5 As String
    Public GHEAD6 As String
    Public GHEAD7 As String
    Public GHEAD8 As String
    Public GHEAD9 As String
    Public GHEAD10 As String

    Public GstrFOOT1 As String
    Public GstrFOOT2 As String
    Public GstrFOOT3 As String
    Public GstrFOOT4 As String
    Public GstrFOOT5 As String
    Public GstrFOOT6 As String
    Public GstrFOOT7 As String
    Public GstrFOOT8 As String
    Public GstrFOOT9 As String
    Public GstrFOOT10 As String

    Public GstrLinea1 As String
    Public GstrLinea2 As String
    Public GstrLinea3 As String
    Public GstrLinea4 As String

    Public GStrMaquinaReg As String
    Public GstrRUTAPRN As String
    Public GDatFechaActual As Date

    Public ANULAR_VENTAS As Boolean



    Sub Main()
        Call conectar() '(Cnscb)
        Dim flogin As New LoginForm
        If flogin.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            flogin.Close()

            ''Application.Run(New Menu)
            Application.Run(New Menu_V2)
        End If
    End Sub
    Public Sub LimpiarCAJAS(ByVal Controls As System.Windows.Forms.Control.ControlCollection)
        For Each c As Control In Controls
            If Not c.Controls Is Nothing AndAlso c.Controls.Count > 0 Then
                LimpiarCajas(c.Controls)
            ElseIf c.GetType().Equals(GetType(TextBox)) Then
                CType(c, TextBox).Text = ""
            End If
        Next

    End Sub
    Sub CARGAR_CONFIG()
        Dim SQL As String
        'Dim RS As New ADODB.Recordset
        Dim OREADER As SqlDataReader
        SQL = "EXEC LISTAR_CONFIG"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        CN_NET.Open()
        OREADER = OCOMANDO.ExecuteReader
        'If Not (RS.EOF And RS.BOF) Then
        While OREADER.Read
            IGV = OREADER("IGV") 'RS.Fields("IGV").Value
            TURNO = OREADER("TURNO_VTA") 'RS.Fields("TURNO_VTA").Value
            GFechaProceso = OREADER("FECHA_PROCESO") 'RS.Fields("FECHA_PROCESO").Value
            CFG_FPAGO = OREADER("FORMA_PAGO_CONTADO")
            CFG_MONVENTA = OREADER("MON_VENTA")
            CONFIG_TURNO = OREADER("CONFIG_TURNOS")
            COD_FACT = OREADER("COD_DOC_FACTURA")
            COD_BOL = OREADER("COD_DOC_BOLETA")

        End While
        OREADER.Close()
        CN_NET.Close()
        'RS.Close()
    End Sub
    Public Function CargarVariablesPtovta() As Integer
        On Error GoTo TratarError
        Dim RS As SqlDataReader 'New ADODB.Recordset
        Dim SQL As String

        CargarVariablesPtovta = 0

        SQL = "PTOVTA_BUSCAR  1,'" & SystemInformation.ComputerName & "',0"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        CN_NET.Open()
        RS = OCOMANDO.ExecuteReader
        If RS.HasRows = False Then
            Call MsgBox("Punto de Venta no configurado", MsgBoxStyle.Information)
            CargarVariablesPtovta = 1
            RS.Close()
            CN_NET.Close()
            Exit Function
        Else
            While RS.Read
                If RS("estado") = "Inactivo" Then
                    CN_NET.Close()
                    MsgBox("Punto de Venta esta Bloqueado")
                    CargarVariablesPtovta = 1
                    End
                End If


                GPTOVTA = RS("APTOCODI")
                GEditprecio = RS("APTOEDIT")

                'GFechaProceso = RS.Fields("APTOFEPO").Value
                GStrMaquinaReg = RS("APTOREG")

            End While

        End If
        RS.Close()
        
TratarError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "CargarVariablesPtoVta()", Err.Description)
    End Function
    Public Sub PObtener_FechaServidor()

        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "ServidorFechaProc"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@FECHA", SqlDbType.DateTime)
        CMN.Parameters("@FECHA").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        GDatFechaActual = CMN.Parameters("@FECHA").Value
        CNN.Close 

    End Sub
End Module
