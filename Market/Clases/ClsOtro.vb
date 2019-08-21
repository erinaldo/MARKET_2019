Public Class ClsOtro
    Private COD_OTRO As Double
    Private DESC_OTRO As String
    Private STAT_OTRO As Integer

    Public Property Codigo As Double
        Get
            Return COD_OTRO
        End Get
        Set(value As Double)
            COD_OTRO = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return DESC_OTRO
        End Get
        Set(value As String)
            DESC_OTRO = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_OTRO
        End Get
        Set(value As Integer)
            STAT_OTRO = value
        End Set
    End Property
    Function Mantenimiento(Tipo As String) As Integer
        Try
            'Dim intValidar As Integer
            Dim CMN As New SqlClient.SqlCommand
            CMN.Connection = CN_NET
            CMN.CommandType = CommandType.StoredProcedure
            CMN.CommandTimeout = 0
            ''
            CMN.CommandText = "MANT_OTRO"
            CMN.Parameters.Add("@COD_OTRO", SqlDbType.BigInt)
            CMN.Parameters("@COD_OTRO").Value = Codigo
            CMN.Parameters.Add("@DESC_OTRO", SqlDbType.VarChar, 150)
            CMN.Parameters("@DESC_OTRO").Value = Descripcion
            CMN.Parameters.Add("@STAT_OTRO", SqlDbType.Bit)
            CMN.Parameters("@STAT_OTRO").Value = Estado
            CMN.Parameters.Add("@TIP", SqlDbType.Char, 1)
            CMN.Parameters("@TIP").Value = Tipo
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

End Class
