Public Class ClsRubro
    Private COD_RUBRO As Double
    Private DESC_RUBRO As String
    Private STAT_RUBRO As Integer

    Public Property Codigo As Double
        Get
            Return COD_RUBRO
        End Get
        Set(value As Double)
            COD_RUBRO = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return DESC_RUBRO
        End Get
        Set(value As String)
            DESC_RUBRO = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_RUBRO
        End Get
        Set(value As Integer)
            STAT_RUBRO = value
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
            CMN.CommandText = "MANT_RUBRO"
            CMN.Parameters.Add("@COD_RUBRO", SqlDbType.BigInt)
            CMN.Parameters("@COD_RUBRO").Value = Codigo
            CMN.Parameters.Add("@DESC_RUBRO", SqlDbType.VarChar, 150)
            CMN.Parameters("@DESC_RUBRO").Value = Descripcion
            CMN.Parameters.Add("@STAT_RUBRO", SqlDbType.Bit)
            CMN.Parameters("@STAT_RUBRO").Value = Estado
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
