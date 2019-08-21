Module ModFunciones
    Sub COLOR_FOCO(OBJ As Object, TIPO As String)
        If TIPO = "F" Then
            OBJ.BackColor = GC_ColorEnfoque
        Else
            OBJ.BackColor = GC_ColorDefecto
        End If

    End Sub
    Public Sub LLENAR_COMBO(ByVal combo As Object, SQL As String, CAMPO_MOSTRAR As String, CAMPO_VALOR As String, CAD_CON As String)
        Try
            Dim Adapter As New SqlClient.SqlDataAdapter(SQL, CAD_CON)
            Dim table As New DataTable
            Adapter.Fill(table)
            combo.DisplayMember = CAMPO_MOSTRAR
            combo.ValueMember = CAMPO_VALOR
            combo.DataSource = table
            If table.Rows.Count > 0 Then combo.SelectedIndex = 0
        Catch ex As Exception

            MsgBox(Err.Description)
        End Try
    End Sub
    Function ImprimeTotalLetras(nume As Double, TMONEDA As String) As String
        '------------------------------------
        '  nume    : Cifra (incluye decimales)
        '  TMONEDA : Texto que debe indicar la moneda ("Nuevos Soles","Dolares")
        '------------------------------------

        Dim k, Y, n As Integer
        Dim c1, c2, c3, c4, z1, z, s, u, d, C, sys, cifra, xdec, xcad_dec As String
        Dim xlg As Double

        xlg = 12 - Len(Trim(CStr(Int(nume))))
        z1 = Space(xlg) & Trim(CStr(Int(nume)))
        xdec = Right(Format(nume - Int(nume), "#0.00"), 2)
        xcad_dec = " Y " + xdec + "/100"


        k = 1
        Y = 10
        n = 3
        Do While k <= 4
            z = Mid(z1, Y, 3)
            s = Mid(z, n, 1)
            If s = "1" Then
                u = "UNO"
                If k = 2 Or k = 3 Then
                    u = "UN"
                End If
            Else
                u = IIf(s = "2", "DOS", IIf(s = "3", "TRES", IIf(s = "4", "CUATRO",
            IIf(s = "5", "CINCO", IIf(s = "6", "SEIS", IIf(s = "7", "SIETE",
            IIf(s = "8", "OCHO", IIf(s = "9", "NUEVE", ""))))))))
            End If

            If Mid(z, n - 1, 1) = "1" Then
                If Mid(z, n, 1) = "0" Then
                    d = "DIEZ"
                Else
                    If Mid(z, n, 1) = "1" Then
                        d = "ONCE"
                        u = ""
                    Else
                        If Mid(z, n, 1) = "2" Then
                            d = "DOCE"
                            u = ""
                        Else
                            If Mid(z, n, 1) = "3" Then
                                d = "TRECE"
                                u = ""
                            Else
                                If Mid(z, n, 1) = "4" Then
                                    d = "CATORCE"
                                    u = ""
                                Else
                                    If Mid(z, n, 1) = "5" Then
                                        d = "QUINCE"
                                        u = ""
                                    Else
                                        d = "DIECI"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If Mid(z, n - 1, 1) = "2" Then
                    If Mid(z, n, 1) = "0" Then
                        d = "VEINTE"
                    Else
                        d = "VEINTE Y "
                    End If
                Else
                    If Mid(z, n - 1, 1) = "3" Then
                        If Mid(z, n, 1) = "0" Then
                            d = "TREINTA"
                        Else
                            d = "TREINTA Y "
                        End If
                    Else
                        If Mid(z, n - 1, 1) = "4" Then
                            If Mid(z, n, 1) = "0" Then
                                d = "CUARENTA"
                            Else
                                d = "CUARENTA Y "
                            End If
                        Else
                            If Mid(z, n - 1, 1) = "5" Then
                                If Mid(z, n, 1) = "0" Then
                                    d = "CINCUENTA"
                                Else
                                    d = "CINCUENTA Y "
                                End If
                            Else
                                If Mid(z, n - 1, 1) = "6" Then
                                    If Mid(z, n, 1) = "0" Then
                                        d = "SESENTA"
                                    Else
                                        d = "SESENTA Y "
                                    End If
                                Else
                                    If Mid(z, n - 1, 1) = "7" Then
                                        If Mid(z, n, 1) = "0" Then
                                            d = "SETENTA"
                                        Else
                                            d = "SETENTA Y "
                                        End If
                                    Else
                                        If Mid(z, n - 1, 1) = "8" Then
                                            If Mid(z, n, 1) = "0" Then
                                                d = "OCHENTA"
                                            Else
                                                d = "OCHENTA Y "
                                            End If
                                        Else
                                            If Mid(z, n - 1, 1) = "9" Then
                                                If Mid(z, n, 1) = "0" Then
                                                    d = "NOVENTA"
                                                Else
                                                    d = "NOVENTA Y "
                                                End If
                                            Else
                                                d = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If Mid(z, n - 2, 1) = "1" Then
                If Mid(z, n - 1, 1) = "0" And Mid(z, n, 1) = "0" Then
                    C = "CIEN"
                Else
                    C = "CIENTO"
                End If
            Else
                If Mid(z, n - 2, 1) = "2" Then
                    C = "DOSCIENTOS"
                Else
                    If Mid(z, n - 2, 1) = "3" Then
                        C = "TRESCIENTOS"
                    Else
                        If Mid(z, n - 2, 1) = "4" Then
                            C = "CUATROCIENTOS"
                        Else
                            If Mid(z, n - 2, 1) = "5" Then
                                C = "QUINIENTOS"
                            Else
                                If Mid(z, n - 2, 1) = "6" Then
                                    C = "SEISCIENTOS"
                                Else
                                    If Mid(z, n - 2, 1) = "7" Then
                                        C = "SETECIENTOS"
                                    Else
                                        If Mid(z, n - 2, 1) = "8" Then
                                            C = "OCHOCIENTOS"
                                        Else
                                            If Mid(z, n - 2, 1) = "9" Then
                                                C = "NOVECIENTOS"
                                            Else
                                                C = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Select Case k
                Case 1
                    c1 = C + " " + d + u
                Case 2
                    c2 = C + " " + d + u
                Case 3
                    c3 = C + " " + d + u
                Case 4
                    c4 = C + " " + d + u
            End Select
            k = k + 1
            Y = Y - 3
        Loop
        If (Len(c4) - 1) <> 0 Then
            If c4 = "UN" Then
                sys = " MILLON "
            Else
                sys = " MILLONES "
            End If
            cifra = c4 + " MIL " + c3 + sys + c2 + " MIL " + c1
        Else
            If (Len(c3) - 1) <> 0 Then
                If c3 = "UN" Then
                    sys = " MILLON "
                Else
                    sys = " MILLONES "
                End If
                cifra = c3 + sys + c2 + " MIL " + c1
            Else
                If (Len(c2) - 1) <> 0 Then
                    cifra = c2 + " MIL " + c1
                Else
                    If Len(c1) <> 0 Then
                        cifra = c1
                    End If
                End If
            End If
        End If
        TMONEDA = " " + TMONEDA

        ImprimeTotalLetras = Trim(cifra + xcad_dec + TMONEDA)
    End Function
    Function BUSCAR_CAMPO(ByVal TABLA As String, ByVal CAMPO As String, ByVal CAMPOB As String, ByVal DATO As String, CN_NET As SqlConnection) As String
        Try
            Dim SQL As String
            Dim RF As SqlDataReader
            SQL = "SELECT " & CAMPO & " FROM " & TABLA & " WHERE " & CAMPOB & "='" & DATO & "'"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
            RF = OCOMANDO.ExecuteReader
            While RF.Read
                BUSCAR_CAMPO = NULO(RF(0), "S")
            End While
            RF.Close()
            CN_NET.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function LLENAR_DATA_TABLE(ByVal SQL As String, CN As SqlConnection) As DataTable
        Try
            Dim ODATASET As New DataSet
            Dim ODATAADAPTER As New SqlDataAdapter(SQL, CN)
            If CN.State = ConnectionState.Closed Then CN.Open()
            ODATAADAPTER.SelectCommand.CommandTimeout = 0
            ODATAADAPTER.Fill(ODATASET, "SQL")
            CN.Close()
            LLENAR_DATA_TABLE = ODATASET.Tables("SQL")
        Catch ex As Exception
            CN.Close()
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function NULO(ByVal IVarDato As Object, ByVal TIPO As String) As Object
        ' funcion validas los datos obtenidos, si es null devuelve una cadena vacia
        ' de lo contrario devuelve el mismo datos
        ' parametro ingreso  : valor a evaluar
        If TIPO = "N" Then
            NULO = IIf(IVarDato Is DBNull.Value, 0, IVarDato)
        Else
            NULO = IIf(IVarDato Is DBNull.Value, "", IVarDato)
        End If

    End Function
    Public Function NUMERICO(DATO As Object) As Object
        NUMERICO = IIf(Not IsNumeric(DATO), 0, DATO)
    End Function
    Public Function GValidaRUC(strRUC As String) As Boolean
        Dim intUltimoDigito As Integer
        Dim intDigitoVerifi As Integer
        Dim intVal1 As Integer
        Dim intVal2 As Integer
        Dim intResul As Integer

        Dim intD1 As Integer
        Dim intD2 As Integer
        Dim intD3 As Integer
        Dim intD4 As Integer
        Dim intD5 As Integer
        Dim intD6 As Integer
        Dim intD7 As Integer
        Dim intD8 As Integer
        Dim intD9 As Integer
        Dim intD10 As Integer

        GValidaRUC = False

        strRUC = Trim(strRUC)

        If Len(strRUC) = 11 Then
            intUltimoDigito = CInt(Mid(strRUC, Len(strRUC), 1))
            intD10 = CInt(Mid(strRUC, Len(strRUC) - 1, 1))
            intD9 = CInt(Mid(strRUC, Len(strRUC) - 2, 1))
            intD8 = CInt(Mid(strRUC, Len(strRUC) - 3, 1))
            intD7 = CInt(Mid(strRUC, Len(strRUC) - 4, 1))
            intD6 = CInt(Mid(strRUC, Len(strRUC) - 5, 1))
            intD5 = CInt(Mid(strRUC, Len(strRUC) - 6, 1))
            intD4 = CInt(Mid(strRUC, Len(strRUC) - 7, 1))
            intD3 = CInt(Mid(strRUC, Len(strRUC) - 8, 1))
            intD2 = CInt(Mid(strRUC, Len(strRUC) - 9, 1))
            intD1 = CInt(Mid(strRUC, Len(strRUC) - 10, 1))

            intVal1 = 5 * intD1 + 4 * intD2 + 3 * intD3 + 2 * intD4 + 7 * intD5 + 6 * intD6 + 5 * intD7 + 4 * intD8 + 3 * intD9 + 2 * intD10
            intVal2 = intVal1 \ 11
            intResul = 11 - (intVal1 - (intVal2 * 11))

            If intResul = 10 Then
                intDigitoVerifi = 0
            Else
                If intResul = 11 Then
                    intDigitoVerifi = 1
                Else
                    intDigitoVerifi = intResul
                End If
            End If

            If intDigitoVerifi = intUltimoDigito Then
                GValidaRUC = True
            End If
        Else
            GValidaRUC = False
        End If

    End Function
    Public Function GVDATO(ByVal IVarDato As Object) As String
        'funcion    : validas los datos obtenidos, elimina mayusculas y espacios
        '               en blanco, elimina los nulos
        'parametro ingreso  : valor a cambiar
        'parametro salida  : cadena sin espacios ni nulos y en mayusculas
        IVarDato = Trim(UCase(NULO(IVarDato, "C")))
        GVDATO = IVarDato
    End Function
    Public Function duplicacarnoval1(ByVal X As String) As String
        Dim lg As Integer
        Dim resul As Integer
        Dim nuevacadena As String
        Dim caracternoval1 As String
        Dim aux As Integer
        Dim I As Integer
        caracternoval1 = "'"
        lg = Len(X)
        resul = InStr(X, caracternoval1)

        If resul = 0 Then
            duplicacarnoval1 = X
            Exit Function
        Else
            nuevacadena = Nothing
            For I = 1 To lg

                nuevacadena = nuevacadena & Mid(X, I, 1)
                aux = Len(nuevacadena)
                If Mid(X, I, 1) = caracternoval1 Then
                    nuevacadena = Mid(X, 1, aux - 1) 'nuevacadena & caracternoval
                End If
            Next
            duplicacarnoval1 = nuevacadena
        End If
    End Function
    Public Sub LLENAR_GRID(ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, SQL As String, CAD_CON As String)
        Try
            Dim Adapter As New SqlClient.SqlDataAdapter(SQL, CAD_CON)
            Dim table As New DataTable
            Adapter.SelectCommand.CommandTimeout = 120
            Adapter.Fill(table)
            FLEX.DataSource = table
            FLEX.AutoSizeCols()
        Catch ex As Exception

            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub DISEÑO_SERIE(ByVal DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid, ByVal FI As Integer, ByVal FF As Integer, ByVal CI As Integer, ByVal CF As Integer)
        If DBLISTAR.Rows.Count = 1 Then Exit Sub
        Dim s As C1.Win.C1FlexGrid.CellStyle = DBLISTAR.Styles("Info")

        If s Is Nothing Then
            s = DBLISTAR.Styles.Add("Info")
            s.BackColor = Color.Beige
        End If

        Dim rg As C1.Win.C1FlexGrid.CellRange = DBLISTAR.GetCellRange(FI, CI, FF, CF)

        rg.Style = s


    End Sub
    Public Sub DISEÑO_SAL(ByVal DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid, ByVal FI As Integer, ByVal FF As Integer, ByVal CI As Integer, ByVal CF As Integer)
        If DBLISTAR.Rows.Count = 1 Then Exit Sub
        Dim s As C1.Win.C1FlexGrid.CellStyle = DBLISTAR.Styles("Info1")

        If s Is Nothing Then
            s = DBLISTAR.Styles.Add("Info1")
            s.BackColor = Color.Aquamarine
        End If

        Dim rg As C1.Win.C1FlexGrid.CellRange = DBLISTAR.GetCellRange(FI, CI, FF, CF)

        rg.Style = s


    End Sub

    Public Function Encrip(ByVal X As String) As String
        Dim I As Integer, aux, Result, ult As String
        ult = Right(X, 1)
        aux = ""
        Result = ""
        I = 1

        If ult <> "*" Then    '  si es que no esta encriptado

            'Primero vamos a cambiar de lugar a la cadena.
            'Ej: "DAEBFC" -> "ABCDEFG"
            'Primero los pares, luego los impares

            Do While Len(X) > I
                aux = aux + Right(Left(X, I + 1), 1)
                I = I + 2
            Loop
            I = 1
            Do While Len(X) >= I
                aux = aux + Right(Left(X, I), 1)
                I = I + 2
            Loop

            ' Segundo, Vamos a manipular los ASCII

            I = 1
            Do While Len(aux) >= I
                Result = Result + Chr(Asc(Right(Left(aux, I), 1)) - 10)
                I = I + 1
            Loop
            Encrip = Result + "*"

        Else ' Si es qque ya esta encriptado
            X = Left(X, Len(X) - 1)

            ' Primero vamos a devolver el orden inicial
            '  Ej: ABCDEFG -> DAEBFC

            Do While Len(X) \ 2 + 1 >= I
                If Len(X) \ 2 + 1 > I Or Len(X) Mod 2 <> 0 Then
                    aux = aux + Right(Left(X, (Len(X) \ 2) + I), 1)
                End If

                If Len(X) \ 2 >= I Then
                    aux = aux + Right(Left(X, I), 1)
                End If

                I = I + 1
            Loop
            I = 1
            Do While Len(aux) >= I
                Result = Result + Chr(Asc(Right(Left(aux, I), 1)) + 10)
                I = I + 1
            Loop
            Encrip = Result
        End If
    End Function
    Function BUSCARCOD(ByVal TABLA As String, ByVal CAMPO As String, ByVal FORMATO As String) As String
        Try
            Dim SQL As String
            Dim RS As SqlDataReader 'New ADODB.Recordset

            SQL = "SELECT MAX(" & CAMPO & ") FROM " & TABLA & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            While RS.Read
                If RS(0) Is DBNull.Value Then
                    BUSCARCOD = Format(1, FORMATO)
                Else
                    BUSCARCOD = Format(RS(0) + 1, FORMATO)
                End If
            End While
            RS.Close()
            CN_NET.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function BUSCAR_EXISTE(ByVal TABLA As String, ByVal CAMPO As String, ByVal VALOR As String) As Boolean
        Try
            Dim SQL As String
            BUSCAR_EXISTE = False
            'Dim RS As New ADODB.Recordset
            Dim OREADER As SqlDataReader
            SQL = "SELECT " & CAMPO & " FROM " & TABLA & " WHERE " & CAMPO & "='" & VALOR & "'"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            OREADER = OCOMANDO.ExecuteReader
            'If Not (RS.EOF And RS.BOF) Then
            While OREADER.Read
                BUSCAR_EXISTE = True
            End While
            'RS.Close()
            OREADER.Close()
            CN_NET.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function ANULAR_CAMPO(ByVal TABLA As String, ByVal CAMPO As String, ByVal COND1 As String, ByVal VALOR1 As String, ByVal COND2 As String, ByVal VALOR2 As String, ByVal TIPO As Integer) As Boolean
        Try
            Dim SQL As String = ""
            Select Case TIPO
                Case 1
                    SQL = "UPDATE " & TABLA & " SET " & CAMPO & " =1 WHERE " & COND1 & "='" & VALOR1 & "'"
                Case 2
                    SQL = "UPDATE " & TABLA & " SET " & CAMPO & " =1 WHERE " & COND1 & "='" & VALOR1 & "' AND " & COND2 & "='" & VALOR2 & "'"
            End Select
            'Cnscb.conexion.Execute(SQL)
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            OCOMANDO.ExecuteNonQuery()
            CN_NET.Close()
            ANULAR_CAMPO = True
        Catch ex As Exception
            ANULAR_CAMPO = False
            MsgBox(Err.Description)
        End Try
    End Function
    Function GENERAR_CODIGO(ByVal TABLA As String, ByVal CAMPO As String, ByVal FORMATO As String) As String
        Try
            Dim SQL As String
            'Dim RS As New ADODB.Recordset
            'Dim OREADER As SqlDataReader
            Dim F As Integer
            SQL = "SELECT MAX(" & CAMPO & ") FROM " & TABLA & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            F = NULO(OCOMANDO.ExecuteScalar, "N")
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'If RS.Fields(0).Value Is DBNull.Value Then
            'GENERAR_CODIGO = Format(1, FORMATO)
            'Else
            GENERAR_CODIGO = Format(F + 1, FORMATO)
            CN_NET.Close()
            'End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Public Function GBloqueaNonumeros(ByVal KeyAscii As Integer) As Integer
        If (KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 13 Or KeyAscii = 8 Or KeyAscii = 46 Then
            GBloqueaNonumeros = KeyAscii
        Else
            GBloqueaNonumeros = 0
        End If
    End Function
    Public Sub GCargaDataCombo(ByVal objDataCombo As Object, ByVal rsSource As ADODB.Recordset, ByVal istrCampo1 As String, ByVal istrCampo2 As String)
        On Error Resume Next
        objDataCombo.RowSource = rsSource
        objDataCombo.ListField = istrCampo2
        objDataCombo.BoundColumn = istrCampo1
        If Not rsSource.EOF Then
            objDataCombo.BoundText = rsSource.Fields(istrCampo2)
        End If
    End Sub

    Sub LISTAR_TIPO_DOC(ByVal COMBO As ComboBox, ByVal TIPO As String)
        Dim Adapter As New SqlClient.SqlDataAdapter("EXEC LISTAR_TIPO_DOC '" & TIPO & "'", CN_NET)
        Dim table As New DataTable
        Adapter.Fill(table)
        COMBO.DisplayMember = "DESCRIPCION"
        COMBO.ValueMember = "CODIGO"
        COMBO.DataSource = table

    End Sub
    Sub LISTAR_TIPO_MOV(ByVal COMBO As ComboBox, ByVal TIPO As String)
        Dim Adapter As New SqlClient.SqlDataAdapter("EXEC LISTAR_TIPO_MOV '" & TIPO & "'", CN_NET)
        Dim table As New DataTable
        Adapter.Fill(table)
        COMBO.DisplayMember = "DESCRIPCION"
        COMBO.ValueMember = "CODIGO"
        COMBO.DataSource = table

    End Sub
    Public Function ArmaNumero(ByVal NroDoc As String) As Double
        Dim Serie As String
        Dim Numero As String
        Dim cadserie As Boolean
        Dim NUM As String

        Dim I As Integer

        cadserie = True
        For I = 1 To Len(NroDoc)
            If cadserie = True Then
                If Mid(NroDoc, I, 1) <> "-" Then
                    Serie = Serie & Mid(NroDoc, I, 1)
                Else
                    Serie = Serie 'Format(Serie, "0##")
                    cadserie = False
                End If
            Else
                Numero = Numero & Mid(NroDoc, I, 1)
            End If
        Next
        Numero = Numero 'Format(Numero, "0#####")

        NUM = (Serie & Numero)
        ArmaNumero = Val(NUM)
    End Function
    Public Function FormatoTicket(ByVal nroticket As Double) As String
        FormatoTicket = String.Format("{0:0##-#######}", nroticket)
    End Function

    Public Function Alineacion(ByVal Lugar As String, ByVal Tam_Campo As Integer, ByVal log_text As Integer, ByVal cont_text As String) As String
        If log_text > Tam_Campo Then
            log_text = Tam_Campo
            cont_text = Mid(cont_text, 1, Tam_Campo)
        End If

        Select Case Lugar
            Case "D"
                Alineacion = Space(Tam_Campo - log_text) + cont_text
            Case "I"
                Alineacion = cont_text + Space(Tam_Campo - log_text)
            Case "C"
                Alineacion = Space((Tam_Campo - log_text) / 2) + cont_text + Space((Tam_Campo - log_text) / 2)
        End Select

    End Function
    Public Function GMascara(ByVal IintNumerodeDecimales As Integer) As String
        Select Case IintNumerodeDecimales
            Case 0
                GMascara = "##,#####0"
            Case 1
                GMascara = "##,#####0.0"
            Case 2
                GMascara = "##,#####0.00"
            Case 3
                GMascara = "##,#####0.000"
            Case 4
                GMascara = "##,#####0.0000"
            Case 5
                GMascara = "##,#####0.00000"
            Case 6
                GMascara = "##,#####0.000000"
            Case 7
                GMascara = "##,#####0.0000000"
            Case 8
                GMascara = "##,#####0.00000000"
        End Select
    End Function
    Public Function GFormatodeNumero(ByVal IdblValor As Double, ByVal IintDecimales As Integer) As Object
        GFormatodeNumero = Format(IdblValor, GMascara(IintDecimales))

    End Function
    Function BUSCAR_PERMISO(ByVal NIVEL1 As String) As Boolean
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "BUSCAR_PERMISO"
        Cmn.Parameters.Add("@NIVEL1", SqlDbType.VarChar, 6)
        Cmn.Parameters("@NIVEL1").Value = NIVEL1
        Cmn.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
        Cmn.Parameters("@COD_USER").Value = GUSERID
        Cmn.Parameters.Add("@SW", SqlDbType.Bit)
        Cmn.Parameters("@SW").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        BUSCAR_PERMISO = Cmn.Parameters("@SW").Value

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando AREAS", Err.Description)

    End Function
    Function BUSCAR_CAMPO_NO_ANULADO(ByVal TABLA As String, ByVal CAMPO As String, ByVal CAMPOB As String, ByVal DATO As String, CAMPO_STAT As String) As String
        Try
            Dim SQL As String
            Dim RF As SqlDataReader
            SQL = "SELECT " & CAMPO & " FROM " & TABLA & " WHERE " & CAMPOB & "='" & DATO & "' AND " & CAMPO_STAT & "=0"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
            RF = OCOMANDO.ExecuteReader
            While RF.Read
                BUSCAR_CAMPO_NO_ANULADO = NULO(RF(0), "S")
            End While
            RF.Close()
            CN_NET.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function COMAS(ByVal MONTO As String) As Double
        COMAS = Val(Replace(MONTO, ",", ""))
    End Function

    Public Sub DISEÑO_CA(ByVal DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid, ByVal FI As Integer, ByVal FF As Integer, ByVal CI As Integer, ByVal CF As Integer)
        If DBLISTAR.Rows.Count = 1 Then Exit Sub
        Dim s As C1.Win.C1FlexGrid.CellStyle = DBLISTAR.Styles("Info")

        If s Is Nothing Then
            s = DBLISTAR.Styles.Add("Info")
            s.BackColor = Color.Aquamarine
            s.Font = New Font("Tahoma", 10, FontStyle.Bold)
            s.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        End If

        Dim rg As C1.Win.C1FlexGrid.CellRange = DBLISTAR.GetCellRange(FI, CI, FF, CF)

        rg.Style = s


    End Sub
    Public Function FORMAT_DECIMALES(ByVal VALOR As Double, ByVal NUM As Integer) As String
        Select Case NUM
            Case 0
                FORMAT_DECIMALES = Format(VALOR, "###,###,###")
            Case 1
                FORMAT_DECIMALES = Format(VALOR, "###,###,###.0")
            Case 2
                FORMAT_DECIMALES = Format(VALOR, "###,###,###.00")
            Case 3
                FORMAT_DECIMALES = Format(VALOR, "###,###,###.000")
            Case 4
                FORMAT_DECIMALES = Format(VALOR, "###,###,###.0000")
            Case 5
                FORMAT_DECIMALES = Format(VALOR, "###,###,###.00000")
        End Select
    End Function
    Public Sub DISEÑO_HONEY(ByVal DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid, ByVal FI As Integer, ByVal FF As Integer, ByVal CI As Integer, ByVal CF As Integer)
        If DBLISTAR.Rows.Count = 1 Then Exit Sub
        Dim s As C1.Win.C1FlexGrid.CellStyle = DBLISTAR.Styles("Honeydew")

        If s Is Nothing Then
            s = DBLISTAR.Styles.Add("Honeydew")
            s.BackColor = Color.Honeydew
        End If

        Dim rg As C1.Win.C1FlexGrid.CellRange = DBLISTAR.GetCellRange(FI, CI, FF, CF)

        rg.Style = s


    End Sub
    Public Sub DISEÑO_LETRA(ByVal DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid, ByVal FI As Integer, ByVal FF As Integer, ByVal CI As Integer, ByVal CF As Integer)
        If DBLISTAR.Rows.Count = 1 Then Exit Sub
        Dim s As C1.Win.C1FlexGrid.CellStyle = DBLISTAR.Styles("Info")

        If s Is Nothing Then
            s = DBLISTAR.Styles.Add("Info")
            s.BackColor = Color.LightGoldenrodYellow
        End If

        Dim rg As C1.Win.C1FlexGrid.CellRange = DBLISTAR.GetCellRange(FI, CI, FF, CF)

        rg.Style = s


    End Sub
End Module
