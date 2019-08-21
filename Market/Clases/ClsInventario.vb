Public Class ClsInventario
    Private COD_INV As Double
    Private FECHA_INV As Date
    Private COD_ALMACEN As Double
    Private OBSERV_INV As String
    Private STAT_INV As Integer

    Public Property Codigo As Double
        Get
            Return COD_INV
        End Get
        Set(value As Double)
            COD_INV = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return FECHA_INV
        End Get
        Set(value As Date)
            FECHA_INV = value
        End Set
    End Property

    Public Property Almacen As Double
        Get
            Return COD_ALMACEN
        End Get
        Set(value As Double)
            COD_ALMACEN = value
        End Set
    End Property

    Public Property Observacion As String
        Get
            Return OBSERV_INV
        End Get
        Set(value As String)
            OBSERV_INV = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_INV
        End Get
        Set(value As Integer)
            STAT_INV = value
        End Set
    End Property

    Public Function Mantenimiento(ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_INVENTARIO"
        Cmn.Parameters.Add("@COD_INV", SqlDbType.BigInt)
        Cmn.Parameters("@COD_INV").Value = Codigo
        Cmn.Parameters.Add("@FECHA_INV", SqlDbType.Date)
        Cmn.Parameters("@FECHA_INV").Value = Format(Fecha, "dd/MM/yyyy")
        Cmn.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        Cmn.Parameters("@COD_ALMACEN").Value = Almacen
        Cmn.Parameters.Add("@OBSERV_INV", SqlDbType.VarChar, 2500)
        Cmn.Parameters("@OBSERV_INV").Value = Observacion
        Cmn.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
        Cmn.Parameters("@COD_USER").Value = GUSERID
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value

        Mantenimiento = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando BANCOS", Err.Description)
    End Function
    Sub ELIMINAR_TEMP_INVENTARIO()
        Dim SQL As String
        Dim OCOMANDO As SqlCommand
        Dim CNN As SqlConnection
        CNN = New SqlClient.SqlConnection(CAD_CON)
        SQL = "delete from TEMP_INVENTARIO Where COD_USER='" & GUSERID & "'"
        OCOMANDO = New SqlCommand(SQL, CNN)
        CNN.Open()
        OCOMANDO.ExecuteNonQuery()
        CNN.Close()
    End Sub

    Public Function Mantenimiento_TEMP(COD_ART As String, CANT As Double, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_TEMP_INVENTARIO"
        Cmn.Parameters.Add("@COD_USER", SqlDbType.VarChar, 10)
        Cmn.Parameters("@COD_USER").Value = GUSERID
        Cmn.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        Cmn.Parameters("@COD_ART").Value = COD_ART
        Cmn.Parameters.Add("@CANT", SqlDbType.Float)
        Cmn.Parameters("@CANT").Value = CANT
        Cmn.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        Cmn.Parameters("@COD_ALMACEN").Value = Almacen
        Cmn.Parameters.Add("@FECHA", SqlDbType.Char, 8)
        Cmn.Parameters("@FECHA").Value = Format(Fecha, "yyyyMMdd")
        Cmn.Parameters.Add("@TIPO", SqlDbType.Char, 1)
        Cmn.Parameters("@TIPO").Value = STRTIPO
        Cmn.Parameters.Add("@SW", SqlDbType.Int)
        Cmn.Parameters("@SW").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@SW").Value

        Mantenimiento_TEMP = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando BANCOS", Err.Description)
    End Function
    Sub BUSCAR()
        Dim RS As SqlDataReader
        Dim SQL As String
        SQL = "EXEC BUSCAR_INVENTARIO " & Codigo & ",'" & GUSERID & "'"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        CN_NET.Open()
        RS = OCOMANDO.ExecuteReader
        While RS.Read
            Fecha = RS("FECHA_INV")
            Almacen = RS("COD_ALMACEN")
            Observacion = RS("OBSERV_INV")
            Estado = RS("STAT_INV")
        End While
        RS.Close()
        CN_NET.Close()
    End Sub

End Class
