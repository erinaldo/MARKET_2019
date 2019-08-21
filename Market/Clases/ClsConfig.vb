Public Class ClsConfig
    Private ACIADESC As String
    Private ACIADIRE As String
    Private ACIARUC As String
    Private FE_RUTA_FIRMA_DIGITAL As String
    Private FE_URI As String
    Private FE_UBIGEO As String
    Private FE_URBANIZACION As String
    Private FE_DEPARTAMENTO As String
    Private FE_PROVINCIA As String
    Private FE_DISTRITO As String
    Private FE_PSW_FIRMA_DIGITAL As String
    Private FE_CARPETA_TMP As String
    Private FE_WEB As String
    Private ACFGLIMITE_DNI As Double
    Private ACLICODI_BOLETA_VALE As Integer
    Private FE_CARPETA_TXT As String

    Private FE_COD_ESTABLECIMIENTO As String
    Private FE_CATALOG_51 As String

    Private COD_DOC_FACTURA As String
    Private COD_DOC_BOLETA As String

    Private MON_VENTA As String
    Public Property DescConfig() As String
        Get
            Return ACIADESC
        End Get
        Set(ByVal value As String)
            ACIADESC = value
        End Set
    End Property

    Public Property DirConfig() As String
        Get
            Return ACIADIRE
        End Get
        Set(ByVal value As String)
            ACIADIRE = value
        End Set
    End Property

    Public Property RucConfig() As String
        Get
            Return ACIARUC
        End Get
        Set(ByVal value As String)
            ACIARUC = value
        End Set
    End Property
    Public Property Config_Ruta_Firma_Digital As String
        Get
            Return FE_RUTA_FIRMA_DIGITAL
        End Get
        Set(value As String)
            FE_RUTA_FIRMA_DIGITAL = value
        End Set
    End Property

    Public Property Config_Uri As String
        Get
            Return FE_URI
        End Get
        Set(value As String)
            FE_URI = value
        End Set
    End Property

    Public Property Config_Ubigeo As String
        Get
            Return FE_UBIGEO
        End Get
        Set(value As String)
            FE_UBIGEO = value
        End Set
    End Property
    Public Property Config_Urbanizacion As String
        Get
            Return FE_URBANIZACION
        End Get
        Set(value As String)
            FE_URBANIZACION = value
        End Set
    End Property

    Public Property Config_Departamento As String
        Get
            Return FE_DEPARTAMENTO
        End Get
        Set(value As String)
            FE_DEPARTAMENTO = value
        End Set
    End Property

    Public Property Config_Provincia As String
        Get
            Return FE_PROVINCIA
        End Get
        Set(value As String)
            FE_PROVINCIA = value
        End Set
    End Property

    Public Property Config_Distrito As String
        Get
            Return FE_DISTRITO
        End Get
        Set(value As String)
            FE_DISTRITO = value
        End Set
    End Property

    Public Property Config_Psw_Firma_Digital As String
        Get
            Return FE_PSW_FIRMA_DIGITAL
        End Get
        Set(value As String)
            FE_PSW_FIRMA_DIGITAL = value
        End Set
    End Property

    Public Property Config_Carpeta_Tmp As String
        Get
            Return FE_CARPETA_TMP
        End Get
        Set(value As String)
            FE_CARPETA_TMP = value
        End Set
    End Property

    Public Property Config_Web As String
        Get
            Return FE_WEB
        End Get
        Set(value As String)
            FE_WEB = value
        End Set
    End Property

    Public Property Config_Limite_Dni As Double
        Get
            Return ACFGLIMITE_DNI
        End Get
        Set(value As Double)
            ACFGLIMITE_DNI = value
        End Set
    End Property

    Public Property Config_Cliente_Boleta_Vale As Integer
        Get
            Return ACLICODI_BOLETA_VALE
        End Get
        Set(value As Integer)
            ACLICODI_BOLETA_VALE = value
        End Set
    End Property

    Public Property Config_Carpeta_Txt As String
        Get
            Return FE_CARPETA_TXT
        End Get
        Set(value As String)
            FE_CARPETA_TXT = value
        End Set
    End Property

    Public Property Config_CodEstablecimiento As String
        Get
            Return FE_COD_ESTABLECIMIENTO
        End Get
        Set(value As String)
            FE_COD_ESTABLECIMIENTO = value
        End Set
    End Property

    Public Property Config_Catalog51 As String
        Get
            Return FE_CATALOG_51
        End Get
        Set(value As String)
            FE_CATALOG_51 = value
        End Set
    End Property

    Public Property Config_MonVenta As String
        Get
            Return MON_VENTA
        End Get
        Set(value As String)
            MON_VENTA = value
        End Set
    End Property

    Public Property Config_Factura As String
        Get
            Return COD_DOC_FACTURA
        End Get
        Set(value As String)
            COD_DOC_FACTURA = value
        End Set
    End Property

    Public Property Config_Boleta As String
        Get
            Return COD_DOC_BOLETA
        End Get
        Set(value As String)
            COD_DOC_BOLETA = value
        End Set
    End Property

    Public Function MANT_CONFIG(ByVal IGVD As Integer, ByVal TURNO_VTA As Integer, ByVal FECHA_PROCESO As Date,
    ByVal FIN_DIA As String, MON_VENTA As String, ByVal TIPO As String) As Integer

        On Error GoTo TrataError
        Dim intValidar As Integer

        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "MANT_CONFIG"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@IGV", SqlDbType.Int)
        CMN.Parameters("@IGV").Value = IGVD
        CMN.Parameters.Add("@TURNO_VTA", SqlDbType.Int)
        CMN.Parameters("@TURNO_VTA").Value = TURNO_VTA
        CMN.Parameters.Add("@FECHA_PROCESO", SqlDbType.SmallDateTime)
        CMN.Parameters("@FECHA_PROCESO").Value = Format(FECHA_PROCESO, "dd/MM/yyyy")
        CMN.Parameters.Add("@FIN_DIA", SqlDbType.NVarChar)
        CMN.Parameters("@FIN_DIA").Value = FIN_DIA

        CMN.Parameters.Add("@MON_VENTA", SqlDbType.Char, 1)
        CMN.Parameters("@MON_VENTA").Value = MON_VENTA

        CMN.Parameters.Add("@TIP", SqlDbType.Char)
        CMN.Parameters("@TIP").Value = TIPO
        CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
        CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        MANT_CONFIG = CMN.Parameters("@INGPROC_001").Value
TrataError:
        CMN = Nothing
        CNN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando Configuracion", Err.Description)
    End Function
    Public Function LISTAR_CONFIG() As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            'Dim RS As New ADODB.Recordset
            SQL = "EXEC LISTAR_CONFIG"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            LISTAR_CONFIG = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub LISTAR_CONFIG_V2()
        On Error GoTo merror
        Dim RS As SqlDataReader
        ''CONFIGURACION
        Dim OCOMANDO As New SqlCommand("LISTAR_CONFIG", CN_NET)
        If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
        RS = OCOMANDO.ExecuteReader
        While RS.Read
            DescConfig = RS("CONFIG_NOMB_EMPRESA")
            DirConfig = RS("CONFIG_DIR_EMPRESA")
            RucConfig = RS("CONFIG_RUC_EMPRESA")

            Config_Ruta_Firma_Digital = RS("FE_RUTA_FIRMA_DIGITAL")
            Config_Uri = RS("FE_URI")
            Config_Ubigeo = RS("FE_UBIGEO")
            Config_Urbanizacion = RS("FE_URBANIZACION")
            Config_Departamento = RS("FE_DEPARTAMENTO")
            Config_Provincia = RS("FE_PROVINCIA")
            Config_Distrito = RS("FE_DISTRITO")
            Config_Psw_Firma_Digital = RS("FE_PSW_FIRMA_DIGITAL")
            Config_Carpeta_Tmp = RS("FE_CARPETA_TMP")
            Config_Web = RS("FE_WEB")
            Config_Limite_Dni = RS("ACFGLIMITE_DNI")

            'Config_Cliente_Boleta_Vale = RS("ACLICODI_BOLETA_VALE")

            Config_Carpeta_Txt = RS("FE_CARPETA_TXT")

            Config_CodEstablecimiento = RS("FE_COD_ESTABLECIMIENTO")
            Config_Catalog51 = RS("FE_CATALOG_51")

            Config_MonVenta = RS("MON_VENTA")

            Config_Factura = RS("COD_DOC_FACTURA")
            Config_Boleta = RS("COD_DOC_BOLETA")


        End While
        RS.Close()
        CN_NET.Close()
merror:

        If Err.Number <> 0 Then Err.Raise(Err.Number, "", Err.Description)
    End Sub
End Class
