Public Class Pago_Tarjeta
    Dim OBJTARJETA As ClsTarjeta

    Private Sub Pago_Tarjeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJTARJETA = New ClsTarjeta

        OBJTARJETA.LISTAR_TARJETAS(Me.List_TARJETA)
        Me.Combo_MONEDA.SelectedIndex = 0
        Me.TXT_TARJETA.Select()

        If CFG_MONVENTA = "S" Then lbl_mon.Text = "S/ " Else lbl_mon.Text = "US$ "

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Combo_MONEDA.SelectedIndex = 0
        Me.TXT_TARJETA.Text = ""
        Me.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim TIPO_PAGO As String = ""
            TIPO_PAGO = "T"
            If Me.List_TARJETA.SelectedValue = "" Then MsgBox("Seleccione Tarjeta", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_TARJETA.Text = "" Then MsgBox("Ingrese Numero de Tarjeta", MsgBoxStyle.Information) : Exit Sub

            If Ventas_V2.GRABAR_TARJETA(Me.List_TARJETA.SelectedValue, Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_TARJETA.Text) = 0 Then
                MsgBox("Grabado Correctamente")
                Ventas_V2.MANDAR_IMPRESION()
                Ventas_V2.Button_CANCELAR_Click(Ventas.Button_CANCELAR, EventArgs.Empty)
                Me.Button2_Click(Button2, EventArgs.Empty)
            Else
                'MsgBox("Error al Grabar")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub

    Private Sub TXT_TARJETA_TextChanged(sender As Object, e As EventArgs) Handles TXT_TARJETA.TextChanged

    End Sub

    Private Sub TXT_TARJETA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TARJETA.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub
End Class