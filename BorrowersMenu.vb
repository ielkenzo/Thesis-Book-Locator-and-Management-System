Public Class BorrowersMenu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.LBL_datetime.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub BorrowersMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = Screen.GetWorkingArea(Me).Size
        Me.Timer1.Enabled = True
        Dim x As Integer = (Me.Panel9.Width - Me.Label5.Width) / 2
        Dim y As Integer = (Me.Panel9.Height - Me.Label5.Height) / 2
        Label5.Location = New Point(x, y)
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
        Dim x As Integer = (Me.Panel9.Width - Me.Label5.Width) / 2
        Dim y As Integer = (Me.Panel9.Height - Me.Label5.Height) / 2
        Label5.Location = New Point(x, y)
        ' newPosition(Me.Width, Me.Panel2.Width)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Private Sub PB_searchBook_Click(sender As Object, e As EventArgs) Handles PB_searchBook.Click
        BookSearch.StartPosition = FormStartPosition.CenterParent
        BookSearch.WindowState = FormWindowState.Maximized
        BookSearch.Show()
    End Sub

    Private Sub PB_checkout_Click(sender As Object, e As EventArgs) Handles PB_checkout.Click
        TransactionForm.StartPosition = FormStartPosition.Manual
        TransactionForm.WindowState = FormWindowState.Normal
        TransactionForm.Show()
    End Sub

    Private Sub PB_checkin_Click(sender As Object, e As EventArgs) Handles PB_checkin.Click
        With CheckInForm
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
        'CheckInForm.Show()
    End Sub
End Class