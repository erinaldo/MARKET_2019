Public Class Menu_V2
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Menu_V2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TOOL_USER.Text = GUSERDS
        Me.TOOL_PC.Text = SystemInformation.ComputerName
        CARGAR_CONFIG()
        'CargarVariablesPtovta()
        If BUSCAR_EXISTE("TIPO_CAMBIO", "FECHA", Format(Date.Now, "dd/MM/yyyy")) = False Then
            Mant_TC.ShowDialog()
        End If
        ''**MOSTRAR_ACTIVOS()
        LIMPIAR_PERMISOS()
        verificar_permisos()
    End Sub

    Private Sub Menu_V2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LIMPIAR_PERMISOS()
        verificar_permisos()
    End Sub
    Sub LIMPIAR_PERMISOS()
        C1OutPage_Mantenimiento.Enabled = False
        C1Button_Mant_Familias.Enabled = False
        C1Button_Mant_Articulos.Enabled = False
        C1Button_Mant_Medidas.Enabled = False
        C1Button_Mant_Tipo_Precio.Enabled = False
        C1Button_Mant_Forma_Pago.Enabled = False
        C1Button_Mant_Tipos_Movimiento.Enabled = False
        C1Button_Mant_TCambio.Enabled = False
        C1Button_Mant_Bancos.Enabled = False
        C1Button_Mant_Tarjetas.Enabled = False
        C1Button_Mant_Cobradores.Enabled = False
        C1Button_Mant_Proveedores.Enabled = False
        C1Button_Mant_Clientes.Enabled = False
        C1Button_Mant_Usuarios.Enabled = False
        C1Button_Mant_Plan_Cta.Enabled = False
        C1Button_Mant_SubCta.Enabled = False
        C1Button_ALMACENES.Enabled = False
        C1Button_CTA_BANCARIA.Enabled = False
        C1Button_TIPO_PAGO.Enabled = False
        C1Button_CONCEPTOS.Enabled = False
        C1Button_OTRO.Enabled = False
        C1Button_DETALLE_COMITE.Enabled = False
        C1Button_RUBROS.Enabled = False

        C1OutPage_Inventario.Enabled = False
        C1Button_Inv_Ingresos.Enabled = False
        C1Button_Inv_Salidas.Enabled = False
        C1Button_Inv_Compras.Enabled = False
        C1Button_Inv_Kardex.Enabled = False
        C1Button_Inv_Kardex_Val.Enabled = False
        C1Button_Inv_Inventario.Enabled = False
        C1Button_Inv_Ajustes.Enabled = False

        C1OutPage_Caja.Enabled = False
        C1Button_Caja_Caja.Enabled = False
        C1Button_Caja_Reporte_Caja.Enabled = False
        C1Button_Caja_Capital.Enabled = False
        C1Button_BANCOS.Enabled = False
        C1Button_ComiteDetalle.Enabled = False

        C1OutPage_Ventas.Enabled = False
        C1Button_Ventas_Contingencia.Enabled = False
        C1_Ventas_Ventas.Enabled = False
        C1_Consultar_Ventas.Enabled = False
        C1Button_Ventas_Contingencia.Enabled = False

        C1OutPage_Ctas_Ctes.Enabled = False
        C1Button_CtaCte_Cobranza_Cliente.Enabled = False
        C1Button_CtaCte_Cobranza_Masiva_Cliente.Enabled = False
        C1Button_CtaCte_Ctas_Pagar.Enabled = False
        C1Button_Compras_Pagos.Enabled = False

        C1OutPage_Reportes.Enabled = False
        C1Button_Rpt_Compras_Prov.Enabled = False
        C1Button_Rpt_Movimientos.Enabled = False
        C1Button_Rpt_Kardex_Val.Enabled = False
        C1Button_Rpt_Kardex.Enabled = False
        C1Button_Rpt_Reposicion.Enabled = False
        C1Button_Rpt_Ventas.Enabled = False
        C1Button_Rpt_Vtas_Credito.Enabled = False
        C1Button_Rpt_Mov_Caja.Enabled = False
        C1Button_Rpt_Tipo_Pagos.Enabled = False
        C1Button_Rpt_Tarjetas.Enabled = False
        C1Button_Rpt_Ctas_Cobrar.Enabled = False
        C1Button_Rpt_Ctas_Pagar.Enabled = False
        C1Button_Rpte_Utilidad.Enabled = False
        C1Button_Rpt_Stock_Valorizado.Enabled = False
        C1Button_Rpt_Liq.Enabled = False

        C1OutPage_Utilitarios.Enabled = False
        C1Button_Util_Recalcular_Stock.Enabled = False
        C1Button_Util_Config_Operador.Enabled = False
        C1Button_Util_Config_Venta.Enabled = False
        C1Button_Util_X.Enabled = False
        C1Button_Util_Z.Enabled = False
        C1Button_Util_Permisos_Usuario.Enabled = False
        C1Button_Util_Reimpresion_Bol_Fact.Enabled = False

        C1Button_CUADRO_REPORTE.Enabled = False
    End Sub

    Private Sub ToolStrip_FAMILIA_Click(sender As Object, e As EventArgs) Handles ToolStrip_FAMILIA.Click
        If BUSCAR_PERMISO("010101") = False Then MsgBox("Usted no tiene permiso para usar esta Opcion", MsgBoxStyle.Information) : Exit Sub
        Mant_Familias.Show()
    End Sub

    Private Sub ToolStrip_SUBFAMILIA_Click(sender As Object, e As EventArgs) Handles ToolStrip_SUBFAMILIA.Click
        If BUSCAR_PERMISO("010102") = False Then MsgBox("Usted no tiene permiso para usar esta Opcion", MsgBoxStyle.Information) : Exit Sub
        Mant_Grupos.Show()
    End Sub

    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Familias.Click
        Dim x As Integer
        Dim y As Integer
        x = Me.MousePosition().X - Me.Location.X - 5  'Adjust Here If Needed
        y = Me.MousePosition().Y - Me.Location.Y - 23 'Adjust Here If Needed
        Dim xy As New Point(x, y)
        ContextMenuStrip1.Show(Me, xy)
    End Sub

    Private Sub C1Button_Articulos_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Articulos.Click
        Mant_Articulos.Show()
    End Sub

    Private Sub C1Button_Medidas_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Medidas.Click
        Mant_Medidas.Show()
    End Sub

    Private Sub C1Button1_Click_1(sender As Object, e As EventArgs) Handles C1Button_Mant_Tipo_Precio.Click
        Mant_Tprecio.Show()
    End Sub

    Private Sub C1Button1_Click_2(sender As Object, e As EventArgs) Handles C1Button_Mant_Forma_Pago.Click
        Mant_FPago.Show()
    End Sub

    Private Sub C1Button_Tipos_Movimiento_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Tipos_Movimiento.Click
        Mant_TMov.Show()
    End Sub

    Private Sub C1Button_TCambio_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_TCambio.Click
        Mant_TC.Show()
    End Sub

    Private Sub C1Button_Bancos_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Bancos.Click
        Mant_Bancos.Show()
    End Sub

    Private Sub C1Button_Tarjetas_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Tarjetas.Click
        Mant_Tarjetas.Show()
    End Sub

    Private Sub C1Button_Cobradores_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Cobradores.Click
        Mant_Cobrador.Show()
    End Sub

    Private Sub C1Button_Proveedores_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Proveedores.Click
        Mant_Proveedores.Show()
    End Sub

    Private Sub C1Button_Clientes_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Clientes.Click
        Mant_Clientes.Show()
    End Sub

    Private Sub C1Button_Usuarios_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Usuarios.Click
        Mant_Usuarios.Show()
    End Sub

    Private Sub C1Button_Plan_Cta_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_Plan_Cta.Click
        Mant_Plancta.Show()
    End Sub

    Private Sub C1Button_SubCta_Click(sender As Object, e As EventArgs) Handles C1Button_Mant_SubCta.Click
        Mant_SubCuentas.Show()
    End Sub

    Private Sub C1Button_Ingresos_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Ingresos.Click
        Movimientos.Tag = "I"
        Movimientos.Show()
    End Sub

    Private Sub C1Button_Salidas_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Salidas.Click
        Movimientos.Tag = "S"
        Movimientos.Show()
    End Sub

    Private Sub C1Button_Compras_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Compras.Click
        Compras.Show()
    End Sub

    Private Sub C1Button_Kardex_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Kardex.Click
        Kardex.Tag = "N"
        Kardex.Show()
    End Sub

    Private Sub C1Button_Kardex_Val_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Kardex_Val.Click
        Kardex.Tag = "V"
        Kardex.Show()
    End Sub

    Private Sub C1Button_Caja_Click(sender As Object, e As EventArgs) Handles C1Button_Caja_Caja.Click
        Dim FORM As New CAJA_OFICINA
        FORM.Show()
    End Sub

    Private Sub C1Button1_Click_3(sender As Object, e As EventArgs) Handles C1Button_Caja_Capital.Click
        Capital.Show()
    End Sub

    Private Sub C1Button_Reporte_Caja_Click(sender As Object, e As EventArgs) Handles C1Button_Caja_Reporte_Caja.Click
        Rpte_Caja.Show()
    End Sub

    Private Sub C1Button_Ventas_Click(sender As Object, e As EventArgs) Handles C1Button_Ventas_Contingencia.Click
        'Ventas_Contingencia.Show()
        Consultar_Contingencias.Show()
    End Sub

    Private Sub C1Button_Cobranza_Cliente_Click(sender As Object, e As EventArgs) Handles C1Button_CtaCte_Cobranza_Cliente.Click
        Cobranza_Cliente.Show()
    End Sub

    Private Sub C1Button_Cobranza_Masiva_Cliente_Click(sender As Object, e As EventArgs) Handles C1Button_CtaCte_Cobranza_Masiva_Cliente.Click
        Cobranza_Masiva.Show()
    End Sub

    Private Sub C1Button_Ctas_Pagar_Click(sender As Object, e As EventArgs) Handles C1Button_CtaCte_Ctas_Pagar.Click
        ''Pago_Proveedor.Show()
        Cuentas_Pagar.Show()
    End Sub

    Private Sub C1Button_Compras_Prov_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Compras_Prov.Click
        Rpte_Compras_x_Prov.Show()
    End Sub

    Private Sub C1Button_Movimientos_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Movimientos.Click
        Rpte_Movimientos.Show()
    End Sub

    Private Sub C1Button_Rpt_Kardex_Val_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Kardex_Val.Click
        Rpte_Seleccion_Articulo.Tag = "KV"
        Rpte_Seleccion_Articulo.Show()
    End Sub

    Private Sub C1Button_Rpt_Kardex_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Kardex.Click
        Rpte_Seleccion_Articulo.Tag = "K"
        Rpte_Seleccion_Articulo.Show()
    End Sub

    Private Sub C1Button_Reposicion_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Reposicion.Click
        Rpte_Reposicion_Stock.Show()
    End Sub

    Private Sub C1Button_Rpt_Ventas_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Ventas.Click
        Rpte_Reg_Ventas.Show()
    End Sub

    Private Sub C1Button_Rpt_Vtas_Credito_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Vtas_Credito.Click
        Rpte_Ventas_Credito.Tag = "C"
        Rpte_Ventas_Credito.Text = "Reporte de Ventas al Credito"
        Rpte_Ventas_Credito.Show()
    End Sub

    Private Sub C1Button_Rpt_Mov_Caja_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Mov_Caja.Click
        Rpt_Rango_Fechas.Show()
    End Sub

    Private Sub C1Button_Rpt_Tipo_Pagos_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Tipo_Pagos.Click
        Rpt_Rango_Fechas.Tag = "TP"
        Rpt_Rango_Fechas.Show()
    End Sub

    Private Sub C1Button_Rpt_Tarjetas_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Tarjetas.Click
        Rpt_Rango_Fechas.Tag = "TJ"
        Rpt_Rango_Fechas.Show()
    End Sub

    Private Sub C1Button_Rpt_Ctas_Cobrar_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Ctas_Cobrar.Click
        Rpte_Ventas_Credito.Tag = "P"
        Rpte_Ventas_Credito.Text = "Reporte de Cuentas x Cobrar"
        Rpte_Ventas_Credito.Show()
    End Sub

    Private Sub C1Button_Rpt_Ctas_Pagar_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Ctas_Pagar.Click
        Rpte_Cuentas_Pagar.Show()
    End Sub

    Private Sub C1Button_Util_Recalcular_Stock_Click(sender As Object, e As EventArgs) Handles C1Button_Util_Recalcular_Stock.Click
        Recalc_Stock.Show()
    End Sub

    Private Sub C1Button_Util_Config_Operador_Click(sender As Object, e As EventArgs) Handles C1Button_Util_Config_Operador.Click
        Mant_PtoVta.Show()
    End Sub

    Private Sub C1Button_Util_Config_Venta_Click(sender As Object, e As EventArgs) Handles C1Button_Util_Config_Venta.Click
        Mant_Config.Show()
    End Sub

    Private Sub C1Button_Util_X_Click(sender As Object, e As EventArgs) Handles C1Button_Util_X.Click
        Cierre_X.Tag = "X"
        Cierre_X.picturebox1.Visible = True
        Cierre_X.Show()
    End Sub

    Private Sub C1Button_Util_Y_Click(sender As Object, e As EventArgs) Handles C1Button_Util_Z.Click
        Cierre_X.Tag = "Z"
        Cierre_X.picturebox1.Visible = True
        Cierre_X.Show()
    End Sub

    Private Sub C1Button_Util_Permisos_Usuario_Click(sender As Object, e As EventArgs) Handles C1Button_Util_Permisos_Usuario.Click
        Permisos_Usuarios.Show()
    End Sub

    Private Sub C1Button_Util_Reimpresion_Bol_Fact_Click(sender As Object, e As EventArgs) Handles C1Button_Util_Reimpresion_Bol_Fact.Click
        Reimpresion.Show()
    End Sub
    Private Sub verificar_permisos()
        Try


            Dim SQL As String
            SQL = "select * from permisos where cod_user='" & GUSERID & "'"
            Dim OCOMANDO As New SqlCommand(SQL, CN_NET)
            Dim ODATAREADER As SqlDataReader
            If CN_NET.State = ConnectionState.Closed Then CN_NET.Open()
            ODATAREADER = OCOMANDO.ExecuteReader
            While ODATAREADER.Read
                Select Case ODATAREADER("NIVEL1") 'RP.Fields("nivel1").Value
                    Case "01"
                        C1OutPage_Mantenimiento.Enabled = True
                    Case "0101"
                        C1Button_Mant_Familias.Enabled = True
                    Case "0102"
                        C1Button_Mant_Articulos.Enabled = True
                    Case "0103"
                        C1Button_Mant_Medidas.Enabled = True
                    Case "0104"
                        C1Button_Mant_Tipo_Precio.Enabled = True
                    Case "0105"
                        C1Button_Mant_Forma_Pago.Enabled = True
                    Case "0106"
                        C1Button_Mant_Tipos_Movimiento.Enabled = True
                    Case "0107"
                        C1Button_Mant_TCambio.Enabled = True
                    Case "0108"
                        C1Button_Mant_Bancos.Enabled = True
                    Case "0109"
                        C1Button_Mant_Tarjetas.Enabled = True
                    Case "0110"
                        C1Button_Mant_Cobradores.Enabled = True
                    Case "0111"
                        C1Button_Mant_Proveedores.Enabled = True
                    Case "0112"
                        C1Button_Mant_Clientes.Enabled = True
                    Case "0113"
                        C1Button_Mant_Usuarios.Enabled = True
                    Case "0114"
                        C1Button_Mant_Plan_Cta.Enabled = True
                    Case "0115"
                        C1Button_Mant_SubCta.Enabled = True
                    Case "0116"
                        C1Button_ALMACENES.Enabled = True
                    Case "0117"
                        C1Button_CTA_BANCARIA.Enabled = True
                    Case "0118"
                        C1Button_TIPO_PAGO.Enabled = True
                    Case "0119"
                        C1Button_CONCEPTOS.Enabled = True
                    Case "0120"
                        C1Button_OTRO.Enabled = True
                    Case "0121"
                        C1Button_DETALLE_COMITE.Enabled = True
                    Case "0122"
                        C1Button_RUBROS.Enabled = True
                    Case "02"
                        C1OutPage_Inventario.Enabled = True
                    Case "0201"
                        C1Button_Inv_Ingresos.Enabled = True
                    Case "0202"
                        C1Button_Inv_Salidas.Enabled = True
                    Case "0203"
                        C1Button_Inv_Compras.Enabled = True
                    Case "0204"
                        C1Button_Inv_Kardex.Enabled = True
                    Case "0205"
                        C1Button_Inv_Kardex_Val.Enabled = True
                    Case "0206"
                        C1Button_Inv_Inventario.Enabled = True
                    Case "0207"
                        C1Button_Inv_Ajustes.Enabled = True
                    Case "07"
                        C1OutPage_Caja.Enabled = True
                    Case "0701"
                        C1Button_Caja_Caja.Enabled = True
                    Case "0702"
                        C1Button_Caja_Reporte_Caja.Enabled = True
                    Case "0703"
                        C1Button_Caja_Capital.Enabled = True
                    Case "0704"
                        C1Button_BANCOS.Enabled = True
                    Case "0705"
                        C1Button_ComiteDetalle.Enabled = True
                    Case "0706"
                        C1Button_CUADRO_REPORTE.Enabled = True
                    Case "03"
                        C1OutPage_Ventas.Enabled = True
                    Case "0301"
                        C1_Ventas_Ventas.Enabled = True
                    Case "0302"
                        C1_Consultar_Ventas.Enabled = True
                    Case "0303"
                        C1Button_Ventas_Contingencia.Enabled = True
                    Case "04"
                        C1OutPage_Ctas_Ctes.Enabled = True
                    Case "040101"
                        C1Button_CtaCte_Cobranza_Cliente.Enabled = True
                    Case "040102"
                        C1Button_CtaCte_Cobranza_Masiva_Cliente.Enabled = True
                    Case "0402"
                        C1Button_CtaCte_Ctas_Pagar.Enabled = True
                    Case "0403"
                        C1Button_Compras_Pagos.Enabled = True
                    Case "06"
                        C1OutPage_Reportes.Enabled = True
                    Case "060101"
                        C1Button_Rpt_Compras_Prov.Enabled = True
                    Case "060102"
                        C1Button_Rpt_Movimientos.Enabled = True
                    Case "060103"
                        C1Button_Rpt_Kardex_Val.Enabled = True
                    Case "060104"
                        C1Button_Rpt_Kardex.Enabled = True
                    Case "060105"
                        C1Button_Rpt_Reposicion.Enabled = True
                    Case "060201"
                        C1Button_Rpt_Ventas.Enabled = True
                    Case "060202"
                        C1Button_Rpt_Vtas_Credito.Enabled = True
                    Case "060203"
                        C1Button_Rpt_Mov_Caja.Enabled = True
                    Case "060204"
                        C1Button_Rpt_Tipo_Pagos.Enabled = True
                    Case "060205"
                        C1Button_Rpt_Tarjetas.Enabled = True
                    Case "060206"
                        C1Button_Rpt_Liq.Enabled = True
                    Case "060301"
                        C1Button_Rpt_Ctas_Cobrar.Enabled = True
                    Case "060302"
                        C1Button_Rpt_Ctas_Pagar.Enabled = True
                    Case "060303"
                        C1Button_Rpte_Utilidad.Enabled = True
                    Case "060304"
                        C1Button_Rpt_Stock_Valorizado.Enabled = True
                    Case "05"
                        C1OutPage_Utilitarios.Enabled = True
                    Case "0501"
                        C1Button_Util_Recalcular_Stock.Enabled = True
                    Case "0502"
                        C1Button_Util_Config_Operador.Enabled = True
                    Case "0503"
                        C1Button_Util_Config_Venta.Enabled = True
                    Case "050501"
                        C1Button_Util_X.Enabled = True
                    Case "050502"
                        C1Button_Util_Z.Enabled = True
                    Case "0504"
                        C1Button_Util_Permisos_Usuario.Enabled = True
                    Case "0505"
                        C1Button_Util_Reimpresion_Bol_Fact.Enabled = True
                End Select

            End While
            ODATAREADER.Close()
            CN_NET.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub C1Button1_Click_4(sender As Object, e As EventArgs) Handles C1_Ventas_Ventas.Click
        Ventas_V2.Show()
    End Sub

    Private Sub C1Button2_Click(sender As Object, e As EventArgs) Handles C1_Consultar_Ventas.Click
        Consultar_Ventas.Show()
    End Sub

    Private Sub C1Button_ALMACENES_Click(sender As Object, e As EventArgs) Handles C1Button_ALMACENES.Click
        Mant_Almacenes.Show()
    End Sub

    Private Sub C1Button_Rpte_Utilidad_Click(sender As Object, e As EventArgs) Handles C1Button_Rpte_Utilidad.Click
        Consultar_Utilidad.Show()
    End Sub

    Private Sub C1Button_Compras_Pagos_Click(sender As Object, e As EventArgs) Handles C1Button_Compras_Pagos.Click
        Consultar_Compras_Pagos.Show()
    End Sub

    Private Sub C1Button_CTA_BANCARIA_Click(sender As Object, e As EventArgs) Handles C1Button_CTA_BANCARIA.Click
        Mant_CtaBancaria.Show()
    End Sub

    Private Sub C1Button_TIPO_PAGO_Click(sender As Object, e As EventArgs) Handles C1Button_TIPO_PAGO.Click
        Mant_TPago.Show()
    End Sub

    Private Sub C1Button_BANCOS_Click_1(sender As Object, e As EventArgs) Handles C1Button_BANCOS.Click
        Mov_Banco.Show()
    End Sub

    Private Sub C1Button_CONCEPTOS_Click(sender As Object, e As EventArgs) Handles C1Button_CONCEPTOS.Click
        Mant_Conceptos.Show()
    End Sub

    Private Sub C1Button_OTRO_Click(sender As Object, e As EventArgs) Handles C1Button_OTRO.Click
        Mant_Otros.Show()
    End Sub

    Private Sub C1Button1_Click_5(sender As Object, e As EventArgs) Handles C1Button_DETALLE_COMITE.Click
        Mant_Comite_Detalle.Show()
    End Sub

    Private Sub C1Button_RUBROS_Click(sender As Object, e As EventArgs) Handles C1Button_RUBROS.Click
        Mant_Rubros.Show()
    End Sub

    Private Sub C1Button_ComiteDetalle_Click(sender As Object, e As EventArgs) Handles C1Button_ComiteDetalle.Click
        Consultar_Comite_Detalle.Show()
    End Sub

    Private Sub C1Button_Rpt_Stock_Valorizado_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Stock_Valorizado.Click
        Consultar_Stock_Costo.Show()
    End Sub

    Private Sub C1Button_Rpt_Liq_Click(sender As Object, e As EventArgs) Handles C1Button_Rpt_Liq.Click
        Rango_Fechas_V2.Tag = "LIQ"
        Rango_Fechas_V2.Show()
    End Sub

    Private Sub C1Button_Inv_Inventario_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Inventario.Click
        Mant_Inventario.Show()
    End Sub

    Private Sub C1Button_CUADRO_REPORTE_Click(sender As Object, e As EventArgs) Handles C1Button_CUADRO_REPORTE.Click
        Cuadro_Reporte.Show()
    End Sub

    Private Sub C1Button_Inv_Ajustes_Click(sender As Object, e As EventArgs) Handles C1Button_Inv_Ajustes.Click
        Cuadro_Ajustes.Show()
    End Sub
End Class