Imports System.Data
Imports MySql.Data.MySqlClient
Public Class UserMaintenance
    Private Sub UserMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Resize(sender As Object, e As EventArgs) Handles Panel2.Resize
        'Dim x, y As Integer
        'x = (Me.Panel2.Width - Me.PictureBox1.Width) / 2
        'y = (Me.Panel2.Height - Me.PictureBox1.Height) / 2

        'Me.PictureBox1.Location = New Point(118, y)
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Sub LoadUser()
        Dim dba As New MySqlDataAdapter("select * from users_tbl", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Me.DataGridView1.DataSource = dbs.Tables(0).DefaultView
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Are you sure you want to add this new user?", vbYesNo, "Confirmation Message") = vbYes Then
            Dim sql As String = "Insert into users_tbl VALUES('',@user,@pwd,@lname,@fname,@mi,@designation,@access)"
            Dim cmd As New MySqlCommand(sql, dbconn)
            cmd.Parameters.AddWithValue("user", tb_username.Text)
            cmd.Parameters.AddWithValue("pwd", tb_password.Text)
            cmd.Parameters.AddWithValue("lname", tb_lastname.Text)
            cmd.Parameters.AddWithValue("fname", tb_fname.Text)
            cmd.Parameters.AddWithValue("mi", tb_initial.Text)
            cmd.Parameters.AddWithValue("designation", tb_designation.Text)
            cmd.Parameters.AddWithValue("access", acclevel)
            dbconn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Record added")
            End If
            dbconn.Close()
            LoadUser()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub

    Private acclevel As Integer
    Private Sub CB_access_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_access.SelectedIndexChanged
        'If CB_access.Text = "ADMIN" Then
        '    acclevel = 1
        'ElseIf CB_access.Text = "USER" Then
        '    acclevel = 2
        'ElseIf CB_access.Text = "OTHER USER" Then
        '    acclevel = 3
        'End If
    End Sub

    Private Sub CB_access_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_access.SelectedValueChanged
        If CB_access.Text = "ADMIN" Then
            acclevel = 1
        ElseIf CB_access.Text = "USER" Then
            acclevel = 2
        ElseIf CB_access.Text = "OTHER USERS" Then
            acclevel = 3
        End If
    End Sub
End Class