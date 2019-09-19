Public Class ClsVtaContingecia
    Private ID_VENTASM As Double
    Private COD_DOC As String
    Private SERIE_VENTASM As String
    Private NUMERO_VENTASM As String
    Private FECHA_VENTASM As Date
    Private COD_CLIENTE As String
    Private PIGV As Double
    Private SUBTOTAL_VENTASM As Double
    Private IGV_VENTASM As Double
    Private TOTAL_VENTASM As Double
    Private STAT_VENTASM As Integer
    Private COD_USER As String
    Private COD_MCONTINGENCIA As Integer

    Public ClieDesc As String
    Public ContingenciaDesc As String
    Public Property Id As Double
        Get
            Return ID_VENTASM
        End Get
        Set(value As Double)
            ID_VENTASM = value
        End Set
    End Property

    Public Property TipoDoc As String
        Get
            Return COD_DOC
        End Get
        Set(value As String)
            COD_DOC = value
        End Set
    End Property

    Public Property Serie As String
        Get
            Return SERIE_VENTASM
        End Get
        Set(value As String)
            SERIE_VENTASM = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return NUMERO_VENTASM
        End Get
        Set(value As String)
            NUMERO_VENTASM = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return FECHA_VENTASM
        End Get
        Set(value As Date)
            FECHA_VENTASM = value
        End Set
    End Property

    Public Property ClieCod As String
        Get
            Return COD_CLIENTE
        End Get
        Set(value As String)
            COD_CLIENTE = value
        End Set
    End Property

    Public Property PorcIgv As Double
        Get
            Return PIGV
        End Get
        Set(value As Double)
            PIGV = value
        End Set
    End Property


    Public Property SubTotal As Double
        Get
            Return SUBTOTAL_VENTASM
        End Get
        Set(value As Double)
            SUBTOTAL_VENTASM = value
        End Set
    End Property

    Public Property Igv As Double
        Get
            Return IGV_VENTASM
        End Get
        Set(value As Double)
            IGV_VENTASM = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return TOTAL_VENTASM
        End Get
        Set(value As Double)
            TOTAL_VENTASM = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_VENTASM
        End Get
        Set(value As Integer)
            STAT_VENTASM = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return COD_USER
        End Get
        Set(value As String)
            COD_USER = value
        End Set
    End Property

    Public Property ContingenciaCod As Integer
        Get
            Return COD_MCONTINGENCIA
        End Get
        Set(value As Integer)
            COD_MCONTINGENCIA = value
        End Set
    End Property

    Function GRABAR(ByVal CORR_TMP As Double, TIPO As String, CNN As SqlConnection) As Integer
        Try
            Dim CMN As New SqlClient.SqlCommand
            CMN.CommandText = "GRABAR_CONTINGENCIA"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@ID_VENTASM", SqlDbType.BigInt)
            CMN.Parameters("@ID_VENTASM").Value = Id
            CMN.Parameters.Add("@COD_DOC", SqlDbType.Char, 3)
            CMN.Parameters("@COD_DOC").Value = TipoDoc
            CMN.Parameters.Add("@SERIE_VENTASM", SqlDbType.Char, 4)
            CMN.Parameters("@SERIE_VENTASM").Value = Serie
            CMN.Parameters.Add("@NUMERO_VENTASM", SqlDbType.Char, 8)
            CMN.Parameters("@NUMERO_VENTASM").Value = Numero
            CMN.Parameters.Add("@FECHA_VENTASM", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_VENTASM").Value = Format(Fecha, "dd/MM/yyyy")
            CMN.Parameters.Add("@COD_CLIENTE", SqlDbType.Char, 20)
            CMN.Parameters("@COD_CLIENTE").Value = ClieCod
            CMN.Parameters.Add("@PIGV", SqlDbType.Float)
            CMN.Parameters("@PIGV").Value = PorcIgv
            CMN.Parameters.Add("@SUBTOTAL_VENTASM", SqlDbType.Float)
            CMN.Parameters("@SUBTOTAL_VENTASM").Value = SubTotal
            CMN.Parameters.Add("@IGV_VENTASM", SqlDbType.Float)
            CMN.Parameters("@IGV_VENTASM").Value = Igv
            CMN.Parameters.Add("@TOTAL_VENTASM", SqlDbType.Float)
            CMN.Parameters("@TOTAL_VENTASM").Value = Total
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
            CMN.Parameters("@COD_USER").Value = Usuario

            CMN.Parameters.Add("@COD_MCONTINGENCIA", SqlDbType.Int)
            CMN.Parameters("@COD_MCONTINGENCIA").Value = ContingenciaCod

            CMN.Parameters.Add("@CORR_TMP", SqlDbType.Float)
            CMN.Parameters("@CORR_TMP").Value = CORR_TMP
            CMN.Parameters.Add("@TIPO", SqlDbType.Char, 1)
            CMN.Parameters("@TIPO").Value = TIPO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CNN.Close()
        End Try
    End Function

    Sub BUSCAR(cn As SqlConnection)
        Dim RS As SqlDataReader
        Try
            TipoDoc = 0
            Numero = ""
            ClieCod = 0
            Fecha = Date.Now
            PIGV = 0
            SubTotal = 0
            Igv = 0
            Total = 0
            Estado = 0
            Dim OCOMANDO As New SqlCommand("EXEC BUSCAR_CONTINGENCIA " & Id & "", cn)
            cn.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                TipoDoc = RS("COD_DOC")
                Serie = RS("SERIE_VENTASM")
                Numero = RS("NUMERO_VENTASM")
                ClieCod = RS("COD_CLIENTE")
                ClieDesc = RS("DESC_CLIENTE")
                Fecha = RS("FECHA_VENTASM")
                PIGV = RS("PIGV")
                SubTotal = RS("SUBTOTAL_VENTASM")
                Igv = RS("IGV_VENTASM")
                Total = RS("TOTAL_VENTASM")
                Estado = RS("STAT_VENTASM")
                ContingenciaCod = RS("COD_MCONTINGENCIA")
                ContingenciaDesc = RS("DESC_MCONTINGENCIA")
            End While
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            cn.Close()
        End Try
    End Sub

    Function IAM_ESTADO_FELECTRONICA(cn As SqlConnection, TIPO As Integer) As Integer
        Dim intValidar As Integer
        Dim CMN As New SqlCommand
        CMN.Connection = cn
        CMN.CommandType = CommandType.StoredProcedure
        Try
            CMN.CommandText = "IAM_ESTADO_FELECTRONICA_CONTINGENCIA"
            CMN.Parameters.Add("@ID_VENTASM", SqlDbType.BigInt)
            CMN.Parameters("@ID_VENTASM").Value = Id
            CMN.Parameters.Add("@TIPO", SqlDbType.Int)
            CMN.Parameters("@TIPO").Value = TIPO
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output
            cn.Open()
            CMN.ExecuteNonQuery()
            intValidar = CMN.Parameters("@SW").Value

            IAM_ESTADO_FELECTRONICA = intValidar
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CMN = Nothing
            cn.Close()
        End Try

    End Function
End Class
