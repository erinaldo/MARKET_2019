Public Class Mant_Familias

    Dim OBJFAM As ClsFamilia
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String

    Private Sub Mant_Familias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call picturebox1_Click_1(picturebox1, EventArgs.Empty)
        End If
    End Sub


    Private Sub Mant_FAMILIAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        OBJFAM = New ClsFamilia
    End Sub

    Private Sub TXT_DESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'Me.TXT_Clave.Focus()
        End If
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String

        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese Descripcion", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_COD.Text = "" Then MsgBox("Ingrese Familia", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_TIPO.Text = "" Then MsgBox("Ingrese el Tipo", MsgBoxStyle.Information) : Exit Sub

        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("FAMILIA", "COD_FAMILIA", Me.TXT_COD.Text.Trim) = True Then
                MsgBox("Familia ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJFAM.MANT_FAMILIAS(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_TIPO.Text.Trim, TIPO)
        If intvalor = 0 Then
            MsgBox("Familia grabado con exito", MsgBoxStyle.Information)
            Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.PictureBox1.Enabled = Iblnvalor
        'If Iblnvalor = True Then
        '    Me.PictureBox1.BorderStyle = BorderStyle.None
        'Else
        '    Me.PictureBox1.BorderStyle = BorderStyle.Fixed3D
        'End If
        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        'Me.TXT_COD.Enabled = True
    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        Me.TXT_COD.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJFAM.MANT_FAMILIAS(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, "", intANULAR)
        If intvalor = 0 Then
            MsgBox("Familia anulado con exito", MsgBoxStyle.Information)
            Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click

        With Impresion
            .FORM = "Mant_Familias"
            .SW = 2
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub

    Private Sub ToolSNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Me.LblAnulado.Text = ""
            Me.TXT_COD.Text = GENERAR_CODIGO("FAMILIA", "COD_FAMILIA", "000")
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.TXT_COD.Enabled = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub txt_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_COD.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.TXT_DESC.Focus()
        End If
    End Sub

    Private Sub TXT_DESC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DESC.TextChanged

    End Sub

   
    Private Sub picturebox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "COD_FAMILIA"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_FAMILIA"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "TIPO_FAMILIA"
        arraybusqueda(3, 2) = "Tipo "
        arraybusqueda(3, 3) = 3000
        arraybusqueda(4, 1) = "STAT_USER"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Familias"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD.Text = .GrecibeColumnaID
                Me.TXT_DESC.Text = .GrecibeColumnaOpcional
                Me.TXT_TIPO.Text = .GrecibeColumnaOpcional2
                Me.LblAnulado.Text = .GrecibeColumnaOpcional3
                'Me.TXT_Clave.Text = .GrecibeColumnaOpcional3
            End If
            .Close()
        End With

    End Sub
End Class