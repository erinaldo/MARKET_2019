Public Class Mant_CtaBancaria
    Dim OBJCTABANCO As ClsCtaBanc
    Dim INTVALOR As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Dim CN_NET As SqlConnection

    Private Sub Mant_TC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCTABANCO = New ClsCtaBanc
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
            Me.Combo_MONEDA.SelectedIndex = 0
            'LLENAR_COMBO(Me.Combo_MONEDA, "SELECT AMONCODI, AMONDESC FROM MONEDA WHERE (AMONSTAT = 0)", "AMONDESC", "AMONCODI", CAD_CON)
            LLENAR_COMBO(Me.Combo_BANCO, "SELECT COD_BANCO, DESC_BANCO FROM BANCOS WHERE (STAT_BANCO = 0)", "DESC_BANCO", "COD_BANCO", CAD_CON)
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
        With OBJCTABANCO
            .Codigo = Val(Me.TXT_CODIGO.Text)
            INTVALOR = .CtaBancMantenimiento(intANULAR)
        End With
        If INTVALOR = 0 Then
            MsgBox("Cuenta Bancaria eliminada con exito", MsgBoxStyle.Information)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click

    End Sub
    Sub ASIGNAR_DATOS()
        With OBJCTABANCO
            Me.TXT_CODIGO.Text = .Codigo
            Me.TXT_DESC.Text = .Descripcion
            Me.TXT_ABREV.Text = .Abrev
            Me.CHK_ACTIVO.Checked = .Estado
            Me.Combo_MONEDA.SelectedValue = IIf(.Moneda = "S", 0, 1)
            Me.Combo_BANCO.SelectedValue = .Banco
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
        ''If BUSCAR_PERMISO("9101") = False Then MsgBox("Usted no tiene permiso para grabar el Tipo de Cambio", MsgBoxStyle.Information) : End
        ''
        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese la Descripcion", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_ABREV.Text = "" Then MsgBox("Ingrese Abreviatura", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("CTABANC", "ACTADESC", Me.TXT_DESC.Text) = True Then
                MsgBox("Cuenta Bancaria ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
        End If
        ''GRABANDO
        With OBJCTABANCO
            .Codigo = Val(Me.TXT_CODIGO.Text)
            .Descripcion = Me.TXT_DESC.Text
            .Abrev = Me.TXT_ABREV.Text
            .Estado = Me.CHK_ACTIVO.Checked
            .Moneda = Strings.Left(Me.Combo_MONEDA.Text, 1)
            .Banco = Me.Combo_BANCO.SelectedValue
        End With
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        INTVALOR = OBJCTABANCO.CtaBancMantenimiento(TIPO)
        If INTVALOR = 0 Then
            MsgBox("Cuenta Bancaria grabada con exito", MsgBoxStyle.Information)
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

        Dim arraybusqueda(5, 3) As Object
        arraybusqueda(1, 1) = "ACTACODI"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "ACTADESC"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "AMONSIMB"
        arraybusqueda(3, 2) = "Moneda "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "ABANDESC"
        arraybusqueda(4, 2) = "Banco "
        arraybusqueda(4, 3) = 1500
        arraybusqueda(5, 1) = "ACTASTAT"
        arraybusqueda(5, 2) = "Estado "
        arraybusqueda(5, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_CtaBancos"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                OBJCTABANCO.Codigo = .GrecibeColumnaID
                OBJCTABANCO.BUSCAR()
                ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
End Class