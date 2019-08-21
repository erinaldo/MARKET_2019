Public Class Kardex
    Dim OBJART As ClsArticulo

    Dim COL_ITEM As Integer = 0
    Dim COL_ID As Integer = 1
    Dim COL_FECHA As Integer = 2
    Dim COL_FECHALIQ As Integer = 3
    Dim COL_TDOC As Integer = 4
    Dim COL_NRODOC As Integer = 5
    Dim COL_HORA As Integer = 6
    Dim COL_CLIEPROV As Integer = 7
    Dim COL_ING_CANT As Integer = 8
    Dim COL_ING_PU As Integer = 9
    Dim COL_ING_TOT As Integer = 10
    Dim COL_SAL_CANT As Integer = 11
    Dim COL_SAL_PU As Integer = 12
    Dim COL_SAL_TOT As Integer = 13
    Dim COL_STOCK As Integer = 14
    Dim COL_COSTO As Integer = 15
    Dim COL_TOTAL As Integer = 16
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim F As Integer
            Dim SALDO_INI As Double = 0
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("IAM_KARDEX", CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@COD").Value = Me.TXT_COD.Tag
            da.SelectCommand.Parameters.Add("@FECHAINI", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@FECHAINI").Value = Format(Me.DT_INI.Value, "yyyyMMdd")
            da.SelectCommand.Parameters.Add("@FECHAFIN", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@FECHAFIN").Value = Format(Me.DT_FIN.Value, "yyyyMMdd")
            da.SelectCommand.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
            da.SelectCommand.Parameters("@COD_ALMACEN").Value = IIf(Me.TXT_ALMACEN.Text = "", 0, Me.TXT_ALMACEN.Tag)
            da.Fill(dt)
            Me.DBLISTAR.DataSource = dt
            ''SALDO INICIAL
            SALDO_INI = OBJART.SALDO_INI(Me.TXT_COD.Tag, Format(Me.DT_INI.Value, "yyyyMMdd"))
            ''CALCULOS
            For F = 1 To Me.DBLISTAR.Rows.Count - 1
                If F = 1 Then
                    Me.DBLISTAR.Item(F, COL_STOCK) = SALDO_INI + Me.DBLISTAR.Item(F, COL_ING_CANT) - Me.DBLISTAR.Item(F, COL_SAL_CANT)
                Else
                    Me.DBLISTAR.Item(F, COL_STOCK) = Me.DBLISTAR.Item(F - 1, COL_STOCK) + Me.DBLISTAR.Item(F, COL_ING_CANT) - Me.DBLISTAR.Item(F, COL_SAL_CANT)
                End If
                Me.DBLISTAR.Item(F, COL_TOTAL) = Me.DBLISTAR.Item(F, COL_STOCK) * NULO(Me.DBLISTAR.Item(F, COL_COSTO), "N")
            Next
            ''FORMATO
            'Me.DBLISTAR.Cols(0).Visible = False
            'Me.DBLISTAR.Cols(3).Visible = False
            Me.DBLISTAR.Cols(COL_ING_CANT).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_ING_PU).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_ING_TOT).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_SAL_CANT).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_SAL_PU).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_SAL_TOT).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_STOCK).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_COSTO).Format = "###,###,###.0000"
            Me.DBLISTAR.Cols(COL_TOTAL).Format = "###,###,###.0000"
            DBLISTAR.Cols(COL_HORA).Format = "hh:mm:ss tt"
            DBLISTAR.AutoSizeCols()
            ' Me.DBLISTAR.AutoResize = True
            DISEÑO()
            If Me.Tag = "N" Then
                Me.DBLISTAR.Cols(COL_ING_PU).Visible = False
                Me.DBLISTAR.Cols(COL_ING_TOT).Visible = False
                Me.DBLISTAR.Cols(COL_SAL_PU).Visible = False
                Me.DBLISTAR.Cols(COL_SAL_TOT).Visible = False
                Me.DBLISTAR.Cols(COL_TOTAL).Visible = False
                Me.DBLISTAR.Cols(COL_COSTO).Visible = False
            Else
                Me.DBLISTAR.Cols(COL_ING_PU).Visible = True
                Me.DBLISTAR.Cols(COL_ING_TOT).Visible = True
                Me.DBLISTAR.Cols(COL_SAL_PU).Visible = True
                Me.DBLISTAR.Cols(COL_SAL_TOT).Visible = True
                Me.DBLISTAR.Cols(COL_TOTAL).Visible = True
                Me.DBLISTAR.Cols(COL_COSTO).Visible = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub DISEÑO()
        If Me.DBLISTAR.Rows.Count = 1 Then Exit Sub
        Dim s As C1.Win.C1FlexGrid.CellStyle = Me.DBLISTAR.Styles("Yellow")

        If s Is Nothing Then
            s = Me.DBLISTAR.Styles.Add("Yellow")
            s.BackColor = Color.Yellow
        End If

        Dim rg As C1.Win.C1FlexGrid.CellRange = Me.DBLISTAR.GetCellRange(1, COL_STOCK, Me.DBLISTAR.Rows.Count - 1, COL_STOCK)
        Dim rg1 As C1.Win.C1FlexGrid.CellRange = Me.DBLISTAR.GetCellRange(1, COL_TOTAL, Me.DBLISTAR.Rows.Count - 1, COL_TOTAL)
        rg.Style = s
        rg1.Style = s
        DISEÑO_SERIE(DBLISTAR, 1, DBLISTAR.Rows.Count - 1, COL_ING_CANT, COL_ING_TOT)
        DISEÑO_SAL(DBLISTAR, 1, DBLISTAR.Rows.Count - 1, COL_ING_CANT, COL_ING_TOT)
    End Sub

    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda
        ''Try
        ''    Dim arraybusqueda(3, 3) As Object
        ''    arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
        ''    arraybusqueda(1, 2) = "Codigo"
        ''    arraybusqueda(1, 3) = 1500
        ''    arraybusqueda(2, 1) = "Desc_ART"
        ''    arraybusqueda(2, 2) = "Descripcion "
        ''    arraybusqueda(2, 3) = 3000
        ''    arraybusqueda(3, 1) = "Stock_ART"
        ''    arraybusqueda(3, 2) = "Stock "
        ''    arraybusqueda(3, 3) = 1500

        ''    ''
        ''    With BusquedaMaestra
        ''        .ACT = "Consultar_Articulos"
        ''        .STATINI = 0
        ''        .CARGAR_COMBO(arraybusqueda, 3, 2)
        ''        .TIPO = 0

        ''        .ShowDialog()

        ''        ''
        ''        If .GrecibeColumnaID <> "" Then
        ''            Me.TXT_COD.Tag = .GrecibeColumnaID
        ''            Me.TXT_COD.Text = .GrecibeColumnaOpcional
        ''            'Me.LblAnulado.Text = .GrecibeColumnaOpcional2

        ''            'Me.DBLISTAR.AutoSizeCol(0)
        ''            'Me.DBLISTAR.AutoSizeCol(1)
        ''            'Me.DBLISTAR.AutoSizeCol(2)
        ''        End If
        ''        .Close()
        ''    End With
        ''Catch ex As Exception
        ''    MsgBox(Err.Description)
        ''End Try
        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "ARTICULOS.DESC_ART"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_ART"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        ''
        With Consultar_Articulos
            .ACT = "Mant_Articulos"
            .PROV = ""
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_COD.Tag = .GrecibeColumnaID
                Me.TXT_COD.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJART = New ClsArticulo
    End Sub

    Private Sub TXT_ALMACEN_TextChanged(sender As Object, e As EventArgs) Handles TXT_ALMACEN.TextChanged

    End Sub

    Private Sub TXT_ALMACEN_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_ALMACEN.KeyUp
        If e.KeyCode = Keys.Delete Then
            TXT_ALMACEN.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_ALMACEN"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_ALMACEN"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_ALMACEN"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Almacen"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_ALMACEN.Tag = .GrecibeColumnaID
                Me.TXT_ALMACEN.Text = .GrecibeColumnaOpcional

            End If
            .Close()
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            ''''''
            Me.DLG.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
            Me.DLG.FileName = ""
            Me.DLG.ShowDialog()
            If Len(Me.DLG.FileName) = 0 Then Exit Sub
            Me.DBLISTAR.SaveExcel(DLG.FileName, "kardex", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            MsgBox("Exportacion Completa", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class