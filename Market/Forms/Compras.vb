Public Class Compras
    Dim OBJCOMPRA As ClsCompra
    Dim OBJTC As ClsTC
    Dim OBJART As ClsArticulo
    Dim OBJPTOVTA As ClsPtoVta
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String

    Dim COL_COD As Integer = 0
    Dim COL_DESC As Integer = 1
    Dim COL_MEDIDA As Integer = 2
    Dim COL_CANT As Integer = 3
    Dim COL_PU As Integer = 4
    Dim COL_TOTAL As Integer = 5
    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCOMPRA = New ClsCompra
        OBJTC = New ClsTC
        OBJART = New ClsArticulo
        OBJPTOVTA = New ClsPtoVta
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        ObtenerConfiguracionTicket(1)
        LISTAR_TIPO_DOC(Me.Combo_DOC, "C")
    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Me.TXT_ESTADO.Text = ""

            'Me.txt_cod.Text = BUSCARCOD("FORMA_PAGO", "COD_FP", "000")
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.DT_FECHA.Value = Date.Now
            Me.DT_VCTO.Value = Date.Now
            Me.DBLISTAR.Rows.Count = 1
            Me.Combo_DOC.Tag = 0
            'Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "C")
            'Me.txt_cod.Enabled = False
            FORMATO()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub FORMATO()
        With Me.DBLISTAR
            .Item(0, 0) = "Codigo"
            .Item(0, 1) = "Descripcion"
            .Item(0, 2) = "Medida"
            .Item(0, 3) = "Cantidad"
            .Item(0, 4) = "P.U."
            .Item(0, 5) = "Total"
        End With
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.PictureBox1.Enabled = Iblnvalor

        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        Dim F As Integer
        Dim C As Integer = 0
        If Me.TXT_ALMACEN.Text = "" Then MsgBox("Seleccione el Almacen", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_PROV.Text = "" Then MsgBox("Ingrese Proveedor", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_SERIE.Text = "" Then MsgBox("Ingrese Serie", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_NUMERO.Text = "" Then MsgBox("Ingrese Numero", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_TC.Text) = 0 Then MsgBox("Ingrese Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub
        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Ingrese Detalle del Documento", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR DATOS LLENOS DEL DETALLE
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            If Val(Me.DBLISTAR.Item(F, COL_CANT)) = 0 Or Val(Me.DBLISTAR.Item(F, COL_PU)) = 0 Then
                C = 1
                Exit For
            End If
        Next
        If C = 1 Then MsgBox("Verifique datos del Detalle", MsgBoxStyle.Information) : Exit Sub
        ' ''VALIDAR SI EXISTE
        'If pb_agregar = True Then
        '    If BUSCAR_EXISTE("COMPRAS", "COD_DOC+SERIE_COMPRA+NUM_COMPRA+COD_PROVED", Me.Combo_DOC.SelectedValue + Me.TXT_SERIE.Text.Trim + Me.TXT_NUMERO.Text.Trim + Me.TXT_PROV.Tag) = True Then
        '        MsgBox("Documento ya existe", MsgBoxStyle.Information) : Exit Sub
        '    End If
        'End If
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJCOMPRA.GRABAR(Me.Combo_DOC.Tag, Me.Combo_DOC.SelectedValue, Me.TXT_SERIE.Text.Trim, Me.TXT_NUMERO.Text.Trim, Me.DT_FECHA.Value, Me.DT_VCTO.Value, Me.TXT_PROV.Tag, IIf(Me.OPT_SOLES.Checked = True, "S", "D"), Me.TXT_TC.Text, IIf(Me.CHK_IGV.Checked = True, 1, 0), Me.TXT_FPAGO.Tag, Me.TXT_VVENTA.Text, Me.TXT_IGV.Text, Me.TXT_TOTAL.Text, GUSERID, Me.TXT_COMENTARIO.Text.Trim, Me.TXT_ALMACEN.Tag, Me.TXT_NRO_PERCEPCION.Text, Val(Me.TXT_PERCEPCION.Text), TIPO, Me.DBLISTAR)
        If intvalor = 2 Then MsgBox("Documento ya existe", MsgBoxStyle.Information) : Exit Sub
        If intvalor = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
        If intvalor = 0 Then
            MsgBox("Compra grabada con exito", MsgBoxStyle.Information)
            Combo_DOC.Tag = OBJCOMPRA.ID
            IMPRIMIR()
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Dim OBJUSER As New ClsUsu
        If OBJUSER.Validar_PERMISO("1002", GUSERID) = False Then MsgBox("Usted no tiene permiso para modificar esta Compra", MsgBoxStyle.Information) : Exit Sub
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        'Me.txt_cod.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        Dim OBJUSER As New ClsUsu
        If OBJUSER.Validar_PERMISO("1003", GUSERID) = False Then MsgBox("Usted no tiene permiso para Anular esta Compra", MsgBoxStyle.Information) : Exit Sub
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJCOMPRA.ANULAR_COMPRA(Me.Combo_DOC.Tag)
        If intvalor = 0 Then
            MsgBox("Documento anulado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        'Me.txt_cod.Enabled = False
    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click
        'With Impresion
        '    .FORM = "Mant_FPago"
        '    .SW = 2
        '    .CADENA = ""
        '    .CAMPO = ""
        '    .Show()

        'End With
        IMPRIMIR()
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub Combo_DOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_DOC.SelectedIndexChanged
       
    End Sub

    Private Sub TXT_SERIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_SERIE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.TXT_NUMERO.Focus()
        End If
    End Sub

    Private Sub TXT_SERIE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_SERIE.LostFocus
        Me.TXT_SERIE.Text = Microsoft.VisualBasic.Right("0000" + Me.TXT_SERIE.Text, 4)
    End Sub

    Private Sub TXT_SERIE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SERIE.TextChanged

    End Sub

    Private Sub TXT_NUMERO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NUMERO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.DT_FECHA.Focus()
        End If
    End Sub

    Private Sub TXT_NUMERO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_NUMERO.LostFocus
        Me.TXT_NUMERO.Text = Microsoft.VisualBasic.Right("00000000" + Me.TXT_NUMERO.Text, 8)
    End Sub

    Private Sub TXT_NUMERO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NUMERO.TextChanged

    End Sub

    Private Sub DT_FECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FECHA.ValueChanged
        Try

            Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "C")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_PROVED"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_PROVED"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_PROVED"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Proveedores"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_PROV.Tag = .GrecibeColumnaID
                Me.TXT_PROV.Text = .GrecibeColumnaOpcional
                ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
    Sub ASIGNAR_DATOS()

        Dim OBJPROV As New ClsProveedor
        Dim RS As SqlDataReader
        RS = OBJPROV.LISTAR_PROV(Me.TXT_PROV.Tag)
        While RS.Read
            Me.TXT_PORC_PERCEP.Text = RS("PERCEP_PROVED")
            Me.Group_PERCEP.Visible = True
            If Val(TXT_PORC_PERCEP.Text) = 0 Then
                Me.Group_PERCEP.Visible = False
                Me.TXT_PORC_PERCEP.Text = 0
                Me.TXT_NRO_PERCEPCION.Clear()
            End If
        End While
        CN_NET.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "COD_FP"
        arraybusqueda(1, 2) = "Usuario"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_FP"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "DIAS_FP"
        arraybusqueda(3, 2) = "Dias "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "STAT_FP"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_FPago"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_FPAGO.Tag = .GrecibeColumnaID
                Me.TXT_FPAGO.Text = .GrecibeColumnaOpcional
                DT_VCTO.Value = Me.DT_FECHA.Value.AddDays(.GrecibeColumnaOpcional2)

            End If
            .Close()
        End With

    End Sub

    Private Sub DBLISTAR_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.AfterEdit
        Me.DBLISTAR.Item(e.Row, 5) = Format(Val(Me.DBLISTAR.Item(e.Row, 3)) * Val(Me.DBLISTAR.Item(e.Row, 4)), "###,###,###.00")
        DBLISTAR.AutoSizeCols()
        TOTALES()
    End Sub

    Private Sub DBLISTAR_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.BeforeEdit
        If e.Col < 3 Or e.Col = 5 Then e.Cancel = True
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
        'Lineas que llaman al Formulario de Búsqueda

        ''Dim arraybusqueda(3, 3) As Object
        ''arraybusqueda(1, 1) = "COD_ART"
        ''arraybusqueda(1, 2) = "Codigo"
        ''arraybusqueda(1, 3) = 1500
        ''arraybusqueda(2, 1) = "Desc_ART"
        ''arraybusqueda(2, 2) = "Descripcion "
        ''arraybusqueda(2, 3) = 3000
        ''arraybusqueda(3, 1) = "Stock_ART"
        ''arraybusqueda(3, 2) = "Stock "
        ''arraybusqueda(3, 3) = 1500



        ''''
        ''With BusquedaMaestra
        ''    .ACT = "Consultar_Articulos_Prov"
        ''    .STATINI = 0
        ''    .CARGAR_COMBO(arraybusqueda, 3, 2)
        ''    .TIPO = 1
        ''    '.TxtDatoBuscado.Text = Me.TXT_PROV.Tag
        ''    .TxtDatoBuscado.Tag = Me.TXT_PROV.Tag

        ''    .ShowDialog()

        ''    ''
        ''    If .GrecibeColumnaID <> "" Then
        ''        'Me.TXT_COD.Text = .GrecibeColumnaID
        ''        'Me.TXT_DESC.Text = .GrecibeColumnaOpcional
        ''        'Me.LblAnulado.Text = .GrecibeColumnaOpcional2
        ''        ASIGNAR_CAMPOS()
        ''        Me.DBLISTAR.AutoSizeCol(0)
        ''        Me.DBLISTAR.AutoSizeCol(1)
        ''        Me.DBLISTAR.AutoSizeCol(2)
        ''    End If
        ''    .Close()
        ''End With
        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "ARTICULOS.DESC_ART"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_ART"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        ''
        With Consultar_Articulos
            .ACT = "Mant_Articulos"
            .PROV = ""
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                ASIGNAR_CAMPOS(.GrecibeColumnaID)
                'AGREGAR_TEMP(.GrecibeColumnaID)
            End If
            .Close()
        End With
    End Sub
    Sub ASIGNAR_CAMPOS(COD_ART As String)
        Dim RS As SqlDataReader
        RS = OBJART.LISTAR_ARTICULOS(COD_ART)
        While RS.Read
            'If Not (RS.EOF And RS.BOF) Then
            Me.DBLISTAR.AddItem(RS("CODIGO") & vbTab & RS("DESCRIPCION") & vbTab & RS("DESC_MEDIDA"))
        End While
        RS.Close()
        CN_NET.Close()
        DBLISTAR.AutoSizeCols(COL_DESC)
    End Sub
    Sub TOTALES()
        Dim F As Integer
        Dim PERCEP As Double = 0
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOT = TOT + Me.DBLISTAR.Item(F, 5)
        Next
        If Me.CHK_IGV.Checked = False Then
            Me.TXT_VVENTA.Text = Format(TOT, "###,###,###.00")
            Me.TXT_IGV.Text = Format(TOT * (IGV / 100), "###,###,###.00")
            PERCEP = (TOT * (1 + (IGV / 100))) * (Val(Me.TXT_PORC_PERCEP.Text) / 100)
            Me.TXT_PERCEPCION.Text = Format(PERCEP, "###,###,###.00")
            Me.TXT_TOTAL.Text = Format(TOT + (TOT * (IGV / 100) + PERCEP), "###,###,###.00")
        Else
            Me.TXT_VVENTA.Text = Format(TOT / (1 + IGV / 100), "###,###,###.00")
            Me.TXT_IGV.Text = Format(TOT - (TOT / (1 + IGV / 100)), "###,###,###.00")
            PERCEP = (TOT) * (Val(Me.TXT_PORC_PERCEP.Text) / 100)
            Me.TXT_PERCEPCION.Text = Format(PERCEP, "###,###,###.00")
            Me.TXT_TOTAL.Text = Format(TOT + PERCEP, "###,###,###.00")
        End If
    End Sub
    Private Sub DBLISTAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DBLISTAR.KeyPress

    End Sub

    Private Sub CHK_IGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_IGV.CheckedChanged
        TOTALES()
    End Sub

    Private Sub DBLISTAR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBLISTAR.KeyUp

        If e.KeyCode = Keys.Delete And Me.DBLISTAR.Row > 0 Then
            Me.DBLISTAR.RemoveItem(Me.DBLISTAR.Row)
            TOTALES()
        End If
    End Sub


    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        Consultar_Compras.Tag = "Compras"
        Consultar_Compras.ShowDialog()
    End Sub
    Public Sub LLENAR_DATOS(ByVal COD_ID As Double)
        ''
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        ''
        Dim OTABLA As DataTable
        'Dim RS As New DataSet 'SqlDataReader 'New ADODB.Recordset
        OTABLA = OBJCOMPRA.BUSCAR_COMPRA(COD_ID)
        Dim OFILA As DataRow
        'For Each OFILA In OTABLA.Rows
        OFILA = OTABLA.Rows(0) 'RS.Tables("SQL").Rows(0)
        Me.Combo_DOC.Tag = COD_ID
        Me.Combo_DOC.SelectedValue = OFILA.Item("COD_DOC")
        Me.TXT_SERIE.Text = OFILA.Item("serie_compra")
        Me.TXT_NUMERO.Text = OFILA.Item("NUM_COMPRA")
        Me.DT_FECHA.Value = OFILA.Item("FECHA_COMPRA")
        Me.DT_VCTO.Value = OFILA.Item("VENC_COMPRA")
        Me.TXT_PROV.Tag = OFILA.Item("COD_PROVED")
        Me.TXT_PROV.Text = OFILA.Item("DESC_PROVED")
        ASIGNAR_DATOS()
        Me.TXT_NRO_PERCEPCION.Text = OFILA.Item("NRO_PERCEP")
        Me.TXT_PERCEPCION.Text = OFILA.Item("PERCEP_COMPRA")

        If OFILA.Item("MON_COMPRA") = "S" Then Me.OPT_SOLES.Checked = True Else Me.OPT_DOLARES.Checked = True
        Me.TXT_TC.Text = OFILA.Item("TC_COMPRA")
        ''If OFILA.Item("INC_COMPRA") = 1 Then Me.CHK_IGV.Checked = True Else Me.CHK_IGV.Checked = False
        Me.CHK_IGV.Checked = OFILA.Item("INC_COMPRA")
        Me.TXT_FPAGO.Tag = OFILA.Item("COD_FP")
        Me.TXT_FPAGO.Text = OFILA.Item("DESC_FP")
        Me.TXT_COMENTARIO.Text = OFILA.Item("OBS_COMPRA")

        TXT_ALMACEN.Tag = OFILA.Item("COD_ALMACEN")
        TXT_ALMACEN.Text = OFILA.Item("DESC_ALMACEN")

        If OFILA.Item("PAGOS_COMPRA") <> 0 Then
            MsgBox("Este Documento contiene pagos, por lo tanto solo se podra consultar", MsgBoxStyle.Information)
            Me.ToolModificar.Enabled = False
            Me.ToolAnular.Enabled = False
        Else
            Me.ToolModificar.Enabled = True
            Me.ToolAnular.Enabled = True
        End If
        ''LLENAMOS DETALLE
        For Each OFILA In OTABLA.Rows
            Me.DBLISTAR.AddItem(OFILA.Item("COD_ART") & vbTab & OFILA.Item("DESC_ART") & vbTab & OFILA.Item("DESC_MEDIDA") & vbTab & OFILA.Item("CANT_DC") & vbTab & OFILA.Item("PU_DC") & vbTab & Format(OFILA.Item("CANT_DC") * OFILA.Item("PU_DC"), "###,###,###.00"))
        Next

        'While RS.Read


        'Me.DBLISTAR.Rows.Count = 1
        'Do While Not RS.EOF
        'Me.DBLISTAR.AddItem(RS.Fields("COD_ART").Value & vbTab & RS.Fields("DESC_ART").Value & vbTab & RS.Fields("DESC_MEDIDA").Value & vbTab & RS.Fields("CANT_DC").Value & vbTab & RS.Fields("PU_DC").Value & vbTab & Format(RS.Fields("CANT_DC").Value * RS.Fields("PU_DC").Value, "###,###,###.00"))
        'RS.MoveNext()
        'Loop

        'End While
        DBLISTAR.AutoSizeCols()
        TOTALES()
        'RS.Close()
    End Sub

    Public Sub IMPRIMIR()
        Try
            Dim PORTIMP As String
            Dim TOTG As Double = 0
            Dim DSCTO As Boolean = False
            ''AVERIGUAR PUERTO DE IMPRESION
            PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP("002")
            If PORTIMP = "" Then MsgBox("punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
            ''
            Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")

            Dim LHead1 As String ', LHead2 As String, LHead3 As String, LHead4 As String, LHead5 As String, LHead6 As String, LHead7 As String, LHead8 As String, LHead9 As String, LHead10 As String
            Dim LFoot1 As String, LFoot2 As String, LFoot3 As String, LFoot4 As String, LFoot5 As String, LFoot6 As String, LFoot7 As String, LFoot8 As String, LFoot9 As String, LFoot10 As String


            PObtener_FechaServidor()

            ' Imprimir la Cabecera
            Dim IntAnchoTicket = 39
            LHead1 = Alineacion("C", IntAnchoTicket, Len(Trim("Impresion de Compra")), Trim("Impresion de Compra"))
            'LHead2 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD2)), Trim(GHEAD2))
            'LHead3 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD3)), Trim(GHEAD3))
            'LHead4 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD4)), Trim(GHEAD4))
            'LHead5 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD5)), Trim(GHEAD5))
            'LHead6 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD6)), Trim(GHEAD6))
            'LHead7 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD7)), Trim(GHEAD7))
            'LHead8 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD8)), Trim(GHEAD8))
            'LHead9 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD9)), Trim(GHEAD9))
            'LHead10 = Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD10)), Trim(GHEAD10))

            '---------------------------------------------------------------------------------------------

            If Trim(LHead1) <> Nothing Then file.WriteLine(LHead1)
            'If Trim(LHead2) <> Nothing Then file.WriteLine(LHead2)
            'If Trim(LHead3) <> Nothing Then file.WriteLine(LHead3)
            'If Trim(LHead4) <> Nothing Then file.WriteLine(LHead4)
            'If Trim(LHead5) <> Nothing Then file.WriteLine(LHead5)
            'If Trim(LHead6) <> Nothing Then file.WriteLine(LHead6)
            'If Trim(LHead7) <> Nothing Then file.WriteLine(LHead7)
            'If Trim(LHead8) <> Nothing Then file.WriteLine(LHead8)
            'If Trim(LHead9) <> Nothing Then file.WriteLine(LHead9)
            'If Trim(LHead10) <> Nothing Then file.WriteLine(LHead10)

            'Imprimir la Linea
            Dim LLinea1 As String
            LLinea1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea1)), Trim(GstrLinea1))

            If Trim(LLinea1) <> Nothing Then file.WriteLine(LLinea1)


            ' Imprimir el Número del Ticket
            Dim StrNumeroTicket As String
            Dim DOCU As String = IIf(Strings.Left(Me.Combo_DOC.Text, 1) = "B", " BOL. ", " FACT.")
            Dim STRTIPODOC = "Nº " & DOCU
            StrNumeroTicket = Alineacion("I", IntAnchoTicket - 9, Len(STRTIPODOC & ":" & (Me.TXT_SERIE.Text.Trim + "-" + Me.TXT_NUMERO.Text)), STRTIPODOC & ": " & (Me.TXT_SERIE.Text.Trim + "-" + Me.TXT_NUMERO.Text.Trim)) & Format(DateTime.Now, "HH:mm:ss")
            file.WriteLine(StrNumeroTicket)

            ' Imprimir los Datos del Proveedor
            If Trim(Me.TXT_PROV.Text) <> Nothing Then
                Dim LStrRazonSocial As String
                LStrRazonSocial = Alineacion("I", IntAnchoTicket, Len("Raz.Soc:" & Me.TXT_PROV.Text.Trim), "NOMBRE :" & Me.TXT_PROV.Text.Trim)
                file.WriteLine(LStrRazonSocial)
            End If

            'If Trim(Me.TXT_RUC.Text) <> Nothing Then
            Dim LStrFECHA As String
            LStrFECHA = Alineacion("I", IntAnchoTicket, Len("FECHA  :" & Format(Me.DT_FECHA.Value, "dd/MM/yyyy")), "FECHA  :" & Format(Me.DT_FECHA.Value, "dd/MM/yyyy"))
            file.WriteLine(LStrFECHA)
            'End If

            'If Trim(Me.TXT_DIRECCION.Text) <> Nothing Then
            Dim LstrVENC As String
            LstrVENC = Alineacion("I", IntAnchoTicket, Len("VENC   :" & Format(Me.DT_VCTO.Value, "dd/MM/yyyy")), "VENC   :" & Format(Me.DT_VCTO.Value, "dd/MM/yyyy"))
            file.WriteLine(LstrVENC)
            'End If


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
            Dim OTABLA As DataTable
            'Dim RS As New DataSet 'SqlDataReader 'New ADODB.Recordset
            OTABLA = OBJCOMPRA.BUSCAR_COMPRA(Combo_DOC.Tag)
            Dim OFILA As DataRow
            'For Each OFILA In OTABLA.Rows
            OFILA = OTABLA.Rows(0) 'RS.Tables("SQL").Rows(0
            Dim LstrProducto As String
            Dim LstrDescripcion As String
            For Each OFILA In OTABLA.Rows
                LstrProducto = ""
                LstrDescripcion = ""
                'Me.DBLISTAR.AddItem(OFILA.Item("COD_ART") & vbTab & OFILA.Item("DESC_ART") & vbTab & OFILA.Item("DESC_MEDIDA") & vbTab & OFILA.Item("CANT_DC") & vbTab & OFILA.Item("PU_DC") & vbTab & Format(OFILA.Item("CANT_DC") * OFILA.Item("PU_DC"), "###,###,###.00"))
                LstrProducto = Alineacion("I", 15, Len(Trim(OFILA.Item("COD_ART"))), Trim(OFILA.Item("COD_ART"))) & _
                               Alineacion("I", 7, Len(Trim(OFILA.Item("DESC_MEDIDA"))), Trim(OFILA.Item("DESC_MEDIDA"))) & _
                               Alineacion("I", 11, Len(GFormatodeNumero(OFILA.Item("CANT_DC"), 4) & "x"), (GFormatodeNumero(OFILA.Item("CANT_DC"), 4)) & "x") & _
                               Alineacion("D", IntAnchoTicket - 10 - 5 - 11 - 8, Len(GFormatodeNumero(OFILA.Item("PU_DC"), 2)), GFormatodeNumero(OFILA.Item("PU_DC"), 2))
                file.WriteLine(LstrProducto)
                LstrDescripcion = Alineacion("I", 30, Len(Trim(OFILA.Item("DESC_ART"))), Trim(OFILA.Item("DESC_ART"))) & _
                                  Alineacion("D", IntAnchoTicket - 30, Len(Format(OFILA.Item("CANT_DC") * OFILA.Item("PU_DC"), "###,###,###.00")), Format(OFILA.Item("CANT_DC") * OFILA.Item("PU_DC"), "###,###,###.00"))

                TOTG = TOTG + (OFILA.Item("CANT_DC") * OFILA.Item("PU_DC"))

                file.WriteLine(LstrDescripcion)

                'Me.DBLISTAR.AddItem(OFILA.Item("COD_ART") & vbTab & OFILA.Item("DESC_ART") & vbTab & OFILA.Item("DESC_MEDIDA") & vbTab & OFILA.Item("CANT_DC") & vbTab & OFILA.Item("PU_DC") & vbTab & Format(OFILA.Item("CANT_DC") * OFILA.Item("PU_DC"), "###,###,###.00"))
            Next
            ' Imprimir la Línea 3
            Dim LLinea3 As String
            LLinea3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea3)), Trim(GstrLinea3))

            If Trim(LLinea3) <> Nothing Then
                file.WriteLine(LLinea3)
            End If

            ' Imprimir Totales
            Dim GstrSimbMonedaBase As String = "S/ "
            Dim GstrSimbMonedaExtr As String = "US$ "


            Dim StrValoventa As String
            StrValoventa = Alineacion("I", 17, Len("**** Valor Venta "), "**** Valor Venta ")
            StrValoventa = StrValoventa & Alineacion("I", 7, Len(IIf(Me.OPT_SOLES.Checked = True, GstrSimbMonedaBase, GstrSimbMonedaExtr) & " :"), IIf(Me.OPT_SOLES.Checked = True, GstrSimbMonedaBase, GstrSimbMonedaExtr) & " :")
            StrValoventa = StrValoventa & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(Me.TXT_VVENTA.Text, 2)), GFormatodeNumero(Me.TXT_VVENTA.Text, 2))
            file.WriteLine(StrValoventa)


            Dim StrImpuesto As String
            StrImpuesto = Alineacion("I", 17, Len("**** IGV         "), "**** IGV         ")
            StrImpuesto = StrImpuesto & Alineacion("I", 7, Len(IIf(Me.OPT_SOLES.Checked = True, GstrSimbMonedaBase, GstrSimbMonedaExtr) & " :"), IIf(Me.OPT_SOLES.Checked = True, GstrSimbMonedaBase, GstrSimbMonedaExtr) & " : ")
            StrImpuesto = StrImpuesto & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(Me.TXT_IGV.Text, 2)), GFormatodeNumero(Me.TXT_IGV.Text, 2))
            file.WriteLine(StrImpuesto)


            Dim StrTotal As String
            StrTotal = Alineacion("I", 17, Len("**** TOTAL       "), "**** TOTAL       ")
            StrTotal = StrTotal & Alineacion("I", 7, Len(IIf(Me.OPT_SOLES.Checked = True, GstrSimbMonedaBase, GstrSimbMonedaExtr) & " :"), IIf(Me.OPT_SOLES.Checked = True, GstrSimbMonedaBase, GstrSimbMonedaExtr) & " :")
            StrTotal = StrTotal & Alineacion("D", IntAnchoTicket - 17 - 7, Len(GFormatodeNumero(Me.TXT_TOTAL.Text, 2)), GFormatodeNumero(Me.TXT_TOTAL.Text, 2))
            file.WriteLine(StrTotal)


            ' Imprimir Tipo de cambio y Cajero
            Dim StrDatosVendedor As String
            StrDatosVendedor = Alineacion("D", 3, Len("TC:"), "TC:")
            'StrDatosVendedor = StrDatosVendedor & Alineacion("I", 12, Len(RSPAGO("CAMBIO_VENTA")), RSPAGO("CAMBIO_VENTA"))
            StrDatosVendedor = StrDatosVendedor & Alineacion("D", 10, Len("CAJERO:"), "CAJERO:")
            StrDatosVendedor = StrDatosVendedor & Alineacion("I", IntAnchoTicket - 6 - 3 - 8, Len(GUSERID), GUSERID)

            file.WriteLine(StrDatosVendedor)
            ' Imprimir la Línea 4

            Dim LLinea4 As String
            LLinea4 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrLinea4)), Trim(GstrLinea4))
            If Trim(LLinea4) <> Nothing Then
                file.WriteLine(LLinea4)
            End If

            ' Imprimir Pie de Página

            LFoot1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT1)), Trim(GstrFOOT1))
            LFoot2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT2)), Trim(GstrFOOT2))
            LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT2)), Trim(GstrFOOT2))
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_ALMACEN"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_ALMACEN"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_ALMACEN"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Almacen"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_ALMACEN.Tag = .GrecibeColumnaID
                Me.TXT_ALMACEN.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub
End Class