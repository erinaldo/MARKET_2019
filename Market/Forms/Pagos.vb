Public Class Pagos
    Dim OBJBANCO As ClsBanco
    Dim OBJCOMPRA As ClsCompra
    Dim OBJTC As ClsTC

    Dim COL_ID As Integer = 0
    Dim COL_FECHA As Integer = 1
    Dim COL_TPAGO As Integer = 2
    Dim COL_REF As Integer = 3
    Dim COL_MON As Integer = 4
    Dim COL_TC As Integer = 5
    Dim COL_MONTO As Integer = 6
    Dim COL_BANCO As Integer = 7
    Dim COL_CTA_BANC As Integer = 8
    Dim COL_OBSERV As Integer = 9
    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJBANCO = New ClsBanco
        OBJCOMPRA = New ClsCompra
        OBJTC = New ClsTC

        Label3.Visible = False
        LLENAR_COMBO(Me.Combo_FPAGO, "LISTAR_TIPO_PAGO 0,'',''", "DESCRIPCION", "CODIGO", CAD_CON)
        LLENAR_COMBO(Me.Combo_BANCO, "EXEC usp_BANCOSSelProc 1,0,0", "ABANDESC", "ABANCODI", CAD_CON)
        Me.Combo_BANCO.SelectedIndex = 0
        Me.Combo_FPAGO.SelectedIndex = 0
        Me.DT_FECHA.Value = Date.Now

        ''OBJCP.LLENAR_DETALLE_CTAS_PAGAR(Me.Tag, Me.DBLISTAR)
        LLENAR_GRID_()
        BUSCAR_TC()
    End Sub
    Sub LLENAR_GRID_()
        LLENAR_GRID(DBLISTAR, "EXEC LISTAR_DETALLE_CTAS_PAGAR " & Me.Tag & "", CAD_CON)
    End Sub
    Sub BUSCAR_TC()
        Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT_FECHA.Value, "C")
    End Sub

    Private Sub TXT_TC_TextChanged(sender As Object, e As EventArgs) Handles TXT_TC.TextChanged

    End Sub

    Private Sub TXT_TC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TC.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_MONTO_TextChanged(sender As Object, e As EventArgs) Handles TXT_MONTO.TextChanged
        Try
            Dim MONTO_CAMBIO As Double = 0
            If Val(Me.TXT_TC.Text) = 0 And Val(Me.TXT_MONTO.Text) <> 0 Then MsgBox("Ingrese Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub
            If Me.OPT_SOLES.Checked = True Then
                MONTO_CAMBIO = Format(Val(Me.TXT_MONTO.Text) / Val(Me.TXT_TC.Text), "###,###,###.00")
                If Me.GroupBox3.Tag = "S" Then
                    Me.TXT_SALDO.Text = Format(Val(Replace(Me.TXT_TOTAL.Text, ",", "")) - Val(Me.TXT_MONTO.Text), "###,###,###.00")
                Else
                    Me.TXT_SALDO.Text = Format(Val(Replace(Me.TXT_TOTAL.Text, ",", "")) - MONTO_CAMBIO, "###,###,###.00")
                End If
            Else
                MONTO_CAMBIO = Format(Val(Me.TXT_MONTO.Text) * Val(Me.TXT_TC.Text), "###,###,###.00")
                If Me.GroupBox3.Tag = "S" Then
                    Me.TXT_SALDO.Text = Format(Val(Replace(Me.TXT_TOTAL.Text, ",", "")) - MONTO_CAMBIO, "###,###,###.00")
                Else
                    Me.TXT_SALDO.Text = Format(Val(Replace(Me.TXT_TOTAL.Text, ",", "")) - Val(Me.TXT_MONTO.Text), "###,###,###.00")
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub TXT_MONTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONTO.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub Pagos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LLENAR_GRID_()
    End Sub

    Private Sub Pagos_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        BUSCAR_TC()
    End Sub

    Private Sub OPT_DOLARES_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_DOLARES.CheckedChanged
        TXT_MONTO_TextChanged(TXT_MONTO, EventArgs.Empty)
    End Sub

    Private Sub OPT_SOLES_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_SOLES.CheckedChanged
        TXT_MONTO_TextChanged(TXT_MONTO, EventArgs.Empty)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim intvalor As Integer
            Dim MON_BANCO As String = ""
            Dim MON_PAGO As String
            Dim MONTO_PAGO As Double = Val(Me.TXT_MONTO.Text)
            If Val(Me.TXT_MONTO.Text) = 0 Then MsgBox("Ingrese Monto", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_TC.Text) = 0 Then MsgBox("Ingrese Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub

            ''If Me.Combo_BANCO.Visible = True Then
            ''    If MON_BANCO = "S" Then
            ''        MON_PAGO = "S"
            ''        MONTO_PAGO = Val(OBJFUNC.COMAS(Me.TXT_MONTO.Text))
            ''    Else
            ''        MON_PAGO = "D"
            ''        MONTO_PAGO = Val(OBJFUNC.COMAS(Me.TXT_MONTO.Text))
            ''    End If
            ''Else
            ''    MON_PAGO = IIf(Me.OPT_SOLES.Checked = True, "S", "D")
            ''    MONTO_PAGO = Val(OBJFUNC.COMAS(Me.TXT_MONTO.Text))
            ''End If
            ''
            MON_PAGO = IIf(Me.OPT_SOLES.Checked = True, "S", "D")
            'If Me.GroupBox3.Tag = MONTO_PAGO Then
            MONTO_PAGO = Val(COMAS(Me.TXT_MONTO.Text))
            'Else
            'If MONTO_PAGO = "S" Then

            'End If
            'End If
            ''
            OBJCOMPRA.ID = Me.Tag
            'OBJCOMPRA.Usuario = GUSERID
            intvalor = OBJCOMPRA.MANT_PAGO(Me.Tag, Me.DT_FECHA.Value, Me.Combo_FPAGO.SelectedValue, MON_PAGO, Me.TXT_TC.Text, MONTO_PAGO, Me.Combo_BANCO.SelectedValue, Me.TXT_REFERENCIA.Text.Trim, Me.TXT_OBS.Text.Trim, Me.Combo_CTA_BANCARIA.SelectedValue, "N", CN_NET)
            If intvalor = 0 Then
                MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
                LLENAR_GRID_()
                Me.TXT_TOTAL.Text = Me.TXT_SALDO.Text 'Me.TXT_TOTAL.Text - Me.TXT_MONTO.Text
                Me.TXT_MONTO.Clear()
                Me.TXT_OBS.Clear()
                Me.TXT_REFERENCIA.Clear()
                ''
                Me.OPT_DOLARES.Enabled = True
                Me.OPT_SOLES.Enabled = True
                ''
            Else
                MsgBox("Error al Grabar", MsgBoxStyle.Information) : Exit Sub
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim INTVALOR As Integer
            Dim TOT As Double
            Dim TC As Double
            Dim MON As String
            If Me.DBLISTAR.Row < 1 Then Exit Sub
            If MsgBox("Seguro de Eliminar??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            TOT = Me.DBLISTAR.Item(DBLISTAR.Row, COL_MONTO)
            TC = Me.DBLISTAR.Item(DBLISTAR.Row, COL_TC)
            MON = Me.DBLISTAR.Item(DBLISTAR.Row, COL_MON)
            OBJCOMPRA.ID = Me.Tag
            INTVALOR = OBJCOMPRA.MANT_PAGO(DBLISTAR.Item(DBLISTAR.Row, COL_ID), Me.DT_FECHA.Value, 0, "", 0, 0, 0, "", "", Me.Combo_CTA_BANCARIA.SelectedValue, "A", CN_NET)
            If INTVALOR = 3 Then MsgBox("Este Pago de encuentra en Contabilidad, no se podra Eliminar") : Exit Sub
            If INTVALOR = 0 Then
                MsgBox("Eliminado Correctamente", MsgBoxStyle.Exclamation)
                LLENAR_GRID_()
                If Me.GroupBox3.Tag = MON Then
                    Me.TXT_TOTAL.Text = Me.TXT_SALDO.Text + TOT 'Me.TXT_TOTAL.Text - Me.TXT_MONTO.Text
                    Me.TXT_SALDO.Text = Me.TXT_TOTAL.Text
                Else
                    If MON = "S" Then
                        Me.TXT_TOTAL.Text = Math.Round(Me.TXT_SALDO.Text + (TOT / TC), 2)
                    Else
                        Me.TXT_TOTAL.Text = Math.Round(Me.TXT_SALDO.Text + (TOT * TC), 2)
                    End If
                    Me.TXT_SALDO.Text = Me.TXT_TOTAL.Text
                End If
                Me.TXT_MONTO.Clear()
                Me.TXT_OBS.Clear()
                Me.TXT_REFERENCIA.Clear()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Combo_FPAGO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_FPAGO.SelectedIndexChanged
        Dim OBJTPAGO As New ClsTPago
        With OBJTPAGO
            .Codigo = Me.Combo_FPAGO.SelectedValue
            .BUSCAR(CN_NET)
            Me.Combo_BANCO.Visible = .PedirBanco
            Me.Label3.Visible = .PedirBanco
            Me.Combo_CTA_BANCARIA.Visible = .PedirBanco
            Me.Label5.Visible = .PedirBanco
            Me.OPT_DOLARES.Enabled = True
            Me.OPT_SOLES.Enabled = True
        End With
    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub Combo_BANCO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_BANCO.SelectedIndexChanged
        LLENAR_COMBO(Me.Combo_CTA_BANCARIA, "EXEC usp_CtaBancSelProc 0,'" & Combo_BANCO.SelectedValue & "',0,0", "ACTADESC", "ACTACODI", CAD_CON)
    End Sub

    Private Sub Combo_CTA_BANCARIA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_CTA_BANCARIA.SelectedIndexChanged
        Dim MON As String = BUSCAR_CAMPO("CTABANC", "ACTAMONE", "ACTACODI", Me.Combo_CTA_BANCARIA.SelectedValue, CN_NET)
        Me.OPT_DOLARES.Enabled = False
        Me.OPT_SOLES.Enabled = False
        If MON = "S" Then Me.OPT_SOLES.Checked = True Else Me.OPT_DOLARES.Checked = True
    End Sub
End Class