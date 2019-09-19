Module ModImpresion
    ''
    Public FILE_JPG As String
    Public CARPETA_TMP As String
    Public FE_WEB As String
    Public ORIG As String
    ''
    Dim Fuente As New System.Drawing.Font("Arial", 8, FontStyle.Regular)
    Dim ANCHO As Integer = 65
    ''
    ''
    Public SALTAR_PAG As Printing.PrintPageEventArgs
    Public IAM_PRINT As String
    Dim Y_INI As Integer = 5
    Dim X_INI As Integer = 2
    ''

    Public GRAFICO As System.Drawing.Graphics
    Public Sub IMPRIMIR(COD_DOC As String, REIMPRIME As Integer, STRESTADO As String, NRODOC As String,
                        CLIENTE_DESC As String, CLIENTE_RUC As String, CLIENTE_DIRECCION As String,
                        DESCUENTO As String, SUBTOTAL As String, IGV As String, TOTAL As String, FECHA_DOC As Date, HORA As DateTime,
                        COD_HASH As String, Optional GRATUITA As Boolean = False)
        Dim OBJPTOVTA As New ClsPtoVta
        Try
            'Dim Fuente As New System.Drawing.Font("Arial", 8)
            'Dim Grafico As System.Drawing.Graphics = e.Graphics
            Dim PORTIMP As String
            Dim TOTG As Double = 0
            Dim DSCTO As Boolean = False

            ''AVERIGUAR PUERTO DE IMPRESION
            PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP(COD_DOC)
            If PORTIMP = "" Then MsgBox("punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            ''
            ObtenerConfiguracionTicket(1)
            ''
            Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")

            Dim LHead1 As String, LHead2 As String, LHead3 As String, LHead4 As String, LHead5 As String, LHead6 As String, LHead7 As String, LHead8 As String, LHead9 As String, LHead10 As String
            Dim LFoot1 As String, LFoot2 As String, LFoot3 As String, LFoot4 As String, LFoot5 As String, LFoot6 As String, LFoot7 As String, LFoot8 As String, LFoot9 As String, LFoot10 As String


            PObtener_FechaServidor()

            ' Imprimir la Cabecera
            Dim IntAnchoTicket = 39
            LHead1 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD1)), Trim(GHEAD1))
            LHead2 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD2)), Trim(GHEAD2))
            LHead3 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD3)), Trim(GHEAD3))
            LHead4 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD4)), Trim(GHEAD4))
            LHead5 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD5)), Trim(GHEAD5))
            LHead6 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD6)), Trim(GHEAD6))
            LHead7 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD7)), Trim(GHEAD7))
            LHead8 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD8)), Trim(GHEAD8))
            LHead9 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD9)), Trim(GHEAD9))
            LHead10 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD10)), Trim(GHEAD10))

            '---------------------------------------------------------------------------------------------
            'ABRIR GAVETA
            If REIMPRIME = 0 Then
                'Call abrir_gaveta()
                'file.WriteLine(Chr(27) + "p" + Chr(0) + Chr(25) + Chr(250))
                file.WriteLine(Chr(27) + Chr(112) + Chr(0) + Chr(27) + Chr(112) + Chr(0))

            End If

            If Trim(STRESTADO) <> Nothing Then
                Dim CAB_ANULADO As String
                CAB_ANULADO = "***************************************"
                file.WriteLine(CAB_ANULADO)
                CAB_ANULADO = "*********** TICKET ANULADO ************"
                file.WriteLine(CAB_ANULADO)
                CAB_ANULADO = "***************************************"
                file.WriteLine(CAB_ANULADO)
                file.WriteLine("")
            End If


            If Trim(LHead1) <> Nothing Then file.WriteLine(LHead1)
            If Trim(LHead2) <> Nothing Then file.WriteLine(LHead2)
            If Trim(LHead3) <> Nothing Then file.WriteLine(LHead3)
            If Trim(LHead4) <> Nothing Then file.WriteLine(LHead4)
            If Trim(LHead5) <> Nothing Then file.WriteLine(LHead5)
            If Trim(LHead6) <> Nothing Then file.WriteLine(LHead6)
            If Trim(LHead7) <> Nothing Then file.WriteLine(LHead7)
            If Trim(LHead8) <> Nothing Then file.WriteLine(LHead8)
            If Trim(LHead9) <> Nothing Then file.WriteLine(LHead9)
            If Trim(LHead10) <> Nothing Then file.WriteLine(LHead10)

            'Imprimir la Linea
            Dim LLinea1 As String
            LLinea1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea1)), Trim(GstrLinea1))

            If Trim(LLinea1) <> Nothing Then file.WriteLine(LLinea1)

            'If REIMPRIME = 1 Then
            '    GstrSimbMonedaBase = GstrSimbMonedaBase
            '    GstrSimbMonedaExtr = GstrSimbMonedaExtr
            'End If
            ''TIPO DE DOCUMENTO
            Dim StrTipoTicket As String
            Dim TDOC As String = BUSCAR_CAMPO("TIPO_DOC", "DESC_DOC", "COD_DOC", COD_DOC, CN_NET)
            If SISTEMA_ASPNET = "S" Or SISTEMA_ITALO = "S" Then
                If Strings.Left(TDOC, 1) = "B" Then
                    StrTipoTicket = "***BOLETA DE VENTA ELECTRONICA ***"
                Else
                    StrTipoTicket = "***FACTURA DE VENTA ELECTRONICA ***"
                End If
            Else
                If Strings.Left(TDOC, 1) = "B" Then
                    StrTipoTicket = "*** B O L E T A ***"
                Else
                    StrTipoTicket = "*** F A C T U R A ***"
                End If
            End If
            ''
            ''If Strings.Right(STRTIPODOC.Trim, 5) = "OTRO." Then
            ''    StrTipoTicket = "*** O T R O ***"
            ''End If

            ''
            StrTipoTicket = Alineacion("C", IntAnchoTicket, Len(StrTipoTicket), StrTipoTicket)
            file.WriteLine(StrTipoTicket)
            file.WriteLine("")

            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = Alineacion("I", IntAnchoTicket - 10, Len("Maq.Regist.No: " & GStrMaquinaReg), "Maq.Regist.No: " & GStrMaquinaReg) & Format(FECHA_DOC, "dd/MM/yyyy")
            file.WriteLine(strMaquinaReg)

            ' Imprimir el Número del Ticket

            Dim StrNumeroTicket As String
            If SISTEMA_ASPNET = "S" Or SISTEMA_ITALO = "S" Then
                StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(Strings.Left(TDOC, 1) & FormatoTicket(NRODOC)), Strings.Left(TDOC, 1) & FormatoTicket(NRODOC)) & Format(HORA, "HH:mm:ss")
                'objstream.WriteLine(StrNumeroTicket)
            Else
                'StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(strTipoDoc & ":" & FormatoTicket(StrNumerodeTicket)), strTipoDoc & ": " & FormatoTicket(StrNumerodeTicket)) & Format(DatHoraImpresion, "HH:mm:ss")
                'objstream.WriteLine(StrNumeroTicket)
                Dim DOCU As String = IIf(Strings.Left(TDOC, 1) = "B", " BOL. ", " FACT.")
                Dim STRTIPODOC = "Ticket No" & DOCU
                StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(STRTIPODOC & ":" & (NRODOC)), STRTIPODOC & ": " & (NRODOC)) & Format(HORA, "HH:mm:ss")
            End If
            'Dim DOCU As String = IIf(Strings.Left(TDOC, 1) = "B", " BOL. ", " FACT.")
            'Dim STRTIPODOC = "Ticket No" & DOCU
            'StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(STRTIPODOC & ":" & (NRODOC)), STRTIPODOC & ": " & (NRODOC)) & Format(HORA, "HH:mm:ss")
            file.WriteLine(StrNumeroTicket)

            ' Imprimir los Datos del Cliente
            If Trim(CLIENTE_DESC) <> Nothing Then
                Dim LStrRazonSocial As String
                LStrRazonSocial = Alineacion("I", IntAnchoTicket, Len("Raz.Soc:" & CLIENTE_DESC.Trim), "NOMBRE :" & CLIENTE_DESC.Trim)
                file.WriteLine(LStrRazonSocial)
            End If

            If Trim(CLIENTE_RUC) <> Nothing Then
                Dim LStrRUC As String
                LStrRUC = Alineacion("I", IntAnchoTicket, Len("RUC    :" & CLIENTE_RUC.Trim), "RUC    :" & CLIENTE_RUC.Trim)
                file.WriteLine(LStrRUC)
            End If

            If Trim(CLIENTE_DIRECCION) <> Nothing Then
                Dim LstrDireccion As String
                LstrDireccion = Alineacion("I", IntAnchoTicket, Len("DIRECC.:" & CLIENTE_DIRECCION.Trim), "DIRECC :" & CLIENTE_DIRECCION.Trim)
                file.WriteLine(LstrDireccion)
            End If


            ' Imprimir Seguna Línea

            Dim LLinea2 As String
            LLinea2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea2)), Trim(GstrLinea2))
            If Trim(LLinea2) <> Nothing Then
                file.WriteLine(LLinea2)
            End If
            ''**
            TOTG = 0
            DSCTO = False
            ''**
            ' Imprimir el Detalle
            Dim RSDET As SqlDataReader 'New ADODB.Recordset
            'Dim SQL As String = "EXEC VENTA_MOSTRAR_DETALLE '" & Me.COMBO_DOC.SelectedValue & "'," & ArmaNumero(Me.TXT_NRODOC.Text) & ""
            Dim OCOMANDO As New SqlCommand("EXEC VENTA_MOSTRAR_DETALLE '" & COD_DOC & "'," & NRODOC & "", CN_NET)
            CN_NET.Open()
            RSDET = OCOMANDO.ExecuteReader
            While RSDET.Read
                Dim LstrProducto As String
                Dim LstrDescripcion As String

                'RSDET.MoveFirst()

                'Do While Not RSDET.EOF

                ' El precio del Producto se Muestra a la Moneda Levantada (MonedaRelacionada)
                ' Y ase Graba en la Moneda Solicitada

                LstrProducto = Alineacion("I", 15, Len(Trim(RSDET("CODIGO"))), Trim(RSDET("CODIGO"))) &
                               Alineacion("I", 7, Len(Trim(RSDET("MEDIDA"))), Trim(RSDET("MEDIDA"))) &
                               Alineacion("I", 11, Len(GFormatodeNumero(RSDET("CANTIDAD"), 4) & "x"), (GFormatodeNumero(RSDET("CANTIDAD"), 4)) & "x") &
                               Alineacion("D", IntAnchoTicket - 10 - 5 - 11 - 8, Len(GFormatodeNumero(RSDET("PU"), 2)), GFormatodeNumero(RSDET("PU"), 2))

                file.WriteLine(LstrProducto)

                'If StrCodMoneda = GstrCodMonedaBase Then
                LstrDescripcion = Alineacion("I", 30, Len(Trim(RSDET("DESCRIPCION"))), Trim(RSDET("DESCRIPCION"))) &
                                  Alineacion("D", IntAnchoTicket - 30, Len(GFormatodeNumero(RSDET("TOTALSD"), 2)), GFormatodeNumero(RSDET("TOTALSD"), 2))

                TOTG = TOTG + RSDET("TOTALSD")
                If RSDET("DSCTO_PORC") <> 0 Or RSDET("DSCTO_MONTO") <> 0 Then
                    DSCTO = True
                End If
                file.WriteLine(LstrDescripcion)

                'RSDET.MoveNext()

            End While
            RSDET.Close()

            ' Imprimir la Línea 3
            Dim LLinea3 As String
            LLinea3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea3)), Trim(GstrLinea3))

            If Trim(LLinea3) <> Nothing Then
                file.WriteLine(LLinea3)
            End If

            ' Imprimir Totales
            Dim GstrSimbMonedaBase As String = "S/ "
            Dim GstrSimbMonedaExtr As String = "US$ "
            If CFG_MONVENTA = "D" Then
                GstrSimbMonedaBase = "US$ "
                GstrSimbMonedaExtr = "S/ "
            End If
            ''**
            ''IMPRIMO DESCUENTO
            ''If DSCTO = True Then
            Dim StrTotalSD As String
            StrTotalSD = Alineacion("I", 17, Len("**** DESCUENTO   "), "**** DESCUENTO   ")
            StrTotalSD = StrTotalSD & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
            StrTotalSD = StrTotalSD & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(DESCUENTO, 2)), GFormatodeNumero(DESCUENTO, 2))
            file.WriteLine(StrTotalSD)
            If Trim(LLinea3) <> Nothing Then
                file.WriteLine(LLinea3)
            End If
            ''End If
            ''**
            If Trim(CLIENTE_RUC) <> Nothing Then
                Dim StrValoventa As String
                StrValoventa = Alineacion("I", 17, Len("**** Valor Venta "), "**** Valor Venta ")

                'If StrCodMoneda = GstrCodMonedaBase Then
                StrValoventa = StrValoventa & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                StrValoventa = StrValoventa & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(SUBTOTAL, 2)), GFormatodeNumero(SUBTOTAL, 2))
                'Else
                'StrValoventa = StrValoventa & Alineacion("I", 7, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
                'StrValoventa = StrValoventa & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(DblValorVentaExt, Gdeciresu)), GFormatodeNumero(DblValorVentaExt, Gdeciresu))
                'End If

                file.WriteLine(StrValoventa)

                '    If DblNoAfectoBase <> 0 Then

                '        Dim strNoAfecto As String
                '        strNoAfecto = Alineacion("I", 17, Len("**** No Afecto   "), "**** No Afecto   ")

                '        If StrCodMoneda = GstrCodMonedaBase Then
                '            strNoAfecto = strNoAfecto & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                '            strNoAfecto = strNoAfecto & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(DblNoAfectoBase, Gdeciresu)), GFormatodeNumero(DblNoAfectoBase, Gdeciresu))
                '        Else
                '            'strNoAfecto = strNoAfecto & Alineacion("I", 7, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
                '            'strNoAfecto = strNoAfecto & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(DblNoAfectoExt, Gdeciresu)), GFormatodeNumero(DblNoAfectoExt, Gdeciresu))
                '        End If
                'Print #1, strNoAfecto
                '    End If

                Dim StrImpuesto As String
                StrImpuesto = Alineacion("I", 17, Len("**** IGV         "), "**** IGV         ")

                'If StrCodMoneda = GstrCodMonedaBase Then
                StrImpuesto = StrImpuesto & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                StrImpuesto = StrImpuesto & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(IGV, 2)), GFormatodeNumero(IGV, 2))
                'Else
                '   StrImpuesto = StrImpuesto & Alineacion("I", 7, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
                '  StrImpuesto = StrImpuesto & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(dblIGVEXT, Gdeciresu)), GFormatodeNumero(dblIGVEXT, Gdeciresu))
                'End If
                file.WriteLine(StrImpuesto)
            End If

            Dim StrTotal As String
            StrTotal = Alineacion("I", 17, Len("**** TOTAL       "), "**** TOTAL       ")
            'If StrCodMoneda = GstrCodMonedaBase Then
            StrTotal = StrTotal & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
            StrTotal = StrTotal & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(TOTAL, 2)), GFormatodeNumero(TOTAL, 2))
            'Else
            'StrTotal = StrTotal & Alineacion("I", 7, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
            'StrTotal = StrTotal & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(DblTotalExt, Gdeciresu)), GFormatodeNumero(DblTotalExt, Gdeciresu))
            'End If
            file.WriteLine(StrTotal)

            ' Parte que Imprimie el Tipo de Pago
            Dim OBJPAGOS As New ClsPagos
            Dim StrTipoPagoImp As String
            Dim RSTARJETA As SqlDataReader 'New ADODB.Recordset
            RSTARJETA = OBJPAGOS.MOSTRAR_TARJETA_DETALLE(COD_DOC, NRODOC)
            'If Not RSTARJETA.EOF Then  'HAY PAGO CON TARJETAS
            While RSTARJETA.Read
                StrTipoPagoImp = Alineacion("I", 17, Len("TARJETA           "), "TARJETA          ")
                file.WriteLine(StrTipoPagoImp)
                ' Se Tiene que Imprimir el Número de la Tarjeta
                Dim LSTR_NOMBRET As String
                Dim LSTR_NUMEROT As String
                Dim LSTR_MONEDA As String
                Dim LDBL_PENT As Double
                'Dim LDBL_USDT As Double
                Dim SIMBOLO As String

                'Do While Not RSTARJETA.EOF
                LSTR_MONEDA = RSTARJETA("MONEDA")
                If Strings.Left(LSTR_MONEDA, 1) = "S" Then SIMBOLO = "S/ " Else SIMBOLO = "US$ "
                LSTR_NOMBRET = Trim(RSTARJETA("TARJETA"))
                LSTR_NUMEROT = Trim(RSTARJETA("NUMERO"))
                LDBL_PENT = RSTARJETA("MONTO")
                'LDBL_USDT = RSTARJETAS!ATMPIMPO
                StrTipoPagoImp = Alineacion("I", 11, Len(LSTR_NOMBRET), LSTR_NOMBRET)
                StrTipoPagoImp = StrTipoPagoImp & Alineacion("I", 16, Len(LSTR_NUMEROT), LSTR_NUMEROT)

                'If LSTR_MONEDA = GstrCodMonedaBase Then
                StrTipoPagoImp = StrTipoPagoImp & Alineacion("I", 4, Len(SIMBOLO & ":"), SIMBOLO & ":")
                StrTipoPagoImp = StrTipoPagoImp & Alineacion("D", 8, Len(GFormatodeNumero(LDBL_PENT, 2)), GFormatodeNumero(LDBL_PENT, 2))
                'Else
                'StrTipoPagoImp = StrTipoPagoImp & Alineacion("I", 4, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
                'StrTipoPagoImp = StrTipoPagoImp & Alineacion("D", 8, Len(GFormatodeNumero(LDBL_USDT, Gdeciresu)), GFormatodeNumero(LDBL_USDT, Gdeciresu))
                'End If
                file.WriteLine(StrTipoPagoImp)
                'RSTARJETA.MoveNext()
                '   Loop
            End While
            RSTARJETA.Close()

            ' Imprimir Efectivo Soles y dolares
            Dim OBJVENTAS As New ClsVenta
            Dim Strefectivopagado As String
            Dim RSPAGO As SqlDataReader 'New ADODB.Recordset
            RSPAGO = OBJVENTAS.MOSTRAR_CABECERA(COD_DOC, NRODOC)
            'If RSPAGO.HasRows = True Then
            While RSPAGO.Read
                If RSPAGO("PAGOS_VENTA") <> 0 Or RSPAGO("PAGOD_VENTA") <> 0 Then
                    Strefectivopagado = Alineacion("I", 10, Len("EFECTIVO: "), "EFECTIVO: ")
                    If RSPAGO("PAGOS_VENTA") > 0 Then
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 3, Len("S/ :"), "S/ :")
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 10, Len(GFormatodeNumero(Str(RSPAGO("PAGOS_VENTA")), 2)), GFormatodeNumero(Str(RSPAGO("PAGOS_VENTA")), 2))
                    End If
                    If RSPAGO("PAGOD_VENTA") > 0 Then
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 3, Len("US$ :"), "US$ :")
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 10, Len(GFormatodeNumero(Str(RSPAGO("PAGOD_VENTA")), 2)), GFormatodeNumero(Str(RSPAGO("PAGOD_VENTA")), 2))
                    End If
                    file.WriteLine(Strefectivopagado)
                End If

                ' Imprimir Vuelto Soles y dolares
                Dim Strvuelto As String
                If RSPAGO("VUELTO_VENTA") <> 0 Then
                    Strvuelto = Alineacion("I", 10, Len("VUELTO: "), "VUELTO: ")
                    If RSPAGO("VUELTO_VENTA") > 0 Then
                        Strvuelto = Strvuelto & Alineacion("I", 3, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                        Strvuelto = Strvuelto & Alineacion("I", 10, Len(GFormatodeNumero(Str(RSPAGO("VUELTO_VENTA")), 2)), GFormatodeNumero(Str(RSPAGO("VUELTO_VENTA")), 2))
                    End If
                    'If DBLRETURNUSD > 0 Then
                    ' Strvuelto = Strvuelto & Alineacion("I", 3, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
                    ' Strvuelto = Strvuelto & Alineacion("I", 10, Len(GFormatodeNumero(Str(DBLRETURNUSD), Gdeciresu)), GFormatodeNumero(Str(DBLRETURNUSD), Gdeciresu))
                    'End If
                    file.WriteLine(Strvuelto)
                End If



                ' Imprimir Tipo de cambio y Cajero
                Dim StrDatosVendedor As String
                StrDatosVendedor = Alineacion("D", 3, Len("TC:"), "TC:")
                StrDatosVendedor = StrDatosVendedor & Alineacion("I", 12, Len(RSPAGO("CAMBIO_VENTA")), RSPAGO("CAMBIO_VENTA"))
                StrDatosVendedor = StrDatosVendedor & Alineacion("D", 10, Len("CAJERO:"), "CAJERO:")
                StrDatosVendedor = StrDatosVendedor & Alineacion("I", IntAnchoTicket - 6 - 3 - 8, Len(RSPAGO("COD_USER")), RSPAGO("COD_USER"))

                file.WriteLine(StrDatosVendedor)
            End While
            RSPAGO.Close()
            CN_NET.Close()

            If GRATUITA = True Then
                file.WriteLine("")
                Dim STRGRATIS As String
                STRGRATIS = Alineacion("C", IntAnchoTicket - 3, Len("TRANSFERENCIA A TITULO GRATUITO"), "TRANSFERENCIA A TITULO GRATUITO")
                file.WriteLine(STRGRATIS)
            End If
            ''HASH
            If SISTEMA_ASPNET = "S" Or SISTEMA_ITALO = "S" Then
                Dim StrHASH As String
                file.WriteLine("")
                StrHASH = Alineacion("C", IntAnchoTicket, Len(COD_HASH), COD_HASH)
                file.WriteLine(StrHASH)
                file.WriteLine("")
                ''  file.WriteLine("")
            End If


            ' Imprimir la Línea 4
            Dim LLinea4 As String
            LLinea4 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea4)), Trim(GstrLinea4))
            If Trim(LLinea4) <> Nothing Then
                file.WriteLine(LLinea4)
            End If

            ' Imprimir Pie de Página

            LFoot1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT1)), Trim(GstrFOOT1))
            LFoot2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT2)), Trim(GstrFOOT2))
            If REIMPRIME = 1 Then
                LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim("REIMPRESION")), Trim("REIMPRESION"))
            End If
            If REIMPRIME = 0 Then
                LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT3)), Trim(GstrFOOT3))
            End If
            If REIMPRIME = 2 Then
                LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim("ANULADO")), Trim("ANULADO"))
            End If
            LFoot4 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT4)), Trim(GstrFOOT4))
            LFoot5 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT5)), Trim(GstrFOOT5))
            LFoot6 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT6)), Trim(GstrFOOT6))
            LFoot7 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT7)), Trim(GstrFOOT7))
            LFoot8 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT8)), Trim(GstrFOOT8))
            LFoot9 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT9)), Trim(GstrFOOT9))
            LFoot10 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT10)), Trim(GstrFOOT10))

            If Trim(LFoot1) <> Nothing Then
                file.WriteLine(LFoot1)
            End If
            If Trim(LFoot2) <> Nothing Then
                file.WriteLine(LFoot2)
            End If
            If Trim(LFoot3) <> Nothing Then
                file.WriteLine(LFoot3)
            End If
            If Trim(LFoot4) <> Nothing Then
                file.WriteLine(LFoot4)
            End If
            If Trim(LFoot5) <> Nothing Then
                file.WriteLine(LFoot5)
            End If
            If Trim(LFoot6) <> Nothing Then
                file.WriteLine(LFoot6)
            End If
            If Trim(LFoot7) <> Nothing Then
                file.WriteLine(LFoot7)
            End If
            If Trim(LFoot8) <> Nothing Then
                file.WriteLine(LFoot8)
            End If
            If Trim(LFoot9) <> Nothing Then
                file.WriteLine(LFoot9)
            End If
            If Trim(LFoot10) <> Nothing Then
                file.WriteLine(LFoot10)
            End If
            Dim i As Integer
            For i = 1 To 10
                file.WriteLine("")
            Next
            file.WriteLine(Chr(27) + "i")
            file.Close()
            Try
                If ORIG = "P" Then
                    Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
                End If
            Catch ax As System.IO.FileNotFoundException
                MsgBox(ax.Message)
            End Try
            'Open GstrRUTAPRN For Output As #1
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, ""
            'Print #1, GstrCadCortaTicket
            'Close #1
            '         FactImprimir_Ticket = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Sub IMPRIMIR_TERMICA(COD_DOC As String, REIMPRIME As Integer, STRESTADO As String, NRODOC As String,
                       CLIENTE_DESC As String, CLIENTE_RUC As String, CLIENTE_DIRECCION As String,
                       DESCUENTO As String, SUBTOTAL As String, IGV As String, TOTAL As String,
                        FECHA_DOC As Date, HORA As DateTime,
                                 Optional strDNI As String = "",
                                                Optional TCLIENTE As String = "")
        Dim OBJPTOVTA As New ClsPtoVta
        Try
            'Dim Fuente As New System.Drawing.Font("Arial", 8)
            'Dim Grafico As System.Drawing.Graphics = e.Graphics
            Dim PORTIMP As String
            Dim TOTG As Double = 0
            Dim DSCTO As Boolean = False

            ObtenerConfiguracionTicket(1)
            ''AVERIGUAR PUERTO DE IMPRESION
            PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP(COD_DOC)
            If PORTIMP = "" Then MsgBox("punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            ''
            ''Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")

            Dim LHead1 As String, LHead2 As String, LHead3 As String, LHead4 As String, LHead5 As String, LHead6 As String, LHead7 As String, LHead8 As String, LHead9 As String, LHead10 As String
            Dim LFoot1 As String, LFoot2 As String, LFoot3 As String, LFoot4 As String, LFoot5 As String, LFoot6 As String, LFoot7 As String, LFoot8 As String, LFoot9 As String, LFoot10 As String


            PObtener_FechaServidor()

            ' Imprimir la Cabecera
            Dim IntAnchoTicket = 39
            ''LHead1 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD1)), Trim(GHEAD1))
            ''LHead2 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD2)), Trim(GHEAD2))
            ''LHead3 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD3)), Trim(GHEAD3))
            ''LHead4 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD4)), Trim(GHEAD4))
            ''LHead5 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD5)), Trim(GHEAD5))
            ''LHead6 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD6)), Trim(GHEAD6))
            ''LHead7 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD7)), Trim(GHEAD7))
            ''LHead8 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD8)), Trim(GHEAD8))
            ''LHead9 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD9)), Trim(GHEAD9))
            ''LHead10 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD10)), Trim(GHEAD10))
            LHead1 = Trim(GHEAD1)
            LHead2 = Trim(GHEAD2)
            LHead3 = Trim(GHEAD3)
            LHead4 = Trim(GHEAD4)
            LHead5 = Trim(GHEAD5)
            LHead6 = Trim(GHEAD6)
            LHead7 = Trim(GHEAD7)
            LHead8 = Trim(GHEAD8)
            LHead9 = Trim(GHEAD9)
            LHead10 = Trim(GHEAD10)

            '---------------------------------------------------------------------------------------------
            'ABRIR GAVETA
            If REIMPRIME = 0 Then
                'DatFechaImpresion = OBJFUNC.FECHA_SERVIDOR(OBJCONN.Conexion(CAD_CON))
                'DatHoraImpresion = Date.Now
            End If

            Y_INI = 5
            If Trim(STRESTADO) <> Nothing Then
                Dim CAB_ANULADO As String
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
                CAB_ANULADO = "*********** TICKET ANULADO ************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If

            Dim FGT As SizeF

            If Trim(LHead1) <> String.Empty Then ESCRIBIR(LHead1, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead2) <> String.Empty Then ESCRIBIR(LHead2, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead3) <> String.Empty Then ESCRIBIR(LHead3, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead4) <> String.Empty Then ESCRIBIR(LHead4, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead5) <> String.Empty Then ESCRIBIR(LHead5, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead6) <> String.Empty Then ESCRIBIR(LHead6, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead7) <> String.Empty Then ESCRIBIR(LHead7, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead8) <> String.Empty Then ESCRIBIR(LHead8, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead9) <> String.Empty Then ESCRIBIR(LHead9, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead10) <> String.Empty Then ESCRIBIR(LHead10, GRAFICO, "C") : Y_INI = Y_INI + 4

            'Imprimir la Linea
            Dim LLinea1 As String
            LLinea1 = Trim(GstrLinea1) 'Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea1)), Trim(GstrLinea1))
            If Trim(LLinea1) <> String.Empty Then ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
            'If REIMPRIME = 1 Then
            '    GstrSimbMonedaBase = GstrSimbMonedaBase
            '    GstrSimbMonedaExtr = GstrSimbMonedaExtr
            'End If
            ''TIPO DE DOCUMENTO
            Dim StrTipoTicket As String
            If COD_DOC.Trim = "002" Then
                StrTipoTicket = "***BOLETA DE VENTA ELECTRONICA ***"
            Else
                StrTipoTicket = "***FACTURA DE VENTA ELECTRONICA***"
            End If
            ''
            ESCRIBIR(StrTipoTicket, GRAFICO, "C")
            Y_INI = Y_INI + 4

            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = "N/S: " & GStrMaquinaReg
            ESCRIBIR(strMaquinaReg, GRAFICO, "I")
            strMaquinaReg = Format(FECHA_DOC, "dd/MM/yyyy")
            ESCRIBIR(strMaquinaReg, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Imprimir el Número del Ticket
            Dim TDOC As String = BUSCAR_CAMPO("TIPO_DOC", "DESC_DOC", "COD_DOC", COD_DOC, CN_NET)
            Dim StrNumeroTicket As String
            StrNumeroTicket = "Nro: " & Strings.Left(TDOC, 1) + FormatoTicket(NRODOC)
            ESCRIBIR(StrNumeroTicket, GRAFICO, "I")
            StrNumeroTicket = Format(HORA, "HH:mm:ss")
            ESCRIBIR(StrNumeroTicket, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Imprimir los Datos del Cliente
            If Trim(CLIENTE_DESC) <> String.Empty Then
                Dim LStrRazonSocial As String
                Dim NOMB As String
                NOMB = CLIENTE_DESC
                ''
                LStrRazonSocial = "Raz.Soc:" & NOMB
                FGT = GRAFICO.MeasureString(LStrRazonSocial, Fuente)
                ESCRIBIR(LStrRazonSocial, GRAFICO, "I")
                If (FGT.Width / 40) < 1 Then
                    Y_INI = Y_INI + 4
                Else
                    Y_INI = Y_INI + 4 * (FGT.Width / 40)
                End If
            End If

            If TCLIENTE = "R" Then
                If Trim(CLIENTE_RUC) <> String.Empty Then
                    Dim LStrRUC As String
                    LStrRUC = "RUC    :" & CLIENTE_RUC
                    ESCRIBIR(LStrRUC, GRAFICO, "I")
                    Y_INI = Y_INI + 4
                End If
            Else
                If Trim(strDNI) <> String.Empty Then
                    Dim LStrRUC As String
                    LStrRUC = "DNI    :" & strDNI
                    ESCRIBIR(LStrRUC, GRAFICO, "I")
                    Y_INI = Y_INI + 4
                End If
            End If

            If Trim(CLIENTE_DIRECCION) <> String.Empty Then
                Dim LstrDireccion As String
                Dim NOMB As String
                NOMB = CLIENTE_DIRECCION  'Left(StrDireccion, 30)
                LstrDireccion = "DIRECC :" & NOMB
                FGT = GRAFICO.MeasureString(LstrDireccion, Fuente)
                ESCRIBIR(LstrDireccion, GRAFICO, "I")
                If (FGT.Width / 40) < 1 Then
                    Y_INI = Y_INI + 4
                Else
                    Y_INI = Y_INI + 4 * Math.Round(FGT.Width / 40, 2) ' - 4
                End If

            End If

            ' Imprimir Seguna Línea
            Dim LLinea2 As String
            LLinea2 = Trim(GstrLinea2)
            If Trim(LLinea2) <> String.Empty Then
                ESCRIBIR(LLinea2, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            ''**
            TOTG = 0
            DSCTO = False
            ''**
            ' Imprimir el Detalle
            Dim RSDET As SqlDataReader 'New ADODB.Recordset
            Dim OCOMANDO As New SqlCommand("EXEC VENTA_MOSTRAR_DETALLE '" & COD_DOC & "'," & NRODOC & "", CN_NET)
            CN_NET.Open()
            RSDET = OCOMANDO.ExecuteReader
            While RSDET.Read
                Dim LstrProducto As String
                Dim LstrDescripcion As String
                LstrProducto = Trim(RSDET("CODIGO"))
                ESCRIBIR(LstrProducto, GRAFICO, "I")
                LstrProducto = Trim(RSDET("MEDIDA")) & "  " & GFormatodeNumero(RSDET("CANTIDAD"), 2) & "x"
                ESCRIBIR(LstrProducto, GRAFICO, "C")
                LstrProducto = GFormatodeNumero(RSDET("PU"), 2)
                ESCRIBIR(LstrProducto, GRAFICO, "D")
                Y_INI = Y_INI + 4
                LstrDescripcion = Trim(RSDET("DESCRIPCION"))
                ESCRIBIR(LstrDescripcion, GRAFICO, "I")
                LstrDescripcion = GFormatodeNumero(RSDET("TOTALSD"), 2)
                ESCRIBIR(LstrDescripcion, GRAFICO, "D")
                Y_INI = Y_INI + 4

            End While
            RSDET.Close()

            ' Imprimir la Línea 3
            Dim LLinea3 As String
            LLinea3 = Trim(GstrLinea3)
            If Trim(LLinea3) <> String.Empty Then
                ESCRIBIR(LLinea3, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If

            ' Imprimir Totales

            Dim GstrSimbMonedaBase As String = "S/ "
            Dim GstrSimbMonedaExtr As String = "US$ "
            If CFG_MONVENTA = "D" Then
                GstrSimbMonedaBase = "US$ "
                GstrSimbMonedaExtr = "S/ "
            End If
            ''**
            ''IMPRIMO DESCUENTO
            Dim StrTotalSD As String
            StrTotalSD = "**** DESCUENTO   "
            ESCRIBIR(StrTotalSD, GRAFICO, "I")
            StrTotalSD = GstrSimbMonedaBase & " :"
            ESCRIBIR(StrTotalSD, GRAFICO, "C")
            StrTotalSD = GFormatodeNumero(DESCUENTO, 2)
            ESCRIBIR(StrTotalSD, GRAFICO, "D")
            Y_INI = Y_INI + 4

            LLinea3 = Trim(GstrLinea3)
            If Trim(LLinea3) <> String.Empty Then
                ESCRIBIR(LLinea3, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            ''**
            If Trim(CLIENTE_RUC) <> Nothing Then
                Dim StrValoventa As String
                StrValoventa = "**** Valor Venta "
                ESCRIBIR(StrValoventa, GRAFICO, "I")
                StrValoventa = GstrSimbMonedaBase & " :"
                ESCRIBIR(StrValoventa, GRAFICO, "C")
                StrValoventa = GFormatodeNumero(SUBTOTAL, 2)
                ESCRIBIR(StrValoventa, GRAFICO, "D")
                Y_INI = Y_INI + 4

                Dim StrImpuesto As String
                StrImpuesto = "**** IGV " & PIGV & "%    "
                ESCRIBIR(StrImpuesto, GRAFICO, "I")
                StrImpuesto = GstrSimbMonedaBase & " :"
                ESCRIBIR(StrImpuesto, GRAFICO, "C")
                StrImpuesto = GFormatodeNumero(IGV, 2)
                ESCRIBIR(StrImpuesto, GRAFICO, "D")
                Y_INI = Y_INI + 4

            End If

            Dim StrTotal As String
            StrTotal = "**** TOTAL        "
            ESCRIBIR(StrTotal, GRAFICO, "I")
            StrTotal = GstrSimbMonedaBase & " :"
            ESCRIBIR(StrTotal, GRAFICO, "C")
            StrTotal = GFormatodeNumero(TOTAL, 2)
            ESCRIBIR(StrTotal, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Parte que Imprimie el Tipo de Pago
            Dim OBJPAGOS As New ClsPagos
            Dim StrTipoPagoImp As String
            Dim RSTARJETA As SqlDataReader 'New ADODB.Recordset
            RSTARJETA = OBJPAGOS.MOSTRAR_TARJETA_DETALLE(COD_DOC, NRODOC)
            While RSTARJETA.Read
                StrTipoPagoImp = "TARJETA          "
                ESCRIBIR(StrTipoPagoImp, GRAFICO, "I")
                Y_INI = Y_INI + 4
                ' Se Tiene que Imprimir el Número de la Tarjeta
                Dim LSTR_NOMBRET As String
                Dim LSTR_NUMEROT As String
                Dim LSTR_MONEDA As String
                Dim LDBL_PENT As Double
                Dim SIMBOLO As String

                LSTR_MONEDA = RSTARJETA("MONEDA")
                If Strings.Left(LSTR_MONEDA, 1) = "S" Then SIMBOLO = "S/ " Else SIMBOLO = "US$ "
                LSTR_NOMBRET = Trim(RSTARJETA("TARJETA"))
                LSTR_NUMEROT = Trim(RSTARJETA("NUMERO"))
                LDBL_PENT = RSTARJETA("MONTO")
                StrTipoPagoImp = LSTR_NOMBRET & "  " & LSTR_NUMEROT
                ESCRIBIR(StrTipoPagoImp, GRAFICO, "I")
                StrTipoPagoImp = SIMBOLO & ":"
                ESCRIBIR(StrTipoPagoImp, GRAFICO, "C")
                StrTipoPagoImp = GFormatodeNumero(LDBL_PENT, 2)
                ESCRIBIR(StrTipoPagoImp, GRAFICO, "D")
                Y_INI = Y_INI + 4

            End While
            RSTARJETA.Close()

            ' Imprimir Efectivo Soles y dolares
            Dim OBJVENTAS As New ClsVenta
            Dim Strefectivopagado As String
            Dim RSPAGO As SqlDataReader 'New ADODB.Recordset
            RSPAGO = OBJVENTAS.MOSTRAR_CABECERA(COD_DOC, NRODOC)
            While RSPAGO.Read
                If RSPAGO("PAGOS_VENTA") <> 0 Or RSPAGO("PAGOD_VENTA") <> 0 Then
                    Strefectivopagado = "EFECTIVO: "
                    ESCRIBIR(Strefectivopagado, GRAFICO, "I")
                    If RSPAGO("PAGOS_VENTA") > 0 Then
                        Strefectivopagado = "S/ " & " :"
                        ESCRIBIR(Strefectivopagado, GRAFICO, "C")
                        Strefectivopagado = GFormatodeNumero(Str(RSPAGO("PAGOS_VENTA")), 2)
                        ESCRIBIR(Strefectivopagado, GRAFICO, "D")
                        Y_INI = Y_INI + 4
                    End If
                    If RSPAGO("PAGOD_VENTA") > 0 Then
                        Strefectivopagado = "US$ " & " :"
                        ESCRIBIR(Strefectivopagado, GRAFICO, "C")
                        Strefectivopagado = GFormatodeNumero(Str(RSPAGO("PAGOD_VENTA")), 2)
                        ESCRIBIR(Strefectivopagado, GRAFICO, "D")
                        Y_INI = Y_INI + 4
                    End If

                End If

                ' Imprimir Vuelto Soles y dolares
                Dim Strvuelto As String
                If RSPAGO("VUELTO_VENTA") <> 0 Then
                    Strvuelto = "VUELTO: "
                    ESCRIBIR(Strvuelto, GRAFICO, "I")
                    If RSPAGO("VUELTO_VENTA") > 0 Then
                        Strvuelto = GstrSimbMonedaBase & " :"
                        ESCRIBIR(Strvuelto, GRAFICO, "C")
                        Strvuelto = GFormatodeNumero(Str(RSPAGO("VUELTO_VENTA")), 2)
                        ESCRIBIR(Strvuelto, GRAFICO, "D")
                    End If
                    Y_INI = Y_INI + 4
                End If

                ' Imprimir Tipo de cambio y Cajero
                Dim StrDatosVendedor As String
                StrDatosVendedor = "TC:  " & RSPAGO("CAMBIO_VENTA")
                ESCRIBIR(StrDatosVendedor, GRAFICO, "I")
                StrDatosVendedor = "CAJERO:  " & RSPAGO("COD_USER")
                ESCRIBIR(StrDatosVendedor, GRAFICO, "D")
                Y_INI = Y_INI + 4

            End While
            RSPAGO.Close()
            CN_NET.Close()
            ' Imprimir la Línea 4
            Dim LLinea4 As String
            LLinea4 = Trim(GstrLinea4)
            If Trim(LLinea4) <> String.Empty Then
                ESCRIBIR(LLinea4, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If

            ' Imprimir Pie de Página

            LFoot1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT1)), Trim(GstrFOOT1))
            LFoot2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT2)), Trim(GstrFOOT2))
            If REIMPRIME = 1 Then
                LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim("REIMPRESION")), Trim("REIMPRESION"))
            End If
            If REIMPRIME = 0 Then
                LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT3)), Trim(GstrFOOT3))
            End If
            If REIMPRIME = 2 Then
                LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim("ANULADO")), Trim("ANULADO"))
            End If

            ''GRAFICO
            Dim newImage As Image = Image.FromFile(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "JPG")
            GRAFICO.DrawImage(newImage, X_INI + 15, Y_INI, 39, 39)
            Y_INI = Y_INI + 50
            newImage.Dispose()
            ''
            ''ELIMINAMOS
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "JPG")
            ''

            Dim LEYENDA As String = ""
            LEYENDA = Trim("Representacion Impresa de la ")
            ESCRIBIR(LEYENDA, GRAFICO, "C")
            Y_INI = Y_INI + 4
            If COD_DOC.Trim = "002" Then
                LEYENDA = Trim("Boleta Electronica ")
            Else
                LEYENDA = Trim("Factura Electronica ")
            End If
            ESCRIBIR(LEYENDA, GRAFICO, "C")
            Y_INI = Y_INI + 4
            LEYENDA = Trim("Esta puede ser consultada en :")
            ESCRIBIR(LEYENDA, GRAFICO, "C")
            Y_INI = Y_INI + 4
            LEYENDA = Trim(FE_WEB)
            ESCRIBIR(LEYENDA, GRAFICO, "C")
            Y_INI = Y_INI + 6
            ESCRIBIR("", GRAFICO, "C")

            LFoot4 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT4)), Trim(GstrFOOT4))
            LFoot5 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT5)), Trim(GstrFOOT5))
            LFoot6 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT6)), Trim(GstrFOOT6))
            LFoot7 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT7)), Trim(GstrFOOT7))
            LFoot8 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT8)), Trim(GstrFOOT8))
            LFoot9 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT9)), Trim(GstrFOOT9))
            LFoot10 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT10)), Trim(GstrFOOT10))
            Y_INI = Y_INI + 4


            If Trim(LFoot1) <> String.Empty Then
                ESCRIBIR(LFoot1, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot2) <> String.Empty Then
                ESCRIBIR(LFoot2, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot3) <> String.Empty Then
                ESCRIBIR(LFoot3, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot4) <> String.Empty Then
                ESCRIBIR(LFoot4, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot5) <> String.Empty Then
                ESCRIBIR(LFoot5, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot6) <> String.Empty Then
                ESCRIBIR(LFoot6, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot7) <> String.Empty Then
                ESCRIBIR(LFoot7, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot8) <> String.Empty Then
                ESCRIBIR(LFoot8, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot9) <> String.Empty Then
                ESCRIBIR(LFoot9, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If
            If Trim(LFoot10) <> String.Empty Then
                ESCRIBIR(LFoot10, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Sub ObtenerConfiguracionTicket(intTicket As Integer)
        Dim LrsDatosTicket As SqlDataReader
        Dim CN As New SqlConnection
        Dim SQL As String
        SQL = " SELECT HEAD1,HEAD2,HEAD3,HEAD4,HEAD5,HEAD6,HEAD7,HEAD8,HEAD9,HEAD10, " &
                                      " LINES1,LINES2,LINES3,LINES4, " &
                                      " FOOT1,FOOT2,FOOT3,FOOT4,FOOT5,FOOT6,FOOT7,FOOT8,FOOT9,FOOT10 " &
                             " FROM TICKETFORM "
        ''&                             " WHERE TCKCODI=" & intTicket & ""

        Try
            CN = CN_NET
            CN.Open()
            Dim OCOMANDO As New SqlCommand(SQL, CN)
            LrsDatosTicket = OCOMANDO.ExecuteReader
            While LrsDatosTicket.Read
                ' Obtener las Cabeceras
                If String.IsNullOrEmpty(LrsDatosTicket!HEAD1) Then
                    GHEAD1 = String.Empty
                Else
                    GHEAD1 = LrsDatosTicket!HEAD1
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD2) Then
                    GHEAD2 = String.Empty
                Else
                    GHEAD2 = LrsDatosTicket!HEAD2
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD3) Then
                    GHEAD3 = String.Empty
                Else
                    GHEAD3 = LrsDatosTicket!HEAD3
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD4) Then
                    GHEAD4 = String.Empty
                Else
                    GHEAD4 = LrsDatosTicket!HEAD4
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD5) Then
                    GHEAD5 = String.Empty
                Else
                    GHEAD5 = LrsDatosTicket!HEAD5
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD6) Then
                    GHEAD6 = String.Empty
                Else
                    GHEAD6 = LrsDatosTicket!HEAD6
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD7) Then
                    GHEAD7 = String.Empty
                Else
                    GHEAD7 = LrsDatosTicket!HEAD7
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD8) Then
                    GHEAD8 = String.Empty
                Else
                    GHEAD8 = LrsDatosTicket!HEAD8
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD9) Then
                    GHEAD9 = String.Empty
                Else
                    GHEAD9 = LrsDatosTicket!HEAD9
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!HEAD10) Then
                    GHEAD10 = String.Empty
                Else
                    GHEAD10 = LrsDatosTicket!HEAD10
                End If


                'Obtener la Lineas
                If String.IsNullOrEmpty(LrsDatosTicket!LINES1) Then
                    GstrLinea1 = String.Empty
                Else
                    GstrLinea1 = LrsDatosTicket!LINES1
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Lines2) Then
                    GstrLinea2 = String.Empty
                Else
                    GstrLinea2 = LrsDatosTicket!Lines2
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Lines3) Then
                    GstrLinea3 = String.Empty
                Else
                    GstrLinea3 = LrsDatosTicket!Lines3
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Lines4) Then
                    GstrLinea4 = String.Empty
                Else
                    GstrLinea4 = LrsDatosTicket!Lines4
                End If


                If String.IsNullOrEmpty(LrsDatosTicket!Foot1) Then
                    GstrFOOT1 = String.Empty
                Else
                    GstrFOOT1 = LrsDatosTicket!Foot1
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot2) Then
                    GstrFOOT2 = String.Empty
                Else
                    GstrFOOT2 = LrsDatosTicket!Foot2
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot3) Then
                    GstrFOOT3 = String.Empty
                Else
                    GstrFOOT3 = LrsDatosTicket!Foot3
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot4) Then
                    GstrFOOT4 = String.Empty
                Else
                    GstrFOOT4 = LrsDatosTicket!Foot4
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot5) Then
                    GstrFOOT5 = String.Empty
                Else
                    GstrFOOT5 = LrsDatosTicket!Foot5
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot6) Then
                    GstrFOOT6 = String.Empty
                Else
                    GstrFOOT6 = LrsDatosTicket!Foot6
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot7) Then
                    GstrFOOT7 = String.Empty
                Else
                    GstrFOOT7 = LrsDatosTicket!Foot7
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot8) Then
                    GstrFOOT8 = String.Empty
                Else
                    GstrFOOT8 = LrsDatosTicket!Foot8
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot9) Then
                    GstrFOOT9 = String.Empty
                Else
                    GstrFOOT9 = LrsDatosTicket!Foot9
                End If

                If String.IsNullOrEmpty(LrsDatosTicket!Foot10) Then
                    GstrFOOT10 = String.Empty
                Else
                    GstrFOOT10 = LrsDatosTicket!Foot10
                End If

            End While
        Catch
            MsgBox(Err.Description)
        Finally
            LrsDatosTicket.Close()
            CN.Close()
        End Try



    End Sub
    Sub ESCRIBIR(ByVal TEXTO As String, ByVal GRAFICO As System.Drawing.Graphics, LUGAR As String)
        GRAFICO.PageUnit = GraphicsUnit.Millimeter

        Dim RecTexto As RectangleF
        RecTexto = New RectangleF(X_INI, Y_INI, ANCHO, Fuente.Height)



        Dim FORMAT As New StringFormat
        Select Case LUGAR
            Case "I"
                FORMAT.Alignment = StringAlignment.Near
            Case "D"
                FORMAT.Alignment = StringAlignment.Far
            Case "C"
                FORMAT.Alignment = StringAlignment.Center
        End Select

        ''GRAFICO.DrawString(TEXTO, Fuente, Brushes.Black, X_INI, Y_INI)

        GRAFICO.DrawString(TEXTO, Fuente, Brushes.Black, RecTexto, FORMAT)
        ''GRAFICO.TranslateTransform(0, Fuente.GetHeight(GRAFICO))
    End Sub
    Sub IMPRIMIR_CAJA_VENTA(TIPO_MOV As String, MON_CAJA As String, MONTO_CAJA As Double, OBSERV As String)
        Try
            Dim OBJPTOVTA As New ClsPtoVta
            Dim PORTIMP As String
            ''AVERIGUAR PUERTO DE IMPRESION
            PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP("002")
            If PORTIMP = "" Then MsgBox("punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            ''
            ObtenerConfiguracionTicket(1)

            Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")

            Dim LHead1 As String, LHead2 As String, LHead3 As String, LHead4 As String, LHead5 As String, LHead6 As String, LHead7 As String, LHead8 As String, LHead9 As String, LHead10 As String
            'Dim LFoot1 As String, LFoot2 As String, LFoot3 As String, LFoot4 As String, LFoot5 As String, LFoot6 As String, LFoot7 As String, LFoot8 As String, LFoot9 As String, LFoot10 As String


            PObtener_FechaServidor()

            ' Imprimir la Cabecera
            Dim IntAnchoTicket = 39
            LHead1 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD1)), Trim(GHEAD1))
            LHead2 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD2)), Trim(GHEAD2))
            LHead3 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD3)), Trim(GHEAD3))
            LHead4 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD4)), Trim(GHEAD4))
            LHead5 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD5)), Trim(GHEAD5))
            LHead6 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD6)), Trim(GHEAD6))
            LHead7 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD7)), Trim(GHEAD7))
            LHead8 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD8)), Trim(GHEAD8))
            LHead9 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD9)), Trim(GHEAD9))
            LHead10 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD10)), Trim(GHEAD10))

            '---------------------------------------------------------------------------------------------
            'ABRIR GAVETA
            file.WriteLine(Chr(27) + "p" + Chr(0) + Chr(25) + Chr(250))


            Dim CAB_ANULADO As String
            CAB_ANULADO = "***************************************"
            file.WriteLine(CAB_ANULADO)
            If TIPO_MOV = "I" Then
                CAB_ANULADO = "*********** INGRESO A CAJA ************"
            Else
                CAB_ANULADO = "*********** SALIDA DE CAJA ************"
            End If
            file.WriteLine(CAB_ANULADO)
            CAB_ANULADO = "***************************************"
            file.WriteLine(CAB_ANULADO)


            If Trim(LHead1) <> Nothing Then file.WriteLine(LHead1)
            If Trim(LHead2) <> Nothing Then file.WriteLine(LHead2)
            If Trim(LHead3) <> Nothing Then file.WriteLine(LHead3)
            If Trim(LHead4) <> Nothing Then file.WriteLine(LHead4)
            If Trim(LHead5) <> Nothing Then file.WriteLine(LHead5)
            If Trim(LHead6) <> Nothing Then file.WriteLine(LHead6)
            If Trim(LHead7) <> Nothing Then file.WriteLine(LHead7)
            If Trim(LHead8) <> Nothing Then file.WriteLine(LHead8)
            If Trim(LHead9) <> Nothing Then file.WriteLine(LHead9)
            If Trim(LHead10) <> Nothing Then file.WriteLine(LHead10)

            'Imprimir la Linea
            Dim LLinea1 As String
            LLinea1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea1)), Trim(GstrLinea1))

            If Trim(LLinea1) <> Nothing Then file.WriteLine(LLinea1)

            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = Alineacion("I", IntAnchoTicket - 10, Len("Maq.Regist.No: " & GStrMaquinaReg), "Maq.Regist.No: " & GStrMaquinaReg) & Format(GDatFechaActual, "dd/MM/yyyy")
            file.WriteLine(strMaquinaReg)

            ' Imprimir Seguna Línea

            Dim LLinea2 As String
            LLinea2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea2)), Trim(GstrLinea2))
            If Trim(LLinea2) <> Nothing Then
                file.WriteLine(LLinea2)
            End If

            Dim strConcepto As String = OBSERV
            strConcepto = Alineacion("I", IntAnchoTicket, Len(strConcepto), strConcepto)
            file.WriteLine(strConcepto)

            LLinea2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea2)), Trim(GstrLinea2))
            If Trim(LLinea2) <> Nothing Then
                file.WriteLine(LLinea2)
            End If


            ' Imprimir Totales
            Dim GstrSimbMonedaBase As String = "S/ "
            Dim GstrSimbMonedaExtr As String = "US$ "
            Dim MON As String = IIf(Strings.Left(MON_CAJA, 1) = "S", GstrSimbMonedaBase, GstrSimbMonedaExtr)
            Dim StrTotal As String
            StrTotal = Alineacion("I", 17, Len("**** TOTAL       "), "**** TOTAL       ")
            StrTotal = StrTotal & Alineacion("I", 7, Len(MON & " :"), MON & " :")
            StrTotal = StrTotal & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(MONTO_CAJA, 2)), GFormatodeNumero(MONTO_CAJA, 2))
            file.WriteLine(StrTotal)

            ' Fecha y Hora
            Dim Strfecha As String
            Strfecha = Alineacion("I", 10, Len("FECHA:"), "FECHA:")
            Strfecha = Strfecha & Alineacion("I", IntAnchoTicket - 6 - 3 - 8, Len(Date.Now), Date.Now)
            file.WriteLine(Strfecha)

            ' Imprimir Tipo de cambio y Cajero
            Dim StrDatosVendedor As String
            StrDatosVendedor = Alineacion("I", 10, Len("CAJERO:"), "CAJERO:")
            StrDatosVendedor = StrDatosVendedor & Alineacion("I", IntAnchoTicket - 6 - 3 - 8, Len(GUSERID), GUSERID)
            file.WriteLine(StrDatosVendedor)
            ''
            Dim I As Integer
            For I = 1 To 10
                file.WriteLine("")
            Next
            file.WriteLine(Chr(27) + "i")
            '
            file.Flush()
            file.Close()
            Try
                If ORIG = "P" Then
                    Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
                End If
            Catch ax As System.IO.FileNotFoundException
                MsgBox(ax.Message)
            End Try

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub IMPRIMIR_CAJA_VENTA_TERMICA(TIPO_MOV As String, MON_CAJA As String, MONTO_CAJA As Double, COMENTARIO As String, STRESTADO As String)
        Try
            Dim OBJPTOVTA As New ClsPtoVta
            Dim PORTIMP As String

            ObtenerConfiguracionTicket(1)

            Dim FGT As SizeF
            Y_INI = 5

            PObtener_FechaServidor()

            Dim LHead1 As String, LHead2 As String, LHead3 As String, LHead4 As String, LHead5 As String, LHead6 As String, LHead7 As String, LHead8 As String, LHead9 As String, LHead10 As String
            'Dim LFoot1 As String, LFoot2 As String, LFoot3 As String, LFoot4 As String, LFoot5 As String, LFoot6 As String, LFoot7 As String, LFoot8 As String, LFoot9 As String, LFoot10 As String
            Dim CAB_ANULADO As String

            LHead1 = Trim(GHEAD1)
            LHead2 = Trim(GHEAD2)
            '---------------------------------------------------------------------------------------------
            ObtenerConfiguracionTicket(1)

            If Trim(STRESTADO) <> String.Empty Then
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
                CAB_ANULADO = "*********** RECIBO ANULADO ***********"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
            Else
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4

                If TIPO_MOV = "S" Then
                    CAB_ANULADO = "******** RECIBO SALIDA DE CAJA ********"
                    ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                    Y_INI = Y_INI + 4
                Else
                    CAB_ANULADO = "******** RECIBO INGRESO DE CAJA ********"
                    ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                    Y_INI = Y_INI + 4
                End If
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If

            If Trim(LHead1) <> String.Empty Then ESCRIBIR(LHead1, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead2) <> String.Empty Then ESCRIBIR(LHead2, GRAFICO, "C") : Y_INI = Y_INI + 4

            'Imprimir la Linea
            Dim LLinea1 As String
            LLinea1 = Trim(GstrLinea1)
            If Trim(LLinea1) <> String.Empty Then ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4

            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = "N/S: " & GStrMaquinaReg
            ESCRIBIR(strMaquinaReg, GRAFICO, "I")
            strMaquinaReg = Format(GDatFechaActual, "dd/MM/yyyy")
            ESCRIBIR(strMaquinaReg, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Imprimir Seguna Línea
            Dim LLinea2 As String
            LLinea2 = Trim(GstrLinea2)
            If Trim(LLinea2) <> String.Empty Then ESCRIBIR(LLinea2, GRAFICO, "C") : Y_INI = Y_INI + 4

            If Trim(COMENTARIO) <> String.Empty Then
                Dim LStrNombre As String
                LStrNombre = COMENTARIO
                FGT = GRAFICO.MeasureString(LStrNombre, Fuente)
                ESCRIBIR(LStrNombre, GRAFICO, "I")
                If (FGT.Width / 40) < 1 Then
                    Y_INI = Y_INI + 4
                Else
                    Y_INI = Y_INI + 4 * (FGT.Width / 40)
                End If
            End If

            ' Imprimir la Línea 3
            Dim LLinea3 As String
            LLinea3 = Trim(GstrLinea3)
            If Trim(LLinea3) <> String.Empty Then
                ESCRIBIR(LLinea3, GRAFICO, "I")
                Y_INI = Y_INI + 4
            End If

            ' Imprimir Totales
            Dim GstrSimbMonedaBase As String = "S/ "
            Dim GstrSimbMonedaExtr As String = "US$ "
            Dim MON As String = IIf(Strings.Left(MON_CAJA, 1) = "S", GstrSimbMonedaBase, GstrSimbMonedaExtr)
            Dim StrTotal As String
            StrTotal = "**** TOTAL       "
            ESCRIBIR(StrTotal, GRAFICO, "I")
            StrTotal = MON & " :"
            ESCRIBIR(StrTotal, GRAFICO, "C")
            StrTotal = GFormatodeNumero(MONTO_CAJA, 2)
            ESCRIBIR(StrTotal, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Fecha y Hora
            Dim Strfecha As String
            Strfecha = "FECHA:  " & Date.Now
            ESCRIBIR(Strfecha, GRAFICO, "I")
            Y_INI = Y_INI + 4

            ' Imprimir Tipo de cambio y Cajero
            Dim StrDatosVendedor As String
            StrDatosVendedor = "CAJERO:  " & GUSERID
            ESCRIBIR(StrDatosVendedor, GRAFICO, "D")
            Y_INI = Y_INI + 4
            ''
            ' Imprimir la Línea 4
            Dim LLinea4 As String
            LLinea4 = Trim(GstrLinea4)
            If Trim(LLinea4) <> String.Empty Then
                ESCRIBIR(LLinea4, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If



        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub IMPRIMIR_CIERRE_X(FECHA_LIQ As Date, CAJA_LIQ As String, TURNO_LIQ As Integer)
        Try
            Dim OBJTC As New ClsTC
            Dim OBJPTOVTA As New ClsPtoVta
            Dim CREDITO As Double = 0
            Dim PAGOSOL As Double = 0
            Dim PAGODOL As Double = 0
            Dim PAGOTARJSOL As Double = 0
            Dim PAGOTARJDOL As Double = 0
            Dim PORTIMP As String = ""
            Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")

            ''AVERIGUAR PUERTO DE IMPRESION
            PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP("002")
            If PORTIMP = "" Then MsgBox("Punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            ''
            Dim LINEA As String = "---------------------------------------"
            Dim IntAnchoTicket = 39

            'IMPRIMO CABECERA
            Dim TITUT As String
            Dim TURN As String
            file.WriteLine("")
            file.WriteLine("")
            file.WriteLine(LINEA)
            TITUT = Alineacion("C", IntAnchoTicket, Len("CIERRE (X)"), Trim("CIERRE (X)"))
            file.WriteLine(TITUT)
            TURN = Alineacion("C", IntAnchoTicket, Len("TURNO :" & TURNO & ""), Trim("TURNO :" & TURNO & ""))
            file.WriteLine(TURN)
            file.WriteLine(LINEA)
            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = Alineacion("I", IntAnchoTicket - 15, Len("Maq.Regist.No       : "), "Maq.Regist.No       : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GStrMaquinaReg), GStrMaquinaReg)
            file.WriteLine(strMaquinaReg)
            ' Imprimir FECHA
            Dim strfecha As String
            strfecha = Alineacion("I", IntAnchoTicket - 15, Len("Fecha               : "), "Fecha               : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(Format(FECHA_LIQ, "dd/MM/yyyy")), Format(FECHA_LIQ, "dd/MM/yyyy"))
            file.WriteLine(strfecha)
            ' Imprimir HORA
            Dim strhora As String
            Dim HORA As String = Format(DateTime.Now, "HH:mm:ss")
            strhora = Alineacion("I", IntAnchoTicket - 15, Len("Hora                : "), "Hora                : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(HORA), HORA)
            file.WriteLine(strhora)
            ' Imprimir TC
            Dim strcambio As String
            Dim tc As String = GFormatodeNumero(OBJTC.BUSCAR_TC(GFechaProceso, "V"), 3)
            strcambio = Alineacion("I", IntAnchoTicket - 15, Len("Tipo de Cambio      : "), "Tipo de Cambio      : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(tc), tc)
            file.WriteLine(strcambio)
            file.WriteLine(LINEA)
            file.WriteLine("")
            TITUT = Alineacion("C", IntAnchoTicket, Len("REPORTE DE TICKETS"), Trim("REPORTE DE TICKETS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ''LLENANDO DATOS DE TICKET
            Dim RS As SqlDataReader
            Dim PAGOS As Double, PAGOD As Double, VUELTO As Double
            Dim OCOMANDO As New SqlCommand("EXEC IMP_X_RESUMEN '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            If RS.HasRows = True Then
                While RS.Read
                    ' Imprimir Nro de Transacciones
                    Dim strnrotransac As String
                    strnrotransac = Alineacion("I", IntAnchoTicket - 15, Len("Nro. Transac.       : "), "Nro. Transac.       : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(RS("cant")), RS("cant"))
                    file.WriteLine(strnrotransac.Trim)
                    ' Imprimir Ticket Inicial
                    Dim strticketini As String
                    strticketini = Alineacion("I", IntAnchoTicket - 15, Len("Num. Ticket Ini.    : "), "Num. Ticket Ini.    : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(FormatoTicket(RS("minimo"))), FormatoTicket(RS("minimo")))
                    file.WriteLine(strticketini)
                    ' Imprimir Ticket Final
                    Dim strticketfin As String
                    strticketfin = Alineacion("I", IntAnchoTicket - 15, Len("Num. Ticket Fin.    : "), "Num. Ticket Fin.    : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(FormatoTicket(RS("maximo"))), FormatoTicket(RS("maximo")))
                    file.WriteLine(strticketfin)
                    If CFG_MONVENTA = "S" Then
                        ' Imprimir Valor Venta
                        Dim strvv As String
                        strvv = Alineacion("I", IntAnchoTicket - 15, Len("Valor Venta       S/: "), "Valor Venta       S/: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("valor"), 2)), GFormatodeNumero(RS("valor"), 2))
                        file.WriteLine(strvv)
                        ' Imprimir IGV
                        Dim strigv As String
                        strigv = Alineacion("I", IntAnchoTicket - 15, Len("I.G.V.            S/: "), "I.G.V.            S/: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("IGV"), 2)), GFormatodeNumero(RS("IGV"), 2))
                        file.WriteLine(strigv)
                        ' Imprimir Total
                        Dim strtotal As String
                        strtotal = Alineacion("I", IntAnchoTicket - 15, Len("Venta Total       S/: "), "Venta Total       S/: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total"), 2)), GFormatodeNumero(RS("total"), 2))
                        file.WriteLine(strtotal)
                        ' Imprimir Nro de Tickets Anulados
                        Dim strticketanul As String
                        strticketanul = Alineacion("I", IntAnchoTicket - 15, Len("Num.Ticket Anul.: "), "Num.Ticket Anul.: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(RS("anulados")), RS("anulados"))
                        file.WriteLine(strticketanul)
                        ' Imprimir Total de Tickets Anulados
                        Dim strmontoanul As String
                        strmontoanul = Alineacion("I", IntAnchoTicket - 15, Len("Tot.Ticket Anul.  S/: "), "Tot.Ticket Anul.  S/: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total_anul"), 2)), GFormatodeNumero(RS("total_anul"), 2))
                        file.WriteLine(strmontoanul)
                    Else
                        ' Imprimir Valor Venta
                        Dim strvv As String
                        strvv = Alineacion("I", IntAnchoTicket - 15, Len("Valor Venta      US$: "), "Valor Venta      US$: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("valor"), 2)), GFormatodeNumero(RS("valor"), 2))
                        file.WriteLine(strvv)
                        ' Imprimir IGV
                        Dim strigv As String
                        strigv = Alineacion("I", IntAnchoTicket - 15, Len("I.G.V.           US$: "), "I.G.V.           US$: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("IGV"), 2)), GFormatodeNumero(RS("IGV"), 2))
                        file.WriteLine(strigv)
                        ' Imprimir Total
                        Dim strtotal As String
                        strtotal = Alineacion("I", IntAnchoTicket - 15, Len("Venta Total      US$: "), "Venta Total      US$: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total"), 2)), GFormatodeNumero(RS("total"), 2))
                        file.WriteLine(strtotal)
                        ' Imprimir Nro de Tickets Anulados
                        Dim strticketanul As String
                        strticketanul = Alineacion("I", IntAnchoTicket - 15, Len("Num.Ticket Anul.: "), "Num.Ticket Anul.: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(RS("anulados")), RS("anulados"))
                        file.WriteLine(strticketanul)
                        ' Imprimir Total de Tickets Anulados
                        Dim strmontoanul As String
                        strmontoanul = Alineacion("I", IntAnchoTicket - 15, Len("Tot.Ticket Anul. US$: "), "Tot.Ticket Anul. US$: ") &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total_anul"), 2)), GFormatodeNumero(RS("total_anul"), 2))
                        file.WriteLine(strmontoanul)
                    End If
                    ''
                    PAGOS = RS("PAGOS")
                    PAGOD = RS("PAGOD")
                    VUELTO = GFormatodeNumero(RS("VUELTO"), 2)
                    CREDITO = RS("CREDITO")
                End While
            Else
                MsgBox("No hay Transacciones en esta Caja", MsgBoxStyle.Information) : file.Close() : RS.Close() : CN_NET.Close() : Exit Sub
            End If
            RS.Close()
            file.WriteLine("")
            ''TIPO DE PAGOS
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR TIPOS DE PAGOS"), Trim("RESUMEN POR TIPOS DE PAGOS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ' Imprimir Efectivo Soles
            Dim strtotsoles As String
            strtotsoles = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO SOLES   S/: "), "EFECTIVO SOLES   S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS, 2)), GFormatodeNumero(PAGOS, 2))
            file.WriteLine(strtotsoles)
            ' Imprimir Vuelto Soles
            Dim strvueltosoles As String
            If CFG_MONVENTA = "S" Then
                strvueltosoles = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO SOLES     S/: "), "VUELTO SOLES     S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(VUELTO, 2)), GFormatodeNumero(VUELTO, 2))
                file.WriteLine(strvueltosoles)
                ' Imprimir Neto Soles
                Dim strnetosoles As String
                strnetosoles = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS - VUELTO, 2)), GFormatodeNumero(PAGOS - VUELTO, 2))
                file.WriteLine(strnetosoles)
                file.WriteLine("")
                PAGOSOL = PAGOS - VUELTO
            Else
                strvueltosoles = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO SOLES     S/: "), "VUELTO SOLES     S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(0, 2)), GFormatodeNumero(0, 2))
                file.WriteLine(strvueltosoles)
                ' Imprimir Neto Soles
                Dim strnetosoles As String
                strnetosoles = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS - 0, 2)), GFormatodeNumero(PAGOS - 0, 2))
                file.WriteLine(strnetosoles)
                file.WriteLine("")
                PAGOSOL = PAGOS
            End If
            ' Imprimir Efectivo Dolares
            Dim strtotdol As String
            strtotdol = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO DOLARES $/.: "), "EFECTIVO DOLARES $/.: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD, 2)), GFormatodeNumero(PAGOD, 2))
            file.WriteLine(strtotdol)
            ' Imprimir Vuelto Dolares
            If CFG_MONVENTA = "D" Then
                Dim strvueltodol As String
                strvueltodol = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO DOLARES   $/.: "), "VUELTO DOLARES   $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(VUELTO, 2)), GFormatodeNumero(VUELTO, 2))
                file.WriteLine(strvueltodol)
                ' Imprimir Neto Dolares
                Dim strnetodol As String
                strnetodol = Alineacion("I", IntAnchoTicket - 15, Len("NETO DOLARES     $/.: "), "NETO DOLARES     $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD - VUELTO, 2)), GFormatodeNumero(PAGOD - VUELTO, 2))
                file.WriteLine(strnetodol)
                PAGODOL = PAGOD - VUELTO
            Else
                Dim strvueltodol As String
                strvueltodol = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO DOLARES   $/.: "), "VUELTO DOLARES   $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(0, 2)), GFormatodeNumero(0, 2))
                file.WriteLine(strvueltodol)
                ' Imprimir Neto Dolares
                Dim strnetodol As String
                strnetodol = Alineacion("I", IntAnchoTicket - 15, Len("NETO DOLARES     $/.: "), "NETO DOLARES     $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD - 0, 2)), GFormatodeNumero(PAGOD - 0, 2))
                file.WriteLine(strnetodol)
                PAGODOL = PAGOD - VUELTO
            End If
            ''''
            file.WriteLine("")
            ''TARJETA EN SOLES
            Dim SQL As String
            Dim tots As Double = 0, totd As Double = 0
            Dim OCOMANDO1 As New SqlCommand("EXEC IMP_X_RESUMEN_TARJETAS '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("TARJETAS EN SOLES"), Trim("TARJETAS EN SOLES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                While RS.Read
                    ' Imprimir Soles
                    If RS("MON_TARJETA") = "S" Then
                        SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                        file.WriteLine(SQL)
                        tots = tots + RS("TOTAL")
                    End If
                    'If RS("MON_TARJETA") = "D" Then
                    '    SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                    '    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                    '    file.WriteLine(SQL)
                    '    totd = totd + RS("TOTAL")
                    'End If
                End While
                PAGOTARJSOL = tots
                file.WriteLine("")
            End If
            RS.Close()
            ' Imprimir Total Tarjetas Soles
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            S/: "), "TOTAL            S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(tots, 2)), GFormatodeNumero(tots, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            ' Imprimir Dolares
            OCOMANDO1 = New SqlCommand("EXEC IMP_X_RESUMEN_TARJETAS '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                ''TARJETA EN DOLARES
                TITUT = Alineacion("C", IntAnchoTicket, Len("TARJETAS EN DOLARES"), Trim("TARJETAS EN DOLARES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                While RS.Read
                    ' Imprimir Soles
                    If RS("MON_TARJETA") = "D" Then
                        SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                        file.WriteLine(SQL)
                        totd = totd + RS("TOTAL")
                    End If
                End While
                PAGOTARJDOL = totd
                file.WriteLine("")
            End If
            RS.Close()
            ' Imprimir Total Tarjetas Dolares
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            $/: "), "TOTAL            $/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(totd, 2)), GFormatodeNumero(totd, 2))
            file.WriteLine(SQL)
            file.WriteLine("")

            ''  RESUMEN VENTA POR TIPO PAGO EN SOLES 
            If CFG_MONVENTA = "S" Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN VENTA POR TIPO PAGO EN SOLES"), Trim("RESUMEN VENTA POR TIPO PAGO EN SOLES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                ' Imprimir Neto Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL, 2)), GFormatodeNumero(PAGOSOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO $ EN SOLES  S/: "), "NETO $ EN SOLES  S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL * tc, 2)), GFormatodeNumero(PAGODOL * tc, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJETA EN SOLES S/: "), "TARJETA EN SOLES S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJSOL, 2)), GFormatodeNumero(PAGOTARJSOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJ. $ EN SOLES S/: "), "TARJ. $ EN SOLES S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJDOL * tc, 2)), GFormatodeNumero(PAGOTARJDOL * tc, 2))
                file.WriteLine(SQL)
                ' Imprimir CREDITO
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("CREDITO EN SOLES S/: "), "CREDITO EN SOLES S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(CREDITO, 2)), GFormatodeNumero(CREDITO, 2))
                file.WriteLine(SQL)
                ' Imprimir Total Tipo de Pagos
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            S/: "), "TOTAL            S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc), 2)), GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc) + CREDITO, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            Else
                TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN VENTA POR TIPO PAGO EN DOLARES"), Trim("RESUMEN VENTA POR TIPO PAGO EN DOLARES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                ' Imprimir Neto Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       US$: "), "NETO SOLES       US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL / tc, 2)), GFormatodeNumero(PAGOSOL / tc, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO              US$: "), "NETO             US$: ") &
                Alineacion("D", IntAnchoTicket - 24, Len(GFormatodeNumero(PAGODOL, 2)), GFormatodeNumero(PAGODOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJETA EN SOLES US$: "), "TARJETA EN SOLES US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJSOL / tc, 2)), GFormatodeNumero(PAGOTARJSOL / tc, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJETA          US$: "), "TARJETA          US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJDOL, 2)), GFormatodeNumero(PAGOTARJDOL, 2))
                file.WriteLine(SQL)
                ' Imprimir CREDITO
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("CREDITO          US$: "), "CREDITO          US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(CREDITO, 2)), GFormatodeNumero(CREDITO, 2))
                file.WriteLine(SQL)
                ' Imprimir Total Tipo de Pagos
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            US$: "), "TOTAL            US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero((PAGOSOL / tc) + (PAGODOL) + (PAGOTARJSOL / tc) + (PAGOTARJDOL), 2)), GFormatodeNumero((PAGOSOL / tc) + (PAGODOL) + (PAGOTARJSOL / tc) + (PAGOTARJDOL) + CREDITO, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If

            'CUADRE TOTAL ING/SALIDAS
            Dim CAD As String = ""
            Dim SIMB As String = ""
            Dim EFECTS As Double = 0
            Dim EFECTD As Double = 0
            Dim OCOMANDO2 As New SqlCommand("EXEC IMP_X_CAJA '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO2.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"), Trim("CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                While RS.Read
                    If RS("MON_CAJA") = "S" Then SIMB = "S/ : " Else SIMB = "$/. : "
                    If RS("TIPOMOVI") = "I" Then
                        CAD = "ING. A CAJA     " & SIMB & " (+) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS + RS("TOTAL") Else EFECTD = EFECTD + RS("TOTAL")
                    Else
                        CAD = "SAL. DE CAJA    " & SIMB & " (-) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS - RS("TOTAL") Else EFECTD = EFECTD - RS("TOTAL")
                    End If

                    SQL = Alineacion("I", IntAnchoTicket - 10, Len(CAD), CAD) &
                               Alineacion("D", IntAnchoTicket - 30, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                    file.WriteLine(SQL)
                End While
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO         S/: "), "EFECTIVO         S/: ") &
                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL, 2)), GFormatodeNumero(PAGOSOL, 2))
                file.WriteLine(SQL)
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO         $/.: "), "EFECTIVO         $/.: ") &
                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL, 2)), GFormatodeNumero(PAGODOL, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("*TOTAL EFECTIVO  S/: "), "*TOTAL EFECTIVO  S/: ") &
                                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL + EFECTS, 2)), GFormatodeNumero(PAGOSOL + EFECTS, 2))
                file.WriteLine(SQL)
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("*TOTAL EFECTIVO  $/.: "), "*TOTAL EFECTIVO  $/.: ") &
                                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL + EFECTD, 2)), GFormatodeNumero(PAGODOL + EFECTD, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            RS.Close()

            ''RESUMEN POR PRODUCTOS   
            Dim TOTART As Double = 0
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR PRODUCTOS"), Trim("RESUMEN POR PRODUCTOS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)

            Dim OCOMANDO3 As New SqlCommand("EXEC IMP_X_RESUMEN_ARTICULOS_VENTA '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO3.ExecuteReader
            While RS.Read
                SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("DESC_ART")), RS("DESC_ART")) &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                file.WriteLine(SQL)
                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X PRODUCTOS
            If CFG_MONVENTA = "S" Then
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            S/ :"), "Total            S/ :") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            Else
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total           US$ :"), "Total           US$ :") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            End If
            file.WriteLine(SQL)
            file.WriteLine("")
            ''
            ''STOCK ARTICULOS
            If CONFIG_RESUMEN_X_ARTICULOS = True Then
                TOTART = 0
                TITUT = Alineacion("C", IntAnchoTicket, Len("STOCK ARTICULOS"), Trim("STOCK ARTICULOS"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)

                Dim OCOMANDO5 As New SqlCommand("EXEC IMP_X_RESUMEN_STOCK '" & SystemInformation.ComputerName & "'", CN_NET)
                RS = OCOMANDO5.ExecuteReader
                While RS.Read
                    SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("CODIGO")), RS("CODIGO")) &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("STOCK"), 2)), GFormatodeNumero(RS("STOCK"), 2))
                    file.WriteLine(SQL)
                    SQL = Alineacion("I", IntAnchoTicket - 1, Len(RS("DESCRIPCION")), RS("DESCRIPCION"))
                    file.WriteLine(SQL)
                    TOTART = TOTART + RS("STOCK")
                End While
                RS.Close()
                ''STOCK ARTICULOS
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            :"), "Total           :") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            ''
            ''TOTAL X VENDEDORES
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR VENDEDOR"), Trim("RESUMEN POR VENDEDOR"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ''
            TOTART = 0
            Dim OCOMANDO4 As New SqlCommand("EXEC IMP_X_RESUMEN_USUARIOS '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO4.ExecuteReader
            While RS.Read
                SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("DESC_USER")), RS("DESC_USER")) &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                file.WriteLine(SQL)
                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X VENDEDORES
            If CFG_MONVENTA = "S" Then
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            S/ :"), "Total            S/ :") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            Else
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total           US$ :"), "Total           US$ :") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            End If
            file.WriteLine(SQL)
            file.WriteLine("")
            '
            Dim I As Integer
            For I = 1 To 10
                file.WriteLine("")
            Next
            file.WriteLine(Chr(27) + "i")
            '

            file.Close()
            CN_NET.Close()
            Try
                If ORIG = "P" Then
                    Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
                Else
                    Shell("NOTEPAD.EXE " & "C:\TEMP\temp.txt", AppWinStyle.MaximizedFocus)
                End If
            Catch ax As System.IO.FileNotFoundException
                MsgBox(ax.Message)
            End Try

        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)

        End Try

    End Sub

    Sub IMPRIMIR_CIERRE_X_TERMICA(FECHA_LIQ As Date, CAJA_LIQ As String, TURNO_LIQ As Integer, REIMPRIME As Integer)
        Try
            Dim OBJTC As New ClsTC
            Dim OBJPTOVTA As New ClsPtoVta
            Dim CREDITO As Double = 0
            Dim PAGOSOL As Double = 0
            Dim PAGODOL As Double = 0
            Dim PAGOTARJSOL As Double = 0
            Dim PAGOTARJDOL As Double = 0
            Dim PORTIMP As String = ""

            Dim LHead1 As String, LHead2 As String, LHead3 As String, LHead4 As String, LHead5 As String, LHead6 As String, LHead7 As String, LHead8 As String, LHead9 As String, LHead10 As String
            Dim LFoot1 As String, LFoot2 As String, LFoot3 As String, LFoot4 As String, LFoot5 As String, LFoot6 As String, LFoot7 As String, LFoot8 As String, LFoot9 As String, LFoot10 As String

            ObtenerConfiguracionTicket(1)

            Dim FGT As SizeF
            Y_INI = 5

            Dim Linea As String
            Linea = "----------------------------------------------------------------"

            ''
            Dim IntAnchoTicket = 39
            If REIMPRIME <> 0 Then
                Dim CAB_ANULADO As String
                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
                CAB_ANULADO = "*********** REIMPRESION ************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4

                CAB_ANULADO = "***************************************"
                ESCRIBIR(CAB_ANULADO, GRAFICO, "C")
                Y_INI = Y_INI + 4
            End If

            LHead1 = Trim(GHEAD1)
            LHead2 = Trim(GHEAD2)
            LHead3 = Trim(GHEAD3)
            LHead4 = Trim(GHEAD4)
            LHead5 = Trim(GHEAD5)
            LHead6 = Trim(GHEAD6)
            LHead7 = Trim(GHEAD7)
            LHead8 = Trim(GHEAD8)
            LHead9 = Trim(GHEAD9)
            LHead10 = Trim(GHEAD10)

            '---------------------------------------------------------------------------------------------
            If Trim(LHead1) <> String.Empty Then ESCRIBIR(LHead1, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead2) <> String.Empty Then ESCRIBIR(LHead2, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead3) <> String.Empty Then ESCRIBIR(LHead3, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead4) <> String.Empty Then ESCRIBIR(LHead4, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead5) <> String.Empty Then ESCRIBIR(LHead5, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead6) <> String.Empty Then ESCRIBIR(LHead6, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead7) <> String.Empty Then ESCRIBIR(LHead7, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead8) <> String.Empty Then ESCRIBIR(LHead8, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead9) <> String.Empty Then ESCRIBIR(LHead9, GRAFICO, "C") : Y_INI = Y_INI + 4
            If Trim(LHead10) <> String.Empty Then ESCRIBIR(LHead10, GRAFICO, "C") : Y_INI = Y_INI + 4

            'Imprimir la Linea
            Dim LLinea1 As String
            LLinea1 = Trim(GstrLinea1)
            If Trim(LLinea1) <> String.Empty Then ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4

            'IMPRIMO CABECERA
            Dim strTITUT As String
            strTITUT = "CIERRE (X)"
            ESCRIBIR(strTITUT, GRAFICO, "C")
            Y_INI = Y_INI + 4
            strTITUT = "TURNO :" & TURNO & ""
            ESCRIBIR(strTITUT, GRAFICO, "C")
            Y_INI = Y_INI + 4

            ' Imprimir Numero de Máquina Registradora
            Dim strRESUMEN As String
            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = "Maq.Regist.No       : "
            ESCRIBIR(strMaquinaReg, GRAFICO, "I")
            strMaquinaReg = "N/S: " & GStrMaquinaReg ' & Format(DatFechaImpresion, "dd/mm/yyyy")
            ESCRIBIR(strMaquinaReg, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Imprimir FECHA
            Dim strfecha As String
            strfecha = "Fecha: "
            ESCRIBIR(strfecha, GRAFICO, "I")
            strfecha = Format(FECHA_LIQ, "dd/MM/yyyy")
            ESCRIBIR(strfecha, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Imprimir HORA
            Dim strhora As String
            Dim HORA As String = Format(DateTime.Now, "HH:mm:ss")
            strhora = "Hora: "
            ESCRIBIR(strhora, GRAFICO, "I")
            strhora = HORA
            ESCRIBIR(strhora, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ' Imprimir TC
            Dim strcambio As String
            Dim tc As String = GFormatodeNumero(OBJTC.BUSCAR_TC(GFechaProceso, "V"), 3)
            strcambio = "Tipo de Cambio      : "
            ESCRIBIR(strcambio, GRAFICO, "I")
            strcambio = tc
            ESCRIBIR(strcambio, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4

            Dim TITUT As String
            TITUT = "REPORTE DE TICKETS"
            ESCRIBIR(TITUT, GRAFICO, "C")
            Y_INI = Y_INI + 4

            ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4

            ''LLENANDO DATOS DE TICKET
            Dim RS As SqlDataReader
            Dim PAGOS As Double, PAGOD As Double, VUELTO As Double

            Dim MON_IMP As String = IIf(CFG_MONVENTA = "S", "S/", "US$")

            Dim OCOMANDO As New SqlCommand("EXEC IMP_X_RESUMEN '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            If RS.HasRows = True Then
                While RS.Read
                    ' Imprimir Nro de Transacciones
                    Dim strnrotransac As String
                    strnrotransac = ""
                    strnrotransac = Trim("Nro. Transac.       : ")
                    ESCRIBIR(strnrotransac, GRAFICO, "I")
                    strnrotransac = RS("cant")
                    ESCRIBIR(strnrotransac, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir Ticket Inicial
                    Dim strticketini As String
                    strticketini = Trim("Num. Ticket Ini.    : ")
                    ESCRIBIR(strticketini, GRAFICO, "I")
                    strticketini = FormatoTicket(RS("minimo"))
                    ESCRIBIR(strticketini, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir Ticket Final
                    Dim strticketfin As String
                    strticketfin = Trim("Num. Ticket Fin.    : ")
                    ESCRIBIR(strticketfin, GRAFICO, "I")
                    strticketfin = FormatoTicket(RS("maximo"))
                    ESCRIBIR(strticketfin, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir Valor Venta
                    Dim strvv As String
                    strvv = Trim("Valor Venta")
                    ESCRIBIR(strvv, GRAFICO, "I")
                    strvv = Trim(MON_IMP)
                    ESCRIBIR(strvv, GRAFICO, "C")
                    strvv = FormatoTicket(GFormatodeNumero(RS("valor"), 2))
                    ESCRIBIR(strvv, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir IGV
                    Dim strigv As String
                    strigv = Trim("I.G.V.")
                    ESCRIBIR(strigv, GRAFICO, "I")
                    strvv = Trim(MON_IMP)
                    ESCRIBIR(strvv, GRAFICO, "C")
                    strigv = FormatoTicket(GFormatodeNumero(RS("IGV"), 2))
                    ESCRIBIR(strigv, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir Total
                    Dim strtotal As String
                    strtotal = Trim("Venta Total")
                    ESCRIBIR(strtotal, GRAFICO, "I")
                    strvv = Trim(MON_IMP)
                    ESCRIBIR(strvv, GRAFICO, "C")
                    strtotal = FormatoTicket(GFormatodeNumero(RS("total"), 2))
                    ESCRIBIR(strtotal, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir Nro de Tickets Anulados
                    Dim strticketanul As String
                    strticketanul = Trim("Num.Ticket Anul.: ")
                    ESCRIBIR(strticketanul, GRAFICO, "I")
                    strticketanul = RS("anulados")
                    ESCRIBIR(strticketanul, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                    ' Imprimir Total de Tickets Anulados
                    Dim strmontoanul As String
                    strmontoanul = Trim("Tot.Ticket Anul. ")
                    ESCRIBIR(strmontoanul, GRAFICO, "I")
                    strvv = Trim(MON_IMP)
                    ESCRIBIR(strvv, GRAFICO, "C")
                    strmontoanul = GFormatodeNumero(RS("total_anul"), 2)
                    ESCRIBIR(strmontoanul, GRAFICO, "D")
                    Y_INI = Y_INI + 4
                    ''
                    PAGOS = RS("PAGOS")
                    PAGOD = RS("PAGOD")
                    VUELTO = RS("VUELTO")
                    CREDITO = RS("CREDITO")
                End While
            Else
                MsgBox("No hay Transacciones en esta Caja", MsgBoxStyle.Information) : RS.Close() : CN_NET.Close() : Exit Sub
            End If
            RS.Close()
            Y_INI = Y_INI + 4
            ''TIPO DE PAGOS
            TITUT = "RESUMEN POR TIPOS DE PAGOS"
            ESCRIBIR(TITUT, GRAFICO, "C")
            Y_INI = Y_INI + 4
            ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
            ' Imprimir Efectivo Soles
            Dim strtotsoles As String
            strtotsoles = Trim("EFECTIVO")
            ESCRIBIR(strtotsoles, GRAFICO, "I")
            strtotsoles = Trim("S/")
            ESCRIBIR(strtotsoles, GRAFICO, "C")
            strtotsoles = GFormatodeNumero(PAGOS, 2)
            ESCRIBIR(strtotsoles, GRAFICO, "D")
            Y_INI = Y_INI + 4

            If CFG_MONVENTA = "S" Then
                ' Imprimir Vuelto Soles
                Dim strvueltosoles As String
                strvueltosoles = Trim("VUELTO")
                ESCRIBIR(strvueltosoles, GRAFICO, "I")
                strvueltosoles = Trim("S/")
                ESCRIBIR(strvueltosoles, GRAFICO, "C")
                strvueltosoles = GFormatodeNumero(VUELTO, 2)
                ESCRIBIR(strvueltosoles, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Soles
                Dim strnetosoles As String
                strnetosoles = Trim("NETO")
                ESCRIBIR(strnetosoles, GRAFICO, "I")
                strnetosoles = Trim("S/")
                ESCRIBIR(strnetosoles, GRAFICO, "C")
                strnetosoles = GFormatodeNumero(PAGOS - VUELTO, 2)
                ESCRIBIR(strnetosoles, GRAFICO, "D")
                Y_INI = Y_INI + 4

                PAGOSOL = PAGOS - VUELTO
            Else
                ' Imprimir Vuelto Soles
                Dim strvueltosoles As String
                strvueltosoles = Trim("VUELTO")
                ESCRIBIR(strvueltosoles, GRAFICO, "I")
                strvueltosoles = Trim("S/")
                ESCRIBIR(strvueltosoles, GRAFICO, "C")
                strvueltosoles = GFormatodeNumero(0, 2)
                ESCRIBIR(strvueltosoles, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Soles
                Dim strnetosoles As String
                strnetosoles = Trim("NETO")
                ESCRIBIR(strnetosoles, GRAFICO, "I")
                strnetosoles = Trim("S/")
                ESCRIBIR(strnetosoles, GRAFICO, "C")
                strnetosoles = GFormatodeNumero(PAGOS - 0, 2)
                ESCRIBIR(strnetosoles, GRAFICO, "D")
                Y_INI = Y_INI + 4

                PAGOSOL = PAGOS
            End If
            ' Imprimir Efectivo Dolares
            Dim strtotdol As String
            strtotdol = Trim("EFECTIVO")
            ESCRIBIR(strtotdol, GRAFICO, "I")
            strtotdol = Trim("US$")
            ESCRIBIR(strtotdol, GRAFICO, "C")
            strtotdol = GFormatodeNumero(PAGOD, 2)
            ESCRIBIR(strtotdol, GRAFICO, "D")
            Y_INI = Y_INI + 4
            If CFG_MONVENTA = "D" Then
                ' Imprimir Vuelto Dolares
                Dim strvueltodol As String
                strvueltodol = Trim("VUELTO")
                ESCRIBIR(strvueltodol, GRAFICO, "I")
                strvueltodol = Trim("US$")
                ESCRIBIR(strvueltodol, GRAFICO, "C")
                strvueltodol = GFormatodeNumero(VUELTO, 2)
                ESCRIBIR(strvueltodol, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Dolares
                Dim strnetodol As String
                strnetodol = Trim("NETO")
                ESCRIBIR(strnetodol, GRAFICO, "I")
                strnetodol = Trim("US$")
                ESCRIBIR(strnetodol, GRAFICO, "C")
                strnetodol = GFormatodeNumero(PAGOD - VUELTO, 2)
                ESCRIBIR(strnetodol, GRAFICO, "D")
                Y_INI = Y_INI + 4

                PAGODOL = PAGOD - VUELTO
            Else
                ' Imprimir Vuelto Dolares
                Dim strvueltodol As String
                strvueltodol = Trim("VUELTO")
                ESCRIBIR(strvueltodol, GRAFICO, "I")
                strvueltodol = Trim("US$")
                ESCRIBIR(strvueltodol, GRAFICO, "C")
                strvueltodol = GFormatodeNumero(0, 2)
                ESCRIBIR(strvueltodol, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Dolares
                Dim strnetodol As String
                strnetodol = Trim("NETO")
                ESCRIBIR(strnetodol, GRAFICO, "I")
                strnetodol = Trim("US$")
                ESCRIBIR(strnetodol, GRAFICO, "C")
                strnetodol = GFormatodeNumero(PAGOD, 2)
                ESCRIBIR(strnetodol, GRAFICO, "D")
                Y_INI = Y_INI + 4

                PAGODOL = PAGOD

            End If
            ''''
            Y_INI = Y_INI + 4
            ''TARJETA EN SOLES
            Dim SQL As String
            Dim tots As Double = 0, totd As Double = 0
            Dim OCOMANDO1 As New SqlCommand("EXEC IMP_X_RESUMEN_TARJETAS '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                TITUT = "TARJETAS EN SOLES"
                ESCRIBIR(TITUT, GRAFICO, "C")
                Y_INI = Y_INI + 4
                ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
                Y_INI = Y_INI + 4
                While RS.Read
                    ' Imprimir Soles
                    If RS("MON_TARJETA") = "S" Then
                        SQL = Trim(RS("COD_TARJETA")) + "   " + Trim(RS("DESC_TARJETA"))
                        ESCRIBIR(SQL, GRAFICO, "I")
                        SQL = GFormatodeNumero(RS("TOTAL"), 2)
                        ESCRIBIR(SQL, GRAFICO, "D")
                        Y_INI = Y_INI + 4

                        tots = tots + RS("TOTAL")
                    End If
                    ''If RS("MON_TARJETA") = "D" Then
                    ''    SQL = Trim(RS("COD_TARJETA")) + "   " + Trim(RS("DESC_TARJETA"))
                    ''    ESCRIBIR(SQL, GRAFICO, "I")
                    ''    SQL = GFormatodeNumero(RS("TOTAL"), 2)
                    ''    ESCRIBIR(SQL, GRAFICO, "D")
                    ''    Y_INI = Y_INI + 4

                    ''    totd = totd + RS("TOTAL")
                    ''End If
                End While
            End If
            RS.Close()
            PAGOTARJSOL = tots
            Y_INI = Y_INI + 4
            ' Imprimir Total Tarjetas Soles
            SQL = Trim("TOTAL")
            ESCRIBIR(SQL, GRAFICO, "I")
            SQL = Trim("S/")
            ESCRIBIR(SQL, GRAFICO, "C")
            SQL = GFormatodeNumero(tots, 2)
            ESCRIBIR(SQL, GRAFICO, "D")
            Y_INI = Y_INI + 4

            Y_INI = Y_INI + 4
            ' Imprimir Dolares
            ''TARJETA EN DOLARES
            OCOMANDO1 = New SqlCommand("EXEC IMP_X_RESUMEN_TARJETAS '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                TITUT = "TARJETAS EN DOLARES"
                ESCRIBIR(TITUT, GRAFICO, "C")
                Y_INI = Y_INI + 4
                ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
                Y_INI = Y_INI + 4
                While RS.Read
                    If RS("MON_TARJETA") = "D" Then
                        SQL = Trim(RS("COD_TARJETA")) + "   " + Trim(RS("DESC_TARJETA"))
                        ESCRIBIR(SQL, GRAFICO, "I")
                        SQL = GFormatodeNumero(RS("TOTAL"), 2)
                        ESCRIBIR(SQL, GRAFICO, "D")
                        Y_INI = Y_INI + 4
                        totd = totd + RS("TOTAL")
                    End If
                End While
            End If
            RS.Close()
            PAGOTARJDOL = totd

            ' Imprimir Total Tarjetas Dolares
            SQL = Trim("TOTAL")
            ESCRIBIR(SQL, GRAFICO, "I")
            SQL = Trim("US$")
            ESCRIBIR(SQL, GRAFICO, "C")
            SQL = GFormatodeNumero(totd, 2)
            ESCRIBIR(SQL, GRAFICO, "D")
            Y_INI = Y_INI + 4

            Y_INI = Y_INI + 4

            ''  RESUMEN VENTA POR TIPO PAGO EN SOLES  
            If CFG_MONVENTA = "S" Then
                TITUT = "RESUMEN VENTA POR TIPO PAGO EN SOLES"
                ESCRIBIR(TITUT, GRAFICO, "C")
                Y_INI = Y_INI + 4
                ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
                ' Imprimir Neto Soles
                SQL = Trim("NETO")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("S/")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOSOL, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Dolares en Soles
                SQL = Trim("NETO $")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("S/")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGODOL * tc, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Tarjeta en Soles
                SQL = Trim("TARJETA")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("S/")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOTARJSOL, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Tarjeta Dolares en Soles
                SQL = Trim("TARJ. $")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("S/")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOTARJDOL * tc, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir CREDITO
                SQL = Trim("CREDITO")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("S/")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(CREDITO, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Total Tipo de Pagos
                SQL = Trim("TOTAL")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("S/")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc) + CREDITO, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                Y_INI = Y_INI + 4
            Else
                TITUT = "RESUMEN VENTA POR TIPO PAGO EN DOLARES"
                ESCRIBIR(TITUT, GRAFICO, "C")
                Y_INI = Y_INI + 4
                ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
                ' Imprimir Neto Soles
                ''SQL = Trim("NETO        US$: ")
                SQL = Trim("NETO ")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("US$: ")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGODOL, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Dolares en Soles
                SQL = Trim("NETO S/  ")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("US$: ")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOSOL / tc, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Tarjeta en Soles
                SQL = Trim("TARJETA")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("US$: ")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOTARJDOL, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Neto Tarjeta Dolares en Soles
                SQL = Trim("TARJ. S/")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("US$: ")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGOTARJSOL / tc, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir CREDITO
                SQL = Trim("CREDITO")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("US$: ")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(CREDITO, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                ' Imprimir Total Tipo de Pagos
                SQL = Trim("TOTAL")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = Trim("US$: ")
                ESCRIBIR(SQL, GRAFICO, "C")
                SQL = GFormatodeNumero(PAGODOL + (PAGOSOL / tc) + PAGOTARJDOL + (PAGOTARJSOL / tc) + CREDITO, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                Y_INI = Y_INI + 4
            End If

            'CUADRE TOTAL ING/SALIDAS
            Dim CAD As String = ""
            Dim SIMB As String = ""
            Dim EFECTS As Double = 0
            Dim EFECTD As Double = 0
            Dim OCOMANDO2 As New SqlCommand("EXEC IMP_X_CAJA '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO2.ExecuteReader
            If RS.HasRows = True Then
                TITUT = "CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"
                ESCRIBIR(TITUT, GRAFICO, "C")
                Y_INI = Y_INI + 4

                ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
                While RS.Read
                    If RS("MON_CAJA") = "S" Then SIMB = "S/ : " Else SIMB = "$/. : "
                    If RS("TIPOMOVI") = "I" Then
                        CAD = "ING. A CAJA     " & SIMB & " (+) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS + RS("TOTAL") Else EFECTD = EFECTD + RS("TOTAL")
                    Else
                        CAD = "SAL. DE CAJA    " & SIMB & " (-) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS - RS("TOTAL") Else EFECTD = EFECTD - RS("TOTAL")
                    End If

                    SQL = Trim(CAD)
                    ESCRIBIR(SQL, GRAFICO, "I")
                    SQL = GFormatodeNumero(RS("TOTAL"), 2)
                    ESCRIBIR(SQL, GRAFICO, "D")
                    Y_INI = Y_INI + 4

                End While
                SQL = Trim("EFECTIVO         S/: ")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(PAGOSOL, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                SQL = Trim("EFECTIVO         $/.: ")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(PAGODOL, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                Y_INI = Y_INI + 4

                SQL = Trim("*TOTAL EFECTIVO  S/: ")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(PAGOSOL + EFECTS, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                SQL = Trim("*TOTAL EFECTIVO  $/.: ")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(PAGODOL + EFECTD, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                Y_INI = Y_INI + 4
            End If
            RS.Close()

            ''RESUMEN POR PRODUCTOS   
            Dim TOTART As Double = 0
            TITUT = "RESUMEN POR PRODUCTOS"
            ESCRIBIR(TITUT, GRAFICO, "C")
            Y_INI = Y_INI + 4

            ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4

            Dim OCOMANDO3 As New SqlCommand("EXEC IMP_X_RESUMEN_ARTICULOS_VENTA '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO3.ExecuteReader
            While RS.Read
                SQL = Trim(RS("DESC_ART"))
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(RS("TOTAL"), 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X PRODUCTOS
            SQL = Trim("Total            " + MON_IMP + " :")
            ESCRIBIR(SQL, GRAFICO, "I")
            SQL = GFormatodeNumero(TOTART, 2)
            ESCRIBIR(SQL, GRAFICO, "D")
            Y_INI = Y_INI + 4

            ''
            ''STOCK ARTICULOS
            Dim LstrDescripcion As String
            If CONFIG_RESUMEN_X_ARTICULOS = True Then
                TOTART = 0
                TITUT = "STOCK ARTICULOS"
                ESCRIBIR(TITUT, GRAFICO, "C")
                Y_INI = Y_INI + 4

                ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4

                Dim OCOMANDO5 As New SqlCommand("EXEC IMP_X_RESUMEN_STOCK '" & SystemInformation.ComputerName & "'", CN_NET)
                RS = OCOMANDO5.ExecuteReader
                While RS.Read
                    SQL = Trim(RS("CODIGO"))
                    ESCRIBIR(SQL, GRAFICO, "I")
                    SQL = GFormatodeNumero(RS("STOCK"), 2)
                    ESCRIBIR(SQL, GRAFICO, "D")
                    Y_INI = Y_INI + 4
                    ''
                    LstrDescripcion = Trim(RS("DESCRIPCION"))
                    ESCRIBIR(LstrDescripcion, GRAFICO, "I")
                    Y_INI = Y_INI + 4
                    ''
                    TOTART = TOTART + RS("STOCK")
                End While
                RS.Close()
                ''STOCK ARTICULOS
                SQL = Trim("Total            :")
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(TOTART, 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4
            End If
            ''

            ''
            Y_INI = Y_INI + 4
            ''TOTAL X VENDEDORES
            TITUT = "RESUMEN POR VENDEDOR"
            ESCRIBIR(TITUT, GRAFICO, "C")
            Y_INI = Y_INI + 4

            ESCRIBIR(LLinea1, GRAFICO, "C") : Y_INI = Y_INI + 4
            ''
            TOTART = 0
            Dim OCOMANDO4 As New SqlCommand("EXEC IMP_X_RESUMEN_USUARIOS '" & Format(FECHA_LIQ, "dd/MM/yyyy") & "','" & CAJA_LIQ.Trim & "'," & TURNO_LIQ & "", CN_NET)
            RS = OCOMANDO4.ExecuteReader
            While RS.Read
                SQL = Trim(RS("DESC_USER"))
                ESCRIBIR(SQL, GRAFICO, "I")
                SQL = GFormatodeNumero(RS("TOTAL"), 2)
                ESCRIBIR(SQL, GRAFICO, "D")
                Y_INI = Y_INI + 4

                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X VENDEDORES
            SQL = Trim("Total            " + MON_IMP + " :")
            ESCRIBIR(SQL, GRAFICO, "I")
            SQL = GFormatodeNumero(TOTART, 2)
            ESCRIBIR(SQL, GRAFICO, "D")
            Y_INI = Y_INI + 4

            Y_INI = Y_INI + 4
            '
            CN_NET.Close()


        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)

        End Try

    End Sub

End Module
