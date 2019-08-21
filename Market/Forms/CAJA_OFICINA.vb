Public Class CAJA_OFICINA
    Dim OBJOFIC As ClsCajaOfic
    Dim OBJTC As ClsTC

    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String

    Private Sub Mant_TARJETAS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.F2 Then
        '    Call picturebox1_Click_1(picturebox1, EventArgs.Empty)
        'End If
    End Sub


    Private Sub Mant_TARJETAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call HabBotones(True)
        OBJOFIC = New ClsCajaOfic
        OBJTC = New ClsTC
        Combo_MONEDA.SelectedIndex = 0
        Call Button_NUEVO_Click(Button_NUEVO, EventArgs.Empty)
        Me.OPT_SAL.Checked = True
        GENERAR_NUMERO()

    End Sub


    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.Button_NUEVO.Enabled = Iblnvalor
        'Button_MODIFICAR.Enabled = Iblnvalor
        'Button_ANULAR.Enabled = Iblnvalor
        Button_GRABAR.Enabled = Not Iblnvalor
        'Me.picturebox1.Enabled = Iblnvalor

        Button_CANCELAR.Enabled = Not Iblnvalor
    End Sub

   


    ''Private Sub txt_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_COD.KeyPress
    ''    If e.KeyChar = ChrW(Keys.Enter) Then
    ''        e.Handled = True
    ''        Me.TXT_DESC.Focus()
    ''    End If
    ''End Sub


    Private Sub picturebox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda
        If Me.TXT_COD_CUENTA.Text = "" Then MsgBox("Seleccione la Cuenta", MsgBoxStyle.Information) : Exit Sub

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "SUB_PLANCTA"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_PLANCTAD"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_PLANCTA"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_PlanCtas_D"
            .COD_DOC = Me.TXT_COD_CUENTA.Text
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD_SUBCUENTA.Text = .GrecibeColumnaID
                Me.TXT_SUBCUENTA.Text = .GrecibeColumnaOpcional
                
            End If
            .Close()
        End With
    End Sub

    Private Sub Button_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_NUEVO.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Me.LblAnulado.Text = ""
            'Me.TXT_COD.Text = GENERAR_CODIGO("TARJETA", "COD_TARJETA", "00")
            Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False
            'Me.TXT_COD.Enabled = False
            GENERAR_NUMERO()
            Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "V")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CANCELAR.Click
        Call Button_NUEVO_Click(Button_NUEVO, EventArgs.Empty)
        Call HabBotones(True)
    End Sub

    Private Sub Button_MODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_MODIFICAR.Click
        ''
        If DBLISTAR.Item(DBLISTAR.Row, 10) = "C" Then
            MsgBox("Este Recibo se genero en Punto de Venta, no se puede modificar", MsgBoxStyle.Information)
            Exit Sub
        End If
        ''
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        CARGAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 1), Me.DBLISTAR.Item(DBLISTAR.Row, 2))
        Me.TabControl1.SelectedTab = TabPage2
        ''Me.TXT_COD.Enabled = False
    End Sub
    Sub CARGAR_DATOS(ByVal TIPO_MCAJA As String, ByVal COD_MCAJA As Double)
        Try
            Dim RS As SqlDataReader
            RS = OBJOFIC.BUSCAR_CAJA_OFICINA(TIPO_MCAJA, COD_MCAJA)
            While RS.Read
                Me.TXT_NRO.Text = COD_MCAJA
                If TIPO_MCAJA = "S" Then OPT_SAL.Checked = True Else Me.OPT_ING.Checked = True
                Me.DT_FECHA.Value = RS("FECHA_MCAJA")
                If RS("MON_MCAJA") = "S" Then Me.Combo_MONEDA.SelectedIndex = 0 Else Me.Combo_MONEDA.SelectedIndex = 1
                Me.TXT_TC.Text = RS("TC_MCAJA")
                If RS("STAT_MCAJA") = 0 Then Me.LblAnulado.Text = "" Else Me.LblAnulado.Text = "ANULADO"
                Me.TXT_COD_CUENTA.Text = RS("COD_PLANCTA")
                Me.TXT_CUENTA.Text = RS("DESC_PLANCTA")
                Me.TXT_COD_SUBCUENTA.Text = RS("SUB_PLANCTA")
                Me.TXT_SUBCUENTA.Text = RS("DESC_PLANCTAD")
                Me.TXT_ENTREGAMOS.Text = RS("ENTREGAMOS_MCAJA")
                Me.TXT_IMPORTE.Text = RS("MONTO_MCAJA")
                Me.TXT_OBSERV.Text = RS("OBSERV_MCAJA")
            End While
            RS.Close()
            CN_NET.Close()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button_GRABAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GRABAR.Click
        Dim TIPO As String

        If Me.TXT_COD_CUENTA.Text = "" Then MsgBox("Ingrese Cuenta", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_COD_SUBCUENTA.Text = "" Then MsgBox("Ingrese SubCuenta", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_ENTREGAMOS.Text = "" Then MsgBox("Ingrese a quien se le Entrega", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_IMPORTE.Text) = 0 Then MsgBox("Ingrese Importe", MsgBoxStyle.Information) : Exit Sub

        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        intvalor = OBJOFIC.MANT_CAJAOFIC(IIf(Me.OPT_ING.Checked = True, "I", "S"), Me.TXT_NRO.Text, Me.DT_FECHA.Value, _
                Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_COD_CUENTA.Text, Me.TXT_COD_SUBCUENTA.Text, Me.TXT_ENTREGAMOS.Text.Trim, _
                 Val(Me.TXT_IMPORTE.Text), Me.TXT_OBSERV.Text.Trim, Val(Me.TXT_TC.Text), TIPO)
        If intvalor = 0 Then
            MsgBox("Movimiento de Caja grabado con exito", MsgBoxStyle.Information)
            If MsgBox("Desea Imprimir??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then IMPRIMIR(IIf(Me.OPT_ING.Checked = True, "I", "S"), Me.TXT_NRO.Text)
            Call Button_NUEVO_Click(Button_NUEVO, EventArgs.Empty)
            Call HabBotones(True)
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button_ANULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ANULAR.Click
        ''
        If DBLISTAR.Item(DBLISTAR.Row, 10) = "C" Then
            If MsgBox("Este Recibo se genero en Punto de Venta, se Eliminara,seguro de continuar??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            ''
            intvalor = OBJOFIC.MANT_CAJAOFIC(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 1), Me.DBLISTAR.Item(Me.DBLISTAR.Row, 2), Me.DT_FECHA.Value, _
                Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_COD_CUENTA.Text, Me.TXT_COD_SUBCUENTA.Text, Me.TXT_ENTREGAMOS.Text.Trim, _
                 Val(Me.TXT_IMPORTE.Text), Me.TXT_OBSERV.Text.Trim, 0, intELIMINAR)
            If intvalor = 0 Then
                MsgBox("Recibo eliminado con exito", MsgBoxStyle.Information)
                Call Button1_Click(Button1, EventArgs.Empty)
            Else
                MsgBox("Error al anular", MsgBoxStyle.Information)
            End If
            ''
            Exit Sub
        End If
        ''
        If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        intvalor = OBJOFIC.MANT_CAJAOFIC(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 1), Me.DBLISTAR.Item(Me.DBLISTAR.Row, 2), Me.DT_FECHA.Value, _
                Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_COD_CUENTA.Text, Me.TXT_COD_SUBCUENTA.Text, Me.TXT_ENTREGAMOS.Text.Trim, _
                 Val(Me.TXT_IMPORTE.Text), Me.TXT_OBSERV.Text.Trim, 0, intANULAR)
        If intvalor = 0 Then
            MsgBox("Recibo anulado con exito", MsgBoxStyle.Information)
            Call Button1_Click(Button1, EventArgs.Empty)
        Else
            MsgBox("Error al anular", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            IMPRIMIR(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 1), Me.DBLISTAR.Item(Me.DBLISTAR.Row, 2))
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub IMPRIMIR(ByVal TIPO As String, ByVal COD As Double)
        With Impresion
            .FORM = "IMP_CAJA"
            .TIPO_MCAJA = TIPO
            .COD_MCAJA = COD
            .Show()
        End With
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_PLANCTA"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_PLANCTA"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_PLANCTA"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_PlanCtas"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD_CUENTA.Text = .GrecibeColumnaID
                Me.TXT_CUENTA.Text = .GrecibeColumnaOpcional
                
            End If
            .Close()
        End With
    End Sub

    Private Sub TXT_IMPORTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_IMPORTE.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_IMPORTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_IMPORTE.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            OBJOFIC.IAM_LISTAR_RECIBOS_OFIC(Format(Me.DT_INI.Value, "yyyyMMdd"), Format(Me.DT_FIN.Value, "yyyyMMdd"), Me.DBLISTAR)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub OPT_ING_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_ING.CheckedChanged
        GENERAR_NUMERO()
    End Sub
    Sub GENERAR_NUMERO()
        Try
            Me.TXT_NRO.Text = OBJOFIC.CORR_CAJA(IIf(Me.OPT_ING.Checked = True, "I", "S"))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub OPT_SAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_SAL.CheckedChanged
        GENERAR_NUMERO()
    End Sub

    Private Sub TXT_TC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TC.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_TC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TC.TextChanged

    End Sub

    Private Sub DT_FECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FECHA.ValueChanged
        Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "V")
    End Sub
End Class