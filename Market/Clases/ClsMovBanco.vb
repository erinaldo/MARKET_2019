Public Class ClsMovBanco
    Private _iD_MOVB As Double
    Private _cOD_BANCO As Integer
    Private _tIPO_MOVB As String
    Private _cOD_CONCEPTO As String
    Private _mONTO_MOVB As Double
    Private _gIRO_MOVB As Date
    Private _oPER_MOVB As String
    Private _oBSERV_MOVB As String
    Private _fCOBRO_MOVB As String
    Private _aUSUCODI As String
    Private _cODG_MOVB As String
    Private _tIPG_MOVB As String
    Private _pAGO_MOVB As Double
    Private _rEF_MOVB As String
    Private _tRANSF_MOVB As Integer
    Private _cOD_FPAGOM As String
    Private _tC_MOVB As Double
    Private _iD_MOVB_D As Double
    Private _dETALLE As String
    Private COD_BANCO_D As Integer
    Private COD_DCOMITE As Double

    Public DescConcepto As String
    Public ConceptoFecCobro As Integer
    Public ProvDesc As String
    Public OtroDesc As String
    Public ConceptoTC As Integer
    Public BancoDesc_D As String
    Public DescComite As String
    Public Property Id As Double
        Get
            Return _iD_MOVB
        End Get
        Set(value As Double)
            _iD_MOVB = value
        End Set
    End Property

    Public Property CodBanco As Integer
        Get
            Return _cOD_BANCO
        End Get
        Set(value As Integer)
            _cOD_BANCO = value
        End Set
    End Property

    Public Property TipoMov As String
        Get
            Return _tIPO_MOVB
        End Get
        Set(value As String)
            _tIPO_MOVB = value
        End Set
    End Property

    Public Property CodConcepto As String
        Get
            Return _cOD_CONCEPTO
        End Get
        Set(value As String)
            _cOD_CONCEPTO = value
        End Set
    End Property

    Public Property Monto As Double
        Get
            Return _mONTO_MOVB
        End Get
        Set(value As Double)
            _mONTO_MOVB = value
        End Set
    End Property

    Public Property FecGiro As Date
        Get
            Return _gIRO_MOVB
        End Get
        Set(value As Date)
            _gIRO_MOVB = value
        End Set
    End Property

    Public Property FegOper As String
        Get
            Return _oPER_MOVB
        End Get
        Set(value As String)
            _oPER_MOVB = value
        End Set
    End Property

    Public Property Observacion As String
        Get
            Return _oBSERV_MOVB
        End Get
        Set(value As String)
            _oBSERV_MOVB = value
        End Set
    End Property

    Public Property FecCobro As String
        Get
            Return _fCOBRO_MOVB
        End Get
        Set(value As String)
            _fCOBRO_MOVB = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _aUSUCODI
        End Get
        Set(value As String)
            _aUSUCODI = value
        End Set
    End Property

    Public Property GiradoCod As String
        Get
            Return _cODG_MOVB
        End Get
        Set(value As String)
            _cODG_MOVB = value
        End Set
    End Property

    Public Property GiradoTipo As String
        Get
            Return _tIPG_MOVB
        End Get
        Set(value As String)
            _tIPG_MOVB = value
        End Set
    End Property

    Public Property Referencia As String
        Get
            Return _rEF_MOVB
        End Get
        Set(value As String)
            _rEF_MOVB = value
        End Set
    End Property

    Public Property FormaPago As String
        Get
            Return _cOD_FPAGOM
        End Get
        Set(value As String)
            _cOD_FPAGOM = value
        End Set
    End Property

    Public Property TCambio As Double
        Get
            Return _tC_MOVB
        End Get
        Set(value As Double)
            _tC_MOVB = value
        End Set
    End Property

    Public Property Id_Destino As Double
        Get
            Return _iD_MOVB_D
        End Get
        Set(value As Double)
            _iD_MOVB_D = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _dETALLE
        End Get
        Set(value As String)
            _dETALLE = value
        End Set
    End Property

    Public Property CodBanco_D As Integer
        Get
            Return COD_BANCO_D
        End Get
        Set(value As Integer)
            COD_BANCO_D = value
        End Set
    End Property

    Public Property Transferencia As Integer
        Get
            Return _tRANSF_MOVB
        End Get
        Set(value As Integer)
            _tRANSF_MOVB = value
        End Set
    End Property

    Public Property Comite As Double
        Get
            Return COD_DCOMITE
        End Get
        Set(value As Double)
            COD_DCOMITE = value
        End Set
    End Property

    Function Mantenimiento(TIPO As String, cn As SqlConnection) As Integer
        Try
            Dim CMN As New SqlCommand
            CMN.Connection = cn
            CMN.CommandType = CommandType.StoredProcedure
            CMN.CommandTimeout = 0
            ''
            CMN.CommandText = "MANT_MOVI_BANCO"
            CMN.Parameters.Add("@ID_MOVB", SqlDbType.BigInt)
            CMN.Parameters("@ID_MOVB").Value = Id
            CMN.Parameters.Add("@ABANCODI", SqlDbType.TinyInt)
            CMN.Parameters("@ABANCODI").Value = CodBanco
            CMN.Parameters.Add("@TIPO_MOVB", SqlDbType.Char, 1)
            CMN.Parameters("@TIPO_MOVB").Value = TipoMov
            CMN.Parameters.Add("@COD_CONCEPTO", SqlDbType.Char, 3)
            CMN.Parameters("@COD_CONCEPTO").Value = CodConcepto
            CMN.Parameters.Add("@MONTO_MOVB", SqlDbType.Float)
            CMN.Parameters("@MONTO_MOVB").Value = Monto
            CMN.Parameters.Add("@GIRO_MOVB", SqlDbType.DateTime)
            CMN.Parameters("@GIRO_MOVB").Value = Format(FecGiro, "dd/MM/yyyy")
            CMN.Parameters.Add("@OBSERV_MOVB", SqlDbType.VarChar, 250)
            CMN.Parameters("@OBSERV_MOVB").Value = Observacion
            CMN.Parameters.Add("@FCOBRO_MOVB", SqlDbType.VarChar, 10)
            CMN.Parameters("@FCOBRO_MOVB").Value = FecCobro
            CMN.Parameters.Add("@AUSUCODI", SqlDbType.NVarChar, 8)
            CMN.Parameters("@AUSUCODI").Value = Usuario
            CMN.Parameters.Add("@CODG_MOVB", SqlDbType.VarChar, 20)
            CMN.Parameters("@CODG_MOVB").Value = GiradoCod
            CMN.Parameters.Add("@TIPG_MOVB", SqlDbType.Char, 1)
            CMN.Parameters("@TIPG_MOVB").Value = GiradoTipo
            CMN.Parameters.Add("@REF_MOVB", SqlDbType.VarChar, 15)
            CMN.Parameters("@REF_MOVB").Value = Referencia
            CMN.Parameters.Add("@COD_FPAGOM", SqlDbType.VarChar, 3)
            CMN.Parameters("@COD_FPAGOM").Value = FormaPago
            CMN.Parameters.Add("@TC_MOVB", SqlDbType.Float)
            CMN.Parameters("@TC_MOVB").Value = TCambio
            CMN.Parameters.Add("@ABANCODI_D", SqlDbType.TinyInt)
            CMN.Parameters("@ABANCODI_D").Value = CodBanco_D

            CMN.Parameters.Add("@COD_DCOMITE", SqlDbType.BigInt)
            CMN.Parameters("@COD_DCOMITE").Value = Comite

            CMN.Parameters.Add("@TIP", SqlDbType.Char, 1)
            CMN.Parameters("@TIP").Value = TIPO
            CMN.Parameters.Add("@ingproc_001", SqlDbType.Int)
            CMN.Parameters("@ingproc_001").Direction = ParameterDirection.Output
            cn.Open()
            CMN.ExecuteNonQuery()
            Mantenimiento = CMN.Parameters("@ingproc_001").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            cn.Close()
        End Try
    End Function
    Public Sub SALDO_BANCOS(ByVal TXT_G As TextBox, ByVal TXT_O As TextBox, ByVal TXT_L As TextBox, CN As SqlConnection)

        Try
            Dim CMN As New SqlCommand
            CMN.Connection = CN
            CMN.CommandType = CommandType.StoredProcedure
            CMN.CommandTimeout = 0

            CMN.CommandText = "SALDO_BANCOS"
            CMN.Parameters.Add("@ABANCODI", SqlDbType.TinyInt)
            CMN.Parameters("@ABANCODI").Value = CodBanco
            CMN.Parameters.Add("@SALDO_G", SqlDbType.Float)
            CMN.Parameters("@SALDO_G").Direction = ParameterDirection.Output
            CMN.Parameters.Add("@SALDO_O", SqlDbType.Float)
            CMN.Parameters("@SALDO_O").Direction = ParameterDirection.Output
            CMN.Parameters.Add("@SALDO_L", SqlDbType.Float)
            CMN.Parameters("@SALDO_L").Direction = ParameterDirection.Output
            CN.Open()
            CMN.ExecuteNonQuery()
            TXT_G.Text = Format(CMN.Parameters("@SALDO_G").Value, "###,###,###.00")
            TXT_O.Text = Format(CMN.Parameters("@SALDO_O").Value, "###,###,###.00")
            TXT_L.Text = Format(CMN.Parameters("@SALDO_L").Value, "###,###,###.00")
            CN.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CN.Close()
        End Try
    End Sub
    Sub BUSCAR(cn As SqlConnection)
        Dim RS As SqlDataReader
        Try
            Dim OCOMANDO As New SqlCommand("EXEC BUSCAR_MOVI_BANCO " & Id & "", cn)
            cn.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                TipoMov = RS("TIPO_MOVB")
                CodConcepto = RS("COD_CONCEPTO")
                Monto = RS("MONTO_MOVB")
                FecGiro = RS("GIRO_MOVB")
                FegOper = RS("OPER_MOVB")
                Observacion = RS("OBSERV_MOVB")
                DescConcepto = RS("DESC_CONCEPTO")
                FecCobro = RS("FCOBRO_MOVB")
                ConceptoFecCobro = RS("FCOBRO_CONCEPTO")
                GiradoCod = RS("CODG_MOVB")
                GiradoTipo = RS("TIPG_MOVB")
                ProvDesc = RS("DESC_PROVED")
                OtroDesc = RS("DESC_OTRO")
                Referencia = RS("REF_MOVB")
                FormaPago = RS("COD_FPAGOM")
                TCambio = RS("TC_MOVB")
                ConceptoTC = RS("TC_CONCEPTO")
                CodBanco_D = RS("COD_BANCOD")
                ''BancoDesc_D = RS("DESC_BANCOD")
                BancoDesc_D = RS("ACTADESC")
                Transferencia = RS("TRANSF_CONCEPTO")
                Comite = RS("COD_DCOMITE")
                DescComite = RS("DESC_DCOMITE")
            End While
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            cn.Close()
        End Try
    End Sub
    Function ELIMINAR_MOVI_BANCO(CN As SqlConnection) As Integer
        Dim INTVALIDAR As Integer
        Dim CMN As New SqlCommand
        CMN.Connection = CN
        CMN.CommandType = CommandType.StoredProcedure
        CMN.CommandTimeout = 0

        CMN.CommandText = "ELIMINAR_MOVI_BANCO"
        CMN.Parameters.Add("@ID_MOVB", SqlDbType.BigInt)
        CMN.Parameters("@ID_MOVB").Value = Id
        CMN.Parameters.Add("@SW", SqlDbType.Int)
        CMN.Parameters("@SW").Direction = ParameterDirection.Output
        CN.Open()
        CMN.ExecuteNonQuery()
        INTVALIDAR = CMN.Parameters("@SW").Value
        CN.Close()
        If INTVALIDAR = 0 Then MsgBox("Se Eimino Correctamente", MsgBoxStyle.Information)
        If INTVALIDAR = 1 Then MsgBox(Err.Description)
        If INTVALIDAR = 2 Then MsgBox("Movimiento de Banco usado para Cancelar Compra,no se puede Eliminar", MsgBoxStyle.Information)
        If INTVALIDAR = 3 Then MsgBox("Movimiento de Banco fue Transferido a Contabilidad,no se puede Eliminar", MsgBoxStyle.Information)

        ELIMINAR_MOVI_BANCO = INTVALIDAR
TrataError:
        CN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando MOVIMIENTOS DE BANCOS", Err.Description)
    End Function
    Public Function MANT_FECHA_OPERACION(ByVal ID_COMPRA As Double, ByVal ID_PAGO As Integer, ByVal TP As String, ByVal FECHA_OPER As Date, ByVal TIPO As String, CN As SqlConnection) As Integer
        On Error GoTo TrataError
        Dim INTVALIDAR As Integer
        Dim CMN As New SqlCommand
        CMN.Connection = CN
        CMN.CommandType = CommandType.StoredProcedure
        CMN.CommandTimeout = 0

        CMN.CommandText = "MANT_FECHA_OPERACION"
        CMN.Parameters.Add("@ID_COMPRA", SqlDbType.BigInt)
        CMN.Parameters("@ID_COMPRA").Value = ID_COMPRA
        CMN.Parameters.Add("@ID_PAGO", SqlDbType.Int)
        CMN.Parameters("@ID_PAGO").Value = ID_PAGO
        CMN.Parameters.Add("@TP", SqlDbType.VarChar, 3)
        CMN.Parameters("@TP").Value = TP
        CMN.Parameters.Add("@FECHA_OPER", SqlDbType.SmallDateTime)
        CMN.Parameters("@FECHA_OPER").Value = Format(FECHA_OPER, "dd/MM/yyyy")
        CMN.Parameters.Add("@TIPO", SqlDbType.Char, 1)
        CMN.Parameters("@TIPO").Value = TIPO
        CMN.Parameters.Add("@SW", SqlDbType.Int)
        CMN.Parameters("@SW").Direction = ParameterDirection.Output
        CN.Open()
        CMN.ExecuteNonQuery()
        INTVALIDAR = CMN.Parameters("@SW").Value
        MANT_FECHA_OPERACION = INTVALIDAR
TrataError:
        CN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "FECHA DE OPERACION", Err.Description)
    End Function
    Sub SALDO_INI(ByVal TF As String, ByVal FI As String, ByVal TXT_SALDO_G As TextBox, ByVal TXT_SALDO_O As TextBox, ByVal TXT_SALDO_L As TextBox, CN As SqlConnection)
        On Error GoTo TrataError

        Dim CMN As New SqlCommand
        CMN.Connection = CN
        CMN.CommandType = CommandType.StoredProcedure
        CMN.CommandTimeout = 0

        CMN.CommandText = "SALDO_MOV_BANCO"
        CMN.Parameters.Add("@ABANCODI", SqlDbType.TinyInt)
        CMN.Parameters("@ABANCODI").Value = CodBanco
        CMN.Parameters.Add("@TF", SqlDbType.Char, 1)
        CMN.Parameters("@TF").Value = TF
        CMN.Parameters.Add("@FI", SqlDbType.Char, 8)
        CMN.Parameters("@FI").Value = FI
        CMN.Parameters.Add("@SALDO_G", SqlDbType.Float)
        CMN.Parameters("@SALDO_G").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@SALDO_O", SqlDbType.Float)
        CMN.Parameters("@SALDO_O").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@SALDO_L", SqlDbType.Float)
        CMN.Parameters("@SALDO_L").Direction = ParameterDirection.Output
        CN.Open()
        CMN.ExecuteNonQuery()
        TXT_SALDO_G.Text = Math.Round(CMN.Parameters("@SALDO_G").Value, 2)
        TXT_SALDO_O.Text = Math.Round(CMN.Parameters("@SALDO_O").Value, 2)
        TXT_SALDO_L.Text = Math.Round(CMN.Parameters("@SALDO_L").Value, 2)
TrataError:
        CN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "SALDO INICIAL MOVIMIENTOS DE BANCOS", Err.Description)
    End Sub
End Class
