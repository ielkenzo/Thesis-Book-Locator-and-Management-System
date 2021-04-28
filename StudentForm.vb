Imports System.Data
Imports MySql.Data.MySqlClient
Public Class StudentForm

    Sub ClearFields()

    End Sub
    Dim i As Integer
    Dim studID As String
    Dim lname, fname, mname As String
    Dim course As String
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
    '    Me.Close()
    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        StudentModule.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub LoadStudent()
        Dim dba As New MySqlDataAdapter("Select * from borrowers_tbl ORDER BY YearAdmitted DESC", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        DGV_studentinfo.DataSource = dbs.Tables(0).DefaultView
        lbl_totalRecord.Text = DGV_studentinfo.Rows.Count
    End Sub
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudent()
        Me.Size = Screen.GetWorkingArea(Me).Size
    End Sub

    Private Sub DGV_studentinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_studentinfo.CellContentClick

    End Sub

    Private Sub EditInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditInformationToolStripMenuItem.Click
        StudentModule.tbStudID.Text = studID
        StudentModule.tbStudID.Enabled = False
        StudentModule.tbFname.Text = fname
        StudentModule.tbMiddle.Text = mname
        StudentModule.tbLname.Text = lname
        StudentModule.tbCourse.Text = course
        StudentModule.ShowDialog()
    End Sub



    Private Sub ContextMenuStrip1_DoubleClick(sender As Object, e As EventArgs) Handles ContextMenuStrip1.DoubleClick
        StudentModule.tbStudID.Text = studID
        StudentModule.tbStudID.Enabled = False
        StudentModule.tbFname.Text = fname
        StudentModule.tbMiddle.Text = mname
        StudentModule.tbLname.Text = lname
        StudentModule.tbCourse.Text = course
        StudentModule.btnSave.Text = "UPDATE"
        StudentModule.ShowDialog()
    End Sub

    Private Sub TS_btnEDIT_Click(sender As Object, e As EventArgs) Handles TS_btnEDIT.Click
        StudentModule.tbStudID.Text = studID
        StudentModule.tbStudID.Enabled = False
        StudentModule.tbFname.Text = fname
        StudentModule.tbMiddle.Text = mname
        StudentModule.tbLname.Text = lname
        StudentModule.tbCourse.Text = course
        StudentModule.btnSave.Text = "UPDATE"
        StudentModule.ShowDialog()
    End Sub

    Private Sub TSBtnDelete_Click(sender As Object, e As EventArgs) Handles TSBtnDelete.Click
        If MsgBox("You are trying to delete a record link to other record" & vbCrLf & "You need to enter admin credentials to do it." & vbCrLf & "Would you like to continue?", MsgBoxStyle.YesNo) = vbYes Then
            Admin_Credentials.userid = studID
            Admin_Credentials.tbpass.Text = ""
            Admin_Credentials.tbusername.Text = ""
            Admin_Credentials.ShowDialog()
        End If
    End Sub

    Private Sub DeleteInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteInformationToolStripMenuItem.Click
        If MsgBox("You are trying to delete a record link to other record" & vbCrLf & "You need to enter admin credentials to do it." & vbCrLf & "Would you like to continue?", MsgBoxStyle.YesNo) = vbYes Then
            Admin_Credentials.userid = studID
            Admin_Credentials.tbpass.Text = ""
            Admin_Credentials.tbusername.Text = ""
            Admin_Credentials.ShowDialog()
        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim cmd As New MySqlCommand("Select * from borrowers_tbl where studentID=@search or LastName like @lname or FirstName like @fname ORDER BY YearAdmitted DESC", dbconn)
        cmd.Parameters.AddWithValue("search", tbSearch.Text.Trim)
        cmd.Parameters.AddWithValue("lname", "%" & tbSearch.Text.Trim & "%")
        cmd.Parameters.AddWithValue("fname", "%" & tbSearch.Text.Trim & "%")
        Dim dba As New MySqlDataAdapter(cmd)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        DGV_studentinfo.DataSource = dbs.Tables(0).DefaultView
        lbl_totalRecord.Text = DGV_studentinfo.Rows.Count
    End Sub

    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
    '    
    'End Sub

    Private Sub DGV_studentinfo_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_studentinfo.SelectionChanged
        Try
            i = DGV_studentinfo.CurrentRow.Index
            studID = DGV_studentinfo.Item(0, i).Value
            lname = DGV_studentinfo.Item(3, i).Value
            fname = DGV_studentinfo.Item(1, i).Value
            mname = DGV_studentinfo.Item(2, i).Value
            course = DGV_studentinfo.Item(4, i).Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGV_studentinfo_DoubleClick(sender As Object, e As EventArgs) Handles DGV_studentinfo.DoubleClick
        StudentModule.tbStudID.Text = studID
        StudentModule.tbStudID.Enabled = False
        StudentModule.tbFname.Text = fname
        StudentModule.tbMiddle.Text = mname
        StudentModule.tbLname.Text = lname
        StudentModule.tbCourse.Text = course
        StudentModule.btnSave.Text = "UPDATE"
        StudentModule.ShowDialog()
    End Sub
End Class