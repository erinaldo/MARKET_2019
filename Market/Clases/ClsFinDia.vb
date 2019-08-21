Public Class ClsFinDia
    Public Function VERIFICAR_PC() As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "FIN_DIA_VERIFICAR_PC"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@PC", SqlDbType.NVarChar)
            CMN.Parameters("@PC").Value = SystemInformation.ComputerName
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            VERIFICAR_PC = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
    Public Function GENERAR_FIN_DIA(ByVal FECHA As DateTime, TURNO As Integer) As Integer
        Try
            Dim CNN As SqlClient.SqlConnection
            Dim CMN As New SqlClient.SqlCommand

            CNN = New SqlClient.SqlConnection(CAD_CON)
            CMN.CommandText = "FIN_DIA_GENERAR"
            CMN.CommandType = CommandType.StoredProcedure
            CMN.Connection = CNN
            ''
            CMN.Parameters.Add("@FECHA_PROCESO", SqlDbType.SmallDateTime)
            CMN.Parameters("@FECHA_PROCESO").Value = FECHA
            CMN.Parameters.Add("@TURNO", SqlDbType.Int)
            CMN.Parameters("@TURNO").Value = TURNO
            CMN.Parameters.Add("@APTOCODI", SqlDbType.NVarChar)
            CMN.Parameters("@APTOCODI").Value = GPTOVTA
            CMN.Parameters.Add("@SW", SqlDbType.Int)
            CMN.Parameters("@SW").Direction = ParameterDirection.Output

            CNN.Open()

            CMN.ExecuteNonQuery()

            GENERAR_FIN_DIA = CMN.Parameters("@SW").Value
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function
End Class
