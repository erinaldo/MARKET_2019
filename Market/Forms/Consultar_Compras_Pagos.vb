Public Class Consultar_Compras_Pagos
    Dim OBJCONFIG As ClsConfig

    Dim COL_NRO As Integer = 0
    Dim COL_CODIGO As Integer = 1
    Dim COL_PROVEEDOR As Integer = 2
    Dim COL_FECHA As Integer = 3
    Dim COL_ARTICULO As Integer = 4
    Dim COL_CANTIDAD As Integer = 5
    Dim COL_PU As Integer = 6
    Dim COL_TOTAL As Integer = 7
    Dim COL_PAGO As Integer = 8
    Dim COL_TIPO As Integer = 9

    Private Sub Consultar_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCONFIG = New ClsConfig

        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
        Me.Combo_TIPO.SelectedIndex = 0
        VER()
        ''
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        VER()
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub
    Sub VER()
        Dim TIPO As String = ""
        If Me.Combo_TIPO.SelectedIndex > 0 Then
            TIPO = Strings.Left(Combo_TIPO.Text, 1)
        End If
        LLENAR_GRID(Me.C1_DETALLE, "CONSULTAR_COMPRAS_PAGOS '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & IIf(Me.TXT_PROVEEDOR.Text = "", "", Me.TXT_PROVEEDOR.Tag) & "','" & TIPO & "'", CAD_CON)
        TOTALES()
        DISEÑO()

    End Sub
    Sub TOTALES()
        With C1_DETALLE
            .Redraw = False
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            .Tree.Column = COL_NRO
            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData

            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, -1, GFormatodeNumero(COL_TOTAL, 2), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, -1, GFormatodeNumero(COL_PAGO, 2), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, COL_NRO, COL_NRO, COL_TOTAL, "SubTotal")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, COL_NRO, COL_NRO, COL_PAGO, "SubTotal")
            ''.Tree.Show(COL_NRO)

            .Redraw = True
        End With
    End Sub
    Sub DISEÑO()
        Dim F As Integer

        C1_DETALLE.Cols(COL_TOTAL).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_CANTIDAD).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_PU).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_PAGO).Format = "###,###,###.00"
        C1_DETALLE.AutoSizeCols()

        For F = 1 To C1_DETALLE.Rows.Count - 1
            If C1_DETALLE.Item(F, COL_TIPO) = "P" Then
                DISEÑO_SERIE(C1_DETALLE, F, F, COL_CODIGO, COL_TIPO)
            End If
        Next
        C1_DETALLE.Cols(COL_TIPO).Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click
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
                Me.TXT_PROVEEDOR.Tag = .GrecibeColumnaID
                Me.TXT_PROVEEDOR.Text = .GrecibeColumnaOpcional
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
End Class