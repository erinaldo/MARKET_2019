Public Class ClsCtaBanc
    Private ACTACODI As Integer
    Private ACTADESC As String
    Private ACTAABRV As String
    Private ACTAMONE As String
    Private COD_BANCO As Integer
    Private ACTASTAT As Integer

    Public Property Codigo As Integer
        Get
            Return ACTACODI
        End Get
        Set(value As Integer)
            ACTACODI = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return ACTADESC
        End Get
        Set(value As String)
            ACTADESC = value
        End Set
    End Property

    Public Property Abrev As String
        Get
            Return ACTAABRV
        End Get
        Set(value As String)
            ACTAABRV = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return ACTAMONE
        End Get
        Set(value As String)
            ACTAMONE = value
        End Set
    End Property

    Public Property Banco As Integer
        Get
            Return COD_BANCO
        End Get
        Set(value As Integer)
            COD_BANCO = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return ACTASTAT
        End Get
        Set(value As Integer)
            ACTASTAT = value
        End Set
    End Property

    Function CtaBancMantenimiento(intMODO As String) As Integer
        Try

            Dim intValidar As Integer
            Dim CMN As New SqlCommand
            CMN.Connection = CN_NET
            Select Case intMODO
                Case intNUEVO
                    CMN.CommandText = "usP_CTABANCInsProc"
                    CMN.CommandType = CommandType.StoredProcedure
                    CMN.Parameters.Add("@COD_BANCO", SqlDbType.TinyInt)
                    CMN.Parameters("@COD_BANCO").Value = Banco
                    CMN.Parameters.Add("@AMONCODI", SqlDbType.Char, 1)
                    CMN.Parameters("@AMONCODI").Value = Moneda
                    CMN.Parameters.Add("@ACTADESC", SqlDbType.NVarChar, 30)
                    CMN.Parameters("@ACTADESC").Value = Descripcion
                    CMN.Parameters.Add("@ACTAABRV", SqlDbType.NVarChar, 30)
                    CMN.Parameters("@ACTAABRV").Value = Abrev
                    CMN.Parameters.Add("@ACTASTAT", SqlDbType.Bit)
                    CMN.Parameters("@ACTASTAT").Value = Estado
                    CMN.Parameters.Add("@ACTACODI", SqlDbType.TinyInt)
                    CMN.Parameters("@ACTACODI").Direction = ParameterDirection.Output
                    CMN.Parameters.Add("@ing_proc001", SqlDbType.Int)
                    CMN.Parameters("@ing_proc001").Direction = ParameterDirection.Output
                    CN_NET.Open()
                    CMN.ExecuteNonQuery()
                    Codigo = CMN.Parameters("@ACTACODI").Value
                    intValidar = CMN.Parameters("@ing_proc001").Value

                Case intMODIFICAR

                    CMN.CommandText = "usp_CTABANCUpdProc"
                    CMN.CommandType = CommandType.StoredProcedure
                    CMN.Parameters.Add("@ACTACODI", SqlDbType.TinyInt)
                    CMN.Parameters("@ACTACODI").Value = Codigo
                    CMN.Parameters.Add("@ACTADESC", SqlDbType.NVarChar, 30)
                    CMN.Parameters("@ACTADESC").Value = Descripcion
                    CMN.Parameters.Add("@ACTAABRV", SqlDbType.NVarChar, 30)
                    CMN.Parameters("@ACTAABRV").Value = Abrev
                    CMN.Parameters.Add("@AMONCODI", SqlDbType.Char, 1)
                    CMN.Parameters("@AMONCODI").Value = Moneda
                    CMN.Parameters.Add("@COD_BANCO", SqlDbType.TinyInt)
                    CMN.Parameters("@COD_BANCO").Value = Banco
                    CMN.Parameters.Add("@ACTASTAT", SqlDbType.Bit)
                    CMN.Parameters("@ACTASTAT").Value = Estado
                    CMN.Parameters.Add("@ing_proc001", SqlDbType.Int)
                    CMN.Parameters("@ing_proc001").Direction = ParameterDirection.Output
                    CN_NET.Open()
                    CMN.ExecuteNonQuery()
                    intValidar = CMN.Parameters("@ing_proc001").Value

                Case intANULAR

                    CMN.CommandText = "usp_CTABANCAnuProc"
                    CMN.CommandType = CommandType.StoredProcedure
                    CMN.Parameters.Add("@ACTACODI", SqlDbType.TinyInt)
                    CMN.Parameters("@ACTACODI").Value = Codigo
                    CMN.Parameters.Add("@ing_proc001", SqlDbType.Int)
                    CMN.Parameters("@ing_proc001").Direction = ParameterDirection.Output
                    CN_NET.Open()
                    CMN.ExecuteNonQuery()
                    intValidar = CMN.Parameters("@ing_proc001").Value
            End Select

            CtaBancMantenimiento = intValidar


        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            CN_NET.Close()
        End Try
    End Function

    Sub BUSCAR()
        Dim RS As SqlDataReader
        Try
            Descripcion = ""
            Estado = 0
            Dim OCOMANDO As New SqlCommand("EXEC IAM_BUSCAR_CTABANCARIA " & Codigo & "", CN_NET)
            CN_NET.Open()
            RS = OCOMANDO.ExecuteReader
            While RS.Read
                Descripcion = RS("ACTADESC")
                Abrev = RS("ACTAABRV")
                Moneda = RS("ACTAMONE")
                Banco = RS("COD_BANCO")
                Estado = RS("ACTASTAT")
            End While
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            RS.Close()
            CN_NET.Close()
        End Try
    End Sub
End Class
