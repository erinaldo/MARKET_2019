Public Class Mant_PtoVta
    Dim OBJPTOVTA As ClsPtoVta
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String
    Private Sub Mant_PtoVta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        OBJPTOVTA = New ClsPtoVta
        LISTAR_TIPO_DOC(Me.Combo_DOC, "V")
    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.TXT_COD.Enabled = True
            Me.DBLISTAR.Rows.Count = 1
            FORMATO()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub FORMATO()
        With Me.DBLISTAR
            .Item(0, 0) = "Codigo"
            .Item(0, 1) = "Descripcion"
            .Item(0, 2) = "Correlativo"
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
                Me.TXT_COD.Text = .GrecibeColumnaID
                
                ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
    Sub ASIGNAR_DATOS()
        Dim RS As SqlDataReader  'New ADODB.Recordset
        RS = OBJPTOVTA.BUSCAR(Me.TXT_COD.Text)
        Me.DBLISTAR.Rows.Count = 1
        While RS.Read
            Me.CHK_EDITAR.Checked = RS("APTOEDIT") 'IIf(RS.Fields("APTOEDIT").Value = 1, True, False)
            Me.DT_FECHA.Value = RS("APTOFEPO")
            Me.TXT_TERMINAL.Text = NULO(RS("APTOTERM"), "S")
            Me.CHK_ACTIVO.Checked = IIf(RS("ESTADO") = "", True, False)
            Me.TXT_REG.Text = NULO(RS("APTOREG"), "S")
            Me.TXT_ALMACEN.Tag = RS("COD_ALMACEN")
            Me.TXT_ALMACEN.Text = RS("DESC_ALMACEN")

            'Do While Not RS.EOF
            If Not RS("COD_DOC") Is DBNull.Value Then
                Me.DBLISTAR.AddItem(RS("COD_DOC") & vbTab & RS("DESC_DOC") & vbTab & RS("APTONDOC") & vbTab & NULO(RS("APTOPORTIMP"), "S") & vbTab & RS("NRO"))
            End If
            'RS.MoveNext()
            'Loop
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        If Me.TXT_ALMACEN.Text = "" Then MsgBox("Ingrese el Almacen", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_TERMINAL.Text = "" Then MsgBox("Ingrese Terminal", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_COD.Text = "" Then MsgBox("Ingrese Codigo", MsgBoxStyle.Information) : Exit Sub
        'If Me.TXT_REG.Text = "" Then MsgBox("Ingrese Maq. Reg.", MsgBoxStyle.Information) : Exit Sub
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJPTOVTA.MANT_PTOVTA(Me.TXT_COD.Text.Trim, IIf(Me.CHK_EDITAR.Checked = True, 1, 0), Me.DT_FECHA.Value,
                Me.TXT_TERMINAL.Text.Trim, IIf(Me.CHK_ACTIVO.Checked = True, 0, 1), Me.TXT_ALMACEN.Tag, TIPO, Me.DBLISTAR, Me.TXT_REG.Text.Trim)
        If intvalor = 2 Then MsgBox("Codigo ya existe", MsgBoxStyle.Information) : Exit Sub
        If intvalor = 0 Then
            MsgBox("Configuracion grabado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim F As Integer
            If Me.Combo_DOC.Text = "" Then MsgBox("Seleccione Tipo de Documento", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_CORR.Text) = 0 Then MsgBox("Ingrese Correlativo", MsgBoxStyle.Information) : Exit Sub
            If (Me.TXT_PUERTO.Text) = "" Then MsgBox("Ingrese Puerto de Impresion", MsgBoxStyle.Information) : Exit Sub
            ''BUSCAR SI DOC YA SE INGRESO
            For F = 1 To Me.DBLISTAR.Rows.Count - 1
                If Me.Combo_DOC.SelectedValue = Me.DBLISTAR.Item(F, 0) Then MsgBox("Documento ya Ingresado", MsgBoxStyle.Information) : Exit Sub
            Next
            ''
            Me.DBLISTAR.AddItem(Me.Combo_DOC.SelectedValue & vbTab & Me.Combo_DOC.Text & vbTab & Me.TXT_CORR.Text & vbTab & Me.TXT_PUERTO.Text & vbTab & Val(Me.TXT_NRO_PAPEL.Text))

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        Me.TXT_COD.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
      
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.DBLISTAR.RemoveItem(Me.DBLISTAR.Row)
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