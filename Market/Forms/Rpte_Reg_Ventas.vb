Public Class Rpte_Reg_Ventas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

        
            With Impresion
                .FORM = "Rpte_Reg_Ventas"
                Select Case True
                    Case Me.OPT_GENERAL.Checked
                        .SW = 1
                    Case Me.OPT_DETALLADO.Checked
                        .SW = 2
                    Case Me.OPT_PRODUCTO.Checked
                        .SW = 3
                End Select
                .CAMPO = IIf(Me.OPT_SOLES.Checked = True, "S", "D")
                .MON = Me.Tag
                .FI = Format(Me.DT_INI.Value, "dd/MM/yyyy")
                .FF = Format(Me.DT_FIN.Value, "dd/MM/yyyy")
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

    Private Sub Rpte_Reg_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class