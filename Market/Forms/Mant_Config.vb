Public Class Mant_Config
    Dim OBJCONFIG As ClsConfig
    Dim intvalor As Integer
    Public pb_editar As Boolean
    Public pb_agregar As Boolean
    
    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Try
            LimpiarCAJAS(Me.Controls)
            Me.DT.Value = Date.Now
            ' Call HabBotones(False)
            Me.pb_agregar = True
            Me.pb_editar = False

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Mant_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCONFIG = New ClsConfig
        ASIGNAR_DATOS()
    End Sub
    Sub ASIGNAR_DATOS()
        Dim RS As SqlDataReader 'New ADODB.Recordset
        RS = OBJCONFIG.LISTAR_CONFIG
        While RS.Read
            Me.DT.Text = RS("FECHA_PROCESO")
            Me.TXT_IGV.Text = NULO(RS("IGV"), "N")
            Me.TXT_TURNO.Text = NULO(RS("TURNO_VTA"), "N")
            Me.TXT_FIN_DIA.Text = NULO(RS("FIN_DIA"), "S")
            If RS("MON_VENTA") = "S" Then Me.OPT_SOLES.Checked = True Else Me.OPT_DOLARES.Checked = True
        End While
        RS.Close()
        CN_NET.Close()
    End Sub
    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Try
            Dim TIPO As String

            If Val(Me.TXT_IGV.Text) = 0 Then MsgBox("Ingrese Igv", MsgBoxStyle.Information) : Exit Sub
            If Val(Me.TXT_TURNO.Text) = 0 Then MsgBox("Ingrese Turno Actual", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_FIN_DIA.Text = "" Then MsgBox("Ingrese PC que hara Fin de Dia", MsgBoxStyle.Information) : Exit Sub

            ''GRABANDO
            'If pb_agregar Then TIPO = "N" Else TIPO = "M"
            TIPO = "M"
            intvalor = OBJCONFIG.MANT_CONFIG(Me.TXT_IGV.Text, Me.TXT_TURNO.Text, Me.DT.Value, Me.TXT_FIN_DIA.Text.Trim, IIf(Me.OPT_SOLES.Checked = True, "S", "D"), TIPO)
            If intvalor = 0 Then
                MsgBox("Configuracion grabada con exito", MsgBoxStyle.Information)
                '   Call ToolSNuevo_Click(ToolNuevo, EventArgs.Empty)
                'Call HabBotones(True)
                End
            Else
                MsgBox("Error al Grabar", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub
End Class