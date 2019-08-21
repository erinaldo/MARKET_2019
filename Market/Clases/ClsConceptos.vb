Public Class ClsConceptos
    Private _cOD_CONCEPTO As Double
    Private _dESC_CONCEPTO As String
    Private _tIPO_CONCEPTO As String
    Private _sTAT_CONCEPTO As Integer
    Private _fCOBRO_CONCEPTO As Integer
    Private _tOP_CONCEPTO As String
    Private _gRUPO_CONCEPTO As String
    Private _tC_CONCEPTO As Integer
    Private _tRANSF_CONCEPTO As Integer
    Private COMITE_CONCEPTO As Integer
    Private ACAPITAL_CONCEPTO As Integer
    Private PCAPITAL_CONCEPTO As Integer

    Public Property Codigo As Double
        Get
            Return _cOD_CONCEPTO
        End Get
        Set(value As Double)
            _cOD_CONCEPTO = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _dESC_CONCEPTO
        End Get
        Set(value As String)
            _dESC_CONCEPTO = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tIPO_CONCEPTO
        End Get
        Set(value As String)
            _tIPO_CONCEPTO = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _sTAT_CONCEPTO
        End Get
        Set(value As Integer)
            _sTAT_CONCEPTO = value
        End Set
    End Property

    Public Property Fecha_Cobro As Integer
        Get
            Return _fCOBRO_CONCEPTO
        End Get
        Set(value As Integer)
            _fCOBRO_CONCEPTO = value
        End Set
    End Property

    Public Property Forma_Auto_Manual As String
        Get
            Return _tOP_CONCEPTO
        End Get
        Set(value As String)
            _tOP_CONCEPTO = value
        End Set
    End Property

    Public Property Grupo As String
        Get
            Return _gRUPO_CONCEPTO
        End Get
        Set(value As String)
            _gRUPO_CONCEPTO = value
        End Set
    End Property

    Public Property TCambio As Integer
        Get
            Return _tC_CONCEPTO
        End Get
        Set(value As Integer)
            _tC_CONCEPTO = value
        End Set
    End Property

    Public Property Transferencia As Integer
        Get
            Return _tRANSF_CONCEPTO
        End Get
        Set(value As Integer)
            _tRANSF_CONCEPTO = value
        End Set
    End Property

    Public Property Mostrar_Comite As Integer
        Get
            Return COMITE_CONCEPTO
        End Get
        Set(value As Integer)
            COMITE_CONCEPTO = value
        End Set
    End Property

    Public Property ACapital As Integer
        Get
            Return ACAPITAL_CONCEPTO
        End Get
        Set(value As Integer)
            ACAPITAL_CONCEPTO = value
        End Set
    End Property

    Public Property PCapital As Integer
        Get
            Return PCAPITAL_CONCEPTO
        End Get
        Set(value As Integer)
            PCAPITAL_CONCEPTO = value
        End Set
    End Property

    Function Mantenimiento(Tipo_M As String) As Integer
        Try
            'Dim intValidar As Integer
            Dim CMN As New SqlClient.SqlCommand
            CMN.Connection = CN_NET
            CMN.CommandType = CommandType.StoredProcedure
            CMN.CommandTimeout = 0
            ''
            CMN.CommandText = "MANT_CONCEPTOS"
            CMN.Parameters.Add("@COD_CONCEPTO", SqlDbType.BigInt)
            CMN.Parameters("@COD_CONCEPTO").Value = Codigo
            CMN.Parameters.Add("@DESC_CONCEPTO", SqlDbType.VarChar, 150)
            CMN.Parameters("@DESC_CONCEPTO").Value = Descripcion
            CMN.Parameters.Add("@TIPO_CONCEPTO", SqlDbType.Char, 1)
            CMN.Parameters("@TIPO_CONCEPTO").Value = Tipo
            CMN.Parameters.Add("@FCOBRO_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@FCOBRO_CONCEPTO").Value = Fecha_Cobro
            CMN.Parameters.Add("@TOP_CONCEPTO", SqlDbType.Char, 1)
            CMN.Parameters("@TOP_CONCEPTO").Value = Forma_Auto_Manual
            CMN.Parameters.Add("@GRUPO_CONCEPTO", SqlDbType.VarChar, 5)
            CMN.Parameters("@GRUPO_CONCEPTO").Value = Grupo
            CMN.Parameters.Add("@TC_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@TC_CONCEPTO").Value = TCambio
            CMN.Parameters.Add("@TRANSF_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@TRANSF_CONCEPTO").Value = Transferencia

            CMN.Parameters.Add("@COMITE_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@COMITE_CONCEPTO").Value = Mostrar_Comite
            CMN.Parameters.Add("@ACAPITAL_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@ACAPITAL_CONCEPTO").Value = ACapital
            CMN.Parameters.Add("@PCAPITAL_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@PCAPITAL_CONCEPTO").Value = PCapital

            CMN.Parameters.Add("@STAT_CONCEPTO", SqlDbType.Bit)
            CMN.Parameters("@STAT_CONCEPTO").Value = Estado
            CMN.Parameters.Add("@TIP", SqlDbType.Char, 1)
            CMN.Parameters("@TIP").Value = Tipo_M
            CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
            CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output
            CN_NET.Open()
            CMN.ExecuteNonQuery()
            Mantenimiento = CMN.Parameters("@ingproc_001").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CN_NET.Close()
        End Try
    End Function
    Sub BUSCAR()
        Dim RS As SqlDataReader
        Try
            Dim OCOMANDO As New SqlCommand("EXEC BUSCAR_CONCEPTO " & Codigo & "", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                Descripcion = RS("DESC_CONCEPTO")
                Tipo = RS("TIPO_CONCEPTO")
                Estado = RS("STAT_CONCEPTO")
                Fecha_Cobro = RS("FCOBRO_CONCEPTO")
                Forma_Auto_Manual = RS("TOP_CONCEPTO")
                Grupo = RS("GRUPO_CONCEPTO")
                TCambio = RS("TC_CONCEPTO")
                Transferencia = RS("TRANSF_CONCEPTO")
                Mostrar_Comite = RS("COMITE_CONCEPTO")
                ACapital = RS("ACAPITAL_CONCEPTO")
                PCapital = RS("PCAPITAL_CONCEPTO")
            End While
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            CN_NET.Close()
        End Try
    End Sub
End Class
