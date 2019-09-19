Imports System.ComponentModel
Imports System.Drawing.Printing
Imports C1.Win.C1FlexGrid

Public Class Consultar_Ventas
    Dim OBJCONFIG As ClsConfig

    ' Dim ORIG As String
    Dim MlonCorrelativo As Double

    Dim COL_ORIGEN As Integer = 0
    Dim COL_COD_DOC As Integer = 1
    Dim COL_NUMERO As Integer = 2
    Dim COL_FECHA As Integer = 3
    Dim COL_FECHA_PROCESO As Integer = 4
    Dim COL_RUC As Integer = 5
    Dim COL_CLIENTE As Integer = 6
    Dim COL_DESCUENTO As Integer = 7
    Dim COL_SUBTOTAL As Integer = 8
    Dim COL_IGV As Integer = 9
    Dim COL_TOTAL As Integer = 10
    Dim COL_HORA_REGISTRO As Integer = 11
    Dim COL_USUARIO As Integer = 12
    Dim COL_PTOVTA As Integer = 13
    Dim COL_TURNO As Integer = 14
    Dim COL_ESTADO As Integer = 15
    Dim COL_FELECTRONICA As Integer = 16


    Dim COL_DET_ORIGEN As Integer = 0
    Dim COL_DET_COD_DOC As Integer = 1
    Dim COL_DET_NUMERO As Integer = 2
    Dim COL_DET_FECHA As Integer = 3
    Dim COL_DET_RUC As Integer = 4
    Dim COL_DET_CLIENTE As Integer = 5
    Dim COL_DET_TIPO_ARTICULO As Integer = 6
    Dim COL_DET_CANT As Integer = 7
    Dim COL_DET_PU As Integer = 8
    Dim COL_DET_TOTAL As Integer = 9
    Dim COL_DET_ORDEN As Integer = 10
    Dim COL_DET_VALE As Integer = 11
    Dim COL_DET_TIPOREF As Integer = 12
    Dim COL_DET_DOCREF As Integer = 13
    Dim COL_DET_NCREDITO As Integer = 14
    Dim COL_DET_ESTADO As Integer = 15
    Dim COL_DET_HORA_REGISTRO As Integer = 16
    Dim COL_DET_FECHANCREDITO As Integer = 17
    Dim COL_DET_CARA As Integer = 18
    Dim COL_DET_LIQ As Integer = 19
    Dim COL_DET_FECHA_PROCESO As Integer = 20
    Dim COL_DET_USUARIO As Integer = 21
    Dim COL_DET_PTOVTA As Integer = 22
    Dim COL_DET_TURNO As Integer = 23
    Dim COL_DET_SERIE As Integer = 24
    Dim COL_DET_FELECTRONICA As Integer = 25
    Dim COL_DET_CODIGO As Integer = 26
    Dim COL_DET_ARTICULO As Integer = 27
    Dim COL_DET_SUBTOTAL As Integer = 28
    Dim COL_DET_IGV As Integer = 29

    Dim COL_LIQUIDACION_CODIGO As Integer = 0
    Dim COL_LIQUIDACION_FECHA As Integer = 1

    Dim COL_CAJA_COD As Integer = 1
    Dim COL_CAJA_TIPO As Integer = 2

    Public PAGO_SOLES As Double
    Public PAGO_DOLARES As Double
    Public PAGO_VUELTO As Double

    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean

    Private Sub Consultar_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCONFIG = New ClsConfig
        PrintDocument1.PrintController = New StandardPrintController()

        LLENAR_COMBO(Me.LIST_TIPO_DOC, "EXEC LISTAR_TIPO_DOC 'V'", "DESCRIPCION", "CODIGO", CAD_CON)
        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
        Me.Combo_TIPO.SelectedIndex = 0
        Me.Combo_FPAGO.SelectedIndex = 0
        LLENAR_COMBO(Me.Combo_PTOVTA, "SELECT '' as APTOCODI,'Todo' as APTOTERM union all SELECT APTOCODI, APTOTERM FROM PtoVta WHERE (APTOSTAT = 0)", "APTOTERM", "APTOCODI", CAD_CON)
        Dim I As Integer
        For I = 0 To LIST_TIPO_DOC.Items.Count - 1
            LIST_TIPO_DOC.SetSelected(I, True)
        Next I
        VER()
        ''
        If SISTEMA_FELECTRONICA = "S" Or SISTEMA_ITALO = "S" Then
            Me.Button9.Visible = True
        Else
            Me.Button9.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        VER()
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub
    Sub VER()

        Dim CADENA As String = ""
        Dim i As Integer
        Dim CAD2 As String
        Dim TIPO As String
        ''CONDICIONES
        ''TURNO
        If Val(Me.TXT_TURNO.Text) <> 0 Then
            CADENA = CADENA + " AND VENTACAB.TURNO=" & Val(Me.TXT_TURNO.Text) & ""
        End If
        ''NRO DOCUMENTO
        If Me.TXT_NRO_DOC.Text.Trim <> "" Then
            CADENA = CADENA + " AND VENTACAB.NRODOCU=" & Me.TXT_NRO_DOC.Text & ""
        End If
        ''CLIENTE
        If Me.TXT_CLIENTE.Text.Trim <> "" Then
            CADENA = CADENA + " AND VENTACAB.COD_CLIENTE=" & Me.TXT_CLIENTE.Tag & ""
        End If
        ''' 
        ''TIPO
        If Me.Combo_TIPO.SelectedIndex = 1 Then CADENA = CADENA + " AND (VENTACAB.STAT_VENTA=0) "
        If Me.Combo_TIPO.SelectedIndex = 2 Then CADENA = CADENA + " AND (VENTACAB.STAT_VENTA<>0) "
        ''PTOVTA
        If Me.OPT_LISTAR_DOC.Checked Then
            If Me.Combo_PTOVTA.SelectedValue <> "" Then
                CADENA = CADENA + " AND VENTACAB.NROPTOVTA=''" & Me.Combo_PTOVTA.SelectedValue & "''"
            End If
        End If
        If Me.OPT_LISTAR_CAJA.Checked Then
            If Me.Combo_PTOVTA.SelectedValue <> "" Then
                CADENA = CADENA + " AND NROPTOVTA=''" & Me.Combo_PTOVTA.SelectedValue & "''"
            End If
        End If

        ''USER
        If Me.OPT_LISTAR_DOC.Checked Then
            If Me.TXT_USER.Text <> "" Then
                CADENA = CADENA + " AND VENTACAB.COD_USER=''" & Me.TXT_USER.Tag & "''"
            End If
        End If
        If Me.OPT_LISTAR_CAJA.Checked Then
            If Me.TXT_USER.Text <> "" Then
                CADENA = CADENA + " AND COD_USER=''" & Me.TXT_USER.Tag & "''"
            End If
        End If

        ''FORMA DE PAGO
        If Me.OPT_FECHA_PROCESO.Checked Then
            If Me.Combo_FPAGO.SelectedIndex = 1 Then CADENA = CADENA + " AND VENTACAB.NRODOCU NOT IN (SELECT VC.NRODOCU FROM VENTACAB VC INNER JOIN VENTATARJ ON VC.COD_DOC = VENTATARJ.COD_DOC AND VC.NRODOCU = VENTATARJ.NRODOCU WHERE VC.FECPROCESO BETWEEN ''" & Format(DT_INI.Value, "yyyyMMdd") & "'' AND ''" & Format(DT_FIN.Value, "yyyyMMdd") & "'' AND VC.COD_DOC=VENTACAB.COD_DOC) "
            If Me.Combo_FPAGO.SelectedIndex = 2 Then CADENA = CADENA + " AND VENTACAB.NRODOCU IN (SELECT VC.NRODOCU FROM VENTACAB VC INNER JOIN VENTATARJ ON VC.COD_DOC = VENTATARJ.COD_DOC AND VC.NRODOCU = VENTATARJ.NRODOCU WHERE VC.FECPROCESO BETWEEN ''" & Format(DT_INI.Value, "yyyyMMdd") & "'' AND ''" & Format(DT_FIN.Value, "yyyyMMdd") & "'' AND VC.COD_DOC=VENTACAB.COD_DOC) "
        Else
            If Me.Combo_FPAGO.SelectedIndex = 1 Then CADENA = CADENA + " AND VENTACAB.NRODOCU NOT IN (SELECT VC.NRODOCU FROM VENTACAB VC INNER JOIN VENTATARJ ON VC.COD_DOC = VENTATARJ.COD_DOC AND VC.NRODOCU = VENTATARJ.NRODOCU WHERE VC.FECHA_VENTA BETWEEN ''" & Format(DT_INI.Value, "yyyyMMdd") & "'' AND ''" & Format(DT_FIN.Value, "yyyyMMdd") & "'' AND VC.COD_DOC=VENTACAB.COD_DOC) "
            If Me.Combo_FPAGO.SelectedIndex = 2 Then CADENA = CADENA + " AND VENTACAB.NRODOCU IN (SELECT VC.NRODOCU FROM VENTACAB VC INNER JOIN VENTATARJ ON VC.COD_DOC = VENTATARJ.COD_DOC AND VC.NRODOCU = VENTATARJ.NRODOCU WHERE VC.FECHA_VENTA BETWEEN ''" & Format(DT_INI.Value, "yyyyMMdd") & "'' AND ''" & Format(DT_FIN.Value, "yyyyMMdd") & "'' AND VC.COD_DOC=VENTACAB.COD_DOC) "
        End If
        Select Case True
            Case Me.OPT_LISTAR_DOC.Checked
                ''TIPO
                TIPO = Obtener_matriz_Seleccionada(LIST_TIPO_DOC)
                If TIPO = "" Then MsgBox("Seleccione al menos un Tipo de Documento", MsgBoxStyle.Information) : Exit Sub
                LLENAR_GRID(Me.C1_DETALLE, "IAM_CONSULTAR_VENTAS '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & IIf(Me.OPT_FECHA_DOCUMENTO.Checked, "D", "P") & "','" & CADENA & "','" & TIPO & "','" & IIf(Me.CHK_DETALLE.Checked = True, "D", "R") & "'", CAD_CON)
            Case Me.OPT_LISTAR_CAJA.Checked
                LLENAR_GRID(Me.C1_DETALLE, "IAM_LISTAR_CAJA_ALL '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & CADENA & "'", CAD_CON)
            Case Me.OPT_LISTAR_LIQUIDACION.Checked
                ''OBJFUNC.LLENAR_GRID(Me.C1_DETALLE, "IAM_LISTAR_LIQUIDACION_ALL '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & CADENA & "'", CAD_CON)
        End Select


        ''ORDENES
        ''If Me.CHK_ORDEN.Checked = True Then CADENA = CADENA + " AND COMPRAS.OC_COMPRA<>''"
        ''''
        ''If Me.CHK_DETALLADO.Checked = False Then
        ''    OBJCOMPRA.CONSULTAR_COMPRAS(IIf(Me.OPT_GIRO.Checked, "E", "A"), Format(Me.DT_INI.Value, "yyyyMMdd"), Format(Me.DT_FIN.Value, "yyyyMMdd"), CADENA, Me.DBLISTAR)
        ''    TOTALES()
        ''    DISEÑO()
        ''Else
        ''    ''ALMACEN
        ''    If Me.TXT_ALMACEN.Text <> "" Then CADENA = CADENA + " AND DETALLE_COMPRAS.COD_ALMACEN=" & Me.TXT_ALMACEN.Tag & ""
        ''    ''MARCA
        ''    If Me.TXT_MARCA.Text <> "" Then CADENA = CADENA + " AND PRODUCTOS.COD_MARCA='" & Me.TXT_MARCA.Tag & "'"
        ''    ''FAMILIA
        ''    If Me.Combo_FAMILIA.Text <> "" Then CADENA = CADENA + " AND SUBFAMILIAS.COD_FAMILIA='" & Me.Combo_FAMILIA.SelectedValue & "'"
        ''    ''SUBFAMILIA
        ''    If Me.COMBO_SUBF.Text <> "" Then CADENA = CADENA + " AND DETALLE_COMPRAS.COD_SUBFAM='" & Me.COMBO_SUBF.SelectedValue & "'"
        ''    ''ARTICULO
        ''    If Me.TXT_ARTICULO.Text <> "" Then CADENA = CADENA + " AND DETALLE_COMPRAS.COD_PROD='" & Me.TXT_ARTICULO.Tag & "'"
        ''    ''PLACA
        ''    If Me.TXT_PLACA.Text <> "" Then CADENA = CADENA + " AND  (SELECT P.DESC_PLACA FROM OCPROVEEDOR_DETALLE OD INNER JOIN " &
        ''    " REQUERIMIENTOS R ON OD.COD_PEDIDO = R.COD_REQ AND OD.COD_EMP = R.COD_EMP INNER JOIN " &
        ''    " PLACAS P ON R.COD_PLACA = P.COD_PLACA where (OD.COD_EMP = Compras.COD_EMP) " &
        ''    " and OD.COD_OC=DETALLE_COMPRAS.COD_OC)='" & Me.TXT_PLACA.Text.Trim & "'"

        ''    OBJCOMPRA.CONSULTAR_COMPRAS_DETALLADO(IIf(Me.OPT_GIRO.Checked, "E", "A"), Format(Me.DT_INI.Value, "yyyyMMdd"), Format(Me.DT_FIN.Value, "yyyyMMdd"), CADENA, Me.DBLISTAR)
        ''    TOTALES_DET()
        ''    DISEÑO_DET()
        ''End If
        If OPT_LISTAR_LIQUIDACION.Checked = False Then
            TOTALES()
            DISEÑO()
        End If

    End Sub
    Sub TOTALES()
        With C1_DETALLE
            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            If Me.CHK_DETALLE.Checked = True Then
                .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_DET_TOTAL, 2), "Total")
            Else
                .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_TOTAL, 2), "Total")
            End If
            '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_CANT, 2), "Total")
            '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, COL_EECC_ABONO, "Total")
        End With

    End Sub
    Sub DISEÑO()
        If Me.CHK_DETALLE.Checked = True Then
            C1_DETALLE.Cols(COL_DET_HORA_REGISTRO).Format = "dd/MM/yyyy HH:mm:ss"
            C1_DETALLE.Cols(COL_DET_TOTAL).Format = "###,###,###.00"
            C1_DETALLE.AutoSizeCols()
            Me.C1_DETALLE.Cols(COL_DET_COD_DOC).Width = 0
            Me.C1_DETALLE.Cols(COL_DET_CLIENTE).Width = 200
        Else
            C1_DETALLE.Cols(COL_HORA_REGISTRO).Format = "dd/MM/yyyy HH:mm:ss"
            C1_DETALLE.Cols(COL_TOTAL).Format = "###,###,###.00"
            C1_DETALLE.AutoSizeCols()
            Me.C1_DETALLE.Cols(COL_COD_DOC).Width = 0
            Me.C1_DETALLE.Cols(COL_CLIENTE).Width = 200
        End If

        'Me.C1_DETALLE.Cols(COL_COD_CLIE).Width = 0
        'Me.C1_DETALLE.Cols(COL_COD_OPER).Width = 0
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
            ls_cadena = ls_cadena + CStr(Item("CODIGO")) + ""
        Next

        Obtener_matriz_Seleccionada = ls_cadena
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub picturebox1_Click(sender As Object, e As EventArgs) Handles picturebox1.Click

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "ACLICODI"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "ACLIDESC"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "ACLINRUC"
        arraybusqueda(3, 2) = "Ruc "
        arraybusqueda(3, 3) = 0
        arraybusqueda(4, 1) = "ACLISTAT"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500

        With BusquedaMaestra
            .ACT = "Mant_Clientes"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_CLIENTE.Tag = .GrecibeColumnaID
                TXT_CLIENTE.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With

    End Sub

    Private Sub TXT_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLIENTE.TextChanged

    End Sub

    Private Sub TXT_CLIENTE_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_CLIENTE.KeyUp
        If e.KeyCode = Keys.Delete Then
            Me.TXT_CLIENTE.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "AUSUCODI"
        arraybusqueda(1, 2) = "Usuario"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "AUSUDESC"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "AUSUSTAT"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "AUSUPASS"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 0
        With BusquedaMaestra
            .ACT = "Mant_Usuarios"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_USER.Tag = .GrecibeColumnaID
                TXT_USER.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub TXT_USER_TextChanged(sender As Object, e As EventArgs) Handles TXT_USER.TextChanged

    End Sub

    Private Sub TXT_USER_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_USER.KeyUp
        If e.KeyCode = Keys.Delete Then
            Me.TXT_USER.Clear()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ORIG = "P"
        ''
        If SISTEMA_FELECTRONICA = "S" Then
            Dim OBJPTOVTA As New ClsPtoVta
            ''
            If Me.OPT_LISTAR_LIQUIDACION.Checked Or Me.OPT_LISTAR_CAJA.Checked Then
                Dim OBJCONFIG As New ClsConfig
                OBJCONFIG.LISTAR_CONFIG_V2()
            Else
                'With OBJPTOVTA
                '    .PtoVtaCod = Combo_Impresora.SelectedValue
                '    .PtoVtaD_TDoc = C1_DETALLE.Item(C1_DETALLE.Row, COL_TIPO)
                '    .BUSCAR_DATOS_VENTA(OBJCONN.Conexion(CAD_CON))
                'End With
            End If

            PrintDocument1.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("002")
            Dim ps As PaperSize
            Try
                ps = PrintDocument1.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("002"))
                PrintDocument1.DefaultPageSettings.PaperSize = ps
            Catch ex As Exception

            End Try

            Try
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox("Esta Impresora no esta Configurada", MsgBoxStyle.Information) : Exit Sub
            End Try
        Else
            Select Case True
                Case Me.OPT_LISTAR_DOC.Checked
                    IMPRESION()
                Case Me.OPT_LISTAR_CAJA.Checked
                    IMPRESION_CAJA()
                Case Me.OPT_LISTAR_LIQUIDACION.Checked
                    IMPRESION_LIQUIDACION()
            End Select
        End If

    End Sub
    Private Function GetPaperSize(ByVal rawKind As Integer) As PaperSize
        Dim papersize As PaperSize = Nothing
        For Each item As PaperSize In PrintDocument1.PrinterSettings.PaperSizes
            If item.RawKind = rawKind Then
                papersize = item
                Exit For
            End If
        Next

        Return papersize
    End Function
    Sub IMPRESION_LIQUIDACION()
        Try
            Dim OBJCAJA As New ClsCaja
            Dim DT_VENTA As DataTable
            Dim OBJCONFIG As New ClsConfig
            Dim OBJPTOVTA As New ClsPtoVta
            Dim ps As PaperSize

            Dim CODIGO As Double = C1_DETALLE.Item(C1_DETALLE.Row, COL_LIQUIDACION_CODIGO)

            If Me.C1_DETALLE.Row < 1 Then Exit Sub

            OBJCONFIG.LISTAR_CONFIG()

            If CODIGO = 0 Then Exit Sub
            With OBJCAJA

                With OBJPTOVTA
                    '     .PtoVtaCod = Me.Combo_Impresora.SelectedValue
                    '                   .PtoVtaD_TDoc = OBJCONFIG.ConfigFact
                    '                  .BUSCAR_DATOS_VENTA(OBJCONN.Conexion(CAD_CON))
                End With

                If SISTEMA_FELECTRONICA = "N" Then
                    'Imprimir_Cierre_Turno(CODIGO, OBJPTOVTA.PtoVtaSerie, OBJPTOVTA.PtoVtaD_Dispositivo, OBJPTOVTA.PtoVta_Autorizacion, C1_DETALLE.Item(C1_DETALLE.Row, COL_LIQUIDACION_FECHA),
                    'IIf(ORIG = "P", OBJPTOVTA.PtoVtaD_User, ""), OBJPTOVTA.PtoVtaD_Clave)
                    Dim COD_PTO As String = BUSCAR_CAMPO("PTOVTA", "APTOCODI", "APTOTERM", SystemInformation.ComputerName, CN_NET)
                    IMPRIMIR_CIERRE_X(C1_DETALLE.Item(C1_DETALLE.Row, COL_LIQUIDACION_FECHA), COD_PTO, TURNO)
                Else
                    Dim COD_PTO As String = BUSCAR_CAMPO("PTOVTA", "APTOCODI", "APTOTERM", SystemInformation.ComputerName, CN_NET)
                    IMPRIMIR_CIERRE_X_TERMICA(C1_DETALLE.Item(C1_DETALLE.Row, COL_LIQUIDACION_FECHA), COD_PTO, TURNO, 1)
                End If
                ' End If
            End With

        Catch ex As Exception
            MsgBox(Err.Description)

        End Try

    End Sub
    Sub IMPRESION_CAJA()
        Try
            Dim OBJCAJA As New ClsCaja
            Dim DT_VENTA As DataTable
            Dim OBJCONFIG As New ClsConfig
            Dim OBJPTOVTA As New ClsPtoVta

            Dim CODIGO As Double = C1_DETALLE.Item(C1_DETALLE.Row, COL_CAJA_COD)
            Dim TIPO As String = C1_DETALLE.Item(C1_DETALLE.Row, COL_CAJA_TIPO)
            Dim ESTADO As String = C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO)

            If Me.C1_DETALLE.Row < 1 Then Exit Sub

            ''OBJCONFIG.LISTAR_CONFIG(OBJCONN.Conexion(CAD_CON))

            If CODIGO = 0 Then Exit Sub
            With OBJCAJA
                DT_VENTA = LLENAR_DATA_TABLE("BUSCAR_CAJA " & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_CAJA_COD) & "", CN_NET)
                Dim OFILA As DataRow
                For Each OFILA In DT_VENTA.Rows
                    If SISTEMA_FELECTRONICA = "N" Then
                        IMPRIMIR_CAJA_VENTA(OFILA.Item("TIPOMOVI"), OFILA.Item("MON_CAJA"), OFILA.Item("MONTO_CAJA"), NULO(OFILA.Item("OBSERV_CAJA"), "S"))
                    Else
                        IMPRIMIR_CAJA_VENTA_TERMICA(OFILA.Item("TIPOMOVI"), OFILA.Item("MON_CAJA"), OFILA.Item("MONTO_CAJA"), NULO(OFILA.Item("OBSERV_CAJA"), "S"), "")
                    End If

                Next

            End With

        Catch ex As Exception
            MsgBox(Err.Description)

        End Try

    End Sub

    Sub IMPRESION()
        Try
            Dim OBJVENTA As New ClsVenta
            Dim OBJCONFIG As New ClsConfig
            Dim OBJPTOVTA As New ClsPtoVta

            Dim DT_VENTA As DataTable
            Dim DOCU As String
            Dim TDOC As String
            Dim TDOC_ASP As Integer
            Dim MlonCorrelativo As Integer = 0
            Dim HASH As String

            If Me.C1_DETALLE.Row < 1 Then Exit Sub

            OBJCONFIG.LISTAR_CONFIG_V2()

            Dim INTVALOR As Integer
            Dim CODIGO As Double = C1_DETALLE.Item(C1_DETALLE.Row, COL_NUMERO)
            Dim TIPO As String = C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_DOC)
            Dim ESTADO As String = C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO)
            If CODIGO = 0 Then Exit Sub

            Select Case TIPO
                Case "001", "002"
                    With OBJVENTA
                        Select Case TIPO
                            Case "002"
                                DOCU = " BOL. "
                                TDOC = "B"
                            Case "001"
                                DOCU = " FACT."
                                TDOC = "F"
                        End Select
                        ''
                        DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_DOC) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NUMERO) & "'", CN_NET)
                        Dim OFILA As DataRow
                        For Each OFILA In DT_VENTA.Rows
                            'IMPRIMIR
                            IAM_PRINT = Me.Combo_PTOVTA.Text
                            If SISTEMA_FELECTRONICA = "S" Then
                                FIRMAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_DOC), C1_DETALLE.Item(C1_DETALLE.Row, COL_NUMERO), TDOC)

                                IMPRIMIR_TERMICA(OFILA.Item("COD_DOC"), 1, "", OFILA.Item("NRODOCU"), NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), NULO(OFILA.Item("DSCTO_VENTA"), "S"),
                                             OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"),
                                                 OFILA.Item("FECHA_VENTA"), OFILA.Item("FECHA_REG"),
                                                 OFILA.Item("ACLIDNI"), OFILA.Item("TCLIENTE"))
                            End If

                            If SISTEMA_FELECTRONICA = "N" And SISTEMA_ASPNET = "N" And SISTEMA_ITALO = "N" Then
                                IMPRIMIR(OFILA.Item("COD_DOC"), 1, "", OFILA.Item("NRODOCU"), NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), NULO(OFILA.Item("DSCTO_VENTA"), "N"), OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"), OFILA.Item("FECHA_VENTA"), OFILA.Item("FECHA_REG"), "")
                            End If
                            If SISTEMA_ASPNET = "S" Then
                                OBJCONFIG.LISTAR_CONFIG_V2()
                                Select Case OFILA.Item("COD_DOC")
                                    Case OBJCONFIG.Config_Factura
                                        DOCU = " FACT."
                                        TDOC = "F"
                                        TDOC_ASP = OBJCONFIG.Config_Factura
                                    Case OBJCONFIG.Config_Boleta
                                        DOCU = " BOL. "
                                        TDOC = "B"
                                        TDOC_ASP = OBJCONFIG.Config_Boleta
                                        ''Case OPT_OTROS.Checked
                                        ''    DOCU = "OTRO. "
                                        ''    TDOC = "R"
                                        ''    TDOC_ASP = OBJCONFIG.ConfigOtro
                                End Select
                                Call FactImprimir_ASPNET(OBJCONFIG.RucConfig, OBJCONFIG.DescConfig, OBJCONFIG.Config_Ubigeo, OBJCONFIG.DirConfig, OFILA.Item("ACLIMAIL"), C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO),
                                                                      DOCU, FormatoTicket(OFILA.Item("NRODOCU")),
                                                                   NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"),
                                                                   OFILA.Item("SUBTOT_VENTA"),
                                                                      0, OFILA.Item("IGV_VENTA"), 0, OFILA.Item("TOTAL_VENTA"), 0,
                                                                       0, 0, LLENAR_DATA_TABLE("EXEC VENTA_MOSTRAR_DETALLE '" & OFILA.Item("COD_DOC") & "'," & OFILA.Item("NRODOCU") & "", CN_NET), "01", OFILA.Item("COD_USER"),
                                                                   0, "", LLENAR_DATA_TABLE("EXEC TARJETA_MOSTRAR_DETALLE '" & OFILA.Item("COD_DOC") & "'," & OFILA.Item("NRODOCU") & "", CN_NET), 1, OFILA.Item("FECHA_VENTA"),
                                                                   OFILA.Item("ACLIDNI"), OFILA.Item("TCLIENTE"), OFILA.Item("FECHA_REG"))

                                BUSCAR_HASH(OFILA.Item("NRODOCU"), OFILA.Item("COD_DOC"), OBJCONFIG, 1)
                                'Exit Sub
                            End If

                            If SISTEMA_ITALO = "S" Then
                                ''
                                'If TIPO <> OBJCONFIG.ConfigOtro Then
                                HASH = FIRMAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD_DOC), C1_DETALLE.Item(C1_DETALLE.Row, COL_NUMERO), TDOC)
                                'End If
                                ''
                                ''ELIMINAMOS
                                System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "JPG")
                                System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "XML")
                                ''
                                ''
                                IMP_ASP_NET(CODIGO, TIPO, HASH, OBJCONFIG, 1, C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO))
                            End If

                        Next
                    End With

            End Select
            ''MOSTRAR()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub OPT_LISTAR_DOC_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_LISTAR_DOC.CheckedChanged
        VALIDAR_TDOC()
    End Sub
    Sub VALIDAR_TDOC()
        Select Case True
            Case Me.OPT_LISTAR_DOC.Checked
                LIST_TIPO_DOC.Enabled = True
            Case Else
                LIST_TIPO_DOC.Enabled = False
        End Select
    End Sub

    Private Sub OPT_LISTAR_CAJA_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_LISTAR_CAJA.CheckedChanged
        VALIDAR_TDOC()
    End Sub

    Private Sub OPT_LISTAR_LIQUIDACION_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_LISTAR_LIQUIDACION.CheckedChanged
        VALIDAR_TDOC()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'If OBJFUNC.BUSCAR_PERMISO("9103", GUSERID, OBJCONN.Conexion(CAD_CON)) = False Then MsgBox("No tiene permiso para usar esta opcion", MsgBoxStyle.Exclamation) : Exit Sub
        ORIG = "V"
        If SISTEMA_FELECTRONICA = "S" Then
            Dim OBJPTOVTA As New ClsPtoVta

            If Me.OPT_LISTAR_LIQUIDACION.Checked Or Me.OPT_LISTAR_CAJA.Checked Then
                Dim OBJCONFIG As New ClsConfig
                OBJCONFIG.LISTAR_CONFIG_V2()
                'OBJPTOVTA.PtoVtaCod = Combo_Impresora.SelectedValue
                'OBJPTOVTA.PtoVtaD_TDoc = OBJCONFIG.ConfigFact
                'OBJPTOVTA.BUSCAR_DATOS_VENTA(OBJCONN.Conexion(CAD_CON))
            Else
                With OBJPTOVTA
                    '.PtoVtaCod = Combo_Impresora.SelectedValue
                    '.PtoVtaD_TDoc = C1_DETALLE.Item(C1_DETALLE.Row, COL_TIPO)
                    '.BUSCAR_DATOS_VENTA(OBJCONN.Conexion(CAD_CON))
                End With
            End If

            PrintDocument1.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("002")
            Dim ps As PaperSize
            Try
                ps = PrintDocument1.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("002"))
                PrintDocument1.DefaultPageSettings.PaperSize = ps
            Catch ex As Exception

            End Try
            Try
                Dim PV As New PrintPreviewDialog
                PV.Document = PrintDocument1
                PV.PrintPreviewControl.AutoZoom = True
                PV.PrintPreviewControl.Zoom = 75 / 100.0F
                PV.ShowDialog()
                PV.Dispose()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        Else
            Select Case True
                Case Me.OPT_LISTAR_DOC.Checked
                    IMPRESION()
                Case Me.OPT_LISTAR_CAJA.Checked
                    IMPRESION_CAJA()
                Case Me.OPT_LISTAR_LIQUIDACION.Checked
                    IMPRESION_LIQUIDACION()
            End Select
            View_Doc.ShowDialog()

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            GRAFICO = e.Graphics

            ''IMPRESION()
            ''
            SALTAR_PAG = e
            Select Case True
                Case Me.OPT_LISTAR_DOC.Checked
                    Try
                        IMPRESION()
                    Catch ex As Exception
                        MsgBox("Esta Impresora no esta Configurada", MsgBoxStyle.Information) : Exit Sub
                    End Try

                Case Me.OPT_LISTAR_CAJA.Checked
                    IMPRESION_CAJA()
                Case Me.OPT_LISTAR_LIQUIDACION.Checked
                    IMPRESION_LIQUIDACION()
            End Select
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            If BUSCAR_PERMISO("1004") = False Then MsgBox("No tiene permiso para usar esta opcion", MsgBoxStyle.Information) : Exit Sub
            If MsgBox("Seguro de enviar a Sunat??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If Me.OPT_LISTAR_DOC.Checked = False Then Exit Sub
            Me.GroupPROGRESS.Visible = True
            CheckForIllegalCrossThreadCalls = False
            Me.BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim NOMB_FILE As String
        Dim OBJVENTA As New ClsVenta
        Dim F As Integer
        OBJCONFIG.LISTAR_CONFIG_V2()
        Me.ProgressBar1.Maximum = C1_DETALLE.Rows.Count - 1
        For F = 1 To Me.C1_DETALLE.Rows.Count - 1
            BackgroundWorker1.ReportProgress(F)
            ''OBJVENTA.Codigo = C1_DETALLE.Item(F, COL_CODIGO)
            If C1_DETALLE.Item(F, COL_FELECTRONICA) = 0 Then
                Select Case Strings.Left(C1_DETALLE.Item(F, COL_ORIGEN), 1).Trim
                    Case "F" 'FACTURA
                        If Me.C1_DETALLE.Item(F, COL_ESTADO) = "" Then
                            NOMB_FILE = OBJCONFIG.RucConfig + "-" + "01" + "-" + "F" + FormatoTicket(C1_DETALLE.Item(F, COL_NUMERO)) + ".TXT" ''Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 12) + ".TXT"
                            CREAR_FACTURA(NOMB_FILE, C1_DETALLE.Item(F, COL_COD_DOC), C1_DETALLE.Item(F, COL_NUMERO), OBJCONFIG.Config_Carpeta_Txt, "F")
                            OBJVENTA.IAM_ESTADO_FELECTRONICA(C1_DETALLE.Item(F, COL_COD_DOC), C1_DETALLE.Item(F, COL_NUMERO), 1)
                        End If
                    Case "B" 'BOLETA
                        NOMB_FILE = OBJCONFIG.RucConfig + "-" + "03" + "-" + "B" + FormatoTicket(C1_DETALLE.Item(F, COL_NUMERO)) + ".TXT" ''Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 12) + ".TXT"
                        CREAR_FACTURA(NOMB_FILE, C1_DETALLE.Item(F, COL_COD_DOC), C1_DETALLE.Item(F, COL_NUMERO), OBJCONFIG.Config_Carpeta_Txt, "B")
                        OBJVENTA.IAM_ESTADO_FELECTRONICA(C1_DETALLE.Item(F, COL_COD_DOC), C1_DETALLE.Item(F, COL_NUMERO), 1)
                End Select
            End If
        Next
    End Sub
    Function CREAR_FACTURA(ByVal NOMB_FILE As String, COD_DOC As String, ByVal NRODOC As Double, ByVal CONFIG_RUTA_TXT As String, ByVal TDOC As String) As Integer
        Dim OBJVENTA As New ClsVenta
        Dim file As System.IO.StreamWriter
        Dim MON As String
        Dim F As Integer
        Dim OTABLA As DataTable
        Dim DT As DataTable

        Dim OFILADET As DataRow
        DT = LLENAR_DATA_TABLE("EXEC IAM_GENERAR_TXT '" & COD_DOC & "'," & NRODOC & "", CN_NET)
        If DT.Rows.Count = 0 Then GoTo SALIR
        file = System.IO.File.CreateText(CONFIG_RUTA_TXT & NOMB_FILE)
        For Each OFILADET In DT.Rows

            file.WriteLine("[CODIGO ESTABLECIMIENTO]=" + OBJCONFIG.Config_CodEstablecimiento)
            file.WriteLine("[TIPO OPERACION CATALOGO 51]=" + OBJCONFIG.Config_Catalog51)
            file.WriteLine("[HORA DOC]=" + OFILADET.Item("HORAVENTA"))
            file.WriteLine("[MONTO PORC DESCUENTO]=" + "0")

            If OFILADET.Item("MONEDA") = "S" Then MON = "SOLES" Else MON = "DOLARES AMERICANOS"

            If OFILADET.Item("GRATUITA_VENTA") = True Then
                file.WriteLine("[MONTO VTAS GRABADAS]=" + "0")
                file.WriteLine("[MONTO VTAS INAFECTAS]=" + "0")
                file.WriteLine("[MONTO VTAS EXONERADAS]=" + "0")
                file.WriteLine("[MONTO VTAS OPER GRATUITAS]=" + CStr(OFILADET.Item("MONTO_GRATUITO_VENTA")))
                file.WriteLine("[MONTO VTAS SUBTOTAL]=" + "0")
                file.WriteLine("[MONTO VTAS PERCEPCIONES]=" + "0")
                file.WriteLine("[MONTO VTAS RETENCIONES]=" + "0")
                file.WriteLine("[MONTO VTAS DETRACCIONES]=" + "0")
                file.WriteLine("[MONTO VTAS BONIFICACIONES]=" + "0")
                file.WriteLine("[MONTO VTAS DESCUENTOS]=" + "0")
                file.WriteLine("[MONTO VTAS FISE]=" + "0")
                file.WriteLine("[MONTO LETRAS]=" + ImprimeTotalLetras(OFILADET.Item("MONTO_GRATUITO_VENTA"), MON))
            Else
                file.WriteLine("[MONTO VTAS GRABADAS]=" + CStr(OFILADET.Item("AMO1BRUTO")))
                file.WriteLine("[MONTO VTAS INAFECTAS]=" + "0")
                file.WriteLine("[MONTO VTAS EXONERADAS]=" + "0")
                file.WriteLine("[MONTO VTAS OPER GRATUITAS]=" + "0")
                file.WriteLine("[MONTO VTAS SUBTOTAL]=" + CStr(OFILADET.Item("AMO1BRUTO")))
                file.WriteLine("[MONTO VTAS PERCEPCIONES]=" + "0")
                file.WriteLine("[MONTO VTAS RETENCIONES]=" + "0")
                file.WriteLine("[MONTO VTAS DETRACCIONES]=" + "0")
                file.WriteLine("[MONTO VTAS BONIFICACIONES]=" + "0")
                file.WriteLine("[MONTO VTAS DESCUENTOS]=" + "0")
                file.WriteLine("[MONTO VTAS FISE]=" + "0")
                file.WriteLine("[MONTO LETRAS]=" + ImprimeTotalLetras(OFILADET.Item("AMO1TOFA"), MON))
            End If

            file.WriteLine("[NRO DOC]=" + TDOC + Strings.Right(Trim(OFILADET.Item("NRO_FACTURA")), 12))
            file.WriteLine("[FECHA DOC]=" + Format(OFILADET.Item("FECHA"), "yyyy-MM-dd"))
            file.WriteLine("[MONEDA DOC]=" + OFILADET.Item("MONEDA"))
            file.WriteLine("[NRO GUIA DE REMISION]=" + "")
            If TDOC = "B" Then
                If Trim(NULO(OFILADET.Item("ACLINRUC"), "S")) <> "" Then
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("ACLINRUC"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "6") ' PORQUE ES RUC
                Else
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("DNI"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "1") ' PORQUE ES RUC
                End If
            Else
                If Trim(NULO(OFILADET.Item("ACLINRUC"), "S")) = "" Then
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("DNI"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "1") ' PORQUE ES RUC
                Else
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("ACLINRUC"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "6") ' PORQUE ES RUC
                End If
            End If

            file.WriteLine("[NOMBRE DEL CLIENTE]=" + OFILADET.Item("ACLIDESC"))
            ''DATOS FACTURA IMPRESA
            file.WriteLine("[DIRECCION DEL CLIENTE]=" + NULO(OFILADET.Item("DIR_F"), "S"))
            file.WriteLine("[DIRECCION DE ENTREGA]=" + "")
            file.WriteLine("[CODIGO DEL CLIENTE]=" + CStr(OFILADET.Item("AMO1CLIE")))
            file.WriteLine("[CODIGO DEL VENDEDOR]=" + OFILADET.Item("AMO1VEND"))
            file.WriteLine("[CONDICION DE PAGO]=" + OFILADET.Item("AFPADESC"))
            file.WriteLine("[NUMERO ORDEN DE COMPRA]=" + "")
            file.WriteLine("[TRANSPORTISTA]=" + "")
            file.WriteLine("[NOMBRE DEL CHOFER]=" + "")
            file.WriteLine("[BREVETE DEL CHOFER]=" + "")
            file.WriteLine("[PLACA DEL CAMION]=" + OFILADET.Item("AMO1TPLAC"))
            file.WriteLine("[MARCA DEL CAMION]=" + "")
            file.WriteLine("[CAPACIDAD DEL CAMION]=" + "")
            file.WriteLine("[SCOP]=" + "")
            ''
            If OFILADET.Item("GRATUITA_VENTA") = False Then
                file.WriteLine("[MONTO DEL IGV]=" + CStr(OFILADET.Item("AMO1IGV")))
                file.WriteLine("[MONTO DEL ISC]=" + "0")
                file.WriteLine("[TOTAL FACTURA]=" + CStr(OFILADET.Item("AMO1TOFA")))
            Else
                file.WriteLine("[MONTO DEL IGV]=" + "0")
                file.WriteLine("[MONTO DEL ISC]=" + "0")
                file.WriteLine("[TOTAL FACTURA]=" + "0")
            End If

            file.WriteLine("[PORCENTAJE IGV]=" + CStr(OFILADET.Item("VAL_IGV")))
            file.WriteLine("[EMAIL CLIENTE]=" + OFILADET.Item("MAIL"))

            file.WriteLine("[TASA DE PERCEPCION]=" + "0")
            Dim REGIMEN As String = "0"
            ''Select Case CStr(Math.Round(RS("PORC_PERCEP"), 2))
            ''    Case "2.00"
            ''        REGIMEN = "01"
            ''    Case "1.00"
            ''        REGIMEN = "02" 'PERCEPCION DE ADQUISION DE COMBUSTIBLE
            ''    Case "0.50"
            ''        REGIMEN = "03" 'PERCEPCION DE ADQUISION DE COMBUSTIBLE
            ''End Select
            file.WriteLine("[REGIMEN DE PERCEPCION]=" + REGIMEN) 'PERCEPCION DE ADQUISION DE COMBUSTIBLE
            'Dim BASE As Double = Math.Round(RS("APERMTOP") / (1 + RS("VAL_IGV") / 100), 2)
            file.WriteLine("[BASE DE LA PERCEPCION]=" + "0")
            file.WriteLine("[MONTO PERCEPCION]=" + "0")
            file.WriteLine("[MONTO TOTAL A COBRAR]=" + CStr(OFILADET.Item("AMO1TOFA")))
            file.WriteLine("[TIPO DE CAMBIO]=" + CStr(OFILADET.Item("TC_VENTA")))

            file.WriteLine("[ESTADO]=" + CStr(OFILADET.Item("ESTADO")))
            ''
            F = 0
            Dim PU_INCIGV As Double
            Dim IGV_ITEM As Double
            OTABLA = LLENAR_DATA_TABLE("EXEC IAM_GENERAR_DETALLE_TXT '" & COD_DOC & "'," & NRODOC & "", CN_NET)
            Dim OFILA As DataRow
            OFILA = OTABLA.Rows(0)
            file.WriteLine("[NRO DE ITEMS]=" + CStr(OTABLA.Rows.Count))
            For Each OFILA In OTABLA.Rows
                F = F + 1
                file.WriteLine("[NRO ORDEN ITEM]=" + CStr(F))
                file.WriteLine("[UNIDAD DE MEDIDA UN/ECE rec 20]=" + OFILA.Item("AUMESUNAT"))
                file.WriteLine("[CANTIDAD ITEM]=" + CStr(OFILA.Item("AMO2CANTI")))
                file.WriteLine("[SUBTOTAL ITEM SIN IGV]=" + CStr(Format(Math.Round(OFILA.Item("AMO2STOT"), 2), "#0.00")))
                PU_INCIGV = OFILA.Item("AMO2PREC") * (1 + (OFILADET.Item("VAL_IGV") / 100))
                file.WriteLine("[PU ITEM INC IGV]=" + CStr(Math.Round(PU_INCIGV, 5)))
                IGV_ITEM = OFILA.Item("AMO2STOT") * (OFILADET.Item("VAL_IGV") / 100)
                file.WriteLine("[SUBTOTAL ITEM IGV]=" + CStr(Math.Round(IGV_ITEM, 2)))
                If OFILADET.Item("GRATUITA_VENTA") = False Then
                    file.WriteLine("[TIPO AFECTACION IGV TB07]=" + "10")
                Else
                    file.WriteLine("[TIPO AFECTACION IGV TB07]=" + "12")
                End If

                file.WriteLine("[SUBTOTAL ITEM ISC]=" + "0")
                file.WriteLine("[TIPO SISTEMA CALCULO ISC TB08]=" + "0")
                file.WriteLine("[DESCRIPCION DEL ITEM]=" + OFILA.Item("AARTDESC"))

                file.WriteLine("[CODIGO DEL ITEM]=" + OFILA.Item("AMO2ART"))
                file.WriteLine("[VALOR UNITARIO ITEM]=" + CStr(OFILA.Item("AMO2PREC")))

                file.WriteLine("[CODIGO SUNAT]=" + OFILA.Item("COD_SUNAT"))
                file.WriteLine("[PORC PERCEP ITEM]=" + "0.00")
                file.WriteLine("[MONTO PERCEP INC IGV ITEM]=" + "0.00")
            Next
            OTABLA.Dispose()
        Next

SALIR:
        file.Close()
        DT = Nothing
        OTABLA = Nothing

    End Function

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Generacion Completa", MsgBoxStyle.Information)
        Me.GroupPROGRESS.Visible = False
        VER()
    End Sub

    Private Sub Combo_Impresora_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub C1_DETALLE_Click(sender As Object, e As EventArgs) Handles C1_DETALLE.Click

    End Sub

    Private Sub C1_DETALLE_BeforeEdit(sender As Object, e As RowColEventArgs) Handles C1_DETALLE.BeforeEdit
        If e.Col <> COL_FELECTRONICA Then e.Cancel = True
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