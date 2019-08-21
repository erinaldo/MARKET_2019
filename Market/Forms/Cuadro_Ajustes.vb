Public Class Cuadro_Ajustes
    Dim COL_TIPO As Integer = 0
    Dim COL_CODIGO As Integer = 1
    Dim COL_FECHA As Integer = 2
    Dim COL_TMOVIMIENTO As Integer = 3
    Dim COL_OBSERV As Integer = 4
    Dim COL_TANQUE As Integer = 5
    Dim COL_CANT As Integer = 6
    Dim COL_PCOMPRA As Integer = 7
    Dim COL_TOTAL As Integer = 8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub Cuentas_Pagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim AÑO As String = Date.Now.Year


        Me.DT_INI.Value = "01/" + Format(Date.Now.Month, "00") + "/" + AÑO
        Me.DT_FIN.Value = UltimoDiaMes(Date.Now)
        ''
        VER()

    End Sub
    Sub VER()

        Dim CADENA As String = ""
        Dim i As Integer
        Dim CAD2 As String
        ''CONDICIONES
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("CONSULTAR_AJUSTES", CAD_CON)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@FI", SqlDbType.Char, 10)
        da.SelectCommand.Parameters("@FI").Value = Format(Me.DT_INI.Value, "yyyyMMdd")
        da.SelectCommand.Parameters.Add("@FF", SqlDbType.Char, 10)
        da.SelectCommand.Parameters("@FF").Value = Format(Me.DT_FIN.Value, "yyyyMMdd")
        da.SelectCommand.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        da.SelectCommand.Parameters("@COD_ART").Value = IIf(Me.TXT_TANQUE.Text = "", "", Me.TXT_TANQUE.Tag)
        da.Fill(dt)
        DBLISTAR.DataSource = dt

        TOTALES()
        ''
        If DBLISTAR.Rows.Count > 1 Then
            DBLISTAR.Cols(COL_CANT).Format = "###,###,###.0000"
            DBLISTAR.Cols(COL_PCOMPRA).Format = "###,###,###.0000"
            DBLISTAR.Cols(COL_TOTAL).Format = "###,###,###.0000"
            DBLISTAR.AutoSizeCols()
        End If
    End Sub

    Sub TOTALES()

        Dim TOTAL_S As Double = 0
        Dim TOTAL_CANT As Double = 0
        Dim F As Integer
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            If DBLISTAR.Item(F, COL_TIPO) = "I" Then
                TOTAL_S = TOTAL_S + Me.DBLISTAR.Item(F, COL_TOTAL)
                TOTAL_CANT = TOTAL_CANT + Me.DBLISTAR.Item(F, COL_CANT)
            Else
                TOTAL_S = TOTAL_S - Me.DBLISTAR.Item(F, COL_TOTAL)
                TOTAL_CANT = TOTAL_CANT - Me.DBLISTAR.Item(F, COL_CANT)
            End If
        Next
        Me.LBL_TOTAL_S.Text = FORMAT_DECIMALES(TOTAL_S, 4)
        Me.LBL_CANT.Text = FORMAT_DECIMALES(TOTAL_CANT, 4)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        VER()
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Me.SaveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
            Me.SaveFileDialog1.FileName = ""
            Me.SaveFileDialog1.ShowDialog()
            'dlg.ShowOpen()

            If Len(Me.SaveFileDialog1.FileName) = 0 Then Exit Sub

            Me.DBLISTAR.SaveExcel(Me.SaveFileDialog1.FileName, "CUADRO DE REPORTE", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        VER()
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "ARTICULOS.COD_ART"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_ART"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_ART"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_Articulos"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_TANQUE.Tag = .GrecibeColumnaID
                Me.TXT_TANQUE.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub TXT_ARTICULO_TextChanged(sender As Object, e As EventArgs) Handles TXT_TANQUE.TextChanged

    End Sub

    Private Sub TXT_ARTICULO_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_TANQUE.KeyUp
        If e.KeyCode = Keys.Delete Then
            TXT_TANQUE.Clear()
        End If
    End Sub
End Class