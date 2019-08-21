Public Class View_Doc
    Private Sub View_Doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.RichTextBox1.LoadFile("C:\TEMP\temp.txt", RichTextBoxStreamType.PlainText)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class