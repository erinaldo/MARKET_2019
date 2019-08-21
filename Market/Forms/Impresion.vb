Imports CrystalDecisions.Shared
Public Class Impresion

    Public FORM As String
    ''
    ''MANT_USER
    Public SW As Integer
    Public CADENA As String
    Public CADENA2 As String
    Public CAMPO As String
    Public FI As String
    Public FF As String
    Public MON As String
    Public TITULO As String
    Public SALDO As Double
    Public TIPO As Integer

    Public SALDO_S As Double
    Public SALDO_D As Double

    Public TIPO_MCAJA As String
    Public COD_MCAJA As Double

    Public COMBO_CANT As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Impresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CRV.ReportSource = Nothing
        Select Case FORM
            Case "Mant_Usuarios"
                Dim SW1 As New ParameterDiscreteValue
                Dim CADENA1 As New ParameterDiscreteValue
                Dim CAMPO1 As New ParameterDiscreteValue
                SW1.Value = SW
                CADENA1.Value = CADENA
                CAMPO1.Value = CAMPO
                Dim PARAMLIST As New ParameterFields
                Dim PT As ParameterField

                PT = New ParameterField
                PT.Name = "@SW"
                PT.CurrentValues.Add(SW1)
                PARAMLIST.Add(PT)

                PT = New ParameterField
                PT.Name = "@CADENA"
                PT.CurrentValues.Add(CADENA1)
                PARAMLIST.Add(PT)

                PT = New ParameterField
                PT.Name = "@CAMPO"
                PT.CurrentValues.Add(CAMPO1)
                PARAMLIST.Add(PT)

                CRV.ParameterFieldInfo = PARAMLIST
                CRV.ReportSource = New Rpt_Usuarios


            Case "Mant_Familias"
                IMP_FAMILIAS()
            Case "Mant_Grupos"
                IMP_GRUPOS()
            Case "Mant_Medidas"
                IMP_MEDIDAS()
            Case "Mant_Proveedores"
                IMP_PROVEEDORES()
            Case "Mant_Tprecio"
                IMP_TPRECIOS()
            Case "Mant_Articulos"
                IMP_ARTICULOS()
            Case "Mant_FPago"
                IMP_FPAGO()
            Case "Mant_Clientes"
                IMP_CLIENTES()
            Case "Mant_TMov"
                IMP_TMOV()
            Case "Mant_TC"
                IMP_TC()
            Case "Mant_Bancos"
                IMP_BANCOS()
            Case "Mant_Tarjetas"
                IMP_TARJETAS()
            Case "Mant_Cobrador"
                IMP_COBRADORES()
            Case "Cobranza_Cliente"
                IMP_COBRANZA_CLIENTE()
            Case "Pago_Proveedor"
                IMP_PAGO_PROVEEDOR()
            Case "Rpte_Compras_x_Prov"
                IMP_RPTE_COMPRAS_X_PROV()
            Case "Rpte_Seleccion_Articulo"
                IMP_Rpte_Seleccion_Articulo()
            Case "Rpte_Reg_Ventas"
                IMP_Rpte_Reg_Ventas()
            Case "Rpte_Ventas_Credito"
                IMP_Rpte_Ventas_Credito()
            Case "Rpte_Cta_x_Cobrar"
                IMP_Rpte_Cta_x_Cobrar()
            Case "Rpte_Movimientos"
                IMP_rpte_movimientos()
            Case "Rpte_Mov_Caja"
                IMP_MOV_CAJA()
            Case "Rpte_Cuentas_x_Pagar"
                IMP_Rpte_Cta_x_Pagar()
            Case "Rpte_Tipo_Pagos"
                IMP_TIPO_PAGOS()
            Case "Reposicion"
                IMP_REPOSICION()
            Case "Rpte_Tarjetas"
                IMP_RPT_TARJETAS()
            Case "IMP_CAJA"
                IMP_RECIBO_CAJA()
            Case "Rpte_Caja"
                IMP_CAJA()
        End Select

    End Sub
    Sub IMP_CAJA()
        Dim PFI As New ParameterDiscreteValue
        PFI.Value = FI
        Dim PFF As New ParameterDiscreteValue
        PFF.Value = FF
        Dim PCAD As New ParameterDiscreteValue
        PCAD.Value = CADENA
        Dim PCAD2 As New ParameterDiscreteValue
        PCAD2.Value = CADENA2


        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(PFI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(PFF)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAD"
        PT.CurrentValues.Add(PCAD)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAD2"
        PT.CurrentValues.Add(PCAD2)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        Dim REP As New Rpt_Cuentas_MON
        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        REP.DataDefinition.FormulaFields("TIT").Text = "'" & TITULO & "'"
        REP.DataDefinition.FormulaFields("SALDO_INI").Text = "'" & Math.Round(SALDO_S, 2) & "'"
        REP.DataDefinition.FormulaFields("SALDO_INI_D").Text = "'" & Math.Round(SALDO_D, 2) & "'"
        CRV.ReportSource = REP



    End Sub
    Sub IMP_RECIBO_CAJA()
        Dim PTIPO As New ParameterDiscreteValue
        PTIPO.Value = TIPO_MCAJA
        Dim PCOD As New ParameterDiscreteValue
        PCOD.Value = COD_MCAJA

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@TIPO_MCAJA"
        PT.CurrentValues.Add(PTIPO)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@COD_MCAJA"
        PT.CurrentValues.Add(PCOD)
        PARAMLIST.Add(PT)


        CRV.ParameterFieldInfo = PARAMLIST

        Dim REP As New RptReciboSalEfecCaja
        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        'REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
        'REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/.", "$/.") & "'"
        CRV.ReportSource = REP



    End Sub
    Sub IMP_RPT_TARJETAS()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)


        CRV.ParameterFieldInfo = PARAMLIST

        Dim REP As New Rpt_Pagos_Tarjetas
        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
        'REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/.", "$/.") & "'"
        CRV.ReportSource = REP


    End Sub
    Sub IMP_Rpte_Cta_x_Pagar()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF
        Dim MON As New ParameterDiscreteValue
        MON.Value = CAMPO
        Dim CADEN As New ParameterDiscreteValue
        CADEN.Value = CADENA
        Dim TIP As New ParameterDiscreteValue
        TIP.Value = TIPO

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@CAD"
        PT.CurrentValues.Add(CADEN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@TIP"
        PT.CurrentValues.Add(TIP)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@MON"
        PT.CurrentValues.Add(MON)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        Select Case SW
            Case 1
                Dim REP As New Rpt_Cuentas_x_Pagar
                ''
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                ''
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 2
                Dim REP As New Rpt_Cuentas_x_Pagar_Detalle
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
        End Select
    End Sub
    Sub IMP_MOV_CAJA()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)


        CRV.ParameterFieldInfo = PARAMLIST

        Dim REP As New Rpt_Mov_Caja
        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        'REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
        'REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/.", "$/.") & "'"
        CRV.ReportSource = REP


    End Sub
    Sub IMP_TIPO_PAGOS()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)


        CRV.ParameterFieldInfo = PARAMLIST

        Dim REP As New Rpt_Tipo_Pagos
        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
        'REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/.", "$/.") & "'"
        CRV.ReportSource = REP


    End Sub
    Sub IMP_rpte_movimientos()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF
        Dim MON As New ParameterDiscreteValue
        MON.Value = CAMPO

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@MON"
        PT.CurrentValues.Add(MON)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        Select Case SW
            Case 1
                Dim REP As New Rpt_Movimientos_Resumido
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 2
                Dim REP As New Rpt_Movimientos_Detallado
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
        End Select
    End Sub
    Sub IMP_Rpte_Cta_x_Cobrar()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF
        Dim MON As New ParameterDiscreteValue
        MON.Value = CAMPO
        Dim CADEN As New ParameterDiscreteValue
        CADEN.Value = CADENA
        Dim TIP As New ParameterDiscreteValue
        TIP.Value = TIPO

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@CAD"
        PT.CurrentValues.Add(CADEN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@TIP"
        PT.CurrentValues.Add(TIP)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@MON"
        PT.CurrentValues.Add(MON)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        Select Case SW
            Case 1
                Dim REP As New Rpt_Cuentas_x_Cobrar
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 2
                Dim REP As New Rpt_Cuentas_x_Cobrar_Detallado
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 3
                Dim REP As New Rpt_Cuentas_x_Cobrar_Resumido
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
        End Select
    End Sub
    Sub IMP_Rpte_Ventas_Credito()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF
        Dim MON As New ParameterDiscreteValue
        MON.Value = CAMPO
        Dim CADEN As New ParameterDiscreteValue
        CADEN.Value = CADENA
        Dim TIP As New ParameterDiscreteValue
        TIP.Value = TIPO

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@CAD"
        PT.CurrentValues.Add(CADEN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@TIP"
        PT.CurrentValues.Add(TIP)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@MON"
        PT.CurrentValues.Add(MON)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        Select Case SW
            Case 1
                Dim REP As New Rpt_RegVentas_Credito
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 2
                Dim REP As New Rpt_RegVentas_Credito_Detallado
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 3
                Dim REP As New Rpt_RegVentas_Credito_Resumido
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
        End Select
    End Sub
    Sub IMP_Rpte_Reg_Ventas()
        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF
        Dim MON As New ParameterDiscreteValue
        MON.Value = CAMPO

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@MON"
        PT.CurrentValues.Add(MON)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        Select Case SW
            Case 1
                Dim REP As New Rpt_RegVentas
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 2
                Dim REP As New Rpt_RegVentas_Detallado
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
            Case 3
                Dim REP As New Rpt_RegVentas_x_Articulo
                REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
                REP.SetDatabaseLogon(strUID, strPWD)
                REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
                REP.DataDefinition.FormulaFields("MON").Text = "'" & IIf(CAMPO = "S", "S/", "$/.") & "'"
                CRV.ReportSource = REP
        End Select
        
    End Sub
    Sub IMP_Rpte_Seleccion_Articulo()
        
        Dim PC As New ParameterDiscreteValue
        PC.Value = SystemInformation.ComputerName
        
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@PC"
        PT.CurrentValues.Add(PC)
        PARAMLIST.Add(PT)

        
        CRV.ParameterFieldInfo = PARAMLIST
        If MON = "K" Then
            Dim REP As New Rpt_Kardex
            REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
            REP.SetDatabaseLogon(strUID, strPWD)
            'REP.DataDefinition.FormulaFields("MONEDA").Text = "'" & IIf(MON = "S", "S/.", "$/.") & "'"
            REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
            CRV.ReportSource = REP
        Else
            Dim REP As New Rpt_Kardex_Val
            REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
            REP.SetDatabaseLogon(strUID, strPWD)
            'REP.DataDefinition.FormulaFields("MONEDA").Text = "'" & IIf(MON = "S", "S/.", "$/.") & "'"
            REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
            CRV.ReportSource = REP
        End If

        
    End Sub

    Sub IMP_RPTE_COMPRAS_X_PROV()
        Dim REP As New Rpt_Compras_x_Prov

        Dim FINI As New ParameterDiscreteValue
        FINI.Value = FI
        Dim FFIN As New ParameterDiscreteValue
        FFIN.Value = FF
        Dim CAD As New ParameterDiscreteValue
        CAD.Value = CADENA
        Dim TIP As New ParameterDiscreteValue
        TIP.Value = CAMPO

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@FI"
        PT.CurrentValues.Add(FINI)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@FF"
        PT.CurrentValues.Add(FFIN)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CAD)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@TIP"
        PT.CurrentValues.Add(TIP)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST

        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        REP.DataDefinition.FormulaFields("MONEDA").Text = "'" & IIf(MON = "S", "S/", "$/.") & "'"
        REP.DataDefinition.FormulaFields("TITULO").Text = "'" & TITULO & "'"
        CRV.ReportSource = REP
    End Sub

    Sub IMP_COBRANZA_CLIENTE()
        Dim COD_COBRO As New ParameterDiscreteValue
        Dim REP As New Rpt_Recibo_Cobranza

        COD_COBRO.Value = SW

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@COD_COBRO"
        PT.CurrentValues.Add(COD_COBRO)
        PARAMLIST.Add(PT)

        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = REP
    End Sub
    Sub IMP_PAGO_PROVEEDOR()
        Dim COD_COBRO As New ParameterDiscreteValue
        Dim REP As New Rpt_Recibo_Pago

        COD_COBRO.Value = SW

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@COD_PAGO"
        PT.CurrentValues.Add(COD_COBRO)
        PARAMLIST.Add(PT)

        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = REP
    End Sub
    Sub IMP_TPRECIOS()

        Dim REP As New Rpt_Tprecios
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = REP
    End Sub
    Sub IMP_COBRADORES()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Cobradores
    End Sub
    Sub IMP_PROVEEDORES()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Proveedores
    End Sub
    Sub IMP_FAMILIAS()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Familias
    End Sub
    Sub IMP_GRUPOS()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Grupos
    End Sub
    Sub IMP_MEDIDAS()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Medidas
    End Sub
    Sub IMP_ARTICULOS()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Articulos
    End Sub
    Sub IMP_FPAGO()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_FPago
    End Sub
    Sub IMP_CLIENTES()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Clientes
    End Sub
    Sub IMP_TMOV()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_TMov
    End Sub
    Sub IMP_TC()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_TC
    End Sub
    Sub IMP_BANCOS()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Bancos
    End Sub
    Sub IMP_TARJETAS()
        Dim SW1 As New ParameterDiscreteValue
        Dim CADENA1 As New ParameterDiscreteValue
        Dim CAMPO1 As New ParameterDiscreteValue
        SW1.Value = SW
        CADENA1.Value = CADENA
        CAMPO1.Value = CAMPO
        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField

        PT = New ParameterField
        PT.Name = "@SW"
        PT.CurrentValues.Add(SW1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CADENA"
        PT.CurrentValues.Add(CADENA1)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CAMPO"
        PT.CurrentValues.Add(CAMPO1)
        PARAMLIST.Add(PT)

        CRV.ParameterFieldInfo = PARAMLIST
        CRV.ReportSource = New Rpt_Tarjetas
    End Sub

    Sub IMP_REPOSICION()

        Dim PARAMLIST As New ParameterFields
        Dim PT As ParameterField
        Dim CANT As New ParameterDiscreteValue
        CANT.Value = TIPO

        Dim PCOMBO As New ParameterDiscreteValue
        PCOMBO.Value = COMBO_CANT



        PT = New ParameterField
        PT.Name = "@COMBO_CANT"
        PT.CurrentValues.Add(PCOMBO)
        PARAMLIST.Add(PT)

        PT = New ParameterField
        PT.Name = "@CANT"
        PT.CurrentValues.Add(CANT)
        PARAMLIST.Add(PT)

        TITULO = "Stock : " & TIPO

        CRV.ParameterFieldInfo = PARAMLIST

        Dim REP As New Rpt_Rep_Stock
        REP.DataSourceConnections(0).SetConnection(strServidor, strDataBase, False)
        REP.SetDatabaseLogon(strUID, strPWD)
        'REP.DataDefinition.FormulaFields("MONEDA").Text = "'" & IIf(MON = "S", "S/.", "$/.") & "'"
        REP.DataDefinition.FormulaFields("stk").Text = "'" & TITULO & "'"
        CRV.ReportSource = REP



    End Sub
    Private Sub CRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRV.Load

    End Sub
End Class