Public Class Cobranza_Cliente
    Dim OBJCOBROS As ClsCobro
    Dim OBJTC As ClsTC
    Dim OBJCLIENTE As ClsCliente
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
        Consultar_Compras.Tag = "Cobranza"
        Consultar_Compras.DBLISTAR.Tag = Microsoft.VisualBasic.Left(Me.Label3.Text.Trim, 1)
        Consultar_Compras.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Cobranza_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCOBROS = New ClsCobro
        OBJTC = New ClsTC
        OBJCLIENTE = New ClsCliente
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
            Me.TXT_COD_CLIENTE.Text = ""
            Me.TXT_DESC_CLIENTE.Text = ""
            Me.TXT_DEUDA.Text = ""
            Me.TXT_TOTAL_COBRANZA.Text = ""
            Me.DT_COBRO.Value = Date.Today
            Me.Combo_MONEDA.SelectedIndex = 0
            Me.TXT_ESTADO.Text = ""
            ''BUSCAR CORRELATIVO
            Me.TXT_NRO_COBRO.Text = OBJCOBROS.NRO_COBRO
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

    Private Sub DT_COBRO_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_COBRO.ValueChanged
        Try

            Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_COBRO.Value, "V")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Dim TIPO As String
        Dim C As Integer = 0
        Dim INTVALOR As Integer
        If Me.TXT_COD_CLIENTE.Text = "" Then MsgBox("Ingrese Cliente", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_DESC_CLIENTE.Text = "" Then MsgBox("Ingrese Cliente", MsgBoxStyle.Information) : Exit Sub
        If Val(Me.TXT_TOTAL_COBRANZA.Text) = 0 Then MsgBox("Ingrese Monto de Documento a Cancelar", MsgBoxStyle.Information) : Exit Sub
        If Me.TXT_TC.Text = "" Then MsgBox("Ingrese Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub
        If Me.Combo_COBRADOR.Text = "" Then MsgBox("Seleccione Cobrador", MsgBoxStyle.Information) : Exit Sub
        If Me.Combo_TIPO_PAGO.Text = "" Then MsgBox("Seleccione Tipo de Pago", MsgBoxStyle.Information) : Exit Sub
        If Me.DBLISTAR.Rows.Count = 1 Then MsgBox("Ingrese Detalle del Documento", MsgBoxStyle.Information) : Exit Sub
        ''VALIDAR DATOS LLENOS DEL DETALLE
        ''GRABANDO
        If pb_agregar Then TIPO = "N" Else TIPO = "M"
        INTVALOR = OBJCOBROS.GRABAR_COBRO(Me.TXT_COD_CLIENTE.Text.Trim, Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_TOTAL_COBRANZA.Text, Me.Combo_COBRADOR.SelectedValue, Strings.Left(Me.Combo_TIPO_PAGO.Text, 1), IIf(Me.Combo_BANCO.Text = "", "", Me.Combo_BANCO.SelectedValue), Me.TXT_CHEQUE.Text.Trim, Me.TXT_CUENTA.Text.Trim, Me.DT_COBRO.Value, Me.TXT_TC.Text, Me.DBLISTAR)
        'If intvalor = 2 Then MsgBox("Documento ya existe", MsgBoxStyle.Information) : Exit Sub
        If INTVALOR = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
        If INTVALOR = 0 Then
            MsgBox("Cobro grabado con exito", MsgBoxStyle.Information)
            If MsgBox("Desea Imprimir Recibo??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Call Me.ToolPrint_Click(ToolPrint, EventArgs.Empty)
            Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
            Call HabBotones(True)
        End If
    End Sub

    Private Sub TXT_COD_CLIENTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_COD_CLIENTE.KeyPress
        Dim RS As New ADODB.Recordset
        If e.KeyChar = ChrW(Keys.Enter) Then
            RS = OBJCLIENTE.LISTAR_CLIE(Me.TXT_COD_CLIENTE.Text, "COD_CLIENTE")
            If Not (RS.EOF And RS.BOF) Then
                Me.TXT_DESC_CLIENTE.Text = NULO(RS.Fields("DESCRIPCION").Value, "S")
                LLENAR_DEUDA()
                'Me.TXT_RUC.Text = NULO(RS.Fields("RUC").Value, "S")
                'Me.TXT_DIRECCION.Text = NULO(RS.Fields("DIR_CLIENTE").Value, "S")
            Else
                MsgBox("Cliente no existe", MsgBoxStyle.Exclamation)
            End If
            RS.Close()
        End If

    End Sub

    Private Sub TXT_COD_CLIENTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_COD_CLIENTE.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            .ACT = "Cta_Cobrar"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD_CLIENTE.Text = .GrecibeColumnaID
                Me.TXT_DESC_CLIENTE.Text = .GrecibeColumnaOpcional
                LLENAR_DEUDA()
                'ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub
    Sub LLENAR_DEUDA()
        OBJCOBROS.LLENAR_DEUDA(Me.TXT_COD_CLIENTE.Text, Strings.Left(Me.Combo_MONEDA.Text, 1), NULO(Me.TXT_TC.Text, "N"), Me.DBLISTAR)
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
        If Me.DBLISTAR.Item(e.Row, 8) > Me.DBLISTAR.Item(e.Row, 7) Then
            MsgBox("El pago no puede ser mayor al Saldo")
            DBLISTAR.Item(e.Row, 8) = 0
        Else
            TOTAL_PAGO(8)
        End If

    End Sub
    Sub TOTAL_PAGO(ByVal COL As Integer)
        Dim F As Integer
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOT = TOT + Me.DBLISTAR.Item(F, COL)
        Next
        Me.TXT_TOTAL_COBRANZA.Text = GFormatodeNumero(TOT, 2)
    End Sub
    Private Sub DBLISTAR_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.BeforeEdit
        If e.Col < 8 Then e.Cancel = True
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
        RS = OBJCOBROS.BUSCAR(COD)
        While RS.Read
            Me.TXT_NRO_COBRO.Text = COD
            Me.TXT_COD_CLIENTE.Text = RS("COD_CLIENTE")
            Me.TXT_DESC_CLIENTE.Text = RS("DESC_CLIENTE")
            Me.DT_COBRO.Value = RS("FECHA_COBRO")
            Me.TXT_TC.Text = RS("CAMBIO_COBRO")
            If RS("MON_COBRO") = "S" Then Me.Combo_MONEDA.SelectedIndex = 0 Else Me.Combo_MONEDA.SelectedIndex = 1
            Me.TXT_DEUDA.Text = RS("TOTAL_COBRO")
            Me.TXT_TOTAL_COBRANZA.Text = RS("TOTAL_COBRO")
            Me.Combo_COBRADOR.SelectedValue = RS("COBRADOR")
            Select Case RS("TIPO_COBRO")
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
            Me.TXT_CHEQUE.Text = RS("CHEQUE_COBRO")
            Me.TXT_CUENTA.Text = RS("CUENTA_COBRO")
            Me.TXT_ESTADO.Text = IIf(RS("STAT_COBRO") = 0, "", "ANULADO")
            OBJCOBROS.LLENAR_DETALLE_COBRO(COD, RS("MON_COBRO"), RS("CAMBIO_COBRO"), Me.DBLISTAR)
            TOTAL_PAGO(7)
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

    Private Sub ToolAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAnular.Click
        Try
            Dim C As Integer
            If MsgBox("Seguro de Anular??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            C = OBJCOBROS.ANULAR_COBRO(Me.TXT_NRO_COBRO.Text)
            If C = 0 Then MsgBox("Anulado con exito", MsgBoxStyle.Information) : Me.ToolCancelar_Click(ToolCancelar, EventArgs.Empty)
            If C = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrint.Click
        With Impresion
            .FORM = "Cobranza_Cliente"
            .SW = Me.TXT_NRO_COBRO.Text
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub
End Class