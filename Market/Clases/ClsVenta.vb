Public Class ClsVenta
    Public Function BUSCAR_CORR(ByVal COD_DOC As String) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "PTOVTA_CORR_DOC"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_DOC", SqlDbType.VarChar)
            CMN.Parameters("@COD_DOC").Value = COD_DOC
            CMN.Parameters.Add("@TERMINAL", SqlDbType.VarChar)
            CMN.Parameters("@TERMINAL").Value = SystemInformation.ComputerName
            CMN.Parameters.Add("@NUM", SqlDbType.Float)
            CMN.Parameters("@NUM").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            BUSCAR_CORR = CMN.Parameters("@NUM").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function AGREGAR_DETALLE(ByVal COD_ART As String, ByVal CANT As Double, ByVal CORR As Integer, TIPO As String) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "VENTA_AGREGAR_DETALLE"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@CORR", SqlDbType.Float)
            CMN.Parameters("@CORR").Value = CORR
            CMN.Parameters.Add("@COD_ART", SqlDbType.VarChar)
            CMN.Parameters("@COD_ART").Value = COD_ART
            CMN.Parameters.Add("@CANT", SqlDbType.Float)
            CMN.Parameters("@CANT").Value = CANT
            CMN.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar, 30)
            CMN.Parameters("@NROPTOVTA").Value = SystemInformation.ComputerName

            CMN.Parameters.Add("@TIPO", SqlDbType.Char, 1)
            CMN.Parameters("@TIPO").Value = TIPO

            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            AGREGAR_DETALLE = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Function AGREGAR_DSCTO_DETALLE(ByVal IDTEMP As Integer, ByVal TIPO As String, ByVal MONTO As Double, ByVal COND As String) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "VENTA_DSCTO_DETALLE"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@IDTMP", SqlDbType.Int)
            CMN.Parameters("@IDTMP").Value = IDTEMP
            CMN.Parameters.Add("@TIPO", SqlDbType.Char)
            CMN.Parameters("@TIPO").Value = TIPO
            CMN.Parameters.Add("@DESC", SqlDbType.Float)
            CMN.Parameters("@DESC").Value = MONTO
            CMN.Parameters.Add("@COND", SqlDbType.Char)
            CMN.Parameters("@COND").Value = COND
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            AGREGAR_DSCTO_DETALLE = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Function AGREGAR_DSCTO_DETALLE_V2(ByVal IDTEMP As Integer, CORR As Double, ByVal DESC As Double, CANT As Integer, TIPO As String) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "VENTA_DSCTO_DETALLE_V2"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@IDTMP", SqlDbType.Int)
            CMN.Parameters("@IDTMP").Value = IDTEMP
            CMN.Parameters.Add("@CORR", SqlDbType.Float)
            CMN.Parameters("@CORR").Value = CORR
            CMN.Parameters.Add("@DESC", SqlDbType.Float)
            CMN.Parameters("@DESC").Value = DESC
            CMN.Parameters.Add("@CANT", SqlDbType.Int)
            CMN.Parameters("@CANT").Value = CANT
            CMN.Parameters.Add("@TIPO", SqlDbType.Char, 1)
            CMN.Parameters("@TIPO").Value = TIPO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            AGREGAR_DSCTO_DETALLE_V2 = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub CARGAR_DETALLE(ByVal CORR As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("VENTA_LISTAR_DETALLE", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@CORR", SqlDbType.Float)
            da.SelectCommand.Parameters("@CORR").Value = CORR
            da.Fill(dt)
            FLEX.DataSource = dt

            ''FLEX.Cols(5).Format = "###,###,###.000"
            ''FLEX.Cols(6).Format = "###,###,###.000"
            ''FLEX.Cols(7).Format = "###,###,###.000"
            ''FLEX.Cols(8).Format = "###,###,###.000"
            ''FLEX.AutoSizeCol(5)
            ''FLEX.AutoSizeCol(6)
            ''FLEX.AutoSizeCol(7)
            ''FLEX.AutoSizeCol(8)
            ''FLEX.Cols(0).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub ELIMINAR_DETALLE(ByVal IDTEMP As Double)
        Dim SQL As String
        SQL = "EXEC VENTA_ELIMINAR_DETALLE " & IDTEMP & ""
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        CN_NET.Open()
        OCOMANDO.ExecuteNonQuery()
        CN_NET.Close()
        'Cnscb.conexion.Execute(SQL)
    End Sub
    Function GRABAR_VENTA(ByVal COD_DOC As String, ByVal NRODOCU As Double, ByVal MON_VENTA As String, ByVal CAMBIO_VENTA As Double,
    ByVal CDTIPOPAGO As String, ByVal FECHA_VENTA As Date, ByVal FECPROCESO As Date, ByVal TOTAL_VENTA As Double, ByVal SUBTOT_VENTA As Double,
    ByVal IGV_VENTA As Double, ByVal VUELTO_VENTA As Double, ByVal PAGOS_VENTA As Double, ByVal PAGOD_VENTA As Double, ByVal COD_CLIENTE As String,
    ByVal CIERREX As Integer, ByVal CIERREZ As Integer, ByVal COD_USER As String, ByVal NROPTOVTA As String, ByVal TURNO As Integer,
    ByVal CORR As Double, ByVal COD_TARJETA As String, ByVal MON_TARJETA As String, ByVal NRO_TARJETA As String, ByVal MONTO_TARJETA As Double,
                          DSCTO_VENTA As Double, GRATUITA_VENTA As Integer, MONTO_GRATUITA_VENTA As Double) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "GRABAR_VENTA"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_DOC", SqlDbType.VarChar)
            CMN.Parameters("@COD_DOC").Value = COD_DOC
            CMN.Parameters.Add("@NRODOCU", SqlDbType.Float)
            CMN.Parameters("@NRODOCU").Value = NRODOCU
            CMN.Parameters.Add("@MON_VENTA", SqlDbType.Char)
            CMN.Parameters("@MON_VENTA").Value = MON_VENTA
            CMN.Parameters.Add("@CAMBIO_VENTA", SqlDbType.Float)
            CMN.Parameters("@CAMBIO_VENTA").Value = CAMBIO_VENTA
            CMN.Parameters.Add("@CDTIPOPAGO", SqlDbType.Char)
            CMN.Parameters("@CDTIPOPAGO").Value = CDTIPOPAGO
            CMN.Parameters.Add("@FECHA_VENTA", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_VENTA").Value = Format(FECHA_VENTA, "dd/MM/yyyy")
            CMN.Parameters.Add("@FECPROCESO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECPROCESO").Value = Format(FECPROCESO, "dd/MM/yyyy")
            CMN.Parameters.Add("@TOTAL_VENTA", SqlDbType.Float)
            CMN.Parameters("@TOTAL_VENTA").Value = TOTAL_VENTA
            CMN.Parameters.Add("@SUBTOT_VENTA", SqlDbType.Float)
            CMN.Parameters("@SUBTOT_VENTA").Value = SUBTOT_VENTA
            CMN.Parameters.Add("@IGV_VENTA", SqlDbType.Float)
            CMN.Parameters("@IGV_VENTA").Value = IGV_VENTA
            CMN.Parameters.Add("@VUELTO_VENTA", SqlDbType.Float)
            CMN.Parameters("@VUELTO_VENTA").Value = VUELTO_VENTA
            CMN.Parameters.Add("@PAGOS_VENTA", SqlDbType.Float)
            CMN.Parameters("@PAGOS_VENTA").Value = PAGOS_VENTA
            CMN.Parameters.Add("@PAGOD_VENTA", SqlDbType.Float)
            CMN.Parameters("@PAGOD_VENTA").Value = PAGOD_VENTA
            CMN.Parameters.Add("@COD_CLIENTE", SqlDbType.VarChar)
            CMN.Parameters("@COD_CLIENTE").Value = COD_CLIENTE
            CMN.Parameters.Add("@CIERREX", SqlDbType.Int)
            CMN.Parameters("@CIERREX").Value = CIERREX
            CMN.Parameters.Add("@CIERREZ", SqlDbType.Int)
            CMN.Parameters("@CIERREZ").Value = CIERREZ
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = COD_USER
            CMN.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar)
            CMN.Parameters("@NROPTOVTA").Value = NROPTOVTA
            CMN.Parameters.Add("@TURNO", SqlDbType.Int)
            CMN.Parameters("@TURNO").Value = TURNO
            CMN.Parameters.Add("@CORR", SqlDbType.Float)
            CMN.Parameters("@CORR").Value = CORR
            CMN.Parameters.Add("@COD_TARJETA", SqlDbType.Char)
            CMN.Parameters("@COD_TARJETA").Value = COD_TARJETA
            CMN.Parameters.Add("@MON_TARJETA", SqlDbType.Char)
            CMN.Parameters("@MON_TARJETA").Value = MON_TARJETA
            CMN.Parameters.Add("@NRO_TARJETA", SqlDbType.Char)
            CMN.Parameters("@NRO_TARJETA").Value = NRO_TARJETA
            CMN.Parameters.Add("@MONTO_TARJETA", SqlDbType.Float)
            CMN.Parameters("@MONTO_TARJETA").Value = MONTO_TARJETA

            CMN.Parameters.Add("@DSCTO_VENTA", SqlDbType.Float)
            CMN.Parameters("@DSCTO_VENTA").Value = DSCTO_VENTA

            CMN.Parameters.Add("@GRATUITA_VENTA", SqlDbType.Bit)
            CMN.Parameters("@GRATUITA_VENTA").Value = GRATUITA_VENTA
            CMN.Parameters.Add("@MONTO_GRATUITA_VENTA", SqlDbType.Float)
            CMN.Parameters("@MONTO_GRATUITA_VENTA").Value = MONTO_GRATUITA_VENTA

            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR_VENTA = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Public Function MOSTRAR_CABECERA(ByVal COD_DOC As String, ByVal NRO_DOCU As String) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String

            SQL = "EXEC VENTA_MOSTRAR_CABECERA '" & COD_DOC & "'," & NRO_DOCU & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            MOSTRAR_CABECERA = OCOMANDO.ExecuteReader
            'MOSTRAR_CABECERA = RS
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub MOSTRAR_DETALLE(ByVal COD_DOC As String, ByVal NRODOCU As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("VENTA_MOSTRAR_DETALLE", CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@COD_DOC", SqlDbType.Char)
            da.SelectCommand.Parameters("@COD_DOC").Value = COD_DOC
            da.SelectCommand.Parameters.Add("@NRODOCU", SqlDbType.Float)
            da.SelectCommand.Parameters("@NRODOCU").Value = NRODOCU
            da.Fill(dt)
            FLEX.DataSource = dt

            FLEX.Cols(5).Format = "###,###,###.000"
            FLEX.Cols(6).Format = "###,###,###.000"
            FLEX.Cols(7).Format = "###,###,###.000"
            FLEX.Cols(8).Format = "###,###,###.000"
            FLEX.AutoSizeCol(5)
            FLEX.AutoSizeCol(6)
            FLEX.AutoSizeCol(7)
            FLEX.AutoSizeCol(8)
            FLEX.Cols(0).Visible = False
            FLEX.Cols(8).Visible = False
            FLEX.Cols(9).Visible = False
            FLEX.Cols(10).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Function GRABAR_Z(ByVal APTOCODI As String, ByVal TOTAL As Double) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "GRABAR_Z"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@APTOCODI", SqlDbType.NVarChar)
            CMN.Parameters("@APTOCODI").Value = APTOCODI
            CMN.Parameters.Add("@FECHA_PROCESO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_PROCESO").Value = GFechaProceso
            CMN.Parameters.Add("@TOTAL_ZETA", SqlDbType.Float)
            CMN.Parameters("@TOTAL_ZETA").Value = TOTAL
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR_Z = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Function ANULAR_VENTA(ByVal COD_DOC As String, ByVal NRODOCU As String) As Integer

        Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand
        Try
            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "VENTA_ANULAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@COD_DOC", SqlDbType.Char)
            CMN.Parameters("@COD_DOC").Value = COD_DOC
            CMN.Parameters.Add("@NRODOCU", SqlDbType.Float)
            CMN.Parameters("@NRODOCU").Value = NRODOCU
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            ANULAR_VENTA = CMN.Parameters("@SW").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CNN.Close()
        End Try


    End Function
    Function MODIFICAR_DETALLE(ByVal COD_ART As String, ByVal CANT As Double, ByVal PU As Double, ByVal CORR As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "VENTA_MODIFICAR_DETALLE"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@ID_TMP", SqlDbType.Float)
            CMN.Parameters("@ID_TMP").Value = CORR
            CMN.Parameters.Add("@COD_ART", SqlDbType.VarChar)
            CMN.Parameters("@COD_ART").Value = COD_ART
            CMN.Parameters.Add("@CANT", SqlDbType.Float)
            CMN.Parameters("@CANT").Value = CANT
            CMN.Parameters.Add("@PU", SqlDbType.Float)
            CMN.Parameters("@PU").Value = PU
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            MODIFICAR_DETALLE = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function LISTAR_DOC_VENTAS(ByVal COD_DOC As String, ByVal NRO_DOCU_INI As String, ByVal NRO_DOCU_FIN As String, ByVal PC As String, ByVal TURNO As String, ByVal CN1 As SqlConnection) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String

            SQL = "EXEC VENTA_LISTAR_DOC_VENTAS '" & COD_DOC & "'," & NRO_DOCU_INI & "," & NRO_DOCU_FIN & ",'" & PC.Trim & "'," & TURNO & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN1)
            'If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            LISTAR_DOC_VENTAS = OCOMANDO.ExecuteReader
            'MOSTRAR_CABECERA = RS
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function BUSCAR_LIMITE_CREDITO(ByVal COD_CLIENTE As String, ByVal MONTO As Double) As Boolean
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "BUSCAR_LIMITE_CREDITO"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@MONTO", SqlDbType.Float)
            CMN.Parameters("@MONTO").Value = MONTO
            CMN.Parameters.Add("@COD_CLIE", SqlDbType.Char, 20)
            CMN.Parameters("@COD_CLIE").Value = COD_CLIENTE
            CMN.Parameters.Add("@VENTA", SqlDbType.Bit)
            CMN.Parameters("@VENTA").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            BUSCAR_LIMITE_CREDITO = CMN.Parameters("@VENTA").Value

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function IAM_ESTADO_FELECTRONICA(COD_DOC As String, NRODOC As Double, TIPO As Integer) As Integer
        Dim intValidar As Integer
        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlCommand
        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        Try
            CMN.CommandText = "IAM_ESTADO_FELECTRONICA"
            CMN.Parameters.Add("@COD_DOC", SqlDbType.Char, 3)
            CMN.Parameters("@COD_DOC").Value = COD_DOC
            CMN.Parameters.Add("@NRODOCU", SqlDbType.Float)
            CMN.Parameters("@NRODOCU").Value = NRODOC
            CMN.Parameters.Add("@TIPO", SqlDbType.Int)
            CMN.Parameters("@TIPO").Value = TIPO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output
            CNN.Open()
            CMN.ExecuteNonQuery()
            intValidar = CMN.Parameters("@SW").Value

            IAM_ESTADO_FELECTRONICA = intValidar
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CMN = Nothing
            CNN.Close()
        End Try

    End Function
    Function VENTA_ACTUALIZAR_DETALLE_CANT(ByVal COD_ART As String, ByVal CANT As Double, ByVal CORR As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "VENTA_ACTUALIZAR_DETALLE_CANT"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@CORR", SqlDbType.Float)
            CMN.Parameters("@CORR").Value = CORR
            CMN.Parameters.Add("@COD_ART", SqlDbType.VarChar)
            CMN.Parameters("@COD_ART").Value = COD_ART
            CMN.Parameters.Add("@CANT", SqlDbType.Float)
            CMN.Parameters("@CANT").Value = CANT
            CMN.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar, 30)
            CMN.Parameters("@NROPTOVTA").Value = SystemInformation.ComputerName
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            VENTA_ACTUALIZAR_DETALLE_CANT = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
End Class
