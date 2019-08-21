Public Class Pago_Proveedor


    Dim OBJPAGOS As ClsPago
    Dim OBJTC As ClsTC
    Dim OBJPROV As ClsProveedor
    Dim OBJCOBRADORES As ClsCobrador
    Dim OBJBANCOS As ClsBanco
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    Public GrecibeUbicacion As ADODB.BookmarkEnum
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public GrecibeColumnaOpcional3 As String
    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        Consultar_Compras.Tag = "Pagos"
        Consultar_Compras.DBLISTAR.Tag = Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1)
        Consultar_Compras.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pago_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJPAGOS = New ClsPago
        OBJTC = New ClsTC
        OBJPROV = New ClsProveedor
        OBJCOBRADORES = New ClsCobrador
        OBJBANCOS = New ClsBanco
        Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
        Call HabBotones(True)
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Try
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try

            ''LIMPIAR
            'LimpiarCAJAS(Me.Controls)
            Me.TXT_COD_PROV.Text = ""
            Me.TXT_DESC_PROV.Text = ""
            Me.TXT_DEUDA.Text = ""
            Me.TXT_TOTAL_PAGO.Text = ""
            Me.DT_PAGO.Value = Date.Today
            Me.Combo_MONEDA.SelectedIndex = 0
            Me.TXT_ESTADO.Text = ""
            ''BUSCAR CORRELATIVO
            Me.TXT_NRO_PAGO.Text = OBJPAGOS.NRO_PAGO
            Call HabBotones(False)
            OBJCOBRADORES.LISTAR_COBRADORES(Me.Combo_COBRADOR)
            OBJBANCOS.LISTAR_BANCOS(Me.Combo_BANCO)
            Me.Combo_COBRADOR.SelectedIndex = 0
            Me.Combo_TIPO_PAGO.SelectedIndex = 0
            Me.Combo_BANCO.Text = ""
            Me.TXT_CHEQUE.Text = ""
            Me.TXT_CUENTA.Text = ""
            ''
            Me.Button1.Enabled = True
            Me.Combo_MONEDA.Enabled = True
            Me.Label6.Visible = True
            Me.TXT_DEUDA.Visible = True
            Me.ToolGrabar.Visible = True
            ''
            LLENAR_DEUDA()
            ''
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub HabBotones(ByVal Iblnvalor As Boolean)
        Me.ToolNuevo.Enabled = Iblnvalor
        Me.ToolModificar.Enabled = Iblnvalor
        ToolAnular.Enabled = Not Iblnvalor
        ToolGrabar.Enabled = Not Iblnvalor
        Me.picturebox1.Enabled = Not Iblnvalor

        ToolCancelar.Enabled = Not Iblnvalor
    End Sub

    Private Sub DT_COBRO_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_PAGO.ValueChanged
        Try

            Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_PAGO.Value, "V")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        Dim C As Integer = 0
        Dim INTVALOR As Integer
        If Me.TXT_COD_PROV.Text = "" Then MsgBox("Ingrese Proveedor", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_DESC_PROV.Text = "" Then MsgBox("Ingrese Proveedor", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_TOTAL_PAGO.Text) = 0 Then MsgBox("Ingrese Monto de Documento a Cancelar", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_TC.Text = "" Then MsgBox("Ingrese Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub
        If Me.Combo_COBRADOR.Text = "" Then MsgBox("Seleccione Pagador", MsgBoxStyle.Information) : Exit Sub
        If Me.Combo_TIPO_PAGO.Text = "" Then MsgBox("Seleccione Tipo de Pago", MsgBoxStyle.Information) : Exit Sub
        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Ingrese Detalle del Documento", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR DATOS LLENOS DEL DETALLE
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        INTVALOR = OBJPAGOS.GRABAR_PAGO(Me.TXT_COD_PROV.Text.Trim, Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_TOTAL_PAGO.Text, Me.Combo_COBRADOR.SelectedValue, Strings.Left(Me.Combo_TIPO_PAGO.Text, 1), IIf(Me.Combo_BANCO.Text = "", "", Me.Combo_BANCO.SelectedValue), Me.TXT_CHEQUE.Text.Trim, Me.TXT_CUENTA.Text.Trim, Me.DT_PAGO.Value, Me.TXT_TC.Text, Me.DBLISTAR)
        'If intvalor = 2 Then MsgBox("Documento ya existe", MsgBoxStyle.Information) : Exit Sub
        If INTVALOR = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
        If INTVALOR = 0 Then
            MsgBox("Pago grabado con exito", MsgBoxStyle.Information)
            If MsgBox("Desea Imprimir Recibo??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Call Me.ToolPrint_Click(ToolPrint, EventArgs.Empty)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        End If
    End Sub

    Private Sub TXT_COD_prov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_COD_PROV.KeyPress
        Dim RS As New ADODB.Recordset
        If e.KeyChar = ChrW(Keys.Enter) Then
            RS = OBJPROV.LISTAR_PROV(Me.TXT_COD_PROV.Text.Trim)
            If Not (RS.EOF And RS.BOF) Then
                Me.TXT_DESC_PROV.Text = NULO(RS.Fields("DESCRIPCION").Value, "S")
                LLENAR_DEUDA()
                'Me.TXT_RUC.Text = NULO(RS.Fields("RUC").Value, "S")
                'Me.TXT_DIRECCION.Text = NULO(RS.Fields("DIR_CLIENTE").Value, "S")
            Else
                MsgBox("Proveedor no existe", MsgBoxStyle.Exclamation)
            End If
            RS.Close()
        End If

    End Sub

    Private Sub TXT_COD_CLIENTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_COD_PROV.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD_PROV.Text = .GrecibeColumnaID
                Me.TXT_DESC_PROV.Text = .GrecibeColumnaOpcional
                LLENAR_DEUDA()
                'ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
    Sub LLENAR_DEUDA()
        OBJPAGOS.LLENAR_DEUDA(Me.TXT_COD_PROV.Text.Trim, Strings.Left(Me.Combo_MONEDA.Text, 1), NULO(Me.TXT_TC.Text, "N"), Me.DBLISTAR)
        ''TOTALIZAR
        Dim F As Integer
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOT = TOT + Me.DBLISTAR.Item(F, 7)
        Next
        Me.TXT_DEUDA.Text = GFormatodeNumero(TOT, 2)
    End Sub

    Private Sub Combo_MONEDA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_MONEDA.SelectedIndexChanged
        LLENAR_DEUDA()
    End Sub

    Private Sub DBLISTAR_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.AfterEdit
        If Math.Round(Me.DBLISTAR.Item(e.Row, 9), 2) > Math.Round(Me.DBLISTAR.Item(e.Row, 8), 2) Then
            MsgBox("El pago no puede ser mayor al Saldo")
            DBLISTAR.Item(e.Row, 9) = 0
        Else
            TOTAL_PAGO(9)
        End If

    End Sub
    Sub TOTAL_PAGO(ByVal COL As Integer)
        Dim F As Integer
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOT = TOT + Me.DBLISTAR.Item(F, COL)
        Next
        Me.TXT_TOTAL_PAGO.Text = GFormatodeNumero(TOT, 2)
    End Sub
    Private Sub DBLISTAR_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.BeforeEdit
        If e.Col < 9 Then e.Cancel = True
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.ContextMenuChanged

    End Sub

    Private Sub ToolModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolModificar.Click
        Call HabBotones(False)
        Me.pb_editar = True
        Me.pb_agregar = False
        Me.Button1.Enabled = False
        Me.Combo_MONEDA.Enabled = False
        Me.Label6.Visible = False
        Me.TXT_DEUDA.Visible = False
        Me.ToolGrabar.Visible = False
        'Me.txt_cod.Enabled = False
    End Sub
    Public Sub LLENAR_DATOS(ByVal COD As Integer)
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJPAGOS.BUSCAR(COD)
        While RS.Read
            Me.TXT_NRO_PAGO.Text = COD
            Me.TXT_COD_PROV.Text = RS("COD_PROVED")
            Me.TXT_DESC_PROV.Text = RS("DESC_PROVED")
            Me.DT_PAGO.Value = RS("FECHA_PAGO")
            Me.TXT_TC.Text = RS("CAMBIO_PAGO")
            If RS("MON_PAGO") = "S" Then Me.Combo_MONEDA.SelectedIndex = 0 Else Me.Combo_MONEDA.SelectedIndex = 1
            Me.TXT_DEUDA.Text = RS("TOTAL_PAGO")
            Me.TXT_TOTAL_PAGO.Text = RS("TOTAL_PAGO")
            Me.Combo_COBRADOR.SelectedValue = RS("PAGADOR")
            Select Case RS("TIPO_PAGO")
                Case "E"
                    Me.Combo_TIPO_PAGO.SelectedIndex = 0
                Case "B"
                    Me.Combo_TIPO_PAGO.SelectedIndex = 1
                Case "C"
                    Me.Combo_TIPO_PAGO.SelectedIndex = 2
                Case "D"
                    Me.Combo_TIPO_PAGO.SelectedIndex = 3
            End Select
            Me.Combo_BANCO.SelectedValue = RS("COD_BANCO")
            Me.TXT_CHEQUE.Text = RS("CHEQUE_PAGO")
            Me.TXT_CUENTA.Text = RS("CUENTA_PAGO")
            Me.TXT_ESTADO.Text = IIf(RS("STAT_PAGO") = 0, "", "ANULADO")
            OBJPAGOS.LLENAR_DETALLE_PAGO(COD, RS("MON_PAGO"), RS("CAMBIO_PAGO"), Me.DBLISTAR)
            TOTAL_PAGO(9)
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        Try
            Dim C As Integer
            If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            C = OBJPAGOS.ANULAR_PAGO(Me.TXT_NRO_PAGO.Text)
            If C = 0 Then MsgBox("Anulado con exito", MsgBoxStyle.Information) : Me.ToolCancelar_Click(ToolCancelar, EventArgs.Empty)
            If C = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click
        With Impresion
            .FORM = "Pago_Proveedor"
            .SW = Me.TXT_NRO_PAGO.Text
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub
End Class




