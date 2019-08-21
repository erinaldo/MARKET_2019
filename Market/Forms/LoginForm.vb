
Public Class LoginForm
    Dim dadapter As SqlDataAdapter
    Dim RS As ADODB.Recordset
    Dim objUsuario As ClsUsu

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If VALIDA_USUARIO() = True Then
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try


    End Sub
    Function VALIDA_USUARIO() As Boolean
        'VALIDA USUARIO
        VALIDA_USUARIO = False

        'RS = New ADODB.Recordset

        objUsuario = New ClsUsu
        'RS = objUsuario.GRsValidarUsuario(GVDATO(Me.UsernameTextBox.Text), GVDATO(duplicacarnoval1(Encrip(Me.PasswordTextBox.Text))), Cnscb.conexion)
        objUsuario.COD_USER = GVDATO(Me.UsernameTextBox.Text)
        objUsuario.PSW_USER = GVDATO(duplicacarnoval1(Encrip(Me.PasswordTextBox.Text)))
        objUsuario.GRsValidarUsuario()

        'If RS.Fields("Flag").Value = 1 Then
        If objUsuario.GRsValidarUsuario = 1 Then
            MsgBox("Usuario no existe", vbExclamation, "Acceso")
            Me.UsernameTextBox.Focus()
            Exit Function
        End If

        If objUsuario.GRsValidarUsuario = 2 Then
            MsgBox("Clave incorrecta", vbExclamation, "Acceso")
            Me.PasswordTextBox.Focus()
            Exit Function
        End If

        If objUsuario.GRsValidarUsuario = 0 Then
            GUSERID = objUsuario.COD_USER 'RS.Fields("CDUSUARIO").Value
            GUSERDS = objUsuario.DESC_USER 'RS.Fields("DSUSUARIO").Value
            VALIDA_USUARIO = True
        End If

    End Function
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        RS = Nothing
        objUsuario = Nothing
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Call Main()
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown

    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    e.Handled = True
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub


    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click
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
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                'Me.UsernameTextBox.Tag = .GrecibeColumnaOpcional
                Me.UsernameTextBox.Text = .GrecibeColumnaID
            End If
            .Close()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Acceso_Numerico
            .TXT_CLAVE.Clear()
            .TORIG = "L1"
            .ShowDialog()
            Me.UsernameTextBox.Text = .UserCod
            Me.PasswordTextBox.Text = .UserPsw
            'VALIDA_USUARIO()
            OK_Click(OK, Nothing)
        End With
    End Sub
End Class
