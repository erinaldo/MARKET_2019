Public Class Acceso_Numerico
    Dim VALOR As String
    Public TORIG As String
    Public UserCod As String = ""
    Public UserPsw As String = ""
    Protected Overloads Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property

    Private Sub Table_CALC_Paint(sender As Object, e As PaintEventArgs) Handles Table_CALC.Paint

    End Sub

    Private Sub Button_1_Click_1(sender As Object, e As EventArgs) Handles Button_1.Click
        VALOR = 1
        EVALUA()
    End Sub
    Sub EVALUA()
        If Len(Me.TXT_CLAVE.Text) = 6 Then Exit Sub
        Me.TXT_CLAVE.Text = TXT_CLAVE.Text + VALOR

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXT_CLAVE.Text = "" Then Exit Sub
        TXT_CLAVE.Text = Strings.Left(TXT_CLAVE.Text, Len(TXT_CLAVE.Text) - 1)
    End Sub

    Private Sub Button_2_Click_1(sender As Object, e As EventArgs) Handles Button_2.Click
        VALOR = 2
        EVALUA()
    End Sub

    Private Sub Button_3_Click_1(sender As Object, e As EventArgs) Handles Button_3.Click
        VALOR = 3
        EVALUA()
    End Sub

    Private Sub Button_4_Click_1(sender As Object, e As EventArgs) Handles Button_4.Click
        VALOR = 4
        EVALUA()
    End Sub

    Private Sub Button_5_Click_1(sender As Object, e As EventArgs) Handles Button_5.Click
        VALOR = 5
        EVALUA()
    End Sub

    Private Sub Button_6_Click_1(sender As Object, e As EventArgs) Handles Button_6.Click
        VALOR = 6
        EVALUA()
    End Sub

    Private Sub Button_7_Click_1(sender As Object, e As EventArgs) Handles Button_7.Click
        VALOR = 7
        EVALUA()
    End Sub

    Private Sub Button_8_Click_1(sender As Object, e As EventArgs) Handles Button_8.Click
        VALOR = 8
        EVALUA()
    End Sub

    Private Sub Button_9_Click_1(sender As Object, e As EventArgs) Handles Button_9.Click
        VALOR = 9
        EVALUA()
    End Sub

    Private Sub Button_0_Click_1(sender As Object, e As EventArgs) Handles Button_0.Click
        VALOR = 0
        EVALUA()
    End Sub

    Private Sub Button_ENTER_Click_1(sender As Object, e As EventArgs) Handles Button_ENTER.Click
        If Len(Me.TXT_CLAVE.Text) <> 6 Then MsgBox("La clave debe ser de 6 Digitos", MsgBoxStyle.Information) : Exit Sub
        Select Case TORIG
            Case "MANT"
                If BUSCAR_EXISTE("USUARIOS", "AUSUNUM", Me.TXT_CLAVE.Text) Then
                    MsgBox("La clave ya existe", MsgBoxStyle.Critical)
                Else
                    Me.Close()
                End If
            Case "L1"
                Dim OBJUSU As New ClsUsu
                With OBJUSU
                    Dim CLAVENUM As String
                    CLAVENUM = GVDATO(duplicacarnoval1(Encrip(Me.TXT_CLAVE.Text)))
                    .BUSCAR_USER_NUM(CLAVENUM)
                    If .COD_USER = "" Then MsgBox("No existe el Usuario", MsgBoxStyle.Information) : Exit Sub
                    UserCod = .COD_USER
                    UserPsw = GVDATO(duplicacarnoval1(Encrip(.PSW_USER)))
                    Me.Close()

                End With
        End Select


    End Sub

    Private Sub Button_2_GotFocus1(sender As Object, e As EventArgs) Handles Button_2.GotFocus
        COLOR_FOCO(Button_2, "F")
    End Sub

    Private Sub Button_2_LostFocus1(sender As Object, e As EventArgs) Handles Button_2.LostFocus
        COLOR_FOCO(Button_2, "Q")
    End Sub

    Private Sub Button_1_GotFocus1(sender As Object, e As EventArgs) Handles Button_1.GotFocus
        COLOR_FOCO(Button_1, "F")
    End Sub

    Private Sub Button_1_LostFocus1(sender As Object, e As EventArgs) Handles Button_1.LostFocus
        COLOR_FOCO(Button_1, "Q")
    End Sub

    Private Sub Button_3_GotFocus1(sender As Object, e As EventArgs) Handles Button_3.GotFocus
        COLOR_FOCO(Button_3, "F")
    End Sub

    Private Sub Button_3_LostFocus1(sender As Object, e As EventArgs) Handles Button_3.LostFocus
        COLOR_FOCO(Button_3, "Q")
    End Sub

    Private Sub Button_4_GotFocus1(sender As Object, e As EventArgs) Handles Button_4.GotFocus
        COLOR_FOCO(Button_4, "F")
    End Sub

    Private Sub Button_4_LostFocus1(sender As Object, e As EventArgs) Handles Button_4.LostFocus
        COLOR_FOCO(Button_4, "Q")
    End Sub

    Private Sub Button_5_GotFocus1(sender As Object, e As EventArgs) Handles Button_5.GotFocus
        COLOR_FOCO(Button_5, "F")
    End Sub

    Private Sub Button_5_LostFocus1(sender As Object, e As EventArgs) Handles Button_5.LostFocus
        COLOR_FOCO(Button_5, "Q")
    End Sub

    Private Sub Button_6_GotFocus1(sender As Object, e As EventArgs) Handles Button_6.GotFocus
        COLOR_FOCO(Button_6, "F")
    End Sub

    Private Sub Button_6_LostFocus1(sender As Object, e As EventArgs) Handles Button_6.LostFocus
        COLOR_FOCO(Button_6, "Q")
    End Sub

    Private Sub Button_7_GotFocus1(sender As Object, e As EventArgs) Handles Button_7.GotFocus
        COLOR_FOCO(Button_7, "F")
    End Sub

    Private Sub Button_7_LostFocus1(sender As Object, e As EventArgs) Handles Button_7.LostFocus
        COLOR_FOCO(Button_7, "Q")
    End Sub

    Private Sub Button_8_GotFocus1(sender As Object, e As EventArgs) Handles Button_8.GotFocus
        COLOR_FOCO(Button_8, "F")
    End Sub

    Private Sub Button_8_LostFocus1(sender As Object, e As EventArgs) Handles Button_8.LostFocus
        COLOR_FOCO(Button_8, "Q")
    End Sub

    Private Sub Button_9_FontChanged(sender As Object, e As EventArgs) Handles Button_9.FontChanged

    End Sub

    Private Sub Button_9_GotFocus1(sender As Object, e As EventArgs) Handles Button_9.GotFocus
        COLOR_FOCO(Button_9, "F")
    End Sub

    Private Sub Button_9_LostFocus1(sender As Object, e As EventArgs) Handles Button_9.LostFocus
        COLOR_FOCO(Button_9, "Q")
    End Sub

    Private Sub Button_0_GotFocus1(sender As Object, e As EventArgs) Handles Button_0.GotFocus
        COLOR_FOCO(Button_0, "F")
    End Sub

    Private Sub Button_0_LostFocus1(sender As Object, e As EventArgs) Handles Button_0.LostFocus
        COLOR_FOCO(Button_0, "Q")
    End Sub

    Private Sub Acceso_Numerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub Button_ENTER_GotFocus(sender As Object, e As EventArgs) Handles Button_ENTER.GotFocus
        COLOR_FOCO(Button_ENTER, "F")
    End Sub

    Private Sub Button_ENTER_LostFocus(sender As Object, e As EventArgs) Handles Button_ENTER.LostFocus
        COLOR_FOCO(Button_ENTER, "Q")
    End Sub
End Class