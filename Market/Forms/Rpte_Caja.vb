Public Class Rpte_Caja
    Dim OBJOFIC As ClsCajaOfic
    Dim OBJCUENTAS As ClsPlanCta
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Rpte_Ventas_Credito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCUENTAS = New ClsPlanCta
        OBJOFIC = New ClsCajaOfic
        OBJCUENTAS.LLENAR_CUENTAS(Me.List_clie_orig)
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
        OBJCUENTAS.LLENAR_CUENTAS(Me.List_clie_destino)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.List_clie_destino.Items.Clear()
        OBJCUENTAS.LLENAR_CUENTAS(Me.List_clie_orig)
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
            Dim CAD2 As String = ""
            Dim CTA As String = ""
            Dim CTA2 As String = ""
            If Me.List_clie_destino.Items.Count = 0 And Me.CheckBox1.Checked = False Then MsgBox("Seleccione al menos una Cuenta", MsgBoxStyle.Critical) : Exit Sub
            For F = 0 To Me.List_clie_destino.Items.Count - 1
                Me.List_clie_destino.SelectedIndex = F
                CTA = CTA + "'" + Trim(Strings.Right(Me.List_clie_destino.Text.Trim, 4)) + "'" + ","
                ''
                If Trim(Strings.Right(Me.List_clie_destino.Text.Trim, 4)) = "1000" Then
                    CTA2 = "S"
                End If
            Next
            If Me.CheckBox1.Checked = False Then
                CAD = CAD + " AND CAJA_OFICINA.COD_PLANCTA IN(" + Strings.Left(CTA, Strings.Len(CTA.Trim) - 1) + ")"
                If CTA2 <> "S" Then
                    CAD2 = CAD2 + " AND ID_CAJA=0"
                End If
            End If


            With Impresion
                .FORM = "Rpte_Caja"
                .SALDO_S = OBJOFIC.IAM_SALDO_INI_MON(Format(Me.DT_INI.Value, "yyyyMMdd"), "S")
                .SALDO_D = OBJOFIC.IAM_SALDO_INI_MON(Format(Me.DT_INI.Value, "yyyyMMdd"), "D")
                Select Case True
                    Case Me.OPT_INGRESO.Checked
                        CAD = CAD + " AND TIPO_MCAJA='I'"
                        CAD2 = CAD2 + " AND TIPOMOVI='S'"
                    Case Me.OPT_SALIDA.Checked
                        CAD = CAD + " AND TIPO_MCAJA='S'"
                        CAD2 = CAD2 + " AND TIPOMOVI='I'"
                End Select
                ''.CAMPO = IIf(Me.OPT_SOLES.Checked = True, "S", "D")
                .CADENA = CAD
                .CADENA2 = CAD2
                '.TIPO = IIf(Me.CheckBox1.Checked = True, 1, 0)
                .FI = Format(Me.DT_INI.Value, "yyyyMMdd")
                .FF = Format(Me.DT_FIN.Value, "yyyyMMdd")
                .TITULO = "Del : " & Format(Me.DT_INI.Value, "dd/MM/yyyy") & " Al  " & Format(Me.DT_FIN.Value, "dd/MM/yyyy")
                .Show()

            End With

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FIN.ValueChanged

    End Sub
End Class