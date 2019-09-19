Imports System.Drawing.Printing
Imports C1.Win.C1FlexGrid

Public Class Ventas_V2
    Dim OBJVENTAS As ClsVenta
    Dim OBJTC As ClsTC
    Dim OBJCLIE As ClsCliente
    Dim OBJUSU As ClsUsu
    Dim OBJPAGOS As ClsPagos
    Dim OBJPTOVTA As ClsPtoVta
    Dim OBJART As ClsArticulo

    Dim intvalor As Integer
    Dim CORR As Integer
    ''IMPRESION
    Public REIMPRIME As Integer
    Dim STRESTADO As String

    Dim DOCU As String
    Public Tdoc As String
    ''
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String
    Public GrecibeColumnaOpcional4 As String

    Dim COL_ID As Integer = 0
    Dim COL_COD_ART As Integer = 1
    Dim COL_DESCRIPCION As Integer = 2
    Dim COL_UMEDIDA As Integer = 3
    Dim COL_CANT As Integer = 4
    Dim COL_PU As Integer = 5
    Dim COL_TOTAL As Integer = 6
    Dim COL_DSCTO_P As Integer = 7
    Dim COL_DSCTO_M As Integer = 8
    Dim COL_TOTAL_FIN As Integer = 9

    Sub BUSCAR_RUC_CLIENTE()
        If String.IsNullOrEmpty(Me.TXT_RUC_CLIENTE.Text) Then Exit Sub
        Me.TXT_COD_CLIENTE.Text = BUSCAR_CAMPO_NO_ANULADO("CLIENTES", "COD_CLIENTE", "RUC_CLIENTE", Me.TXT_RUC_CLIENTE.Text.Trim, "STAT_CLIENTE")
        If TXT_COD_CLIENTE.Text = "" Then MsgBox("Ruc no esta Registrado", MsgBoxStyle.Critical) : Exit Sub
        ASIGNAR_DATOS()
    End Sub
    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJVENTAS = New ClsVenta
        OBJTC = New ClsTC
        OBJCLIE = New ClsCliente
        OBJUSU = New ClsUsu
        OBJPAGOS = New ClsPagos
        OBJPTOVTA = New ClsPtoVta
        OBJART = New ClsArticulo

        'ClsCustomAnchor.LoadAnchor(Me)
        'Me.Scale(New System.Drawing.SizeF(2, 2))
        ObtenerConfiguracionTicket(1)
        If CargarVariablesPtovta() = 1 Then Me.Close() : Exit Sub

        ''If GEditprecio = True Then Me.TXT_PU.Enabled = True Else Me.TXT_PU.Enabled = False

        Me.DT_PROC.Value = GFechaProceso


        Me.TXT_OPERADOR.Text = GUSERDS
        Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_PROC.Value, "V")
        Me.DT_DOC.Value = Date.Now


        Me.TXT_TURNO.Text = TURNO


        Button_CANCELAR_Click(Button_CANCELAR, EventArgs.Empty)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub COMBO_DOC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Combo_DOC.KeyDown

    End Sub

    Private Sub COMBO_DOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_DOC.SelectedIndexChanged
        Me.TXT_NRODOC.Text = FormatoTicket(OBJVENTAS.BUSCAR_CORR(Me.Combo_DOC.SelectedValue))
        If Microsoft.VisualBasic.Left(Me.Combo_DOC.Text, 1) = "B" Then
            Me.TXT_IGV.Visible = False
            Me.TXT_SUBTOTAL.Visible = False
            Me.LBL_SUBTOTAL.Visible = False
            Me.LBL_IGV.Visible = False
        Else
            Me.TXT_IGV.Visible = True
            Me.TXT_SUBTOTAL.Visible = True
            Me.LBL_IGV.Visible = True
            Me.LBL_SUBTOTAL.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Lineas que llaman al Formulario de Búsqueda
        Try
            Dim arraybusqueda(4, 3) As Object
            arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
            arraybusqueda(1, 2) = "Codigo"
            arraybusqueda(1, 3) = 1500
            arraybusqueda(2, 1) = "Desc_ART"
            arraybusqueda(2, 2) = "Descripcion "
            arraybusqueda(2, 3) = 4000
            arraybusqueda(3, 1) = "Stock_ART"
            arraybusqueda(3, 2) = "Stock "
            arraybusqueda(3, 3) = 800
            arraybusqueda(4, 1) = "PREBASE"
            arraybusqueda(4, 2) = "PU "
            arraybusqueda(4, 3) = 800


            ''
            With BusquedaMaestra
                .ACT = "Ventas"
                .STATINI = 0
                .CARGAR_COMBO(arraybusqueda, 4, 2)
                .TIPO = 0
                '.TxtDatoBuscado.Text = Me.TXT_PROV.Tag


                .ShowDialog()

                ''
                If .GrecibeColumnaID <> "" Then
                    AGREGAR(.GrecibeColumnaID, 1, "M")
                End If
                .Close()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub ASIGNAR_DATOS()
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJCLIE.LISTAR_CLIE(Me.TXT_COD_CLIENTE.Text, "COD_CLIENTE")
        While RS.Read
            If Strings.Left(Me.Combo_DOC.Text, 1) = "F" Then
                Me.TXT_RUC_CLIENTE.Text = NULO(RS("RUC"), "S")
            Else
                If NULO(RS("DNI_CLIENTE"), "S") = "" Then
                    Me.TXT_RUC_CLIENTE.Text = NULO(RS("RUC"), "S")
                Else
                    Me.TXT_RUC_CLIENTE.Text = NULO(RS("DNI_CLIENTE"), "S")
                End If
            End If
            Me.TXT_DIRECCION.Text = NULO(RS("DIR_CLIENTE"), "S")
            Me.TXT_CLIENTE.Text = NULO(RS("DESCRIPCION"), "S")

            'Me.TXT_FONO1.Text = NULO(RS.Fields("TELF_CLIENTE").Value, "S")
            'Me.TXT_FPAGO.Text = NULO(RS.Fields("DESC_FP").Value, "S")
            'Me.TXT_FPAGO.Tag = RS.Fields("COD_FP").Value
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            With Listar_Doc_Emitidos
                .FECHA_PROCESO = Format(DT_PROC.Value, "dd/MM/yyyy") ''Format(DT_PROC.Value, "yyyyMMdd")
                .TURNO = TXT_TURNO.Text
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub Button_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CANCELAR.Click
        OBJVENTAS.CARGAR_DETALLE(0, Me.C1_DETALLE)
        LISTAR_TIPO_DOC(Me.Combo_DOC, "V")
        Me.Combo_DOC.SelectedIndex = 1
        CORR = OBJUSU.ObtenerCorrelativo(GUSERID)
        Me.TXT_SUBTOTAL.Text = ""
        Me.TXT_IGV.Text = ""
        Me.TXT_TOTAL.Text = ""
        Me.TXT_COD_CLIENTE.Text = ""
        Me.TXT_RUC_CLIENTE.Text = ""
        Me.TXT_CLIENTE.Text = ""
        Me.TXT_DIRECCION.Text = ""
        Me.Button_EFECTIVO.Enabled = True
        Me.Button_TARJETA.Enabled = True
        Me.Button_CREDITO.Enabled = True
        Me.Button_CAJA.Enabled = True
        Me.CHK_GRATUITA.Checked = False
        Me.LBL_GRATUITO.Text = "0"
        REIMPRIME = 0
        CARGAR_CONFIG()
    End Sub

    Sub TOTAL()
        Dim F As Integer
        Dim TOT As Double = 0
        Dim CANT As Double = 0
        Dim DSCTO As Double = 0
        For F = 1 To Me.C1_DETALLE.Rows.Count - 1
            TOT = TOT + Me.C1_DETALLE.Item(F, COL_TOTAL_FIN)
            CANT = CANT + Me.C1_DETALLE.Item(F, COL_CANT)
            DSCTO = DSCTO + Me.C1_DETALLE.Item(F, COL_DSCTO_M)
        Next
        Me.TXT_CANT_TOTAL.Text = CANT
        If Me.CHK_GRATUITA.Checked = True Then
            Me.TXT_DSCTO.Text = Format(0, "###,###,###.00")
            Me.TXT_TOTAL.Text = Format(0, "###,###,###.00")
            Me.TXT_SUBTOTAL.Text = Format(0, "###,###,###.00")
            Me.TXT_IGV.Text = Format(0, "###,###,###.00")
            Me.LBL_GRATUITO.Text = Format(TOT, "###,###,###.00")
        Else
            Me.TXT_DSCTO.Text = Format(DSCTO, "###,###,###.00")
            Me.TXT_TOTAL.Text = Format(TOT, "###,###,###.00")
            Me.TXT_SUBTOTAL.Text = Format(TOT / (1 + (IGV / 100)), "###,###,###.00")
            Me.TXT_IGV.Text = Format(TOT - Val(Me.TXT_SUBTOTAL.Text), "###,###,###.00")
            Me.LBL_GRATUITO.Text = Format(0, "###,###,###.00")
        End If
    End Sub

    Private Sub TXT_CANT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_CANT_TOTAL.LostFocus
        Me.TXT_CANT_TOTAL.Text = Math.Round(Val(Me.TXT_CANT_TOTAL.Text), 0)
    End Sub


    Private Sub TXT_CODART_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODART.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim RS As SqlDataReader
            e.Handled = True
            RS = OBJART.BUSCAR_ARTICULOS_BARRAS(Me.TXT_CODART.Text.Trim)
            While RS.Read
                'Me.TXT_DESCART.Text = NULO(RS("DESC_ART"), "S")
                'Me.TXT_CANT_TOTAL.Text = 1
                'Me.TXT_PU.Text = NULO(RS("PREBASE"), "N")
                Me.TXT_CODART.Tag = RS("COD_ART")
                AGREGAR(Me.TXT_CODART.Tag, 1, "M")
            End While
            RS.Close()
            CN_NET.Close()
            ''If Val(Me.GroupBox5.Tag) = 0 Then
            ''    AGREGAR(Me.TXT_CODART.Tag)
            ''Else
            ''    If Me.TXT_CODART.Text = Me.TXT_CODART.Tag Then
            ''        MODIFICAR(Me.TXT_CODART.Text)
            ''    Else
            ''        AGREGAR(Me.TXT_CODART.Text)
            ''    End If
            ''End If
        End If
    End Sub
    Function VERIFICAR_STOCK(ByVal COD_ART As String, CANT As Integer) As Integer
        Try
            Dim STOCK As Double
            STOCK = OBJART.BUSCAR_STOCK(COD_ART, CANT)

            If STOCK = -9999 Then
                VERIFICAR_STOCK = 1
                Exit Function
            End If

            If Val(Me.TXT_CANT_TOTAL.Text) > STOCK Then
                VERIFICAR_STOCK = 1
            Else
                VERIFICAR_STOCK = 0
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Sub AGREGAR(ByVal COD_ART As String, CANT As Double, TIPO As String)
        'If Me.TXT_CODART.Text = "" Then MsgBox("Seleccione Articulo", MsgBoxStyle.Information) : Exit Sub
        'If Val(Me.TXT_CANT.Text) = 0 Then MsgBox("Ingrese Cantidad", MsgBoxStyle.Information) : Exit Sub
        'If Val(Me.TXT_PU.Text) = 0 Then MsgBox("Ingrese Precio", MsgBoxStyle.Information) : Exit Sub

        ''verificamos stock
        '' If VERIFICAR_STOCK(COD_ART) = 1 Then MsgBox("No tiene Stock", MsgBoxStyle.Information) : Exit Sub
        ''
        Dim SW As Integer
        SW = OBJVENTAS.AGREGAR_DETALLE(COD_ART, CANT, CORR, TIPO)
        If SW = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
        If SW = 2 Then MsgBox("No tiene suficiente Stock", MsgBoxStyle.Critical) : Exit Sub
        If SW = 3 Then MsgBox("El articulo no tiene precio", MsgBoxStyle.Critical) : Exit Sub
        CARGAR_DETALLE()

    End Sub
    Public Sub CARGAR_DETALLE()
        OBJVENTAS.CARGAR_DETALLE(CORR, Me.C1_DETALLE)
        C1_DETALLE.Cols(COL_PU).Format = "###,###,###.000"
        C1_DETALLE.Cols(COL_TOTAL).Format = "###,###,###.000"
        C1_DETALLE.Cols(COL_DSCTO_M).Format = "###,###,###.000"
        C1_DETALLE.Cols(COL_DSCTO_P).Format = "###,###,###.000"
        C1_DETALLE.Cols(COL_TOTAL_FIN).Format = "###,###,###.000"
        C1_DETALLE.AutoSizeCols()
        C1_DETALLE.Cols(COL_COD_ART).Visible = False
        C1_DETALLE.Cols(COL_ID).Visible = False
        Me.TXT_CODART.Text = ""
        Me.TXT_CODART.Tag = ""
        Me.TXT_CODART.Focus()
        TOTAL()
    End Sub
    ''Sub MODIFICAR(ByVal COD_ART As String)
    ''    If Me.TXT_CODART.Text = "" Then MsgBox("Seleccione Articulo", MsgBoxStyle.Information) : Exit Sub
    ''    If Val(Me.TXT_CANT_TOTAL.Text) = 0 Then MsgBox("Ingrese Cantidad", MsgBoxStyle.Information) : Exit Sub
    ''    If Val(Me.TXT_PU.Text) = 0 Then MsgBox("Ingrese Precio", MsgBoxStyle.Information) : Exit Sub

    ''    ''verificamos stock
    ''    If VERIFICAR_STOCK(COD_ART) = 1 Then MsgBox("No tiene Stock", MsgBoxStyle.Information) : Exit Sub
    ''    ''
    ''    If OBJVENTAS.MODIFICAR_DETALLE(COD_ART, Me.TXT_CANT_TOTAL.Text, Me.TXT_PU.Text, Me.Button2.Tag) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
    ''    OBJVENTAS.CARGAR_DETALLE(CORR, Me.DBLISTAR)
    ''    Me.TXT_CODART.Text = ""
    ''    Me.TXT_CODART.Tag = ""
    ''    Me.TXT_DESCART.Text = ""
    ''    Me.TXT_CANT_TOTAL.Text = ""
    ''    Me.TXT_PU.Text = ""
    ''    Me.TXT_CODART.Focus()
    ''    TOTAL()
    ''    Me.GroupBox5.Tag = ""
    ''End Sub
    Private Sub TXT_CODART_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODART.TextChanged

    End Sub

    Private Function ValidarDatos() As Boolean
        ValidarDatos = False

        If GVDATO(Strings.Left(Me.Combo_DOC.Text, 1)) = "F" Then
            If Me.TXT_RUC_CLIENTE.Text = "" Then
                Call MsgBox("Nro de RUC, no puede estar en blanco", MsgBoxStyle.Exclamation)
                TXT_RUC_CLIENTE.Focus()
                Exit Function
            End If
            If Not GValidaRUC(TXT_RUC_CLIENTE.Text) Then
                Call MsgBox("Nro de RUC, no es válido", MsgBoxStyle.Exclamation)
                TXT_RUC_CLIENTE.Focus()
                Exit Function
            End If

        End If

        If Val(TXT_TC.Text) = 0 Then
            Call MsgBox("Tipo de Cambio no ingresado?", MsgBoxStyle.Exclamation)
            Exit Function
        End If

        If C1_DETALLE.Rows.Count <= 1 Then
            Call MsgBox("Ingrese el Detalle del Documento ", MsgBoxStyle.Exclamation)
            Exit Function
        End If

        If String.IsNullOrEmpty(GVDATO(Me.TXT_TOTAL.Text)) Then
            Call MsgBox("Documento no puede ser Cero. Corregir", MsgBoxStyle.Exclamation)
            Exit Function
        End If

        ValidarDatos = True
    End Function


    Private Sub Button_EFECTIVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_EFECTIVO.Click
        If ValidarDatos() Then
            Dim TOT_S As Double = 0
            Dim TOT_D As Double = 0
            If CFG_MONVENTA = "S" Then TOT_S = Val(Me.TXT_TOTAL.Text)
            If CFG_MONVENTA = "D" Then TOT_D = Val(Me.TXT_TOTAL.Text)
            If GRABAR_EFECTIVO(TOT_S, TOT_D, 0, 0, "E") = 0 Then
                MsgBox("Grabado Correctamente")
                ORIG = "P"
                'IMPRIMIR(Me.Combo_DOC.SelectedValue, 0, "", ArmaNumero(Me.TXT_NRODOC.Text), Me.TXT_CLIENTE.Text, Me.TXT_RUC_CLIENTE.Text, Me.TXT_DIRECCION.Text, Me.TXT_DSCTO.Text, Me.TXT_SUBTOTAL.Text, Me.TXT_IGV.Text, Me.TXT_TOTAL.Text)
                MANDAR_IMPRESION()
                Button_CANCELAR_Click(Button_CANCELAR, Nothing)
            End If
        End If
    End Sub




    Private Sub Button_TARJETA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TARJETA.Click
        If Me.CHK_GRATUITA.Checked = True Then MsgBox("No puede pagar una Venta Gratuita", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_TOTAL.Text) = 0 Then MsgBox("Ingrese Articulos", MsgBoxStyle.Information) : Exit Sub
        If Microsoft.VisualBasic.Left(Me.Combo_DOC.Text, 1) = "F" And Me.TXT_RUC_CLIENTE.Text = "" Then MsgBox("Ingresar Ruc para poder Facturar", MsgBoxStyle.Information) : Exit Sub
        With Pago_Tarjeta
            .TXT_TC.Text = Me.TXT_TC.Text
            .LBL_MONTO.Text = Me.TXT_TOTAL.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub Button_CREDITO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CREDITO.Click
        Try
            Dim C As Integer
            Dim TOT_S As Double
            If Me.CHK_GRATUITA.Checked = True Then MsgBox("No puede dar Credito de una Venta Gratuita", MsgBoxStyle.Information) : Exit Sub
            If Microsoft.VisualBasic.Left(Me.Combo_DOC.Text, 1) = "F" And Me.TXT_RUC_CLIENTE.Text = "" Then MsgBox("Debe ingresar el numero de Ruc", MsgBoxStyle.Information) : Exit Sub

            If Val(Me.TXT_TOTAL.Text) = 0 Then MsgBox("Ingrese Articulos", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_COD_CLIENTE.Text = "" Then MsgBox("Seleccione al Cliente", MsgBoxStyle.Information) : Exit Sub
            If MsgBox("Seguro que es una venta al Credito??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            ''VERIFICAMOS LIMITE DE CREDITO
            If OBJVENTAS.BUSCAR_LIMITE_CREDITO(NULO(Me.TXT_COD_CLIENTE.Text, "S"), Me.TXT_TOTAL.Text) = False Then
                MsgBox("Este Cliente ya paso su limite de Credito", MsgBoxStyle.Critical)
                Exit Sub
            End If
            ''
            C = OBJVENTAS.GRABAR_VENTA(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), "S", Me.TXT_TC.Text, "C", Me.DT_DOC.Value,
                 Me.DT_PROC.Value, Me.TXT_TOTAL.Text, Me.TXT_SUBTOTAL.Text, Me.TXT_IGV.Text, 0, 0, 0, NULO(Me.TXT_COD_CLIENTE.Text, "S"),
                  0, 0, GUSERID, SystemInformation.ComputerName, Me.TXT_TURNO.Text, CORR, "", "", "", 0, Me.TXT_DSCTO.Text, 0, 0)

            If C = 2 Then MsgBox("Esta fecha de proceso ya fue Cerrrada", MsgBoxStyle.Information) : Exit Sub
            If C = 3 Then MsgBox("Este documento ya existe", MsgBoxStyle.Information) : Exit Sub
            If C = 4 Then MsgBox("Si es Factura debe registrar el Ruc pro Mantenimiento de Clientes", MsgBoxStyle.Information) : Exit Sub
            If C = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
            If C = 0 Then
                MsgBox("Grabado Correctamente")
                MANDAR_IMPRESION()
                Button_CANCELAR_Click(Button_CANCELAR, EventArgs.Empty)
            End If


        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Sub MANDAR_IMPRESION()
        Dim DNI As String = ""
        Dim TIPO_CLIENTE As String = ""
        Dim TTDOC As String = ""
        Dim HASH As String

        Dim OBJCONFIG As New ClsConfig

        OBJCONFIG.LISTAR_CONFIG_V2()
        PObtener_FechaServidor()

        Select Case GVDATO(Me.Combo_DOC.SelectedValue)
            Case OBJCONFIG.Config_Boleta
                DOCU = " BOL. "
                TTDOC = "B"
            Case OBJCONFIG.Config_Factura
                DOCU = " FACT."
                TTDOC = "F"
                ''Case OBJCONFIG.ConfigOtro
                ''    DOCU = "OTRO. "
                ''    TTDOC = "R"
        End Select



        If SISTEMA_FELECTRONICA = "N" And SISTEMA_ASPNET = "N" And SISTEMA_ITALO = "N" Then
            IMPRIMIR(Me.Combo_DOC.SelectedValue, 0, "", ArmaNumero(Me.TXT_NRODOC.Text), Me.TXT_CLIENTE.Text, Me.TXT_RUC_CLIENTE.Text, Me.TXT_DIRECCION.Text, Me.TXT_DSCTO.Text, Me.TXT_SUBTOTAL.Text, Me.TXT_IGV.Text, Me.TXT_TOTAL.Text, GDatFechaActual, Date.Now, "")
        End If

        If SISTEMA_ASPNET = "S" Then
            If OBJCONFIG.Config_Boleta = Combo_DOC.SelectedValue Or OBJCONFIG.Config_Factura = Combo_DOC.SelectedValue Then
                If Me.TXT_CLIENTE.Text.Trim <> "" Then
                    With OBJCLIE

                        Dim RUC As String = NULO(BUSCAR_CAMPO("CLIENTES", "COD_CLIENTE", "RUC_CLIENTE", Me.TXT_COD_CLIENTE.Text.Trim, CN_NET), "S")

                        '.BUSCAR_CLIE(TXT_CLIENTE.Text.Trim, "COD_CLIENTE")
                        If RUC = "" Then TIPO_CLIENTE = "D" Else TIPO_CLIENTE = "R"
                        DNI = BUSCAR_CAMPO_NO_ANULADO("CLIENTES", "COD_CLIENTE", "DNI_CLIENTE", Me.TXT_RUC_CLIENTE.Text.Trim, "STAT_CLIENTE")
                    End With

                End If
            End If

            Dim MAIL As String = BUSCAR_CAMPO("CLIENTES", "MAIL_CLIENTE", "COD_CLIENTE", Me.TXT_COD_CLIENTE.Text, CN_NET)
            Call FactImprimir_ASPNET(OBJCONFIG.RucConfig, OBJCONFIG.DescConfig, OBJCONFIG.Config_Ubigeo, OBJCONFIG.DirConfig, MAIL, "",
                                             "Ticket No" & DOCU, Me.TXT_NRODOC.Text,
                           TXT_CLIENTE.Text, TXT_RUC_CLIENTE.Text, TXT_DIRECCION.Text,
                            TXT_SUBTOTAL.Text, 0, TXT_IGV.Text, 0, CDbl(TXT_TOTAL.Text), 0,
                            0, 0, LLENAR_DATA_TABLE("EXEC VENTA_MOSTRAR_DETALLE '" & Combo_DOC.SelectedValue & "'," & ArmaNumero(TXT_NRODOC.Text) & "", CN_NET), "01", GUSERID,
                           0, "", LLENAR_DATA_TABLE("EXEC TARJETA_MOSTRAR_DETALLE '" & Combo_DOC.SelectedValue & "'," & ArmaNumero(TXT_NRODOC.Text) & "", CN_NET), 0,
                           DT_PROC.Value, DNI, TIPO_CLIENTE, Date.Now)

            BUSCAR_HASH(ArmaNumero(TXT_NRODOC.Text), Me.Combo_DOC.SelectedValue, OBJCONFIG, 0)
        End If

        If SISTEMA_ITALO = "S" Then
            ''
            'If Tdoc <> OBJCONFIG.ConfigOtro Then
            HASH = FIRMAR(Combo_DOC.SelectedValue, ArmaNumero(TXT_NRODOC.Text), TTDOC)
            'End If
            ''
            ''ELIMINAMOS
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "JPG")
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "XML")
            ''
            ''
            IMP_ASP_NET(ArmaNumero(TXT_NRODOC.Text), Combo_DOC.SelectedValue, HASH, OBJCONFIG, 0)
        End If

        If SISTEMA_FELECTRONICA = "S" Then
            ''
            PrintDocument_FACT_BOL.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP(Me.Combo_DOC.SelectedValue)
            Dim ps As PaperSize
            Try
                ps = PrintDocument_FACT_BOL.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP(Me.Combo_DOC.SelectedValue))
                PrintDocument_FACT_BOL.DefaultPageSettings.PaperSize = ps
            Catch ex As Exception

            End Try
            ''
            Try
                PrintDocument_FACT_BOL.Print()
            Catch ex As Exception

            End Try

        End If
    End Sub
    Function GRABAR_EFECTIVO(ByVal SOLES As Double, ByVal DOLARES As Double, ByVal TOTAL_TARJETA As Double, ByVal VUELTO As Double, ByVal TIPO_PAGO As String) As Integer
        Try
            Dim C As Integer

            C = OBJVENTAS.GRABAR_VENTA(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), CFG_MONVENTA, Me.TXT_TC.Text, TIPO_PAGO, Me.DT_DOC.Value,
                 Me.DT_PROC.Value, Me.TXT_TOTAL.Text, Me.TXT_SUBTOTAL.Text, Me.TXT_IGV.Text, VUELTO, SOLES, DOLARES, NULO(Me.TXT_COD_CLIENTE.Text, "S"),
                  0, 0, GUSERID, SystemInformation.ComputerName, Me.TXT_TURNO.Text, CORR, "", "", "", 0, Me.TXT_DSCTO.Text, Me.CHK_GRATUITA.Checked, Me.LBL_GRATUITO.Text)
            GRABAR_EFECTIVO = C
            If C = 4 Then MsgBox("Si es Factura debe registrar el Ruc pro Mantenimiento de Clientes", MsgBoxStyle.Information) : Exit Function
            If C = 2 Then MsgBox("Esta fecha de proceso ya fue Cerrrada", MsgBoxStyle.Information) : Exit Function
            If C = 3 Then MsgBox("Este documento ya existe", MsgBoxStyle.Information) : Exit Function
            If C = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Function

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Function GRABAR_TARJETA(ByVal COD_TARJETA As String, ByVal MONEDA As String, ByVal NUM_TARJETA As String) As Integer
        Try

            Dim C As Integer
            Dim MONTO_TARJETA As Double = 0
            If CFG_MONVENTA = MONEDA Then
                MONTO_TARJETA = Me.TXT_TOTAL.Text
            Else
                If MONEDA = "S" Then
                    MONTO_TARJETA = TXT_TOTAL.Text * NUMERICO(TXT_TC.Text)
                Else
                    MONTO_TARJETA = TXT_TOTAL.Text / NUMERICO(TXT_TC.Text)
                End If
            End If

            C = OBJVENTAS.GRABAR_VENTA(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), "S", Me.TXT_TC.Text, "T", Me.DT_DOC.Value,
                 Me.DT_PROC.Value, Me.TXT_TOTAL.Text, Me.TXT_SUBTOTAL.Text, Me.TXT_IGV.Text, 0, 0, 0, NULO(Me.TXT_COD_CLIENTE.Text, "S"),
                  0, 0, GUSERID, SystemInformation.ComputerName, Me.TXT_TURNO.Text, CORR, COD_TARJETA, MONEDA, NUM_TARJETA, MONTO_TARJETA, Me.TXT_DSCTO.Text, 0, 0)
            GRABAR_TARJETA = C
            If C = 4 Then MsgBox("Si es Factura debe registrar el Ruc pro Mantenimiento de Clientes", MsgBoxStyle.Information) : Exit Function
            If C = 2 Then MsgBox("Esta fecha de proceso ya fue Cerrrada", MsgBoxStyle.Information) : Exit Function
            If C = 3 Then MsgBox("Este documento ya existe", MsgBoxStyle.Information) : Exit Function
            If C = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Function

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub


    Sub abrir_gaveta()
        'Dim p As System.IO.StreamWriter = GetStreamWriter("LPT1")
        Dim file1 As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")


        'Open GstrRUTAPRN For Output As #1
        'file1.WriteLine(Chr(27) + "p" + Chr(0) + Chr(25) + Chr(250))
        file1.WriteLine(Chr(27) + Chr(112) + Chr(0) + Chr(27) + Chr(112) + Chr(0))
        'Print #1, CHR(27)&CHR(112)& CHR(0)& CHR(27)& CHR(112)&CHR(0); 
        'Print #1, Chr(27) + "p" + Chr(0) + Chr(25) + Chr(250)
        'Close #1
        file1.Close()

    End Sub
    'Sub IMP()

    '    Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")

    '    file.WriteLine("NUMERO DE RECETA:     " + txt1.Text)
    '    file.WriteLine(Chr(13))
    '    file.WriteLine(txt2.Text + "   " + Mid(txt3.Text, 1, 40))
    '    file.WriteLine(Chr(13))
    '    file.WriteLine("No. DE AFILIACION:" + "  " + txt4.Text)
    '    file.WriteLine(Chr(13))
    '    file.WriteLine("NOMBRE:   " + txt5.Text)
    '    'file.WriteLine(Chr(13))

    '    file.WriteLine("POSOLOGIA:______________________________")
    '    file.WriteLine(Chr(13))

    '    file.WriteLine("----------------------------------------")

    '    file.WriteLine(txt1.Text + " " + "  " + Now)
    '    file.WriteLine("*** GRACIAS, ES UN PLACER ATENDERLE ***")


    '    file.WriteLine("       &n bsp; " + "DISPENSARIO")
    '    file.WriteLine("    TELEFONO:24676")
    '    file.WriteLine("----------------------------")
    '    'file.WriteLine(ticket)
    '    'file.Write(corte)
    '    file.Close()
    '    Try
    '        Shell("print /d:lpt1 C:\TEMP\temp.txt", AppWinStyle.Hide)
    '    Catch ax As System.IO.FileNotFoundException
    '        MsgBox(ax.Message)
    '    End Try
    'End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub CambioDeTurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeTurnoToolStripMenuItem.Click
        Cambio_Turno.Tag = "V"
        Cambio_Turno.ShowDialog()
    End Sub

    Private Sub AbrirGavetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirGavetaToolStripMenuItem.Click
        abrir_gaveta()
    End Sub

    Private Sub CierreXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreXToolStripMenuItem.Click
        Cierre_X.Tag = "X"
        Cierre_X.picturebox1.Visible = False
        Cierre_X.ShowDialog()
    End Sub

    Private Sub CierreZToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreZToolStripMenuItem.Click
        Cierre_X.Tag = "Z"
        Cierre_X.picturebox1.Visible = False
        ''Cierre_X.OPT_IMPRESORA.Checked = True
        ''Cierre_X.GroupBox1.Visible = False
        Cierre_X.ShowDialog()
    End Sub

    Private Sub FinDeDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinDeDiaToolStripMenuItem.Click
        Fin_Dia.ShowDialog()
    End Sub


    Private Sub Button_CAJA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CAJA.Click
        Movi_Caja.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "COD_CLIENTE"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_CLIENTE"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "RUC_CLIENTE"
        arraybusqueda(3, 2) = "Ruc "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "STAT_CLIENTE"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Clientes"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then

                Me.TXT_COD_CLIENTE.Text = .GrecibeColumnaID
                Me.TXT_CLIENTE.Text = .GrecibeColumnaOpcional
                'Me.TXT_RUC.Text = .GrecibeColumnaOpcional2
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional3
                ASIGNAR_DATOS()
            End If
            .Close()
        End With

    End Sub

    Private Sub Button_mULTIPAGO_Click(sender As Object, e As EventArgs) Handles Button_mULTIPAGO.Click
        If ValidarDatos() Then
            If Me.CHK_GRATUITA.Checked = True Then MsgBox("No puede pagar una Venta Gratuita", MsgBoxStyle.Information) : Exit Sub
            With Pago_Efectivo
                .TXT_TC.Text = Me.TXT_TC.Text
                .LBL_MONTO.Text = Me.TXT_TOTAL.Text
                .CORR = CORR
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Sub AGREGAR_DNI()
        With Mant_Cliente_Dni_Venta
            .TORIG = "S"
            .TXT_DNI.Text = Me.TXT_RUC_CLIENTE.Text
            .TXT_DESCRIPCION.Clear()
            .TXT_DIRECCION.Clear()
            .TXT_MAIL.Clear()
            Dim r As Rectangle = My.Computer.Screen.WorkingArea
            .Location = New Point(r.Width - Width, r.Height - (Height - Height / 2))
            .ShowDialog()

            Me.TXT_COD_CLIENTE.Text = BUSCAR_CAMPO_NO_ANULADO("CLIENTES", "COD_CLIENTE", "DNI_CLIENTE", Me.TXT_RUC_CLIENTE.Text.Trim, "STAT_CLIENTE")
            ASIGNAR_DATOS()
        End With
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try

            If Strings.Left(Me.Combo_DOC.Text, 1) = "F" Then
                AGREGAR_RUC()
            Else
                If MsgBox("Desea Agregar Ruc o Dni ??, Si-Ruc  No-Dni", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    AGREGAR_RUC()
                Else
                    AGREGAR_DNI()
                End If
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub AGREGAR_RUC()
        With Mant_Cliente_Venta
            .TORIG = "S"
            .TXT_RUC.Text = Me.TXT_RUC_CLIENTE.Text
            .TXT_DESCRIPCION.Clear()
            .TXT_DIRECCION.Clear()
            .TXT_ESTADO.Clear()
            .TXT_CONDICION.Clear()
            Dim r As Rectangle = My.Computer.Screen.WorkingArea
            .Location = New Point(r.Width - Width, r.Height - (Height - Height / 2))
            .ShowDialog()

            Me.TXT_COD_CLIENTE.Text = BUSCAR_CAMPO_NO_ANULADO("CLIENTES", "COD_CLIENTE", "RUC_CLIENTE", Me.TXT_RUC_CLIENTE.Text.Trim, "STAT_CLIENTE")
            ASIGNAR_DATOS()
        End With
    End Sub

    Private Sub TXT_COD_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_COD_CLIENTE.TextChanged

    End Sub

    Private Sub TXT_COD_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_COD_CLIENTE.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                BUSCAR_COD_CLIENTE()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub BUSCAR_COD_CLIENTE()
        If String.IsNullOrEmpty(Me.TXT_COD_CLIENTE.Text) Then Exit Sub
        ' OBJCLIENTE.BUSCAR_CLIENTE(OBJCONN.Conexion(CAD_CON))
        ASIGNAR_DATOS()

    End Sub

    Private Sub TXT_RUC_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_RUC_CLIENTE.TextChanged

    End Sub

    Private Sub TXT_RUC_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RUC_CLIENTE.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            BUSCAR_DATOS_CLIENTE()
        End If
    End Sub
    Public Sub BUSCAR_DATOS_CLIENTE()
        If Strings.Left(Me.Combo_DOC.Text, 1) <> "F" Then
            If Me.TXT_RUC_CLIENTE.Text.Trim.Length = 8 Then
                BUSCAR_DNI_CLIENTE()
            Else
                BUSCAR_RUC_CLIENTE()
            End If
        Else
            BUSCAR_RUC_CLIENTE()
        End If

    End Sub
    Sub BUSCAR_DNI_CLIENTE()
        If String.IsNullOrEmpty(Me.TXT_RUC_CLIENTE.Text) Then Exit Sub
        Me.TXT_COD_CLIENTE.Text = BUSCAR_CAMPO_NO_ANULADO("CLIENTES", "COD_CLIENTE", "DNI_CLIENTE", Me.TXT_RUC_CLIENTE.Text.Trim, "STAT_CLIENTE")
        If Me.TXT_COD_CLIENTE.Text = "" Then MsgBox("Dni no esta Registrado", MsgBoxStyle.Critical) : Exit Sub
        ASIGNAR_DATOS()
    End Sub

    Private Sub C1_QUITAR_Click(sender As Object, e As EventArgs) Handles C1_QUITAR.Click
        Try
            OBJVENTAS.ELIMINAR_DETALLE(Me.C1_DETALLE.Item(Me.C1_DETALLE.Row, COL_ID))
            CARGAR_DETALLE()
            ''OBJVENTAS.CARGAR_DETALLE(CORR, Me.C1_DETALLE)
            ''TOTAL()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_AGREGAR_Click(sender As Object, e As EventArgs) Handles C1_AGREGAR.Click
        Try
            Dim FIL As Double
            FIL = C1_DETALLE.Row
            AGREGAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_ART), 1, "M")
            C1_DETALLE.Row = FIL
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_RESTAR_Click(sender As Object, e As EventArgs) Handles C1_RESTAR.Click
        Try
            Dim FIL As Double
            FIL = C1_DETALLE.Row
            AGREGAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_ART), -1, "M")
            C1_DETALLE.Row = FIL
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles C1Button1.Click
        Try
            Dim F As Integer
            Dim TOT As Double = 0
            If Val(Me.TXT_TOTAL.Text) = 0 Then Exit Sub
            If C1_DETALLE.Row < 1 Then Exit Sub
            With Ventas_Dscto_V2
                .Tag = Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_ID)
                .TXT_CANTIDAD.Text = "0"
                .TXT_PORCENTAJE.Text = NULO(C1_DETALLE.Item(C1_DETALLE.Row, COL_DSCTO_P), "N")

                .TXT_CANT.Text = C1_DETALLE.Item(C1_DETALLE.Row, COL_PU) * C1_DETALLE.Item(C1_DETALLE.Row, COL_CANT)

                For F = 1 To C1_DETALLE.Rows.Count - 1
                    TOT = TOT + C1_DETALLE.Item(F, COL_PU) * C1_DETALLE.Item(F, COL_CANT)
                Next
                .TXT_CANT_TOTAL.Text = TOT


                .CORR = CORR
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub PrintDocument_FACT_BOL_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument_FACT_BOL.PrintPage
        Dim DNI As String
        Dim RUC As String
        Dim TIPO_CLIENTE As String = "R"


        FIRMAR(Me.Combo_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), Strings.Left(Combo_DOC.Text, 1))

        GRAFICO = e.Graphics
        If Me.Combo_DOC.SelectedValue = "002" Then
            If Me.TXT_CLIENTE.Text.Trim <> "" Then
                RUC = BUSCAR_CAMPO("CLIENTES", "RUC_CLIENTE", "COD_CLIENTE", Me.TXT_COD_CLIENTE.Text.Trim, CN_NET)
                If RUC.Trim = "" Then TIPO_CLIENTE = "D" Else TIPO_CLIENTE = "R"
                DNI = BUSCAR_CAMPO("CLIENTES", "DNI_CLIENTE", "COD_CLIENTE", Me.TXT_COD_CLIENTE.Text.Trim, CN_NET)
            End If
        End If
        PObtener_FechaServidor()
        IMPRIMIR_TERMICA(Me.Combo_DOC.SelectedValue, 0, "", ArmaNumero(Me.TXT_NRODOC.Text), Me.TXT_CLIENTE.Text.Trim, Me.TXT_RUC_CLIENTE.Text, Me.TXT_DIRECCION.Text.Trim,
                          Me.TXT_DSCTO.Text, Me.TXT_SUBTOTAL.Text, Me.TXT_IGV.Text, Me.TXT_TOTAL.Text, GDatFechaActual, Date.Now, DNI, TIPO_CLIENTE)


    End Sub

    Private Sub C1_DETALLE_Click(sender As Object, e As EventArgs) Handles C1_DETALLE.Click

    End Sub

    Private Sub C1_DETALLE_BeforeEdit(sender As Object, e As RowColEventArgs) Handles C1_DETALLE.BeforeEdit
        If e.Col <> COL_CANT Then e.Cancel = True
    End Sub

    Private Sub C1_DETALLE_AfterEdit(sender As Object, e As RowColEventArgs) Handles C1_DETALLE.AfterEdit
        Dim SW = 0
        ''SW = OBJVENTAS.VENTA_ACTUALIZAR_DETALLE_CANT(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_ART), C1_DETALLE.Item(C1_DETALLE.Row, COL_CANT), CORR)
        AGREGAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_ART), C1_DETALLE.Item(C1_DETALLE.Row, COL_CANT), "N")
        If SW <> 0 Then
            MsgBox(Err.Description)
        Else
            CARGAR_DETALLE()
        End If
    End Sub

    Private Sub CHK_GRATUITA_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_GRATUITA.CheckedChanged
        TOTAL()
    End Sub
End Class