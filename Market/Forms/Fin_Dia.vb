Public Class Fin_Dia
    Dim OBJFINDIA As ClsFinDia

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Fin_Dia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJFINDIA = New ClsFinDia
        Me.TXT_FECHA.Text = GFechaProceso

        Me.TXT_ACTUAL.Text = TURNO
        ''If TURNO = 1 Then
        ''    Me.TXT_NUEVO.Text = 2
        ''Else
        ''    If TURNO = 2 Then
        ''        Me.TXT_NUEVO.Text = 3
        ''    Else
        ''        Me.TXT_NUEVO.Text = 1
        ''    End If

        ''End If
        If TURNO = 1 Then
            Me.TXT_NUEVO.Text = 2 ' 1
        Else
            If CONFIG_TURNO = 3 Then
                If TURNO = 2 Then
                    Me.TXT_NUEVO.Text = 3
                Else
                    Me.TXT_NUEVO.Text = 1
                End If
            Else
                If TURNO = 2 Then
                    Me.TXT_NUEVO.Text = 1
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim VALOR As Integer
            ''VERIFICAR QUE ESTA PC PUEDA HACER FIN DE DIA
            If OBJFINDIA.VERIFICAR_PC = 0 Then MsgBox("Esta PC no puede hacer Fin de Dia", MsgBoxStyle.Information) : Exit Sub
            ''
            If MsgBox("Seguro de realizar fin de dia??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            ''EJECUTAMOS FIN DE DIA
            VALOR = OBJFINDIA.GENERAR_FIN_DIA(CDate(Me.TXT_FECHA.Text), Val(Me.TXT_NUEVO.Text))
            If VALOR = 0 Then MsgBox("Fin de dia realizado con exito", MsgBoxStyle.Information) : Application.Exit() : Exit Sub
            If VALOR = 1 Then MsgBox("Error al Realizar fin de dia", MsgBoxStyle.Information) : Exit Sub
            If VALOR = 2 Then MsgBox("Al menos una de las cajas no ha realizado el Cierre Z", MsgBoxStyle.Information) : Exit Sub
            If VALOR = 3 Then MsgBox("Existen documentos no considerados en el Cierre Z", MsgBoxStyle.Information) : Exit Sub
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class