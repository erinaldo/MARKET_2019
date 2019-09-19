Imports C1.Win.C1FlexGrid

Public Class Ventas_Contingencia
    Dim OBJMOV As ClsMovimiento
    Dim OBJCONFIG As ClsConfig
    Dim OBJCONTING As ClsVtaContingecia
    Dim OBJUSU As ClsUsu

    Dim INTVALOR As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Dim MlonCorrelativo As Long

    Public ID_CONTINGENCIA As Double

    Dim COL_ITEM As Integer = 0
    Dim COL_COD_PROD As Integer = 1
    Dim COL_DESC_PROD As Integer = 2
    Dim COL_UNIDAD As Integer = 3
    Dim COL_CANT As Integer = 4
    Dim COL_PU As Integer = 5
    Dim COL_TOTAL As Integer = 6
    Dim COL_COD_TANQUE As Integer = 7
    Dim COL_DESC_TANQUE As Integer = 8
    Private Sub Ventas_Contingencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OBJMOV = New ClsMovimiento
        OBJCONFIG = New ClsConfig
        OBJCONTING = New ClsVtaContingecia
        OBJUSU = New ClsUsu

        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(False)
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        ' Me.picturebox1.Enabled = Iblnvalor
        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub ToolNuevo_Click(sender As Object, e As EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            ID_CONTINGENCIA = 0

            CARGAR_CONFIG()
            Dim TIPOS As String
            TIPOS = CStr(COD_FACT) + "," + CStr(COD_BOL)
            'LLENAR_COMBO(Combo_TIPODOC, "EXEC usp_TDocuSelProc  2,0,'" & TIPOS & "'", "ADOCDESC", "ADOCCODI", CAD_CON)
            LISTAR_TIPO_DOC(Me.Combo_TIPODOC, "V")
            MlonCorrelativo = OBJUSU.ObtenerCorrelativo(GUSERID)

            OBJMOV.LISTAR_TMP_DETALLE(0, DBLISTAR, CAD_CON)
            DISEÑO_GRID()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolCancelar_Click(sender As Object, e As EventArgs) Handles ToolCancelar.Click
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
    End Sub

    Private Sub ToolModificar_Click(sender As Object, e As EventArgs) Handles ToolModificar.Click
        If BUSCAR_PERMISO("9203") = False Then MsgBox("No tiene permiso para usar esta opcion", MsgBoxStyle.Information) : Exit Sub
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
    End Sub

    Private Sub ToolAnular_Click(sender As Object, e As EventArgs) Handles ToolAnular.Click
        If BUSCAR_PERMISO("9204") = False Then MsgBox("No tiene permiso para usar esta opcion", MsgBoxStyle.Information) : Exit Sub
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        ' INTVALOR = OBJFAMILIA.Mantenimiento(intANULAR, OBJCONN.Conexion(CAD_CON))
        OBJCONTING.Usuario = GUSERID
        INTVALOR = OBJCONTING.GRABAR(MlonCorrelativo, intANULAR, CN_NET)
        If INTVALOR = 0 Then
            MsgBox("Documento anulado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click
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
                Me.TXT_CLIENTE.Tag = .GrecibeColumnaID
                Me.TXT_CLIENTE.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With

    End Sub

    Private Sub ToolGrabar_Click(sender As Object, e As EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        Dim C As Integer
        Dim F As Integer
        ''
        If Me.TXT_SERIE.Text = "" Then MsgBox("Ingrese la Serie", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_NUMERO.Text = "" Then MsgBox("Ingrese el Numero", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_MOTIVO.Text = "" Then MsgBox("Seleccione la Contingencia", MsgBoxStyle.Information) : Exit Sub
        If COD_FACT = Me.Combo_TIPODOC.SelectedValue Then
            If Me.TXT_CLIENTE.Text.Trim = "" Then
                MsgBox("Ingrese el Cliente", MsgBoxStyle.Information) : Exit Sub
            End If
        End If

        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Ingrese Detalle del Documento", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR DATOS LLENOS DEL DETALLE
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            If Val(Me.DBLISTAR.Item(F, COL_CANT)) = 0 Then
                C = 1
                Exit For
            End If
            If Val(Me.DBLISTAR.Item(F, COL_PU)) = 0 Then
                C = 1
                Exit For
            End If
        Next
        If C = 1 Then MsgBox("Verifique datos del Detalle", MsgBoxStyle.Information) : Exit Sub

        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            'If OBJFUNCIONES.BUSCAR_EXISTE("FAMILIAS", "DESC_FAMILIA", Me.TXT_DESCRIPCION.Text.Trim, OBJCONN.Conexion(CAD_CON)) = True Then
            'MsgBox("Familia ya existe", MsgBoxStyle.Information) : Exit Sub
            ' End If
        End If
        ''GRABANDO
        With OBJCONTING
            .Id = ID_CONTINGENCIA
            .TipoDoc = Me.Combo_TIPODOC.SelectedValue
            .Serie = Me.TXT_SERIE.Text.Trim
            .Numero = Me.TXT_NUMERO.Text.Trim
            .Fecha = DT_FECHA.Value
            .ClieCod = Me.TXT_CLIENTE.Tag
            .PorcIgv = IGV
            .SubTotal = Me.TXT_SUBTOTAL.Text
            .Igv = Me.TXT_IGV.Text
            .Total = Me.TXT_TOTAL.Text
            .Usuario = GUSERID
            .ContingenciaCod = Me.TXT_MOTIVO.Tag
        End With
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        INTVALOR = OBJCONTING.GRABAR(MlonCorrelativo, TIPO, CN_NET)
        If INTVALOR = 2 Then MsgBox("Numero de Documento ya existe", MsgBoxStyle.Information) : Exit Sub
        If INTVALOR = 0 Then
            MsgBox("Venta grabada con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TXT_SERIE_GotFocus(sender As Object, e As EventArgs) Handles TXT_SERIE.GotFocus
        COLOR_FOCO(TXT_SERIE, "F")
    End Sub

    Private Sub TXT_NUMERO_GotFocus(sender As Object, e As EventArgs) Handles TXT_NUMERO.GotFocus
        COLOR_FOCO(TXT_NUMERO, "F")
    End Sub

    Private Sub DateTimePicker1_GotFocus(sender As Object, e As EventArgs) Handles DT_FECHA.GotFocus
        COLOR_FOCO(DT_FECHA, "F")
    End Sub

    Private Sub TXT_SERIE_LostFocus(sender As Object, e As EventArgs) Handles TXT_SERIE.LostFocus
        TXT_SERIE.Text = Strings.Right("0000" + TXT_SERIE.Text, 4)
        COLOR_FOCO(TXT_SERIE, "Q")
    End Sub

    Private Sub TXT_NUMERO_LostFocus(sender As Object, e As EventArgs) Handles TXT_NUMERO.LostFocus
        TXT_NUMERO.Text = Strings.Right("00000000" + TXT_NUMERO.Text, 8)
        COLOR_FOCO(TXT_NUMERO, "Q")
    End Sub

    Private Sub DT_FECHA_LostFocus(sender As Object, e As EventArgs) Handles DT_FECHA.LostFocus
        COLOR_FOCO(DT_FECHA, "Q")
    End Sub

    Private Sub C1_DETALLE_DoubleClick(sender As Object, e As EventArgs) Handles DBLISTAR.DoubleClick
        'Lineas que llaman al Formulario de Búsqueda
        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_ART"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_ART"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_Articulos"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                AGREGAR_TEMP(.GrecibeColumnaID)
            End If
            .Close()
        End With

    End Sub

    Public Sub AGREGAR_TEMP(ByVal COD_PROD As String)
        Dim OBJTMP As New ClsTemp
        Dim I As Integer
        With OBJTMP
            .Correlativo = MlonCorrelativo
            .CodArt = COD_PROD
        End With
        I = OBJTMP.AGREGAR_TMP_COMPRAS_PU(CN_NET)
        If I = 1 Then MsgBox("Error al agregar el Detalle", MsgBoxStyle.Information) : Exit Sub
        If I = 2 Then MsgBox("Producto ya se encuentra ingresado", MsgBoxStyle.Information) : Exit Sub
        OBJMOV.LISTAR_TMP_DETALLE(MlonCorrelativo, DBLISTAR, CAD_CON)
        DISEÑO_GRID()


    End Sub
    Sub DISEÑO_GRID()
        DBLISTAR.Cols(COL_CANT).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_PU).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_TOTAL).Format = "###,###,###.0000"

        DBLISTAR.AutoSizeCols()



        DISEÑO_SERIE(Me.DBLISTAR, 1, Me.DBLISTAR.Rows.Count - 1, COL_CANT, COL_CANT)

        TOTALES()
    End Sub

    Sub TOTALES()
        Dim F As Integer
        Dim TOTAL As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOTAL = TOTAL + Val(NULO(Me.DBLISTAR.Item(F, COL_TOTAL), "N"))
        Next
        Me.TXT_TOTAL.Text = FORMAT_DECIMALES(TOTAL, 2)
        Me.TXT_SUBTOTAL.Text = FORMAT_DECIMALES(TOTAL / (1 + (IGV / 100)), 2)
        Me.TXT_IGV.Text = FORMAT_DECIMALES(TOTAL - (TOTAL / (1 + (IGV / 100))), 2)
    End Sub

    Private Sub ToolSalir_Click(sender As Object, e As EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub


    Private Sub DBLISTAR_AfterEdit(sender As Object, e As RowColEventArgs) Handles DBLISTAR.AfterEdit
        Dim FILA As Integer = DBLISTAR.Row 'e.Row
        Dim COLUMNA As Integer = DBLISTAR.Col 'e.Col
        ACTUALIZAR(e.Row)
        Me.DBLISTAR.Col = COLUMNA
        Me.DBLISTAR.Row = FILA
    End Sub
    Sub ACTUALIZAR(FIL As Integer)
        Dim OBJTMP As New ClsTemp
        With OBJTMP
            .Correlativo = MlonCorrelativo
            .Fila = NULO(DBLISTAR.Item(FIL, COL_ITEM), "N")
            .Precio = DBLISTAR.Item(FIL, COL_PU)
            .Cantidad = DBLISTAR.Item(FIL, COL_CANT)
            .ACTUALIZAR_TMP_DETALLE_COMPRA(CN_NET)
            OBJMOV.LISTAR_TMP_DETALLE(MlonCorrelativo, DBLISTAR, CAD_CON)
            DISEÑO_GRID()
        End With


    End Sub

    Private Sub DBLISTAR_KeyUp(sender As Object, e As KeyEventArgs) Handles DBLISTAR.KeyUp
        Dim OBJTMP As New ClsTemp
        If Me.DBLISTAR.Row <= 0 Then Exit Sub
        If e.KeyCode = Keys.Delete And Me.DBLISTAR.Row > 0 Then
            If MsgBox("Seguro de Eliminar este Producto??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            With OBJTMP
                .Correlativo = MlonCorrelativo
                .Fila = Me.DBLISTAR.Item(DBLISTAR.Row, COL_ITEM)
                .Eliminar(CN_NET, Me.DBLISTAR.Item(DBLISTAR.Row, COL_ITEM))
            End With
            OBJMOV.LISTAR_TMP_DETALLE(MlonCorrelativo, DBLISTAR, CAD_CON)
            DISEÑO_GRID()

        End If
    End Sub
    Public Sub LLENAR_DATOS(ID As Double)
        Dim OBJTMP As New ClsTemp
        'MlonCorrelativo = OBJFUNC.ObtenerCorrelativoUsuario(GUSERID, OBJCONN.Conexion(CAD_CON))
        MlonCorrelativo = OBJUSU.ObtenerCorrelativo(GUSERID)
        Me.ToolModificar.Enabled = True
        Me.ToolAnular.Enabled = True
        Me.ToolGrabar.Enabled = False
        ID_CONTINGENCIA = ID
        With OBJCONTING
            .Id = ID
            .BUSCAR(CN_NET)
            If .Estado = True Then
                MsgBox("Documento se encuentra Anulado, solo se podra consultar", MsgBoxStyle.Information)
                Me.ToolModificar.Enabled = False
                Me.ToolAnular.Enabled = False
                Me.ToolGrabar.Enabled = False
            End If

            Me.Combo_TIPODOC.SelectedValue = .TipoDoc
            Me.TXT_SERIE.Text = .Serie
            Me.TXT_NUMERO.Text = .Numero
            Me.DT_FECHA.Value = .Fecha
            Me.TXT_CLIENTE.Tag = .ClieCod
            TXT_CLIENTE.Text = .ClieDesc

            Me.TXT_MOTIVO.Tag = .ContingenciaCod
            Me.TXT_MOTIVO.Text = .ContingenciaDesc

            OBJTMP.Correlativo = MlonCorrelativo
            If OBJTMP.CARGAR_TMP_DETALLE_CONTINGENCIA(MlonCorrelativo, .Id, CN_NET) = 1 Then MsgBox("Error al cargar", MsgBoxStyle.Information) : Exit Sub
            OBJMOV.LISTAR_TMP_DETALLE(MlonCorrelativo, DBLISTAR, CAD_CON)
            DISEÑO_GRID()
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arraybusqueda(2, 3) As Object
        arraybusqueda(1, 1) = "COD_MCONTINGENCIA"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "DESC_MCONTINGENCIA"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000

        With BusquedaMaestra
            .ACT = "MContingencia"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 2, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_MOTIVO.Tag = .GrecibeColumnaID
                TXT_MOTIVO.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub Combo_TIPODOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_TIPODOC.SelectedIndexChanged

    End Sub

    Private Sub DBLISTAR_Click(sender As Object, e As EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_BeforeEdit(sender As Object, e As RowColEventArgs) Handles DBLISTAR.BeforeEdit
        If e.Row = 0 Then Exit Sub
        If e.Col <> COL_CANT Then e.Cancel = True
    End Sub
End Class