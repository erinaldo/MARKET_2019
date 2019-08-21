Public Class ClsAlmacen
    Private COD_ALMACEN As Double
    Private DESC_ALMACEN As String
    Private STAT_ALMACEN As Integer

    Public Property Codigo As Double
        Get
            Return COD_ALMACEN
        End Get
        Set(value As Double)
            COD_ALMACEN = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return DESC_ALMACEN
        End Get
        Set(value As String)
            DESC_ALMACEN = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_ALMACEN
        End Get
        Set(value As Integer)
            STAT_ALMACEN = value
        End Set
    End Property

    Public Function Mantenimiento(ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_ALMACENES"
        Cmn.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        Cmn.Parameters("@COD_ALMACEN").Value = Codigo
        Cmn.Parameters.Add("@DESC_ALMACEN", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_ALMACEN").Value = Descripcion
        Cmn.Parameters.Add("@STAT_ALMACEN", SqlDbType.Bit)
        Cmn.Parameters("@STAT_ALMACEN").Value = Estado
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        Mantenimiento = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando BANCOS", Err.Description)
    End Function
End Class
