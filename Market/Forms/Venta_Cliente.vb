Public Class Venta_Cliente
    Dim OBJCLIE As ClsCliente
    Private Sub Venta_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJCLIE = New ClsCliente
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button_ANULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ANULAR.Click
        Dim TIPO As String
        Dim INTVALOR As Integer
        If Me.TXT_CODCLIE.Text = "" Then MsgBox("Ingrese codigo del cliente", MsgBoxStyle.Critical) : Exit Sub
        If Me.TXT_DESC.Text = "" Then MsgBox("Ingrese descripcion del cliente", MsgBoxStyle.Critical) : Exit Sub
        If Me.TXT_RUC.Text = "" Then MsgBox("Ingrese ruc del cliente", MsgBoxStyle.Critical) : Exit Sub
        ''VALIDAR SI EXISTE
        If CN_NET.State = ConnectionState.Open Then CN_NET.Close()
        If BUSCAR_EXISTE("CLIENTES", "COD_CLIENTE", Me.TXT_CODCLIE.Text.Trim) = True Then
            MsgBox("Cliente ya existe", MsgBoxStyle.Information) : Exit Sub
        End If
        If BUSCAR_EXISTE("CLIENTES", "RUC_CLIENTE", Me.TXT_RUC.Text.Trim) = True Then
            If MsgBox("Ruc ya existe,seguro de Grabar??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If
        ''GRABANDO
        TIPO = "N"
        'INTVALOR = OBJCLIE.MANT_CLIENTES(Me.TXT_CODCLIE.Text.Trim, Me.TXT_DESC.Text.Trim, Me.TXT_RUC.Text.Trim, _
        'Me.TXT_DIREC.Text.Trim, "", DEFAULT_FPAGO, 0, "", TIPO)
        If intvalor = 0 Then
            MsgBox("Cliente grabado con exito", MsgBoxStyle.Information)
            With Ventas
                .TXT_CODCLIE.Text = Me.TXT_CODCLIE.Text.Trim
                .TXT_RUC.Text = Me.TXT_RUC.Text.Trim
                .TXT_RAZON.Text = Me.TXT_DESC.Text.Trim
                .TXT_DIRECCION.Text = Me.TXT_DIREC.Text.Trim
            End With
            Me.Close()
        Else
            MsgBox("Error al Grabar", MsgBoxStyle.Information)
        End If
    End Sub
End Class