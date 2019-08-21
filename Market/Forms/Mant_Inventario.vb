Public Class Mant_Inventario
    Dim OBJINV As ClsInventario
    Dim OBJART As ClsArticulo
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean

    Dim COL_ITEM As Integer = 0
    Dim COL_COD As Integer = 1
    Dim COL_DESC As Integer = 2
    Dim COL_COSTO As Integer = 3
    Dim COL_STOCK As Integer = 4
    Dim COL_CANT As Integer = 5
    Dim COL_DIF As Integer = 6

    Private Sub Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJINV = New ClsInventario
        OBJART = New ClsArticulo
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
    End Sub
    Sub CARGAR_GRID()
        Dim SQL As String = "SELECT TEMP_INVENTARIO.ITEM as Item, TEMP_INVENTARIO.COD_ART as Codigo,
        ARTICULOS.DESC_ART as Articulo, TEMP_INVENTARIO.COSTO_ART as Costo, TEMP_INVENTARIO.STOCK_ART as Stock, 
        TEMP_INVENTARIO.CANT_ART as Cant,ISNULL(TEMP_INVENTARIO.STOCK_ART,0)-ISNULL(TEMP_INVENTARIO.CANT_ART,0) AS Dif
        FROM TEMP_INVENTARIO INNER JOIN ARTICULOS ON TEMP_INVENTARIO.COD_ART = ARTICULOS.COD_ART
        WHERE  COD_USER='" & GUSERID & "' ORDER BY TEMP_INVENTARIO.ITEM"
        LLENAR_GRID(DBLISTAR, SQL, CAD_CON)
        DISEÑO_LETRA(DBLISTAR, 1, DBLISTAR.Rows.Count - 1, COL_CANT, COL_CANT)
    End Sub
    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Button1.Enabled = True
            Me.TXT_ESTADO.Text = ""
            OBJINV.ELIMINAR_TEMP_INVENTARIO()
            'Me.TXT_COD.Text = Microsoft.VisualBasic.Right("000000" + (OBJMOV.CODIGO(Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1))), 6)
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.DT_FECHA.Value = Date.Now
            CARGAR_GRID()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.picturebox1.Enabled = Iblnvalor
        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        Dim F As Integer
        Dim C As Integer = 0

        If Me.TXT_ALMACEN.Text = "" Then MsgBox("Seleccione el Almacen", MsgBoxStyle.Information) : Exit Sub
        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Ingrese Detalle del Documento", MsgBoxStyle.Information) : Exit Sub

        ''VALIDAR DATOS LLENOS DEL DETALLE
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            If Val(Me.DBLISTAR.Item(F, COL_CANT)) = 0 Then
                C = 1
                Exit For
            End If
        Next
        If C = 1 Then MsgBox("Verifique datos del Detalle", MsgBoxStyle.Information) : Exit Sub

        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        With OBJINV
            .Codigo = Val(Me.TXT_COD.Text)
            .Fecha = DT_FECHA.Value
            .Almacen = Me.TXT_ALMACEN.Tag
            .Observacion = Me.TXT_COMENTARIO.Text.Trim
            intvalor = .Mantenimiento(TIPO)
        End With

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
        With OBJINV
            .Codigo = Val(Me.TXT_COD.Text)
            intvalor = OBJINV.Mantenimiento(intANULAR)
        End With
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

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With Impresion
            .FORM = "Mant_FPago"
            .SW = 2
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub

    Private Sub DBLISTAR_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.AfterEdit
        OBJINV.Mantenimiento_TEMP(DBLISTAR.Item(DBLISTAR.Row, COL_COD), DBLISTAR.Item(DBLISTAR.Row, COL_CANT), intMODIFICAR)
        CARGAR_GRID()
    End Sub

    Private Sub DBLISTAR_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.BeforeEdit
        If e.Col <> COL_CANT Then e.Cancel = True
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
        If Me.TXT_ALMACEN.Text = "" Then MsgBox("Seleccione el Almacen", MsgBoxStyle.Information) : Exit Sub
        Button1.Enabled = False
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
        Dim SW As Integer
        With OBJINV
            .Almacen = Me.TXT_ALMACEN.Tag
            .Fecha = DT_FECHA.Value
            SW = .Mantenimiento_TEMP(COD_ART, 0, intNUEVO)
            If SW = 1 Then MsgBox("Articulo ya esta ingresado", MsgBoxStyle.Information)
            CARGAR_GRID()
        End With
        ''Dim RS As SqlDataReader
        ''RS = OBJART.LISTAR_ARTICULOS(COD_ART)
        ''While RS.Read
        ''    Me.DBLISTAR.AddItem(RS("CODIGO") & vbTab & RS("DESCRIPCION") & vbTab & RS("DESC_MEDIDA"))
        ''End While
        ''RS.Close()
        ''CN_NET.Close()
        ''DBLISTAR.AutoSizeCols(COL_DESCRIPCION_DEL_ITEM)

    End Sub


    Private Sub DBLISTAR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBLISTAR.KeyUp
        If e.KeyCode = Keys.Delete And Me.DBLISTAR.Row > 0 Then
            OBJINV.Mantenimiento_TEMP(DBLISTAR.Item(DBLISTAR.Row, COL_COD), 0, intANULAR)
            CARGAR_GRID()
        End If
    End Sub
    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        Consultar_Compras.Tag = "Inventario"
        Consultar_Compras.ShowDialog()
    End Sub
    Public Sub LLENAR_DATOS(ByVal COD_INV As Double)

        With OBJINV
            .Codigo = COD_INV
            TXT_COD.Text = COD_INV
            .BUSCAR()
            DT_FECHA.Value = .Fecha
            TXT_ALMACEN.Tag = .Almacen
            TXT_ALMACEN.Text = BUSCAR_CAMPO("ALMACENES", "DESC_ALMACEN", "COD_ALMACEN", .Almacen, CN_NET)
            If .Estado <> 0 Then
                MsgBox("Inventario se encuentra anulado, solo se podra consultar", MsgBoxStyle.Information)
                ToolGrabar.Enabled = False
                ToolAnular.Enabled = False
                ToolModificar.Enabled = False
            End If
        End With
        CARGAR_GRID()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.SaveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
            Me.SaveFileDialog1.FileName = ""
            Me.SaveFileDialog1.ShowDialog()
            'dlg.ShowOpen()

            If Len(Me.SaveFileDialog1.FileName) = 0 Then Exit Sub

            Me.DBLISTAR.SaveExcel(Me.SaveFileDialog1.FileName, "Listado", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class