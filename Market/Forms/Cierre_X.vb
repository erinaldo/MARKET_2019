Imports System.Drawing.Printing

Public Class Cierre_X
    Dim OBJPTOVTA As ClsPtoVta
    Dim OBJVENTA As ClsVenta
    Dim objtc As ClsTC
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Cierre_X_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJPTOVTA = New ClsPtoVta
        OBJVENTA = New ClsVenta
        objtc = New ClsTC
        If Me.picturebox1.Visible = False Then
            CargarVariablesPtovta()
            Me.TXT_FECHA.Enabled = False
            Me.TXT_TURNO.Enabled = False
        Else
            Me.TXT_FECHA.Enabled = True
            Me.TXT_TURNO.Enabled = True
        End If
        Me.TXT_CAJA.Text = GPTOVTA
        Me.TXT_FECHA.Value = GFechaProceso
        Me.TXT_TURNO.Text = TURNO
        If Me.Tag = "X" Then
            Me.Text = "Cierre X"
            Me.TXT_TURNO.Visible = True
            Me.Label3.Visible = True
        Else
            Me.Text = "Cierre Z"
            Me.TXT_TURNO.Visible = False
            Me.Label3.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ps As PaperSize
        Dim COD_PTO As String = BUSCAR_CAMPO("PTOVTA", "APTOCODI", "APTOTERM", SystemInformation.ComputerName, CN_NET)
        If Me.Tag = "X" Then
            If OPT_PANTALLA.Checked = True Then
                ORIG = "V"
                IMPRIMIR_CIERRE_X(Format(Me.TXT_FECHA.Value, "dd/MM/yyyy"), COD_PTO, TXT_TURNO.Text)
                'EJECUTAR_X()
            Else
                ORIG = "P"
                If SISTEMA_FELECTRONICA = "N" Then
                    IMPRIMIR_CIERRE_X(Format(Me.TXT_FECHA.Value, "dd/MM/yyyy"), COD_PTO, TXT_TURNO.Text)
                Else
                    ''IMPRIMIR_CIERRE_X_TERMICA(Format(Me.TXT_FECHA.Value, "dd/MM/yyyy"), COD_PTO, TXT_TURNO.Text, 0)
                    PrintDocument1.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("002")
                    ps = PrintDocument1.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("002"))
                    PrintDocument1.DefaultPageSettings.PaperSize = ps
                    Try
                        PrintDocument1.Print()
                    Catch ex As Exception
                        MsgBox("Esta Impresora no esta Configurada", MsgBoxStyle.Information) : Exit Sub
                    End Try
                End If
            End If
        Else
            EJECUTAR_Z()
        End If

    End Sub
    Sub EJECUTAR_X()
        Try
            Dim CREDITO As Double = 0
            Dim PAGOSOL As Double = 0
            Dim PAGODOL As Double = 0
            Dim PAGOTARJSOL As Double = 0
            Dim PAGOTARJDOL As Double = 0
            Dim PORTIMP As String = ""
            Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")
            If Me.OPT_IMPRESORA.Checked = True Then
                ''AVERIGUAR PUERTO DE IMPRESION
                PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP("002")
                If PORTIMP = "" Then MsgBox("Punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
                ''
            End If


            Dim LINEA As String = "---------------------------------------"
            Dim IntAnchoTicket = 39


            'IMPRIMO CABECERA
            Dim TITUT As String
            Dim TURN As String
            file.WriteLine("")
            file.WriteLine("")
            file.WriteLine(LINEA)
            TITUT = Alineacion("C", IntAnchoTicket, Len("CIERRE (X)"), Trim("CIERRE (X)"))
            file.WriteLine(TITUT)
            TURN = Alineacion("C", IntAnchoTicket, Len("TURNO :" & TURNO & ""), Trim("TURNO :" & TURNO & ""))
            file.WriteLine(TURN)
            file.WriteLine(LINEA)
            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = Alineacion("I", IntAnchoTicket - 15, Len("Maq.Regist.No       : "), "Maq.Regist.No       : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GStrMaquinaReg), GStrMaquinaReg)
            file.WriteLine(strMaquinaReg)
            ' Imprimir FECHA
            Dim strfecha As String
            strfecha = Alineacion("I", IntAnchoTicket - 15, Len("Fecha               : "), "Fecha               : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(Format(Me.TXT_FECHA.Value, "dd/MM/yyyy")), Format(Me.TXT_FECHA.Value, "dd/MM/yyyy"))
            'Alineacion("D", IntAnchoTicket - 25, Len(Format(GFechaProceso, "dd/MM/yyyy")), Format(GFechaProceso, "dd/MM/yyyy"))
            file.WriteLine(strfecha)
            ' Imprimir HORA
            Dim strhora As String
            Dim HORA As String = Format(DateTime.Now, "HH:mm:ss")
            strhora = Alineacion("I", IntAnchoTicket - 15, Len("Hora                : "), "Hora                : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(HORA), HORA)
            file.WriteLine(strhora)
            ' Imprimir TC
            Dim strcambio As String
            Dim tc As String = GFormatodeNumero(objtc.BUSCAR_TC(GFechaProceso, "V"), 3)
            strcambio = Alineacion("I", IntAnchoTicket - 15, Len("Tipo de Cambio      : "), "Tipo de Cambio      : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(tc), tc)
            file.WriteLine(strcambio)
            file.WriteLine(LINEA)
            file.WriteLine("")
            TITUT = Alineacion("C", IntAnchoTicket, Len("REPORTE DE TICKETS"), Trim("REPORTE DE TICKETS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ''LLENANDO DATOS DE TICKET
            Dim RS As SqlDataReader 'New ADODB.Recordset
            Dim PAGOS As Double, PAGOD As Double, VUELTO As Double
            'RS.Open("EXEC IMP_X_RESUMEN '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO As New SqlCommand("EXEC IMP_X_RESUMEN '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            If RS.HasRows = True Then
                While RS.Read
                    ' Imprimir Nro de Transacciones
                    Dim strnrotransac As String
                    strnrotransac = Alineacion("I", IntAnchoTicket - 15, Len("Nro. Transac.       : "), "Nro. Transac.       : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(RS("cant")), RS("cant"))
                    file.WriteLine(strnrotransac.Trim)
                    ' Imprimir Ticket Inicial
                    Dim strticketini As String
                    strticketini = Alineacion("I", IntAnchoTicket - 15, Len("Num. Ticket Ini.    : "), "Num. Ticket Ini.    : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(FormatoTicket(RS("minimo"))), FormatoTicket(RS("minimo")))
                    file.WriteLine(strticketini)
                    ' Imprimir Ticket Final
                    Dim strticketfin As String
                    strticketfin = Alineacion("I", IntAnchoTicket - 15, Len("Num. Ticket Fin.    : "), "Num. Ticket Fin.    : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(FormatoTicket(RS("maximo"))), FormatoTicket(RS("maximo")))
                    file.WriteLine(strticketfin)
                    ' Imprimir Valor Venta
                    Dim strvv As String
                    strvv = Alineacion("I", IntAnchoTicket - 15, Len("Valor Venta      S/: "), "Valor Venta      S/: ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("valor"), 2)), GFormatodeNumero(RS("valor"), 2))
                    file.WriteLine(strvv)
                    ' Imprimir IGV
                    Dim strigv As String
                    strigv = Alineacion("I", IntAnchoTicket - 15, Len("I.G.V.           S/: "), "I.G.V.           S/: ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("IGV"), 2)), GFormatodeNumero(RS("IGV"), 2))
                    file.WriteLine(strigv)
                    ' Imprimir Total
                    Dim strtotal As String
                    strtotal = Alineacion("I", IntAnchoTicket - 15, Len("Venta Total      S/: "), "Venta Total      S/: ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total"), 2)), GFormatodeNumero(RS("total"), 2))
                    file.WriteLine(strtotal)
                    ' Imprimir Nro de Tickets Anulados
                    Dim strticketanul As String
                    strticketanul = Alineacion("I", IntAnchoTicket - 15, Len("Num.Ticket Anul.: "), "Num.Ticket Anul.: ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(RS("anulados")), RS("anulados"))
                    file.WriteLine(strticketanul)
                    ' Imprimir Total de Tickets Anulados
                    Dim strmontoanul As String
                    strmontoanul = Alineacion("I", IntAnchoTicket - 15, Len("Tot.Ticket Anul. S/: "), "Tot.Ticket Anul. S/: ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total_anul"), 2)), GFormatodeNumero(RS("total_anul"), 2))
                    file.WriteLine(strmontoanul)
                    ''
                    PAGOS = RS("PAGOS")
                    PAGOD = RS("PAGOD")
                    VUELTO = RS("VUELTO")
                    CREDITO = RS("CREDITO")
                End While
            Else
                MsgBox("No hay Transacciones en esta Caja", MsgBoxStyle.Information) : file.Close() : RS.Close() : CN_NET.Close() : Exit Sub
            End If
            RS.Close()
            file.WriteLine("")
            ''TIPO DE PAGOS
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR TIPOS DE PAGOS"), Trim("RESUMEN POR TIPOS DE PAGOS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ' Imprimir Efectivo Soles
            Dim strtotsoles As String
            strtotsoles = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO SOLES   S/: "), "EFECTIVO SOLES   S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS, 2)), GFormatodeNumero(PAGOS, 2))
            file.WriteLine(strtotsoles)
            ' Imprimir Vuelto Soles
            Dim strvueltosoles As String
            strvueltosoles = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO SOLES     S/: "), "VUELTO SOLES     S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(VUELTO, 2)), GFormatodeNumero(VUELTO, 2))
            file.WriteLine(strvueltosoles)
            ' Imprimir Neto Soles
            Dim strnetosoles As String
            strnetosoles = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS - VUELTO, 2)), GFormatodeNumero(PAGOS - VUELTO, 2))
            file.WriteLine(strnetosoles)
            file.WriteLine("")
            PAGOSOL = PAGOS - VUELTO
            ' Imprimir Efectivo Dolares
            Dim strtotdol As String
            strtotdol = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO DOLARES $/.: "), "EFECTIVO DOLARES $/.: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD, 2)), GFormatodeNumero(PAGOD, 2))
            file.WriteLine(strtotdol)
            ' Imprimir Vuelto Dolares
            Dim strvueltodol As String
            strvueltodol = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO DOLARES   $/.: "), "VUELTO DOLARES   $/.: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(0, 2)), GFormatodeNumero(0, 2))
            file.WriteLine(strvueltodol)
            ' Imprimir Neto Dolares
            Dim strnetodol As String
            strnetodol = Alineacion("I", IntAnchoTicket - 15, Len("NETO DOLARES     $/.: "), "NETO DOLARES     $/.: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD, 2)), GFormatodeNumero(PAGOD, 2))
            file.WriteLine(strnetodol)
            PAGODOL = PAGOD
            ''''
            file.WriteLine("")
            ''TARJETA EN SOLES
            Dim SQL As String
            Dim tots As Double = 0, totd As Double = 0
            'RS.Open("EXEC IMP_X_RESUMEN_TARJETAS '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO1 As New SqlCommand("EXEC IMP_X_RESUMEN_TARJETAS '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", CN_NET)
            'CN_NET.Open()
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("TARJETAS EN SOLES"), Trim("TARJETAS EN SOLES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)

                While RS.Read
                    ' Imprimir Soles
                    If RS("MON_TARJETA") = "S" Then
                        SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                        file.WriteLine(SQL)
                        tots = tots + RS("TOTAL")
                    End If
                    If RS("MON_TARJETA") = "D" Then
                        SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                        file.WriteLine(SQL)
                        totd = totd + RS("TOTAL")
                    End If
                End While
                PAGOTARJSOL = tots
                'RS.Close()
                file.WriteLine("")
                ' Imprimir Total Tarjetas Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            S/: "), "TOTAL            S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(tots, 2)), GFormatodeNumero(tots, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
                ' Imprimir Dolares
                ''TARJETA EN DOLARES
                TITUT = Alineacion("C", IntAnchoTicket, Len("TARJETAS EN DOLARES"), Trim("TARJETAS EN DOLARES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                PAGOTARJDOL = totd
                file.WriteLine("")
                ' Imprimir Total Tarjetas Dolares
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            $/: "), "TOTAL            $/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(totd, 2)), GFormatodeNumero(totd, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            RS.Close()
            ''  RESUMEN VENTA POR TIPO PAGO EN SOLES  
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN VENTA POR TIPO PAGO EN SOLES"), Trim("RESUMEN VENTA POR TIPO PAGO EN SOLES"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ' Imprimir Neto Soles
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL, 2)), GFormatodeNumero(PAGOSOL, 2))
            file.WriteLine(SQL)
            ' Imprimir Neto Dolares en Soles
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO $ EN SOLES  S/: "), "NETO $ EN SOLES  S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL * tc, 2)), GFormatodeNumero(PAGODOL * tc, 2))
            file.WriteLine(SQL)
            ' Imprimir Neto Tarjeta en Soles
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJETA EN SOLES S/: "), "TARJETA EN SOLES S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJSOL, 2)), GFormatodeNumero(PAGOTARJSOL, 2))
            file.WriteLine(SQL)
            ' Imprimir Neto Tarjeta Dolares en Soles
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJ. $ EN SOLES S/: "), "TARJ. $ EN SOLES S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJDOL * tc, 2)), GFormatodeNumero(PAGOTARJDOL * tc, 2))
            file.WriteLine(SQL)
            ' Imprimir CREDITO
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("CREDITO EN SOLES S/: "), "CREDITO EN SOLES S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(CREDITO, 2)), GFormatodeNumero(CREDITO, 2))
            file.WriteLine(SQL)
            ' Imprimir Total Tipo de Pagos
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            S/: "), "TOTAL            S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc), 2)), GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc) + CREDITO, 2))
            file.WriteLine(SQL)
            file.WriteLine("")

            'CUADRE TOTAL ING/SALIDAS
            Dim CAD As String = ""
            Dim SIMB As String = ""
            Dim EFECTS As Double = 0
            Dim EFECTD As Double = 0
            'RS.Open("EXEC IMP_X_CAJA '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO2 As New SqlCommand("EXEC IMP_X_CAJA '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", CN_NET)
            RS = OCOMANDO2.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"), Trim("CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                While RS.Read
                    If RS("MON_CAJA") = "S" Then SIMB = "S/ : " Else SIMB = "$/. : "
                    If RS("TIPOMOVI") = "I" Then
                        CAD = "ING. A CAJA     " & SIMB & " (+) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS + RS("TOTAL") Else EFECTD = EFECTD + RS("TOTAL")
                    Else
                        CAD = "SAL. DE CAJA    " & SIMB & " (-) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS - RS("TOTAL") Else EFECTD = EFECTD - RS("TOTAL")
                    End If

                    SQL = Alineacion("I", IntAnchoTicket - 10, Len(CAD), CAD) &
                               Alineacion("D", IntAnchoTicket - 30, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                    file.WriteLine(SQL)
                End While
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO         S/: "), "EFECTIVO         S/: ") &
                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL, 2)), GFormatodeNumero(PAGOSOL, 2))
                file.WriteLine(SQL)
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO         $/.: "), "EFECTIVO         $/.: ") &
                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL, 2)), GFormatodeNumero(PAGODOL, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("*TOTAL EFECTIVO  S/: "), "*TOTAL EFECTIVO  S/: ") &
                                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL + EFECTS, 2)), GFormatodeNumero(PAGOSOL + EFECTS, 2))
                file.WriteLine(SQL)
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("*TOTAL EFECTIVO  $/.: "), "*TOTAL EFECTIVO  $/.: ") &
                                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL + EFECTD, 2)), GFormatodeNumero(PAGODOL + EFECTD, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            RS.Close()

            ''RESUMEN POR PRODUCTOS   
            Dim TOTART As Double = 0
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR PRODUCTOS"), Trim("RESUMEN POR PRODUCTOS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)

            'RS.Open("EXEC IMP_X_RESUMEN_ARTICULOS_VENTA '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO3 As New SqlCommand("EXEC IMP_X_RESUMEN_ARTICULOS_VENTA '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", CN_NET)
            RS = OCOMANDO3.ExecuteReader
            While RS.Read
                SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("DESC_ART")), RS("DESC_ART")) &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                file.WriteLine(SQL)
                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X PRODUCTOS
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            S/ :"), "Total            S/ :") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            file.WriteLine(SQL)
            file.WriteLine("")
            ''TOTAL X VENDEDORES
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR VENDEDOR"), Trim("RESUMEN POR VENDEDOR"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ''
            TOTART = 0
            'RS.Open("EXEC IMP_X_RESUMEN_USUARIOS '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO4 As New SqlCommand("EXEC IMP_X_RESUMEN_USUARIOS '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'," & Me.TXT_TURNO.Text & "", CN_NET)
            RS = OCOMANDO4.ExecuteReader
            While RS.Read
                SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("DESC_USER")), RS("DESC_USER")) &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                file.WriteLine(SQL)
                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X VENDEDORES
            SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            S/ :"), "Total            S/ :") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            file.WriteLine(SQL)
            file.WriteLine("")
            '
            Dim I As Integer
            For I = 1 To 10
                file.WriteLine("")
            Next
            file.WriteLine(Chr(27) + "i")
            '

            file.Close()
            CN_NET.Close()
            Try
                If Me.OPT_IMPRESORA.Checked = True Then
                    Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
                Else
                    'Dim Proceso As Process = New Process
                    'Process.Start(Application.StartupPath & "C:\TEMP\temp.txt")
                    Shell("NOTEPAD.EXE " & "C:\TEMP\temp.txt", AppWinStyle.MaximizedFocus)
                End If
            Catch ax As System.IO.FileNotFoundException
                MsgBox(ax.Message)
            End Try

        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)

        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Sub EJECUTAR_Z()
        Try
            Dim CREDITO As Double = 0
            Dim PAGOSOL As Double = 0
            Dim PAGODOL As Double = 0
            Dim PAGOTARJSOL As Double = 0
            Dim PAGOTARJDOL As Double = 0
            Dim PORTIMP As String = ""
            If Me.OPT_IMPRESORA.Checked = True Then
                ''AVERIGUAR PUERTO DE IMPRESION
                PORTIMP = OBJPTOVTA.BUSCAR_PORTIMP("002")
                If PORTIMP = "" Then MsgBox("Punto no configurado para Impresion", MsgBoxStyle.Information) : Exit Sub
                ''
            End If

            Dim file As System.IO.StreamWriter = System.IO.File.CreateText("C:\TEMP\temp.txt")
            Dim LINEA As String = "---------------------------------------"
            Dim IntAnchoTicket = 39


            'IMPRIMO CABECERA
            Dim TITUT As String
            'Dim TURN As String
            file.WriteLine("")
            file.WriteLine("")
            file.WriteLine(LINEA)
            TITUT = Alineacion("C", IntAnchoTicket, Len("CIERRE (Z)"), Trim("CIERRE (Z)"))
            file.WriteLine(TITUT)
            'TURN = Alineacion("C", IntAnchoTicket, Len("TURNO :" & TURNO & ""), Trim("TURNO :" & TURNO & ""))
            'file.WriteLine(TURN)
            file.WriteLine(LINEA)
            ' Imprimir Numero de Máquina Registradora
            Dim strMaquinaReg As String
            strMaquinaReg = Alineacion("I", IntAnchoTicket - 15, Len("Maq.Regist.No       : "), "Maq.Regist.No       : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GStrMaquinaReg), GStrMaquinaReg)
            file.WriteLine(strMaquinaReg)
            ' Imprimir FECHA
            Dim strfecha As String
            strfecha = Alineacion("I", IntAnchoTicket - 15, Len("Fecha               : "), "Fecha               : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(Format(Me.TXT_FECHA.Value, "dd/MM/yyyy")), Format(Me.TXT_FECHA.Value, "dd/MM/yyyy"))
            'Alineacion("D", IntAnchoTicket - 25, Len(Format(GFechaProceso, "dd/MM/yyyy")), Format(GFechaProceso, "dd/MM/yyyy"))
            file.WriteLine(strfecha)
            ' Imprimir HORA
            Dim strhora As String
            Dim HORA As String = Format(DateTime.Now, "HH:mm:ss")
            strhora = Alineacion("I", IntAnchoTicket - 15, Len("Hora                : "), "Hora                : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(HORA), HORA)
            file.WriteLine(strhora)
            ' Imprimir TC
            Dim strcambio As String
            Dim tc As String = GFormatodeNumero(objtc.BUSCAR_TC(GFechaProceso, "V"), 3)
            strcambio = Alineacion("I", IntAnchoTicket - 15, Len("Tipo de Cambio      : "), "Tipo de Cambio      : ") &
            Alineacion("D", IntAnchoTicket - 25, Len(tc), tc)
            file.WriteLine(strcambio)
            file.WriteLine(LINEA)
            file.WriteLine("")
            TITUT = Alineacion("C", IntAnchoTicket, Len("REPORTE DE TICKETS"), Trim("REPORTE DE TICKETS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ''LLENANDO DATOS DE TICKET
            Dim RS As SqlDataReader 'New ADODB.Recordset
            Dim PAGOS As Double, PAGOD As Double, VUELTO As Double
            Dim MON_IMP As String = IIf(CFG_MONVENTA = "S", "S/", "US$")
            'RS.Open("EXEC IMP_Z_RESUMEN '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO As New SqlCommand("EXEC IMP_Z_RESUMEN '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            If RS.HasRows = True Then
                While RS.Read
                    ' Imprimir Nro de Transacciones
                    Dim strnrotransac As String
                    strnrotransac = Alineacion("I", IntAnchoTicket - 15, Len("Nro. Transac.       : "), "Nro. Transac.       : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(RS("cant")), RS("cant"))
                    file.WriteLine(strnrotransac.Trim)
                    ' Imprimir Ticket Inicial
                    Dim strticketini As String
                    strticketini = Alineacion("I", IntAnchoTicket - 15, Len("Num. Ticket Ini.    : "), "Num. Ticket Ini.    : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(FormatoTicket(RS("minimo"))), FormatoTicket(RS("minimo")))
                    file.WriteLine(strticketini)
                    ' Imprimir Ticket Final
                    Dim strticketfin As String
                    strticketfin = Alineacion("I", IntAnchoTicket - 15, Len("Num. Ticket Fin.    : "), "Num. Ticket Fin.    : ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(FormatoTicket(RS("maximo"))), FormatoTicket(RS("maximo")))
                    file.WriteLine(strticketfin)
                    ' Imprimir Valor Venta
                    Dim strvv As String
                    strvv = Alineacion("I", IntAnchoTicket - 15, Len("Valor Venta      " + MON_IMP + ": "), "Valor Venta      " + MON_IMP + ": ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("valor"), 2)), GFormatodeNumero(RS("valor"), 2))
                    file.WriteLine(strvv)
                    ' Imprimir IGV
                    Dim strigv As String
                    strigv = Alineacion("I", IntAnchoTicket - 15, Len("I.G.V.           " + MON_IMP + ": "), "I.G.V.           " + MON_IMP + ": ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("IGV"), 2)), GFormatodeNumero(RS("IGV"), 2))
                    file.WriteLine(strigv)
                    ' Imprimir Total
                    Dim strtotal As String
                    strtotal = Alineacion("I", IntAnchoTicket - 15, Len("Venta Total      " + MON_IMP + ": "), "Venta Total      " + MON_IMP + ": ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total"), 2)), GFormatodeNumero(RS("total"), 2))
                    file.WriteLine(strtotal)
                    ' Imprimir Nro de Tickets Anulados
                    Dim strticketanul As String
                    strticketanul = Alineacion("I", IntAnchoTicket - 15, Len("Num.Ticket Anul.: "), "Num.Ticket Anul.: ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(RS("anulados")), RS("anulados"))
                    file.WriteLine(strticketanul)
                    ' Imprimir Total de Tickets Anulados
                    Dim strmontoanul As String
                    strmontoanul = Alineacion("I", IntAnchoTicket - 15, Len("Tot.Ticket Anul. " + MON_IMP + ": "), "Tot.Ticket Anul. " + MON_IMP + ": ") &
                    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("total_anul"), 2)), GFormatodeNumero(RS("total_anul"), 2))
                    file.WriteLine(strmontoanul)
                    ''
                    PAGOS = RS("PAGOS")
                    PAGOD = RS("PAGOD")
                    VUELTO = RS("VUELTO")
                    CREDITO = RS("CREDITO")
                End While
            Else
                MsgBox("No hay Transacciones en esta Caja", MsgBoxStyle.Information) : file.Close() : RS.Close() : Exit Sub
            End If
            RS.Close()
            file.WriteLine("")
            ''TIPO DE PAGOS
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR TIPOS DE PAGOS"), Trim("RESUMEN POR TIPOS DE PAGOS"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ' Imprimir Efectivo Soles
            Dim strtotsoles As String
            strtotsoles = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO SOLES   S/: "), "EFECTIVO SOLES   S/: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS, 2)), GFormatodeNumero(PAGOS, 2))
            file.WriteLine(strtotsoles)
            If CFG_MONVENTA = "S" Then
                ' Imprimir Vuelto Soles
                Dim strvueltosoles As String
                strvueltosoles = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO SOLES     S/: "), "VUELTO SOLES     S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(VUELTO, 2)), GFormatodeNumero(VUELTO, 2))
                file.WriteLine(strvueltosoles)
                ' Imprimir Neto Soles
                Dim strnetosoles As String
                strnetosoles = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS - VUELTO, 2)), GFormatodeNumero(PAGOS - VUELTO, 2))
                file.WriteLine(strnetosoles)
                file.WriteLine("")
                PAGOSOL = PAGOS - VUELTO
            Else
                ' Imprimir Vuelto Soles
                Dim strvueltosoles As String
                strvueltosoles = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO SOLES     S/: "), "VUELTO SOLES     S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(0, 2)), GFormatodeNumero(0, 2))
                file.WriteLine(strvueltosoles)
                ' Imprimir Neto Soles
                Dim strnetosoles As String
                strnetosoles = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOS - 0, 2)), GFormatodeNumero(PAGOS - 0, 2))
                file.WriteLine(strnetosoles)
                file.WriteLine("")
                PAGOSOL = PAGOS
            End If
            ' Imprimir Efectivo Dolares
            Dim strtotdol As String
            strtotdol = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO DOLARES $/.: "), "EFECTIVO DOLARES $/.: ") &
            Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD, 2)), GFormatodeNumero(PAGOD, 2))
            file.WriteLine(strtotdol)
            If CFG_MONVENTA = "D" Then
                ' Imprimir Vuelto Dolares
                Dim strvueltodol As String
                strvueltodol = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO DOLARES   $/.: "), "VUELTO DOLARES   $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(VUELTO, 2)), GFormatodeNumero(VUELTO, 2))
                file.WriteLine(strvueltodol)
                ' Imprimir Neto Dolares
                Dim strnetodol As String
                strnetodol = Alineacion("I", IntAnchoTicket - 15, Len("NETO DOLARES     $/.: "), "NETO DOLARES     $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD - VUELTO, 2)), GFormatodeNumero(PAGOD - VUELTO, 2))
                file.WriteLine(strnetodol)
                PAGODOL = PAGOD - VUELTO
            Else
                ' Imprimir Vuelto Dolares
                Dim strvueltodol As String
                strvueltodol = Alineacion("I", IntAnchoTicket - 15, Len("VUELTO DOLARES   $/.: "), "VUELTO DOLARES   $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(0, 2)), GFormatodeNumero(0, 2))
                file.WriteLine(strvueltodol)
                ' Imprimir Neto Dolares
                Dim strnetodol As String
                strnetodol = Alineacion("I", IntAnchoTicket - 15, Len("NETO DOLARES     $/.: "), "NETO DOLARES     $/.: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOD - 0, 2)), GFormatodeNumero(PAGOD - 0, 2))
                file.WriteLine(strnetodol)
                PAGODOL = PAGOD
            End If
            ''''
            file.WriteLine("")
            ''TARJETA EN SOLES
            Dim SQL As String
            Dim tots As Double = 0, totd As Double = 0
            Dim OCOMANDO1 As New SqlCommand("EXEC IMP_Z_RESUMEN_TARJETAS '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", CN_NET)
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("TARJETAS EN SOLES"), Trim("TARJETAS EN SOLES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                ' Imprimir Soles
                While RS.Read
                    If RS("MON_TARJETA") = "S" Then
                        SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                        Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                        file.WriteLine(SQL)
                        tots = tots + RS("TOTAL")
                    End If
                    ''If RS("MON_TARJETA") = "D" Then
                    ''    SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                    ''    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                    ''    file.WriteLine(SQL)
                    ''    totd = totd + RS("TOTAL")
                    ''End If
                End While
                PAGOTARJSOL = tots
                file.WriteLine("")
                ' Imprimir Total Tarjetas Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            S/: "), "TOTAL            S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(tots, 2)), GFormatodeNumero(tots, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            RS.Close()
            ' Imprimir Dolares
            ''TARJETA EN DOLARES
            OCOMANDO1 = New SqlCommand("EXEC IMP_Z_RESUMEN_TARJETAS '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", CN_NET)
            RS = OCOMANDO1.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("TARJETAS EN DOLARES"), Trim("TARJETAS EN DOLARES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                While RS.Read
                    If RS("MON_TARJETA") = "D" Then
                        SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")), RS("COD_TARJETA") & "    " & RS("DESC_TARJETA")) &
                       Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                        file.WriteLine(SQL)
                        totd = totd + RS("TOTAL")
                    End If
                End While
                PAGOTARJDOL = totd
                file.WriteLine("")
                ' Imprimir Total Tarjetas Dolares
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL          US$:"), "TOTAL           US$:") &
                Alineacion("D", IntAnchoTicket - 26, Len(GFormatodeNumero(totd, 2)), GFormatodeNumero(totd, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            RS.Close()
            If CFG_MONVENTA = "S" Then
                ''  RESUMEN VENTA POR TIPO PAGO EN SOLES  
                TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN VENTA POR TIPO PAGO EN SOLES"), Trim("RESUMEN VENTA POR TIPO PAGO EN SOLES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                ' Imprimir Neto Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO SOLES       S/: "), "NETO SOLES       S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL, 2)), GFormatodeNumero(PAGOSOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO $ EN SOLES  S/: "), "NETO $ EN SOLES  S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL * tc, 2)), GFormatodeNumero(PAGODOL * tc, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJETA EN SOLES S/: "), "TARJETA EN SOLES S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJSOL, 2)), GFormatodeNumero(PAGOTARJSOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJ. $ EN SOLES S/: "), "TARJ. $ EN SOLES S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJDOL * tc, 2)), GFormatodeNumero(PAGOTARJDOL * tc, 2))
                file.WriteLine(SQL)
                ' Imprimir CREDITO
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("CREDITO EN SOLES S/: "), "CREDITO EN SOLES S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(CREDITO, 2)), GFormatodeNumero(CREDITO, 2))
                file.WriteLine(SQL)
                ' Imprimir Total Tipo de Pagos
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL            S/: "), "TOTAL            S/: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc), 2)), GFormatodeNumero(PAGOSOL + (PAGODOL * tc) + PAGOTARJSOL + (PAGOTARJDOL * tc) + CREDITO, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            Else
                ''  RESUMEN VENTA POR TIPO PAGO EN SOLES  
                TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN VENTA POR TIPO PAGO EN DOLARES"), Trim("RESUMEN VENTA POR TIPO PAGO EN DOLARES"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                ' Imprimir Neto Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO        US$: "), "NETO        US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL, 2)), GFormatodeNumero(PAGODOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("NETO S/ EN  US$: "), "NETO S/ EN  US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL / tc, 2)), GFormatodeNumero(PAGOSOL / tc, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJETA EN  US$: "), "TARJETA EN  US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJDOL, 2)), GFormatodeNumero(PAGOTARJDOL, 2))
                file.WriteLine(SQL)
                ' Imprimir Neto Tarjeta Dolares en Soles
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TARJ. S/ EN US$: "), "TARJ. S/ EN US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOTARJSOL / tc, 2)), GFormatodeNumero(PAGOTARJSOL / tc, 2))
                file.WriteLine(SQL)
                ' Imprimir CREDITO
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("CREDITO EN  US$: "), "CREDITO EN  US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(CREDITO, 2)), GFormatodeNumero(CREDITO, 2))
                file.WriteLine(SQL)
                ' Imprimir Total Tipo de Pagos
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("TOTAL           US$: "), "TOTAL           US$: ") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL + (PAGOSOL / tc) + PAGOTARJDOL + (PAGOTARJSOL / tc), 2)), GFormatodeNumero(PAGODOL + (PAGOSOL / tc) + PAGOTARJDOL + (PAGOTARJSOL / tc) + CREDITO, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            'End If
            'RS.Close()
            'CUADRE TOTAL ING/SALIDAS
            Dim CAD As String = ""
            Dim SIMB As String = ""
            Dim EFECTS As Double = 0
            Dim EFECTD As Double = 0
            'RS.Open("EXEC IMP_Z_CAJA '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO2 As New SqlCommand("EXEC IMP_Z_CAJA '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", CN_NET)
            RS = OCOMANDO2.ExecuteReader
            If RS.HasRows = True Then
                TITUT = Alineacion("C", IntAnchoTicket, Len("CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"), Trim("CUADRE TOTAL INGRESOS/SALIDAS DE CAJA"))
                file.WriteLine(TITUT)
                file.WriteLine(LINEA)
                While RS.Read
                    If RS("MON_CAJA") = "S" Then SIMB = "S/ : " Else SIMB = "US$ : "
                    If RS("TIPOMOVI") = "I" Then
                        CAD = "ING. A CAJA     " & SIMB & " (+) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS + RS("TOTAL") Else EFECTD = EFECTD + RS("TOTAL")
                    Else
                        CAD = "SAL. DE CAJA    " & SIMB & " (-) "
                        If RS("MON_CAJA") = "S" Then EFECTS = EFECTS - RS("TOTAL") Else EFECTD = EFECTD - RS("TOTAL")
                    End If

                    SQL = Alineacion("I", IntAnchoTicket - 10, Len(CAD), CAD) &
                    Alineacion("D", IntAnchoTicket - 30, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                    file.WriteLine(SQL)
                End While
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO         S/: "), "EFECTIVO         S/: ") &
                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL, 2)), GFormatodeNumero(PAGOSOL, 2))
                file.WriteLine(SQL)
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("EFECTIVO         US$: "), "EFECTIVO         US$: ") &
                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL, 2)), GFormatodeNumero(PAGODOL, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("*TOTAL EFECTIVO  S/: "), "*TOTAL EFECTIVO  S/: ") &
                                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGOSOL + EFECTS, 2)), GFormatodeNumero(PAGOSOL + EFECTS, 2))
                file.WriteLine(SQL)
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("*TOTAL EFECTIVO  US$: "), "*TOTAL EFECTIVO  US$: ") &
                                      Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(PAGODOL + EFECTD, 2)), GFormatodeNumero(PAGODOL + EFECTD, 2))
                file.WriteLine(SQL)
                file.WriteLine("")
            End If
            RS.Close()



            ' ''RESUMEN POR PRODUCTOS   
            Dim TOTART As Double = 0
            'TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR PRODUCTOS"), Trim("RESUMEN POR PRODUCTOS"))
            'file.WriteLine(TITUT)
            'file.WriteLine(LINEA)

            ''RS.Open("EXEC IMP_Z_RESUMEN_ARTICULOS_VENTA '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'Dim OCOMANDO3 As New SqlCommand("EXEC IMP_Z_RESUMEN_ARTICULOS_VENTA '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", CN_NET)
            'RS = OCOMANDO3.ExecuteReader
            'While RS.Read
            '    SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("DESC_ART")), RS("DESC_ART")) & _
            '    Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
            '    file.WriteLine(SQL)
            '    TOTART = TOTART + RS("TOTAL")
            'End While
            'RS.Close()
            ' ''TOTAL RESUMEN X PRODUCTOS
            'SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            S/. :"), "Total            S/. :") & _
            'Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            'file.WriteLine(SQL)
            'file.WriteLine("")
            ''TOTAL X VENDEDORES
            TITUT = Alineacion("C", IntAnchoTicket, Len("RESUMEN POR VENDEDOR"), Trim("RESUMEN POR VENDEDOR"))
            file.WriteLine(TITUT)
            file.WriteLine(LINEA)
            ''
            TOTART = 0
            'RS.Open("EXEC IMP_Z_RESUMEN_USUARIOS '" & Format(GFechaProceso, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            Dim OCOMANDO4 As New SqlCommand("EXEC IMP_Z_RESUMEN_USUARIOS '" & Format(Me.TXT_FECHA.Value, "dd/MM/yyyy") & "','" & Me.TXT_CAJA.Text.Trim & "'", CN_NET)
            RS = OCOMANDO4.ExecuteReader
            While RS.Read
                SQL = Alineacion("I", IntAnchoTicket - 15, Len(RS("DESC_USER")), RS("DESC_USER")) &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(RS("TOTAL"), 2)), GFormatodeNumero(RS("TOTAL"), 2))
                file.WriteLine(SQL)
                TOTART = TOTART + RS("TOTAL")
            End While
            RS.Close()
            ''TOTAL RESUMEN X VENDEDORES
            If CFG_MONVENTA = "S" Then
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            S/ :"), "Total            S/ :") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            Else
                SQL = Alineacion("I", IntAnchoTicket - 15, Len("Total            US$:"), "Total            US$:") &
                Alineacion("D", IntAnchoTicket - 25, Len(GFormatodeNumero(TOTART, 2)), GFormatodeNumero(TOTART, 2))
            End If
            file.WriteLine(SQL)
            file.WriteLine("")
            ''
            Dim I As Integer
            For I = 1 To 10
                file.WriteLine("")
            Next
            file.WriteLine(Chr(27) + "i")
            '
            file.Close()
            Try
                If Me.OPT_IMPRESORA.Checked = True Then
                    Shell("print /d:" & PORTIMP & " C:\TEMP\temp.txt", AppWinStyle.Hide)
                Else
                    'Dim Proceso As Process = New Process
                    'Process.Start(Application.StartupPath & "C:\TEMP\temp.txt")
                    Shell("NOTEPAD.EXE " & "C:\TEMP\temp.txt", AppWinStyle.MaximizedFocus)
                End If
            Catch ax As System.IO.FileNotFoundException
                MsgBox(ax.Message)
            End Try
            ''GRABAR Z
            If OBJVENTA.GRABAR_Z(Me.TXT_CAJA.Text, TOTART) = 0 Then
                MsgBox("Cierre Z generado con exito", MsgBoxStyle.Information)
            Else
                MsgBox("Error al generar cierre Z", MsgBoxStyle.Information)
            End If
            CN_NET.Close()
            ''
        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(4, 3) As Object
        arraybusqueda(1, 1) = "APTOCODI"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "APTOFEPO"
        arraybusqueda(2, 2) = "Proceso "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "APTOTERM"
        arraybusqueda(3, 2) = "Terminal "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "ESTADO"
        arraybusqueda(4, 2) = "Estado "
        arraybusqueda(4, 3) = 1500


        ''
        With BusquedaMaestra
            .ACT = "Mant_PtoVta"
            .STATINI = 2
            .CARGAR_COMBO(arraybusqueda, 4, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                ' Me.TXT_COD.Text = .GrecibeColumnaID
                Me.TXT_CAJA.Text = .GrecibeColumnaID '.GrecibeColumnaOpcional2
                'ASIGNAR_DATOS()
            End If
            .Close()
        End With
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try

            GRAFICO = e.Graphics
            Dim COD_PTO As String = BUSCAR_CAMPO("PTOVTA", "APTOCODI", "APTOTERM", SystemInformation.ComputerName, CN_NET)
            IMPRIMIR_CIERRE_X_TERMICA(Format(Me.TXT_FECHA.Value, "dd/MM/yyyy"), COD_PTO, TXT_TURNO.Text, 0)
        Catch ex As Exception

        End Try

    End Sub
End Class