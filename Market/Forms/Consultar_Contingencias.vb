Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid

Public Class Consultar_Contingencias
    Dim OBJCONFIG As ClsConfig
    Dim OBJCONTING As ClsVtaContingecia
    Dim strdocPath As String

    Dim MlonCorrelativo As Double

    Dim COL_ID As Integer = 0
    Dim COL_TIPO_DOC As Integer = 1
    Dim COL_SERIE As Integer = 2
    Dim COL_NUMERO As Integer = 3
    Dim COL_FECHA As Integer = 4
    Dim COL_RUC As Integer = 5
    Dim COL_CLIENTE As Integer = 6
    Dim COL_MOTIVO As Integer = 7
    Dim COL_SUBTOTAL As Integer = 8
    Dim COL_IGV As Integer = 9
    Dim COL_TOTAL As Integer = 10
    Dim COL_ESTADO As Integer = 11
    Dim COL_HORA_REGISTRO As Integer = 12
    Dim COL_USUARIO As Integer = 13
    Dim COL_FELECTRONICA As Integer = 14
    Dim COL_ART As Integer = 15
    Dim COL_CANT As Integer = 16
    Dim COL_PU As Integer = 17

    Public PAGO_SOLES As Double
    Public PAGO_DOLARES As Double
    Public PAGO_VUELTO As Double

    Private Sub Consultar_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCONFIG = New ClsConfig
        OBJCONTING = New ClsVtaContingecia

        LISTAR_TIPO_DOC(Me.LIST_TIPO_DOC, "V")
        CARGAR_CONFIG()
        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
        Me.Combo_TIPO.SelectedIndex = 0

        Dim I As Integer
        For I = 0 To LIST_TIPO_DOC.Items.Count - 1
            LIST_TIPO_DOC.SetSelected(I, True)
        Next I

        VER()
        ''
        If SISTEMA_FELECTRONICA = "S" Then
            Me.Button2.Visible = True
        Else
            Me.Button2.Visible = False
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
        ''SERIE DOCUMENTO
        If Me.TXT_NRO_DOC.Text.Trim <> "" Then
            CADENA = CADENA + " AND SERIE_VENTASM=" & Me.TXT_SERIE_DOC.Text & ""
        End If
        ''NRO DOCUMENTO
        If Me.TXT_NRO_DOC.Text.Trim <> "" Then
            CADENA = CADENA + " AND NUMERO_VENTASM=" & Me.TXT_NRO_DOC.Text & ""
        End If
        ''CLIENTE/OPERADOR
        If Me.TXT_CLIENTE.Text.Trim <> "" Then
            CADENA = CADENA + " AND VENTAS_MANUAL.COD_CLIENTE=" & Me.TXT_CLIENTE.Tag & ""
        End If
        ''' 
        ''TIPO
        If Me.Combo_TIPO.SelectedIndex = 1 Then CADENA = CADENA + " AND (VENTAS_MANUAL.STAT_VENTASM='''') "
        If Me.Combo_TIPO.SelectedIndex = 2 Then CADENA = CADENA + " AND (VENTAS_MANUAL.STAT_VENTASM<>'''') "


        ''TIPO
        TIPO = Obtener_matriz_Seleccionada(LIST_TIPO_DOC)
        If TIPO = "" Then MsgBox("Seleccione al menos un Tipo de Documento", MsgBoxStyle.Information) : Exit Sub
        LLENAR_GRID(Me.C1_DETALLE, "IAM_LISTAR_CONTINGENCIA '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & CADENA & "','" & IIf(Me.CHK_DETALLE.Checked, "D", "R") & "'", CAD_CON)

        TOTALES()
        DISEÑO()


    End Sub
    Sub TOTALES()
        With C1_DETALLE
            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_TOTAL, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_SUBTOTAL, CFG_DRESULT), "Total")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, GFormatodeNumero(COL_IGV, CFG_DRESULT), "Total")
        End With
    End Sub
    Sub DISEÑO()
        C1_DETALLE.Cols(COL_HORA_REGISTRO).Format = "dd/MM/yyyy HH:mm:ss"
        C1_DETALLE.Cols(COL_TOTAL).Format = "###,###,###.00"


        C1_DETALLE.Cols(COL_SUBTOTAL).Format = "###,###,###.00"
        C1_DETALLE.Cols(COL_IGV).Format = "###,###,###.00"
        If Me.CHK_DETALLE.Checked Then
            C1_DETALLE.Cols(COL_CANT).Format = "###,###,###.00"
        End If
        C1_DETALLE.AutoSizeCols()
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

        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "COD_CLIENTE"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_CLIENTE"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "RUC_CLIENTE"
        arraybusqueda(3, 2) = "Ruc "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "STAT_CLIENTE"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_Clientes"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_CLIENTE.Tag = .GrecibeColumnaID
                Me.TXT_CLIENTE.Text = .GrecibeColumnaOpcional
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BUSCAR_PERMISO("9201") = False Then MsgBox("No tiene permiso para usar esta opcion", MsgBoxStyle.Information) : Exit Sub
        Ventas_Contingencia.ShowDialog()

    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim NOMB_FILE As String
        Dim OBJVENTA As New ClsVenta
        Dim F As Integer
        Dim TREF As String
        OBJCONFIG.LISTAR_CONFIG_V2()
        Me.ProgressBar1.Maximum = C1_DETALLE.Rows.Count - 1 + 4
        For F = 1 To Me.C1_DETALLE.Rows.Count - 1
            BackgroundWorker1.ReportProgress(F)
            OBJCONTING.Id = C1_DETALLE.Item(F, COL_ID)
            ''OBJVENTA.TipoDoc = C1_DETALLE.Item(F, COL_TIPO_DOC)
            If C1_DETALLE.Item(F, COL_FELECTRONICA) = 0 And OBJCONTING.Id <> 0 Then
                Select Case Strings.Left(C1_DETALLE.Item(F, COL_TIPO_DOC), 1).Trim
                    Case "F" 'FACTURA
                        If Me.C1_DETALLE.Item(F, COL_ESTADO) = "" Then
                            NOMB_FILE = OBJCONFIG.RucConfig + "-" + "01" + "-" + C1_DETALLE.Item(F, COL_SERIE) + "-" + Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 6) + ".TXT" ''Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 12) + ".TXT"
                            CREAR_FACTURA(NOMB_FILE, C1_DETALLE.Item(F, COL_ID), OBJCONFIG.Config_Carpeta_Txt, "F")
                            OBJCONTING.IAM_ESTADO_FELECTRONICA(CN_NET, 1)
                        End If
                    Case "B" 'BOLETA
                        If Me.C1_DETALLE.Item(F, COL_ESTADO) = "" Then
                            NOMB_FILE = OBJCONFIG.RucConfig + "-" + "03" + "-" + C1_DETALLE.Item(F, COL_SERIE) + "-" + Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 6) + ".TXT" ''Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 12) + ".TXT"
                            CREAR_FACTURA(NOMB_FILE, C1_DETALLE.Item(F, COL_ID), OBJCONFIG.Config_Carpeta_Txt, "B")
                            OBJCONTING.IAM_ESTADO_FELECTRONICA(CN_NET, 1)
                        End If
                        ''Case "N"
                        ''    If Me.C1_DETALLE.Item(F, COL_ESTADO) = "" Then
                        ''        TREF = Strings.Left(C1_DETALLE.Item(F, COL_NC_NUMERO), 1)
                        ''        NOMB_FILE = OBJCONFIG.RucConfig + "-" + "07" + "-" + TREF + FormatoTicket(C1_DETALLE.Item(F, COL_NUMERO)) + ".TXT" ''Strings.Right(C1_DETALLE.Item(F, COL_NUMERO), 12) + ".TXT"
                        ''        CREAR_NOTA_CREDITO(NOMB_FILE, OBJFUNC.BUSCAR_CAMPO_NO_ANULADO("VENTAS_NC", "AVTACODI", "ID_NC", C1_DETALLE.Item(F, COL_CODIGO), "STAT_NC", OBJCONN.Conexion(CAD_CON)), C1_DETALLE.Item(F, COL_CODIGO), OBJCONFIG.Config_Carpeta_Txt, Strings.Left(C1_DETALLE.Item(F, COL_NC_NUMERO), 1))
                        ''        OBJVENTA.IAM_ESTADO_FELECTRONICA(OBJCONN.Conexion(CAD_CON), 1)
                        ''    End If
                End Select
            End If
        Next
    End Sub
    Function CREAR_FACTURA(ByVal NOMB_FILE As String, ByVal ID As Double, ByVal CONFIG_RUTA_TXT As String, ByVal TDOC As String) As Integer
        Dim OBJVENTA As New ClsVenta
        Dim file As System.IO.StreamWriter
        Dim MON As String
        Dim F As Integer
        Dim OTABLA As DataTable
        Dim DT As DataTable

        Dim OFILADET As DataRow
        DT = LLENAR_DATA_TABLE("EXEC IAM_GENERAR_TXT_CONTINGENCIA " & ID & "", CN_NET)
        If DT.Rows.Count = 0 Then GoTo SALIR
        file = System.IO.File.CreateText(CONFIG_RUTA_TXT & NOMB_FILE)
        For Each OFILADET In DT.Rows
            ''
            file.WriteLine("[CODIGO ESTABLECIMIENTO]=" + OBJCONFIG.Config_CodEstablecimiento)
            file.WriteLine("[TIPO OPERACION CATALOGO 51]=" + OBJCONFIG.Config_Catalog51)
            file.WriteLine("[HORA DOC]=" + OFILADET.Item("HORAVENTA"))
            file.WriteLine("[MONTO PORC DESCUENTO]=" + "0")
            ''
            If OFILADET.Item("MONEDA") = "S" Then MON = "SOLES" Else MON = "DOLARES AMERICANOS"
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
            file.WriteLine("[NRO DOC]=" + Strings.Right(Trim(OFILADET.Item("NRO_FACTURA")), 12))
            file.WriteLine("[FECHA DOC]=" + Format(OFILADET.Item("FECHA"), "yyyy-MM-dd"))
            file.WriteLine("[MONEDA DOC]=" + OFILADET.Item("MONEDA"))
            file.WriteLine("[NRO GUIA DE REMISION]=" + "")
            If TDOC = "B" Then
                If NULO(OFILADET.Item("ACLINRUC"), "S") <> "" Then
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("ACLINRUC"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "6") ' PORQUE ES RUC
                Else
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("DNI"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "1") ' PORQUE ES RUC
                End If
            Else
                If NULO(OFILADET.Item("ACLINRUC"), "S") = "" Then
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("DNI"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "1") ' PORQUE ES RUC
                Else
                    file.WriteLine("[NRO DOC IDENTIDAD CLIENTE]=" + OFILADET.Item("ACLINRUC"))
                    file.WriteLine("[TIPO IDENTIDAD CLIENTE]=" + "6") ' PORQUE ES RUC
                End If
            End If

            file.WriteLine("[NOMBRE DEL CLIENTE]=" + OFILADET.Item("ACLIDESC"))
            ''DATOS FACTURA IMPRESA
            Dim DIREC As String = NULO(OFILADET.Item("DIR_F"), "S")
            DIREC = Regex.Replace(DIREC, "[^0-9A-Za-z ]", "", RegexOptions.IgnorePatternWhitespace)
            'file.WriteLine("[DIRECCION DEL CLIENTE]=" + OBJFUNC.NULO(OFILADET.Item("DIR_F"), "S"))
            file.WriteLine("[DIRECCION DEL CLIENTE]=" + DIREC)
            file.WriteLine("[DIRECCION DE ENTREGA]=" + "")
            file.WriteLine("[CODIGO DEL CLIENTE]=" + CStr(OFILADET.Item("AMO1CLIE")))
            file.WriteLine("[CODIGO DEL VENDEDOR]=" + OFILADET.Item("AMO1VEND"))
            file.WriteLine("[CONDICION DE PAGO]=" + OFILADET.Item("AFPADESC"))
            file.WriteLine("[NUMERO ORDEN DE COMPRA]=" + "")
            file.WriteLine("[TRANSPORTISTA]=" + "")
            file.WriteLine("[NOMBRE DEL CHOFER]=" + "")
            file.WriteLine("[BREVETE DEL CHOFER]=" + "")
            file.WriteLine("[PLACA DEL CAMION]=" + "")
            file.WriteLine("[MARCA DEL CAMION]=" + "")
            file.WriteLine("[CAPACIDAD DEL CAMION]=" + "")
            file.WriteLine("[SCOP]=" + "")
            ''
            file.WriteLine("[MONTO DEL IGV]=" + CStr(OFILADET.Item("AMO1IGV")))
            file.WriteLine("[MONTO DEL ISC]=" + "0")
            file.WriteLine("[TOTAL FACTURA]=" + CStr(OFILADET.Item("AMO1TOFA")))
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
            ''OTABLA = OBJVENTA.IAM_GENERAR_DETALLE_TXT(Me.DBLISTAR.Item(Me.DBLISTAR.Row, COL_ID))
            OTABLA = LLENAR_DATA_TABLE("EXEC IAM_GENERAR_DETALLE_TXT_CONTINGENCIA " & ID & "", CN_NET)
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
                file.WriteLine("[TIPO AFECTACION IGV TB07]=" + "10")

                file.WriteLine("[SUBTOTAL ITEM ISC]=" + "0")
                file.WriteLine("[TIPO SISTEMA CALCULO ISC TB08]=" + "0")
                file.WriteLine("[DESCRIPCION DEL ITEM]=" + OFILA.Item("DESC_ART"))

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

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Generacion Completa", MsgBoxStyle.Information)
        Me.GroupPROGRESS.Visible = False
        VER()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub C1_DETALLE_Click(sender As Object, e As EventArgs) Handles C1_DETALLE.Click

    End Sub

    Private Sub C1_DETALLE_DoubleClick(sender As Object, e As EventArgs) Handles C1_DETALLE.DoubleClick
        Ventas_Contingencia.Show()
        Ventas_Contingencia.LLENAR_DATOS(Me.C1_DETALLE.Item(Me.C1_DETALLE.Row, COL_ID))
    End Sub

    Private Sub C1_DETALLE_BeforeEdit(sender As Object, e As RowColEventArgs) Handles C1_DETALLE.BeforeEdit
        If e.Col <> COL_FELECTRONICA Then e.Cancel = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If BUSCAR_PERMISO("9202") = False Then MsgBox("No tiene permiso para usar esta opcion", MsgBoxStyle.Information) : Exit Sub

            If Me.CHK_DETALLE.Checked = True Then MsgBox("No se puede enviar en modo Detalle", MsgBoxStyle.Exclamation) : Exit Sub
            If MsgBox("Seguro de enviar a Sunat??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Me.GroupPROGRESS.Visible = True
            CheckForIllegalCrossThreadCalls = False
            Me.BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class