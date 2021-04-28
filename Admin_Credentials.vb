Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Admin_Credentials
    Private cmd As MySqlCommand
    Public userid As String

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim dba As New MySqlDataAdapter("Select Username, Password from users_tbl where Username='" & Me.tbusername.Text.Trim & "' and Password='" & tbpass.Text.Trim & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim user, pass As String
            user = dbs.Tables(0).DefaultView.Item(0).Item("Username").ToString
            pass = dbs.Tables(0).DefaultView.Item(0).Item("Password").ToString

            If user = tbusername.Text And pass = tbpass.Text Then
                cmd = New MySqlCommand("delete from borrowers_tbl where studentID=@sid", dbconn)
                cmd.Parameters.AddWithValue("sid", userid)
                dbconn.Open()
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "Delete Confimation Message")
                End If

                userid = ""
                StudentForm.LoadStudent()
                Form1.loadTotalBorrowers()
                Me.Close()
            Else
                MsgBox("username and password mismatched", MsgBoxStyle.Critical, "Delete Confimation Message")
            End If
            MsgBox("record does not exist!", MsgBoxStyle.Critical, "Delete Confimation Message")
        Else
            MsgBox("record does not exist!", MsgBoxStyle.Critical, "Delete Confimation Message")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class