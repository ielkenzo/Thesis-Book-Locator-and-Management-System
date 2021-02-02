Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lbl_timer.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.IsMdiContainer = True
        'Me.MdiParent.Enabled = True
        StudentForm.StartPosition = FormStartPosition.CenterParent
        StudentForm.WindowState = FormWindowState.Maximized
        StudentForm.ShowDialog()
    End Sub

    Private Sub btnBookMaintenance_Click(sender As Object, e As EventArgs) Handles btnBookMaintenance.Click
        BookInfoForm.StartPosition = FormStartPosition.CenterParent
        BookInfoForm.WindowState = FormWindowState.Maximized
        BookInfoForm.ShowDialog()
    End Sub

    Private Sub btnSystemUser_Click(sender As Object, e As EventArgs) Handles btnSystemUser.Click
        UserMaintenance.StartPosition = FormStartPosition.CenterParent
        UserMaintenance.WindowState = FormWindowState.Maximized
        UserMaintenance.ShowDialog()
    End Sub

    Private Sub btnBookLocation_Click(sender As Object, e As EventArgs) Handles btnBookLocation.Click
        BookLocationForm.StartPosition = FormStartPosition.CenterParent
        BookLocationForm.WindowState = FormWindowState.Maximized
        BookLocationForm.ShowDialog()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Refresh()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
    '    
    'End Sub
End Class
