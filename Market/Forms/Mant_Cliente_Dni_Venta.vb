Public Class Mant_Cliente_Dni_Venta
    Dim OBJCLIE As ClsCliente
    Public TORIG As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Mant_Cliente_Dni_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCLIE = New ClsCliente
        LIMPIAR()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LIMPIAR()
    End Sub
    Sub LIMPIAR()
        Me.TXT_DNI.Clear()
        Me.TXT_DIRECCION.Clear()
        Me.TXT_DESCRIPCION.Clear()
        Me.TXT_MAIL.Clear()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
    End Sub

    Private Sub Button_EFECTIVO_Click(sender As Object, e As EventArgs) Handles Button_EFECTIVO.Click
        Try
            Dim INTVALOR As Integer
            If Me.TXT_DESCRIPCION.Text = "" Then MsgBox("Debe ingresar el Nombre", MsgBoxStyle.Critical) : Exit Sub
            If Me.TXT_DNI.Text.Trim.Length < 8 Then MsgBox("El Dni no es Valido", MsgBoxStyle.Critical) : Exit Sub
            If BUSCAR_EXISTE("CLIENTES", "DNI_CLIENTE", Me.TXT_DNI.Text.Trim) Then
                MsgBox("Dni ya existe", MsgBoxStyle.Critical) : LLENAR_DATOS() : Me.Close() : Exit Sub
            End If
            If BUSCAR_EXISTE("CLIENTES", "DESC_CLIENTE", Me.TXT_DESCRIPCION.Text.Trim) Then
                MsgBox("Cliente ya existe", MsgBoxStyle.Critical) : LLENAR_DATOS() : Me.Close() : Exit Sub
            End If


            INTVALOR = OBJCLIE.MANT_CLIENTES(Me.TXT_DNI.Text, Me.TXT_DESCRIPCION.Text.Trim, "", Me.TXT_DIRECCION.Text, "", CFG_FPAGO, 0, Me.TXT_DNI.Text.Trim, Me.TXT_MAIL.Text.Trim, intNUEVO)
            If INTVALOR = 1 Then MsgBox("Error al grabar", MsgBoxStyle.Critical) : Exit Sub
            If INTVALOR = 0 Then
                MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
                LLENAR_DATOS()

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

        End Try
    End Sub
    Sub LLENAR_DATOS()
        Ventas_V2.TXT_RUC_CLIENTE.Text = Me.TXT_DNI.Text
        Ventas_V2.BUSCAR_DATOS_CLIENTE()

    End Sub
End Class