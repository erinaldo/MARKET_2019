Public Class Rpte_Cuentas_Pagar


    Dim OBJPROV As ClsProveedor

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Rpte_Cuentas_Pagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJPROV = New ClsProveedor
        OBJPROV.LLENAR_PROVEEDORES(Me.List_clie_orig)
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
        OBJPROV.LLENAR_PROVEEDORES(Me.List_clie_destino)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.List_clie_destino.Items.Clear()
        OBJPROV.LLENAR_PROVEEDORES(Me.List_clie_orig)
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

            If Me.List_clie_destino.Items.Count = 0 And Me.CheckBox1.Checked = False Then MsgBox("Seleccione al menos un Cliente", MsgBoxStyle.Critical) : Exit Sub
            For F = 0 To Me.List_clie_destino.Items.Count - 1
                Me.List_clie_destino.SelectedIndex = F
                CAD = CAD + "'" + Trim(Strings.Right(Me.List_clie_destino.Text.Trim, 20)) + "'" + ","
            Next
            If Me.CheckBox1.Checked = False Then CAD = Strings.Left(CAD, Strings.Len(CAD.Trim) - 1)

            With Impresion
                .FORM = "Rpte_Cuentas_x_Pagar"

                Select Case True
                    Case Me.OPT_NORMAL.Checked
                        .SW = 1
                    Case Me.OPT_DETALLADO.Checked
                        .SW = 2
                End Select
                .CAMPO = IIf(Me.OPT_SOLES.Checked = True, "S", "D")
                .CADENA = CAD
                .TIPO = IIf(Me.CheckBox1.Checked = True, 1, 0)
                .Show()

            End With

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class