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
            If uname = tbusername.Text And pw = tbpassword.Text Then
                'MsgBox("match")
                Me.Hide()
                Form1.Show()
            End If
        Else
            MsgBox("Username and Password did not match!")
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class