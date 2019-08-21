Public Class Ventas_Dscto_V2
    Public CORR As Double
    Private Sub TXT_CANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANTIDAD.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_CANTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXT_CANTIDAD.TextChanged
        Try
            If Me.OPT_PRODUCTO.Checked Then
                Me.TXT_PORCENTAJE.Text = Math.Round(TXT_CANTIDAD.Text / TXT_CANT.Text * 100, 2)
            Else
                Me.TXT_PORCENTAJE.Text = Math.Round(TXT_CANTIDAD.Text / TXT_CANT_TOTAL.Text * 100, 2)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_PORCENTAJE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PORCENTAJE.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_PORCENTAJE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PORCENTAJE.TextChanged
        Try
            If Me.OPT_PRODUCTO.Checked Then
                Me.TXT_CANTIDAD.Text = Math.Round(TXT_CANT.Text * TXT_PORCENTAJE.Text / 100, 2)
            Else
                Me.TXT_CANTIDAD.Text = Math.Round(TXT_CANT_TOTAL.Text * TXT_PORCENTAJE.Text / 100, 2)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim OBJVENTAS As New ClsVenta
            Dim PORC As Double
            If Val(Me.TXT_CANTIDAD.Text) < 0 Then MsgBox("La Cantidad no puede ser 0", MsgBoxStyle.Information) : Exit Sub

            If OBJVENTAS.AGREGAR_DSCTO_DETALLE_V2(Me.Tag, CORR, CDbl(Me.TXT_PORCENTAJE.Text), Val(Me.TXT_CANTIDAD.Text), IIf(Me.OPT_PRODUCTO.Checked, "U", "T")) = 1 Then MsgBox("Error al agregar detalle", MsgBoxStyle.Critical) : Exit Sub

            'OBJVENTAS.CARGAR_DETALLE(Me.LBLCORRELATIVO.Text, Ventas.DBLISTAR)
            Ventas_V2.CARGAR_DETALLE()
            ''Ventas.TOTAL()
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Ventas_Dscto_V2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class