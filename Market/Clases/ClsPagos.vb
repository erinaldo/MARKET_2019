Public Class ClsPagos
    Function AGREGAR_DETALLE_TARJETA(ByVal COD_TARJETA As String, ByVal MON_TARJETA As String, ByVal NRO_TARJETA As String, ByVal MONTO_TARJETA As Double, ByVal CORR As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "TARJETA_AGREGAR_DETALLE"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@CORR", SqlDbType.Float)
            CMN.Parameters("@CORR").Value = CORR
            CMN.Parameters.Add("@COD_TARJETA", SqlDbType.VarChar)
            CMN.Parameters("@COD_TARJETA").Value = COD_TARJETA
            CMN.Parameters.Add("@MON_TARJETA", SqlDbType.VarChar)
            CMN.Parameters("@MON_TARJETA").Value = MON_TARJETA
            CMN.Parameters.Add("@NRO_TARJETA", SqlDbType.VarChar)
            CMN.Parameters("@NRO_TARJETA").Value = NRO_TARJETA
            CMN.Parameters.Add("@MONTO_TARJETA", SqlDbType.Decimal)
            CMN.Parameters("@MONTO_TARJETA").Value = MONTO_TARJETA
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            AGREGAR_DETALLE_TARJETA = CMN.Parameters("@SW").Value
            CNN.Close()
        Catch ex As Exception

            MsgBox(Err.Description)
        End Try

    End Function
    Sub CARGAR_DETALLE_TARJETA(ByVal CORR As Double, ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("TARJETA_LISTAR_DETALLE", CN_NET)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@CORR", SqlDbType.Float)
            da.SelectCommand.Parameters("@CORR").Value = CORR
            da.Fill(dt)
            FLEX.DataSource = dt

            FLEX.Cols(4).Format = "###,###,###.000"
            'FLEX.Cols(6).Format = "###,###,###.000"
            'FLEX.AutoSizeCol(5)
            'FLEX.AutoSizeCol(6)
            FLEX.Cols(0).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub ELIMINAR_DETALLE_TARJETA(ByVal IDTEMP As Double, ByVal TIPO As String)
        Dim SQL As String
        SQL = "EXEC TARJETA_ELIMINAR_DETALLE " & IDTEMP & ",'" & TIPO & "'"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        CN_NET.Open()
        OCOMANDO.ExecuteNonQuery()
        CN_NET.Close()
    End Sub
    Public Function MOSTRAR_TARJETA_DETALLE(ByVal COD_DOC As String, ByVal NRODOCU As Double) As SqlDataReader 'ADODB.Recordset
        Try
            Dim SQL As String

            SQL = "EXEC TARJETA_MOSTRAR_DETALLE '" & COD_DOC & "'," & NRODOCU & ""
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            MOSTRAR_TARJETA_DETALLE = OCOMANDO.ExecuteReader
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
End Class
