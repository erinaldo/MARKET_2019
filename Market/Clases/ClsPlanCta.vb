Public Class ClsPlanCta
    Public Function MANT_PLANCTAS(ByVal strCod As String, ByVal strDes As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_PLANCTAS"
        Cmn.Parameters.Add("@COD_PLANCTA", SqlDbType.Char, 4)
        Cmn.Parameters("@COD_PLANCTA").Value = strCod
        Cmn.Parameters.Add("@DESC_PLANCTA", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_PLANCTA").Value = strDes
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_PLANCTAS = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando TARJETAS", Err.Description)
    End Function
    Public Function MANT_PLANCTAS_D(ByVal strCod As String, ByVal SUB_PLANCTA As String, ByVal strDes As String, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_PLANCTAS_D"
        Cmn.Parameters.Add("@COD_PLANCTA", SqlDbType.Char, 4)
        Cmn.Parameters("@COD_PLANCTA").Value = strCod
        Cmn.Parameters.Add("@SUB_PLANCTA", SqlDbType.Char, 2)
        Cmn.Parameters("@SUB_PLANCTA").Value = SUB_PLANCTA
        Cmn.Parameters.Add("@DESC_PLANCTAD", SqlDbType.VarChar, 150)
        Cmn.Parameters("@DESC_PLANCTAD").Value = strDes
        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)

        MANT_PLANCTAS_D = intValidar
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando TARJETAS", Err.Description)
    End Function
    Public Function CORR_SUBCTA(ByVal strCod As String) As String

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand 'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "CORR_SUBCTA"
        Cmn.Parameters.Add("@COD_PLANCTA", SqlDbType.Char, 4)
        Cmn.Parameters("@COD_PLANCTA").Value = strCod
        Cmn.Parameters.Add("@CORR", SqlDbType.Int)
        Cmn.Parameters("@CORR").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@CORR").Value
        

        CORR_SUBCTA = Format(intValidar, "00")
TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando TARJETAS", Err.Description)
    End Function
    Sub LLENAR_CUENTAS(ByVal COMBO As Object)
        Dim RS As SqlDataReader 'New ADODB.Recordset
        Dim SQL As String
        SQL = "EXEC LISTAR_PLANCTAS 0,'" & "" & "','" & "" & "'"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        CN_NET.Open()
        RS = OCOMANDO.ExecuteReader
        'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        While RS.Read
            COMBO.Items.Add(RS("DESCRIPCION") & Space(150) & RS("CODIGO"))
        End While
        RS.Close()
        CN_NET.Close()
    End Sub
End Class
