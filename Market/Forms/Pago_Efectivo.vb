Public Class Pago_Efectivo
    Dim OBJTARJETAS As ClsTarjeta
    Dim OBJPAGO As ClsPagos
    Public CORR As Double

    Private Sub TXT_SOLES_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_SOLES.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_SOLES_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SOLES.TextChanged
        Try
            VUELTO()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub VUELTO()
        Dim DOLAR As Double
        Dim TOT_TARJETA As Double
        If CFG_MONVENTA = "S" Then
            TOT_TARJETA = Val(Me.TXT_TOTAL_TARJETA.Text) + Val(Me.TXT_TOTAL_TARJETA_D.Text) * Val(Me.TXT_TC.Text)
            DOLAR = Val(Me.TXT_DOLAR.Text) * Val(Me.TXT_TC.Text)
            Me.TXT_VUELTO.Text = Format((Val(Me.TXT_SOLES.Text) + DOLAR + TOT_TARJETA - Val(Me.LBL_MONTO.Text)), "###,###,###.00")
            ''
            Me.TXT_VUELTO_O.Text = COMAS(TXT_VUELTO.Text) / Val(Me.TXT_TC.Text)
        Else
            TOT_TARJETA = (Val(Me.TXT_TOTAL_TARJETA.Text) / Val(Me.TXT_TC.Text)) + Val(Me.TXT_TOTAL_TARJETA_D.Text)
            DOLAR = Val(Me.TXT_SOLES.Text) / Val(Me.TXT_TC.Text)
            Me.TXT_VUELTO.Text = Format((Val(Me.TXT_DOLAR.Text) + DOLAR + TOT_TARJETA - Val(Me.LBL_MONTO.Text)), "###,###,###.00")
            ''
            Me.TXT_VUELTO_O.Text = COMAS(TXT_VUELTO.Text) * Val(Me.TXT_TC.Text)
        End If


    End Sub
    Private Sub TXT_DOLAR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DOLAR.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_DOLAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DOLAR.TextChanged
        VUELTO()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MONTO_TARJETA.KeyPress
        Dim TTOTAL As Double
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If Me.TXT_TARJETA.Text = "" Then MsgBox("Ingrese nro. de Tarjeta", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_MONTO_TARJETA.Text) = 0 Then MsgBox("Ingrese Monto de Tarjeta", MsgBoxStyle.Information) : Exit Sub

            If CFG_MONVENTA = "S" Then
                If Strings.Left(Me.Combo_MONEDA.Text, 1) = "S" Then
                    TTOTAL = Me.TXT_MONTO_TARJETA.Text
                Else
                    TTOTAL = Me.TXT_MONTO_TARJETA.Text * Val(Me.TXT_TC.Text)
                End If
            Else
                If Strings.Left(Me.Combo_MONEDA.Text, 1) = "D" Then
                    TTOTAL = Me.TXT_MONTO_TARJETA.Text
                Else
                    TTOTAL = Me.TXT_MONTO_TARJETA.Text / Val(Me.TXT_TC.Text)
                End If
            End If
            OBJPAGO.AGREGAR_DETALLE_TARJETA(Me.COMBO_TARJETA.SelectedValue, Strings.Left(Me.Combo_MONEDA.Text, 1), Me.TXT_TARJETA.Text, Me.TXT_MONTO_TARJETA.Text, CORR)
                OBJPAGO.CARGAR_DETALLE_TARJETA(CORR, Me.C1_TARJETA)
                'Me.C1_TARJETA.AddItem(Me.COMBO_TARJETA.SelectedValue & vbTab & Me.COMBO_TARJETA.Text & vbTab & Me.Combo_MONEDA.Text & vbTab & Me.TXT_TARJETA.Text & vbTab & Format(TTOTAL, "###,###,###.00"))
                TOTAL_TARJETA()
                VUELTO()
                Me.Button1.Focus()
            End If
    End Sub
    Sub TOTAL_TARJETA()
        Dim F As Integer
        Dim TOTS As Double = 0
        Dim TOTD As Double = 0
        For F = 1 To Me.C1_TARJETA.Rows.Count - 1
            If Me.C1_TARJETA.Item(F, 2) = "Soles" Then
                TOTS = TOTS + Me.C1_TARJETA.Item(F, 4)
            Else
                TOTD = TOTD + Me.C1_TARJETA.Item(F, 4)
            End If
        Next
        Me.TXT_TOTAL_TARJETA.Text = Format(TOTS, "###,###,###.00")
        Me.TXT_TOTAL_TARJETA_D.Text = Format(TOTD, "###,###,###.00")
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MONTO_TARJETA.TextChanged

    End Sub

    Private Sub Pago_Efectivo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Pago_Efectivo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = (Keys.F7) Then
            Call Button1_Click(Button1, EventArgs.Empty)
        End If
    End Sub

    Private Sub Pago_Efectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJTARJETAS = New ClsTarjeta
        OBJPAGO = New ClsPagos
        Me.Combo_MONEDA.SelectedIndex = 0
        OBJTARJETAS.LISTAR_TARJETAS(Me.COMBO_TARJETA)
        Me.COMBO_TARJETA.SelectedIndex = 1

        'Me.C1_TARJETA.Rows.Count = 1
        TXT_TOTAL_TARJETA.Clear()
        TXT_TOTAL_TARJETA_D.Clear()
        If CFG_MONVENTA = "S" Then
            lbl_MON.Text = "S/ "
            LBL_VUELTO_MON.Text = "S/ "
            Me.TXT_SOLES.Text = Me.LBL_MONTO.Text
            Me.TXT_SOLES.Select()
            ''
            LBL_VUELTO_O.Text = "$ "
        Else
            lbl_MON.Text = "$ "
            LBL_VUELTO_MON.Text = "$ "
            Me.TXT_DOLAR.Text = Me.LBL_MONTO.Text
            Me.TXT_DOLAR.Select()
            ''
            LBL_VUELTO_O.Text = "S/ "
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TXT_SOLES.Text = ""
        Me.TXT_DOLAR.Text = ""
        Me.TXT_TOTAL_TARJETA.Text = ""
        Me.TXT_MONTO_TARJETA.Text = ""
        Me.TXT_TARJETA.Text = ""
        Me.TXT_VUELTO.Text = ""
        OBJPAGO.ELIMINAR_DETALLE_TARJETA(CORR, "T")
        OBJPAGO.CARGAR_DETALLE_TARJETA(CORR, Me.C1_TARJETA)
        Me.Close()
    End Sub

    Private Sub C1_TARJETA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_TARJETA.Click

    End Sub

    Private Sub C1_TARJETA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1_TARJETA.KeyUp
        If e.KeyCode = Keys.Delete Then
            OBJPAGO.ELIMINAR_DETALLE_TARJETA(Me.C1_TARJETA.Item(Me.C1_TARJETA.Row, 0), "U")
            OBJPAGO.CARGAR_DETALLE_TARJETA(CORR, Me.C1_TARJETA)
            'Me.C1_TARJETA.RemoveItem(Me.C1_TARJETA.Row)
            TOTAL_TARJETA()
            VUELTO()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim TOT As Double
            Dim TIPO_PAGO As String = ""
            Dim TOT_TARJETA As Double = 0
            If Val(Me.TXT_SOLES.Text) + Val(Me.TXT_DOLAR.Text) > 0 Then
                If Val(Me.TXT_TOTAL_TARJETA.Text) > 0 Or Val(Me.TXT_TOTAL_TARJETA_D.Text) > 0 Then
                    TIPO_PAGO = "M"
                Else
                    TIPO_PAGO = "E"
                End If
            Else
                TIPO_PAGO = "ET"
            End If
            If CFG_MONVENTA = "S" Then
                TOT = CDbl(NUMERICO(TXT_TOTAL_TARJETA.Text)) + Math.Round((CDbl(NUMERICO(TXT_TOTAL_TARJETA_D.Text)) * CDbl(TXT_TC.Text)), 2) + NUMERICO(Me.TXT_SOLES.Text) + Math.Round(NUMERICO(Me.TXT_DOLAR.Text) * CDbl(TXT_TC.Text), 2)
                If CDbl(LBL_MONTO.Text) < CDbl(NUMERICO(TXT_TOTAL_TARJETA.Text)) + Math.Round((CDbl(NUMERICO(TXT_TOTAL_TARJETA_D.Text)) * CDbl(TXT_TC.Text)), 2) Then
                    MsgBox("Operación no permitida!" & Chr(13) & "El Monto en Tarjetas no puede ser mayor al Total a Pagar", vbExclamation)
                    Exit Sub
                End If
                TOT_TARJETA = Val(Me.TXT_TOTAL_TARJETA.Text)
            Else

                TOT = CDbl(NUMERICO(TXT_TOTAL_TARJETA_D.Text)) + Math.Round((CDbl(NUMERICO(TXT_TOTAL_TARJETA.Text)) / CDbl(TXT_TC.Text)), 2) + NUMERICO(Me.TXT_DOLAR.Text) + Math.Round(NUMERICO(Me.TXT_SOLES.Text) / CDbl(TXT_TC.Text), 2)
                If CDbl(LBL_MONTO.Text) < CDbl(NUMERICO(TXT_TOTAL_TARJETA_D.Text)) + Math.Round((CDbl(NUMERICO(TXT_TOTAL_TARJETA.Text)) / CDbl(TXT_TC.Text)), 2) Then
                    MsgBox("Operación no permitida!" & Chr(13) & "El Monto en Tarjetas no puede ser mayor al Total a Pagar", vbExclamation)
                    Exit Sub
                End If
                TOT_TARJETA = Val(Me.TXT_TOTAL_TARJETA_D.Text)
            End If

            If CDbl(TXT_VUELTO.Text) < 0 Then
                MsgBox("Falta " & " " & GFormatodeNumero(Math.Abs(CDbl(NUMERICO(TXT_VUELTO.Text))), 2) & " para cubrir el Monto total", MsgBoxStyle.Critical)
                If CFG_MONVENTA = "S" Then TXT_SOLES.Focus() Else TXT_DOLAR.Focus()
                Exit Sub
            End If

            If TOT = 0 Then MsgBox("Ingrese Pago", MsgBoxStyle.Information) : Exit Sub
            If Ventas_V2.GRABAR_EFECTIVO(Val(Me.TXT_SOLES.Text), Val(Me.TXT_DOLAR.Text), TOT_TARJETA, Me.TXT_VUELTO.Text, TIPO_PAGO) = 0 Then
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

    Private Sub TXT_TARJETA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TARJETA.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.TXT_MONTO_TARJETA.Focus()
        End If
    End Sub

    Private Sub TXT_TARJETA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TARJETA.TextChanged

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub
End Class