Public Class Menu

    Private Sub Menu_Mant_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Usuarios.Click
        Mant_Usuarios.Show()
    End Sub

    Private Sub MF_Familias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MF_Familias.Click
        Mant_Familias.Show()
    End Sub

    Private Sub MF_Subfamilias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MF_Subfamilias.Click
        Mant_Grupos.Show()
    End Sub

    
    Private Sub Menu_Mant_Medidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Medidas.Click
        Mant_Medidas.Show()
    End Sub

    Private Sub Menu_Mant_Proveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Proveedores.Click
        Mant_Proveedores.Show()
    End Sub

    Private Sub Menu_Mant_Articulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Articulos.Click
        Mant_Articulos.Show()
    End Sub

    Private Sub Menu_Mant_Tprecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Tprecios.Click
        Mant_Tprecio.Show()
    End Sub

    Private Sub Menu_Mant_FPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_FPago.Click
        Mant_FPago.Show()
    End Sub

    Private Sub Menu_Mant_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Clientes.Click
        Mant_Clientes.Show()
    End Sub

    Private Sub Menu_Mant_TMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_TMov.Click
        Mant_TMov.Show()
    End Sub

    Private Sub Menu_Mant_TC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_TC.Click
        Mant_TC.Show()
    End Sub

    Private Sub Menu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Menu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        verificar_permisos()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TOOL_USER.Text = GUSERDS
        Me.TOOL_PC.Text = SystemInformation.ComputerName
        CARGAR_CONFIG()
        'CargarVariablesPtovta()
        If BUSCAR_EXISTE("TIPO_CAMBIO", "FECHA", Format(Date.Now, "dd/MM/yyyy")) = False Then
            Mant_TC.ShowDialog()
        End If
        LIMPIAR_PERMISOS()
        verificar_permisos()
    End Sub
    Private Sub verificar_permisos()
        ' Dim RP As New ADODB.Recordset
        Dim SQL As String
        SQL = "select * from permisos where cod_user='" & GUSERID & "'"
        Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
        'RP.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Dim ODATAREADER As SqlDataReader
        If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
        ODATAREADER = OCOMANDO.ExecuteReader
        While ODATAREADER.Read
            Select Case ODATAREADER("NIVEL1") 'RP.Fields("nivel1").Value
                Case "01"
                    Menu_Mant.Enabled = True
                Case "0101"
                    Menu_Mant_Familias.Enabled = True
                Case "010101"
                    MF_Familias.Enabled = True
                Case "010102"
                    MF_Subfamilias.Enabled = True
                Case "0102"
                    Menu_Mant_Articulos.Enabled = True
                Case "0103"
                    Menu_Mant_Medidas.Enabled = True
                Case "0104"
                    Menu_Mant_Tprecios.Enabled = True
                Case "0105"
                    Menu_Mant_FPago.Enabled = True
                Case "0106"
                    Menu_Mant_TMov.Enabled = True
                Case "0107"
                    Menu_Mant_TC.Enabled = True
                Case "0108"
                    Menu_Mant_Bancos.Enabled = True
                Case "0109"
                    Menu_Mant_Tarjetas.Enabled = True
                Case "0110"
                    Menu_Mant_Cobradores.Enabled = True
                Case "0111"
                    Menu_Mant_Proveedores.Enabled = True
                Case "0112"
                    Menu_Mant_Clientes.Enabled = True
                Case "0113"
                    Menu_Mant_Usuarios.Enabled = True
                Case "0114"
                    Menu_Mant_Planctas.Enabled = True
                Case "0115"
                    Menu_Mant_SubCta.Enabled = True
                Case "02"
                    Menu_Inv.Enabled = True
                Case "0201"
                    Menu_Inv_Ingresos.Enabled = True
                Case "0202"
                    Menu_Inv_Salidas.Enabled = True
                Case "0203"
                    Menu_Inv_Compras.Enabled = True
                    Me.BUTTON_COMPRAS.Enabled = True
                Case "0204"
                    Menu_Inv_Kardex.Enabled = True
                    Me.BUTTON_KARDEX.Enabled = True
                Case "0205"
                    Menu_Inv_KardexV.Enabled = True
                Case "03"
                    Menu_Ventas.Enabled = True
                    Me.BUTTON_VENTAS.Enabled = True
                Case "04"
                    Menu_CtaCte.Enabled = True
                Case "0401"
                    Menu_CtaCte_Cobrar.Enabled = True
                Case "040101"
                    Cta_Cte_Cliente.Enabled = True
                Case "040102"
                    Cta_Cte_Masiva_Cliente.Enabled = True
                Case "0402"
                    Menu_CtaCte_Pagar.Enabled = True
                Case "05"
                    Menu_Utilitarios.Enabled = True
                Case "0501"
                    Menu_Util_Recalculo.Enabled = True
                Case "0502"
                    Menu_Util_Operador.Enabled = True
                Case "0503"
                    Menu_Util_Config.Enabled = True
                Case "0504"
                    Menu_Util_Permisos.Enabled = True
                Case "0505"
                    Me.Menu_Util_Reimpresion.Enabled = True
                Case "050501"
                    Me.Reimpresion_X.Enabled = True
                Case "050502"
                    Me.Reimpresion_Z.Enabled = True
                Case "0506"
                    Me.Menu_Util_Reimp.Enabled = True
                Case "06"
                    Menu_Reportes.Enabled = True
                Case "0601"
                    Menu_Reportes_Inventario.Enabled = True
                Case "060101"
                    ComprasXProveedor.Enabled = True
                Case "060102"
                    RptMovimientos.Enabled = True
                Case "060103"
                    Rpt_KardexValorizado.Enabled = True
                Case "060104"
                    Rpt_Kardex.Enabled = True
                Case "060105"
                    Me.RptReposicion.Enabled = True
                Case "0602"
                    Menu_Reportes_Ventas.Enabled = True
                Case "060201"
                    RegistroDeVentas.Enabled = True
                Case "060202"
                    VentasCredito.Enabled = True
                Case "060203"
                    Me.MoviCaja.Enabled = True
                Case "060204"
                    Me.TipoPago.Enabled = True
                Case "060205"
                    Menu_Reportes_Tarjetas.Enabled = True
                Case "0603"
                    Menu_Reportes_CtaCte.Enabled = True
                Case "060301"
                    CuentasXCobrar.Enabled = True
                Case "060302"
                    Me.CuentasXPagar.Enabled = True
                Case "07"
                    Menu_Caja.Enabled = True
                Case "0701"
                    Menu_Caja_Caja.Enabled = True
                Case "0702"
                    Menu_Rpte_Caja.Enabled = True
                Case "0703"
                    Menu_Caja_Capital.Enabled = True
                Case "1001"
                    ANULAR_VENTAS = True
            End Select

        End While
        ODATAREADER.Close()
        CN_NET.Close()
    End Sub
    Sub LIMPIAR_PERMISOS()
        Menu_Mant.Enabled = False
        Menu_Mant_Familias.Enabled = False
        MF_Familias.Enabled = False
        MF_Subfamilias.Enabled = False
        Menu_Mant_Articulos.Enabled = False
        Menu_Mant_Medidas.Enabled = False
        Menu_Mant_Tprecios.Enabled = False
        Menu_Mant_FPago.Enabled = False
        Menu_Mant_TMov.Enabled = False
        Menu_Mant_TC.Enabled = False
        Menu_Mant_Bancos.Enabled = False
        Menu_Mant_Tarjetas.Enabled = False
        Menu_Mant_Cobradores.Enabled = False
        Menu_Mant_Proveedores.Enabled = False
        Menu_Mant_Clientes.Enabled = False
        Menu_Mant_Usuarios.Enabled = False
        Menu_Inv.Enabled = False
        Menu_Inv_Ingresos.Enabled = False
        Menu_Inv_Salidas.Enabled = False
        Menu_Inv_Compras.Enabled = False
        Menu_Inv_Kardex.Enabled = False
        Menu_Inv_KardexV.Enabled = False
        Menu_Ventas.Enabled = False
        Menu_CtaCte.Enabled = False
        Menu_CtaCte_Cobrar.Enabled = False
        Cta_Cte_Cliente.Enabled = False
        Cta_Cte_Masiva_Cliente.Enabled = False
        Menu_CtaCte_Pagar.Enabled = False
        Menu_Utilitarios.Enabled = False
        Menu_Util_Recalculo.Enabled = False
        Menu_Util_Operador.Enabled = False
        Menu_Util_Config.Enabled = False
        Menu_Util_Permisos.Enabled = False
        Me.BUTTON_VENTAS.Enabled = False
        Me.BUTTON_COMPRAS.Enabled = False
        Me.BUTTON_KARDEX.Enabled = False
        Menu_Reportes.Enabled = False
        Menu_Reportes_Inventario.Enabled = False
        ComprasXProveedor.Enabled = False
        RptMovimientos.Enabled = False
        Rpt_KardexValorizado.Enabled = False
        Rpt_Kardex.Enabled = False
        Menu_Reportes_Ventas.Enabled = False
        RegistroDeVentas.Enabled = False
        VentasCredito.Enabled = False
        Menu_Reportes_CtaCte.Enabled = False
        CuentasXCobrar.Enabled = False
        Me.Menu_Util_Reimpresion.Enabled = False
        Me.Reimpresion_X.Enabled = False
        Me.Reimpresion_Z.Enabled = False
        Me.Menu_Util_Reimp.Enabled = False
        Me.MoviCaja.Enabled = False
        Me.CuentasXPagar.Enabled = False
        Me.TipoPago.Enabled = False
        Me.RptReposicion.Enabled = False
        ANULAR_VENTAS = False
        Menu_Reportes_Tarjetas.Enabled = False

        Menu_Mant_Planctas.Enabled = False
        Menu_Mant_SubCta.Enabled = False

        Menu_Caja.Enabled = False
        Menu_Caja_Caja.Enabled = False

        Menu_Rpte_Caja.Enabled = False
        Menu_Caja_Capital.Enabled = False
    End Sub
    Private Sub Menu_Inv_Compras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Inv_Compras.Click
        Compras.Show()
    End Sub

    Private Sub Menu_Inv_Ingresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Inv_Ingresos.Click
        Movimientos.Tag = "I"
        Movimientos.Show()
    End Sub

    Private Sub Menu_Inv_Salidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Inv_Salidas.Click
        Movimientos.Tag = "S"
        Movimientos.Show()
    End Sub

    Private Sub Menu_Inv_Kardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Inv_Kardex.Click
        Kardex.Tag = "N"
        Kardex.Show()
    End Sub

    Private Sub Menu_Inv_KardexV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Inv_KardexV.Click
        Kardex.Tag = "V"
        Kardex.Show()
    End Sub

    Private Sub Menu_Util_Recalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Util_Recalculo.Click
        Recalc_Stock.Show()
    End Sub

    Private Sub Menu_Util_Operador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Util_Operador.Click
        Mant_PtoVta.Show()
    End Sub

    Private Sub Menu_Mant_Bancos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Bancos.Click
        Mant_Bancos.Show()
    End Sub

    Private Sub Menu_Mant_Tarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Tarjetas.Click
        Mant_Tarjetas.Show()
    End Sub

    Private Sub Menu_Ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Ventas.Click
        Ventas.Show()
    End Sub

    Private Sub Menu_Util_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Util_Config.Click
        Mant_Config.Show()
    End Sub

    Private Sub Cta_Cte_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cta_Cte_Cliente.Click
        Cobranza_Cliente.Show()
    End Sub

    Private Sub Menu_Mant_Cobradores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Cobradores.Click
        Mant_Cobrador.Show()
    End Sub

    Private Sub Cta_Cte_Masiva_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cta_Cte_Masiva_Cliente.Click
        Cobranza_Masiva.Show()
    End Sub

    Private Sub Menu_CtaCte_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_CtaCte_Pagar.Click
        Pago_Proveedor.Show()
    End Sub

    Private Sub BUTTON_VENTAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_VENTAS.Click
        Ventas.Show()
    End Sub

    Private Sub BUTTON_COMPRAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_COMPRAS.Click
        Compras.Show()
    End Sub

    Private Sub BUTTON_KARDEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_KARDEX.Click
        Kardex.Tag = "N"
        Kardex.Show()
    End Sub

    Private Sub Menu_Util_Permisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Util_Permisos.Click
        Permisos_Usuarios.Show()
    End Sub

    Private Sub ComprasXProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasXProveedor.Click
        Rpte_Compras_x_Prov.Show()
    End Sub

    Private Sub Rpt_KardexValorizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rpt_KardexValorizado.Click
        Rpte_Seleccion_Articulo.Tag = "KV"
        Rpte_Seleccion_Articulo.Show()
    End Sub

    Private Sub Rpt_Kardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rpt_Kardex.Click
        Rpte_Seleccion_Articulo.Tag = "K"
        Rpte_Seleccion_Articulo.Show()
    End Sub

    Private Sub RegistroDeVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeVentas.Click
        Rpte_Reg_Ventas.Show()
    End Sub

    Private Sub VentasCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasCredito.Click
        Rpte_Ventas_Credito.Tag = "C"
        Rpte_Ventas_Credito.Text = "Reporte de Ventas al Credito"
        Rpte_Ventas_Credito.Show()
    End Sub

    Private Sub CuentasXCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasXCobrar.Click
        Rpte_Ventas_Credito.Tag = "P"
        Rpte_Ventas_Credito.Text = "Reporte de Cuentas x Cobrar"
        Rpte_Ventas_Credito.Show()
    End Sub

    Private Sub Movimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptMovimientos.Click
        Rpte_Movimientos.Show()
    End Sub

    Private Sub Reimpresion_X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reimpresion_X.Click
        Cierre_X.Tag = "X"
        Cierre_X.picturebox1.Visible = True
        Cierre_X.Show()
    End Sub

    Private Sub Reimpresion_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reimpresion_Z.Click
        Cierre_X.Tag = "Z"
        Cierre_X.picturebox1.Visible = True
        Cierre_X.Show()
    End Sub

    Private Sub Menu_Util_Reimpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Util_Reimpresion.Click

    End Sub

    Private Sub Menu_Util_Reimp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Util_Reimp.Click
        Reimpresion.Show()
    End Sub

    Private Sub MoviCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoviCaja.Click
        Rpt_Rango_Fechas.Show()
    End Sub

    Private Sub CuentasXPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasXPagar.Click
        Rpte_Cuentas_Pagar.Show()
    End Sub

    Private Sub TipoPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoPago.Click
        Rpt_Rango_Fechas.Tag = "TP"
        Rpt_Rango_Fechas.Show()
    End Sub

    Private Sub RptReposicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptReposicion.Click
        Rpte_Reposicion_Stock.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Menu_Reportes_Tarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Reportes_Tarjetas.Click
        Rpt_Rango_Fechas.Tag = "TJ"
        Rpt_Rango_Fechas.Show()
    End Sub

    Private Sub Menu_Mant_Planctas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_Planctas.Click
        Mant_Plancta.Show()
    End Sub

    Private Sub Menu_Mant_SubCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Mant_SubCta.Click
        Mant_SubCuentas.Show()
    End Sub

    Private Sub Menu_Caja_Caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Caja_Caja.Click
        Dim FORM As New CAJA_OFICINA
        FORM.Show()
    End Sub

    Private Sub Menu_Rpte_Caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Rpte_Caja.Click
        Rpte_Caja.Show()
    End Sub

    Private Sub Menu_Caja_Capital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Caja_Capital.Click
        Capital.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu_V2.Show()
    End Sub
End Class
