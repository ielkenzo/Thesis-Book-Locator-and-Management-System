Imports MySql.Data.MySqlClient
Imports System.Data
Public Class UserLogin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim sql As String = "Select * from users_tbl where Username=@uname and Password=@pw"
        Dim cmd As New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("@uname", Me.tbusername.Text)
        cmd.Parameters.AddWithValue("@pw", Me.tbpassword.Text)

        Dim dba As New MySqlDataAdapter(cmd)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)

        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim uname, pw As String
            uname = dbs.Tables(0).DefaultView.Item(0).Item(1).ToString
            pw = dbs.Tables(0).DefaultView.Item(0).Item(2).ToString
            acclevel = dbs.Tables(0).DefaultView.Item(0).Item(7).ToString
            If uname = tbusername.Text And pw = tbpassword.Text And acclevel = 1 Then
                'MsgBox("match")
                Me.Hide()
                Form1.Show()
            ElseIf uname = tbusername.Text And pw = tbpassword.Text And acclevel = 3 Then
                Me.Hide()
                BorrowersMenu.WindowState = FormWindowState.Maximized
                BorrowersMenu.Show()
            End If
        Else
            MsgBox("Username and Password did not match!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Function checkUserCount() As Integer
        Dim counter As Integer
        Dim dba As New MySqlDataAdapter("Select count(*) from users_tbl", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        counter = dbs.Tables(0).DefaultView.Count

        Return counter
    End Function

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cnt As Integer = checkUserCount()
        If cnt = 0 Then
            MsgBox("No records")
        End If

    End Sub

    Private Sub tbpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login_Click(sender, e)
        End If

    End Sub
End Class