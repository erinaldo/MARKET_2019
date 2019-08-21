Imports System.Drawing
Imports System.Xml
Module Module_FE
    Public ID_DOC As Double

    Public Const PIGV As Integer = 18

    Public ESTADO_TDOC As String = ""

    Public CONFIG_RUTA_CORREGIDOS As String
    Public CONFIG_RUTA_TXT As String
    Public CONFIG_RUTA_BIEN As String
    Public CONFIG_RUTA_CERTIFICADO As String
    Public CONFIG_RUTA_LOGO As String
    Public CONFIG_RUTA_ERROR As String
    Public CONFIG_RUTA_TXT_LISTOS As String
    Public CONFIG_RUTA_TXT_CORREGIDOS As String
    Public CONFIG_RUTA_RESPUESTA_SUNAT As String
    Public CONFIG_RUTA_PDF As String
    Public CONFIG_RUTA_XML As String
    Public CONFIG_RUTA_PDF_LISTOS As String
    Public CONFIG_RUTA_XML_LISTOS As String
    Public CONFIG_RUTA_TMP As String

    Public CONFIG_FTP_RUTA_XML As String
    Public CONFIG_FTP_RUTA_PDF As String
    Public CONFIG_FTP_USER As String
    Public CONFIG_FTP_PSW As String
    Public CONFIG_INI As String

    Public ns As String, cac As String, cbc As String, ext As String, ds As String, sac As String
    Public ccts As String, qdt As String, udt As String, xsi As String

    Public ESTADO_FECHA As String = ""
    Public ESTADO_RUC As String = ""
    Public ESTADO_NOMBRE As String = ""
    Public ESTADO_MONTO As String = ""


    ''**Public PWD_FIRMA_DIGITAL As String = "xplg1232"
    Public PWD_FIRMA_DIGITAL As String ''= "12345678a"
    Public RUC_EMISOR As String ''= "20501458164"

    Public ID_FIRMA_DIGITAL As String '= "IDSignSP"
    Public ID_PARTE_FIRMANTE As String ''= "20501458164"
    Public NAME_PARTE_FIRMANTE As String '' = "HERCO COMBUSTIBLES S.A.C."
    Public URI As String '' = "#SignatureSP"
    Public RAZON_SOCIAL_EMISOR As String ''= "HERCO COMBUSTIBLES S.A.C."
    Public NOMBRE_COMERCIAL As String ''= "HERCO S.A."


    Public TIT1 As String ''= "Las Salinas N°C Int. 14-A-Predio Lurin - Lima - Lima   "
    Public TIT2 As String ''= "Km 33.5 Autopista Panamericana Sur   "
    Public TIT3 As String ''= "Telfs : (51 1) 430 2792 / (51 1) 430 0957 "
    Public TIT4 As String ''= "Fax : (51 1) 430 319 "
    Public TIT5 As String ''= "Web : www.hpo.pe "

    Public Const MON_SOLES As String = "PEN"
    Public Const MON_DOLARES As String = "USD"

    Public COD_UBIGEO_EMISOR As String ''= "150119" 'LURIN
    Public DIRECCION_EMISOR As String ''= "KM 33.5 PANAMERICANA SUR"
    Public URBANIZACION_EMISOR As String ''= "URB A"
    Public DEPARTAMENTO_EMISOR As String '' = "LIMA"
    Public PROVINCIA_EMISOR As String ''= "LIMA"
    Public DISTRITO_EMISOR As String ''= "LURIN"
    Public COD_PAIS_EMISOR As String ''= "PE"
    Public AUTORIZACION As String
    Public SOL_USER As String = ""
    Public SOL_PSW As String = ""

    ''CARGAR CONFIG MAIL
    Public MAIL_COPIA_MAIL As String = ""
    Public MAIL_COPIA_PSW As String = ""
    Public MAIL_COPIA_HOST As String = ""
    Public MAIL_COPIA_PUERTO As String = ""
    Public MAIL_COPIA_SSL As String = ""
    Public MAIL_COPIA_CARPETA As String = ""
    Public MAIL_COPIA_ASUNTO As String = ""

    ''TABLA 01 TIPO DE DOCUMENTO
    Public Const TB01_TD_FACTURA As String = "01"
    Public Const TB01_TD_BOLETA As String = "03"
    Public Const TB01_TD_NCREDITO As String = "07"
    Public Const TB01_TD_NDEBITO As String = "08"
    Public Const TB01_TD_GUIA_REMISION As String = "09"
    Public Const TB01_TD_GUIA_TRANSPORTISTA As String = "31"

    Public Const TB01_TD_FACTURA_DESC As String = "FACTURA"
    Public Const TB01_TD_BOLETA_DESC As String = "BOLETA"
    Public Const TB01_TD_NCREDITO_DESC As String = "NOTA DE CREDITO"
    Public Const TB01_TD_NDEBITO_DESC As String = "NOTA DE DEBITO"
    Public Const TB01_TD_GUIA_REMISION_DESC As String = "GUIA DE REMISION"
    Public Const TB01_TD_GUIA_TRANSPORTISTA_DESC As String = "GUIA DE TRANSPORTISTA"

    ''TABLA 03 UNIDAD DE MEDIDA
    Public Const TB03_UNIDAD As String = "NIU"
    Public Const TB03_GALON_COMBUSTIBLE As String = "1G"

    ''TABLA 05 TIPO DE TRIBUTO
    Public Const TB05_TT_IGV As String = "1000"
    Public Const TB05_TT_ISC As String = "2000"
    Public Const TB05_TT_OTROS As String = "9999"


    ''TABLA 06 TIPO DE DOCUMENTO DE IDENTIFICACION
    Public Const TB06_TRIB_NO_DOM_SIN_RUC As String = "0"
    Public Const TB06_DNI As String = "1"
    Public Const TB06_CARNET_EXTRANJERIA As String = "4"
    Public Const TB06_RUC As String = "6"
    Public Const TB06_PASAPORTE As String = "7"
    Public Const TB06_CED_DIPLOMATICA As String = "A"

    ''TABLA 07 TIPO DE AFECTACION DEL IGV
    Public Const TB07_GRABADO_OPER_ONEROSA As String = "10"
    Public Const TB07_GRABADO_RETIRO_PREMIO As String = "11"
    Public Const TB07_GRABADO_RETIRO_DONACION As String = "12"
    Public Const TB07_GRABADO_RETIRO As String = "13"
    Public Const TB07_GRABADO_RETIRO_PUBLICIDAD As String = "14"
    Public Const TB07_GRABADO_BONIFICACIONES As String = "15"
    Public Const TB07_GRABADO_RETIRO_ENTREGA_TRABAJADORES As String = "16"
    Public Const TB07_EXONERADO_OPERACION_ONEROSA As String = "20"
    Public Const TB07_INAFECTO_OPERACION_ONEROSA As String = "30"
    Public Const TB07_INAFECTO_RETIRO_BONIFICACION As String = "31"
    Public Const TB07_INAFECTO_RETIRO As String = "32"
    Public Const TB07_INAFECTO_RETIRO_MUESTRAS_MEDICAS As String = "33"
    Public Const TB07_INAFECTO_RETIRO_CONVENIO_COLECTIVO As String = "34"
    Public Const TB07_INAFECTO_RETIRO_PREMIO As String = "35"
    Public Const TB07_INAFECTO_RETIRO_PUBLICIDAD As String = "36"
    Public Const TB07_EXPORTACION As String = "40"

    ''TABLA 08 TIPOS DE SISTEMA DE CALCULO ISC
    Public Const TB08_SISTEMA_AL_VALOR As String = "01"
    Public Const TB08_APLICACION_MONTO_FIJO As String = "02"
    Public Const TB08_SISTEMA_PRECIO_VENTA_AL_PUBLICO As String = "03"

    ''TABLA 09 TIPO DE NOTA DE CREDITO ELECTRONICA
    Public Const TB09_ANULACION_DE_LA_OPERACION As String = "01"
    Public Const TB09_ANULACION_ERROR_RUC As String = "02"
    Public Const TB09_CORRECCION_ERROR_DESCRIPCION As String = "03"
    Public Const TB09_DESCUENTO_GLOBAL As String = "04"
    Public Const TB09_DESCUENTO_POR_ITEM As String = "05"
    Public Const TB09_DEVOLUCION_TOTAL As String = "06"
    Public Const TB09_DEVOLUCION_POR_ITEM As String = "07"
    Public Const TB09_BONIFICACION As String = "08"
    Public Const TB09_DISMINUCION_EN_EL_VALOR As String = "09"

    ''TABLA 10 TIPO DE NOTA DE DEBITO ELECTRONICA
    Public Const TB10_INTERESES_POR_MORA As String = "01"
    Public Const TB10_AUMENTO_EN_EL_VALOR As String = "02"

    ''TABLA 11 
    Public Const TB11_GRABADO As String = "01"
    Public Const TB11_EXONERADO As String = "02"
    Public Const TB11_INAFECTO As String = "03"
    Public Const TB11_EXPORTACION As String = "04"
    Public Const TB11_GRATUITAS As String = "05"

    ''TABLA 14
    Public Const TB14_VALOR_VENTA_GRAVADAS As String = "1001"
    Public Const TB14_VALOR_VENTA_INAFECTAS As String = "1002"
    Public Const TB14_VALOR_VENTA_OPE_EXONERADAS As String = "1003"
    Public Const TB14_VALOR_VENTA_OPE_GRATUITAS As String = "1004"
    Public Const TB14_VALOR_VENTA_SUBTOTAL As String = "1005"
    Public Const TB14_VALOR_PERCEPCIONES As String = "2001"
    Public Const TB14_VALOR_RETENCIONES As String = "2002"
    Public Const TB14_VALOR_DETRACCIONES As String = "2003"
    Public Const TB14_VALOR_BONIFICACIONES As String = "2004"
    Public Const TB14_VALOR_TOTAL_DESCUENTOS As String = "2005"
    Public Const TB14_VALOR_FISE As String = "3001"
    ''
    ''TABLA 15
    Public Const TB15_MONTO_LETRAS As String = "1000"
    Public Const TB15_TRANSF_GRATUITA As String = "1002"

    ''TABLA 16
    Public Const TB16_TIPO_PRECIO_INC_IGV As String = "01"
    Public Const TB16_TIPO_PRECIO_NO_ONEROSAS As String = "02"

    Public Const COL_NRO_ORDEN_ITEM As Integer = 0
    Public Const COL_UNIDAD_DE_MEDIDA_UN As Integer = 1
    Public Const COL_CANTIDAD_ITEM As Integer = 2
    Public Const COL_SUBTOTAL_ITEM_SIN_IGV As Integer = 3
    Public Const COL_PU_ITEM_INC_IGV As Integer = 4
    Public Const COL_SUBTOTAL_ITEM_IGV As Integer = 5
    Public Const COL_TIPO_AFECTACION_IGV_TB07 As Integer = 6
    Public Const COL_SUBTOTAL_ITEM_ISC As Integer = 7
    Public Const COL_TIPO_SISTEMA_ISC_TB08 As Integer = 8
    Public Const COL_DESCRIPCION_DEL_ITEM As Integer = 9
    Public Const COL_CODIGO_DEL_ITEM As Integer = 10
    Public Const COL_VALOR_UNITARIO_ITEM As Integer = 11

    Public Const COL_PERC_TIPO_DOC_REF As Integer = 1
    Public Const COL_PERC_NRO_DOC_REF As Integer = 2
    Public Const COL_PERC_FECHA_DOC_REF As Integer = 3
    Public Const COL_PERC_MONEDA_DOC_REF As Integer = 4
    Public Const COL_PERC_MONTO_DOC_REF As Integer = 5
    Public Const COL_PERC_ID_COBRO_DOC_REF As Integer = 6
    Public Const COL_PERC_MONEDA_COBRO_DOC_REF As Integer = 7
    Public Const COL_PERC_MONTO_COBRO_DOC_REF As Integer = 8
    Public Const COL_PERC_FECHA_COBRO_DOC_REF As Integer = 9
    Public Const COL_PERC_MONTO_PERCEPCION_DOC_REF As Integer = 10
    Public Const COL_PERC_FECHA_PERCEPCION_DOC_REF As Integer = 11
    Public Const COL_PERC_TOTAL_COBRADO_INCLUIDA_PERCEPCION As Integer = 12


    Public Const COL_BAJA_ID As Integer = 1
    Public Const COL_BAJA_TIPO_DOC As Integer = 2
    Public Const COL_BAJA_SERIE_DOC As Integer = 3
    Public Const COL_BAJA_NUMERO_DOCUMENTO As Integer = 4
    Public Const COL_BAJA_MOTIVO As Integer = 5

    'Public Const COL_RC_FILA As Integer = 1
    Public Const COL_RC_TIPO_DOC As Integer = 1
    Public Const COL_RC_SERIE As Integer = 2
    Public Const COL_RC_INICIO As Integer = 3
    Public Const COL_RC_FIN As Integer = 4
    Public Const COL_RC_VTAS_GRAVADA As Integer = 5
    Public Const COL_RC_VTAS_EXONERADAS As Integer = 6
    Public Const COL_VTAS_INAFECTAS As Integer = 7
    Public Const COL_VTAS_OTROS_CARGOS As Integer = 8
    Public Const COL_VTAS_ISC As Integer = 9
    Public Const COL_VTAS_IGV As Integer = 10
    Public Const COL_VTAS_OTROS_TRIBUTOS As Integer = 11
    Public Const COL_VTAS_TOTAL As Integer = 12

    Function UltimoDiaMes(ByVal fecha As Date) As Date
        UltimoDiaMes = DateAdd("d", -1, DateAdd("m", 1, DateSerial(Year(fecha), Month(fecha), 1)))
    End Function

    Sub node(ByVal nodo As String, ByVal valor As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement(nodo)
        writer.WriteString(valor)
        writer.WriteEndElement()
        ''writer.WriteEndElement()
    End Sub

    Function QUITAR_COMAS(ByVal VALOR As String) As Double
        QUITAR_COMAS = Replace(VALOR, ",", "")
    End Function
    Function FORMATO_MONTO(ByVal VALOR As Double) As String
        FORMATO_MONTO = Format(Math.Round(VALOR, 2), "#0.00")
    End Function
    Function FORMATO_MONTO_COMA(ByVal VALOR As Double) As String
        FORMATO_MONTO_COMA = Format(VALOR, "###,###,###,##0.00")
    End Function
    Function FORMATO_PU(ByVal VALOR As Double) As String
        FORMATO_PU = Format(VALOR, "#0.00000")
    End Function

    Function XML_VALOR(ByVal FILE_XML As String, ByVal BUSCAR As String, POS As Integer) As String
        Dim Xml = New XmlDocument()
        Dim NodeList As XmlNodeList
        Dim name As String = ""
        Dim FILAS As Integer = 0
        ''
        Xml.Load(FILE_XML)
        Dim xmlnsManager = New System.Xml.XmlNamespaceManager(Xml.NameTable)
        xmlnsManager.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        xmlnsManager.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
        ''
        'NodeList = Xml.SelectNodes("//cac:Response/cbc:ReferenceID", xmlnsManager)
        NodeList = Xml.SelectNodes(BUSCAR, xmlnsManager)
        For Each node1 As XmlNode In NodeList
            If FILAS = POS Then
                name = node1.InnerText
                Exit For
            End If
            FILAS = FILAS + 1
        Next
        XML_VALOR = name
    End Function
End Module
