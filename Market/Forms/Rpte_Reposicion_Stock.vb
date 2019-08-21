Public Class Rpte_Reposicion_Stock

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With Impresion
                .FORM = "Reposicion"
                .TIPO = Val(Me.TXT_CANT.Text)
                .COMBO_CANT = Me.Combo_cant.SelectedIndex
                .Show()

            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Rpte_Reposicion_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Combo_CANT.SelectedIndex = 0
    End Sub

    Private Sub Combo_cant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_CANT.SelectedIndexChanged

    End Sub
End Class