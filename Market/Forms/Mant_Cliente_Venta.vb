Public Class Mant_Cliente_Venta

    Dim OBJCLIE As ClsCliente
    Dim myInfo As Libreria.ClsSunat
    Dim xDat As String
    Dim xRazSoc As String, xEst As String, xCon As String, xDir As String
    Dim xRazSocX As Long, xEstX As Long, xConX As Long, xDirX As Long

    Public TORIG As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTONCAPCHA.Click
        Try
            CARGARIMAGEN()
            Me.TXT_CAPTCHA.SelectAll()
            BTONCAPCHA.Focus()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub limpiar_SUNAT()
        ' Me.TXT_RUC.Clear()
        Me.TXT_DESCRIPCION.Clear()
        Me.TXT_DIRECCION.Clear()
        Me.TXT_RUC.Focus()
        ''
        Me.TXT_ESTADO.Clear()
        Me.TXT_CONDICION.Clear()

    End Sub

    Private Sub Button_EFECTIVO_Click(sender As Object, e As EventArgs) Handles Button_EFECTIVO.Click
        Try
            Dim INTVALOR As Integer

            If Me.TXT_DESCRIPCION.Text = "" Then MsgBox("Debe ingresar la Descripcion", MsgBoxStyle.Critical) : Exit Sub

            If BUSCAR_EXISTE("CLIENTES", "RUC_CLIENTE", Me.TXT_RUC.Text.Trim) Then
                MsgBox("Ruc ya existe", MsgBoxStyle.Critical) : Exit Sub
            End If
            If BUSCAR_EXISTE("CLIENTES", "DESC_CLIENTE", Me.TXT_DESCRIPCION.Text.Trim) Then
                MsgBox("Cliente ya existe", MsgBoxStyle.Critical) : Exit Sub
            End If


            INTVALOR = OBJCLIE.MANT_CLIENTES(Me.TXT_RUC.Text.Trim, Me.TXT_DESCRIPCION.Text.Trim, Me.TXT_RUC.Text.Trim, Me.TXT_DIRECCION.Text.Trim, "", CFG_FPAGO, 0, "", Me.TXT_MAIL.Text.Trim, intNUEVO)
            If INTVALOR = 1 Then MsgBox("Error al grabar", MsgBoxStyle.Critical) : Exit Sub
            If INTVALOR = 0 Then
                MsgBox("Grabado Correctamente", MsgBoxStyle.Information)

                Ventas_V2.TXT_RUC_CLIENTE.Text = Me.TXT_RUC.Text
                Ventas_V2.BUSCAR_RUC_CLIENTE()

            End If
            ''     Teclado_Net.Close()
            Me.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar_SUNAT()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Teclado_Net.Show()
        System.Diagnostics.Process.Start("c:\temp\VirtualKeyboard.exe")
        'Teclado_Net.TopMost = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            If Trim(TXT_RUC.Text) = "" Then
                MsgBox("Ingrese número del RUC")
                TXT_RUC.Focus()
                Exit Sub
            End If
            If IsNumeric(TXT_RUC.Text) = True Then
                If Len(TXT_RUC.Text) < 11 Then
                    limpiar_SUNAT()
                    MsgBox("Ingrese los 11 números del RUC")
                    TXT_RUC.Focus()
                    Exit Sub
                End If
                If Val(Mid(Trim(TXT_RUC.Text), 2, 9)) = 0 Or Trim(TXT_RUC.Text) = "23333333333" Then
                    limpiar_SUNAT()
                    MsgBox("Verificar número del RUC")
                    TXT_RUC.Focus()
                    Exit Sub
                End If

                If GValidaRUC(TXT_RUC.Text) = False Then
                    limpiar_SUNAT()
                    MsgBox("El número del RUC no es válido")
                    TXT_RUC.Focus()
                    Exit Sub
                End If

            Else
                limpiar_SUNAT()
                MsgBox("Solo se aceptan números")
                TXT_RUC.Focus()
            End If
            ''llamamos a los metodos de la libreria ConsultaReniec...

            myInfo.GetInfo(TXT_RUC.Text, TXT_CAPTCHA.Text)
            TXT_DIRECCION.Text = myInfo.ApeMaterno
            TXT_DESCRIPCION.Text = myInfo.Nombres
            TXT_RUC.Text = TXT_RUC.Text

            TXT_ESTADO.Text = myInfo.Estado
            TXT_CONDICION.Text = myInfo.Condicion
            TXT_CAPTCHA.Text = ""
            CARGARIMAGEN()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TXT_DESCRIPCION_TextChanged(sender As Object, e As EventArgs) Handles TXT_DESCRIPCION.TextChanged

    End Sub

    Private Sub TXT_RUC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RUC.KeyPress
        e.KeyChar = ChrW(GBloqueaNonumeros(AscW(e.KeyChar)))
    End Sub

    Private Sub TXT_CAPTCHA_TextChanged(sender As Object, e As EventArgs) Handles TXT_CAPTCHA.TextChanged

    End Sub

    Private Sub TXT_RUC_TextChanged(sender As Object, e As EventArgs) Handles TXT_RUC.TextChanged

    End Sub

    Private Sub TXT_DIRECCION_TextChanged(sender As Object, e As EventArgs) Handles TXT_DIRECCION.TextChanged

    End Sub

    Private Sub Mant_Cliente_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OBJCLIE = New ClsCliente
        CARGARIMAGEN()
    End Sub

    Private Sub TXT_PLACA_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Sub CARGARIMAGEN()
        Try

            If myInfo Is Nothing Then
                myInfo = New Libreria.ClsSunat

            End If
            Me.Picture.Image = myInfo.GetCapcha

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub




End Class