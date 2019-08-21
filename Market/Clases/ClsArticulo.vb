Public Class ClsArticulo
    Public Sub LISTAR_ART_PRECIOS(ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, ByVal COD As String)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("LISTAR_ARTICULOS_PRECIOS", CN_NET)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@COD").Value = COD
        da.Fill(dt)
        FLEX.DataSource = dt
    End Sub
    Public Function GRABAR_ART_PRECIOS(ByVal TIPO_PRECIO As String, ByVal COD_ART As String, ByVal PREBASE As Double) As Integer
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand  'ADODB.Command
        Dim intValidar As Integer


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "GRABAR_ARTICULO_PRECIO"
        Cmn.Parameters.Add("@COD_TPRECIO", SqlDbType.Char, 2)
        Cmn.Parameters("@COD_TPRECIO").Value = TIPO_PRECIO
        Cmn.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        Cmn.Parameters("@COD_ART").Value = COD_ART
        Cmn.Parameters.Add("@PREBASE", SqlDbType.Float)
        Cmn.Parameters("@PREBASE").Value = PREBASE
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value

        GRABAR_ART_PRECIOS = intValidar

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando TIPO DE PRECIO", Err.Description)
    End Function
    Public Function GRABAR_ART_PROVEEDOR(ByVal PROV As String, ByVal COD_ART As String) As Integer
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand  'ADODB.Command
        Dim intValidar As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "GRABAR_ARTICULO_PROV"
        Cmn.Parameters.Add("@COD_PROVED", SqlDbType.Char, 20)
        Cmn.Parameters("@COD_PROVED").Value = PROV
        Cmn.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        Cmn.Parameters("@COD_ART").Value = COD_ART
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value

        GRABAR_ART_PROVEEDOR = intValidar

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDOR", Err.Description)
    End Function
    Public Function GRABAR_ART_BARRAS(ByVal COD As String, ByVal COD_ART As String) As Integer
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand  'ADODB.Command
        Dim intValidar As Integer
        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "GRABAR_ARTICULO_BARRAS"
        Cmn.Parameters.Add("@COD_BARRAS", SqlDbType.Char, 20)
        Cmn.Parameters("@COD_BARRAS").Value = COD
        Cmn.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        Cmn.Parameters("@COD_ART").Value = COD_ART
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value

        GRABAR_ART_BARRAS = intValidar

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando BARRAS", Err.Description)
    End Function
    Public Sub LISTAR_ART_PROV(ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, ByVal COD As String)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("LISTAR_ARTICULOS_PROV", CN_NET)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@COD").Value = COD
        da.Fill(dt)
        FLEX.DataSource = dt
    End Sub
    Public Sub LISTAR_ART_BARRAS(ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, ByVal COD As String)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("LISTAR_ARTICULOS_BARRAS", CN_NET)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@COD").Value = COD
        da.Fill(dt)
        FLEX.DataSource = dt
    End Sub
    Public Sub LISTAR_ART_COMBO(ByVal FLEX As C1.Win.C1FlexGrid.C1FlexGrid, ByVal COD As String)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("LISTAR_ARTICULOS_COMBOS", CN_NET)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@COD").Value = COD
        da.Fill(dt)
        FLEX.DataSource = dt
    End Sub
    Public Function MANT_ARTICULOS(ByVal strCod As String, ByVal strDes As String, ByVal COD_MEDIDA As String, ByVal COD_FAMILIA As String, ByVal COD_GRUPO As String, ByVal COMBO_ART As Boolean, COD_SUNAT As String, STOCK_MIN As Double, ByVal C1_COMBO As C1.Win.C1FlexGrid.C1FlexGrid, ByVal STRTIPO As String) As Integer

        On Error GoTo TrataError
        Dim Cmn As New SqlCommand  'ADODB.Command
        Dim intValidar As Integer

        Dim OCOMANDO As SqlCommand
        Dim SQL As String
        Dim FIL As Integer

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "MANT_ARTICULOS"
        Cmn.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        Cmn.Parameters("@COD_ART").Value = strCod
        Cmn.Parameters.Add("@DESC_ART", SqlDbType.VarChar, 2500)
        Cmn.Parameters("@DESC_ART").Value = strDes
        Cmn.Parameters.Add("@COD_MEDIDA", SqlDbType.VarChar, 4)
        Cmn.Parameters("@COD_MEDIDA").Value = COD_MEDIDA
        Cmn.Parameters.Add("@COD_FAMILIA", SqlDbType.VarChar, 3)
        Cmn.Parameters("@COD_FAMILIA").Value = COD_FAMILIA
        Cmn.Parameters.Add("@COD_GRUPO", SqlDbType.VarChar, 3)
        Cmn.Parameters("@COD_GRUPO").Value = COD_GRUPO
        Cmn.Parameters.Add("@COMBO_ART", SqlDbType.Bit)
        Cmn.Parameters("@COMBO_ART").Value = COMBO_ART

        Cmn.Parameters.Add("@COD_SUNAT", SqlDbType.Char, 8)
        Cmn.Parameters("@COD_SUNAT").Value = COD_SUNAT

        Cmn.Parameters.Add("@STOCK_MIN", SqlDbType.Float)
        Cmn.Parameters("@STOCK_MIN").Value = STOCK_MIN

        Cmn.Parameters.Add("@TIP", SqlDbType.Char, 1)
        Cmn.Parameters("@TIP").Value = STRTIPO
        Cmn.Parameters.Add("@ingproc_001", SqlDbType.Int)
        Cmn.Parameters("@ingproc_001").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@ingproc_001").Value
        'If intValidar = 0 Then MsgBox("Datos se grabaron Correctamente", MsgBoxStyle.Information)
        'If intValidar = 1 Then MsgBox(Err.Description)
        If intValidar = 0 And COMBO_ART = True Then
            For FIL = 1 To C1_COMBO.Rows.Count - 1
                SQL = "insert into COMBOS values('" & strCod & "','" & C1_COMBO.Item(FIL, 0) & "'," & C1_COMBO.Item(FIL, 3) & ")"
                OCOMANDO = New SqlCommand(SQL, CN_NET)
                OCOMANDO.ExecuteNonQuery()
            Next
        End If

        MANT_ARTICULOS = intValidar

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando MEDIDAS", Err.Description)
    End Function
    Public Function LISTAR_ARTICULOS(ByVal COD_ART As String) As SqlDataReader ' ADODB.Recordset
        Try
            Dim SQL As String

            SQL = "EXEC LISTAR_ARTICULOS 2,'" & COD_ART & "','ARTICULOS.COD_ART'"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            CN_NET.Open()
            'RS = OCOMANDO.ExecuteReader
            LISTAR_ARTICULOS = OCOMANDO.ExecuteReader 'RS
            'RS.Close()
            'CN_NET.Close()
        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function SALDO_INI(ByVal COD_ART As String, ByVal FECHA As String) As Double
        On Error GoTo TrataError

        'Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        'CNN = New SqlClient.SqlConnection(CN_NET)
        CMN.CommandText = "IAM_STOCK_ANT"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CN_NET
        ''
        CMN.Parameters.Add("@COD", SqlDbType.VarChar)
        CMN.Parameters("@COD").Value = COD_ART
        CMN.Parameters.Add("@FEC", SqlDbType.VarChar)
        CMN.Parameters("@FEC").Value = FECHA
        CMN.Parameters.Add("@STOCK", SqlDbType.Float)
        CMN.Parameters("@STOCK").Direction = ParameterDirection.Output

        CN_NET.Open()

        CMN.ExecuteNonQuery()

        SALDO_INI = CMN.Parameters("@STOCK").Value

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "STOCK INICIAL", Err.Description)
    End Function
    Public Function BUSCAR_ARTICULOS_BARRAS(ByVal COD_BARRAS As String) As SqlDataReader ' ADODB.Recordset
        Try
            Dim SQL As String

            SQL = "EXEC IAM_BUSCAR_COD_BARRAS '" & COD_BARRAS & "'"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            CN_NET.Open()
            BUSCAR_ARTICULOS_BARRAS = OCOMANDO.ExecuteReader
            'RS.Close()
            'CN_NET.Close()
        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)
        End Try

    End Function
    Public Function BUSCAR_STOCK(ByVal COD_ART As String, ByVal CANT As Double) As Double
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand  'ADODB.Command
        Dim intValidar As Double


        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "BUSCAR_STOCK"
        Cmn.Parameters.Add("@CODIGO", SqlDbType.Char, 15)
        Cmn.Parameters("@CODIGO").Value = COD_ART
        Cmn.Parameters.Add("@CANT", SqlDbType.Float)
        Cmn.Parameters("@CANT").Value = CANT
        Cmn.Parameters.Add("@STOCK", SqlDbType.Float)
        Cmn.Parameters("@STOCK").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@STOCK").Value

        BUSCAR_STOCK = intValidar

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando TIPO DE PRECIO", Err.Description)
    End Function
    Public Function VERIFICAR_STOCK(ByVal COD_ART As String, ByVal COD_ALMACEN As Double) As Double
        On Error GoTo TrataError
        Dim Cmn As New SqlCommand  'ADODB.Command
        Dim intValidar As Double

        Cmn.Connection = CN_NET
        Cmn.CommandType = CommandType.StoredProcedure
        Cmn.CommandText = "IAM_VERIFICAR_STOCK"
        Cmn.Parameters.Add("@COD_ART", SqlDbType.Char, 15)
        Cmn.Parameters("@COD_ART").Value = COD_ART
        Cmn.Parameters.Add("@COD_ALMACEN", SqlDbType.BigInt)
        Cmn.Parameters("@COD_ALMACEN").Value = COD_ALMACEN
        Cmn.Parameters.Add("@STOCK", SqlDbType.Float)
        Cmn.Parameters("@STOCK").Direction = ParameterDirection.Output
        CN_NET.Open()
        Cmn.ExecuteNonQuery()
        intValidar = Cmn.Parameters("@STOCK").Value

        VERIFICAR_STOCK = intValidar

TrataError:
        CN_NET.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "Insertando PROVEEDOR", Err.Description)
    End Function
End Class
