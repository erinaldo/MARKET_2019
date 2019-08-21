Public Class Ventas
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
    ''
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String
    Public GrecibeColumnaOpcional4 As String

   

   

    Private Sub Ventas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = (Keys.F2) Then
            Call Button2_Click(Button2, EventArgs.Empty)
        End If
        If e.KeyCode = (Keys.F6) Then
            Call Button_CAJA_Click(Button_CAJA, EventArgs.Empty)
        End If
        If e.KeyCode = (Keys.F7) Then
            Call Button_EFECTIVO_Click(Button_EFECTIVO, EventArgs.Empty)
        End If
        If e.KeyCode = (Keys.F8) Then
            Call Button_TARJETA_Click(Button_TARJETA, EventArgs.Empty)
        End If
        If e.KeyCode = (Keys.F9) Then
            Call Button_CREDITO_Click(Button_CREDITO, EventArgs.Empty)
        End If
        If e.KeyCode = (Keys.F12) Then
            Call Button_CANCELAR_Click(Button_CANCELAR, EventArgs.Empty)
        End If

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

        If GEditprecio = True Then Me.TXT_PU.Enabled = True Else Me.TXT_PU.Enabled = False

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

    Private Sub COMBO_DOC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COMBO_DOC.KeyDown
        
    End Sub

    Private Sub COMBO_DOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMBO_DOC.SelectedIndexChanged
        Me.TXT_NRODOC.Text = FormatoTicket(OBJVENTAS.BUSCAR_CORR(Me.COMBO_DOC.SelectedValue))
        If Microsoft.VisualBasic.Left(Me.COMBO_DOC.Text, 1) = "B" Then
            Me.TXT_IGV.Visible = False
            Me.TXT_VVENTA.Visible = False
            Me.Label15.Visible = False
            Me.Label16.Visible = False
        Else
            Me.TXT_IGV.Visible = True
            Me.TXT_VVENTA.Visible = True
            Me.Label15.Visible = True
            Me.Label16.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
                Me.TXT_CODCLIE.Text = .GrecibeColumnaID
                Me.TXT_RAZON.Text = .GrecibeColumnaOpcional
                'Me.TXT_RUC.Text = .GrecibeColumnaOpcional2
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional3
                ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
    Sub ASIGNAR_DATOS()
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJCLIE.LISTAR_CLIE(Me.TXT_CODCLIE.Text, "COD_CLIENTE")
        While RS.Read
            Me.TXT_RUC.Text = NULO(RS("RUC"), "S")
            Me.TXT_DIRECCION.Text = NULO(RS("DIR_CLIENTE"), "S")
            'Me.TXT_FONO1.Text = NULO(RS.Fields("TELF_CLIENTE").Value, "S")
            'Me.TXT_FPAGO.Text = NULO(RS.Fields("DESC_FP").Value, "S")
            'Me.TXT_FPAGO.Tag = RS.Fields("COD_FP").Value
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Lineas que llaman al Formulario de Búsqueda
        Try
            Dim arraybusqueda(4, 3) As Object
            arraybusqueda(1, 1) = "COD_ART"
            arraybusqueda(1, 2) = "Codigo"
            arraybusqueda(1, 3) = 1500
            arraybusqueda(2, 1) = "Desc_ART"
            arraybusqueda(2, 2) = "Descripcion "
            arraybusqueda(2, 3) = 3000
            arraybusqueda(3, 1) = "Stock_ART"
            arraybusqueda(3, 2) = "Stock "
            arraybusqueda(3, 3) = 1500
            arraybusqueda(4, 1) = "PREBASE"
            arraybusqueda(4, 2) = "PU "
            arraybusqueda(4, 3) = 1500


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
                    Me.TXT_CODART.Text = .GrecibeColumnaID
                    Me.TXT_DESCART.Text = .GrecibeColumnaOpcional
                    Me.TXT_PU.Text = .GrecibeColumnaOpcional3
                    Me.TXT_CANT.Focus()
                End If
                .Close()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub Button_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CANCELAR.Click
        OBJVENTAS.CARGAR_DETALLE(0, Me.DBLISTAR)
        LISTAR_TIPO_DOC(Me.COMBO_DOC, "V")
        Me.COMBO_DOC.SelectedIndex = 1
        CORR = OBJUSU.ObtenerCorrelativo(GUSERID)
        Me.TXT_VVENTA.Text = ""
        Me.TXT_IGV.Text = ""
        Me.TXT_TOTAL.Text = ""
        Me.TXT_CODCLIE.Text = ""
        Me.TXT_RUC.Text = ""
        Me.TXT_RAZON.Text = ""
        Me.TXT_DIRECCION.Text = ""
        Me.picturebox1.Enabled = False
        Me.Button_EFECTIVO.Enabled = True
        Me.Button_TARJETA.Enabled = True
        Me.Button_CREDITO.Enabled = True
        Me.Button_CAJA.Enabled = True
        REIMPRIME = 0
        CARGAR_CONFIG()
    End Sub

    Private Sub TXT_CANT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CANT.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Me.TXT_PU.Enabled = False Then
                e.Handled = True
                'If Me.TXT_CODART.Text = "" Then MsgBox("Seleccione Articulo", MsgBoxStyle.Information) : Exit Sub
                'If Val(Me.TXT_CANT.Text) = 0 Then MsgBox("Ingrese Cantidad", MsgBoxStyle.Information) : Exit Sub
                'If Val(Me.TXT_PU.Text) = 0 Then MsgBox("Ingrese Precio", MsgBoxStyle.Information) : Exit Sub
                'If OBJVENTAS.AGREGAR_DETALLE(Me.TXT_CODART.Text, Me.TXT_CANT.Text, Me.TXT_PU.Text, CORR) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
                'OBJVENTAS.CARGAR_DETALLE(CORR, Me.DBLISTAR)
                'Me.TXT_CODART.Text = ""
                'Me.TXT_DESCART.Text = ""
                'Me.TXT_CANT.Text = ""
                'Me.TXT_PU.Text = ""
                'Me.TXT_CODART.Focus()
                'TOTAL()
                If Val(Me.GroupBox5.Tag) = 0 Then
                    AGREGAR(Me.TXT_CODART.Text)
                Else
                    If Me.TXT_CODART.Text = Me.TXT_CODART.Tag Then
                        MODIFICAR(Me.TXT_CODART.Text)
                    Else
                        AGREGAR(Me.TXT_CODART.Text)
                    End If
                End If
            Else
                Me.TXT_PU.Focus()
            End If
        
        End If
    End Sub
    Sub TOTAL()
        Dim F As Integer
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOT = TOT + Me.DBLISTAR.Item(F, 6)
        Next
        Me.TXT_TOTAL.Text = Format(TOT, "###,###,###.00")
        Me.TXT_VVENTA.Text = Format(TOT / (1 + (IGV / 100)), "###,###,###.00")
        Me.TXT_IGV.Text = Format(TOT - Val(Me.TXT_VVENTA.Text), "###,###,###.00")
    End Sub

    Private Sub TXT_CANT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_CANT.LostFocus
        Me.TXT_CANT.Text = Math.Round(Val(Me.TXT_CANT.Text), 0)
    End Sub
    Private Sub TXT_CANT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CANT.TextChanged

    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
        Try
            Me.GroupBox5.Tag = Me.DBLISTAR.Row
            Me.Button2.Tag = Me.DBLISTAR.Item(DBLISTAR.Row, 0)
            Me.TXT_CODART.Text = Me.DBLISTAR.Item(DBLISTAR.Row, 1)
            Me.TXT_CODART.Tag = Me.DBLISTAR.Item(DBLISTAR.Row, 1)
            Me.TXT_DESCART.Text = Me.DBLISTAR.Item(DBLISTAR.Row, 2)
            Me.TXT_CANT.Text = Me.DBLISTAR.Item(DBLISTAR.Row, 4)
            Me.TXT_PU.Text = Me.DBLISTAR.Item(DBLISTAR.Row, 5)
            Me.TXT_CANT.Focus()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DBLISTAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DBLISTAR.KeyPress

    End Sub

    Private Sub DBLISTAR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBLISTAR.KeyUp
        If e.KeyCode = Keys.Delete Then
            OBJVENTAS.ELIMINAR_DETALLE(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0))
            OBJVENTAS.CARGAR_DETALLE(CORR, Me.DBLISTAR)
            TOTAL()
        End If
    End Sub

    Private Sub TXT_CODART_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODART.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim RS As SqlDataReader
            e.Handled = True
            RS = OBJART.BUSCAR_ARTICULOS_BARRAS(Me.TXT_CODART.Text.Trim)
            While RS.Read
                Me.TXT_DESCART.Text = NULO(RS("DESC_ART"), "S")
                Me.TXT_CANT.Text = 1
                Me.TXT_PU.Text = NULO(RS("PREBASE"), "N")
                Me.TXT_CODART.Tag = RS("COD_ART")
            End While
            RS.Close()
            CN_NET.Close()
            If Val(Me.GroupBox5.Tag) = 0 Then
                AGREGAR(Me.TXT_CODART.Tag)
            Else
                If Me.TXT_CODART.Text = Me.TXT_CODART.Tag Then
                    MODIFICAR(Me.TXT_CODART.Text)
                Else
                    AGREGAR(Me.TXT_CODART.Text)
                End If
            End If
        End If
    End Sub
    Function VERIFICAR_STOCK(ByVal COD_ART As String) As Integer
        Try
            Dim STOCK As Double
            STOCK = OBJART.BUSCAR_STOCK(COD_ART, Val(Me.TXT_CANT.Text))

            If STOCK = -9999 Then
                VERIFICAR_STOCK = 1
                Exit Function
            End If

            If Val(Me.TXT_CANT.Text) > STOCK Then
                VERIFICAR_STOCK = 1
            Else
                VERIFICAR_STOCK = 0
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Sub AGREGAR(ByVal COD_ART As String)
        If Me.TXT_CODART.Text = "" Then MsgBox("Seleccione Articulo", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_CANT.Text) = 0 Then MsgBox("Ingrese Cantidad", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_PU.Text) = 0 Then MsgBox("Ingrese Precio", MsgBoxStyle.Information) : Exit Sub

        ''verificamos stock
        If VERIFICAR_STOCK(COD_ART) = 1 Then MsgBox("No tiene Stock", MsgBoxStyle.Information) : Exit Sub
        ''

        ''If OBJVENTAS.AGREGAR_DETALLE(COD_ART, Me.TXT_CANT.Text, Me.TXT_PU.Text, CORR) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
        OBJVENTAS.CARGAR_DETALLE(CORR, Me.DBLISTAR)
        Me.TXT_CODART.Text = ""
        Me.TXT_CODART.Tag = ""
        Me.TXT_DESCART.Text = ""
        Me.TXT_CANT.Text = ""
        Me.TXT_PU.Text = ""
        Me.TXT_CODART.Focus()
        TOTAL()
        Me.GroupBox5.Tag = ""
    End Sub
    Sub MODIFICAR(ByVal COD_ART As String)
        If Me.TXT_CODART.Text = "" Then MsgBox("Seleccione Articulo", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_CANT.Text) = 0 Then MsgBox("Ingrese Cantidad", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_PU.Text) = 0 Then MsgBox("Ingrese Precio", MsgBoxStyle.Information) : Exit Sub

        ''verificamos stock
        If VERIFICAR_STOCK(COD_ART) = 1 Then MsgBox("No tiene Stock", MsgBoxStyle.Information) : Exit Sub
        ''
        If OBJVENTAS.MODIFICAR_DETALLE(COD_ART, Me.TXT_CANT.Text, Me.TXT_PU.Text, Me.Button2.Tag) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
        OBJVENTAS.CARGAR_DETALLE(CORR, Me.DBLISTAR)
        Me.TXT_CODART.Text = ""
        Me.TXT_CODART.Tag = ""
        Me.TXT_DESCART.Text = ""
        Me.TXT_CANT.Text = ""
        Me.TXT_PU.Text = ""
        Me.TXT_CODART.Focus()
        TOTAL()
        Me.GroupBox5.Tag = ""
    End Sub
    Private Sub TXT_CODART_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODART.TextChanged

    End Sub

    Private Sub TXT_PU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PU.KeyPress
        'e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    e.Handled = True
        '    If Me.TXT_CODART.Text = "" Then MsgBox("Seleccione Articulo", MsgBoxStyle.Information) : Exit Sub
        '    If Val(Me.TXT_CANT.Text) = 0 Then MsgBox("Ingrese Cantidad", MsgBoxStyle.Information) : Exit Sub
        '    If Val(Me.TXT_PU.Text) = 0 Then MsgBox("Ingrese Precio", MsgBoxStyle.Information) : Exit Sub
        '    If OBJVENTAS.AGREGAR_DETALLE(Me.TXT_CODART.Text, Me.TXT_CANT.Text, Me.TXT_PU.Text, CORR) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
        '    OBJVENTAS.CARGAR_DETALLE(CORR, Me.DBLISTAR)
        '    Me.TXT_CODART.Text = ""
        '    Me.TXT_DESCART.Text = ""
        '    Me.TXT_CANT.Text = ""
        '    Me.TXT_PU.Text = ""
        '    Me.TXT_CODART.Focus()
        '    TOTAL()
        'End If
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If Val(Me.GroupBox5.Tag) = 0 Then
                AGREGAR(Me.TXT_CODART.Text)
            Else
                If Me.TXT_CODART.Text = Me.TXT_CODART.Tag Then
                    MODIFICAR(Me.TXT_CODART.Text)
                Else
                    AGREGAR(Me.TXT_CODART.Text)
                End If
            End If
        End If
    End Sub

    Private Sub TXT_PU_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PU.TextChanged

    End Sub

    Private Sub Button_EFECTIVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_EFECTIVO.Click
        If Val(Me.TXT_TOTAL.Text) = 0 Then MsgBox("Ingrese Articulos", MsgBoxStyle.Information) : Exit Sub
        If Microsoft.VisualBasic.Left(Me.COMBO_DOC.Text, 1) = "F" And Me.TXT_RUC.Text = "" Then MsgBox("Ingresar Ruc para poder Facturar", MsgBoxStyle.Information) : Exit Sub
        With Pago_Efectivo
            .TXT_TC.Text = Me.TXT_TC.Text
            .LBL_MONTO.Text = Me.TXT_TOTAL.Text
            .CORR = CORR
            .ShowDialog()
        End With

    End Sub

    Private Sub Button_TARJETA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TARJETA.Click
        If Val(Me.TXT_TOTAL.Text) = 0 Then MsgBox("Ingrese Articulos", MsgBoxStyle.Information) : Exit Sub
        If Microsoft.VisualBasic.Left(Me.COMBO_DOC.Text, 1) = "F" And Me.TXT_RUC.Text = "" Then MsgBox("Ingresar Ruc para poder Facturar", MsgBoxStyle.Information) : Exit Sub
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

            If Microsoft.VisualBasic.Left(Me.COMBO_DOC.Text, 1) = "F" And Me.TXT_RUC.Text = "" Then MsgBox("Debe ingresar el numero de Ruc", MsgBoxStyle.Information) : Exit Sub

            If Val(Me.TXT_TOTAL.Text) = 0 Then MsgBox("Ingrese Articulos", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_CODCLIE.Text = "" Then MsgBox("Seleccione al Cliente", MsgBoxStyle.Information) : Exit Sub
            If MsgBox("Seguro que es una venta al Credito??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            ''VERIFICAMOS LIMITE DE CREDITO
            If OBJVENTAS.BUSCAR_LIMITE_CREDITO(NULO(Me.TXT_CODCLIE.Text, "S"), Me.TXT_TOTAL.Text) = False Then
                MsgBox("Este Cliente ya paso su limite de Credito", MsgBoxStyle.Critical)
                Exit Sub
            End If
            ''
            C = OBJVENTAS.GRABAR_VENTA(Me.COMBO_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), "S", Me.TXT_TC.Text, "C", Me.DT_DOC.Value,
                 Me.DT_PROC.Value, Me.TXT_TOTAL.Text, Me.TXT_VVENTA.Text, Me.TXT_IGV.Text, 0, 0, 0, NULO(Me.TXT_CODCLIE.Text, "S"),
                  0, 0, GUSERID, SystemInformation.ComputerName, Me.TXT_TURNO.Text, CORR, "", "", "", 0, 0)

            If C = 2 Then MsgBox("Esta fecha de proceso ya fue Cerrrada", MsgBoxStyle.Information) : Exit Sub
            If C = 3 Then MsgBox("Este documento ya existe", MsgBoxStyle.Information) : Exit Sub
            If C = 4 Then MsgBox("Si es Factura debe registrar el Ruc pro Mantenimiento de Clientes", MsgBoxStyle.Information) : Exit Sub
            If C = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
            If C = 0 Then
                MsgBox("Grabado Correctamente")
                IMPRIMIR()
                Button_CANCELAR_Click(Button_CANCELAR, EventArgs.Empty)
                'Me.Button2_Click(Button2, EventArgs.Empty)
            End If


        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Function GRABAR_EFECTIVO(ByVal SOLES As Double, ByVal DOLARES As Double, ByVal TOTAL_TARJETA As Double, ByVal VUELTO As Double, ByVal TIPO_PAGO As String) As Integer
        Try
            Dim C As Integer

            C = OBJVENTAS.GRABAR_VENTA(Me.COMBO_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), "S", Me.TXT_TC.Text, TIPO_PAGO, Me.DT_DOC.Value,
                 Me.DT_PROC.Value, Me.TXT_TOTAL.Text, Me.TXT_VVENTA.Text, Me.TXT_IGV.Text, VUELTO, SOLES, DOLARES, NULO(Me.TXT_CODCLIE.Text, "S"),
                  0, 0, GUSERID, SystemInformation.ComputerName, Me.TXT_TURNO.Text, CORR, "", "", "", 0, 0)
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
            C = OBJVENTAS.GRABAR_VENTA(Me.COMBO_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text), "S", Me.TXT_TC.Text, "T", Me.DT_DOC.Value,
                 Me.DT_PROC.Value, Me.TXT_TOTAL.Text, Me.TXT_VVENTA.Text, Me.TXT_IGV.Text, 0, 0, 0, NULO(Me.TXT_CODCLIE.Text, "S"),
                  0, 0, GUSERID, SystemInformation.ComputerName, Me.TXT_TURNO.Text, CORR, COD_TARJETA, MONEDA, NUM_TARJETA, Me.TXT_TOTAL.Text, 0)
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
        Me.picturebox1.Enabled = True
        Me.Button_EFECTIVO.Enabled = False
        Me.Button_TARJETA.Enabled = False
        Me.Button_CREDITO.Enabled = False
        Me.Button_CAJA.Enabled = False
    End Sub

    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
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
                .ACT = "Ventas_Documentos"
                .STATINI = 2
                .CARGAR_COMBO(arraybusqueda, 4, 2)
                .TIPO = 0
                .FECHA = Me.DT_PROC.Value
                .TURNO = Me.TXT_TURNO.Text
                .COD_DOC = Me.COMBO_DOC.SelectedValue
                '.TxtDatoBuscado.Text = Me.TXT_PROV.Tag


                .ShowDialog()

                ''
                If .GrecibeColumnaOpcional <> "" Then
                    If .GrecibeColumnaOpcional3 <> "" Then MsgBox("Este Documento se encuentra Anulado", MsgBoxStyle.Information) : Exit Sub
                    ASIGNAR_DATOS_VENTA()
                    OBJVENTAS.MOSTRAR_DETALLE(Me.COMBO_DOC.SelectedValue, .GrecibeColumnaOpcional, Me.DBLISTAR)

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
            Me.TXT_NRODOC.Text = FormatoTicket(BusquedaMaestra.GrecibeColumnaOpcional)
            Me.DT_DOC.Value = RS("FECHA_VENTA")
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


    Public Sub IMPRIMIR()
        Try
            'Dim Fuente As New System.Drawing.Font("Arial", 8)
            'Dim Grafico As System.Drawing.Graphics = e.Graphics
            Dim PORTIMP As String
            Dim TOTG As Double = 0
            Dim DSCTO As Boolean = False
           
            ''AVERIGUAR PUERTO DE IMPRESION
            PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP(Me.COMBO_DOC.SelectedValue)
            If PORTIMP = "" Then MsgBox("punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            ''
            'Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")
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

            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = Alineacion("I", IntAnchoTicket - 10, Len("Maq.Regist.No: " & GStrMaquinaReg), "Maq.Regist.No: " & GStrMaquinaReg) & Format(GDatFechaActual, "dd/MM/yyyy")
            file.WriteLine(strMaquinaReg)

            ' Imprimir el Número del Ticket
            Dim StrNumeroTicket As String
            Dim DOCU As String = IIf(Strings.Left(Me.COMBO_DOC.Text, 1) = "B", " BOL. ", " FACT.")
            Dim STRTIPODOC = "Ticket No" & DOCU
            StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(STRTIPODOC & ":" & (Me.TXT_NRODOC.Text)), STRTIPODOC & ": " & (Me.TXT_NRODOC.Text)) & Format(DateTime.Now, "HH:mm:ss")
            file.WriteLine(StrNumeroTicket)

            ' Imprimir los Datos del Cliente
            If Trim(Me.TXT_RAZON.Text) <> Nothing Then
                Dim LStrRazonSocial As String
                LStrRazonSocial = Alineacion("I", IntAnchoTicket, Len("Raz.Soc:" & Me.TXT_RAZON.Text.Trim), "NOMBRE :" & Me.TXT_RAZON.Text.Trim)
                file.WriteLine(LStrRazonSocial)
            End If

            If Trim(Me.TXT_RUC.Text) <> Nothing Then
                Dim LStrRUC As String
                LStrRUC = Alineacion("I", IntAnchoTicket, Len("RUC    :" & Me.TXT_RUC.Text.Trim), "RUC    :" & Me.TXT_RUC.Text.Trim)
                file.WriteLine(LStrRUC)
            End If

            If Trim(Me.TXT_DIRECCION.Text) <> Nothing Then
                Dim LstrDireccion As String
                LstrDireccion = Alineacion("I", IntAnchoTicket, Len("DIRECC.:" & Me.TXT_DIRECCION.Text.Trim), "DIRECC :" & Me.TXT_DIRECCION.Text.Trim)
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
            Dim OCOMANDO As New SqlCommand("EXEC VENTA_MOSTRAR_DETALLE '" & Me.COMBO_DOC.SelectedValue & "'," & ArmaNumero(Me.TXT_NRODOC.Text) & "", CN_NET)
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
            ''**
            ''IMPRIMO DESCUENTO
            If DSCTO = True Then
                Dim StrTotalSD As String
                StrTotalSD = Alineacion("I", 17, Len("**** DESCUENTO   "), "**** DESCUENTO   ")
                StrTotalSD = StrTotalSD & Alineacion("I", 7, Len(GstrSimbMonedaBase & " :"), GstrSimbMonedaBase & " :")
                StrTotalSD = StrTotalSD & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(TOTG - CDbl(Me.TXT_TOTAL.Text), 2)), GFormatodeNumero(TOTG - CDbl(Me.TXT_TOTAL.Text), 2))
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
                StrValoventa = StrValoventa & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(Me.TXT_VVENTA.Text, 2)), GFormatodeNumero(Me.TXT_VVENTA.Text, 2))
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
                StrImpuesto = StrImpuesto & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(Me.TXT_IGV.Text, 2)), GFormatodeNumero(Me.TXT_IGV.Text, 2))
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
            StrTotal = StrTotal & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(Me.TXT_TOTAL.Text, 2)), GFormatodeNumero(Me.TXT_TOTAL.Text, 2))
            'Else
            'StrTotal = StrTotal & Alineacion("I", 7, Len(GstrSimbMonedaExtr & " :"), GstrSimbMonedaExtr & " :")
            'StrTotal = StrTotal & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(DblTotalExt, Gdeciresu)), GFormatodeNumero(DblTotalExt, Gdeciresu))
            'End If
            file.WriteLine(StrTotal)

            ' Parte que Imprimie el Tipo de Pago

            Dim StrTipoPagoImp As String
            Dim RSTARJETA As SqlDataReader 'New ADODB.Recordset
            RSTARJETA = OBJPAGOS.MOSTRAR_TARJETA_DETALLE(Me.COMBO_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text))
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
            RSPAGO = OBJVENTAS.MOSTRAR_CABECERA(Me.COMBO_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text))
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
                Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        REIMPRIME = 1
        IMPRIMIR()

    End Sub

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
        Cierre_X.ShowDialog()
    End Sub

    Private Sub FinDeDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinDeDiaToolStripMenuItem.Click
        Fin_Dia.ShowDialog()
    End Sub

    Private Sub Button_ANULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ANULAR.Click
        Try
            Dim VALOR As Integer
            If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If ANULAR_VENTAS = True Then
                VALOR = OBJVENTAS.ANULAR_VENTA(Me.COMBO_DOC.SelectedValue, ArmaNumero(Me.TXT_NRODOC.Text))
                If VALOR = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
                If VALOR = 0 Then MsgBox("Anulado Correctamente", MsgBoxStyle.Information)
                REIMPRIME = 2
                IMPRIMIR()
                Button_CANCELAR_Click(Button_CANCELAR, EventArgs.Empty)
            Else
                Login_Permiso.TXT_USER.Clear()
                Login_Permiso.TXT_PSW.Clear()
                Login_Permiso.ACCION = "ANULAR VENTA"
                Login_Permiso.COD_DOC = Me.COMBO_DOC.SelectedValue
                Login_Permiso.NRO_DOC = Me.TXT_NRODOC.Text
                Login_Permiso.ShowDialog()
            End If
           

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TXT_CODCLIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CODCLIE.KeyPress
        Dim RS As SqlDataReader 'New ADODB.Recordset
        If e.KeyChar = ChrW(Keys.Enter) Then
            RS = OBJCLIE.BUSCAR_CLIE(Me.TXT_CODCLIE.Text, "COD_CLIENTE")
            If RS.HasRows = True Then
                While RS.Read
                    Me.TXT_RAZON.Text = NULO(RS("DESCRIPCION"), "S")
                    Me.TXT_RUC.Text = NULO(RS("RUC"), "S")
                    Me.TXT_DIRECCION.Text = NULO(RS("DIR_CLIENTE"), "S")
                End While
            Else
                If MsgBox("Cliente no existe, desea crearlo??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    With Venta_Cliente
                        .TXT_CODCLIE.Text = Me.TXT_CODCLIE.Text.Trim
                        .TXT_DESC.Text = Me.TXT_RAZON.Text.Trim
                        .TXT_RUC.Text = Me.TXT_RUC.Text.Trim
                        .TXT_DIREC.Text = Me.TXT_DIRECCION.Text.Trim
                        .ShowDialog()
                    End With
                End If
            End If
            RS.Close()
            CN_NET.Close()
        End If
    End Sub

    Private Sub TXT_CODCLIE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODCLIE.TextChanged

    End Sub

    Private Sub Button_CAJA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CAJA.Click
        Movi_Caja.ShowDialog()
    End Sub

    Private Sub TXT_RUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_RUC.KeyPress
        Dim RS As SqlDataReader 'New ADODB.Recordset

        If e.KeyChar = ChrW(Keys.Enter) Then
            RS = OBJCLIE.BUSCAR_CLIE(Me.TXT_RUC.Text.Trim, "RUC_CLIENTE")
            If RS.HasRows = True Then
                While RS.Read
                    Me.TXT_RAZON.Text = NULO(RS("DESCRIPCION"), "S")
                    Me.TXT_CODCLIE.Text = NULO(RS("CODIGO"), "S")
                    Me.TXT_DIRECCION.Text = NULO(RS("DIR_CLIENTE"), "S")
                End While
            Else
                If MsgBox("Cliente no existe, desea crearlo??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    With Venta_Cliente
                        .TXT_CODCLIE.Text = Me.TXT_CODCLIE.Text.Trim
                        .TXT_DESC.Text = Me.TXT_RAZON.Text.Trim
                        .TXT_RUC.Text = Me.TXT_RUC.Text.Trim
                        .TXT_DIREC.Text = Me.TXT_DIRECCION.Text.Trim
                        .ShowDialog()
                    End With
                End If
            End If
            RS.Close()
            CN_NET.Close()
        End If
    End Sub

    Private Sub TXT_RUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_RUC.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim TOT As Double = 0
        Dim F As Integer
        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Agregue Articulos", MsgBoxStyle.Information) : Exit Sub
        If Me.DBLISTAR.Row > 0 Then
            With Ventas_Dscto
                .Tag = "T"
                '.LBLIDDETALLE.Text = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0)
                .LBLCORRELATIVO.Text = CORR
                For F = 1 To Me.DBLISTAR.Rows.Count - 1
                    TOT = TOT + Me.DBLISTAR.Item(F, 4) * Me.DBLISTAR.Item(F, 5)
                Next
                .TXT_TOTAL.Text = GFormatodeNumero(TOT, 2)
                .OPT_VALOR.Checked = True
                .TXT_DSCTO.Text = GFormatodeNumero(Val(.TXT_TOTAL.Text) - Val(.TXT_TOTAL.Text) / (1 + IGV / 100), 2)
                .CALCULAR()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Agregue Articulos", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Row > 0 Then
                With Ventas_Dscto
                    .Tag = "I"
                    .LBLIDDETALLE.Text = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0)
                    .LBLCORRELATIVO.Text = CORR
                    .TXT_TOTAL.Text = GFormatodeNumero(Me.DBLISTAR.Item(DBLISTAR.Row, 4) * Me.DBLISTAR.Item(DBLISTAR.Row, 5), 2)
                    .OPT_VALOR.Checked = True
                    .TXT_DSCTO.Text = GFormatodeNumero(Val(.TXT_TOTAL.Text) - Val(.TXT_TOTAL.Text) / (1 + IGV / 100), 2)
                    .CALCULAR()
                    .ShowDialog()
                End With
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub GroupBox8_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox8.Enter

    End Sub
End Class