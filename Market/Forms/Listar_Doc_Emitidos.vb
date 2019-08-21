Imports System.Drawing.Printing

Public Class Listar_Doc_Emitidos
    Public FECHA_PROCESO As String
    Public TURNO As Integer

    Dim OBJCAJA As ClsCaja
    Dim OBJPTOVTA As ClsPtoVta
    Dim OBJCONFIG As ClsConfig

    Dim COL_COD As Integer = 0
    Dim COL_TIPO As Integer = 1
    Dim COL_NRODOC As Integer = 2
    Dim COL_FECHADOC As Integer = 3
    Dim COL_CLIENTE As Integer = 4
    Dim COL_MONTO As Integer = 5
    Dim COL_FECHAREG As Integer = 6
    Dim COL_ESTADO As Integer = 7

    Dim COL_TOTAL_CAJA As Integer = 4

    Dim COL_TARJETA_MONTO As Integer = 11



    Private Sub OPT_BOLETAS_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_BOLETAS.CheckedChanged
        MOSTRAR()
    End Sub
    Sub MOSTRAR()
        ''If FECHA_PROCESO = "" Then Exit Sub
        C1_DETALLE.Visible = True
        C1_DOC.Visible = False
        Me.Panel1.Visible = True
        Try
            Dim TDOC As String
            Select Case True
                Case Me.OPT_BOLETAS.Checked
                    TDOC = "B"
                Case Me.OPT_FACTURAS.Checked
                    TDOC = "F"
                Case Me.OPT_ORDENES.Checked
                    TDOC = "O"
                Case Me.OPT_CAJA.Checked
                    TDOC = "C"
                Case Me.OPT_TARJETA.Checked
                    TDOC = "T"
                Case Me.OPT_LIQ.Checked
                    C1_DETALLE.Visible = False
                    C1_DOC.Visible = True
                    Me.Panel1.Visible = False
                    MOSTRAR_LIQ()
                    Exit Sub
                Case Me.OPT_ARTICULOS.Checked
                    TDOC = "A"
            End Select
            LLENAR_GRID(C1_DETALLE, "IAM_LISTAR_EMITIDOS '" & FECHA_PROCESO & "'," & TURNO & ",'" & GUSERID & "','" & TDOC & "'", CAD_CON)
            If Me.OPT_CAJA.Checked = False And OPT_ARTICULOS.Checked = False Then
                C1_DETALLE.Cols(COL_FECHAREG).Format = "dd/MM/yyyy HH:mm:ss"
            End If
            C1_DETALLE.AutoSizeCols()
            If OPT_ARTICULOS.Checked = False Then
                C1_DETALLE.Cols(COL_COD).Visible = False
            Else
                C1_DETALLE.Cols(COL_COD).Visible = True
            End If

            If TDOC = "T" Then
                C1_DETALLE.Cols(COL_CLIENTE).Width = 180
            End If

            If Me.OPT_CAJA.Checked Then
                C1_DETALLE.Cols(COL_MONTO).Visible = False
                C1_DETALLE.Cols(COL_FECHAREG).Visible = False
            End If

            TOTAL()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub MOSTRAR_LIQ()
        C1_DOC.DataSource = Nothing
        C1_DOC.Rows.Count = 1
        C1_DOC.Cols.Count = 4
        C1_DOC.Cols(0).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
        C1_DOC.Cols(1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
        C1_DOC.Cols(2).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
        C1_DOC.Cols(3).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
        Dim TOTAL_PAGOS As Double = 0
        Dim TOTAL_PAGOS_DOL As Double = 0
        Dim DT_LIQ_RES As DataTable
        DT_LIQ_RES = LLENAR_DATA_TABLE("IAM_RESUMEN_CIERRE '" & FECHA_PROCESO & "','" & GUSERID & "'," & TURNO & "", CN_NET)
        Dim OFILA As DataRow
        For Each OFILA In DT_LIQ_RES.Rows
            With C1_DOC
                .Cols(1).AllowMerging = True
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictCols
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tk.Factura :"
                Dim DF As String = OFILA.Item("MINFACT").ToString + "-" + OFILA.Item("MAXFACT").ToString
                .Item(.Rows.Count - 1, 2) = OFILA.Item("MINFACT").ToString
                .Item(.Rows.Count - 1, 3) = OFILA.Item("MAXFACT").ToString
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tk.Boleta :"
                .Item(.Rows.Count - 1, 2) = OFILA.Item("MINBOL").ToString
                .Item(.Rows.Count - 1, 3) = OFILA.Item("MAXBOL").ToString
                .AddItem("")
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .Rows(.Rows.Count - 1).Height = 10
                .AddItem("")
                .Item(.Rows.Count - 1, 2) = "Nro.Tks."
                .Item(.Rows.Count - 1, 3) = "Importe"
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tk.Factura"
                .Item(.Rows.Count - 1, 2) = OFILA.Item("CANTFACT")
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("TOTFACT"), 2)
                .Cols(3).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tk.Boleta"
                .Item(.Rows.Count - 1, 2) = OFILA.Item("CANTBOL")
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("TOTBOL"), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tk.Fact Anul"
                .Item(.Rows.Count - 1, 2) = OFILA.Item("ANULFACT")
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("TOTANULFACT"), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tk.Bol Anul"
                .Item(.Rows.Count - 1, 2) = OFILA.Item("ANULBOL")
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("TOTANULBOL"), 2)
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Item(.Rows.Count - 1, 2) = OFILA.Item("CANTTK")
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("TOTVTA"), 2)
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Item(.Rows.Count - 1, 1) = "Valor.Vta"
                .Item(.Rows.Count - 1, 2) = "I.G.V."
                .Item(.Rows.Count - 1, 3) = "Total.Vta"
                .AddItem("")
                .Item(.Rows.Count - 1, 1) = GFormatodeNumero(OFILA.Item("SUBT"), 2)
                .Item(.Rows.Count - 1, 2) = GFormatodeNumero(OFILA.Item("IGV"), 2)
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("TOTAL"), 2)
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Item(.Rows.Count - 1, 1) = "FORMA DE PAGO"
                .Item(.Rows.Count - 1, 2) = "FORMA DE PAGO"
                .Rows(.Rows.Count - 1).AllowMerging = True
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Efectivo S/ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("VTAEFECT"), 2)
                TOTAL_PAGOS = TOTAL_PAGOS + OFILA.Item("VTAEFECT")
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Efectivo US$ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("VTAEFECT_DOL"), 2)
                TOTAL_PAGOS_DOL = TOTAL_PAGOS_DOL + OFILA.Item("VTAEFECT_DOL")
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tarjeta S/ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("VTATARJ"), 2)
                TOTAL_PAGOS = TOTAL_PAGOS + OFILA.Item("VTATARJ")
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Tarjeta US$ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("VTATARJ_DOL"), 2)
                TOTAL_PAGOS_DOL = TOTAL_PAGOS_DOL + OFILA.Item("VTATARJ_DOL")
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Creditos"
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("ORDENES"), 2)
                TOTAL_PAGOS = TOTAL_PAGOS + OFILA.Item("ORDENES")
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Total S/ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(TOTAL_PAGOS, 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Total US$ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(TOTAL_PAGOS_DOL, 2)
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Item(.Rows.Count - 1, 1) = "EFECTIVO"
                .Item(.Rows.Count - 1, 2) = "EFECTIVO"
                .Rows(.Rows.Count - 1).AllowMerging = True
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Entrega S/ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("DEPOSITOS"), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Entrega US$ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("DEPOSITOS_DOL"), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Caja S/ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("PAGO_CAJA"), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Caja US$ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(OFILA.Item("PAGO_CAJA_DOL"), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Saldo S/ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(Math.Abs(OFILA.Item("VTAEFECT")) - Math.Abs(OFILA.Item("DEPOSITOS")) + Math.Abs(OFILA.Item("PAGO_CAJA")), 2)
                .AddItem("")
                .Item(.Rows.Count - 1, 0) = "Saldo US$ "
                .Item(.Rows.Count - 1, 3) = GFormatodeNumero(Math.Abs(OFILA.Item("VTAEFECT_DOL")) - Math.Abs(OFILA.Item("DEPOSITOS_DOL")) + Math.Abs(OFILA.Item("PAGO_CAJA_DOL")), 2)
                .AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
                .AddItem("")
                ''.Item(.Rows.Count - 1, 1) = "DETALLE Z"
                ''.Item(.Rows.Count - 1, 2) = "DETALLE Z"
                ''.Rows(.Rows.Count - 1).AllowMerging = True
                ''.AddItem("")
                .Rows(.Rows.Count - 1).Height = 10
                DISEÑO_SERIE(C1_DOC, .Rows.Count - 1, .Rows.Count - 1, 0, 3)
ACA:
                .AutoSizeCols()
            End With
        Next

    End Sub
    Sub TOTAL()
        Dim TOT As Double = 0
        Dim F As Integer
        For F = 1 To C1_DETALLE.Rows.Count - 1
            If OPT_ARTICULOS.Checked = True Then
                TOT = TOT + C1_DETALLE.Item(F, COL_FECHADOC)
            Else
                If Me.OPT_CAJA.Checked Then
                    If C1_DETALLE.Item(F, COL_ESTADO) = "" Then
                        If C1_DETALLE.Item(F, COL_TIPO) = "I" Then
                            TOT = TOT + C1_DETALLE.Item(F, COL_TOTAL_CAJA)
                        Else
                            TOT = TOT - C1_DETALLE.Item(F, COL_TOTAL_CAJA)
                        End If
                    End If
                Else
                        If Me.OPT_TARJETA.Checked Then
                        TOT = TOT + C1_DETALLE.Item(F, COL_TARJETA_MONTO)
                    Else
                        If C1_DETALLE.Item(F, COL_ESTADO) = "" Then
                            TOT = TOT + C1_DETALLE.Item(F, COL_MONTO)
                        End If
                    End If
                End If
            End If
        Next
        Me.lbl_tot.Text = GFormatodeNumero(TOT, 2)
    End Sub
    Private Sub OPT_FACTURAS_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_FACTURAS.CheckedChanged
        MOSTRAR()

    End Sub

    Private Sub OPT_ORDENES_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_ORDENES.CheckedChanged
        MOSTRAR()
    End Sub


    Private Sub OPT_CAJA_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_CAJA.CheckedChanged
        MOSTRAR()
    End Sub

    Private Sub Listado_Doc_Emitidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.PrintController = New StandardPrintController
        PrintDocument2.PrintController = New StandardPrintController

        OBJPTOVTA = New ClsPtoVta
        OBJCONFIG = New ClsConfig
        OBJCAJA = New ClsCaja

        'Dim OBJCONN As New ClsConexion
        'OBJCONFIG.LISTAR_CONFIG(OBJCONN.Conexion(CAD_CON))
        ''
        If CFG_MONVENTA = "S" Then lbl_tot_moneda.Text = "S/ :" Else lbl_tot_moneda.Text = "$ :"
        ''
        MOSTRAR()
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DT_VENTA As DataTable
        Dim DOCU As String
        Dim TDOC As String
        Dim MlonCorrelativo As Integer = 0
        Dim HASH As String
        Dim ORIG_DOC As Integer


        If C1_DETALLE.Row < 1 Then Exit Sub
        If C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO) <> "" Then MsgBox("Documento ya se encuentra Anulado", MsgBoxStyle.Information) : Exit Sub
        If MsgBox("Seguro de Anular el Documento??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If Me.OPT_CAJA.Checked Then
            OBJCAJA.ANULAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD))
            MOSTRAR()
            Exit Sub
        End If


        If SISTEMA_FELECTRONICA = "N" And SISTEMA_ASPNET = "N" And SISTEMA_ITALO = "N" Then ANULAR_DOC() : MOSTRAR() : Exit Sub
        Select Case True
            Case OPT_BOLETAS.Checked
                DOCU = " BOL. "
                TDOC = "B"
                ORIG_DOC = OBJCONFIG.Config_Boleta
            Case OPT_FACTURAS.Checked
                DOCU = " FACT."
                TDOC = "F"
                ORIG_DOC = OBJCONFIG.Config_Factura
                'Case OPT_OTROS.Checked
                '    DOCU = "OTRO. "
                '    TDOC = "R"
                '    ORIG_DOC = OBJCONFIG.ConfigOtro
        End Select

        If SISTEMA_ASPNET = "S" Then
            OBJCONFIG.LISTAR_CONFIG_V2()
            ANULAR_DOC()

            DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC) & "'", CN_NET)
            Dim OFILA As DataRow
            For Each OFILA In DT_VENTA.Rows
                Call BAJA_ASPNET(OFILA.Item("FECHA_VENTA"), OBJCONFIG.RucConfig, OBJCONFIG.DescConfig, OBJCONFIG.Config_Ubigeo, OBJCONFIG.DirConfig,
                                            DOCU, FormatoTicket(OFILA.Item("NRODOCU")))
            Next
            MOSTRAR()
            Exit Sub
        End If

        If SISTEMA_ITALO = "S" Then
            ''
            'If ORIG_DOC <> OBJCONFIG.ConfigOtro Then
            HASH = FIRMAR(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), TDOC)
            'End If
            ''
            ''ELIMINAMOS
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "JPG")
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "XML")
            ''
            ''
            IMP_ASP_NET(C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), HASH, OBJCONFIG, 0, "ANULAR")
            ANULAR_DOC()
            MOSTRAR()
            Exit Sub
        End If


        Dim ps As PaperSize
        Try
            With OBJPTOVTA
                Select Case True
                    Case Me.OPT_BOLETAS.Checked, OPT_CAJA.Checked, OPT_LIQ.Checked
                        PrintDocument2.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("002")
                        ps = PrintDocument2.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("002"))
                        PrintDocument2.DefaultPageSettings.PaperSize = ps
                    Case Me.OPT_FACTURAS.Checked, OPT_TARJETA.Checked, OPT_ORDENES.Checked
                        PrintDocument2.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("001")
                        ps = PrintDocument2.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("001"))
                        PrintDocument2.DefaultPageSettings.PaperSize = ps
                End Select
            End With
        Catch ex As Exception

        End Try
        ''
        Try
            PrintDocument2.Print()
            MOSTRAR()
        Catch ex As Exception
            MsgBox("Esta Impresora no esta Configurada", MsgBoxStyle.Information) : Exit Sub
        End Try
    End Sub
    Sub ANULAR_DOC()
        Dim OBJVENTAS As New ClsVenta
        Dim VALOR As Integer
        VALOR = OBJVENTAS.ANULAR_VENTA(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC))
        If VALOR = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
        If VALOR = 0 Then MsgBox("Anulado Correctamente", MsgBoxStyle.Information)
        Dim DT_VENTA As DataTable
        DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC) & "'", CN_NET)
        Dim OFILA As DataRow
        For Each OFILA In DT_VENTA.Rows
            IMPRIMIR(OFILA.Item("COD_DOC"), 2, "", OFILA.Item("NRODOCU"), NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), NULO(OFILA.Item("DSCTO_VENTA"), "S"), OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"), OFILA.Item("FECHA_VENTA"), OFILA.Item("FECHA_REG"), "")
        Next
    End Sub
    Sub REIMPRIMIR_DOC()
        Dim OBJVENTAS As New ClsVenta
        Dim DT_VENTA As DataTable
        Dim OFILA As DataRow
        ORIG = "P"
        Select Case True
            Case Me.OPT_BOLETAS.Checked, Me.OPT_FACTURAS.Checked, Me.OPT_ORDENES.Checked, Me.OPT_TARJETA.Checked
                DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC) & "'", CN_NET)
                For Each OFILA In DT_VENTA.Rows
                    IMPRIMIR(OFILA.Item("COD_DOC"), 1, "", OFILA.Item("NRODOCU"), NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), NULO(OFILA.Item("DSCTO_VENTA"), "N"), OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"), OFILA.Item("FECHA_VENTA"), OFILA.Item("FECHA_REG"), "")
                Next
            Case Me.OPT_CAJA.Checked
                DT_VENTA = LLENAR_DATA_TABLE("BUSCAR_CAJA " & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "", CN_NET)
                For Each OFILA In DT_VENTA.Rows
                    IMPRIMIR_CAJA_VENTA(OFILA.Item("TIPOMOVI"), OFILA.Item("MON_CAJA"), OFILA.Item("MONTO_CAJA"), NULO(OFILA.Item("OBSERV_CAJA"), "S"))
                Next
            Case Me.OPT_LIQ.Checked
                Dim COD_PTO As String = BUSCAR_CAMPO("PTOVTA", "APTOCODI", "APTOTERM", SystemInformation.ComputerName, CN_NET)
                IMPRIMIR_CIERRE_X(FECHA_PROCESO, COD_PTO, TURNO)
        End Select

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DOCU As String
        Dim TDOC As String
        Dim HASH As String
        Dim TDOC_ASP As Integer
        Dim DT_VENTA As DataTable

        If C1_DETALLE.Row < 1 Then Exit Sub
        If SISTEMA_FELECTRONICA = "N" And SISTEMA_ASPNET = "N" And SISTEMA_ITALO = "N" Then REIMPRIMIR_DOC() : Exit Sub

        Select Case True
            Case OPT_FACTURAS.Checked
                DOCU = " FACT."
                TDOC = "F"
                TDOC_ASP = OBJCONFIG.Config_Factura
            Case OPT_BOLETAS.Checked
                DOCU = " BOL. "
                TDOC = "B"
                TDOC_ASP = OBJCONFIG.Config_Boleta
                ''Case OPT_OTROS.Checked
                ''    DOCU = "OTRO. "
                ''    TDOC = "R"
                ''    TDOC_ASP = OBJCONFIG.ConfigOtro
        End Select

        If SISTEMA_ASPNET = "S" Then
            OBJCONFIG.LISTAR_CONFIG_V2()
            ORIG = "P"
            DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC) & "'", CN_NET)
            Dim OFILA As DataRow
            For Each OFILA In DT_VENTA.Rows
                Call FactImprimir_ASPNET(OBJCONFIG.RucConfig, OBJCONFIG.DescConfig, OBJCONFIG.Config_Ubigeo, OBJCONFIG.DirConfig, OFILA.Item("ACLIMAIL"), C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO),
                                                      "Ticket No" & DOCU, FormatoTicket(OFILA.Item("NRODOCU")),
                                                   NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"),
                                                   OFILA.Item("SUBTOT_VENTA"),
                                                      0, OFILA.Item("IGV_VENTA"), 0, OFILA.Item("TOTAL_VENTA"), 0,
                                                       0, 0, LLENAR_DATA_TABLE("EXEC VENTA_MOSTRAR_DETALLE '" & OFILA.Item("COD_DOC") & "'," & OFILA.Item("NRODOCU") & "", CN_NET), "01", OFILA.Item("COD_USER"),
                                                   0, "", LLENAR_DATA_TABLE("EXEC TARJETA_MOSTRAR_DETALLE '" & OFILA.Item("COD_DOC") & "'," & OFILA.Item("NRODOCU") & "", CN_NET), 1, OFILA.Item("FECHA_VENTA"),
                                                   OFILA.Item("ACLIDNI"), OFILA.Item("TCLIENTE"), OFILA.Item("FECHA_REG"))
            Next
            BUSCAR_HASH(C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), OBJCONFIG, 1)
            Exit Sub
        End If

        If SISTEMA_ITALO = "S" Then
            ''
            'If TDOC_ASP <> OBJCONFIG.ConfigOtro Then
            HASH = FIRMAR(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), TDOC)
            'End If
            ''
            ''ELIMINAMOS
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "JPG")
            System.IO.File.Delete(CARPETA_TMP + Strings.Left(FILE_JPG, Len(FILE_JPG) - 3) + "XML")
            ''
            ''
            IMP_ASP_NET(C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), HASH, OBJCONFIG, 1, Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_ESTADO))
            Exit Sub
        End If


        Dim ps As PaperSize
        Try
            With OBJPTOVTA
                Select Case True
                    Case Me.OPT_BOLETAS.Checked, OPT_CAJA.Checked, OPT_LIQ.Checked
                        PrintDocument1.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("002")
                        ps = PrintDocument1.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("002"))
                        PrintDocument1.DefaultPageSettings.PaperSize = ps
                    Case Me.OPT_FACTURAS.Checked, OPT_TARJETA.Checked, OPT_ORDENES.Checked
                        PrintDocument1.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("001")
                        ps = PrintDocument1.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("001"))
                        PrintDocument1.DefaultPageSettings.PaperSize = ps
                End Select
            End With
        Catch ex As Exception

        End Try
        ''
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox("Esta Impresora no esta Configurada", MsgBoxStyle.Information) : Exit Sub
        End Try

    End Sub

    Private Sub OPT_TARJETA_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_TARJETA.CheckedChanged
        MOSTRAR()
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim OBJVENTA As New ClsVenta
            Dim OBJCAJA As New ClsCaja
            Dim OBJCONFIG As New ClsConfig
            Dim OBJPTOVTA As New ClsPtoVta

            Dim DT_VENTA As DataTable
            Dim DOCU As String
            Dim TDOC As String
            Dim MlonCorrelativo As Integer = 0

            GRAFICO = e.Graphics

            Dim INTVALOR As Integer
            If C1_DETALLE.Row < 1 Then Exit Sub

            Select Case True
                Case Me.OPT_BOLETAS.Checked, Me.OPT_FACTURAS.Checked, OPT_TARJETA.Checked
                    With OBJVENTA
                        ''.Codigo = Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD)
                        ''
                        Select Case True
                            Case OPT_FACTURAS.Checked
                                DOCU = " FACT."
                                TDOC = "F"
                            Case OPT_BOLETAS.Checked
                                DOCU = " BOL. "
                                TDOC = "B"
                            Case OPT_TARJETA.Checked
                                Select Case C1_DETALLE.Item(C1_DETALLE.Row, COL_COD)
                                    Case "002"
                                        DOCU = " BOL. "
                                        TDOC = "B"
                                    Case "001"
                                        DOCU = " FACT."
                                        TDOC = "F"
                                End Select
                        End Select
                        ''
                        ''
                        DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC) & "'", CN_NET)
                        Dim OFILA As DataRow
                        For Each OFILA In DT_VENTA.Rows
                            ''
                            'IMPRIMIR
                            FIRMAR(C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), TDOC)

                            IMPRIMIR_TERMICA(OFILA.Item("COD_DOC"), 1, "", OFILA.Item("NRODOCU"), NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), NULO(OFILA.Item("DSCTO_VENTA"), "S"),
                                             OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"),
                                             OFILA.Item("FECHA_VENTA"), OFILA.Item("FECHA_REG"),
                            OFILA.Item("ACLIDNI"), OFILA.Item("TCLIENTE"))
                            ''
                        Next
                    End With

                Case Me.OPT_CAJA.Checked
                    With OBJCAJA
                        DT_VENTA = LLENAR_DATA_TABLE("BUSCAR_CAJA " & C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "", CN_NET)
                        Dim OFILA As DataRow
                        For Each OFILA In DT_VENTA.Rows
                            ''IMPRIMIMOS
                            IMPRIMIR_CAJA_VENTA_TERMICA(OFILA.Item("TIPOMOVI"), OFILA.Item("MON_CAJA"), OFILA.Item("MONTO_CAJA"), OFILA.Item("OBSERV_CAJA"), "")
                        Next

                    End With
                Case Me.OPT_LIQ.Checked
                    Dim COD_PTO As String = BUSCAR_CAMPO("PTOVTA", "APTOCODI", "APTOTERM", SystemInformation.ComputerName, CN_NET)
                    IMPRIMIR_CIERRE_X_TERMICA(FECHA_PROCESO, COD_PTO, TURNO, 1)

            End Select
            MOSTRAR()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OPT_LIQ_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_LIQ.CheckedChanged
        MOSTRAR()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Try
            Dim OBJVENTA As New ClsVenta
            Dim OBJCAJA As New ClsCaja
            Dim OBJCONFIG As New ClsConfig
            Dim OBJPTOVTA As New ClsPtoVta

            Dim DT_VENTA As DataTable
            Dim DOCU As String
            Dim TDOC As String
            Dim MlonCorrelativo As Integer = 0

            ' OBJCONFIG.LISTAR_CONFIG(OBJCONN.Conexion(CAD_CON))
            GRAFICO = e.Graphics
            Dim INTVALOR As Integer

            Dim PUNTO_BONUS As Double = 0
            Select Case True
                Case Me.OPT_BOLETAS.Checked, Me.OPT_FACTURAS.Checked, Me.OPT_TARJETA.Checked, Me.OPT_ORDENES.Checked
                    With OBJVENTA
                        INTVALOR = OBJVENTA.ANULAR_VENTA(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC))
                        If INTVALOR = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
                        If INTVALOR = 0 Then
                            MsgBox("Anulado Correctamente", MsgBoxStyle.Information)
                            Select Case True
                                Case OPT_BOLETAS.Checked
                                    DOCU = " BOL. "
                                    TDOC = "B"
                                Case OPT_FACTURAS.Checked
                                    DOCU = " FACT."
                                    TDOC = "F"
                            End Select
                            ''
                            DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD) & "','" & C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC) & "'", CN_NET)
                            Dim OFILA As DataRow
                            For Each OFILA In DT_VENTA.Rows
                                ''
                                'IMPRIMIR
                                ''
                                FIRMAR(Me.C1_DETALLE.Item(C1_DETALLE.Row, COL_COD), C1_DETALLE.Item(C1_DETALLE.Row, COL_NRODOC), TDOC)
                                ''
                                GRAFICO = e.Graphics

                                IMPRIMIR_TERMICA(OFILA.Item("COD_DOC"), 1, "ANULADO", OFILA.Item("NRODOCU"), NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), NULO(OFILA.Item("DSCTO_VENTA"), "S"),
                                             OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"),
                                                 OFILA.Item("FECHA_VENTA"), OFILA.Item("FECHA_REG"),
                                OFILA.Item("ACLIDNI"), OFILA.Item("TCLIENTE"))


                            Next

                        End If

                    End With

                Case Me.OPT_CAJA.Checked
                    With OBJCAJA
                        MsgBox("No se Anulan los Recibos de Caja", MsgBoxStyle.Critical) : Exit Sub
                    End With
            End Select
            MOSTRAR()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OPT_ARTICULOS_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_ARTICULOS.CheckedChanged
        MOSTRAR()
    End Sub
End Class