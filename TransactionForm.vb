Public Class TransactionForm
    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y As Integer
        x = (Panel1.Width - Me.Label1.Width) / 2
        y = (Panel1.Height - Me.Label1.Height) / 2
        Label1.Location = New Point(x, y)
    End Sub

    Private Sub TransactionForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' this code retains the self checkout window label in the center even after maximized
        Dim x, y As Integer
        x = (Panel1.Width - Me.Label1.Width) / 2
        y = (Panel1.Height - Me.Label1.Height) / 2
        Label1.Location = New Point(x, y)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class