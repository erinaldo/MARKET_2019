Public Class Cuentas_Pagar

    Dim ORIG As String
    Dim MlonCorrelativo As Double

    Dim COL_ID As Integer = 0
    Dim COL_TDOC As Integer = 1
    Dim COL_NUMERO As Integer = 2
    Dim COL_PROVEEDOR As Integer = 3
    Dim COL_FPAGO As Integer = 4
    Dim COL_FECHA As Integer = 5
    Dim COL_VCTO As Integer = 6
    Dim COL_MONEDA As Integer = 7
    Dim COL_TOTAL_S As Integer = 8
    Dim COL_PAGO_S As Integer = 9
    Dim COL_SALDO_S As Integer = 10
    Dim COL_TOTAL_D As Integer = 11
    Dim COL_PAGO_D As Integer = 12
    Dim COL_SALDO_D As Integer = 13

    Private Sub Consultar_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        LLENAR_COMBO(Me.Combo_FPAGO, "SELECT 0 as COD_FP,'Todos' as DESC_FP union all SELECT COD_FP, DESC_FP FROM FORMA_PAGO WHERE STAT_FP=0 ", "DESC_FP", "COD_FP", CAD_CON)
        ''
        LLENAR_COMBO(Me.LIST_TIPO_DOC, "SELECT COD_DOC,DESC_DOC FROM TIPO_DOC WHERE (COMPRAS = 1)", "DESC_DOC", "COD_DOC", CAD_CON)
        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
        Me.Combo_TIPO.SelectedIndex = 1
        Me.Combo_FPAGO.SelectedIndex = 0
        Dim I As Integer
        For I = 0 To LIST_TIPO_DOC.Items.Count - 1
            LIST_TIPO_DOC.SetSelected(I, True)
        Next I
        VER()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        VER()
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub
    Sub VER()
        Dim CADENA As String = ""
        Dim TIPO As String
        ''CONDICIONES
        ''NRO DOCUMENTO
        If Me.TXT_NRO_DOC.Text.Trim <> "" Then
            CADENA = CADENA + " AND COMPRAS.num_COMPRA=''" & Me.TXT_NRO_DOC.Text & "''"
        End If
        ''PROVEEDOR
        If Me.TXT_PROVEEDOR.Text.Trim <> "" Then
            CADENA = CADENA + " AND COMPRAS.Cod_Proved=''" & Me.TXT_PROVEEDOR.Tag & "''"
        End If
        ''TIPO
        If Me.Combo_TIPO.SelectedIndex = 1 Then CADENA = CADENA + " AND (round(COMPRAS.TOTAL_COMPRA - COMPRAS.pagos_COMPRA,2)<>0) "
        If Me.Combo_TIPO.SelectedIndex = 2 Then CADENA = CADENA + " AND (round(COMPRAS.TOTAL_COMPRA - COMPRAS.pagos_COMPRA,2)=0) "

        ''TIPO
        If Me.Combo_FPAGO.SelectedIndex > 0 Then CADENA = CADENA + " AND (COMPRAS.COD_FP=" & Me.Combo_FPAGO.SelectedValue & ") "
        ''

        TIPO = Obtener_matriz_Seleccionada(LIST_TIPO_DOC)
        If TIPO = "" Then MsgBox("Seleccione al menos un Tipo de Documento", MsgBoxStyle.Information) : Exit Sub
        If Me.CHK_DETALLE.Checked = False Then
            LLENAR_GRID(Me.C1_DETALLE, "IAM_CUENTA_PAGAR '" & IIf(Me.OPT_EMISION.Checked, "E", "V") & "','" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & CADENA & "'", CAD_CON)

        Else
            LLENAR_GRID(Me.C1_DETALLE, "CTA_PAGAR_DETALLE '" & IIf(Me.OPT_EMISION.Checked, "E", "V") & "','" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & CADENA & "'", CAD_CON)
        End If
        DISEÑO()
        TOTALES()
    End Sub
    Sub TOTALES()
        Dim FIL As Integer
        With C1_DETALLE
            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_TOTAL_S, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_TOTAL_D, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_PAGO_S, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_PAGO_D, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_SALDO_S, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_SALDO_D, CFG_DRESULT), "Total")
            If Me.CHK_DETALLE.Checked = True Then
                For FIL = COL_SALDO_D To C1_DETALLE.Cols.Count - 1
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(FIL, CFG_DRESULT), "Total")
                Next
            End If
        End With
    End Sub
    Sub DISEÑO()
        Dim FIL As Integer
        C1_DETALLE.Cols(COL_TOTAL_S).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_TOTAL_D).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_PAGO_S).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_PAGO_D).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_SALDO_S).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_SALDO_D).Format = "###,###,###.00"

        If Me.CHK_DETALLE.Checked = True Then
            For FIL = COL_SALDO_D To C1_DETALLE.Cols.Count - 1
                C1_DETALLE.Cols(FIL).Format = "###,###,###.00"
            Next
        End If
        C1_DETALLE.AutoSizeCols()

        DISEÑO_LETRA(C1_DETALLE, 1, C1_DETALLE.Rows.Count - 1, COL_TOTAL_S, COL_SALDO_S)
        DISEÑO_HONEY(C1_DETALLE, 1, C1_DETALLE.Rows.Count - 1, COL_TOTAL_D, COL_SALDO_D)


    End Sub
    Public Function Obtener_matriz_Seleccionada(lst_temp As ListBox) As Object
        Dim I As Integer
        Dim li_ne As Integer 'numero de elementos
        Dim ls_cadena As String


        ls_cadena = String.Empty
        li_ne = lst_temp.Items.Count
        ''
        For Each Item As Object In lst_temp.SelectedItems
            If Len(ls_cadena) >= 1 Then ls_cadena = ls_cadena + ","
            '' ls_cadena = ls_cadena + "'" + CStr(Item("ADOCCODI")) + "'"
            ls_cadena = ls_cadena + CStr(Item("COD_DOC")) + ""
        Next

        Obtener_matriz_Seleccionada = ls_cadena
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub TXT_LIQ_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_LIQ_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXT_NRO_DOC.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NRO_DOC.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "COD_PROVED"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "DESC_PROVED"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "RUC_PROVED"
        arraybusqueda(3, 2) = "Ruc "
        arraybusqueda(3, 3) = 0
        arraybusqueda(4, 1) = "STAT_PROVED"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500

        With BusquedaMaestra
            .ACT = "Mant_Proveedores"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_PROVEEDOR.Tag = .GrecibeColumnaID
                TXT_PROVEEDOR.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub TXT_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PROVEEDOR.TextChanged

    End Sub

    Private Sub TXT_CLIENTE_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_PROVEEDOR.KeyUp
        If e.KeyCode = Keys.Delete Then
            Me.TXT_PROVEEDOR.Clear()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Me.SaveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
            Me.SaveFileDialog1.FileName = ""
            Me.SaveFileDialog1.ShowDialog()
            'dlg.ShowOpen()

            If Len(Me.SaveFileDialog1.FileName) = 0 Then Exit Sub

            Me.C1_DETALLE.SaveExcel(Me.SaveFileDialog1.FileName, "Listado", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_DETALLE_Click(sender As Object, e As EventArgs) Handles C1_DETALLE.Click

    End Sub

    Private Sub C1_DETALLE_DoubleClick(sender As Object, e As EventArgs) Handles C1_DETALLE.DoubleClick
        Compras.Show()
        Compras.LLENAR_DATOS(Me.C1_DETALLE.Item(Me.C1_DETALLE.Row, COL_ID))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Me.C1_DETALLE.Row < 1 Then Exit Sub
            If Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_NUMERO) = "" Then Exit Sub
            Pagos.Tag = Me.C1_DETALLE.Item(Me.C1_DETALLE.Row, COL_ID)
            Pagos.TXT_DOC.Text = Me.C1_DETALLE.Item(Me.C1_DETALLE.Row, COL_NUMERO)
            Pagos.GroupBox3.Tag = Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_MONEDA)
            If Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_MONEDA) = "S" Then
                Pagos.TXT_SALDO.Text = FORMAT_DECIMALES(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_SALDO_S), 4)
                Pagos.GroupBox3.Text = "Deuda S/."
                Pagos.TXT_TOTAL.Text = FORMAT_DECIMALES(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_SALDO_S), 4)
            Else
                Pagos.TXT_SALDO.Text = FORMAT_DECIMALES(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_SALDO_D), 4)
                Pagos.GroupBox3.Text = "Deuda US$"
                Pagos.TXT_TOTAL.Text = FORMAT_DECIMALES(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_SALDO_D), 4)
            End If
            Pagos.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Cuentas_Pagar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        VER()
    End Sub
End Class