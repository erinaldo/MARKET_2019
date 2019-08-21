Public Class Cobranza_Masiva_Detalle
    Dim OBJCOBROS As ClsCobro
    Dim OBJTC As ClsTC
    Public FINI As DateTime
    Public FFIN As DateTime


    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub
    Public Sub CARGAR_DATOS(ByVal FI As String, ByVal FF As String, ByVal CLIENTES As String)
        Try

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("COBRO_DEUDA_CLIENTE_RESUMEN", CAD_CON)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@FI", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@FI").Value = FI
            da.SelectCommand.Parameters.Add("@FF", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@FF").Value = FF
            da.SelectCommand.Parameters.Add("@CAD", SqlDbType.VarChar)
            da.SelectCommand.Parameters("@CAD").Value = CLIENTES
            da.Fill(dt)
            Me.DBLISTAR.DataSource = dt

            DBLISTAR.Cols(3).Format = "###,###,###.000"
            DBLISTAR.Cols(4).Format = "###,###,###.000"
            DBLISTAR.Cols(5).DataType = GetType(Boolean)
            DBLISTAR.AutoSizeCol(3)
            DBLISTAR.AutoSizeCol(4)
            DBLISTAR.Cols(6).Visible = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Cobranza_Masiva_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCOBROS = New ClsCobro
        OBJTC = New ClsTC
        Me.TXT_TOTAL.Text = ""
    End Sub

    Private Sub DBLISTAR_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.AfterEdit

    End Sub

    Private Sub DBLISTAR_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles DBLISTAR.BeforeEdit
        If e.Col < 5 Then e.Cancel = True
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click
        If Me.DBLISTAR.Col = 5 Then
            TOTAL()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim F As Integer
            For f = 1 To Me.DBLISTAR.Rows.Count - 1
                Me.DBLISTAR.Item(F, 5) = 1
            Next
            TOTAL()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim F As Integer
            For F = 1 To Me.DBLISTAR.Rows.Count - 1
                Me.DBLISTAR.Item(F, 5) = 0
            Next
            TOTAL()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub TOTAL()
        Dim F As Integer
        Dim TOT As Double = 0
        For F = 1 To Me.DBLISTAR.Rows.Count - 1
            If Me.DBLISTAR.Item(F, 5).ToString <> 0 Then
                TOT = TOT + Me.DBLISTAR.Item(F, 4)
            End If
        Next
        Me.TXT_TOTAL.Text = GFormatodeNumero(TOT, 2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim intvalor As Integer
            Dim TC As Double = OBJTC.BUSCAR_TC(Date.Now, "V")
            If TC = 0 Then MsgBox("Ingrese Tipo de Cambio del dia", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_TOTAL.Text) = 0 Then MsgBox("Seleccione al menos un Cliente", MsgBoxStyle.Information) : Exit Sub
            intvalor = OBJCOBROS.GRABAR_COBRO_MASIVO("001", "S", Me.TXT_TOTAL.Text, GUSERID, "E", "", "", "", Date.Now, TC, Me.DBLISTAR, FINI, FFIN)
            If intvalor = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
            If intvalor = 0 Then
                MsgBox("Cobro grabado con exito", MsgBoxStyle.Information)
                If MsgBox("Desea Imprimir Recibo??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then imprimir()
                Me.Close()
                'Call ToolNuevo_Click(ToolNuevo, EventArgs.Empty)
                'Call HabBotones(True)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub IMPRIMIR()
        Dim COD As Integer = OBJCOBROS.CODIGO
        With Impresion
            .FORM = "Cobranza_Cliente"
            .SW = COD
            .CADENA = ""
            .CAMPO = ""
            .Show()

        End With
    End Sub
End Class