
Imports System.Drawing.Printing

Public Class Movi_Caja
    Dim OBJCAJA As ClsCaja
    Dim OBJPTOVTA As ClsPtoVta
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Movi_Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SISTEMA_MOVIMI_CAJA = "N" Then
            Me.GroupBox_TIPO.Visible = False
            Me.CHK_TRANSF.Visible = False
            Me.CHK_TRANSF.Checked = True
            Me.OPT_SAL.Checked = True
        Else
            Me.GroupBox_TIPO.Visible = True
            Me.CHK_TRANSF.Visible = True
            Me.CHK_TRANSF.Checked = True
            Me.OPT_SAL.Checked = True
        End If
        Me.Combo_MONEDA.SelectedIndex = 0
        Me.TXT_MONTO.Text = ""
        Me.TXT_MOTIVO.Text = ""
        OBJCAJA = New ClsCaja
        OBJPTOVTA = New ClsPtoVta
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim SW As Integer
            If Val(Me.TXT_MONTO.Text) = 0 Then MsgBox("Ingrese Monto", MsgBoxStyle.Information) : Exit Sub
            SW = OBJCAJA.GRABAR(IIf(Me.OPT_ING.Checked = True, "I", "S"), GFechaProceso, Strings.Left(Me.Combo_MONEDA.Text, 1), GFormatodeNumero(Me.TXT_MONTO.Text, 2), GPTOVTA, Me.TXT_MOTIVO.Text.Trim, TURNO, IIf(Me.OPT_ING.Checked = True, 0, Me.CHK_TRANSF.Checked))
            If SW = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Critical) : Exit Sub
            If SW = 0 Then MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
            If SISTEMA_FELECTRONICA = "N" Then
                IMPRIMIR_CAJA_VENTA(IIf(Me.OPT_ING.Checked, "I", "S"), Me.Combo_MONEDA.Text, Me.TXT_MONTO.Text, TXT_MOTIVO.Text.Trim)
            Else
                ''
                PrintDocument1.PrinterSettings.PrinterName = OBJPTOVTA.BUSCAR_PORTIMP("001")
                Dim ps As PaperSize
                Try
                    ps = PrintDocument1.PrinterSettings.PaperSizes(OBJPTOVTA.BUSCAR_PORTIMP_NRO_IMP("001"))
                    PrintDocument1.DefaultPageSettings.PaperSize = ps
                Catch ex As Exception

                End Try
                ''
                Try
                    PrintDocument1.Print()
                Catch ex As Exception

                End Try


                ''
            End If
            Me.Combo_MONEDA.SelectedIndex = 0
            Me.TXT_MONTO.Text = ""
            Me.TXT_MOTIVO.Text = ""
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Private Sub OPT_ING_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_ING.CheckedChanged
        Me.CHK_TRANSF.Visible = Not OPT_ING.Checked
    End Sub

    Private Sub OPT_SAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_SAL.CheckedChanged
        Me.CHK_TRANSF.Visible = OPT_SAL.Checked
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        GRAFICO = e.Graphics
        IMPRIMIR_CAJA_VENTA_TERMICA(IIf(Me.OPT_ING.Checked, "I", "S"), Me.Combo_MONEDA.Text, Me.TXT_MONTO.Text, TXT_MOTIVO.Text.Trim, "")
    End Sub
End Class