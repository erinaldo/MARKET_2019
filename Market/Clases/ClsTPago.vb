Public Class ClsTPago
    Private COD_TPAGO As Double
    Private DESC_TPAGO As String
    Private BANCO_TPAGO As Integer
    Private STAT_TPAGO As Integer

    Public Property Codigo As Double
        Get
            Return COD_TPAGO
        End Get
        Set(value As Double)
            COD_TPAGO = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return DESC_TPAGO
        End Get
        Set(value As String)
            DESC_TPAGO = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return STAT_TPAGO
        End Get
        Set(value As Integer)
            STAT_TPAGO = value
        End Set
    End Property

    Public Property PedirBanco As Integer
        Get
            Return BANCO_TPAGO
        End Get
        Set(value As Integer)
            BANCO_TPAGO = value
        End Set
    End Property

    Function Mantenimiento(intMODO As String) As Integer
        ' On Error GoTo TratarError
        Dim intValidar As Integer
        Dim CMN As New SqlCommand
        CMN.Connection = CN_NET
        CMN.CommandType = CommandType.StoredProcedure

        Select Case intMODO
            Case intNUEVO
                CMN.CommandText = "usp_TipoPagoInsProc"
                CMN.Parameters.Add("@DESC_TPAGO", SqlDbType.VarChar, 150)
                CMN.Parameters("@DESC_TPAGO").Value = Descripcion
                CMN.Parameters.Add("@BANCO_TPAGO", SqlDbType.Bit)
                CMN.Parameters("@BANCO_TPAGO").Value = PedirBanco
                CMN.Parameters.Add("@STAT_TPAGO", SqlDbType.Bit)
                CMN.Parameters("@STAT_TPAGO").Value = Estado
                CMN.Parameters.Add("@ing_proc001", SqlDbType.Int)
                CMN.Parameters("@ing_proc001").Direction = ParameterDirection.Output
                CN_NET.Open()
                CMN.ExecuteNonQuery()
                'Codigo = CMN.Parameters("@ABANCODI").Value
                intValidar = CMN.Parameters("@ing_proc001").Value

            Case intMODIFICAR

                CMN.CommandText = "usp_TipoPagoUpdProc"
                CMN.Parameters.Add("@COD_TPAGO", SqlDbType.BigInt)
                CMN.Parameters("@COD_TPAGO").Value = Codigo
                CMN.Parameters.Add("@DESC_TPAGO", SqlDbType.VarChar, 150)
                CMN.Parameters("@DESC_TPAGO").Value = Descripcion
                CMN.Parameters.Add("@BANCO_TPAGO", SqlDbType.Bit)
                CMN.Parameters("@BANCO_TPAGO").Value = PedirBanco
                CMN.Parameters.Add("@STAT_TPAGO", SqlDbType.Bit)
                CMN.Parameters("@STAT_TPAGO").Value = Estado
                CMN.Parameters.Add("@ing_proc001", SqlDbType.Int)
                CMN.Parameters("@ing_proc001").Direction = ParameterDirection.Output
                CN_NET.Open()
                CMN.ExecuteNonQuery()
                intValidar = CMN.Parameters("@ing_proc001").Value

            Case intANULAR

                CMN.CommandText = "usp_TipoPagoAnuProc"
                CMN.Parameters.Add("@COD_TPAGO", SqlDbType.BigInt)
                CMN.Parameters("@COD_TPAGO").Value = Codigo
                CMN.Parameters.Add("@ing_proc001", SqlDbType.Int)
                CMN.Parameters("@ing_proc001").Direction = ParameterDirection.Output
                CN_NET.Open()
                CMN.ExecuteNonQuery()
                intValidar = CMN.Parameters("@ing_proc001").Value
        End Select

        Mantenimiento = intValidar

TratarError:
        CMN = Nothing
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "ClsMtasGenerales.Usuario.Mantenimiento()", Err.Description)
    End Function
    Sub BUSCAR(cn As SqlConnection)
        Dim RS As SqlDataReader
        Try
            Descripcion = ""
            Estado = 0
            Dim OCOMANDO As New SqlCommand("EXEC IAM_BUSCAR_TPAGO " & Codigo & "", cn)
            cn.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                Descripcion = RS("DESC_TPAGO")
                Estado = RS("STAT_TPAGO")
                PedirBanco = RS("BANCO_TPAGO")
            End While
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            cn.Close()
        End Try
    End Sub
End Class
