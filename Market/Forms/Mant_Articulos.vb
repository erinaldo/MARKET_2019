Public Class Mant_Articulos
    Dim OBJMEDIDAS As ClsMedida
    Dim OBJFAMILIAS As ClsFamilia
    Dim OBJGRUPOS As ClsGrupo
    Dim OBJART As ClsArticulo

    Dim COL_COMBO_COD As Integer = 0
    Dim COL_COMBO_DESC As Integer = 1
    Dim COL_COMBO_MEDIDA As Integer = 2
    Dim COL_COMBO_CANT As Integer = 3

    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String
    Private Sub TXT_PRECIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PRECIO.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))

    End Sub

    Private Sub TXT_PRECIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRECIO.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
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
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD.Text = .GrecibeColumnaID
                Me.TXT_DESC.Text = .GrecibeColumnaOpcional
                Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                ASIGNAR_CAMPOS()

                'Me.TXT_Clave.Text = .GrecibeColumnaOpcional3
            End If
            .Close()
        End With
    End Sub
    Sub ASIGNAR_CAMPOS()
        Dim RS As SqlDataReader  'New ADODB.Recordset
        RS = OBJART.LISTAR_ARTICULOS(Me.TXT_COD.Text)
        While RS.Read
            Me.TXT_MEDIDA.Tag = NULO(RS("COD_MEDIDA"), "S")
            Me.TXT_MEDIDA.Text = NULO(RS("DESC_MEDIDA"), "S")
            Me.TXT_FAMILIA.Tag = NULO(RS("COD_FAMILIA"), "S")
            Me.TXT_FAMILIA.Text = NULO(RS("DESC_FAMILIA"), "S")
            Me.TXT_GRUPO.Tag = NULO(RS("COD_GRUPO"), "S")
            Me.TXT_GRUPO.Text = NULO(RS("DESC_GRUPO"), "S")
            Me.CHK_COMBO.Checked = RS("COMBO")
            Me.TXT_COD_SUNAT.Text = RS("COD_SUNAT")
            Me.TXT_STOCK_MIN.Text = RS("STOCK_MIN")
        End While
        RS.Close()
        CN_NET.Close()
        ''REGISTRO DE PRECIOS
        OBJART.LISTAR_ART_PRECIOS(Me.C1_PRECIOS, Me.TXT_COD.Text)
        ''PROVEEDORES
        OBJART.LISTAR_ART_PROV(Me.C1_PROV, Me.TXT_COD.Text)
        ''BARRA
        OBJART.LISTAR_ART_BARRAS(Me.C1_BARRA, Me.TXT_COD.Text)
        ''COMBO
        If CHK_COMBO.Checked Then
            Me.TabPage5.Parent = TabControl1
        Else
            Me.TabPage5.Parent = Nothing
        End If
        OBJART.LISTAR_ART_COMBO(Me.C1_COMBO, Me.TXT_COD.Text)
    End Sub

    Private Sub Mant_Articulos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        OBJMEDIDAS = New ClsMedida
        OBJFAMILIAS = New ClsFamilia
        OBJGRUPOS = New ClsGrupo
        OBJART = New ClsArticulo
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.PictureBox1.Enabled = Iblnvalor

        ToolCancelar.Enabled = Not Iblnvalor
    End Sub
    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Me.TabPage5.Parent = Nothing
            Me.LblAnulado.Text = ""
            Me.TXT_COD.Text = GENERAR_CODIGO("ARTICULOS", "COD_ART", "0000000000000")
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.TXT_COD.Enabled = True
            ''
            ' Me.C1_PRECIOS.Clear(C1.Win.C1FlexGrid.ClearFlags.All)
            OBJART.LISTAR_ART_PRECIOS(Me.C1_PRECIOS, "0")

            'Me.C1_PRECIOS.Rows.Count = 1
            'Me.C1_PRECIOS.Cols.Count = 4
            ''
            'Me.C1_PROV.Clear(C1.Win.C1FlexGrid.ClearFlags.All)
            OBJART.LISTAR_ART_PROV(Me.C1_PROV, "")

            'Me.C1_PROV.Rows.Count = 1
            'Me.C1_PROV.Cols.Count = 2
            ''
            'Me.C1_BARRA.Clear(C1.Win.C1FlexGrid.ClearFlags.All)
            OBJART.LISTAR_ART_BARRAS(Me.C1_BARRA, "")

            OBJART.LISTAR_ART_COMBO(Me.C1_COMBO, "")

            'Me.C1_BARRA.Rows.Count = 1
            'Me.C1_BARRA.Cols.Count = 1

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_MEDIDA"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_MEDIDA"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_MEDIDA"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Medidas"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_MEDIDA.Tag = .GrecibeColumnaID
                Me.TXT_MEDIDA.Text = .GrecibeColumnaOpcional
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                'Me.TXT_Clave.Text = .GrecibeColumnaOpcional3
            End If
            .Close()
        End With
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_GRUPO"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_GRUPO"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_GRUPO"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Grupos"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_GRUPO.Tag = .GrecibeColumnaID
                Me.TXT_GRUPO.Text = .GrecibeColumnaOpcional
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                'Me.TXT_Clave.Text = .GrecibeColumnaOpcional3
            End If
            .Close()
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_FAMILIA"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_FAMILIA"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_USER"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Familias"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_FAMILIA.Tag = .GrecibeColumnaID
                Me.TXT_FAMILIA.Text = .GrecibeColumnaOpcional
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                'Me.TXT_Clave.Text = .GrecibeColumnaOpcional3
            End If
            .Close()
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_TPRECIO"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_TPRECIO"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_TPRECIO"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Tprecio"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_TPRECIO.Tag = .GrecibeColumnaID
                Me.TXT_TPRECIO.Text = .GrecibeColumnaOpcional
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                'Me.TXT_Clave.Text = .GrecibeColumnaOpcional3
            End If
            .Close()
        End With
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String

        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese Descripcion", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_COD.Text = "" Then MsgBox("Ingrese Codigo", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_MEDIDA.Text = "" Then MsgBox("Ingrese Medida", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_FAMILIA.Text = "" Then MsgBox("Ingrese Familia", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_GRUPO.Text = "" Then MsgBox("Ingrese Grupo", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_COD_SUNAT.Text = "" Then MsgBox("Ingrese el Codigo de la Sunat", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("ARTICULOS", "COD_ART", Me.TXT_COD.Text.Trim) = True Then
                MsgBox("Articulo ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''COMBO
        If Me.CHK_COMBO.Checked Then
            If Me.C1_COMBO.Rows.Count <= 1 Then
                MsgBox("Debe agregar Articulos al Combo", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJART.MANT_ARTICULOS(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_MEDIDA.Tag, Me.TXT_FAMILIA.Tag, Me.TXT_GRUPO.Tag, Me.CHK_COMBO.Checked, Me.TXT_COD_SUNAT.Text, Val(Me.TXT_STOCK_MIN.Text), Me.C1_COMBO, TIPO)
        If intvalor = 0 Then
            MsgBox("Articulo grabado con exito", MsgBoxStyle.Information)
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
        Me.TXT_COD.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJART.MANT_ARTICULOS(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_MEDIDA.Tag, Me.TXT_FAMILIA.Tag, Me.TXT_GRUPO.Tag, 0, Me.TXT_COD_SUNAT.Text, 0, C1_COMBO, intANULAR)
        If intvalor = 0 Then
            MsgBox("Articulo anulado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        'Me.TXT_COD.Enabled = True
    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click
        With Impresion
            .FORM = "Mant_Articulos"
            .SW = 2
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim F As Integer
            ''
            If Me.TXT_DESC.Text = "" Then MsgBox("Seleccione el Articulo", MsgBoxStyle.Information) : Exit Sub
            ''
            If Me.TXT_PRECIO.Text = "" Then MsgBox("Ingrese el Precio", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_TPRECIO.Text = "" Then MsgBox("Ingrese el Tipo de Precio", MsgBoxStyle.Information) : Exit Sub
            ''AVERIGUAR SI YA EXISTE
            For F = 1 To Me.C1_PRECIOS.Rows.Count - 1
                If Me.TXT_TPRECIO.Tag = Me.C1_PRECIOS.Item(F, 0) And Me.TXT_COD.Text = Me.C1_PRECIOS.Item(F, 1) And Me.C1_PRECIOS.Item(F, 4) = "" Then
                    MsgBox("Precio para este Articulo ya existe", MsgBoxStyle.Information) : Exit Sub
                End If
            Next
            'Me.C1_PRECIOS.AddItem(Me.TXT_TPRECIO.Tag & vbTab & Me.TXT_COD.Text & vbTab & Me.TXT_TPRECIO.Text & vbTab & Me.TXT_PRECIO.Text)
            'Me.C1_PRECIOS.Cols(0).Visible = False
            'Me.C1_PRECIOS.Cols(1).Visible = False
            'Me.C1_PRECIOS.Item(0, 2) = "Tipo de Precio"
            'Me.C1_PRECIOS.Item(0, 3) = "Precio"
            'Me.C1_PRECIOS.AutoSizeCols(2)
            'Me.C1_PRECIOS.AutoSizeCols(3)
            OBJART.GRABAR_ART_PRECIOS(Me.TXT_TPRECIO.Tag, Me.TXT_COD.Text, Me.TXT_PRECIO.Text)
            OBJART.LISTAR_ART_PRECIOS(Me.C1_PRECIOS, Me.TXT_COD.Text)

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_PRECIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_PRECIOS.Click

    End Sub

    Private Sub C1_PRECIOS_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1_PRECIOS.KeyUp
        If e.KeyCode = Keys.F3 Then
            'Call picturebox1_Click_1(PictureBox1, EventArgs.Empty)
            If MsgBox("Seguro de Anular este Precio??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If ANULAR_CAMPO("ART_PRECIO", "STAT_AP", "COD_ART", Me.C1_PRECIOS.Item(Me.C1_PRECIOS.Row, 1), "COD_TPRECIO", Me.C1_PRECIOS.Item(C1_PRECIOS.Row, 0), 2) = True Then
                MsgBox("Anulado con exito")
            End If
            OBJART.LISTAR_ART_PRECIOS(Me.C1_PRECIOS, Me.TXT_COD.Text)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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
                'Me.LblAnulado.Text = .GrecibeColumnaOpcional2
            End If
            .Close()
        End With
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim F As Integer
            ''
            If Me.TXT_DESC.Text = "" Then MsgBox("Seleccione el Articulo", MsgBoxStyle.Information) : Exit Sub

            If Me.TXT_PROV.Text = "" Then MsgBox("Ingrese el Proveedor", MsgBoxStyle.Information) : Exit Sub
            ''AVERIGUAR SI YA EXISTE
            For F = 1 To Me.C1_PROV.Rows.Count - 1
                If Me.TXT_PROV.Tag = Me.C1_PROV.Item(F, 0) Then
                    MsgBox("Proveedor para este Articulo ya existe", MsgBoxStyle.Information) : Exit Sub
                End If
            Next
            'Me.C1_PROV.AddItem(Me.TXT_PROV.Tag & vbTab & Me.TXT_PROV.Text)
            ''Me.C1_PRECIOS.Cols(0).Visible = False
            ''Me.C1_PRECIOS.Cols(1).Visible = False
            'Me.C1_PROV.Item(0, 0) = "Codigo"
            'Me.C1_PROV.Item(0, 1) = "Proveedor"
            'Me.C1_PROV.AutoSizeCols(0)
            'Me.C1_PROV.AutoSizeCols(1)

            OBJART.GRABAR_ART_PROVEEDOR(Me.TXT_PROV.Tag, Me.TXT_COD.Text)
            OBJART.LISTAR_ART_PROV(Me.C1_PROV, Me.TXT_COD.Text)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_PROV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_PROV.Click

    End Sub

    Private Sub C1_PROV_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1_PROV.KeyUp
        If e.KeyCode = Keys.F3 Then
            If MsgBox("Seguro de Anular este Proveedor??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If ANULAR_CAMPO("ART_PROV", "STAT_ARTPROV", "COD_PROVED", Me.C1_PROV.Item(Me.C1_PROV.Row, 0), "COD_ART", Me.TXT_COD.Text, 2) = True Then
                MsgBox("Anulado con exito")
            End If
            OBJART.LISTAR_ART_PROV(Me.C1_PROV, Me.TXT_COD.Text)
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Dim F As Integer
            ''
            If Me.TXT_DESC.Text = "" Then MsgBox("Seleccione el Articulo", MsgBoxStyle.Information) : Exit Sub

            If Me.TXT_BARRA.Text = "" Then MsgBox("Ingrese el Codigo de Barra", MsgBoxStyle.Information) : Exit Sub
            ''AVERIGUAR SI YA EXISTE
            For F = 1 To Me.C1_BARRA.Rows.Count - 1
                If Me.TXT_BARRA.Tag = Me.C1_BARRA.Item(F, 0) Then
                    MsgBox("Codigo de Barra para este Articulo ya existe", MsgBoxStyle.Information) : Exit Sub
                End If
            Next
            'Me.C1_BARRA.AddItem(Me.TXT_BARRA.Text)
            'Me.C1_PRECIOS.Cols(0).Visible = False
            'Me.C1_PRECIOS.Cols(1).Visible = False
            'Me.C1_PROV.Item(0, 0) = "Codigo"
            ''Me.C1_PROV.Item(0, 1) = "Proveedor"
            'Me.C1_PROV.AutoSizeCols(0)
            ''Me.C1_PROV.AutoSizeCols(1)
            OBJART.GRABAR_ART_BARRAS(Me.TXT_BARRA.Text, Me.TXT_COD.Text)
            OBJART.LISTAR_ART_BARRAS(Me.C1_BARRA, Me.TXT_COD.Text)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_BARRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_BARRA.Click

    End Sub

    Private Sub C1_BARRA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1_BARRA.KeyUp
        If e.KeyCode = Keys.F3 Then
            If MsgBox("Seguro de Anular este Codigo de Barra??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If ANULAR_CAMPO("ART_BARRAS", "STAT_BARRAS", "COD_BARRAS", Me.C1_BARRA.Item(Me.C1_BARRA.Row, 0), "COD_ART", Me.TXT_COD.Text, 2) = True Then
                MsgBox("Anulado con exito")
            End If
            OBJART.LISTAR_ART_BARRAS(Me.C1_BARRA, Me.TXT_COD.Text)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_COMBO.CheckedChanged
        If CHK_COMBO.Checked Then
            Me.TabPage5.Parent = TabControl1
        Else
            Me.TabPage5.Parent = Nothing
        End If
    End Sub

    Private Sub C1_COMBO_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1_COMBO.BeforeEdit
        If e.Col <> COL_COMBO_CANT Then e.Cancel = True
    End Sub

    Private Sub C1_COMBO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_COMBO.Click

    End Sub

    Private Sub C1_COMBO_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1_COMBO.DoubleClick
        'Lineas que llaman al Formulario de Búsqueda
        Dim FILA As Integer
        If Me.TXT_DESC.Text = "" Then MsgBox("Seleccione el Articulo", MsgBoxStyle.Information) : Exit Sub
        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_ART"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "Stock_ART"
        arraybusqueda(3, 2) = "Stock "
        arraybusqueda(3, 3) = 1500



        ''
        With BusquedaMaestra
            .ACT = "Mant_Articulos_COMBO"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .TIPO = 0
            '.TxtDatoBuscado.Text = Me.TXT_PROV.Tag


            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                If Me.TXT_COD.Text = .GrecibeColumnaID Then
                    MsgBox("Este articulo no puede ser parte del mismo Combo", MsgBoxStyle.Information)
                    Exit Sub
                End If
                For FILA = 1 To Me.C1_COMBO.Rows.Count - 1
                    If .GrecibeColumnaID = Me.C1_COMBO.Item(FILA, COL_COMBO_COD) Then
                        MsgBox("Este Articulo ya esta Ingresado", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Next
                ASIGNAR_CAMPOS_COMBO()

            End If
            .Close()
        End With
    End Sub
    Sub ASIGNAR_CAMPOS_COMBO()
        Dim RS As SqlDataReader
        RS = OBJART.LISTAR_ARTICULOS(BusquedaMaestra.GrecibeColumnaID)
        While RS.Read
            Me.C1_COMBO.AddItem(RS("CODIGO") & vbTab & RS("DESCRIPCION") & vbTab & RS("DESC_MEDIDA") & vbTab & 1)
        End While
        RS.Close()
        CN_NET.Close()
        C1_COMBO.AutoSizeCols()
    End Sub

    Private Sub C1_COMBO_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1_COMBO.KeyUp
        If e.KeyCode = Keys.Delete And Me.C1_COMBO.Row > 0 Then
            Me.C1_COMBO.RemoveItem(Me.C1_COMBO.Row)
        End If
    End Sub
End Class