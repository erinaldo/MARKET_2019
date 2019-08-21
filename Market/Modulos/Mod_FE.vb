Imports Hash

Module Mod_FE
    Function FIRMAR(ByVal COD_DOC As String, NRODOC As String, ByVal TDOC As String) As String
        Dim OBJFE As New ClsHash
        Dim OBJVENTA As New ClsVenta
        Dim OBJCONFIG As New ClsConfig
        OBJCONFIG.LISTAR_CONFIG_V2()

        'Dim CN_NET1 As New SqlConnection
        'CN_NET1.ConnectionString = CAD_CON
        'CN_NET1.Open()
        Dim MON As String
        Dim DT As DataTable
        Dim OTABLA As DataTable
        ''
        Dim OFILADET As DataRow
        DT = LLENAR_DATA_TABLE("EXEC IAM_GENERAR_TXT '" & COD_DOC & "','" & NRODOC & "'", CN_NET)
        If DT.Rows.Count = 0 Then GoTo SALIR
        For Each OFILADET In DT.Rows
            If OFILADET.Item("MONEDA") = "S" Then MON = "SOLES" Else MON = "DOLARES AMERICANOS"
            With OBJFE
                .RUTA = OBJCONFIG.Config_Carpeta_Tmp
                .CODIGO_ESTABLECIMIENTO = OBJCONFIG.Config_CodEstablecimiento
                .TIPO_OPERACION_CAT_51 = OBJCONFIG.Config_Catalog51
                .HORA_DOC = OFILADET.Item("HORAVENTA")
                .VALOR_PORC_DSCTO = "0"

                .MONTO_VTAS_GRABADAS = CStr(OFILADET.Item("AMO1BRUTO"))
                .MONTO_VTAS_INAFECTAS = "0"
                .MONTO_VTAS_EXONERADAS = "0"
                .MONTO_VTAS_OPER_GRATUITAS = "0"
                .MONTO_VTAS_SUBTOTAL = CStr(OFILADET.Item("AMO1BRUTO"))
                .MONTO_VTAS_PERCEPCIONES = "0"
                .MONTO_VTAS_RETENCIONES = "0"
                .MONTO_VTAS_DETRACCIONES = "0"
                .MONTO_VTAS_BONIFICACIONES = "0"
                .MONTO_VTAS_DESCUENTOS = "0"
                .MONTO_VTAS_FISE = "0"
                .MONTO_LETRAS = ImprimeTotalLetras(OFILADET.Item("AMO1TOFA"), MON)
                .NRO_DOC = TDOC + Strings.Right(Trim(OFILADET.Item("NRO_FACTURA")), 12)
                .FECHA_DOC = Format(OFILADET.Item("FECHA"), "yyyy-MM-dd")
                .MONEDA_DOC = OFILADET.Item("MONEDA")
                .NRO_GUIA_DE_REMISION = ""

                If TDOC = "B" Then
                    .NRO_DOC_IDENTIDAD_CLIENTE = OFILADET.Item("DNI")
                    .TIPO_IDENTIDAD_CLIENTE = "1" ' PORQUE ES RUC
                Else
                    If NULO(OFILADET.Item("ACLINRUC"), "S") = "" Then
                        .NRO_DOC_IDENTIDAD_CLIENTE = OFILADET.Item("DNI")
                        .TIPO_IDENTIDAD_CLIENTE = "1" ' PORQUE ES RUC
                    Else
                        .NRO_DOC_IDENTIDAD_CLIENTE = OFILADET.Item("ACLINRUC")
                        .TIPO_IDENTIDAD_CLIENTE = "6" ' PORQUE ES RUC
                    End If
                End If
                .NOMBRE_DEL_CLIENTE = OFILADET.Item("ACLIDESC")
                ''DATOS FACTURA IMPRESA
                .DIRECCION_DEL_CLIENTE = NULO(OFILADET.Item("DIR_F"), "S")
                .DIRECCION_DE_ENTREGA = ""
                .CODIGO_DEL_CLIENTE = OFILADET.Item("AMO1CLIE")
                .CODIGO_DEL_VENDEDOR = OFILADET.Item("AMO1VEND")
                .CONDICION_DE_PAGO = OFILADET.Item("AFPADESC")
                .NUMERO_ORDEN_DE_COMPRA = ""
                .TRANSPORTISTA = ""
                .NOMBRE_DEL_CHOFER = ""
                .BREVETE_DEL_CHOFER = ""
                .PLACA_DEL_CAMION = OFILADET.Item("AMO1TPLAC")
                .MARCA_DEL_CAMION = ""
                .CAPACIDAD_DEL_CAMION = ""
                .SCOP = ""
                ''
                .MONTO_DEL_IGV = CStr(OFILADET.Item("AMO1IGV"))
                .MONTO_DEL_ISC = "0"
                .TOTAL_FACTURA = CStr(OFILADET.Item("AMO1TOFA"))
                .PORCENTAJE_IGV = CStr(OFILADET.Item("VAL_IGV"))

                .PERC_TC = NULO(OFILADET.Item("TC_VENTA"), "N")

                .PERC_MONTO_TOTAL_A_COBRAR = "0"
                .PERC_MONTO_TOTAL_PERCEPCION = "0"
                ESTADO_MONTO = NULO(OFILADET.Item("AMO1TOFA"), "N")
                .PERC_REGIMEN_DE_PERCEPCION = "0"
                .PERC_TASA_DE_PERCEPCION = "0"
                .TRANSP_PLACA = ""

                ''
                Dim F As Integer = 0
                Dim PU_INCIGV As Double
                Dim IGV_ITEM As Double
                OTABLA = LLENAR_DATA_TABLE("EXEC IAM_GENERAR_DETALLE_TXT '" & COD_DOC & "','" & NRODOC & "'", CN_NET)
                Dim OFILA As DataRow
                OFILA = OTABLA.Rows(0)
                .NRO_DE_ITEMS = CStr(OTABLA.Rows.Count)
                For Each OFILA In OTABLA.Rows
                    .DET_NRO_ORDEN_ITEM(F) = CStr(F)
                    .DET_UNIDAD_DE_MEDIDA_UNECE_rec_20(F) = OFILA.Item("AUMESUNAT")
                    .DET_CANTIDAD_ITEM(F) = CStr(OFILA.Item("AMO2CANTI"))
                    .DET_SUBTOTAL_ITEM_SIN_IGV(F) = CStr(OFILA.Item("AMO2STOT"))
                    PU_INCIGV = OFILA.Item("AMO2PREC") * (1 + (OFILADET.Item("VAL_IGV") / 100))
                    .DET_PU_ITEM_INC_IGV(F) = CStr(Math.Round(PU_INCIGV, 5))
                    IGV_ITEM = OFILA.Item("AMO2STOT") * (OFILADET.Item("VAL_IGV") / 100)
                    .DET_SUBTOTAL_ITEM_IGV(F) = CStr(Math.Round(IGV_ITEM, 2))
                    .DET_TIPO_AFECTACION_IGV_TB07(F) = "10"
                    .DET_SUBTOTAL_ITEM_ISC(F) = "0"
                    .DET_TIPO_SISTEMA_CALCULO_ISC_TB08(F) = "0"
                    .DET_DESCRIPCION_DEL_ITEM(F) = OFILA.Item("AARTDESC")

                    .DET_CODIGO_DEL_ITEM(F) = OFILA.Item("AMO2ART")
                    .DET_VALOR_UNITARIO_ITEM(F) = CStr(OFILA.Item("AMO2PREC"))

                    .DET_COD_SUNAT_ITEM(F) = OFILA.Item("COD_SUNAT")
                    .DET_PORC_PERCEP_ITEM(F) = "0"
                    .DET_MONTO_PERC_INC_IGV_ITEM(F) = "0"

                    F = F + 1
                Next
                OTABLA.Dispose()
                ''
                Dim NOMB_FILE As String
                If TDOC = "F" Then
                    NOMB_FILE = OBJCONFIG.RucConfig + "-" + "01" + "-" + "F" + Strings.Right(Trim(OFILADET.Item("NRO_FACTURA")), 12) + ".TXT"
                End If
                If TDOC = "B" Then
                    NOMB_FILE = OBJCONFIG.RucConfig + "-" + "03" + "-" + "B" + Strings.Right(Trim(OFILADET.Item("NRO_FACTURA")), 12) + ".TXT"
                End If
                .RUC_EMISOR = OBJCONFIG.RucConfig
                .RAZON_SOCIAL_EMISOR = OBJCONFIG.DescConfig
                .RUTA_CERT = OBJCONFIG.Config_Ruta_Firma_Digital
                .ID_FIRMA_DIGITAL = "IDSignSP"
                .ID_PARTE_FIRMANTE = OBJCONFIG.RucConfig
                .NAME_PARTE_FIRMANTE = OBJCONFIG.DescConfig
                .NOMBRE_COMERCIAL = OBJCONFIG.DescConfig
                .URI = OBJCONFIG.Config_Uri

                .COD_UBIGEO_EMISOR = OBJCONFIG.Config_Ubigeo
                .DIRECCION_EMISOR = OBJCONFIG.DirConfig
                .URBANIZACION_EMISOR = OBJCONFIG.Config_Urbanizacion
                .DEPARTAMENTO_EMISOR = OBJCONFIG.Config_Departamento
                .PROVINCIA_EMISOR = OBJCONFIG.Config_Provincia
                .DISTRITO_EMISOR = OBJCONFIG.Config_Distrito
                .COD_PAIS_EMISOR = "PE"
                CARPETA_TMP = OBJCONFIG.Config_Carpeta_Tmp
                FILE_JPG = NOMB_FILE
                FE_WEB = OBJCONFIG.Config_Web
                .GENERAR(OBJCONFIG.Config_Carpeta_Tmp + NOMB_FILE, OBJCONFIG.Config_Psw_Firma_Digital, NOMB_FILE)
                FIRMAR = .DIGESTVALUE
            End With
        Next
        ''

SALIR:
        DT = Nothing
        OTABLA = Nothing

    End Function
End Module
