Public Class BusquedaMaestra

    Private MintNumerodeFilas As Integer
    Private MArrayDeBusqueda As Object
    Private MintItemInicio As Integer

    Public GrecibeColumnaID As String = ""
    Public GrecibeColumnaOpcional As String = ""
    Public GrecibeColumnaOpcional2 As String = ""
    Public GrecibeColumnaOpcional3 As String = ""
    Public GrecibeColumnaOpcional4 As String = ""
    Public GrecibeColumnaOpcional5 As String = ""
    Public GrecibeColumnaOpcional6 As String = ""
    Public GrecibeColumnaOpcional7 As String = ""
    Public GrecibeColumnaOpcional8 As String = ""
    Public GrecibeColumnaOpcional9 As String = ""
    Public GrecibeColumnaOpcional10 As String = ""
    Public GrecibeColumnaOpcional11 As String = ""
    Public GrecibeColumnaOpcional12 As String = ""
    Public GrecibeColumnaOpcional13 As String = ""
    ''FORMULARIO ACTUAL
    Public ACT As String
    Public BUSQ As String
    Public TIPO As Integer
    Public FECHA As Date
    Public TURNO As Integer
    Public COD_DOC As String
    Public COD_CLIE As String

    Public CODCTA As String
    ''PARAMETRO
    Public STATINI As Integer


    Private Sub BusquedaMaestra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 1 To MintNumerodeFilas
            Me.CmbCriterioBusqueda.Items.Add(MArrayDeBusqueda(i, 2))
        Next
        Me.CmbCriterioBusqueda.SelectedIndex = MintItemInicio - 1
        If TIPO = 1 Then
            CARGAR_DATOS_PROV()
        Else
            CARGAR_DATOS()
        End If
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
            Dim dt As New DataTable
            Dim PROC As String = ""
            Select Case ACT
                Case "Mant_Usuarios"
                    PROC = "LISTAR_USUARIOS"
                Case "Mant_Familias"
                    PROC = "LISTAR_FAMILIAS"
                Case "Mant_Grupos"
                    PROC = "LISTAR_GRUPOS"
                Case "Mant_Medidas"
                    PROC = "LISTAR_MEDIDAS"
                Case "Mant_Proveedores"
                    PROC = "LISTAR_PROVEEDORES"
                Case "Mant_Tprecio"
                    PROC = "LISTAR_TPRECIOS"
                Case "Mant_Articulos"
                    PROC = "LISTAR_ARTICULOS"
                Case "Mant_FPago"
                    PROC = "LISTAR_FPAGO"
                Case "Mant_Clientes"
                    PROC = "LISTAR_CLIENTES"
                Case "Cta_Cobrar"
                    PROC = "LISTAR_CLIENTES_CREDITO"
                Case "Mant_TMov"
                    PROC = "LISTAR_TMOV"
                Case "Mant_TC"
                    PROC = "LISTAR_TC"
                Case "Consultar_Articulos"
                    PROC = "LISTAR_ARTICULOS"
                Case "Consultar_Articulos_Prov"
                    PROC = "LISTAR_ARTICULOS_X_PROV"
                Case "Mant_PtoVta"
                    PROC = "LISTAR_PTOVTA"
                Case "Mant_Bancos"
                    PROC = "LISTAR_BANCOS"
                Case "Mant_Cobrador"
                    PROC = "LISTAR_COBRADOR"
                Case "Mant_Tarjetas"
                    PROC = "LISTAR_TARJETAS"
                Case "Ventas"
                    PROC = "LISTAR_ARTICULOS_VENTA"
                Case "Ventas_Documentos"
                    PROC = "VENTA_LISTAR_DOCUMENTOS"
                Case "Ventas_Documentos_R"
                    PROC = "VENTA_LISTAR_DOCUMENTOS"
                Case "Mant_PlanCtas"
                    PROC = "LISTAR_PLANCTAS"
                Case "Mant_PlanCtas_D"
                    PROC = "LISTAR_PLANCTAS_D"
                Case "Mant_Articulos_COMBO"
                    PROC = "LISTAR_ARTICULOS_COMBO"
                Case "Mant_Almacen"
                    PROC = "LISTAR_ALMACENES"
                Case "Mant_CtaBancos"
                    PROC = "LISTAR_CTA_BANCARIA"
                Case "Mant_TPago"
                    PROC = "LISTAR_TIPO_PAGO"
                Case "Mant_Conceptos"
                    PROC = "LISTAR_CONCEPTOS"
                Case "Mant_Otro"
                    PROC = "LISTAR_OTROS"
                Case "Mant_Conceptos_BANCO"
                    PROC = "LISTAR_CONCEPTOS_MOVB"
                Case "Mant_Comite_Detalle"
                    PROC = "LISTAR_COMITE_DETALLE"
                Case "Mant_Rubro"
                    PROC = "LISTAR_RUBROS"
            End Select
            Dim da As New SqlClient.SqlDataAdapter(PROC, CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@sw", SqlDbType.Int)
            da.SelectCommand.Parameters("@sw").Value = STATINI
            da.SelectCommand.Parameters.Add("@CADENA", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@CADENA").Value = Me.TxtDatoBuscado.Text.Trim
            da.SelectCommand.Parameters.Add("@CAMPO", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@CAMPO").Value = MArrayDeBusqueda(Me.CmbCriterioBusqueda.SelectedIndex + 1, 1)
            If ACT = "Mant_Conceptos_BANCO" Then
                da.SelectCommand.Parameters.Add("@T", SqlDbType.Char, 1)
                da.SelectCommand.Parameters("@T").Value = CODCTA
            End If
            If ACT = "Mant_PlanCtas_D" Then
                da.SelectCommand.Parameters.Add("@COD_PLANCTA", SqlDbType.Char, 4)
                da.SelectCommand.Parameters("@COD_PLANCTA").Value = COD_DOC
            End If
            If ACT = "Ventas_Documentos" Then
                da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@FECHA").Value = Format(FECHA, "dd/MM/yyyy")
                da.SelectCommand.Parameters.Add("@TERM", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@TERM").Value = SystemInformation.ComputerName
                da.SelectCommand.Parameters.Add("@TURNO", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@TURNO").Value = TURNO
                da.SelectCommand.Parameters.Add("@COD_DOC", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@COD_DOC").Value = COD_DOC
            End If
            If ACT = "Ventas_Documentos_R" Then
                da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@FECHA").Value = Format(FECHA, "dd/MM/yyyy")
                da.SelectCommand.Parameters.Add("@TERM", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@TERM").Value = COD_CLIE
                da.SelectCommand.Parameters.Add("@TURNO", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@TURNO").Value = TURNO
                da.SelectCommand.Parameters.Add("@COD_DOC", SqlDbType.VarChar)
                da.SelectCommand.Parameters("@COD_DOC").Value = COD_DOC
            End If
            If ACT = "Ventas" Then
                da.SelectCommand.Parameters.Add("@APTOTERM", SqlDbType.NVarChar, 30)
                da.SelectCommand.Parameters("@APTOTERM").Value = SystemInformation.ComputerName
            End If
            da.Fill(dt)
            Me.DBLISTAR.DataSource = dt
            DBLISTAR.AutoSizeCols()
            Select Case ACT
                Case "Mant_Usuarios"
                    'Me.DBLISTAR.Cols(3).Format = "###,###,###.00"
                    Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                Case "Mant_Proveedores"
                    Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(7).Width = 0
                Case "Mant_Clientes"
                    'Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(7).Width = 0
                Case "Cta_Cobrar"
                    'Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(7).Width = 0
                Case "Mant_Articulos"
                    Me.DBLISTAR.AutoSizeCol(1)
                    Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(7).Width = 0
                    Me.DBLISTAR.Cols(8).Width = 0
                    Me.DBLISTAR.Cols(9).Width = 0
                    Me.DBLISTAR.Cols(10).Width = 0
                    Me.DBLISTAR.Cols(11).Width = 0
                Case "Mant_TC"
                    Me.GroupBox1.Visible = False
                Case "Consultar_Articulos"
                    Me.DBLISTAR.AutoSizeCol(1)
                    Me.DBLISTAR.Cols(2).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(8).Width = 0
                    Me.DBLISTAR.Cols(9).Width = 0
                    Me.DBLISTAR.Cols(10).Width = 0
                    Me.DBLISTAR.Item(0, 7) = "Stock"
                Case "Consultar_Articulos_Prov"
                    Me.DBLISTAR.AutoSizeCol(1)
                    Me.DBLISTAR.Cols(2).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(8).Width = 0
                    Me.DBLISTAR.Cols(9).Width = 0
                    Me.DBLISTAR.Cols(10).Width = 0
                    Me.DBLISTAR.Item(0, 7) = "Stock"

            End Select
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtDatoBuscado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDatoBuscado.TextChanged
        If TIPO = 1 Then
            CARGAR_DATOS_PROV()
        Else
            CARGAR_DATOS()
        End If

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DBLISTAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
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
            If UBound(MArrayDeBusqueda) >= 7 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional6 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 6)
            End If
            If UBound(MArrayDeBusqueda) >= 8 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional7 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 7)
            End If
            If UBound(MArrayDeBusqueda) >= 9 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional8 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 8)
            End If
            If UBound(MArrayDeBusqueda) >= 10 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional9 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 9)
            End If
            If UBound(MArrayDeBusqueda) >= 11 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional10 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 10)
            End If
            If UBound(MArrayDeBusqueda) >= 12 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional11 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 11)
            End If
            If UBound(MArrayDeBusqueda) >= 13 Then   ' Si el Arreglo tiene 4 o mas columnas
                GrecibeColumnaOpcional12 = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 12)
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub DBLISTAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DBLISTAR.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call DBLISTAR_DoubleClick1(DBLISTAR, EventArgs.Empty)
        End If
    End Sub
    Private Sub CARGAR_DATOS_PROV()
        Try
            Dim dt As New DataTable
            Dim PROC As String = ""
            Select Case ACT
                Case "Consultar_Articulos_Prov"
                    PROC = "LISTAR_ARTICULOS_X_PROV"
            End Select
            Dim da As New SqlClient.SqlDataAdapter(PROC, CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@COD").Value = Me.TxtDatoBuscado.Tag
            da.SelectCommand.Parameters.Add("@CADENA", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@CADENA").Value = Me.TxtDatoBuscado.Text.Trim
            da.SelectCommand.Parameters.Add("@CAMPO", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@CAMPO").Value = MArrayDeBusqueda(Me.CmbCriterioBusqueda.SelectedIndex + 1, 1)
            da.Fill(dt)
            Me.DBLISTAR.DataSource = dt
            Select Case ACT
                   Case "Consultar_Articulos_Prov"
                    Me.DBLISTAR.AutoSizeCol(1)
                    Me.DBLISTAR.Cols(2).Width = 0
                    Me.DBLISTAR.Cols(4).Width = 0
                    Me.DBLISTAR.Cols(5).Width = 0
                    Me.DBLISTAR.Cols(3).Width = 0
                    Me.DBLISTAR.Cols(6).Width = 0
                    Me.DBLISTAR.Cols(8).Width = 0
                    Me.DBLISTAR.Cols(9).Width = 0
                    Me.DBLISTAR.Cols(10).Width = 0
                    Me.DBLISTAR.Cols(11).Width = 0
                    Me.DBLISTAR.Item(0, 7) = "Stock"
                    ''**Me.GroupBox1.Visible = False
            End Select
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub
End Class