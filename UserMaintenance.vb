Imports System.Data
Imports MySql.Data.MySqlClient
Public Class UserMaintenance
    Private i As Integer
    Private id As Integer
    Private username As String
    Private password As String
    Private lname As String
    Private fname As String
    Private initial As String
    Private desig As String
    Private access As String
    Private Sub UserMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.GetWorkingArea(Me).Size
        LoadUser()
    End Sub

    Private Sub Panel2_Resize(sender As Object, e As EventArgs)
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



    Sub LoadUser()
        Dim dba As New MySqlDataAdapter("select * from users_tbl", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Me.DataGridView1.DataSource = dbs.Tables(0).DefaultView
    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs)
    '    If MsgBox("Are you sure you want to add this new user?", vbYesNo, "Confirmation Message") = vbYes Then
    '        Dim sql As String = "Insert into users_tbl VALUES('',@user,@pwd,@lname,@fname,@mi,@designation,@access)"
    '        Dim cmd As New MySqlCommand(sql, dbconn)
    '        cmd.Parameters.AddWithValue("user", tb_username.Text)
    '        cmd.Parameters.AddWithValue("pwd", tb_password.Text)
    '        cmd.Parameters.AddWithValue("lname", tb_lastname.Text)
    '        cmd.Parameters.AddWithValue("fname", tb_fname.Text)
    '        cmd.Parameters.AddWithValue("mi", tb_initial.Text)
    '        cmd.Parameters.AddWithValue("designation", tb_designation.Text)
    '        cmd.Parameters.AddWithValue("access", acclevel)
    '        dbconn.Open()
    '        If cmd.ExecuteNonQuery() > 0 Then
    '            MsgBox("Record added")
    '        End If
    '        dbconn.Close()
    '        LoadUser()
    '    End If
    'End Sub
    Sub clearFields(str As String)
        UsersModule.tb_username.Text = str
        UsersModule.tb_password.Text = str
        UsersModule.tb_lastname.Text = str
        UsersModule.tb_fname.Text = str
        UsersModule.tb_username.Text = str
        UsersModule.tb_username.Text = str
        UsersModule.tb_username.Text = str

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearFields("")
        UsersModule.ShowDialog()
    End Sub

    Private acclevel As Integer
    Private Sub CB_access_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If CB_access.Text = "ADMIN" Then
        '    acclevel = 1
        'ElseIf CB_access.Text = "USER" Then
        '    acclevel = 2
        'ElseIf CB_access.Text = "OTHER USER" Then
        '    acclevel = 3
        'End If
    End Sub

    'Private Sub CB_access_SelectedValueChanged(sender As Object, e As EventArgs)
    '    If CB_access.Text = "ADMIN" Then
    '        acclevel = 1
    '    ElseIf CB_access.Text = "USER" Then
    '        acclevel = 2
    '    ElseIf CB_access.Text = "OTHER USERS" Then
    '        acclevel = 3
    '    End If
    'End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public ALevel As String
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        i = Me.DataGridView1.CurrentRow.Index
        id = Me.DataGridView1.Item(0, i).Value
        username = Me.DataGridView1.Item(1, i).Value
        password = Me.DataGridView1.Item(2, i).Value
        lname = Me.DataGridView1.Item(3, i).Value
        fname = Me.DataGridView1.Item(4, i).Value
        initial = Me.DataGridView1.Item(5, i).Value
        desig = Me.DataGridView1.Item(6, i).Value
        access = Me.DataGridView1.Item(7, i).Value


        UsersModule.tb_username.Text = username
        UsersModule.tb_password.Text = password
        UsersModule.tb_lastname.Text = lname
        UsersModule.tb_fname.Text = fname
        UsersModule.tb_initial.Text = initial
        UsersModule.tb_designation.Text = desig
        If access = 1 Then
            UsersModule.CB_access.Text = "ADMIN"
            ALevel = "ADMIN"
        ElseIf access = 2 Then
            UsersModule.CB_access.Text = "USER"
            ALevel = "USER"
        ElseIf access = 3 Then
            UsersModule.CB_access.Text = "OTHER USER"
            ALevel = "OTHER USER"
        End If
        'MsgBox(password)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UsersModule.btn_save.Text = "Update"
        If ALevel = "ADMIN" Then
            UsersModule.accLevel = 1
        ElseIf ALevel = "USER" Then
            UsersModule.accLevel = 2
        ElseIf ALevel = "OTHER USER" Then
            UsersModule.accLevel = 3
        End If
        UsersModule.uid = id
        UsersModule.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("You are about to delete a record with linked transactions record. Would you like to continue this action?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
            If MsgBox("You need to enter Administrative credentials to continue with this action", MsgBoxStyle.OkCancel) = vbOK Then
                Dim cmd As New MySqlCommand("DELETE FROM users_tbl where UserID=" & id & "", dbconn)
                dbconn.Open()
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Record deleted Successfully!", MsgBoxStyle.Information)
                End If
                dbconn.Close()
                LoadUser()
            End If
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim sql As String
            sql = "SELECT * FROM users_tbl where LastName like @lname or FirstName like @fname or Designation like @des or Username like @user"
            Dim cmd As New MySqlCommand(sql, dbconn)
            cmd.Parameters.AddWithValue("lname", "%" + TextBox7.Text + "%")
            cmd.Parameters.AddWithValue("fname", "%" + TextBox7.Text + "%")
            cmd.Parameters.AddWithValue("user", "%" + TextBox7.Text + "%")
            cmd.Parameters.AddWithValue("des", "%" + TextBox7.Text + "%")
            Dim dba As New MySqlDataAdapter(cmd)
            Dim dbs As New DataSet
            dbs.Reset()
            dba.Fill(dbs)
            DataGridView1.DataSource = dbs.Tables(0).DefaultView
        End If
        '
    End Sub
End Class