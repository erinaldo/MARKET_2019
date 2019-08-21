Public Class Mant_TPago
    Dim OBJTPAGO As ClsTPago
    Dim INTVALOR As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean

    Private Sub Mant_TC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJTPAGO = New ClsTPago
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(False)

    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.Button1.Enabled = Iblnvalor
        ToolCancelar.Enabled = Not Iblnvalor
    End Sub
    Private Sub ToolSalir_Click(sender As Object, e As EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolNuevo_Click(sender As Object, e As EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            TXT_CODIGO.Enabled = False
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolCancelar_Click(sender As Object, e As EventArgs) Handles ToolCancelar.Click
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
    End Sub

    Private Sub ToolModificar_Click(sender As Object, e As EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
    End Sub

    Private Sub ToolAnular_Click(sender As Object, e As EventArgs) Handles ToolAnular.Click
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        INTVALOR = OBJTPAGO.Mantenimiento(intANULAR)
        If INTVALOR = 0 Then
            MsgBox("Tipo de Pago anulado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub ASIGNAR_DATOS()
        With OBJTPAGO
            Me.TXT_CODIGO.Text = .Codigo
            Me.TXT_DESC.Text = .Descripcion
            Me.CHK_ACTIVO.Checked = .Estado
            Me.CHK_BANCO.Checked = .PedirBanco
        End With
    End Sub
    Private Sub TXT_COMPRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CODIGO.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.TXT_DESC.Focus()
        End If
    End Sub

    Private Sub TXT_VENTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.ToolGrabar.PerformClick()
        End If
    End Sub

    Private Sub TXT_VENTA_TextChanged(sender As Object, e As EventArgs) Handles TXT_DESC.TextChanged

    End Sub

    Private Sub ToolGrabar_Click(sender As Object, e As EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        ''
        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese la Descripcion", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("TIPO_PAGO", "DESC_TPAGO", Me.TXT_DESC.Text) = True Then
                MsgBox("Tipo de Pago ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''GRABANDO
        With OBJTPAGO
            .Codigo = Val(Me.TXT_CODIGO.Text)
            .Descripcion = Me.TXT_DESC.Text
            .Estado = Me.CHK_ACTIVO.Checked
            .PedirBanco = Me.CHK_BANCO.Checked
        End With
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        INTVALOR = OBJTPAGO.Mantenimiento(TIPO)
        If INTVALOR = 0 Then
            MsgBox("Tipo de Pago grabado con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TXT_COMPRA_GotFocus(sender As Object, e As EventArgs) Handles TXT_CODIGO.GotFocus
        COLOR_FOCO(TXT_CODIGO, "F")
    End Sub

    Private Sub TXT_VENTA_GotFocus(sender As Object, e As EventArgs) Handles TXT_DESC.GotFocus
        COLOR_FOCO(TXT_DESC, "F")
    End Sub

    Private Sub TXT_COMPRA_LostFocus(sender As Object, e As EventArgs) Handles TXT_CODIGO.LostFocus
        COLOR_FOCO(TXT_CODIGO, "Q")
    End Sub

    Private Sub TXT_VENTA_LostFocus(sender As Object, e As EventArgs) Handles TXT_DESC.LostFocus
        COLOR_FOCO(TXT_DESC, "Q")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_TPAGO"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "DESC_TPAGO"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_TPAGO"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_TPago"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                OBJTPAGO.Codigo = .GrecibeColumnaID
                OBJTPAGO.BUSCAR(CN_NET)
                ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
End Class