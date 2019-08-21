Public Class Consultar_Comite_Detalle
    Dim COL_D_RUBRO As Integer = 0
    Dim COL_D_DESCRIPCION As Integer = 1
    Dim COL_D_MONTO As Integer = 2
    Dim COL_D_ESTIMADO As Integer = 3

    Dim COL_R_DESCRIPCION As Integer = 0
    Dim COL_R_MONTO As Integer = 1

    Dim COL_CANT_FECHA As Integer = 0
    Dim COL_CANT_DIA As Integer = 1
    Dim COL_CANT_GL As Integer = 2
    Dim COL_CANT_KG As Integer = 3

    Dim OBJCOMITE As ClsComiteDetalle

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_ACTUALIZAR.Click
        Try
            OBJCOMITE = New ClsComiteDetalle


            Dim FIL As Integer
            Dim TOT_PAGO As Double = 0
            Dim TOT_ESTIMADO As Double = 0
            LLENAR_GRID(C1_DETALLE_COMITE, "EXEC CONSULTAR_COMITE_DETALLE '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "','" & IIf(Me.OPT_DETALLE.Checked = True, "D", "R") & "'", CAD_CON)
            If Me.OPT_DETALLE.Checked Then
                Me.C1_DETALLE_COMITE.Cols(COL_D_MONTO).Format = "###,###,###.00"
                Me.C1_DETALLE_COMITE.Cols(COL_D_ESTIMADO).Format = "###,###,###.00"
            Else
                Me.C1_DETALLE_COMITE.Cols(COL_R_MONTO).Format = "###,###,###.00"
            End If
            ''TOTALES
            For FIL = 1 To C1_DETALLE_COMITE.Rows.Count - 1
                If Me.OPT_DETALLE.Checked Then
                    TOT_PAGO = TOT_PAGO + NULO(C1_DETALLE_COMITE.Item(FIL, COL_D_MONTO), "N")
                    TOT_ESTIMADO = TOT_ESTIMADO + NULO(C1_DETALLE_COMITE.Item(FIL, COL_D_ESTIMADO), "N")
                Else
                    TOT_PAGO = TOT_PAGO + NULO(C1_DETALLE_COMITE.Item(FIL, COL_R_MONTO), "N")
                End If
            Next
            Me.TXT_TOT_PAGO_VARIOS.Text = FORMAT_DECIMALES(TOT_PAGO, 2)
            Me.TXT_ESTIMADO.Text = FORMAT_DECIMALES(TOT_ESTIMADO, 2)

            Button1_Click_1(Button1, Nothing)

            CALCULAR_DIA()

            AUMENTO_PAGO_CAPITAL()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub AUMENTO_PAGO_CAPITAL()
        With OBJCOMITE
            .BUSCAR_AUMENTO_PAGO_CAPITAL(Format(Me.DT_INI.Value, "yyyyMMdd"), Format(DT_FIN.Value, "yyyyMMdd"))
            Me.TXT_AUMENTO_CAPITAL.Text = FORMAT_DECIMALES(.Aumento_Capital, 2)
            Me.TXT_PAGO_CAPITAL.Text = FORMAT_DECIMALES(.Pago_Capital, 2)
            Me.TXT_TOTAL_AUM_PAG.Text = FORMAT_DECIMALES(.Aumento_Capital - .Pago_Capital, 2)
        End With
    End Sub
    Sub CALCULAR_DIA()

        LLENAR_GRID(C1_CANT, "EXEC CONSULTAR_COMITE_CANT '" & Format(DT_INI.Value, "yyyyMMdd") & "','" & Format(DT_FIN.Value, "yyyyMMdd") & "'", CAD_CON)
        C1_CANT.Cols(COL_CANT_DIA).Visible = False
        C1_CANT.Cols(COL_CANT_GL).Format = "###,###,###.00"
        C1_CANT.Cols(COL_CANT_KG).Format = "###,###,###.00"

        ''TOT
        Dim FIL As Integer
        Dim TOT_GL As Double = 0
        Dim TOT_KG As Double = 0
        For FIL = 1 To C1_CANT.Rows.Count - 1
            TOT_GL = TOT_GL + C1_CANT.Item(FIL, COL_CANT_GL)
            TOT_KG = TOT_KG + C1_CANT.Item(FIL, COL_CANT_KG)
        Next
        Me.TXT_VEND_GL.Text = FORMAT_DECIMALES(TOT_GL, 2)
        Me.TXT_VEND_KG.Text = FORMAT_DECIMALES(TOT_KG, 2)

        If Me.OPT_GALONES.Checked Then
            C1_CANT.Cols(COL_CANT_GL).Visible = True
            C1_CANT.Cols(COL_CANT_KG).Visible = False
            Me.TXT_VENTAS_TOT.Text = FORMAT_DECIMALES(TOT_GL, 2)
        Else
            C1_CANT.Cols(COL_CANT_GL).Visible = False
            C1_CANT.Cols(COL_CANT_KG).Visible = True
            Me.TXT_VENTAS_TOT.Text = FORMAT_DECIMALES(TOT_KG, 2)
        End If
        ''
        Me.TXT_VENTAS_PROM.Text = FORMAT_DECIMALES(Val(COMAS(Me.TXT_VENTAS_TOT.Text)) / Val(Me.TXT_VENTAS_DIAS.Text), 2)
        Me.TXT_RESULTADO_GANANCIA_BRUTO.Text = FORMAT_DECIMALES(Val(COMAS(Me.TXT_BRUTO.Text)) / Val(COMAS(Me.TXT_VENTAS_TOT.Text)), 2)
        Me.TXT_RESULTADO_GENERADO_DIA_BRUTO.Text = FORMAT_DECIMALES(Val(COMAS(Me.TXT_BRUTO.Text)) / Val(Me.TXT_VENTAS_DIAS.Text), 2)
        Me.TXT_RESULTADO_COSTO_GALON.Text = FORMAT_DECIMALES(Val(COMAS(Me.TXT_EMPRESA_1.Text)) / Val(COMAS(Me.TXT_VENTAS_TOT.Text)), 2)
    End Sub
    Private Sub OPT_DETALLE_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_DETALLE.CheckedChanged
        Button1_Click(Button_ACTUALIZAR, Nothing)
    End Sub

    Private Sub Consultar_Comite_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCOMITE = New ClsComiteDetalle

        Dim AÑO As String = Date.Now.Year
        Me.DT_INI.Value = "01/" + Format(Date.Now.Month, "00") + "/" + AÑO
        Me.DT_FIN.Value = UltimoDiaMes(Date.Now)

        Me.TXT_VENTAS_DIAS.Text = OBJCOMITE.BUSCAR_COMITE_DIAS()
    End Sub

    Private Sub OPT_RUBRO_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_RUBRO.CheckedChanged
        Button1_Click(Button_ACTUALIZAR, Nothing)
    End Sub

    Private Sub TXT_CAP_INI_TextChanged(sender As Object, e As EventArgs) Handles TXT_CAP_INI.TextChanged
        CALCULAR()
    End Sub
    Sub CALCULAR()
        Me.TXT_CAP_TOT.Text = FORMAT_DECIMALES(Val(Me.TXT_CAP_FIN.Text) - Val(Me.TXT_CAP_INI.Text), 2)
    End Sub

    Private Sub TXT_CAP_FIN_TextChanged(sender As Object, e As EventArgs) Handles TXT_CAP_FIN.TextChanged
        CALCULAR()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TXT_EMPRESA_1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim PAGOS_VARIOS As Double = Double.Parse(Me.TXT_TOT_PAGO_VARIOS.Text.ToString)
            Dim CAPITA_TOTAL As Double = Double.Parse(Val(Me.TXT_CAP_TOT.Text.ToString))
            Dim BRUTO As Double = CAPITA_TOTAL + PAGOS_VARIOS
            Me.TXT_BRUTO.Text = FORMAT_DECIMALES(BRUTO, 2)
            ''
            With OBJCOMITE
                .BUSCAR_TOT_GENERADO_COMITE_DETALLE(Format(Me.DT_INI.Value, "yyyyMMdd"), Format(DT_FIN.Value, "yyyyMMdd"), Double.Parse(Me.TXT_BRUTO.Text))

                Me.TXT_EMPRESA_1.Text = FORMAT_DECIMALES(.Comite_Empresa, 2)
                TXT_EMPRESA_2.Text = FORMAT_DECIMALES(.Comite_Empresa1, 2)
                TXT_FINANCIEROS_1.Text = FORMAT_DECIMALES(.Comite_Financiero, 2)
                TXT_FINANCIEROS_2.Text = FORMAT_DECIMALES(.Comite_Financiero1, 2)
                TXT_EXTRAS_1.Text = FORMAT_DECIMALES(.Comite_Extra, 2)
                TXT_EXTRAS_2.Text = FORMAT_DECIMALES(.Comite_Extra1, 2)
                TXT_PERSONAL_1.Text = FORMAT_DECIMALES(.Comite_Personal, 2)
                TXT_PERSONAL_2.Text = FORMAT_DECIMALES(.Comite_Personal1, 2)
                TXT_CAPITAL_1.Text = FORMAT_DECIMALES(.Comite_Capital, 2)
                TXT_CAPITAL_2.Text = FORMAT_DECIMALES(.Comite_Capital1, 2)
            End With
            CALCULAR_DIA()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DT_INI_ValueChanged(sender As Object, e As EventArgs) Handles DT_INI.ValueChanged
        Button1_Click(Button_ACTUALIZAR, Nothing)
    End Sub

    Private Sub DT_FIN_ValueChanged(sender As Object, e As EventArgs) Handles DT_FIN.ValueChanged
        Button1_Click(Button_ACTUALIZAR, Nothing)
    End Sub

    Private Sub OPT_GALONES_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_GALONES.CheckedChanged
        CALCULAR_DIA()
    End Sub

    Private Sub OPT_KILOS_CheckedChanged(sender As Object, e As EventArgs) Handles OPT_LITROS.CheckedChanged
        CALCULAR_DIA()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Button1_Click(Button_ACTUALIZAR, Nothing)

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_DETALLE_COMITE_Click(sender As Object, e As EventArgs) Handles C1_DETALLE_COMITE.Click

    End Sub

    Private Sub C1_DETALLE_COMITE_DoubleClick(sender As Object, e As EventArgs) Handles C1_DETALLE_COMITE.DoubleClick
        Try
            With Ver_Detalle_Comite
                .FI = Format(DT_INI.Value, "yyyyMMdd")
                .FF = Format(DT_FIN.Value, "yyyyMMdd")
                .TIPO = IIf(Me.OPT_DETALLE.Checked, "D", "R")
                If Me.OPT_DETALLE.Checked Then
                    .DESC = C1_DETALLE_COMITE.Item(C1_DETALLE_COMITE.Row, COL_D_DESCRIPCION)
                Else
                    .DESC = C1_DETALLE_COMITE.Item(C1_DETALLE_COMITE.Row, COL_R_DESCRIPCION)
                End If
                .VER_DETALLE()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class