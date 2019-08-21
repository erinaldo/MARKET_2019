Public Class Ver_Detalle_Comite
    Public FI As String
    Public FF As String
    Public DESC As String
    Public TIPO As String

    Dim COL_TOTAL As Integer = 1

    Private Sub Ver_Detalle_Comite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub VER_DETALLE()

        LLENAR_GRID(C1_PRECIOS, "EXEC VER_DETALLE_COMITE '" & FI & "','" & FF & "','" & TIPO & "','" & DESC & "'", CAD_CON)
        Dim FIL As Integer
        Dim TOT As Double
        For FIL = 1 To C1_PRECIOS.Rows.Count - 1
            TOT = TOT + C1_PRECIOS.Item(FIL, COL_TOTAL)
        Next
        Me.TXT_TOTAL.Text = FORMAT_DECIMALES(TOT, 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class