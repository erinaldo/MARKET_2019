Public Class ClsCaja
    Function GRABAR(ByVal TIPOMOVI As String, ByVal FECHA_CAJA As Date,
                ByVal MON_CAJA As String, ByVal MONTO_CAJA As Double,
                ByVal NROPTOVTA As String, ByVal OBSERV_CAJA As String,
                ByVal TURNO As Integer, ByVal TRANSF_CAJA As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "CAJA_GRABAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@TIPOMOVI", SqlDbType.Char)
            CMN.Parameters("@TIPOMOVI").Value = TIPOMOVI
            CMN.Parameters.Add("@COD_USER", SqlDbType.VarChar)
            CMN.Parameters("@COD_USER").Value = GUSERID
            CMN.Parameters.Add("@FECHA_CAJA", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_CAJA").Value = FECHA_CAJA
            CMN.Parameters.Add("@MON_CAJA", SqlDbType.Char)
            CMN.Parameters("@MON_CAJA").Value = MON_CAJA
            CMN.Parameters.Add("@MONTO_CAJA", SqlDbType.Decimal)
            CMN.Parameters("@MONTO_CAJA").Value = MONTO_CAJA
            CMN.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar)
            CMN.Parameters("@NROPTOVTA").Value = NROPTOVTA
            CMN.Parameters.Add("@OBSERV_CAJA", SqlDbType.VarChar)
            CMN.Parameters("@OBSERV_CAJA").Value = OBSERV_CAJA
            CMN.Parameters.Add("@TURNO", SqlDbType.Int)
            CMN.Parameters("@TURNO").Value = TURNO
            CMN.Parameters.Add("@TRANSF_CAJA", SqlDbType.Bit)
            CMN.Parameters("@TRANSF_CAJA").Value = TRANSF_CAJA
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            GRABAR = CMN.Parameters("@SW").Value

            CMN = Nothing
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Function ANULAR(ID_CAJA As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "CAJA_ANULAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@ID_CAJA", SqlDbType.Int)
            CMN.Parameters("@ID_CAJA").Value = ID_CAJA
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            ANULAR = CMN.Parameters("@SW").Value

            CMN = Nothing
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
End Class
