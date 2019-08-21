Public Class Consultar_Utilidad
    Dim COL_CODIGO As Integer = 0
    Dim COL_DESCRIPCION As Integer = 1
    Dim COL_PU As Integer = 2
    Dim COL_COSTO As Integer = 3
    Dim COL_UTILIDAD As Integer = 4
    Dim COL_CANT As Integer = 5
    Dim COL_TOTUTIL As Integer = 6

    Private Sub Consultar_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
        VER()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        VER()
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub
    Sub VER()
        Dim CADENA As String = ""

        LLENAR_GRID(Me.C1_DETALLE, "CONSULTAR_UTILIDAD '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "'", CAD_CON)
        TOTALES()
        DISEÑO()
    End Sub
    Sub TOTALES()
        With C1_DETALLE
            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_TOTUTIL, 2), "Total")

        End With

    End Sub
    Sub DISEÑO()
        C1_DETALLE.Cols(COL_TOTUTIL).Format = "###,###,###.00"
        C1_DETALLE.AutoSizeCols()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
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