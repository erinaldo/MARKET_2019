Public Class Movi_Banco
    Dim OBJMOVBANCO As ClsMovBanco
    Dim OBJFPAGO As ClsFPago
    Dim OBJTC As ClsTC

    Public COD_BANCO As String
    Public TIPO As String
    Public ID_DET As Integer


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Movi_Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXT_MONTO.Text = ""
        Me.TXT_OBS.Text = ""
        Me.TXT_CONCEPTO.Text = ""
        Me.TXT_CONCEPTO.Tag = ""
        Me.TXT_GIRADO.Clear()
        Me.TXT_GIRADO.Tag = ""
        Me.TXT_REFERENCIA.Clear()
        Me.OPT_NINGUNO.Checked = True

        OBJMOVBANCO = New ClsMovBanco
        OBJFPAGO = New ClsFPago
        OBJTC = New ClsTC

        Me.DT.Value = Date.Today
        Me.DT_OPERACION.Value = Date.Today

        Me.GROUP_TC.Visible = False

        Me.DT_OPERACION.Visible = False
        Me.Label1.Visible = False

        'OBJFPAGO.LISTAR_FPAGO_MOV(Me.Combo_FPAGO)
        LLENAR_COMBO(Me.Combo_FPAGO, "LISTAR_FORMA_PAGO_MOV 0,'',''", "DESCRIPCION", "CODIGO", CAD_CON)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim SW As Integer
            Dim TGIRO As String, COD_GIRO As String
            If Me.GROUP_TC.Visible = True And Val(Me.TXT_TC.Text) = 0 Then MsgBox("Ingrese el Tipo de Cambio", MsgBoxStyle.Information) : Exit Sub
            If Me.Combo_FPAGO.Text = "" Then MsgBox("Seleccione la Forma de Pago", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_CONCEPTO.Text = "" Then MsgBox("seleccione Concepto", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_OBS.Text = "" Then MsgBox("Ingrese Observacion", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_MONTO.Text) = 0 Then MsgBox("Ingrese Monto", MsgBoxStyle.Information) : Exit Sub

            If Me.Group_BANCO_DESTINO.Visible = True Then
                If Me.TXT_BANCO_DEST.Text = "" Then MsgBox("Seleccione el Banco Destino", MsgBoxStyle.Information) : Exit Sub
                If Me.TXT_BANCO_DEST.Tag = COD_BANCO Then MsgBox("El banco origen y Destino no pueden ser Iguales", MsgBoxStyle.Information) : Exit Sub
            End If

            If Me.OPT_NINGUNO.Checked = False And Me.TXT_GIRADO.Text = "" Then
                MsgBox("Ingrese Observacion", MsgBoxStyle.Information) : Exit Sub
            End If
            If Me.OPT_NINGUNO.Checked = True Then
                TGIRO = ""
                COD_GIRO = ""
            Else
                TGIRO = IIf(Me.OPT_PROV.Checked = True, "P", "O")
                COD_GIRO = Me.TXT_GIRADO.Tag
            End If
            If Me.CHK_COMITE.Checked = False Then Me.TXT_COMITE.Text = ""
            If Me.CHK_COMITE.Checked = True And Me.TXT_COMITE.Text = "" Then MsgBox("Seleccione el Comite", MsgBoxStyle.Information) : Exit Sub
            With OBJMOVBANCO
                .Id = ID_DET
                .CodBanco = COD_BANCO
                .TipoMov = IIf(Me.OPT_ING.Checked = True, "I", "S")
                .CodConcepto = Me.TXT_CONCEPTO.Tag
                .Monto = GFormatodeNumero(Me.TXT_MONTO.Text, 2)
                .FecGiro = DT.Value
                .Observacion = Me.TXT_OBS.Text.Trim
                .FecCobro = IIf(Me.DT_COBRO.Visible = True, Format(Me.DT_COBRO.Value, "dd/MM/yyyy"), "")
                .GiradoCod = COD_GIRO
                .GiradoTipo = TGIRO
                .Referencia = Me.TXT_REFERENCIA.Text.Trim
                .FormaPago = Me.Combo_FPAGO.SelectedValue
                .TCambio = IIf(Me.GROUP_TC.Visible = True, Val(Me.TXT_TC.Text), 0)
                .CodBanco_D = IIf(Me.Group_BANCO_DESTINO.Visible = True, Me.TXT_BANCO_DEST.Tag, 0)
                .Comite = IIf(Me.TXT_COMITE.Text = "", 0, Me.TXT_COMITE.Tag)
                .Usuario = GUSERID
                SW = .Mantenimiento(TIPO, CN_NET)
            End With
            If SW = 1 Then MsgBox("Error al Grabar", MsgBoxStyle.Critical) : Exit Sub
            If SW = 0 Then MsgBox("Grabado Correctamente", MsgBoxStyle.Information)


            Me.DT.Value = Date.Today
            Me.TXT_MONTO.Text = ""
            Me.TXT_OBS.Text = ""
            Me.TXT_CONCEPTO.Text = ""
            Me.TXT_CONCEPTO.Tag = ""

            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Sub LLENAR_DATOS(ByVal ID As Double)
        Try
            With OBJMOVBANCO
                .Id = ID
                .BUSCAR(CN_NET)
                If .Monto = 0 Then Exit Sub
                Me.Button1.Enabled = True
                If .TipoMov = "I" Then Me.OPT_ING.Checked = True Else Me.OPT_SAL.Checked = True
                Me.TXT_CONCEPTO.Tag = NULO(.CodConcepto, "S")
                Me.TXT_CONCEPTO.Text = NULO(.DescConcepto, "S")
                Me.GROUP_TC.Visible = .ConceptoTC
                Me.TXT_MONTO.Text = NULO(.Monto, "N")
                Me.DT.Value = .FecGiro

                Me.Combo_FPAGO.SelectedValue = .FormaPago
                If .ConceptoFecCobro = True Then
                    Me.Label5.Visible = True
                    Me.DT_COBRO.Visible = True
                    Me.DT_COBRO.Value = .FecCobro
                Else
                    Me.Label5.Visible = False
                    Me.DT_COBRO.Visible = False
                End If
                Me.TXT_OBS.Text = NULO(.Observacion, "S")
                If NULO(.FegOper, "S") = "" Then
                    Me.DT_OPERACION.Visible = False
                    Me.Label1.Visible = False
                Else
                    Me.DT_OPERACION.Value = .FegOper
                    Me.DT_OPERACION.Visible = True
                    Me.Label1.Visible = True
                End If

                If .TipoMov = "O" Then
                    Me.OPT_OTROS.Checked = True
                    Me.TXT_GIRADO.Text = .OtroDesc
                End If
                If .TipoMov = "P" Then
                    Me.OPT_PROV.Checked = True
                    Me.TXT_GIRADO.Text = .ProvDesc
                End If
                If .TipoMov = "N" Then Me.OPT_NINGUNO.Checked = True
                Me.TXT_GIRADO.Tag = .GiradoCod

                ''If RS("PAGO_MOVB") <> 0 Then MsgBox("Movimiento usado para Cancelar Documento, solo se podra Consultar", MsgBoxStyle.Information) : Me.Button1.Enabled = False 'Else Me.Button1.Enabled = True
                Me.TXT_REFERENCIA.Text = .Referencia
                Me.TXT_TC.Text = .TCambio

                If .Transferencia = 0 Then
                    Me.Group_BANCO_DESTINO.Visible = False
                    Me.TXT_BANCO_DEST.Clear()
                Else
                    Me.Group_BANCO_DESTINO.Visible = True
                    Me.TXT_BANCO_DEST.Tag = .CodBanco_D
                    Me.TXT_BANCO_DEST.Text = .BancoDesc_D
                End If

                If .Comite = 0 Then
                    Me.CHK_COMITE.Checked = False
                    Me.Group_COMITE.Visible = False
                Else
                    Me.CHK_COMITE.Checked = True
                    Me.Group_COMITE.Visible = True
                    Me.TXT_COMITE.Tag = .Comite
                    Me.TXT_COMITE.Text = .DescComite
                End If
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TXT_MONTO_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MONTO.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub


    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(8, 3) As Object
        arraybusqueda(1, 1) = "COD_CONCEPTO"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "Desc_CONCEPTO"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "TIPO_CONCEPTO"
        arraybusqueda(3, 2) = "Tipo "
        arraybusqueda(3, 3) = 1000
        arraybusqueda(4, 1) = "FCOBRO_CONCEPTO"
        arraybusqueda(4, 2) = "FCobro "
        arraybusqueda(4, 3) = 1000
        arraybusqueda(5, 1) = "TC_CONCEPTO"
        arraybusqueda(5, 2) = "TC "
        arraybusqueda(5, 3) = 1000
        arraybusqueda(6, 1) = "TRANSF_CONCEPTO"
        arraybusqueda(6, 2) = "Estado "
        arraybusqueda(6, 3) = 1500

        arraybusqueda(7, 1) = "COMITE_CONCEPTO"
        arraybusqueda(7, 2) = "Comite "
        arraybusqueda(7, 3) = 1500

        arraybusqueda(8, 1) = "STAT_CONCEPTO"
        arraybusqueda(8, 2) = "Estado "
        arraybusqueda(8, 3) = 1500

        ''
        With BusquedaMaestra
            .ACT = "Mant_Conceptos_BANCO"
            .STATINI = 0
            .CODCTA = IIf(Me.OPT_ING.Checked = True, "I", "S")
            .CARGAR_COMBO(arraybusqueda, 8, 2)
            .ShowDialog()

            ''
            If .GrecibeColumnaID <> "" Then
                Me.TXT_CONCEPTO.Tag = .GrecibeColumnaID
                Me.TXT_CONCEPTO.Text = .GrecibeColumnaOpcional
                If .GrecibeColumnaOpcional3 = True Then
                    Me.Label5.Visible = True
                    Me.DT_COBRO.Visible = True
                Else
                    Me.Label5.Visible = False
                    Me.DT_COBRO.Visible = False
                End If
                Me.GROUP_TC.Visible = .GrecibeColumnaOpcional5
                Me.Group_BANCO_DESTINO.Visible = .GrecibeColumnaOpcional6
                Me.CHK_COMITE.Checked = .GrecibeColumnaOpcional7
                Me.Group_COMITE.Visible = CHK_COMITE.Checked
            End If
            .Close()
        End With
    End Sub

    Private Sub OPT_PROV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_PROV.CheckedChanged
        If Me.OPT_PROV.Checked = True Then
            Me.Label8.Visible = True
            Me.TXT_GIRADO.Visible = True
            Me.Button3.Visible = True
            Me.TXT_GIRADO.Clear()
            Me.TXT_GIRADO.Tag = ""
        End If
    End Sub

    Private Sub OPT_OTROS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_OTROS.CheckedChanged
        If Me.OPT_OTROS.Checked = True Then
            Me.Label8.Visible = True
            Me.TXT_GIRADO.Visible = True
            Me.Button3.Visible = True
            Me.TXT_GIRADO.Clear()
            Me.TXT_GIRADO.Tag = ""
        End If
    End Sub

    Private Sub OPT_NINGUNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPT_NINGUNO.CheckedChanged
        If Me.OPT_NINGUNO.Checked = True Then
            Me.Label8.Visible = False
            Me.TXT_GIRADO.Visible = False
            Me.Button3.Visible = False
            Me.TXT_GIRADO.Clear()
            Me.TXT_GIRADO.Tag = ""
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If Me.OPT_PROV.Checked = True Then
                'Lineas que llaman al Formulario de Búsqueda

                Dim arraybusqueda(3, 3) As Object
                arraybusqueda(1, 1) = "COD_PROVED"
                arraybusqueda(1, 2) = "Codigo"
                arraybusqueda(1, 3) = 1500
                arraybusqueda(2, 1) = "Desc_PROVED"
                arraybusqueda(2, 2) = "Descripcion "
                arraybusqueda(2, 3) = 3000
                arraybusqueda(3, 1) = "STAT_PROVED"
                arraybusqueda(3, 2) = "Estado "
                arraybusqueda(3, 3) = 1500

                ''
                With BusquedaMaestra
                    .ACT = "Mant_Proveedores"
                    .STATINI = 0
                    .CARGAR_COMBO(arraybusqueda, 3, 2)
                    .ShowDialog()
                    ''
                    If .GrecibeColumnaID <> "" Then
                        Me.TXT_GIRADO.Tag = .GrecibeColumnaID
                        Me.TXT_GIRADO.Text = .GrecibeColumnaOpcional
                    End If
                    .Close()
                End With
            End If
            If OPT_OTROS.Checked = True Then
                'Lineas que llaman al Formulario de Búsqueda

                'Lineas que llaman al Formulario de Búsqueda

                Dim arraybusqueda(3, 3) As Object
                arraybusqueda(1, 1) = "COD_OTRO"
                arraybusqueda(1, 2) = "Codigo"
                arraybusqueda(1, 3) = 1500
                arraybusqueda(2, 1) = "DESC_OTRO"
                arraybusqueda(2, 2) = "Descripcion "
                arraybusqueda(2, 3) = 3000
                arraybusqueda(3, 1) = "STAT_OTRO"
                arraybusqueda(3, 2) = "Estado "
                arraybusqueda(3, 3) = 1500
                ''
                With BusquedaMaestra
                    .ACT = "Mant_Otro"
                    .STATINI = 0
                    .CARGAR_COMBO(arraybusqueda, 3, 2)
                    .ShowDialog()
                    ''
                    If .GrecibeColumnaID <> "" Then
                        Me.TXT_GIRADO.Tag = .GrecibeColumnaID
                        TXT_GIRADO.Text = .GrecibeColumnaOpcional
                    End If
                    .Close()
                End With
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub TXT_OBS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_OBS.TextChanged

    End Sub

    Private Sub DT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT.ValueChanged
        Me.TXT_TC.Text = OBJTC.BUSCAR_TC(Me.DT.Value, "V")
    End Sub

    Private Sub TXT_TC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TC.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_TC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TC.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Lineas que llaman al Formulario de Búsqueda
        Dim arraybusqueda(5, 3) As Object
        arraybusqueda(1, 1) = "ACTACODI"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "ACTADESC"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "AMONSIMB"
        arraybusqueda(3, 2) = "Moneda "
        arraybusqueda(3, 3) = 1500
        arraybusqueda(4, 1) = "ABANDESC"
        arraybusqueda(4, 2) = "Banco "
        arraybusqueda(4, 3) = 1500
        arraybusqueda(5, 1) = "ACTASTAT"
        arraybusqueda(5, 2) = "Estado "
        arraybusqueda(5, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_CtaBancos"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_BANCO_DEST.Tag = .GrecibeColumnaID
                TXT_BANCO_DEST.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Lineas que llaman al Formulario de Búsqueda

        Dim arraybusqueda(3, 3) As Object
        arraybusqueda(1, 1) = "COD_DCOMITE"
        arraybusqueda(1, 2) = "Codigo"
        arraybusqueda(1, 3) = 1500
        arraybusqueda(2, 1) = "DESC_DCOMITE"
        arraybusqueda(2, 2) = "Descripcion "
        arraybusqueda(2, 3) = 3000
        arraybusqueda(3, 1) = "STAT_DCOMITE"
        arraybusqueda(3, 2) = "Estado "
        arraybusqueda(3, 3) = 1500
        ''
        With BusquedaMaestra
            .ACT = "Mant_Comite_Detalle"
            .STATINI = 0
            .CARGAR_COMBO(arraybusqueda, 3, 2)
            .ShowDialog()
            ''
            If .GrecibeColumnaID <> "" Then
                TXT_COMITE.Tag = .GrecibeColumnaID
                TXT_COMITE.Text = .GrecibeColumnaOpcional
            End If
            .Close()
        End With
    End Sub
End Class