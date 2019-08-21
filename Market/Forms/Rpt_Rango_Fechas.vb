Public Class Rpt_Rango_Fechas

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            With New Impresion
                Select Case Me.Tag
                    Case ""
                        .FORM = "Rpte_Mov_Caja"
                    Case "TP"
                        .FORM = "Rpte_Tipo_Pagos"
                    Case "TJ"
                        .FORM = "Rpte_Tarjetas"

                End Select
                .FI = Format(Me.DT_INI.Value, "yyyyMMdd")
                .FF = Format(Me.DT_FIN.Value, "yyyyMMdd")
                .TITULO = "Del : " & Format(Me.DT_INI.Value, "dd/MM/yyyy") & " Al  " & Format(Me.DT_FIN.Value, "dd/MM/yyyy")
                .Show()
            End With

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class