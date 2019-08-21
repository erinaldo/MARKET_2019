Public Class Ventas_Dscto
    Dim OBJVENTAS As ClsVenta
    Private Sub Ventas_Dscto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJVENTAS = New ClsVenta
    End Sub
    Sub CALCULAR()
        Try
            If Me.OPT_PORC.Checked = True Then
                Me.TXT_TOT_APLICADO.Text = GFormatodeNumero(Me.TXT_TOTAL.Text - (Me.TXT_TOTAL.Text * Me.TXT_DSCTO.Text / 100), 2)
            Else
                Me.TXT_TOT_APLICADO.Text = GFormatodeNumero(Val(Me.TXT_TOTAL.Text) - Val(Me.TXT_DSCTO.Text), 2)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TXT_DSCTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DSCTO.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CALCULAR()
        End If
    End Sub

    Private Sub TXT_DSCTO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_DSCTO.LostFocus
        CALCULAR()
    End Sub

    Private Sub TXT_DSCTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DSCTO.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub OPT_PORC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_PORC.CheckedChanged
        CALCULAR()
    End Sub

    Private Sub OPT_VALOR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_VALOR.CheckedChanged
        CALCULAR()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim PORC As Double
            'If Val(Me.TXT_DSCTO.Text) = 0 Then MsgBox("Ingrese el Descuento", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_TOT_APLICADO.Text) < 0 Then MsgBox("El Total no puede ser negativo", MsgBoxStyle.Information) : Exit Sub
            If Me.Tag = "I" Then
                If OBJVENTAS.AGREGAR_DSCTO_DETALLE(Me.LBLIDDETALLE.Text, IIf(Me.OPT_PORC.Checked, "P", "M"), CDbl(Me.TXT_DSCTO.Text), Me.Tag) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
            Else
                If Me.OPT_VALOR.Checked Then
                    PORC = (Val(Me.TXT_DSCTO.Text) * 100) / (Val(Me.TXT_TOTAL.Text))
                Else
                    PORC = Val(Me.TXT_DSCTO.Text)
                End If
                If OBJVENTAS.AGREGAR_DSCTO_DETALLE(Me.LBLCORRELATIVO.Text, "P", PORC, Me.Tag) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub
            End If
            OBJVENTAS.CARGAR_DETALLE(Me.LBLCORRELATIVO.Text, Ventas.DBLISTAR)
            Ventas.TOTAL()
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class