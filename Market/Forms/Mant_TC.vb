Public Class Mant_TC

    Dim OBJTC As ClsTC
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


    Private Sub Mant_fpago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        OBJTC = New ClsTC
    End Sub

    

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String

        If Val(Me.TXT_COMPRA.Text) = 0 Then MsgBox("Ingrese Compra", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_VENTA.Text) = 0 Then MsgBox("Ingrese Venta", MsgBoxStyle.Information) : Exit Sub
        'If Me.TXT_Dias.Text = "" Then MsgBox("Ingrese Dias", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("TIPO_CAMBIO", "FECHA", Format(Me.DT.Value, "dd/MM/yyyy")) = True Then
                MsgBox("Tipo de Cambio ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJTC.MANT_TC(Me.DT.Value, Me.TXT_COMPRA.Text, Me.TXT_VENTA.Text, TIPO)
        If intvalor = 0 Then
            MsgBox("Tipo de Cambio grabado con exito", MsgBoxStyle.Information)
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
        'Me.txt_cod.Enabled = False
    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        'Me.txt_cod.Enabled = False
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJTC.MANT_TC(Me.DT.Value, Me.TXT_COMPRA.Text, Me.TXT_VENTA.Text, intANULAR)
        If intvalor = 0 Then
            MsgBox("Tipo de Cambio eliminado con exito", MsgBoxStyle.Information)
            Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click

        With Impresion
            .FORM = "Mant_TC"
            .SW = 2
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub

    Public Sub ToolSNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            'Me.LblAnulado.Text = ""
            'Me.txt_cod.Text = BUSCARCOD("FORMA_PAGO", "COD_FP", "000")
            Me.DT.Value = Date.Now
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            'Me.txt_cod.Enabled = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

   

    Private Sub picturebox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "Fecha"
        arraybusqueda(1, 2) = "Fecha"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Compra"
        arraybusqueda(2, 2) = "Compra "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "Venta"
        arraybusqueda(3, 2) = "Venta "
        arraybusqueda(3, 3) = 1500
        


        ''
        With BusquedaMaestra
            .ACT = "Mant_TC"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                Me.DT.Value = .GrecibeColumnaID
                Me.TXT_COMPRA.Text = .GrecibeColumnaOpcional
                Me.TXT_VENTA.Text = .GrecibeColumnaOpcional2
            End If
            .Close()
        End With

    End Sub

    Private Sub TXT_COMPRA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_COMPRA.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then Me.TXT_VENTA.Focus()
    End Sub

    Private Sub TXT_COMPRA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_COMPRA.TextChanged

    End Sub

    Private Sub TXT_VENTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_VENTA.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))

    End Sub

    Private Sub TXT_VENTA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VENTA.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub
End Class