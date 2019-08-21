Public Class ClsPtoVta
    Public Function MANT_PTOVTA(ByVal APTOCODI As String, ByVal APTOEDIT As Integer, ByVal APTOFEPO As Date,
    ByVal APTOTERM As String, ByVal APTOSTAT As Integer, COD_ALMACEN As Double,
                                ByVal TIPO As String, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, ByVal APTOREG As String) As Integer

        On Error GoTo TrataError
        Dim intValidar As Integer
        Dim F As Integer
        Dim SQL As String
        On Error GoTo TrataError

        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "MANT_PTOVTA"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@APTOCODI", SqlDbType.NVarChar)
        CMN.Parameters("@APTOCODI").Value = APTOCODI
        CMN.Parameters.Add("@APTOEDIT", SqlDbType.Bit)
        CMN.Parameters("@APTOEDIT").Value = APTOEDIT
        CMN.Parameters.Add("@APTOFEPO", SqlDbType.SmallDateTime)
        CMN.Parameters("@APTOFEPO").Value = Format(APTOFEPO, "dd/MM/yyyy")
        CMN.Parameters.Add("@APTOTERM", SqlDbType.VarChar)
        CMN.Parameters("@APTOTERM").Value = APTOTERM
        CMN.Parameters.Add("@APTOSTAT", SqlDbType.Bit)
        CMN.Parameters("@APTOSTAT").Value = APTOSTAT
        CMN.Parameters.Add("@APTOREG", SqlDbType.VarChar)
        CMN.Parameters("@APTOREG").Value = APTOREG

        CMN.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        CMN.Parameters("@COD_ALMACEN").Value = COD_ALMACEN


        CMN.Parameters.Add("@TIP", SqlDbType.Char)
        CMN.Parameters("@TIP").Value = TIPO
        CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
        CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        MANT_PTOVTA = CMN.Parameters("@INGPROC_001").Value
        Dim OCOMANDO As SqlCommand
        If MANT_PTOVTA = 0 Then
            For F = 1 To FLEX.Rows.Count - 1
                SQL = "EXEC PTOVTA_GRABAR_DETALLE '" & APTOCODI & "'," & F & ",'" & FLEX.Item(F, 0) & "'," & FLEX.Item(F, 2) & ",'" & FLEX.Item(F, 3) & "'," & FLEX.Item(F, 4) & ""
                'Cnscb.conexion.Execute(SQL)
                OCOMANDO = New SqlCommand(SQL, CNN)
                OCOMANDO.ExecuteNonQuery()
            Next
        End If


TrataError:
        CMN = Nothing
        CNN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "STOCK INICIAL", Err.Description)
    End Function
    Public Function BUSCAR(ByVal COD As String) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            'Dim RS As New ADODB.Recordset
            SQL = "EXEC PTOVTA_BUSCAR 0,'" & COD & "',0"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            BUSCAR = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function BUSCAR_PORTIMP(ByVal COD_DOC As String) As String
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "PTOVTA_BUSCAR_PORTIMP"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_DOC", SqlDbType.VarChar)
            CMN.Parameters("@COD_DOC").Value = COD_DOC
            CMN.Parameters.Add("@TERMINAL", SqlDbType.VarChar)
            CMN.Parameters("@TERMINAL").Value = SystemInformation.ComputerName
            CMN.Parameters.Add("@PORT", SqlDbType.VarChar, 50)
            CMN.Parameters("@PORT").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            BUSCAR_PORTIMP = CMN.Parameters("@PORT").Value

            CNN.Close()

        Catch ex As Exception

            MsgBox(Err.Description)
        End Try
    End Function

    Public Function BUSCAR_PORTIMP_NRO_IMP(ByVal COD_DOC As String) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "PTOVTA_BUSCAR_NRO_IMP"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_DOC", SqlDbType.VarChar)
            CMN.Parameters("@COD_DOC").Value = COD_DOC
            CMN.Parameters.Add("@TERMINAL", SqlDbType.VarChar)
            CMN.Parameters("@TERMINAL").Value = SystemInformation.ComputerName
            CMN.Parameters.Add("@PORT", SqlDbType.Int)
            CMN.Parameters("@PORT").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            BUSCAR_PORTIMP_NRO_IMP = CMN.Parameters("@PORT").Value

            CNN.Close()

        Catch ex As Exception

            MsgBox(Err.Description)
        End Try
    End Function
End Class
