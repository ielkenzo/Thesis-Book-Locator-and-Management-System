Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("Are your sure you want to Logout?", vbYesNo) = vbYes Then
            Me.Close()
            UserLogin.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadTotalBooks()
        loadCheckedIn()
        loadCheckedOut()
        loadTotalBorrowers()
    End Sub

    Sub loadCheckedIn()
        Dim dba As New MySqlDataAdapter("Select count(*) from booklocation_tbl where Status='Available'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            lbl_checkedIn.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
        End If
    End Sub
    Sub loadCheckedOut()
        Dim dba As New MySqlDataAdapter("Select count(*) from booklocation_tbl where Status='Checked Out'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            lbl_checkOut.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
        End If
    End Sub

    Sub loadTotalBooks()
        Dim dba As New MySqlDataAdapter("Select count(*) from book_tbl", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            lbl_totalbook.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
        End If
    End Sub

    Sub loadTotalBorrowers()
        Try
            Dim dba As New MySqlDataAdapter("Select count(*) from borrowers_tbl", dbconn)
            Dim dbs As New DataSet
            dbs.Reset()
            dba.Fill(dbs)
            If dbs.Tables(0).DefaultView.Count > 0 Then
                lbl_borrower.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.ToString)
        End Try

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

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        BookSearch.StartPosition = FormStartPosition.CenterParent
        BookSearch.WindowState = FormWindowState.Maximized
        BookSearch.ShowDialog()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
    '    
    'End Sub
End Class
