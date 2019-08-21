Public Class Capital

    Private Sub DT_FECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_FECHA.ValueChanged
        GENERAR_CAPITAL()
    End Sub
    Sub GENERAR_CAPITAL()
        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "CONSULTAR_CAPITAL"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@FECHA_CAPITAL", SqlDbType.Char, 8)
        CMN.Parameters("@FECHA_CAPITAL").Value = Format(Me.DT_FECHA.Value, "yyyyMMdd")
        CMN.Parameters.Add("@CAJA", SqlDbType.Float)
        CMN.Parameters("@CAJA").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@XCOBRAR", SqlDbType.Float)
        CMN.Parameters("@XCOBRAR").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@XPAGAR", SqlDbType.Float)
        CMN.Parameters("@XPAGAR").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@INV_VAL", SqlDbType.Float)
        CMN.Parameters("@INV_VAL").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@BANCOS", SqlDbType.Float)
        CMN.Parameters("@BANCOS").Direction = ParameterDirection.Output
        CMN.Parameters.Add("@VENTA_PCOMPRA", SqlDbType.Float)
        CMN.Parameters("@VENTA_PCOMPRA").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        Me.TXT_BANCOS.Text = Format(CMN.Parameters("@BANCOS").Value, "###,###,###.00")
        Me.TXT_CAJAS.Text = Format(CMN.Parameters("@CAJA").Value, "###,###,###.00")
        Me.TXT_XCOBRAR.Text = Format(CMN.Parameters("@XCOBRAR").Value, "###,###,###.00")
        Me.TXT_XPAGAR.Text = Format(CMN.Parameters("@XPAGAR").Value, "###,###,###.00")
        Me.TXT_VALORIZADO.Text = Format(CMN.Parameters("@INV_VAL").Value, "###,###,###.00")
        Me.TXT_VTA_PCOMPRA.Text = Format(CMN.Parameters("@VENTA_PCOMPRA").Value, "###,###,###.00")

        Me.TXT_TOTAL.Text = Format(CMN.Parameters("@BANCOS").Value + CMN.Parameters("@CAJA").Value + CMN.Parameters("@XCOBRAR").Value - CMN.Parameters("@XPAGAR").Value + CMN.Parameters("@INV_VAL").Value + CMN.Parameters("@VENTA_PCOMPRA").Value, "###,###,###.00")

        CNN.Close()


    End Sub


    Private Sub Capital_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DT_FECHA.Value = Date.Now
    End Sub
End Class