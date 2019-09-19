Imports System.IO

Module ModAspNet
    Public Function FactImprimir_ASPNET(RUC_CIA As String, DESC_CIA As String, UBIGEO_CIA As String, DIR_CIA As String,
                            MAIL As String, strEstado As String, strTipoDoc As String, StrNumerodeTicket As String,
                            StrRazonSocial As String,
                            strRUC As String, StrDireccion As String,
                             DblValorVentaBase As Double, DblValorVentaExt As Double,
                            DblIGVBase As Double, dblIGVEXT As Double,
                            DblTotalBase As Double, DblTotalExt As Double,
                            DblNoAfectoBase As Double,
                            DblNoAfectoExt As Double,
                            ByVal RsDetalleTemporal As DataTable,
                            strTIPOPAGO As String,
                            strCajero As String,
                            Optional DBLBonus As Double = 0,
                            Optional StrPlaca As String = "",
                            Optional ByVal RSTARJETAS As DataTable = Nothing,
                            Optional IntImprimeReimprime As Integer = 0, Optional DatFechaImpresion As Date = Nothing,
                                                              Optional strDNI As String = "",
                                             Optional TCLIENTE As String = "", Optional DatHoraImpresion As Date = Nothing
     ) As Boolean

        'Dim OBJFUNC As New ClSFunciones
        'Dim OBJCONN As New ClsConexion
        Dim OBJCONFIG As New ClsConfig
        Dim CARA As String

        Dim objFSO
        'Dim objStream
        Dim NOMBRE_FILE As String
        Dim TDOC As String
        Dim NRODOC As String
        Dim RUTA As String

        OBJCONFIG.LISTAR_CONFIG_V2()

        If Strings.Right(strTipoDoc.Trim, 4) = "BOL." Then
            NOMBRE_FILE = OBJCONFIG.RucConfig + "-" + "03" + "-" + "B" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            NRODOC = "B" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            TDOC = "03"
            RUTA = SISTEMA_ASPNET_RUTA + "\boleta\"
        Else
            NOMBRE_FILE = OBJCONFIG.RucConfig + "-" + "01" + "-" + "F" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            'NRO = "F" + FormatoTicket(StrNumerodeTicket)
            NRODOC = "F" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            TDOC = "01"
            RUTA = SISTEMA_ASPNET_RUTA + "\invoice\"
        End If

        Dim objstream As System.IO.StreamWriter
        If strEstado = "" Then
            'If IntImprimeReimprime = 0 Then
            objstream = System.IO.File.CreateText(RUTA + NOMBRE_FILE + ".csv")
            'Else
            'objstream = System.IO.File.CreateText(SISTEMA_ACEPTA_RUTA + NOMBRE_FILE + ".PTX")
            'End If
        Else
            objstream = System.IO.File.CreateText(RUTA + NOMBRE_FILE + ".BAJA")
        End If

        Try
            ''
            If IntImprimeReimprime = 0 Then
                PObtener_FechaServidor()
                DatFechaImpresion = GDatFechaActual
                DatHoraImpresion = Date.Now
            End If

            objstream.Write(Format(DatFechaImpresion, "dd/MM/yyyy") + ",") '1
            objstream.Write(NRODOC + ",") '2
            objstream.Write(TDOC + ",") '3
            objstream.Write("PEN" + ",") '4
            objstream.Write(COMAS(GFormatodeNumero(DblIGVBase, 2).ToString).ToString + ",") '5
            objstream.Write(COMAS(GFormatodeNumero(DblIGVBase, 2).ToString).ToString + ",") '6
            objstream.Write("PEN" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("" + ",") '10
            objstream.Write("" + ",") '11
            objstream.Write("" + ",") '12
            objstream.Write("" + ",") '13
            objstream.Write(COMAS(GFormatodeNumero(DblTotalBase, 2).ToString).ToString + ",") '14
            objstream.Write("" + ",") '15
            objstream.Write("" + ",") '16
            objstream.Write("01" + ",") '17
            objstream.Write("" + ",") '18
            objstream.Write("" + ",") '19
            objstream.Write("" + ",") '20
            objstream.Write("" + ",") '21
            objstream.Write(COMAS(GFormatodeNumero(DblValorVentaBase, 2).ToString).ToString + ",") '22
            objstream.Write("" + ",") '23
            objstream.Write("" + ",") '24
            objstream.Write("" + ",") '25
            objstream.Write(COMAS(GFormatodeNumero(DblValorVentaBase, 2).ToString).ToString + ",") '26
            objstream.Write("" + ",") '27
            objstream.Write("" + ",") '28
            objstream.Write("" + ",") '29
            objstream.Write("" + ",") '30
            objstream.Write("" + ",") '31
            objstream.Write("" + ",") '32
            objstream.Write("" + ",") '33
            objstream.Write("" + ",") '34
            objstream.Write("" + ",") '35
            objstream.Write("" + ",") '36
            objstream.Write("" + ",") '37
            objstream.Write(Format(DatFechaImpresion, "dd/MM/yyyy") + ",") '38
            objstream.Write("" + ",") '39
            objstream.Write("") '40
            objstream.WriteLine() 'LIN1
            'PLACA
            'If TDOC = "01" Then
            If Trim(StrPlaca) = String.Empty Then
                StrPlaca = ""
            End If

            objstream.Write("" + ",") '1
            objstream.Write("" + ",") '2
            objstream.Write("" + ",") '3
            objstream.Write("" + ",") '4
            objstream.Write("" + ",") '5
            objstream.Write("" + ",") '6
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("" + ",") '10
            objstream.Write("" + ",") '11
            objstream.Write("" + ",") '12
            objstream.Write("" + ",") '13
            objstream.Write("" + ",") '14
            objstream.Write(StrPlaca + ",") '15
            objstream.Write("" + ",") '16
            objstream.Write("" + ",") '17
            objstream.Write("" + ",") '18
            objstream.Write("" + ",") '19
            objstream.Write("" + ",") '20
            objstream.Write("") '21
            objstream.WriteLine() ''LIN2

            objstream.Write("" + ",") '1
            objstream.Write("" + ",") '2
            objstream.Write("" + ",") '3
            objstream.Write("" + ",") '4
            objstream.Write("") '5
            objstream.WriteLine() ''LIN3

            'DATOS DEL EMISOR
            objstream.Write(DESC_CIA + ",") '1
            objstream.Write("" + ",") '2
            objstream.Write(RUC_CIA + ",") '3
            objstream.Write(UBIGEO_CIA + ",") '4
            objstream.Write(DIR_CIA + ",") '5
            objstream.Write(OBJCONFIG.Config_Provincia + ",") '6
            objstream.Write(OBJCONFIG.Config_Departamento + ",") '7
            objstream.Write(OBJCONFIG.Config_Distrito + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("PE" + ",") '10
            objstream.Write("" + ",") '11
            objstream.Write("" + ",") '12
            objstream.Write("") '13
            objstream.WriteLine() ''LIN4

            'DATOS DEL CLIENTE
            If TCLIENTE = "R" Then
                If Trim(strRUC) <> String.Empty Then
                    objstream.Write(strRUC + ",") '1
                    objstream.Write("6" + ",") '2
                End If
            Else
                If Trim(strDNI) <> String.Empty Then
                    objstream.Write(strDNI + ",") '1
                    objstream.Write("1" + ",") '2
                Else
                    objstream.Write("99999999999" + ",") '1
                    objstream.Write("6" + ",") '2
                End If
            End If
            If Trim(StrRazonSocial) <> String.Empty Then
                objstream.Write(StrRazonSocial + ",") '3
            Else
                objstream.Write("CLIENTES VARIOS" + ",") '3
            End If
            objstream.Write("" + ",") '4
            objstream.Write("" + ",") '5


            'StrDireccion = Replace(StrDireccion.Trim, "</td>", "").Replace("</tr>", "").Replace("<tr>", "")

            If Trim(StrDireccion) <> String.Empty Then
                StrDireccion = Replace(StrDireccion.Trim, vbCrLf, "").Replace("</td>", "").Replace("</tr>", "").Replace("<tr>", "")
                objstream.Write(StrDireccion + ",") '6
            Else
                objstream.Write("" + ",") '6
            End If
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            If TDOC = "03" Then
                If Trim(MAIL) <> String.Empty Then
                    objstream.Write(MAIL + ",") '9
                Else
                    objstream.Write("" + ",") '9
                End If
            End If
            objstream.Write("" + ",") '10
            objstream.Write("" + ",") '11

            If TDOC = "01" Then
                If Trim(MAIL) <> String.Empty Then
                    objstream.Write(MAIL) '12
                Else
                    objstream.Write("") '12
                End If
            End If
            objstream.WriteLine() ''LIN5

            objstream.Write(ImprimeTotalLetras(DblTotalBase, "SOLES") + ",") '1
            objstream.Write("" + ",") '2
            objstream.Write("" + ",") '3
            objstream.Write("" + ",") '4
            objstream.Write("" + ",") '5
            objstream.Write("" + ",") '6
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("") '10
            objstream.WriteLine() ''LIN6

            If StrPlaca <> String.Empty Then
                objstream.Write("PLACA(S): " + StrPlaca + ",")  '1
            Else
                objstream.Write("" + ",") '1
            End If
            objstream.Write("" + ",") '2
            objstream.Write("" + ",") '3
            objstream.Write("" + ",") '4
            objstream.Write("" + ",") '5
            objstream.Write("" + ",") '6
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("" + ",") '10
            objstream.Write("" + ",") '11
            objstream.Write("" + ",") '12
            objstream.Write("" + ",") '13
            objstream.Write("" + ",") '14
            objstream.Write("" + ",") '15
            objstream.Write("" + ",") '16
            objstream.Write("" + ",") '17
            objstream.Write("" + ",") '18
            objstream.Write("" + ",") '19
            objstream.Write("") '20
            objstream.WriteLine() ''LIN7


            ' DETALLE
            Dim OFILADET As DataRow
            For Each OFILADET In RsDetalleTemporal.Rows
                Dim LstrProducto As String
                Dim LstrDescripcion As String
                objstream.Write("1" + ",") '1
                If OFILADET.Item("AUMESUNAT") = "GLL" Then
                    objstream.Write("Galones" + ",") '2
                End If
                If OFILADET.Item("AUMESUNAT") = "LTR" Then
                    objstream.Write("Litros" + ",") '2
                End If
                If OFILADET.Item("AUMESUNAT") = "NIU" Then
                    objstream.Write("Unidades" + ",") '2
                End If
                objstream.Write(GFormatodeNumero(OFILADET.Item("CANTIDAD"), 4) + ",") '3
                objstream.Write(Trim(OFILADET.Item("DESCRIPCION")) + ",") '4
                objstream.Write(COMAS(GFormatodeNumero(OFILADET.Item("PU"), 2)).ToString + ",") '5
                objstream.Write("01" + ",") '6
                objstream.Write("" + ",") '7
                objstream.Write("" + ",") '8
                objstream.Write(COMAS(GFormatodeNumero(DblIGVBase, 2).ToString).ToString + ",") '9
                objstream.Write(COMAS(GFormatodeNumero(DblIGVBase, 2).ToString()).ToString + ",") '10
                objstream.Write("10" + ",") '11
                objstream.Write("1000" + ",") '12
                objstream.Write(CStr(GFormatodeNumero(PIGV, 2).ToString) + ",") '13
                objstream.Write("" + ",") '14
                objstream.Write("" + ",") '15
                objstream.Write("" + ",") '16
                objstream.Write("" + ",") '17
                objstream.Write("" + ",") '18
                objstream.Write(Trim(OFILADET.Item("CODIGO")) + ",") '19
                objstream.Write(COMAS(GFormatodeNumero(OFILADET.Item("PU") / (1 + (PIGV / 100)), 2)).ToString + ",") '20
                objstream.Write(COMAS(GFormatodeNumero(OFILADET.Item("TOTAL") / (1 + (PIGV / 100)), 2).ToString).ToString + ",") '21
                objstream.Write("" + ",") '22
                objstream.Write(COMAS(GFormatodeNumero(OFILADET.Item("TOTAL"), 2).ToString).ToString + ",") '23
                objstream.Write("" + ",") '24
                objstream.Write("" + ",") '25
                objstream.Write("" + ",") '26
                objstream.Write("" + ",") '27
                objstream.Write("" + ",") '28
                objstream.Write("" + ",") '29
                objstream.Write("" + ",") '30
                objstream.Write("" + ",") '31
                objstream.Write("" + ",") '32
                objstream.Write("" + ",") '33
                objstream.Write("" + ",") '34
                objstream.Write("" + ",") '35
                objstream.Write("") '36
            Next
            objstream.WriteLine() ''LIN8
            ''
            objstream.Write("FF00FF")

            ''Dim F As Integer = 1
            ''For Each OFILATARJ In RSTARJETAS.Rows
            ''    objstream.Write(Trim(OFILATARJ.Item("ATARDESC")) + " " + Trim(OFILATARJ.Item("ATMPDESC")) + " " + CFG_SIMBMONEDA + " " + OBJFUNC.GFormatodeNumero(OFILATARJ.Item("ATMPIMPO"), CFG_DRESULT))
            ''    objstream.Write("|")
            ''    F = F + 1
            ''Next

            ''If RSTARJETAS.Rows.Count > 0 Then
            ''    objstream.Write("TARJETA" + "|")
            ''Else
            ''    objstream.Write("EFECTIVO" + "|")
            ''End If


            FactImprimir_ASPNET = True
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            objstream.Close()
            objFSO = Nothing
            objstream = Nothing


        End Try



    End Function
    Public Function BAJA_ASPNET(FECHA_DOC As Date, RUC_CIA As String, DESC_CIA As String, UBIGEO_CIA As String, DIR_CIA As String,
                              strTipoDoc As String, StrNumerodeTicket As String
      ) As Boolean

        'Dim OBJFUNC As New ClSFunciones
        'Dim OBJCONN As New ClsConexion
        Dim OBJCONFIG As New ClsConfig

        Dim objFSO
        'Dim objStream
        Dim NOMBRE_FILE As String
        Dim TDOC As String
        Dim NRODOC As String
        Dim RUTA As String
        Dim DatFechaImpresion As Date
        OBJCONFIG.LISTAR_CONFIG_V2()

        If Strings.Right(strTipoDoc.Trim, 4) = "BOL." Then
            NOMBRE_FILE = "RA-" + OBJCONFIG.RucConfig + "-" + "03" + "-" + "B" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            NRODOC = "B" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            TDOC = "03"
            RUTA = SISTEMA_ASPNET_RUTA + "\voided\"
        Else
            NOMBRE_FILE = "RA-" + OBJCONFIG.RucConfig + "-" + "01" + "-" + "F" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            NRODOC = "F" + Strings.Left(StrNumerodeTicket, 3) + "-00" + Strings.Right(StrNumerodeTicket, 6)
            TDOC = "01"
            RUTA = SISTEMA_ASPNET_RUTA + "\voided\"
        End If

        PObtener_FechaServidor()
        DatFechaImpresion = GDatFechaActual

        Dim objstream As System.IO.StreamWriter
        objstream = System.IO.File.CreateText(RUTA + NOMBRE_FILE + ".csv")

        Try

            objstream.Write(Format(DatFechaImpresion, "dd/MM/yyyy") + ",") '1
            objstream.Write(Format(FECHA_DOC, "dd/MM/yyyy") + ",") '2
            objstream.Write("RA-" + Format(DatFechaImpresion, "yyyyMMdd") + "-1" + ",") '3
            objstream.Write("" + ",") '4
            objstream.Write("" + ",") '5
            objstream.Write("" + ",") '6
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("" + ",") '10
            objstream.Write("" + ",") '11
            objstream.Write("" + ",") '12
            objstream.Write("")  '13
            objstream.WriteLine() 'LIN1

            'DATOS DEL EMISOR
            objstream.Write(DESC_CIA + ",") '1
            objstream.Write(DESC_CIA + ",") '2
            objstream.Write(RUC_CIA + ",") '3
            objstream.Write(UBIGEO_CIA + ",") '4
            objstream.Write(DIR_CIA + ",") '5
            objstream.Write("" + ",") '6
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("" + ",") '10
            objstream.Write("" + ",") '11
            objstream.Write("" + ",") '12
            objstream.Write("") '13
            objstream.WriteLine() ''LIN2


            objstream.Write("1" + ",") '1
            objstream.Write(TDOC + ",") '2
            objstream.Write(Strings.Left(NRODOC, 4) + ",") '3
            objstream.Write("00" + Strings.Right(StrNumerodeTicket, 6) + ",") '4
            objstream.Write("CANCELACION" + ",") '5
            objstream.Write("" + ",") '6
            objstream.Write("" + ",") '7
            objstream.Write("" + ",") '8
            objstream.Write("" + ",") '9
            objstream.Write("" + ",") '10
            objstream.Write("") '11
            objstream.WriteLine() ''LIN3
            objstream.Write("FF00FF")

            BAJA_ASPNET = True
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

            objstream.Close()
            objFSO = Nothing
            objstream = Nothing


        End Try



    End Function

    Sub BUSCAR_HASH(DOC As String, TDOC As String, OBJCONFIG As ClsConfig, REIMPRIME As Integer)
        Dim RUTA As String
        Dim COD_HASH As String
        Dim FDOC As String = Strings.Left(FormatoTicket(DOC), Strings.InStr(FormatoTicket(DOC), "-")) + "0" + Mid(FormatoTicket(DOC), Strings.InStr(FormatoTicket(DOC), "-") + 1, 7)
ACA:
        System.Threading.Thread.Sleep(3000)
        If TDOC = OBJCONFIG.Config_Factura Then
            RUTA = SISTEMA_ASPNET_RUTA_HASH + "\invoice\" + "F" + (FDOC) + ".txt"
        End If
        If TDOC = OBJCONFIG.Config_Boleta Then
            RUTA = SISTEMA_ASPNET_RUTA_HASH + "\boleta\" + "B" + (FDOC) + ".txt"
        End If
        If File.Exists(RUTA) Then
            Dim sr As New System.IO.StreamReader(RUTA)
            COD_HASH = sr.ReadToEnd()
            sr.Close()
            ''
            IMP_ASP_NET(DOC, TDOC, COD_HASH, OBJCONFIG, REIMPRIME)
        Else
            GoTo ACA
        End If
    End Sub
    Sub IMP_ASP_NET(ID As Double, TIPODOC As String, COD_HASH As String, OBJCONFIG As ClsConfig, REIMPRIME As Integer, Optional ESTADO As String = "") '', ruta As String)
        Dim DOCU As String
        Dim TDOC As String
        Dim OBJVTA As New ClsVenta
        Dim OBJPTOVTA As New ClsPtoVta
        With OBJVTA
            ''.Codigo = ID
            ''
            Select Case TIPODOC
                Case OBJCONFIG.Config_Factura
                    DOCU = " FACT."
                    TDOC = "F"
                Case OBJCONFIG.Config_Boleta
                    DOCU = " BOL. "
                    TDOC = "B"
            End Select
            ''
            Dim DT_VENTA As DataTable
            DT_VENTA = LLENAR_DATA_TABLE("VENTA_MOSTRAR_CABECERA '" & TIPODOC & "'," & ID & "", CN_NET)
            Dim OFILA As DataRow
            For Each OFILA In DT_VENTA.Rows
                ''
                ''With OBJPTOVTA
                ''    .PtoVtaCod = COD_TERMINAL
                ''    .PtoVtaD_TDoc = OFILA.Item("AVTATDOC")
                ''    .BUSCAR_DATOS_VENTA(OBJCONN.Conexion(CAD_CON))
                ''End With
                'IMPRIMIR
                IMPRIMIR(TIPODOC, 0, ESTADO, ID, NULO(OFILA.Item("DESC_CLIENTE"), "S"), NULO(OFILA.Item("RUC_CLIENTE"), "S"), NULO(OFILA.Item("DIR_CLIENTE"), "S"), OFILA.Item("DSCTO_VENTA"), OFILA.Item("SUBTOT_VENTA"), OFILA.Item("IGV_VENTA"), OFILA.Item("TOTAL_VENTA"), GDatFechaActual, Date.Now, COD_HASH, OFILA.Item("GRATUITA_VENTA"))

                ''Call FactImprimir_Ticket(ESTADO, OBJFUNC.GFormatodeNumero(OFILA.Item("ACAMVTAS"), CFG_DRESULT),
                ''                                             DOCU, OBJFUNC.GMascaraDoc(OFILA.Item("AVTANUME")),
                ''                                             39, OFILA.Item("ACLIDESC"), OFILA.Item("ACLINRUC"), OFILA.Item("ACLIDIRE"),
                ''                                             OBJCONFIG.ConfigMonB, MlonCorrelativo, OFILA.Item("AVTASTOT"),
                ''                                             0, OFILA.Item("AVTAMIGV"), 0, OFILA.Item("AVTATOTA"), 0,
                ''                                              0, 0, OFILA.Item("AMTOEFECBAS"), OFILA.Item("AMTOEFECEXT"), OFILA.Item("AMTOVLTOBAS"),
                ''                                             0, OBJFUNC.LLENAR_DATA_TABLE("BUSCAR_DOCUMENTOS_DETALLE " & .Codigo & ",'" & TDOC & "'", OBJCONN.Conexion(CAD_CON)), "01", 0, OFILA.Item("AUSULOGI"),
                ''                                             OFILA.Item("PTO_BONUS"), OFILA.Item("AVTAPLAC"), 0, 0, OBJFUNC.LLENAR_DATA_TABLE("BUSCAR_DOCUMENTOS_TARJETA " & .Codigo & "", OBJCONN.Conexion(CAD_CON)), REIMPRIME, OFILA.Item("AVTAFEPO"), ,
                ''                                         OBJPTOVTA.PtoVtaSerie, OBJPTOVTA.PtoVtaD_Dispositivo,
                ''                                              OBJPTOVTA.PtoVta_Autorizacion, OBJPTOVTA.PtoVtaD_User, OBJPTOVTA.PtoVtaD_Clave, OFILA.Item("AVTAHORA"), REG_CONSOLA, COD_HASH)



            Next
            Try


                ''My.Computer.FileSystem.DeleteFile(ruta)
            Catch ex As Exception

            End Try
        End With
    End Sub
End Module
