Public Class ClsCompra

    Public ID As Double
    Public Function GRABAR(ByVal ID_COMPRA As Integer, ByVal COD_DOC As String, ByVal SERIE_COMPRA As String, ByVal NUM_COMPRA As String, ByVal FECHA_COMPRA As Date,
                        ByVal VENC_COMPRA As Date, ByVal COD_PROVED As String, ByVal MON_COMPRA As String, ByVal TC_COMPRA As Double, ByVal INC_COMPRA As Integer, ByVal COD_FP As String,
    ByVal SUBT_COMPRA As Double, ByVal IGV_COMPRA As Double, ByVal TOTAL_COMPRA As Double, ByVal COD_USER As String, ByVal OBS_COMPRA As String, COD_ALMACEN As Double,
                         NRO_PERCEP As String, PERCEP_COMPRA As Double,
                          ByVal TIPO As String, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid) As Integer

        On Error GoTo TrataError
        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand
        Dim intValidar As Integer
        Dim F As Integer
        Dim SQL As String


        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "GRABAR_COMPRA"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@ID_COMPRA", SqlDbType.Int)
        CMN.Parameters("@ID_COMPRA").Value = ID_COMPRA
        CMN.Parameters.Add("@COD_DOC", SqlDbType.Char)
        CMN.Parameters("@COD_DOC").Value = COD_DOC
        CMN.Parameters.Add("@SERIE_COMPRA", SqlDbType.VarChar)
        CMN.Parameters("@SERIE_COMPRA").Value = SERIE_COMPRA
        CMN.Parameters.Add("@NUM_COMPRA", SqlDbType.VarChar)
        CMN.Parameters("@NUM_COMPRA").Value = NUM_COMPRA
        CMN.Parameters.Add("@FECHA_COMPRA", SqlDbType.DateTime)
        CMN.Parameters("@FECHA_COMPRA").Value = FECHA_COMPRA
        CMN.Parameters.Add("@VENC_COMPRA", SqlDbType.DateTime)
        CMN.Parameters("@VENC_COMPRA").Value = VENC_COMPRA
        CMN.Parameters.Add("@COD_PROVED", SqlDbType.Char)
        CMN.Parameters("@COD_PROVED").Value = COD_PROVED
        CMN.Parameters.Add("@MON_COMPRA", SqlDbType.Char)
        CMN.Parameters("@MON_COMPRA").Value = MON_COMPRA
        CMN.Parameters.Add("@TC_COMPRA", SqlDbType.Float)
        CMN.Parameters("@TC_COMPRA").Value = TC_COMPRA
        CMN.Parameters.Add("@INC_COMPRA", SqlDbType.Bit)
        CMN.Parameters("@INC_COMPRA").Value = INC_COMPRA
        CMN.Parameters.Add("@COD_FP", SqlDbType.Char)
        CMN.Parameters("@COD_FP").Value = COD_FP
        CMN.Parameters.Add("@SUBT_COMPRA", SqlDbType.Float)
        CMN.Parameters("@SUBT_COMPRA").Value = SUBT_COMPRA
        CMN.Parameters.Add("@IGV_COMPRA", SqlDbType.Float)
        CMN.Parameters("@IGV_COMPRA").Value = IGV_COMPRA
        CMN.Parameters.Add("@TOTAL_COMPRA", SqlDbType.Float)
        CMN.Parameters("@TOTAL_COMPRA").Value = TOTAL_COMPRA
        CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
        CMN.Parameters("@COD_USER").Value = COD_USER
        CMN.Parameters.Add("@OBS_COMPRA", SqlDbType.VarChar)
        CMN.Parameters("@OBS_COMPRA").Value = OBS_COMPRA

        CMN.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        CMN.Parameters("@COD_ALMACEN").Value = COD_ALMACEN

        CMN.Parameters.Add("@NRO_PERCEP", SqlDbType.VarChar, 15)
        CMN.Parameters("@NRO_PERCEP").Value = NRO_PERCEP
        CMN.Parameters.Add("@PERCEP_COMPRA", SqlDbType.Float)
        CMN.Parameters("@PERCEP_COMPRA").Value = PERCEP_COMPRA

        CMN.Parameters.Add("@TIPO", SqlDbType.Char)
        CMN.Parameters("@TIPO").Value = TIPO
        CMN.Parameters.Add("@ID", SqlDbType.Float)
        CMN.Parameters("@ID").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
        CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        ID = CMN.Parameters("@ID").Value
        intValidar = CMN.Parameters("@ingproc_001").Value

        GRABAR = intValidar
        ''GRABAR DETALLE
        If intValidar = 0 Then
            For F = 1 To FLEX.Rows.Count - 1
                SQL = "EXEC GRABAR_COMPRA_DETALLE " & ID & "," & F & ",'" & FLEX.Item(F, 0) & "'," & FLEX.Item(F, 3) & "," & FLEX.Item(F, 4) & ",'" & Format(FECHA_COMPRA, "dd/MM/yyyy") & "','" & MON_COMPRA & "'," & INC_COMPRA & "," & IGV & ",'" & COD_USER & "'," & TC_COMPRA & "," & COD_ALMACEN & ""
                Dim OCOMANDO As New SqlCommand(SQL, CNN)
                OCOMANDO.ExecuteNonQuery()
            Next
        End If
TrataError:
        CNN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando COMPRAS", Err.Description)
    End Function
    Public Function BUSCAR_COMPRA(ByVal ID As Double) As DataTable 'SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String
            Dim ODATASET As New DataSet ' SqlDataReader 'New ADODB.Recordset
            SQL = "EXEC BUSCAR_COMPRA " & ID & ""
            Dim ODATAADAPTER As New SqlDataAdapter(SQL, CN_NET)
            CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ODATAADAPTER.Fill(ODATASET, "SQL")
            'BUSCAR_COMPRA = OCOMANDO.ExecuteReader
            CN_NET.Close()
            BUSCAR_COMPRA = ODATASET.Tables("SQL")
        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function ANULAR_COMPRA(ByVal ID As Double) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand
            'Dim intValidar As Integer
            'Dim SQL As String

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "ANULAR_COMPRA"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@ID_COMPRA", SqlDbType.Int)
            CMN.Parameters("@ID_COMPRA").Value = ID
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            ANULAR_COMPRA = CMN.Parameters("@SW").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function MANT_PAGO(ID_PAGO As Integer, FECHA_PAGO As Date, COD_TPAGO As Double,
                   MON_PAGO As String, TC_PAGO As Double, MONTO_PAGO As Double,
                   ABANCODI As Integer, REF_PAGO As String, OBS_PAGO As String,
                   ACTACODI As Double,
                   intMODO As String, cn As SqlConnection) As Integer
        Try
            'Dim intValidar As Integer
            Dim CMN As New SqlCommand
            CMN.Connection = cn
            CMN.CommandType = CommandType.StoredProcedure
            ''
            CMN.CommandText = "MANT_PAGO"
            CMN.Parameters.Add("@ID_COMPRA", SqlDbType.BigInt)
            CMN.Parameters("@ID_COMPRA").Value = ID
            CMN.Parameters.Add("@ID_PAGO", SqlDbType.Int)
            CMN.Parameters("@ID_PAGO").Value = ID_PAGO
            CMN.Parameters.Add("@FECHA_PAGO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_PAGO").Value = Format(FECHA_PAGO, "dd/MM/yyyy")
            CMN.Parameters.Add("@COD_TPAGO", SqlDbType.BigInt)
            CMN.Parameters("@COD_TPAGO").Value = COD_TPAGO
            CMN.Parameters.Add("@MON_PAGO", SqlDbType.Char, 1)
            CMN.Parameters("@MON_PAGO").Value = MON_PAGO
            CMN.Parameters.Add("@TC_PAGO", SqlDbType.Float)
            CMN.Parameters("@TC_PAGO").Value = TC_PAGO
            CMN.Parameters.Add("@MONTO_PAGO", SqlDbType.Float)
            CMN.Parameters("@MONTO_PAGO").Value = MONTO_PAGO
            CMN.Parameters.Add("@ABANCODI", SqlDbType.TinyInt)
            CMN.Parameters("@ABANCODI").Value = ABANCODI
            CMN.Parameters.Add("@REF_PAGO", SqlDbType.VarChar, 30)
            CMN.Parameters("@REF_PAGO").Value = REF_PAGO
            CMN.Parameters.Add("@OBS_PAGO", SqlDbType.VarChar, 350)
            CMN.Parameters("@OBS_PAGO").Value = OBS_PAGO

            CMN.Parameters.Add("@ACTACODI", SqlDbType.TinyInt)
            CMN.Parameters("@ACTACODI").Value = ACTACODI


            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@TIP", SqlDbType.Char, 1)
            CMN.Parameters("@TIP").Value = intMODO
            CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
            CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output
            cn.Open()
            CMN.ExecuteNonQuery()
            MANT_PAGO = CMN.Parameters("@ingproc_001").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            cn.Close()
        End Try
    End Function


End Class
