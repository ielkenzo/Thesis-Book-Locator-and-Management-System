Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class UsersModule

    Private username As String
    Private pword As String
    Private lname As String
    Private fname As String
    Private initial As String
    Private designation As String
    Private access As String
    Public uid As Integer
    'Holds Hash Bytes Returned From Database
    Dim StoredHash As Byte() = Nothing

    'Holds Hash Bytes From Current User Password Attempt
    Dim UserHash As Byte() = Nothing
    Public Function GetSHA1PasswordHash(Password As String) As Byte()

        'Self Explanitory
        Dim SHA1_CSP As New SHA1CryptoServiceProvider()
        Return SHA1_CSP.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password))

    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        username = tb_username.Text.Trim
        pword = tb_password.Text.Trim
        lname = tb_lastname.Text.Trim
        fname = tb_fname.Text.Trim
        initial = tb_initial.Text.Trim
        designation = tb_designation.Text.Trim
        access = CB_access.Text.Trim

        If username = "" Or pword = "" Or lname = "" Or fname = "" Or initial = "" Or designation = "" Or access = "" Then
            MsgBox("You are attempting to save with some fields null. Write N/A if you wish to leave it blank.", MsgBoxStyle.Exclamation, "Warning")
        Else
            If btn_save.Text = "Save" Then
                Dim sql As String = "INSERT INTO users_tbl VALUES('',@user,@pwd,@lname,@fname,@init,@designation,@access)"
                Dim cmd As New MySqlCommand(sql, dbconn)
                cmd.Parameters.AddWithValue("user", username)
                cmd.Parameters.AddWithValue("pwd", pword)
                cmd.Parameters.AddWithValue("lname", lname)
                cmd.Parameters.AddWithValue("fname", fname)
                cmd.Parameters.AddWithValue("init", initial)
                cmd.Parameters.AddWithValue("designation", designation)
                cmd.Parameters.AddWithValue("access", accLevel)
                dbconn.Open()

                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Record has been added to Database", MsgBoxStyle.Information, "Confirmation")
                End If
                dbconn.Close()
                UserMaintenance.LoadUser()
                Me.Close()

            ElseIf btn_save.Text = "Update" Then
                Dim sql As String = "UPDATE users_tbl SET Username=@user,Password=@pass,LastName=@lname,FirstName=@fname,Designation=@designation,AccessLevel=@level where UserID=@uid"
                Dim cmd As New MySqlCommand(sql, dbconn)
                cmd.Parameters.AddWithValue("user", username)
                cmd.Parameters.AddWithValue("pass", pword)
                cmd.Parameters.AddWithValue("lname", lname)
                cmd.Parameters.AddWithValue("fname", fname)
                cmd.Parameters.AddWithValue("init", initial)
                cmd.Parameters.AddWithValue("designation", designation)
                cmd.Parameters.AddWithValue("level", accLevel)
                cmd.Parameters.AddWithValue("uid", uid)
                dbconn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Record has been Updated from the database", MsgBoxStyle.Information, "Confirmation")
                    dbconn.Close()
                    UserMaintenance.LoadUser()
                    Me.Close()
                Else
                    MsgBox("No record was modified", MsgBoxStyle.Information, "Confirmation")
                    dbconn.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Public accLevel As Integer
    Private Sub CB_access_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_access.SelectedIndexChanged
        If Me.CB_access.Text = "ADMIN" Then
            accLevel = 1
        ElseIf Me.CB_access.Text = "USER" Then
            accLevel = 2
        ElseIf Me.CB_access.Text = "OTHER USER" Then
            accLevel = 3
        End If
    End Sub

    Private Sub UsersModule_Load(sender As Object, e As EventArgs) Handles Me.Load
        StoredHash = GetSHA1PasswordHash("ADMIN")
    End Sub
End Class