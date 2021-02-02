Public Class BorrowersMenu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.LBL_datetime.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub BorrowersMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Timer1.Enabled = True
    End Sub



    Private Sub newPosition(cntl1 As Integer, cntl2 As Integer)
        'Dim x, y As Integer
        'x = (cntl1 - cntl2) / 2
        'Dim p As New Panel
        'With p
        '    .Name = "Panel2"
        '    .Location = New Point(x, Me.Panel2.Height)
        'End With
    End Sub

    Private Sub BorrowersMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        newPosition(Me.Width, Me.Panel2.Width)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub
End Class