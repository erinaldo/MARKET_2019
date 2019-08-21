Public Class Movimientos
    Dim OBJMOV As ClsMovimiento
    Dim OBJTC As ClsTC
    Dim OBJART As ClsArticulo
    Dim OBJTMOV As ClsTMov
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
    Private Sub Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "I" Then
            Me.Label3.Text = "INGRESOS"
            LISTAR_TIPO_MOV(Me.Combo_mov, "I")
        Else
            Me.Label3.Text = "SALIDAS"
            LISTAR_TIPO_MOV(Me.Combo_mov, "S")
        End If
        OBJMOV = New ClsMovimiento
        OBJTC = New ClsTC
        OBJART = New ClsArticulo
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)


    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Me.TXT_ESTADO.Text = ""

            Me.TXT_COD.Text = Microsoft.VisualBasic.Right("000000" + (OBJMOV.CODIGO(Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1))), 6)
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.DT_FECHA.Value = Date.Now
            Me.DBLISTAR.Rows.Count = 1

            'Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "C")
            'Me.txt_cod.Enabled = False
            FORMATO()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.PictureBox1.Enabled = Iblnvalor
        Me.Combo_mov.Enabled = Iblnvalor
        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        Dim F As Integer
        Dim C As Integer = 0

        If BUSCAR_EXISTE("ALMACENES", "DESC_ALMACEN", Me.TXT_ALMACEN.Text.Trim) = False Then MsgBox("No existe el Almacen Origen", MsgBoxStyle.Information) : Exit Sub
        If Me.Group_ALM_DESTINO.Visible = True And BUSCAR_EXISTE("ALMACENES", "DESC_ALMACEN", Me.TXT_ALM_DESTINO.Text.Trim) = False Then MsgBox("No existe el Almacen Destino", MsgBoxStyle.Information) : Exit Sub

        If Me.TXT_TC.Text = "" Then MsgBox("Ingrese Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub
        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Ingrese Detalle del Documento", MsgBoxStyle.Information) : Exit Sub

        If Me.Group_ALM_DESTINO.Visible = True And Me.TXT_ALM_DESTINO.Text = "" Then MsgBox("Seleccione el Almacen Destino", MsgBoxStyle.Information) : Exit Sub
        If Me.Group_ALM_DESTINO.Visible = True And Me.TXT_ALM_DESTINO.Text = Me.TXT_ALMACEN.Text Then MsgBox("Almacen Origen no puede ser igual al Destino", MsgBoxStyle.Information) : Exit Sub

        ''VALIDAR DATOS LLENOS DEL DETALLE
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            If Val(Me.DBLISTAR.Item(F, 3)) = 0 Or Val(Me.DBLISTAR.Item(F, 4)) = 0 Then
                C = 1
                Exit For
            End If

            If Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1) = "S" Then
                ''VERIFICAR SOTCK EN SALIDA
                If CONFIG_VALIDAR_STOCK = True Then
                    Dim STOCK As Double = OBJART.VERIFICAR_STOCK(Me.DBLISTAR.Item(F, COL_COD), Me.TXT_ALMACEN.Tag)
                    ''If pb_editar = True Then STOCK = STOCK + Val(Me.DBLISTAR.Item(F, COL_CANT))
                    If STOCK < Val(Me.DBLISTAR.Item(F, COL_CANT)) Then
                        MsgBox("El Articulo :" & Me.DBLISTAR.Item(F, COL_DESC) & " , supera el stock actual", MsgBoxStyle.Critical) : Exit Sub
                    End If
                    ''
                End If
            End If
        Next
        If C = 1 Then MsgBox("Verifique datos del Detalle", MsgBoxStyle.Information) : Exit Sub
        
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJMOV.GRABAR(Me.TXT_COD.Text, Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1), Me.Combo_mov.SelectedValue, Me.DT_FECHA.Value, IIf(Me.OPT_SOLES.Checked = True, "S", "D"), Me.TXT_TC.Text, Me.TXT_COMENTARIO.Text.Trim, Me.TXT_TOTAL.Text, Me.TXT_ALMACEN.Tag, IIf(Me.TXT_ALM_DESTINO.Text = "", 0, Me.TXT_ALM_DESTINO.Tag), TIPO, Me.DBLISTAR)
        If intvalor = 2 Then MsgBox("Documento ya existe", MsgBoxStyle.Information) : Exit Sub
        If intvalor = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
        If intvalor = 0 Then
            MsgBox("Movimiento grabado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        'Me.txt_cod.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJMOV.ANULAR(Me.TXT_COD.Text, Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1))
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
        With Impresion
            .FORM = "Mant_FPago"
            .SW = 2
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub

    Private Sub DT_FECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FECHA.ValueChanged
        Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "C")
    End Sub

    Private Sub DBLISTAR_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.AfterEdit
        Me.DBLISTAR.Item(e.Row, 5) = Format(Val(Me.DBLISTAR.Item(e.Row, 3)) * Val(Me.DBLISTAR.Item(e.Row, 4)), "###,###,###.00")
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
        ''    .ACT = "Consultar_Articulos"
        ''    .STATINI = 0
        ''    .CARGAR_COMBO(arraybusqueda, 3, 2)
        ''    .TIPO = 0
        ''    .ShowDialog()
        ''    ''
        ''    If .GrecibeColumnaID <> "" Then
        ''        ASIGNAR_CAMPOS()
        ''        Me.DBLISTAR.AutoSizeCol(0)
        ''        Me.DBLISTAR.AutoSizeCol(1)
        ''        Me.DBLISTAR.AutoSizeCol(2)
        ''    End If
        ''    .Close()
        ''End With
        'Lineas que llaman al Formulario de Búsqueda
        ''If Me.TXT_ALMACEN.Text = "" Then MsgBox("Seleccione el Almacen", MsgBoxStyle.Information) : Exit Sub

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
            Me.DBLISTAR.AddItem(RS("CODIGO") & vbTab & RS("DESCRIPCION") & vbTab & RS("DESC_MEDIDA"))
        End While
        RS.Close()
        CN_NET.Close()
        DBLISTAR.AutoSizeCols(COL_DESCRIPCION_DEL_ITEM)
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

    Private Sub DBLISTAR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBLISTAR.KeyUp
        If e.KeyCode = Keys.Delete And Me.DBLISTAR.Row > 0 Then
            Me.DBLISTAR.RemoveItem(Me.DBLISTAR.Row)
            TOTALES()
        End If
    End Sub
    Sub TOTALES()
        Dim F As Integer
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOT = TOT + Me.DBLISTAR.Item(F, 5)
        Next
        
        Me.TXT_TOTAL.Text = Format(TOT, "###,###,###.00")
        
    End Sub

    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        Consultar_Compras.Tag = "Movimientos"
        Consultar_Compras.DBLISTAR.Tag = Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1)
        Consultar_Compras.ShowDialog()
    End Sub
    Public Sub LLENAR_DATOS(ByVal COD_MOV As String)

        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJMOV.BUSCAR(COD_MOV, Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1))
        Me.DBLISTAR.Rows.Count = 1
        While RS.Read
            Me.Combo_mov.Enabled = False
            Me.TXT_COD.Text = RS("COD_MOV")
            Me.Combo_mov.SelectedValue = RS("COD_TMOV")
            Me.DT_FECHA.Value = RS("FECHA_MOV")
            If RS("MON_MOV") = "S" Then Me.OPT_SOLES.Checked = True Else Me.OPT_DOLARES.Checked = True
            Me.TXT_TC.Text = RS("TC_MOV")
            Me.TXT_COMENTARIO.Text = RS("OBS_MOV")

            Me.TXT_ALMACEN.Tag = RS("COD_ALMACEN")
            Me.TXT_ALMACEN.Text = RS("DESC_ALMACEN")

            Me.TXT_ALM_DESTINO.Tag = RS("ALM_DESTINO")
            Me.TXT_ALM_DESTINO.Text = RS("DESC_ALMACEN_D")

            'While RS.Read
            Me.DBLISTAR.AddItem(RS("COD_ART") & vbTab & RS("DESC_ART") & vbTab & RS("DESC_MEDIDA") & vbTab & RS("CANT_DM") & vbTab & RS("PU_DM") & vbTab & Format(RS("CANT_DM") * RS("PU_DM"), "###,###,###.00"))
            'End While

        End While
        TOTALES()
        RS.Close()
        CN_NET.Close()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                Me.TXT_ALM_DESTINO.Tag = .GrecibeColumnaID
                Me.TXT_ALM_DESTINO.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With

    End Sub

    Private Sub Combo_mov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_mov.SelectedIndexChanged
        OBJTMOV = New ClsTMov
        If OBJTMOV.BUSCAR_TRANSF_TMOV(Me.Combo_mov.SelectedValue) = True Then
            Me.Group_ALM_DESTINO.Visible = True
        Else
            Me.Group_ALM_DESTINO.Visible = False
        End If
    End Sub
End Class