Public Class Cobranza_Masiva
    Dim OBJCLIENTES As ClsCliente
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Cobranza_Masiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCLIENTES = New ClsCliente
        OBJCLIENTES.LLENAR_CLIENTES(Me.List_clie_orig)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.List_clie_orig.Text <> "" Then
            Me.List_clie_destino.Items.Add(Me.List_clie_orig.SelectedItem)
            Dim F As Integer = Me.List_clie_orig.SelectedIndex
            Me.List_clie_orig.Items.RemoveAt(Me.List_clie_orig.SelectedIndex)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.List_clie_orig.Items.Clear()
        OBJCLIENTES.LLENAR_CLIENTES(Me.List_clie_destino)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.List_clie_destino.Items.Clear()
        OBJCLIENTES.LLENAR_CLIENTES(Me.List_clie_orig)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.List_clie_destino.Text <> "" Then
            Me.List_clie_orig.Items.Add(Me.List_clie_destino.Text)
            Me.List_clie_destino.Items.RemoveAt(Me.List_clie_destino.SelectedIndex)

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim F As Integer
            Dim CAD As String = ""

            If Me.List_clie_destino.Items.Count = 0 Then MsgBox("Seleccione al menos un Cliente", MsgBoxStyle.Critical) : Exit Sub
            For F = 0 To Me.List_clie_destino.Items.Count - 1
                Me.List_clie_destino.SelectedIndex = F
                CAD = CAD + "'" + Trim(Strings.Right(Me.List_clie_destino.Text.Trim, 20)) + "'" + ","
            Next
            CAD = Strings.Left(CAD, Strings.Len(CAD.Trim) - 1)
            Cobranza_Masiva_Detalle.FINI = Me.DT_INI.Value
            Cobranza_Masiva_Detalle.FFIN = Me.DT_FIN.Value
            Cobranza_Masiva_Detalle.CARGAR_DATOS(Format(Me.DT_INI.Value, "yyyyMMdd"), Format(Me.DT_FIN.Value, "yyyyMMdd"), CAD)
            Cobranza_Masiva_Detalle.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FIN.ValueChanged

    End Sub
End Class