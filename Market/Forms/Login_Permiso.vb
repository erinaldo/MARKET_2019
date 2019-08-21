Public Class Login_Permiso
    Dim OBJUSER As ClsUsu
    Dim OBJVENTAS As ClsVenta
    Public ACCION As String

    ''VENTAS
    Public COD_DOC As String
    Public NRO_DOC As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.TXT_USER.Text = "" Then MsgBox("Ingrese Usuario", MsgBoxStyle.Information) : Exit Sub
            If Me.TXT_PSW.Text = "" Then MsgBox("Ingrese Contraseña", MsgBoxStyle.Information) : Exit Sub
            OBJUSER.COD_USER = GVDATO(Me.TXT_USER.Text)
            OBJUSER.PSW_USER = GVDATO(duplicacarnoval1(Encrip(Me.TXT_PSW.Text)))
            If OBJUSER.GRsValidarUsuario = 1 Then MsgBox("Usuario no existe o clave incorrecta", MsgBoxStyle.Critical) : Exit Sub
            Select Case ACCION
                Case "ANULAR VENTA"
                    ANULAR_VENTA()
            End Select

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub ANULAR_VENTA()
        OBJVENTAS = New ClsVenta
        Dim VALOR As Integer
        If OBJUSER.Validar_PERMISO("1001", Me.TXT_USER.Text) = True Then
            VALOR = OBJVENTAS.ANULAR_VENTA(COD_DOC, ArmaNumero(NRO_DOC))
            If VALOR = 1 Then MsgBox("Error al Anular", MsgBoxStyle.Information) : Exit Sub
            If VALOR = 0 Then
                MsgBox("Anulado Correctamente", MsgBoxStyle.Information)
                Ventas.REIMPRIME = 2
                Ventas.IMPRIMIR()
                Ventas.Button_CANCELAR_Click(Ventas.Button_CANCELAR, EventArgs.Empty)
                Me.Close()
            End If
        Else
            MsgBox("Este Usuario no tiene permiso para Anular", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJUSER = New ClsUsu
    End Sub
End Class