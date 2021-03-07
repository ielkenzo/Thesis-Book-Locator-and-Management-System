Imports System.Data
Imports MySql.Data.MySqlClient
Public Class PanelModule
    Public panelid As Integer

    Sub updatePanel()
        Dim sql As String = "update panel_tbl set FullName=@fullname where PanelNo=@panID"
        Dim cmd As New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("fullname", tb_fullname.Text)
        cmd.Parameters.AddWithValue("panID", panelid)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
    End Sub
    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        updatePanel()
        BookInfoForm.LBoxPanel.Items.Remove(BookInfoForm.tbPanel.Text)
        BookInfoForm.LBoxPanel.Items.Add(tb_fullname.Text)
        BookInfoForm.tbPanel.Text = ""
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class