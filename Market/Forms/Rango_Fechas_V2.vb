Public Class Rango_Fechas_V2
    Private Sub Rango_Fechas_V2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_INI.Value = Date.Now
        DT_FIN.Value = Date.Now
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case Me.Tag
            Case "LIQ"
                LIQUIDACIONES()

        End Select
    End Sub
    Sub LIQUIDACIONES()
        Try
            Dim TITULO As String = "Del : " & Format(DT_INI.Value, "dd/MM/yyyy") & " Al : " & Format(DT_FIN.Value, "dd/MM/yyyy")
            Dim reporte As New Reportes
            Dim REPO As CrystalDecisions.CrystalReports.Engine.ReportDocument
            REPO = New Rpt_Liquidaciones

            Dim datos As New Dts_Liquidaciones
            Dim DA As SqlClient.SqlDataAdapter
            DA = New SqlClient.SqlDataAdapter("IAM_RPT_LIQ_TURNO", CAD_CON)
            DA.SelectCommand.CommandTimeout = 0
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.SelectCommand.Parameters.Add("@FI", SqlDbType.Char, 8)
            DA.SelectCommand.Parameters("@FI").Value = Format(DT_INI.Value, "yyyyMMdd")
            DA.SelectCommand.Parameters.Add("@FF", SqlDbType.Char, 8)
            DA.SelectCommand.Parameters("@FF").Value = Format(DT_FIN.Value, "yyyyMMdd")
            DA.Fill(datos.DataTable_Liq)
            If datos.DataTable_Liq.Rows.Count = 0 Then
                MsgBox("No hay Datos", MsgBoxStyle.Information) : Exit Sub
            End If
            ''AGREGAMOS GASTOS
            DA = New SqlClient.SqlDataAdapter("IAM_RPT_GASTOS", CAD_CON)
            DA.SelectCommand.CommandTimeout = 0
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.SelectCommand.Parameters.Add("@FI", SqlDbType.Char, 8)
            DA.SelectCommand.Parameters("@FI").Value = Format(DT_INI.Value, "yyyyMMdd")
            DA.SelectCommand.Parameters.Add("@FF", SqlDbType.Char, 8)
            DA.SelectCommand.Parameters("@FF").Value = Format(DT_FIN.Value, "yyyyMMdd")
            DA.Fill(datos.DataTable_Gastos)
            REPO.SetDataSource(datos)

            REPO.Subreports(0).SetDataSource(datos)
            'REPO.Subreports(1).SetDataSource(datos)
            'REPO.Subreports(2).SetDataSource(datos)
            'REPO.Subreports(3).SetDataSource(datos)
            'REPO.Subreports(4).SetDataSource(datos)
            'REPO.Subreports(5).SetDataSource(datos)
            'REPO.Subreports(6).SetDataSource(datos)
            'End If
            REPO.DataDefinition.FormulaFields("FROMFECHA").Text = "'" & TITULO & "'"
            reporte.CRV.ReportSource = REPO
            reporte.Show()


        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class