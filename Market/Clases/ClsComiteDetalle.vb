Public Class ClsComiteDetalle
    Private COD_DCOMITE As Double
    Private DESC_DCOMITE As String
    Private COD_RUBRO As Double
    Private DESC_RUBRO As String
    Private INCLUYE_DCOMITE As Integer
    Private ESTIMADO_DCOMITE As Double
    Private STAT_DCOMITE As Integer

    Private EMPRESA As Double
    Private EMPRESA1 As Double
    Private FINANCIERO As Double
    Private FINANCIERO1 As Double
    Private EXTRA As Double
    Private EXTRA1 As Double
    Private PERSONAL As Double
    Private PERSONAL1 As Double
    Private CAPITAL As Double
    Private CAPITAL1 As Double

    Private AUMENTO As Double
    Private PAGO As Double
    Public Property Codigo As Double
        Get
            Return COD_DCOMITE
        End Get
        Set(value As Double)
            COD_DCOMITE = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return DESC_DCOMITE
        End Get
        Set(value As String)
            DESC_DCOMITE = value
        End Set
    End Property

    Public Property Rubro As Double
        Get
            Return COD_RUBRO
        End Get
        Set(value As Double)
            COD_RUBRO = value
        End Set
    End Property

    Public Property Incluye As Integer
        Get
            Return INCLUYE_DCOMITE
        End Get
        Set(value As Integer)
            INCLUYE_DCOMITE = value
        End Set
    End Property

    Public Property Estimado As Double
        Get
            Return ESTIMADO_DCOMITE
        End Get
        Set(value As Double)
            ESTIMADO_DCOMITE = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_DCOMITE
        End Get
        Set(value As Integer)
            STAT_DCOMITE = value
        End Set
    End Property

    Public Property Rubro_Desc As String
        Get
            Return DESC_RUBRO
        End Get
        Set(value As String)
            DESC_RUBRO = value
        End Set
    End Property

    Public Property Comite_Empresa As Double
        Get
            Return EMPRESA
        End Get
        Set(value As Double)
            EMPRESA = value
        End Set
    End Property

    Public Property Comite_Empresa1 As Double
        Get
            Return EMPRESA1
        End Get
        Set(value As Double)
            EMPRESA1 = value
        End Set
    End Property

    Public Property Comite_Financiero As Double
        Get
            Return FINANCIERO
        End Get
        Set(value As Double)
            FINANCIERO = value
        End Set
    End Property

    Public Property Comite_Financiero1 As Double
        Get
            Return FINANCIERO1
        End Get
        Set(value As Double)
            FINANCIERO1 = value
        End Set
    End Property

    Public Property Comite_Extra As Double
        Get
            Return EXTRA
        End Get
        Set(value As Double)
            EXTRA = value
        End Set
    End Property

    Public Property Comite_Extra1 As Double
        Get
            Return EXTRA1
        End Get
        Set(value As Double)
            EXTRA1 = value
        End Set
    End Property

    Public Property Comite_Personal As Double
        Get
            Return PERSONAL
        End Get
        Set(value As Double)
            PERSONAL = value
        End Set
    End Property

    Public Property Comite_Personal1 As Double
        Get
            Return PERSONAL1
        End Get
        Set(value As Double)
            PERSONAL1 = value
        End Set
    End Property

    Public Property Comite_Capital As Double
        Get
            Return CAPITAL
        End Get
        Set(value As Double)
            CAPITAL = value
        End Set
    End Property

    Public Property Comite_Capital1 As Double
        Get
            Return CAPITAL1
        End Get
        Set(value As Double)
            CAPITAL1 = value
        End Set
    End Property

    Public Property Aumento_Capital As Double
        Get
            Return AUMENTO
        End Get
        Set(value As Double)
            AUMENTO = value
        End Set
    End Property

    Public Property Pago_Capital As Double
        Get
            Return PAGO
        End Get
        Set(value As Double)
            PAGO = value
        End Set
    End Property
    Function Mantenimiento(intMODO As String) As Integer
        Dim intValidar As Integer
        Dim CMN As New SqlCommand
        CMN.Connection = CN_NET
        CMN.CommandType = CommandType.StoredProcedure

        CMN.CommandText = "MANT_DETALLE_COMITE"
        CMN.Parameters.Add("@COD_DCOMITE", SqlDbType.BigInt)
        CMN.Parameters("@COD_DCOMITE").Value = Codigo
        CMN.Parameters.Add("@DESC_DCOMITE", SqlDbType.VarChar, 50)
        CMN.Parameters("@DESC_DCOMITE").Value = Descripcion
        CMN.Parameters.Add("@COD_RUBRO", SqlDbType.BigInt)
        CMN.Parameters("@COD_RUBRO").Value = Rubro
        CMN.Parameters.Add("@INCLUYE_DCOMITE", SqlDbType.Bit)
        CMN.Parameters("@INCLUYE_DCOMITE").Value = Incluye
        CMN.Parameters.Add("@ESTIMADO_DCOMITE", SqlDbType.Float)
        CMN.Parameters("@ESTIMADO_DCOMITE").Value = Estimado
        CMN.Parameters.Add("@STAT_DCOMITE", SqlDbType.Bit)
        CMN.Parameters("@STAT_DCOMITE").Value = Estado
        CMN.Parameters.Add("@TIP", SqlDbType.Char, 1)
        CMN.Parameters("@TIP").Value = intMODO
        CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
        CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        CMN.ExecuteNonQuery()
        intValidar = CMN.Parameters("@ingproc_001").Value


        Mantenimiento = intValidar

TratarError:
        CMN = Nothing
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "ClsMtasGenerales.Usuario.Mantenimiento()", Err.Description)
    End Function
    Sub BUSCAR()
        Dim RS As SqlDataReader
        Try
            Descripcion = ""
            Estado = 0
            Dim OCOMANDO As New SqlCommand("EXEC BUSCAR_DETALLE_COMITE " & Codigo & "", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                Descripcion = RS("DESC_DCOMITE")
                Rubro = RS("COD_RUBRO")
                Rubro_Desc = RS("DESC_RUBRO")
                Incluye = RS("INCLUYE_DCOMITE")
                Estimado = RS("ESTIMADO_DCOMITE")
                Estado = RS("STAT_DCOMITE")
            End While
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            CN_NET.Close()
        End Try
    End Sub
    Public Function BUSCAR_TOT_GENERADO_COMITE_DETALLE(ByVal FI As String, FF As String, BRUTO As Double) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "BUSCAR_TOT_GENERADO_COMITE_DETALLE"
        Cmn.Parameters.Add("@FI", SqlDbType.Char, 8)
        Cmn.Parameters("@FI").Value = FI
        Cmn.Parameters.Add("@FF", SqlDbType.Char, 8)
        Cmn.Parameters("@FF").Value = FF
        Cmn.Parameters.Add("@BRUTO", SqlDbType.Float)
        Cmn.Parameters("@BRUTO").Value = BRUTO
        Cmn.Parameters.Add("@EMPRESA", SqlDbType.Float)
        Cmn.Parameters("@EMPRESA").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@EMPRESA1", SqlDbType.Float)
        Cmn.Parameters("@EMPRESA1").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@FINANCIERO", SqlDbType.Float)
        Cmn.Parameters("@FINANCIERO").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@FINANCIERO1", SqlDbType.Float)
        Cmn.Parameters("@FINANCIERO1").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@EXTRA", SqlDbType.Float)
        Cmn.Parameters("@EXTRA").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@EXTRA1", SqlDbType.Float)
        Cmn.Parameters("@EXTRA1").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@PERSONAL", SqlDbType.Float)
        Cmn.Parameters("@PERSONAL").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@PERSONAL1", SqlDbType.Float)
        Cmn.Parameters("@PERSONAL1").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@CAPITAL", SqlDbType.Float)
        Cmn.Parameters("@CAPITAL").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@CAPITAL1", SqlDbType.Float)
        Cmn.Parameters("@CAPITAL1").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()

        Comite_Empresa = Cmn.Parameters("@EMPRESA").Value
        Comite_Empresa1 = Cmn.Parameters("@EMPRESA1").Value
        Comite_Financiero = Cmn.Parameters("@FINANCIERO").Value
        Comite_Financiero1 = Cmn.Parameters("@FINANCIERO1").Value
        Comite_Extra = Cmn.Parameters("@EXTRA").Value
        Comite_Extra1 = Cmn.Parameters("@EXTRA1").Value
        Comite_Personal = Cmn.Parameters("@PERSONAL").Value
        Comite_Personal1 = Cmn.Parameters("@PERSONAL1").Value
        Comite_Capital = Cmn.Parameters("@CAPITAL").Value
        Comite_Capital1 = Cmn.Parameters("@CAPITAL1").Value
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando AREAS", Err.Description)
    End Function
    Public Function BUSCAR_COMITE_DIAS() As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "BUSCAR_COMITE_DIAS"
        Cmn.Parameters.Add("@DIA", SqlDbType.Int)
        Cmn.Parameters("@DIA").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()

        BUSCAR_COMITE_DIAS = Cmn.Parameters("@DIA").Value

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando AREAS", Err.Description)
    End Function

    Public Function BUSCAR_AUMENTO_PAGO_CAPITAL(FI As String, FF As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "BUSCAR_AUMENTO_PAGO_CAPITAL"
        Cmn.Parameters.Add("@FI", SqlDbType.Char, 8)
        Cmn.Parameters("@FI").Value = FI
        Cmn.Parameters.Add("@FF", SqlDbType.Char, 8)
        Cmn.Parameters("@FF").Value = FF
        Cmn.Parameters.Add("@AUMENTO", SqlDbType.Float)
        Cmn.Parameters("@AUMENTO").Direction = ParameterDirection.Output
        Cmn.Parameters.Add("@PAGO", SqlDbType.Float)
        Cmn.Parameters("@PAGO").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()

        Aumento_Capital = Cmn.Parameters("@AUMENTO").Value
        Pago_Capital = Cmn.Parameters("@PAGO").Value

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando AREAS", Err.Description)
    End Function

End Class
