Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim n As Integer
        While n <> 5
            n += 1

            MessageBox.Show(n)

        End While
        MessageBox.Show("Now out of Loop")
    End Sub
End Class
