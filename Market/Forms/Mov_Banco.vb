Public Class Mov_Banco

    Dim OBJMOVB As ClsMovBanco
    Dim OBJBANCO As ClsBanco

    Dim COL_ID As Integer = 0
    Dim COL_N As Integer = 1
    Dim COL_ORIGEN As Integer = 2
    Dim COL_FECHA As Integer = 3
    Dim COL_FECHA_COBRO As Integer = 4
    Dim COL_FECHA_OPER As Integer = 5
    Dim COL_PROVEEDOR As Integer = 6
    Dim COL_TIPO_PAGO As Integer = 7
    Dim COL_REFERENCIA As Integer = 8

    Dim COL_OBSERV As Integer = 9
    Dim COL_TIPO As Integer = 10
    Dim COL_ORIGEN_ As Integer = 11
    Dim COL_INGRESO As Integer = 12
    Dim COL_SALIDA As Integer = 13
    Dim COL_CONTABLE As Integer = 14
    Dim COL_FR As Integer = 15
    Dim COL_DISPONIBLE As Integer = 16
    Dim COL_CA As Integer = 17


    Private Sub Mov_Banco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OBJMOVB = New ClsMovBanco
        OBJBANCO = New ClsBanco


        Dim AÑO As String = Date.Now.Year
        Me.DBLISTAR.Rows.Count = 1
        Me.DT_INI.Value = "01/" + Format(Date.Now.Month, "00") + "/" + AÑO
        Me.DT_FIN.Value = UltimoDiaMes(Date.Now)
        Me.Combo_FV.SelectedIndex = 0
        Me.Combo_FV.Visible = False

    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda
        Dim arraybusqueda(8, 3) As Object
        arraybusqueda(1, 1) = "ACTACODI"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "ACTADESC"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "AMONSIMB"
        arraybusqueda(3, 2) = "Moneda "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "ABANDESC"
        arraybusqueda(4, 2) = "Banco "
        arraybusqueda(4, 3) = 1500
        arraybusqueda(5, 1) = "ABANDESC"
        arraybusqueda(5, 2) = "Contable "
        arraybusqueda(5, 3) = 1500
        arraybusqueda(6, 1) = "ABANDESC"
        arraybusqueda(6, 2) = "Disponible "
        arraybusqueda(6, 3) = 1500
        arraybusqueda(7, 1) = "ABANDESC"
        arraybusqueda(7, 2) = "Bancario "
        arraybusqueda(7, 3) = 1500

        arraybusqueda(8, 1) = "ACTASTAT"
        arraybusqueda(8, 2) = "Estado "
        arraybusqueda(8, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_CtaBancos"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 8, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_BANCO.Tag = .GrecibeColumnaID
                TXT_BANCO.Text = .GrecibeColumnaOpcional
                Me.GroupBANCO.Text = .GrecibeColumnaOpcional3
                LLENAR()
                'OBJCTABANCO.BUSCAR(OBJCONN.Conexion(CAD_CON))
                'ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub

    Sub LLENAR()
        Dim SQL As String
        If Me.TXT_BANCO.Text = "" Then Exit Sub
        ''BUSCAR SALDO
        OBJMOVB.CodBanco = Me.TXT_BANCO.Tag
        If Me.OPT_VENC.Checked = True Then
            ''OBJMOVB.LLENAR_MOVIMIENTOS_FCOBRO(Me.TXT_BANCO.Tag, Strings.Left(Me.Combo_FV.Text, 1), Format(Me.DT_INI.Value, "yyyyMMdd"), Format(Me.DT_FIN.Value, "yyyyMMdd"), Me.DBLISTAR)
            SQL = "LLENAR_CHEQUES " & Me.TXT_BANCO.Tag & ",'" & Strings.Left(Me.Combo_FV.Text, 1) & "','" & Format(Me.DT_INI.Value, "yyyyMMdd") & "','" & Format(Me.DT_FIN.Value, "yyyyMMdd") & "'"
            LLENAR_GRID(DBLISTAR, SQL, CAD_CON)
            Me.TXT_SALDO_G.Text = 0
            Me.TXT_SALDO_L.Text = 0
            Me.TXT_SALDO_O.Text = 0
        Else
            Me.TXT_SALDO_G.Visible = True
            OBJMOVB.SALDO_INI(IIf(Me.OPT_GIRO.Checked = True, "G", "O"), Format(Me.DT_INI.Value, "yyyyMMdd"), Me.TXT_SALDO_G, Me.TXT_SALDO_O, Me.TXT_SALDO_L, CN_NET)
            ''OBJMOVB.LLENAR_MOVIMIENTOS(Me.TXT_BANCO.Tag, IIf(Me.OPT_GIRO.Checked = True, "G", "O"), Format(Me.DT_INI.Value, "yyyyMMdd"), Format(Me.DT_FIN.Value, "yyyyMMdd"), Me.DBLISTAR)
            ''SQL = "LLENAR_MOV_BANCO " & Me.TXT_BANCO.Tag & ",'" & IIf(Me.OPT_GIRO.Checked = True, "G", "O") & "','" & Format(Me.DT_INI.Value, "yyyyMMdd") & "','" & Format(Me.DT_FIN.Value, "yyyyMMdd") & "'"
            SQL = "LLENAR_MOV_BANCO " & Me.TXT_BANCO.Tag & ",'" & Format(Me.DT_INI.Value, "yyyyMMdd") & "','" & Format(Me.DT_FIN.Value, "yyyyMMdd") & "'"
            LLENAR_GRID(DBLISTAR, SQL, CAD_CON)
        End If
        OBJMOVB.CodBanco = TXT_BANCO.Tag
        OBJMOVB.SALDO_BANCOS(Me.TXT_MONTO_G, Me.TXT_MONTO_O, Me.TXT_MONTO_L, CN_NET)
        TOTAL()
    End Sub
    Sub TOTAL()
        Dim F As Integer
        Dim TOTAL As Double = 0
        Dim TOTAL_L As Double = 0
        Dim TOT_CONCEPTO As Double = 0

        TXT_PAGO_VARIOS.Clear()

        If Me.DBLISTAR.Rows.Count = 1 Then Exit Sub
        TOTAL = Val(Me.TXT_SALDO_G.Text)
        TOTAL_L = Val(Me.TXT_SALDO_L.Text)
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            ''
            If Me.DBLISTAR.Item(F, COL_TIPO_PAGO) = "Pago Varios" Then
                TOT_CONCEPTO = TOT_CONCEPTO + Me.DBLISTAR.Item(F, COL_SALIDA)
            End If
            ''
            TOTAL = TOTAL + COMAS(Me.DBLISTAR.Item(F, COL_INGRESO)) - COMAS(Me.DBLISTAR.Item(F, COL_SALIDA))
            If Me.DBLISTAR.Item(F, COL_ORIGEN) = "M" Then
                If Me.DBLISTAR.Item(F, COL_TIPO) = "I" Then
                    If NULO(Me.DBLISTAR.Item(F, COL_FECHA_OPER), "S") <> "" Then
                        TOTAL_L = TOTAL_L + COMAS(Me.DBLISTAR.Item(F, COL_INGRESO)) - COMAS(Me.DBLISTAR.Item(F, COL_SALIDA))
                    End If
                Else
                    If NULO(Me.DBLISTAR.Item(F, COL_FECHA_COBRO), "S") = "" Then
                        TOTAL_L = TOTAL_L + COMAS(Me.DBLISTAR.Item(F, COL_INGRESO)) - COMAS(Me.DBLISTAR.Item(F, COL_SALIDA))
                    Else
                        If NULO(Me.DBLISTAR.Item(F, COL_FECHA_COBRO), "S") <> "" And NULO(Me.DBLISTAR.Item(F, COL_FECHA_OPER), "S") <> "" Then
                            TOTAL_L = TOTAL_L + COMAS(Me.DBLISTAR.Item(F, COL_INGRESO)) - COMAS(Me.DBLISTAR.Item(F, COL_SALIDA))
                        End If
                    End If
                End If
            Else
                TOTAL_L = TOTAL_L + COMAS(Me.DBLISTAR.Item(F, COL_INGRESO)) - COMAS(Me.DBLISTAR.Item(F, COL_SALIDA))
            End If
            Me.DBLISTAR.Item(F, COL_CONTABLE) = TOTAL
            Me.DBLISTAR.Item(F, COL_DISPONIBLE) = TOTAL_L
            ''CARGO/ABONO
            If NULO(Me.DBLISTAR.Item(F, COL_FECHA_OPER), "S") <> "" Then
                If Me.DBLISTAR.Item(F, COL_INGRESO) > 0 Then
                    Me.DBLISTAR.Item(F, COL_CA) = "+"
                Else
                    Me.DBLISTAR.Item(F, COL_CA) = "-"
                End If
            End If
            DISEÑO_CA(Me.DBLISTAR, F, F, COL_CA, COL_CA)
        Next
        ''
        Me.TXT_PAGO_VARIOS.Text = Format(TOT_CONCEPTO, "###,###,##0.000")
        FORMATO()
    End Sub
    Sub FORMATO()
        With DBLISTAR
            .Cols(12).Format = "###,###,##0.000"
            .Cols(13).Format = "###,###,##0.000"
            .Cols(14).Format = "###,###,##0.000"
            .Cols(16).Format = "###,###,##0.000"
            .AutoSizeCols()
            .Cols(COL_ID).Visible = False
            .Cols(COL_N).Visible = False
            .Cols(10).Visible = False
            .Cols(11).Visible = False


        End With
    End Sub

    Private Sub Mov_Banco_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'If BUSCAR_PERMISO("5001") = True Then
        'Me.KeyPreview = False
        'Else
        ' Me.KeyPreview = True
        ' End If
        ''LLENAR()
    End Sub

    Private Sub DBLISTAR_Click(sender As Object, e As EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_KeyUp(sender As Object, e As KeyEventArgs) Handles DBLISTAR.KeyUp
        Movi_Banco.COD_BANCO = Me.TXT_BANCO.Tag
        If e.KeyCode = Keys.F2 Then
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub
            Movi_Banco.TIPO = "N"
            Movi_Banco.ID_DET = 0
            Movi_Banco.Tag = Me.TXT_BANCO.Tag
            Movi_Banco.ShowDialog()
        End If
        If DBLISTAR.Row < 1 Then Exit Sub
        Dim FILA As Double = Me.DBLISTAR.Item(Me.DBLISTAR.Row, COL_ID)
        OBJMOVB.Id = FILA
        If e.KeyCode = Keys.F3 Then
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "PFC" Then MsgBox("Este movimiento se origino por planilla de Fondo de Garantia, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "CD" Then MsgBox("Este movimiento se origino por planilla de Detraccion, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "C" Then MsgBox("Este movimiento se origino por cobranza, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "P" Then MsgBox("Este movimiento se origino por pagos, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "L" Then MsgBox("Este movimiento se origino por planilla, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "PLC" Then MsgBox("Este movimiento se origino por planilla de Cobranza, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "D" Then MsgBox("Este movimiento se origino por planilla de Detraccion, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub
            If MsgBox("Seguro de Eliminar???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            If OBJMOVB.ELIMINAR_MOVI_BANCO(CN_NET) = 0 Then LLENAR()
        End If
        If e.KeyCode = Keys.F4 Then
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "PLC" Then MsgBox("Este movimiento se origino por planilla de Cobranza, no se puede modificar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "PFC" Then MsgBox("Este movimiento se origino por planilla de Fondo de Garantia, no se puede modificar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "CD" Then MsgBox("Este movimiento se origino por planilla de Detraccion, no se puede modificar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "C" Then MsgBox("Este movimiento se origino por cobranza, no se puede modificar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "L" Then MsgBox("Este movimiento se origino por planilla, no se puede eliminar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "P" Then MsgBox("Este movimiento se origino por pagos, no se puede modificar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.DBLISTAR.Item(DBLISTAR.Row, COL_ORIGEN) = "D" Then MsgBox("Este movimiento se origino por planilla de Detraccion, no se puede modificar desde aqui", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub
            Movi_Banco.Show()
            Movi_Banco.TIPO = "M"
            Movi_Banco.ID_DET = Me.DBLISTAR.Item(Me.DBLISTAR.Row, COL_ID)
            Movi_Banco.LLENAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, COL_ID))
        End If
        If e.KeyCode = Keys.F5 Then
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub
            If NULO(Me.DBLISTAR.Item(DBLISTAR.Row, 5), "S") <> "" Then Me.DT_OPERACION.Value = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 5) Else Me.DT_OPERACION.Value = Date.Now
            Panel2.Visible = True
        End If
        LLENAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub
            With Impresion
                ''.FORM = "Rpte_Mov_Banco"
                ''.MODELO = Me.TXT_BANCO.Tag
                ''.CADENA = IIf(Me.OPT_GIRO.Checked = True, "G", "O")
                ''.PRECIO = Me.TXT_SALDO_G.Text
                ''.FI = Format(Me.DT_INI.Value, "yyyyMMdd")
                ''.FF = Format(Me.DT_FIN.Value, "yyyyMMdd")
                ''.TALLA = "Del : " & Format(Me.DT_INI.Value, "dd/MM/yyyy") & " Al  " & Format(Me.DT_FIN.Value, "dd/MM/yyyy")
                ''.TITULO = "Reporte de Movimientos de " & Me.TXT_BANCO.Text.Trim
                ''.Show()
            End With

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LLENAR()
        Me.Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim intvalor As Integer
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub

            'If Me.DBLISTAR.Item(Me.DBLISTAR.Row, 7) = "P" Then
            'intvalor = OBJMOVB.MANT_FECHA_OPERACION(Me.DBLISTAR.Item(DBLISTAR.Row, 0), Me.DBLISTAR.Item(DBLISTAR.Row, 1), "P", Me.DT_OPERACION.Value, "M")
            'Else
            intvalor = OBJMOVB.MANT_FECHA_OPERACION(Me.DBLISTAR.Item(DBLISTAR.Row, COL_ID), Me.DBLISTAR.Item(DBLISTAR.Row, COL_N), Me.DBLISTAR.Item(Me.DBLISTAR.Row, COL_ORIGEN_), Me.DT_OPERACION.Value, "M", CN_NET)
            'End If
            If intvalor = 0 Then MsgBox("Fecha de Operacion Grabado correctamente", MsgBoxStyle.Information) : Me.Panel2.Visible = False : LLENAR()
            If intvalor = 1 Then MsgBox("Error al grabar la Fecha de Operacion", MsgBoxStyle.Information) : Exit Sub
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim intvalor As Integer
            If Me.TXT_BANCO.Text = "" Then MsgBox("Seleccione el Banco", MsgBoxStyle.Information) : Exit Sub
            'If Me.DBLISTAR.Item(Me.DBLISTAR.Row, 8) = "P" Then
            'intvalor = OBJMOVB.MANT_FECHA_OPERACION(Me.DBLISTAR.Item(DBLISTAR.Row, 0), Me.DBLISTAR.Item(DBLISTAR.Row, 1), "P", Me.DT_OPERACION.Value, "E")
            'Else
            intvalor = OBJMOVB.MANT_FECHA_OPERACION(Me.DBLISTAR.Item(DBLISTAR.Row, COL_ID), Me.DBLISTAR.Item(DBLISTAR.Row, COL_N), Me.DBLISTAR.Item(Me.DBLISTAR.Row, COL_ORIGEN_), Me.DT_OPERACION.Value, "E", CN_NET)
            'End If
            If intvalor = 0 Then MsgBox("Fecha de Operacion Eliminado correctamente", MsgBoxStyle.Information) : Me.Panel2.Visible = False : LLENAR()
            If intvalor = 1 Then MsgBox("Error al eliminar la Fecha de Operacion", MsgBoxStyle.Information) : Exit Sub
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub OPT_VENC_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_VENC.CheckedChanged
        If OPT_VENC.Checked = True Then Me.Combo_FV.Visible = True Else Me.Combo_FV.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Me.SaveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"
            Me.SaveFileDialog1.FileName = ""
            Me.SaveFileDialog1.ShowDialog()
            'dlg.ShowOpen()

            If Len(Me.SaveFileDialog1.FileName) = 0 Then Exit Sub

            Me.DBLISTAR.SaveExcel(Me.SaveFileDialog1.FileName, "MOV BANCO", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DBLISTAR_DoubleClick(sender As Object, e As EventArgs) Handles DBLISTAR.DoubleClick
        ''Try
        ''    Dim CAD As String
        ''    Dim POS As Integer
        ''    Dim TIPO As String
        ''    Dim TIPOC As String
        ''    Dim ID As Double
        ''    POS = InStr(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 2), "-")
        ''    TIPO = Strings.Left(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 2), POS - 1)
        ''    Select Case TIPO
        ''        Case "P"
        ''            ''AVERIGUAMOS SI ES COMPRA O CARGO
        ''            Dim FORM As New Compras
        ''            '*FORM.VER = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0)
        ''            FORM.ShowDialog()
        ''        Case "C"
        ''            '*Dim FORM As New VentasN
        ''            '*Form.VER = Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0)
        ''            '*FORM.ShowDialog()
        ''    End Select
        ''Catch ex As Exception
        ''    MsgBox(Err.Description)
        ''End Try
    End Sub
End Class