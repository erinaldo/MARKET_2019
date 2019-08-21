Public Class Mant_Clientes

    Dim OBJCLIE As ClsCliente
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String

    Dim xDat As String
    Dim xRazSoc As String, xEst As String, xCon As String, xDir As String
    Dim xRazSocX As Long, xEstX As Long, xConX As Long, xDirX As Long
    Dim xRazSocY As Long, xEstY As Long, xConY As Long, xDirY As Long

    Dim myInfo As Libreria.ClsSunat

    Private Sub Mant_Proveedores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call picturebox1_Click_1(picturebox1, EventArgs.Empty)
        End If
    End Sub

    Private Sub Mant_Proveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub


    Private Sub Mant_clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
        OBJCLIE = New ClsCliente
        CARGARIMAGEN()
    End Sub

    Private Sub TXT_DESC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DESC.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'Me.TXT_Clave.Focus()
        End If
    End Sub
    Sub limpiar_SUNAT()
        Me.txt_ruc.Clear()
        Me.TXT_DESC.Clear()
        Me.TXT_DIREC.Clear()
        Me.txt_fono1.Clear()
        Me.TXT_RUC.Focus()
        Me.LblAnulado.Visible = False
        ''
        Me.TXT_ESTADO.Clear()
        Me.TXT_CONDICION.Clear()
        Me.Group_SUNAT.Visible = False
    End Sub
    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String

        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese Descripcion", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_COD.Text = "" Then MsgBox("Ingrese Codigo", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_FPAGO.Text = "" Then MsgBox("Ingrese Forma de Pago", MsgBoxStyle.Information) : Exit Sub


        ''VALIDAR SI EXISTE
        If pb_agregar = True Then
            If BUSCAR_EXISTE("CLIENTES", "COD_CLIENTE", Me.TXT_COD.Text.Trim) = True Then
                MsgBox("Cliente ya existe", MsgBoxStyle.Information) : Exit Sub
            End If
            If BUSCAR_EXISTE("CLIENTES", "RUC_CLIENTE", Me.TXT_RUC.Text.Trim) = True Then
                If MsgBox("Ruc ya existe,seguro de Grabar??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If
            If BUSCAR_EXISTE("CLIENTES", "DNI_CLIENTE", Me.TXT_DNI.Text.Trim) = True Then
                If MsgBox("Dni ya existe,seguro de Grabar??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If
        End If

        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJCLIE.MANT_CLIENTES(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_RUC.Text.Trim,
                Me.TXT_DIREC.Text.Trim, Me.TXT_FONO1.Text.Trim, Me.TXT_FPAGO.Tag, Val(Me.TXT_LC.Text), Me.TXT_DNI.Text, Me.TXT_MAIL.Text, TIPO)
        If intvalor = 0 Then
            MsgBox("Cliente grabado con exito", MsgBoxStyle.Information)
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
        Me.picturebox1.Enabled = Iblnvalor

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
        intvalor = OBJCLIE.MANT_CLIENTES(Me.TXT_COD.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_RUC.Text.Trim,
                Me.TXT_DIREC.Text.Trim, Me.TXT_FONO1.Text.Trim, Me.TXT_FPAGO.Tag, Val(Me.TXT_LC.Text), "", Me.TXT_MAIL.Text.Trim, intANULAR)
        If intvalor = 0 Then
            MsgBox("Cliente anulado con exito", MsgBoxStyle.Information)
            Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub ASIGNAR_DATOS()
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJCLIE.LISTAR_CLIE(Me.TXT_COD.Text, "COD_CLIENTE")
        While RS.Read
            Me.TXT_RUC.Text = NULO(RS("RUC"), "S")
            Me.TXT_DIREC.Text = NULO(RS("DIR_CLIENTE"), "S")
            Me.TXT_FONO1.Text = NULO(RS("TELF_CLIENTE"), "S")
            Me.TXT_FPAGO.Text = NULO(RS("DESC_FP"), "S")
            Me.TXT_FPAGO.Tag = RS("COD_FP")
            Me.TXT_LC.Text = RS("LC_CLIENTE")
            Me.TXT_DNI.Text = RS("DNI_CLIENTE")
            Me.TXT_MAIL.Text = RS("MAIL_CLIENTE")
        End While
        CN_NET.Close()
    End Sub
    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click

        With Impresion
            .FORM = "Mant_Clientes"
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
            ''
            Me.TXT_ESTADO.Clear()
            Me.TXT_CONDICION.Clear()
            Me.Group_SUNAT.Visible = False
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
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD.Text = .GrecibeColumnaID
                Me.TXT_DESC.Text = .GrecibeColumnaOpcional
                Me.LblAnulado.Text = .GrecibeColumnaOpcional3
                ASIGNAR_DATOS()
            End If
            .Close()
        End With

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "COD_FP"
        arraybusqueda(1, 2) = "Usuario"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_FP"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "DIAS_FP"
        arraybusqueda(3, 2) = "Dias "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "STAT_FP"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_FPago"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_FPAGO.Tag = .GrecibeColumnaID
                Me.TXT_FPAGO.Text = .GrecibeColumnaOpcional

            End If
            .Close()
        End With

    End Sub

    Private Sub TXT_RUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_RUC.TextChanged

    End Sub

    Private Sub TXT_LC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_LC.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_LC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LC.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try

            If Trim(TXT_RUC.Text) = "" Then
                MsgBox("Ingrese número del RUC")
                TXT_RUC.Focus()
                Exit Sub
            End If
            If IsNumeric(TXT_RUC.Text) = True Then
                If Len(TXT_RUC.Text) < 11 Then
                    limpiar_SUNAT()
                    MsgBox("Ingrese los 11 números del RUC")
                    TXT_RUC.Focus()
                    Exit Sub
                End If
                If Val(Mid(Trim(TXT_RUC.Text), 2, 9)) = 0 Or Trim(TXT_RUC.Text) = "23333333333" Then
                    limpiar_SUNAT()
                    MsgBox("Verificar número del RUC")
                    TXT_RUC.Focus()
                    Exit Sub
                End If
                If Verificar_ruc(TXT_RUC.Text) = False Then
                    limpiar_SUNAT()
                    MsgBox("El número del RUC no es válido")
                    TXT_RUC.Focus()
                    Exit Sub
                End If
                '        RUC txtRuc.Text
                ''OTRO(txt_ruc.Text, Me.txt_ruc.Text, Me.TXTCAPCHA.Text)
            Else
                limpiar_SUNAT()
                MsgBox("Solo se aceptan números")
                TXT_RUC.Focus()
            End If
            ''llamamos a los metodos de la libreria ConsultaReniec...

            myInfo.GetInfo(TXT_RUC.Text, TXTCAPCHA.Text)
            TXT_DIREC.Text = myInfo.ApeMaterno
            TXT_DESC.Text = myInfo.Nombres
            TXT_RUC.Text = TXT_RUC.Text

            TXT_ESTADO.Text = myInfo.Estado
            TXT_CONDICION.Text = myInfo.Condicion
            Habilitar(True)
            'txt_ruc.Text = ""
            TXTCAPCHA.Text = ""
            CARGARIMAGEN()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub Habilitar(ByVal xOpc As Boolean)
        Me.Group_SUNAT.Visible = xOpc
    End Sub
    Function Verificar_ruc(ByVal xNum As String) As Boolean
        Dim li_suma, li_residuo, li_diferencia, li_compara As Integer
        li_suma = (CInt(Mid(xNum, 1, 1)) * 5) + (CInt(Mid(xNum, 2, 1)) * 4) + (CInt(Mid(xNum, 3, 1)) * 3) + (CInt(Mid(xNum, 4, 1)) * 2) + (CInt(Mid(xNum, 5, 1)) * 7) + (CInt(Mid(xNum, 6, 1)) * 6) + (CInt(Mid(xNum, 7, 1)) * 5) + (CInt(Mid(xNum, 8, 1)) * 4) + (CInt(Mid(xNum, 9, 1)) * 3) + (CInt(Mid(xNum, 10, 1)) * 2)
        li_compara = CInt(Mid(xNum, 11, 1))
        li_residuo = li_suma Mod 11
        li_diferencia = Int(11 - li_residuo)
        If li_diferencia > 9 Then li_diferencia = li_diferencia - 10
        If li_diferencia <> li_compara Then
            Verificar_ruc = False
        Else
            Verificar_ruc = True
        End If
    End Function
    Sub CARGARIMAGEN()
        Try

            If myInfo Is Nothing Then
                myInfo = New Libreria.ClsSunat

            End If
            Me.PICTURE.Image = myInfo.GetCapcha

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTONCAPCHA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTONCAPCHA.Click
        Try
            CARGARIMAGEN()
            TXTCAPCHA.SelectAll()
            BTONCAPCHA.Focus()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class