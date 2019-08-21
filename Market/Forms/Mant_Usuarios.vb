Public Class Mant_Usuarios
    Dim OBJUSU As ClsUsu
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String

    Private Sub Mant_Usuarios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call picturebox1_Click_1(picturebox1, EventArgs.Empty)
        End If
    End Sub
    

    Private Sub Mant_Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        OBJUSU = New ClsUsu
    End Sub

    Private Sub TXT_DESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.TXT_Clave.Focus()
        End If
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String

        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese Descripcion", MsgBoxStyle.Information) : Exit Sub
        If Me.txt_user.Text = "" Then MsgBox("Ingrese Usuario", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_Clave.Text = "" Then MsgBox("Ingrese Clave", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("USUARIOS", "COD_USER", Me.txt_user.Text.Trim) = True Then
                MsgBox("Usuario ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJUSU.MANT_USUARIOS(Me.txt_user.Text.Trim, Me.TXT_DESC.Text.Trim, duplicacarnoval1(Encrip(Me.TXT_Clave.Text.Trim)), duplicacarnoval1(Encrip(Me.TXT_CLAVE_NUM.Text.Trim)), TIPO)
        If intvalor = 0 Then
            MsgBox("Usuario grabado con exito", MsgBoxStyle.Information)
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
        
        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        Me.txt_user.Enabled = True
    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        Me.txt_user.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJUSU.MANT_USUARIOS(Me.txt_user.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_Clave.Text.Trim, "", intANULAR)
        If intvalor = 0 Then
            MsgBox("Usuario anulado con exito", MsgBoxStyle.Information)
            Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click

        With Impresion
            .FORM = "Mant_Usuarios"
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
            'Me.TXT_COD.Text = BUSCARCOD("SERVICIOS", "COD_SERVICIO", "00", "")
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.txt_user.Enabled = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub txt_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_user.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.TXT_DESC.Focus()
        End If
    End Sub

    Private Sub picturebox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(5, 3) As Object
        arraybusqueda(1, 1) = "COD_USER"
        arraybusqueda(1, 2) = "Usuario"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_USER"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_USER"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "PSW_USER"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 0
        arraybusqueda(5, 1) = "AUSUNUM"
        arraybusqueda(5, 2) = "Num "
        arraybusqueda(5, 3) = 0

        ''
        With BusquedaMaestra
            .ACT = "Mant_Usuarios"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                Me.txt_user.Text = .GrecibeColumnaID
                Me.TXT_DESC.Text = .GrecibeColumnaOpcional
                Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                Me.TXT_Clave.Text = GVDATO(duplicacarnoval1(Encrip(.GrecibeColumnaOpcional3)))
                Me.TXT_CLAVE_NUM.Text = GVDATO(duplicacarnoval1(Encrip(.GrecibeColumnaOpcional4)))
            End If
            .Close()
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Acceso_Numerico
            .TORIG = "MANT"
            .TXT_CLAVE.Clear()
            .ShowDialog()
            Me.TXT_CLAVE_NUM.Text = .TXT_CLAVE.Text
        End With
    End Sub
End Class