Public Class Cuadro_Reporte

    Dim COL_FECHA As Integer = 0
    Dim COL_PRODUCTO As Integer = 1
    Dim COL_PR_VENTA As Integer = 2
    Dim COL_PR_COMPRA As Integer = 3
    Dim COL_MARGEN As Integer = 4

    Dim COL_PORC As Integer = 5

    Dim COL_VTA_GALON As Integer = 6
    Dim COL_GANANCIA_IGV As Integer = 7
    Dim COL_GANANCIA_SIN_IGV As Integer = 8
    Dim COL_AJUSTE_CANT As Integer = 9
    Dim COL_AJUSTE_MONTO As Integer = 10

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
        Dim da As New SqlClient.SqlDataAdapter("CONSULTAR_CUADRO_REPORTE", CAD_CON)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@FI", SqlDbType.Char, 10)
        da.SelectCommand.Parameters("@FI").Value = Format(Me.DT_INI.Value, "yyyyMMdd")
        da.SelectCommand.Parameters.Add("@FF", SqlDbType.Char, 10)
        da.SelectCommand.Parameters("@FF").Value = Format(Me.DT_FIN.Value, "yyyyMMdd")
        da.SelectCommand.Parameters.Add("@AARTCODI", SqlDbType.Char, 15)
        da.SelectCommand.Parameters("@AARTCODI").Value = IIf(Me.TXT_ARTICULO.Text = "", "", Me.TXT_ARTICULO.Tag)
        da.Fill(dt)
        DBLISTAR.DataSource = dt

        TOTALES()
        ''
        DBLISTAR.Cols(COL_MARGEN).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_PR_COMPRA).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_GANANCIA_IGV).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_GANANCIA_SIN_IGV).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_PR_VENTA).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_PORC).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_VTA_GALON).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_AJUSTE_CANT).Format = "###,###,###.0000"
        DBLISTAR.Cols(COL_AJUSTE_MONTO).Format = "###,###,###.0000"
        DBLISTAR.AutoSizeCols()

    End Sub

    Sub TOTALES()
        'Dim OBJFUNC As New ClSFunciones
        Dim TOTAL_S As Double = 0
        Dim TOTAL_INC_IGV As Double = 0
        Dim TOTAL_INC_IGV_AJUSTE As Double = 0
        Dim F As Integer
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            TOTAL_S = TOTAL_S + Me.DBLISTAR.Item(F, COL_GANANCIA_SIN_IGV)
            TOTAL_INC_IGV = TOTAL_INC_IGV + Me.DBLISTAR.Item(F, COL_GANANCIA_IGV)
            TOTAL_INC_IGV_AJUSTE = TOTAL_INC_IGV_AJUSTE + Me.DBLISTAR.Item(F, COL_GANANCIA_IGV) + Me.DBLISTAR.Item(F, COL_AJUSTE_MONTO)
        Next
        Me.LBL_TOTAL_S_IGV.Text = FORMAT_DECIMALES(TOTAL_S, 4)
        Me.LBL_TOTAL_INC_IGV.Text = FORMAT_DECIMALES(TOTAL_INC_IGV, 4)
        Me.LBL_TOTAL_INC_IGV_AJUSTE.Text = FORMAT_DECIMALES(TOTAL_INC_IGV_AJUSTE, 4)
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


    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DT_INI_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_INI.ValueChanged

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub DT_FIN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FIN.ValueChanged

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub LBL_TOTAL_S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_TOTAL_S_IGV.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click
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
        With BusquedaMaestra
            .ACT = "Mant_Articulos"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_ARTICULO.Tag = .GrecibeColumnaID
                Me.TXT_ARTICULO.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub TXT_ARTICULO_TextChanged(sender As Object, e As EventArgs) Handles TXT_ARTICULO.TextChanged

    End Sub

    Private Sub TXT_ARTICULO_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_ARTICULO.KeyUp
        If e.KeyCode = Keys.Delete Then
            TXT_ARTICULO.Clear()
        End If
    End Sub
End Class