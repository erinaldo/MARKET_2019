Public Class Rpte_Movimientos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            With Impresion
                .FORM = "Rpte_Movimientos"
                Select Case True
                    Case Me.OPT_GENERAL.Checked
                        .SW = 1
                    Case Me.OPT_DETALLADO.Checked
                        .SW = 2
                End Select
                .CAMPO = IIf(Me.OPT_SOLES.Checked = True, "S", "D")
                .MON = Me.Tag
                .FI = Format(Me.DT_INI.Value, "yyyyMMdd")
                .FF = Format(Me.DT_FIN.Value, "yyyyMMdd")
                .TITULO = "Del : " & Format(Me.DT_INI.Value, "dd/MM/yyyy") & " Al  " & Format(Me.DT_FIN.Value, "dd/MM/yyyy")
                .Show()

            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class