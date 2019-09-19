Public Class ClsTemp
    Private CORRNBR As Double
    Private ITEM As Integer
    Private COD_ART As String
    Private ATMPCANT As Double
    Private ATMPPREC As Double
    Private ATMPIMPO As Double

    Public Property Correlativo As Double
        Get
            Return CORRNBR
        End Get
        Set(value As Double)
            CORRNBR = value
        End Set
    End Property

    Public Property Fila As Integer
        Get
            Return ITEM
        End Get
        Set(value As Integer)
            ITEM = value
        End Set
    End Property

    Public Property CodArt As String
        Get
            Return COD_ART
        End Get
        Set(value As String)
            COD_ART = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return ATMPCANT
        End Get
        Set(value As Double)
            ATMPCANT = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return ATMPPREC
        End Get
        Set(value As Double)
            ATMPPREC = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return ATMPIMPO
        End Get
        Set(value As Double)
            ATMPIMPO = value
        End Set
    End Property

    Function AGREGAR_TMP_COMPRAS_PU(ByVal CN As SqlConnection) As Integer
        Try
            Dim CMN As New SqlClient.SqlCommand
            CMN.CommandText = "AGREGAR_TMP_COMPRAS_PU"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CN
            ''
            CMN.Parameters.Add("@CORR_TMP", SqlDbType.Float)
            CMN.Parameters("@CORR_TMP").Value = Correlativo
            CMN.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
            CMN.Parameters("@COD_ART").Value = CodArt
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output
            If CN.State = ConnectionState.Open Then CN.Close()
            CN.Open()

            CMN.ExecuteNonQuery()

            AGREGAR_TMP_COMPRAS_PU = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
    Sub ACTUALIZAR_TMP_DETALLE_COMPRA(cn As SqlConnection)
        Try
            Dim Cmn As New SqlCommand
            Cmn.Connection = cn
            Cmn.CommandType = CommandType.StoredProcedure
            Cmn.CommandText = "ACTUALIZAR_TMP_DETALLE_COMPRA"
            '
            Cmn.Parameters.Add("@CORRNBR", SqlDbType.BigInt)
            Cmn.Parameters("@CORRNBR").Value = Correlativo
            Cmn.Parameters.Add("@ITEM", SqlDbType.Int)
            Cmn.Parameters("@ITEM").Value = Fila
            Cmn.Parameters.Add("@ATMPPREC", SqlDbType.Float)
            Cmn.Parameters("@ATMPPREC").Value = Precio
            Cmn.Parameters.Add("@ATMPCANT", SqlDbType.Float)
            Cmn.Parameters("@ATMPCANT").Value = Cantidad
            Cmn.Parameters.Add("@SW", SqlDbType.Int)
            Cmn.Parameters("@SW").Direction = ParameterDirection.Output
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Open()
            Cmn.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            cn.Close()
        End Try
    End Sub
    Public Function Eliminar(cn As SqlConnection, ITEM As Integer) As Integer
        Try
            Dim Cmn As New SqlCommand
            Dim intValidar As Integer

            Cmn.Connection = cn
            Cmn.CommandType = CommandType.StoredProcedure
            Cmn.CommandText = "usp_TMP_DETALLEDelProc"
            '
            Cmn.Parameters.Add("@CORRNBR", SqlDbType.Int)
            Cmn.Parameters("@CORRNBR").Value = CORRNBR
            Cmn.Parameters.Add("@ITEM", SqlDbType.Int)
            Cmn.Parameters("@ITEM").Value = ITEM
            Cmn.Parameters.Add("@ing_proc001", SqlDbType.TinyInt)
            Cmn.Parameters("@ing_proc001").Direction = ParameterDirection.Output
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Open()
            Cmn.ExecuteNonQuery()
            intValidar = Cmn.Parameters("@ing_proc001").Value
            Eliminar = intValidar
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            cn.Close()
        End Try
    End Function
    Function CARGAR_TMP_DETALLE_CONTINGENCIA(ByVal CORR_TMP As Double, ByVal ID_VENTASM As Double, CNN As SqlConnection) As Integer
        Try
            Dim CMN As New SqlClient.SqlCommand
            CMN.CommandText = "CARGAR_TMP_DETALLE_CONTINGENCIA"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@CORR_TMP", SqlDbType.Float)
            CMN.Parameters("@CORR_TMP").Value = CORR_TMP
            CMN.Parameters.Add("@ID_VENTASM", SqlDbType.BigInt)
            CMN.Parameters("@ID_VENTASM").Value = ID_VENTASM
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            CARGAR_TMP_DETALLE_CONTINGENCIA = CMN.Parameters("@SW").Value
            CNN.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Function
End Class
