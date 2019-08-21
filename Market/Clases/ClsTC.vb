Public Class ClsTC
    Dim SQL As String
    Dim CN As SqlConnection
    Public Function MANT_TC(ByVal FECHA As Date, ByVal COMPRA As Double, ByVal VENTA As Double, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer

        'Cmn = New ADODB.Command
        CN_NET.Open()
        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_TC"

        Dim paramFECHA As SqlParameter = New SqlParameter("@FECHA", SqlDbType.DateTime)
        paramFECHA.Value = Format(FECHA, "dd/MM/yyyy")
        Cmn.Parameters.Add(paramFECHA)
        Dim paramCOMPRA As SqlParameter = New SqlParameter("@COMPRA", SqlDbType.Float)
        paramCOMPRA.Value = COMPRA
        Cmn.Parameters.Add(paramCOMPRA)
        Dim paramVENTA As SqlParameter = New SqlParameter("@VENTA", SqlDbType.Float)
        paramVENTA.Value = VENTA
        Cmn.Parameters.Add(paramVENTA)
        Dim paramTIPO As SqlParameter = New SqlParameter("@TIP", SqlDbType.Char, 1)
        paramTIPO.Value = STRTIPO
        Cmn.Parameters.Add(paramTIPO)
        Dim paramResultado As SqlParameter = New SqlParameter("@ingproc_001", SqlDbType.Int)
        paramResultado.Direction = ParameterDirection.Output
        Cmn.Parameters.Add(paramResultado)

        'Cmn.Parameters.AddWithValue("@FECHA", Format(FECHA, "dd/MM/yyyy"))
        'Cmn.Parameters.AddWithValue("@COMPRA", COMPRA)
        'Cmn.Parameters.AddWithValue("@VENTA", VENTA)
        'Cmn.Parameters.AddWithValue("@TIP", STRTIPO)
        'Cmn(1).Value = Format(FECHA, "dd/MM/yyyy")
        'Cmn(2).Value = COMPRA
        'Cmn(3).Value = VENTA
        'Cmn(4).Value = STRTIPO
        'Cmn(5).Value = 0
        Cmn.ExecuteReader()

        intValidar = paramResultado.Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_TC = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando Tipo de Cambio", Err.Description)
    End Function
    Public Function BUSCAR_TC(ByVal FECHA As Date, ByVal TIPO As String) As Double
        Try
            Dim CN As New SqlConnection
            CN.ConnectionString = CAD_CON
            Dim RS As SqlDataReader 'New ADODB.Recordset
            BUSCAR_TC = 0
            SQL = "EXEC BUSCAR_TC '" & Format(FECHA, "dd/MM/yyyy") & "'"
            Dim OCOMANDO As New SqlCommand(SQL, CN)
            CN.Open()
            RS = OCOMANDO.ExecuteReader
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            While RS.Read
                If TIPO = "C" Then
                    BUSCAR_TC = RS("COMPRA")
                Else
                    BUSCAR_TC = RS("VENTA")
                End If
            End While
            RS.Close()
            CN.Close()
        Catch ex As Exception
            CN.Close()
            MsgBox(Err.Description)
        End Try
    End Function
End Class
