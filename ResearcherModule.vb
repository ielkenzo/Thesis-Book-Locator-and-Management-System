Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ResearcherModule

    Public authorID As Integer
    Sub updateAuthor()
        Dim sql As String = "update author_tbl set FullName=@fullname where authorID=@authID"
        Dim cmd As New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("fullname", tb_fullname.Text)
        cmd.Parameters.AddWithValue("authID", authorID)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
    End Sub
    Private Sub ResearcherModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        updateAuthor()
        BookInfoForm.LBoxResearcher.Items.Remove(BookInfoForm.tbResearcher.Text)
        BookInfoForm.LBoxResearcher.Items.Add(tb_fullname.Text)
        BookInfoForm.tbResearcher.Text = ""
        Me.Close()
    End Sub
End Class