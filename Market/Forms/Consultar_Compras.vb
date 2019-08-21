Public Class Consultar_Compras

    Private Sub Consultar_Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
        Me.Combo_CRITERIO.SelectedIndex = 0
        Me.Combo_TIPO.SelectedIndex = 0
        Button1_Click(Button1, EventArgs.Empty)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim SP As String = ""
        Dim CAD As String = ""
        Select Case Me.Tag
            Case "Compras"
                SP = "LISTAR_COMPRAS"
                If Me.Combo_CRITERIO.SelectedIndex = 0 Then
                    CAD = " AND ID_compra LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                Else
                    CAD = " AND Compras.serie_COMPRA + '-' + Compras.num_COMPRA LIKE '%" & Me.TXT_BUSCAR.Text & "%'"
                End If
                If Me.TXT_BUSCAR.Text.Trim = "" Then CAD = ""
            Case "Movimientos"
                SP = "MOVIMIENTO_LISTAR"
                If Me.Combo_CRITERIO.SelectedIndex = 0 Then
                    CAD = " AND COD_MOV LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%' AND TIPO_MOV='" & Me.DBLISTAR.Tag & "'"
                Else
                    'CAD = " AND Compras.serie_COMPRA + '-' + Compras.num_COMPRA LIKE '%" & Me.TXT_BUSCAR.Text & "%'"
                    CAD = " AND COD_MOV LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%' AND TIPO_MOV='" & Me.DBLISTAR.Tag & "'"
                End If
                If Me.TXT_BUSCAR.Text.Trim = "" Then CAD = " and TIPO_MOV='" & Me.DBLISTAR.Tag & "'"
            Case "Cobranza"
                SP = "COBRO_LISTAR"
                If Me.Combo_CRITERIO.SelectedIndex = 0 Then
                    CAD = " AND COD_COBRO LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                Else
                    CAD = " AND COD_COBRO LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                End If
                If Me.TXT_BUSCAR.Text.Trim = "" Then CAD = ""
            Case "Pagos"
                SP = "PAGO_LISTAR"
                If Me.Combo_CRITERIO.SelectedIndex = 0 Then
                    CAD = " AND COD_PAGO LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                Else
                    CAD = " AND COD_PAGO LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                End If
                If Me.TXT_BUSCAR.Text.Trim = "" Then CAD = ""
            Case "Inventario"
                SP = "INVENTARIO_LISTAR"
                If Me.Combo_CRITERIO.SelectedIndex = 0 Then
                    CAD = " AND COD_INV LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                Else
                    CAD = " AND COD_INV LIKE '%" & Me.TXT_BUSCAR.Text.Trim & "%'"
                End If
                If Me.TXT_BUSCAR.Text.Trim = "" Then CAD = ""
        End Select
        Dim da As New SqlClient.SqlDataAdapter(SP, CN_NET)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@CAD", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@CAD").Value = CAD
        da.SelectCommand.Parameters.Add("@FI", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@FI").Value = Format(Me.DT_INI.Value, "yyyyMMdd")
        da.SelectCommand.Parameters.Add("@FF", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@FF").Value = Format(Me.DT_FIN.Value, "yyyyMMdd")
        da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@TIPO").Value = Microsoft.VisualBasic.Left(Me.Combo_TIPO.Text, 1)
        da.Fill(dt)
        Me.DBLISTAR.DataSource = dt
        DBLISTAR.AutoSizeCols()
        Select Case Me.Tag
            Case "Movimientos"
                Me.DBLISTAR.Cols(0).Visible = False
                Me.DBLISTAR.Cols(1).Visible = False
        End Select
    End Sub

    Private Sub TXT_BUSCAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BUSCAR.TextChanged
        Call Button1_Click(Button1, EventArgs.Empty)
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
        Try
            If Me.DBLISTAR.Item(Me.DBLISTAR.Row, 6) <> "" Then MsgBox("Documento se encuentra Anulado", MsgBoxStyle.Information) : Exit Sub
            Select Case Me.Tag
                Case "Compras"
                    Compras.LLENAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0))
                Case "Movimientos"
                    Movimientos.LLENAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0))
                Case "Cobranza"
                    Cobranza_Cliente.LLENAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0))
                Case "Pagos"
                    Pago_Proveedor.LLENAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0))
                Case "Inventario"
                    Mant_Inventario.LLENAR_DATOS(Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0))
            End Select

            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class