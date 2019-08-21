Public Class Reimpresion

    Dim OBJVENTAS As ClsVenta
    Dim OBJPTOVTA As ClsPtoVta
    Dim OBJPAGOS As ClsPagos
    ''IMPRESION
    Dim REIMPRIME As Integer = 1
    Dim STRESTADO As String
    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "APTOCODI"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "APTOFEPO"
        arraybusqueda(2, 2) = "Proceso "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "APTOTERM"
        arraybusqueda(3, 2) = "Terminal "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "ESTADO"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_PtoVta"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                ' Me.TXT_COD.Text = .GrecibeColumnaID
                Me.TXT_CAJA.Text = .GrecibeColumnaOpcional2
                'ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub

    Private Sub Reimpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJVENTAS = New ClsVenta
        OBJPTOVTA = New ClsPtoVta
        OBJPAGOS = New ClsPagos
        ObtenerConfiguracionTicket(1)
        LISTAR_TIPO_DOC(Me.Combo_DOC, "V")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Lineas que llaman al Formulario de Búsqueda
        Try
            Dim arraybusqueda(4, 3) As Object
            arraybusqueda(1, 1) = "DESC_CLIENTE"
            arraybusqueda(1, 2) = "Cliente"
            arraybusqueda(1, 3) = 1500
            arraybusqueda(2, 1) = "NRODOCU"
            arraybusqueda(2, 2) = "Documento "
            arraybusqueda(2, 3) = 3000
            arraybusqueda(3, 1) = "total_venta"
            arraybusqueda(3, 2) = "Total "
            arraybusqueda(3, 3) = 1500
            arraybusqueda(4, 1) = "estado"
            arraybusqueda(4, 2) = "Estado"
            arraybusqueda(4, 3) = 1500


            ''
            With BusquedaMaestra
                .ACT = "Ventas_Documentos_R"
                .STATINI = 2
                .CARGAR_COMBO(arraybusqueda, 4, 2)
                .TIPO = 0
                .FECHA = Me.TXT_FECHA.Value
                .TURNO = Me.TXT_TURNO.Text
                .COD_DOC = Me.Combo_DOC.SelectedValue
                .COD_CLIE = Me.TXT_CAJA.Text.Trim
                '.TxtDatoBuscado.Text = Me.TXT_PROV.Tag


                .ShowDialog()

                ''
                If .GrecibeColumnaOpcional <> "" Then
                    '*If .GrecibeColumnaOpcional3 <> "" Then MsgBox("Este Documento se encuentra Anulado", MsgBoxStyle.Information) : Exit Sub
                    Me.TXT_NUM.Text = FormatoTicket(BusquedaMaestra.GrecibeColumnaOpcional)

                    ASIGNAR_DATOS_VENTA()
                    'OBJVENTAS.MOSTRAR_DETALLE(Me.Combo_DOC.SelectedValue, .GrecibeColumnaOpcional, Me.DBLISTAR)

                End If
                .Close()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub ASIGNAR_DATOS_VENTA()
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJVENTAS.MOSTRAR_CABECERA(Me.COMBO_DOC.SelectedValue, BusquedaMaestra.GrecibeColumnaOpcional)
        'If Not (RS.EOF And RS.BOF) Then
        While RS.Read
            'Me.TXT_NUM.Text = FormatoTicket(BusquedaMaestra.GrecibeColumnaOpcional)
            'Me.DT_DOC.Value = RS("FECHA_VENTA")
            Me.TXT_CODCLIE.Text = RS("COD_CLIENTE")
            Me.TXT_RUC.Text = NULO(RS("RUC_CLIENTE"), "S")
            Me.TXT_DIRECCION.Text = NULO(RS("DIR_CLIENTE"), "S")
            Me.TXT_RAZON.Text = NULO(RS("DESC_CLIENTE"), "S")
            Me.TXT_VVENTA.Text = RS("SUBTOT_VENTA")
            Me.TXT_IGV.Text = RS("IGV_VENTA")
            Me.TXT_TOTAL.Text = RS("TOTAL_VENTA")
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim CN_NET1 As New SqlConnection
            Dim RS1 As SqlDataReader
            REIMPRIME = 1
            CN_NET1.ConnectionString = CAD_CON
            CN_NET1.Open()
            RS1 = OBJVENTAS.LISTAR_DOC_VENTAS(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NUM.Text), ArmaNumero(Me.TXT_NUM_FIN.Text), Me.TXT_CAJA.Text.Trim, Me.TXT_TURNO.Text, CN_NET1)
            'If Not (RS.EOF And RS.BOF) Then
            While RS1.Read
                IMPRIMIR(RS1("FECHA_VENTA"), RS1("DOCUMENTO"), RS1("DESC_CLIENTE"), RS1("RUC_CLIENTE"), RS1("DIR_CLIENTE"), RS1("SUBTOT_VENTA"), RS1("IGV_VENTA"), RS1("TOTAL"))

            End While
            RS1.Close()
            CN_NET1.CLOSE()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub


    Public Sub IMPRIMIR(ByVal FECHA As Date, ByVal NUM As String, ByVal RAZON As String, ByVal RUC As String, ByVal DIRECCION As String, ByVal VENTA As String, ByVal IGV As String, ByVal TOTAL As String)
        Try
            'Dim Fuente As New System.Drawing.Font("Arial", 8)
            'Dim Grafico As System.Drawing.Graphics = e.Graphics
            Dim PORTIMP As String
            Dim TOTG As Double = 0
            Dim DSCTO As Boolean = False
            ''**
            Dim NewFont As Font
            NewFont = New Font("Symbol", 40, FontStyle.Regular)
            ''**
            ''AVERIGUAR PUERTO DE IMPRESION
            If Me.Opt_Impresora.Checked = True Then
                PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP(Me.Combo_DOC.SelectedValue)
                If PORTIMP = "" Then MsgBox("punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            End If
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
            Font = NewFont
            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            If REIMPRIME = 0 Then
                strMaquinaReg = Alineacion("I", IntAnchoTicket - 10, Len("Maq.Regist.No: " & GStrMaquinaReg), "Maq.Regist.No: " & GStrMaquinaReg) & Format(GDatFechaActual, "dd/MM/yyyy")
            Else
                strMaquinaReg = Alineacion("I", IntAnchoTicket - 10, Len("Maq.Regist.No: " & GStrMaquinaReg), "Maq.Regist.No: " & GStrMaquinaReg) & Format(FECHA, "dd/MM/yyyy")
            End If
            file.WriteLine(strMaquinaReg, Font)

            ' Imprimir el Número del Ticket
            Dim StrNumeroTicket As String
            Dim DOCU As String = IIf(Strings.Left(Me.Combo_DOC.Text, 1) = "B", " BOL. ", " FACT.")
            Dim STRTIPODOC = "Ticket No" & DOCU
            StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(STRTIPODOC & ":" & (NUM)), STRTIPODOC & ": " & (NUM)) & Format(DateTime.Now, "HH:mm:ss")
            file.WriteLine(StrNumeroTicket)

            ' Imprimir los Datos del Cliente
            If Trim(Me.TXT_RAZON.Text) <> Nothing Then
                Dim LStrRazonSocial As String
                LStrRazonSocial = Alineacion("I", IntAnchoTicket, Len("Raz.Soc:" & RAZON.Trim), "NOMBRE :" & RAZON.Trim)
                file.WriteLine(LStrRazonSocial)
            End If

            If Trim(Me.TXT_RUC.Text) <> Nothing Then
                Dim LStrRUC As String
                LStrRUC = Alineacion("I", IntAnchoTicket, Len("RUC    :" & RUC.Trim), "RUC    :" & RUC.Trim)
                file.WriteLine(LStrRUC)
            End If

            If Trim(Me.TXT_DIRECCION.Text) <> Nothing Then
                Dim LstrDireccion As String
                LstrDireccion = Alineacion("I", IntAnchoTicket, Len("DIRECC.:" & DIRECCION.Trim), "DIRECC :" & DIRECCION.Trim)
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
            Dim OCOMANDO As New SqlCommand("EXEC VENTA_MOSTRAR_DETALLE '" & Me.Combo_DOC.SelectedValue & "'," & ArmaNumero(NUM) & "", CN_NET)
            CN_NET.Open()
            RSDET = OCOMANDO.ExecuteReader
            While RSDET.Read
                Dim LstrProducto As String
                Dim LstrDescripcion As String

                'RSDET.MoveFirst()

                'Do While Not RSDET.EOF

                ' El precio del Producto se Muestra a la Moneda Levantada (MonedaRelacionada)
                ' Y ase Graba en la Moneda Solicitada

                LstrProducto = Alineacion("I", 15, Len(Trim(RSDET("CODIGO"))), Trim(RSDET("CODIGO"))) & _
                               Alineacion("I", 7, Len(Trim(RSDET("MEDIDA"))), Trim(RSDET("MEDIDA"))) & _
                               Alineacion("I", 11, Len(GFormatodeNumero(RSDET("CANTIDAD"), 4) & "x"), (GFormatodeNumero(RSDET("CANTIDAD"), 4)) & "x") & _
                               Alineacion("D", IntAnchoTicket - 10 - 5 - 11 - 8, Len(GFormatodeNumero(RSDET("PU"), 2)), GFormatodeNumero(RSDET("PU"), 2))

                file.WriteLine(LstrProducto)

                'If StrCodMoneda = GstrCodMonedaBase Then
                LstrDescripcion = Alineacion("I", 30, Len(Trim(RSDET("DESCRIPCION"))), Trim(RSDET("DESCRIPCION"))) & _
                                  Alineacion("D", IntAnchoTicket - 30, Len(GFormatodeNumero(RSDET("TOTALSD"), 2)), GFormatodeNumero(RSDET("TOTALSD"), 2))
                'Else
                'LstrDescripcion = Alineacion("I", 30, Len(Trim(RsDetalleTemporal!DESCRINVENTORY)), Trim(RsDetalleTemporal!DESCRINVENTORY)) & _
                '                 Alineacion("D", IntAnchoTicket - 30, Len(GFormatodeNumero(RsDetalleTemporal!TOTALUSD, Gdeciprec)), GFormatodeNumero(RsDetalleTemporal!TOTALUSD, Gdeciprec))
                'End If
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
            ''IMPRIMO DESCUENTO
            If DSCTO = True Then
                Dim StrTotalSD As String
                StrTotalSD = Alineacion("I", 17, Len("**** DESCUENTO   "), "**** DESCUENTO   ")
                StrTotalSD = StrTotalSD & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                StrTotalSD = StrTotalSD & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(TOTG - TOTAL, 2)), GFormatodeNumero(TOTG - TOTAL, 2))
                file.WriteLine(StrTotalSD)
                If Trim(LLinea3) <> Nothing Then
                    file.WriteLine(LLinea3)
                End If
            End If
            ''**
            If Trim(Me.TXT_RUC.Text) <> Nothing Then
                Dim StrValoventa As String
                StrValoventa = Alineacion("I", 17, Len("**** Valor Venta "), "**** Valor Venta ")

                'If StrCodMoneda = GstrCodMonedaBase Then
                StrValoventa = StrValoventa & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                StrValoventa = StrValoventa & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(VENTA, 2)), GFormatodeNumero(VENTA, 2))
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

            Dim StrTipoPagoImp As String
            Dim RSTARJETA As SqlDataReader 'New ADODB.Recordset
            RSTARJETA = OBJPAGOS.MOSTRAR_TARJETA_DETALLE(Me.Combo_DOC.SelectedValue, ArmaNumero(NUM))
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
                If Strings.Left(LSTR_MONEDA, 1) = "S" Then SIMBOLO = GstrSimbMonedaBase Else SIMBOLO = GstrSimbMonedaExtr
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
            Dim Strefectivopagado As String
            Dim RSPAGO As SqlDataReader 'New ADODB.Recordset
            RSPAGO = OBJVENTAS.MOSTRAR_CABECERA(Me.Combo_DOC.SelectedValue, ArmaNumero(NUM))
            'If RSPAGO.HasRows = True Then
            While RSPAGO.Read
                If RSPAGO("PAGOS_VENTA") <> 0 Or RSPAGO("PAGOS_VENTA") <> 0 Then
                    Strefectivopagado = Alineacion("I", 10, Len("EFECTIVO: "), "EFECTIVO: ")
                    If RSPAGO("PAGOS_VENTA") > 0 Then
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 3, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 10, Len(GFormatodeNumero(Str(RSPAGO("PAGOS_VENTA")), 2)), GFormatodeNumero(Str(RSPAGO("PAGOS_VENTA")), 2))
                    End If
                    If RSPAGO("PAGOD_VENTA") > 0 Then
                        Strefectivopagado = Strefectivopagado & Alineacion("I", 3, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
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
            Else
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
                If Me.Opt_Impresora.Checked = True Then
                    Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
                Else
                    Shell("NOTEPAD.EXE " & "C:\TEMP\temp.txt", AppWinStyle.MaximizedFocus)
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
        Threading.Thread.Sleep(100)
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
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim VALOR As Integer
            If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            VALOR = OBJVENTAS.ANULAR_VENTA(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NUM.Text))
            If VALOR = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
            If VALOR = 0 Then MsgBox("Anulado Correctamente", MsgBoxStyle.Information)
            ''
            Dim CN_NET1 As New SqlConnection
            Dim RS1 As SqlDataReader
            REIMPRIME = 2
            CN_NET1.ConnectionString = CAD_CON
            CN_NET1.Open()
            RS1 = OBJVENTAS.LISTAR_DOC_VENTAS(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NUM.Text), ArmaNumero(Me.TXT_NUM_FIN.Text), Me.TXT_CAJA.Text.Trim, Me.TXT_TURNO.Text, CN_NET1)
            'If Not (RS.EOF And RS.BOF) Then
            While RS1.Read
                IMPRIMIR(RS1("FECHA_VENTA"), RS1("DOCUMENTO"), RS1("DESC_CLIENTE"), RS1("RUC_CLIENTE"), RS1("DIR_CLIENTE"), RS1("SUBTOT_VENTA"), RS1("IGV_VENTA"), RS1("TOTAL"))

            End While
            RS1.Close()
            CN_NET1.Close()
            'Button_CANCELAR_Click(Button_CANCELAR, EventArgs.Empty)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Lineas que llaman al Formulario de Búsqueda
        Try
            Dim arraybusqueda(4, 3) As Object
            arraybusqueda(1, 1) = "DESC_CLIENTE"
            arraybusqueda(1, 2) = "Cliente"
            arraybusqueda(1, 3) = 1500
            arraybusqueda(2, 1) = "NRODOCU"
            arraybusqueda(2, 2) = "Documento "
            arraybusqueda(2, 3) = 3000
            arraybusqueda(3, 1) = "total_venta"
            arraybusqueda(3, 2) = "Total "
            arraybusqueda(3, 3) = 1500
            arraybusqueda(4, 1) = "estado"
            arraybusqueda(4, 2) = "Estado"
            arraybusqueda(4, 3) = 1500


            ''
            With BusquedaMaestra
                .ACT = "Ventas_Documentos_R"
                .STATINI = 2
                .CARGAR_COMBO(arraybusqueda, 4, 2)
                .TIPO = 0
                .FECHA = Me.TXT_FECHA.Value
                .TURNO = Me.TXT_TURNO.Text
                .COD_DOC = Me.Combo_DOC.SelectedValue
                .COD_CLIE = Me.TXT_CAJA.Text.Trim
                '.TxtDatoBuscado.Text = Me.TXT_PROV.Tag


                .ShowDialog()

                ''
                If .GrecibeColumnaOpcional <> "" Then
                    '*If .GrecibeColumnaOpcional3 <> "" Then MsgBox("Este Documento se encuentra Anulado", MsgBoxStyle.Information) : Exit Sub
                    Me.TXT_NUM_FIN.Text = FormatoTicket(BusquedaMaestra.GrecibeColumnaOpcional)
                    ASIGNAR_DATOS_VENTA()
                    'OBJVENTAS.MOSTRAR_DETALLE(Me.Combo_DOC.SelectedValue, .GrecibeColumnaOpcional, Me.DBLISTAR)

                End If
                .Close()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Combo_DOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_DOC.SelectedIndexChanged

    End Sub
End Class