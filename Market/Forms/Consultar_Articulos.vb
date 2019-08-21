Public Class Consultar_Articulos

    Private MintNumerodeFilas As Integer
    Private MArrayDeBusqueda As Object
    Private MintItemInicio As Integer

    Public GrecibeColumnaID As String = ""
    Public GrecibeColumnaOpcional As String = ""
    Public GrecibeColumnaOpcional2 As String = ""
    Public GrecibeColumnaOpcional3 As String = ""
    Public GrecibeColumnaOpcional4 As String = ""
    Public GrecibeColumnaOpcional5 As String = ""
    ''FORMULARIO ACTUAL
    Public PROV As String
    Public ACT As String
    Public BUSQ As String
    Public TIPO As Integer
    Public FECHA As Date
    Public TURNO As Integer
    Public COD_DOC As String
    Public COD_CLIE As String
    Public PRECIO As Double
    ''
    Public COD_FAMILIA As String = ""
    Public COD_SUBFAM As String = ""
    ''PARAMETRO
    Public STATINI As Integer

    Dim COL_COD As Integer = 0
    Dim COL_COD2 As Integer = 1
    Dim COL_DESC As Integer = 2
    Dim COL_MARCA As Integer = 3
    Dim COL_MEDIDA As Integer = 4
    Dim COL_MON As Integer = 5
    Dim COL_STOCK As Integer = 6
    Dim COL_COSTO As Integer = 7
    Dim COL_ESTADO As Integer = 8

    Private Sub Consultar_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 1 To MintNumerodeFilas
            Me.CmbCriterioBusqueda.Items.Add(MArrayDeBusqueda(i, 2))
        Next
        Me.CmbCriterioBusqueda.SelectedIndex = MintItemInicio - 1

        LLENAR_COMBO(Me.Combo_FAMILIA, "select COD_FAMILIA,DESC_FAMILIA from FAMILIA where STAT_FAMILIA=0 order by COD_FAMILIA", "DESC_FAMILIA", "COD_FAMILIA", CAD_CON)
        Me.Combo_FAMILIA.SelectedValue = -1
        'CARGAR_DATOS()
        'If ACT = "Mant_Articulos_P" Then
        '    OBJTPRECIOS.LISTAR_TPRECIOS_VEND(Me.Combo_Precio, GUSERID)
        '    Me.Combo_Precio.SelectedIndex = 0
        'Else
        '    OBJTPRECIOS.LISTAR_TPRECIOS(Me.Combo_Precio)
        'End If
        If COD_FAMILIA <> "" Then
            Me.Combo_FAMILIA.SelectedValue = COD_FAMILIA
            Combo_FAMILIA_SelectedIndexChanged(Combo_FAMILIA, Nothing)
        End If
        If COD_SUBFAM <> "" Then Me.COMBO_SUBF.SelectedValue = COD_SUBFAM
        Me.TxtDatoBuscado.Focus()
        Me.TxtDatoBuscado.Select()

    End Sub
    Sub CARGAR_COMBO(ByVal IArrayBusqueda As Object, ByVal IintFila As Integer, ByVal IintColumnaInicio As Integer)
        MArrayDeBusqueda = IArrayBusqueda
        MintNumerodeFilas = IintFila
        MintItemInicio = IintColumnaInicio
    End Sub
    Private Sub CARGAR_DATOS()
        Try
            If ACT = Nothing Then Exit Sub
            Dim dt As New DataTable
            Dim F As Integer
            Dim PROC As String = ""
            Dim CRITERIOS As String = ""

            PROC = "LISTAR_PRODUCTOS"

            Dim da As New SqlClient.SqlDataAdapter(PROC, CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@CADENA", SqlDbType.VarChar, 250)
            da.SelectCommand.Parameters("@CADENA").Value = Me.TxtDatoBuscado.Text.Trim
            da.SelectCommand.Parameters.Add("@CAMPO", SqlDbType.VarChar, 250)
            da.SelectCommand.Parameters("@CAMPO").Value = MArrayDeBusqueda(Me.CmbCriterioBusqueda.SelectedIndex + 1, 1)
            da.SelectCommand.Parameters.Add("@COD_FAMILIA", SqlDbType.VarChar, 3)
            da.SelectCommand.Parameters("@COD_FAMILIA").Value = IIf(Me.Combo_FAMILIA.Text = "", "", Me.Combo_FAMILIA.SelectedValue)
            da.SelectCommand.Parameters.Add("@COD_GRUPO", SqlDbType.VarChar, 3)
            da.SelectCommand.Parameters("@COD_GRUPO").Value = IIf(Me.COMBO_SUBF.Text = "", "", Me.COMBO_SUBF.SelectedValue)
            da.SelectCommand.Parameters.Add("@VER_SOLO_STOCK", SqlDbType.Int)
            da.SelectCommand.Parameters("@VER_SOLO_STOCK").Value = Me.CHK_SALDO.Checked

            da.SelectCommand.Parameters.Add("@SW", SqlDbType.Int)
            da.SelectCommand.Parameters("@SW").Value = STATINI
            da.Fill(dt)
            Me.DBLISTAR.DataSource = dt
            Me.DBLISTAR.Cols(COL_STOCK).Format = "###,###,###.00"
            Me.DBLISTAR.Cols(COL_COSTO).Format = "###,###,###.0000"
            DBLISTAR.AutoSizeCols()

            ''Me.DBLISTAR.Cols(COL_STOCK).Format = "###,###,###.0000"
            'Me.DBLISTAR.Cols(8).Format = "###,###,###.0000"
            'Me.DBLISTAR.AutoSizeCol(6)
            'Me.DBLISTAR.AutoSizeCol(8)
            Me.DBLISTAR.Cols(COL_COD2).Visible = False
            Me.DBLISTAR.Cols(COL_MARCA).Visible = False
            Me.DBLISTAR.Cols(COL_MON).Visible = False
            ' Me.DBLISTAR.Cols(2).Width = 50
            Me.DBLISTAR.Cols(COL_DESC).Width = 200
            'AGRUPAR()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TxtDatoBuscado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.DBLISTAR.Focus()
        End If
    End Sub

    Private Sub TxtDatoBuscado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDatoBuscado.KeyUp

    End Sub

    Private Sub TxtDatoBuscado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDatoBuscado.TextChanged

        CARGAR_DATOS()

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
        Try
            GrecibeColumnaID = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0)
            GrecibeColumnaOpcional = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 1)
            If UBound(MArrayDeBusqueda) >= 3 Then
                GrecibeColumnaOpcional2 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 2)
            End If
            If UBound(MArrayDeBusqueda) >= 4 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional3 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 3)
            End If
            If UBound(MArrayDeBusqueda) >= 5 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional4 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 4)
            End If
            If UBound(MArrayDeBusqueda) >= 6 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional5 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 5)
            End If
            ''
            ' PRECIO = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 6)
            ''

            Me.Close()
            'Me.Hide()



        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DBLISTAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DBLISTAR.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call DBLISTAR_DoubleClick(DBLISTAR, EventArgs.Empty)
            CARGAR_DATOS()
        End If
    End Sub



    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click
        ACTUALIZAR_STOCK()
        ''ACTUALIZAR_PRECIOS()
    End Sub

    Private Sub TXT_ALMACEN_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_PROV.KeyUp
        If e.KeyCode = Keys.Delete Then
            Me.TXT_PROV.Clear()
            CARGAR_DATOS()
        End If
    End Sub

    Private Sub TXT_ALMACEN_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles TXT_PROV.Layout

    End Sub

    Private Sub TXT_ALMACEN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PROV.TextChanged

    End Sub

    Private Sub DBLISTAR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBLISTAR.KeyUp
        ACTUALIZAR_STOCK()
        ''ACTUALIZAR_PRECIOS()
    End Sub
    Sub ACTUALIZAR_STOCK()
        If Me.DBLISTAR.Row < 0 Then Exit Sub
        ''STOCK ALMACEN
        Dim dt2 As New DataTable
        Dim da2 As New SqlClient.SqlDataAdapter("LISTAR_STOCK_ALMACEN", CN_NET)
        da2.SelectCommand.CommandType = CommandType.StoredProcedure
        da2.SelectCommand.Parameters.Add("@COD_ART", SqlDbType.VarChar, 20)
        da2.SelectCommand.Parameters("@COD_ART").Value = Me.DBLISTAR.Item(DBLISTAR.Row, 0)
        da2.Fill(dt2)
        Me.C1_ALMACEN.DataSource = dt2
        Me.C1_ALMACEN.Cols(1).Format = "###,###,###.00"
        Me.C1_ALMACEN.AutoSizeCols()
        'Me.C1_ALMACEN.Cols(0).Visible = False
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button_Almacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Almacen.Click
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
                Me.TXT_PROV.Tag = .GrecibeColumnaID
                Me.TXT_PROV.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With

    End Sub

    Private Sub Combo_TIPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CmbCriterioBusqueda.SelectedIndex + 1 = 0 Then Exit Sub
        CARGAR_DATOS()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try

            ''''''
            Me.DLG.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
            Me.DLG.FileName = ""
            Me.DLG.ShowDialog()
            If Len(Me.DLG.FileName) = 0 Then Exit Sub
            Me.DBLISTAR.SaveExcel(DLG.FileName, "Listado", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            MsgBox("Exportacion Completa", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub



    Private Sub TXT_MARCA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Combo_Precio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As Integer = Me.DBLISTAR.Rows.Count
        CARGAR_DATOS()
    End Sub



    Private Sub Combo_FAMILIA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Combo_FAMILIA.KeyUp
        If Me.Combo_FAMILIA.Text = "" Then CARGAR_DATOS()
    End Sub

    Private Sub Combo_FAMILIA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_FAMILIA.SelectedIndexChanged
        LLENAR_COMBO(COMBO_SUBF, "select * from GRUPO where STAT_GRUPO=0 order by DESC_GRUPO", "DESC_GRUPO", "COD_GRUPO", CAD_CON)
        ''Poblar_dbCbo(COMBO_SUBF, "select * from SUBFAMILIAS where COD_FAMILIA = '" & Me.Combo_FAMILIA.SelectedValue & "' AND STAT_SUBFAM=0 order by COD_SUBFAM", "COD_SUBFAM", "DESC_SUBFAM")
        Me.COMBO_SUBF.Text = ""
        CARGAR_DATOS()
    End Sub

    Private Sub COMBO_SUBF_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles COMBO_SUBF.KeyUp
        If Me.COMBO_SUBF.Text = "" Then CARGAR_DATOS()
    End Sub

    Private Sub COMBO_SUBF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMBO_SUBF.SelectedIndexChanged
        CARGAR_DATOS()
    End Sub


    Private Sub CHK_SALDO_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SALDO.CheckedChanged
        CARGAR_DATOS()
    End Sub
End Class