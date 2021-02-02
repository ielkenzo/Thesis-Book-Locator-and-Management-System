Public Class UserMaintenance
    Private Sub UserMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Resize(sender As Object, e As EventArgs) Handles Panel2.Resize
        Dim x, y As Integer
        x = (Me.Panel2.Width - Me.PictureBox1.Width) / 2
        y = (Me.Panel2.Height - Me.PictureBox1.Height) / 2

        Me.PictureBox1.Location = New Point(x, y)
    End Sub

    Private Sub UserMaintenance_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Dim x, y As Integer
        'x = (Me.Panel2.Width - Me.PictureBox1.Width) / 2
        '' y = (Me.Panel2.Height - Me.PictureBox1.Height) / 2

        'Me.PictureBox1.Location = New Point(x, 15)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class