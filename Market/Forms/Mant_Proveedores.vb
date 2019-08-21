Public Class Mant_Proveedores

    Dim OBJPROV As ClsProveedor
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String

    Private Sub Mant_Proveedores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call picturebox1_Click_1(picturebox1, EventArgs.Empty)
        End If
    End Sub

    Private Sub Mant_Proveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub


    Private Sub Mant_MEDIDAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        OBJPROV = New ClsProveedor
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
        If Me.TXT_COD.Text = "" Then MsgBox("Ingrese Codigo", MsgBoxStyle.Information) : Exit Sub


        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("PROVEEDORES", "COD_PROVED", Me.TXT_COD.Text.Trim) = True Then
                MsgBox("Proveedor ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
            If BUSCAR_EXISTE("PROVEEDORES", "RUC_PROVED", Me.TXT_RUC.Text.Trim) = True Then
                If MsgBox("Ruc ya existe,seguro de Grabar??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If
        End If

        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJPROV.MANT_PROVEEDORES(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_RUC.Text.Trim,
                Me.TXT_DIREC.Text.Trim, Me.TXT_FONO1.Text.Trim, Me.TXT_FONO2.Text.Trim, Me.TXT_CONTACTO.Text.Trim, Val(Me.TXT_PERCEP.Text), TIPO)
        If intvalor = 0 Then
            MsgBox("Proveedor grabado con exito", MsgBoxStyle.Information)
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
        intvalor = OBJPROV.MANT_PROVEEDORES(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_RUC.Text.Trim,
                Me.TXT_DIREC.Text.Trim, Me.TXT_FONO1.Text.Trim, Me.TXT_FONO2.Text.Trim, Me.TXT_CONTACTO.Text.Trim, Val(TXT_PERCEP.Text), intANULAR)
        If intvalor = 0 Then
            MsgBox("Proveedor anulado con exito", MsgBoxStyle.Information)
            Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub
    Sub ASIGNAR_DATOS()
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJPROV.LISTAR_PROV(Me.TXT_COD.Text)
        While RS.Read
            Me.TXT_RUC.Text = NULO(RS("RUC_PROVED"), "S")
            Me.TXT_DIREC.Text = NULO(RS("DIR_PROVED"), "S")
            Me.TXT_FONO1.Text = NULO(RS("TELF_PROVED"), "S")
            Me.TXT_FONO2.Text = NULO(RS("TELF2_PROVED"), "S")
            Me.TXT_CONTACTO.Text = NULO(RS("CONTACTO_PROVED"), "S")
            Me.TXT_PERCEP.Text = RS("PERCEP_PROVED")
        End While
        CN_NET.Close()
    End Sub
    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click

        With Impresion
            .FORM = "Mant_Proveedores"
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
            'Me.TXT_COD.Text = GENERAR_CODIGO("GRUPO", "COD_GRUPO", "000")
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            Me.TXT_COD.Enabled = True
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
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD.Text = .GrecibeColumnaID
                Me.TXT_DESC.Text = .GrecibeColumnaOpcional
                Me.LblAnulado.Text = .GrecibeColumnaOpcional2
                ASIGNAR_DATOS()
            End If
            .Close()
        End With

    End Sub
End Class