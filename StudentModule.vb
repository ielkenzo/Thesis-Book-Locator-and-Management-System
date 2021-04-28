Imports System.Data
Imports MySql.Data.MySqlClient
Public Class StudentModule
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Function CheckFieldValue() As Boolean
        Dim isEmpty As Boolean = False
        If Me.tbCourse.Text = "" Or Me.tbStudID.Text = "" Or tbLname.Text = "" Or tbFname.Text = "" Or tbMiddle.Text = "" Then
            isEmpty = True
        Else
            isEmpty = False
        End If
        Return isEmpty
    End Function

    Function CheckStudentID(ByVal sid As String) As Boolean
        Dim IDExist As Boolean
        Dim dba As New MySqlDataAdapter("Select studentID from borrowers_tbl where studentID='" & sid & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count = 1 Then
            IDExist = True
        Else
            IDExist = False
        End If
        Return IDExist
    End Function

    Sub addStudent()
        If CheckStudentID(Me.tbStudID.Text.Trim) = True Then
            MsgBox("You are trying to add  Student ID that has been assign to other student. Please check and try again", MsgBoxStyle.Critical, "WARNING")
        Else
            Dim cmd As New MySqlCommand("INSERT INTO borrowers_tbl VALUES(@sid,@fname,@mname,@lname,@course,CURDATE())", dbconn)
            cmd.Parameters.AddWithValue("sid", Me.tbStudID.Text.Trim)
            cmd.Parameters.AddWithValue("fname", Me.tbFname.Text.Trim)
            cmd.Parameters.AddWithValue("lname", Me.tbLname.Text.Trim)
            cmd.Parameters.AddWithValue("mname", Me.tbMiddle.Text.Trim)
            cmd.Parameters.AddWithValue("course", Me.tbCourse.Text.Trim)
            dbconn.Open()
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("You have successfully added a new record!", MsgBoxStyle.Information, "New Record Message")
            End If
            dbconn.Close()
            StudentForm.LoadStudent()
            Me.Close()
        End If

    End Sub
    Sub UpdateStudent()
        'If CheckStudentID(Me.tbStudID.Text.Trim) = True Then
        'MsgBox("You are trying to update Student ID that has been assign to other student. Please check and try again", MsgBoxStyle.Critical, "WARNING")
        'Else
        Dim cmd As New MySqlCommand("UPDATE borrowers_tbl SET FirstName=@fname,MiddleName=@mname,LastName=@lname,Course=@course WHERE studentID=@sid", dbconn)
        cmd.Parameters.AddWithValue("sid", Me.tbStudID.Text.Trim)
            cmd.Parameters.AddWithValue("fname", Me.tbFname.Text.Trim)
            cmd.Parameters.AddWithValue("lname", Me.tbLname.Text.Trim)
            cmd.Parameters.AddWithValue("mname", Me.tbMiddle.Text.Trim)
            cmd.Parameters.AddWithValue("course", Me.tbCourse.Text.Trim)
            dbconn.Open()
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("You have successfully updated the selected record!", MsgBoxStyle.Information, "Updated Record Message")
            End If
            dbconn.Close()
            StudentForm.LoadStudent()
            Me.Close()
        ' End If

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If btnSave.Text = "SAVE" Then
            If CheckFieldValue() = True Then
                MsgBox("You are trying to add record with empty field. Enter N/A if you wish to leave it blank.", MsgBoxStyle.Critical, "Warning Message")
            Else
                addStudent()
                Form1.loadTotalBorrowers()
            End If
        ElseIf btnSave.Text = "UPDATE" Then
            If CheckFieldValue() = True Then
                MsgBox("You are trying to add record with empty field. Enter N/A if you wish to leave it blank.", MsgBoxStyle.Critical, "Warning Message")

            Else
                UpdateStudent()
                Form1.loadTotalBorrowers()
            End If
        End If
    End Sub

    Private Sub StudentModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class