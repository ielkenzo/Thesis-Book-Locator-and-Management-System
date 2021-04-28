Imports MySql.Data.MySqlClient
Imports System.Data
Public Class BookInfoForm
    Public bookid As String
    Public title As String
    Public monthyr As String
    Public adviser As String
    Public critic As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Sub loadBooks(keyword As String)
        Try
            Dim dba As New MySqlDataAdapter("Select * from book_tbl where BookID like '%" & keyword & "%'", dbconn)
            Dim dbs As New DataSet
            dbs.Clear()
            dba.Fill(dbs)
            DGVBookInfo.DataSource = dbs.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub objAssign()
        bookid = Me.tbBookID.Text
        title = Me.tbThesisTitle.Text
        monthyr = CBMonth.Text & ", " & CBYear.Text
        adviser = Me.tbAdviser.Text
        critic = Me.tbCritic.Text
    End Sub
    Public Sub ClearFields(c As String)
        tbBookID.Text = c
        tbThesisTitle.Text = c
        tbAdviser.Text = c
        tbCritic.Text = c
        CBYear.Text = c
        CBMonth.Text = c
        tbPanel.Text = c
        tbResearcher.Text = c
        LBoxPanel.Items.Clear()
        LBoxResearcher.Items.Clear()
    End Sub

    Public Sub unlockControls(ByVal b As Boolean)
        tbBookID.Enabled = b
        tbThesisTitle.Enabled = b
        tbAdviser.Enabled = b
        tbCritic.Enabled = b
        CBYear.Enabled = b
        CBMonth.Enabled = b
        tbPanel.Enabled = b
        tbResearcher.Enabled = b
        LBoxPanel.Enabled = b
        LBoxResearcher.Enabled = b
    End Sub

    Public Sub insertAuthor(ByVal bkid As String, name As String)
        Try
            Dim cmd As New MySqlCommand("", dbconn)
            cmd.CommandText = "INSERT INTO author_tbl VALUES('',@bookid,@fullname)"
            cmd.Parameters.AddWithValue("@bookid", bkid)
            cmd.Parameters.AddWithValue("@fullname", name)
            dbconn.Open()
            cmd.ExecuteNonQuery()
            dbconn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub insertPanel(ByVal bkid As String, name As String)
        Try
            Dim cmd As New MySqlCommand("", dbconn)
            cmd.CommandText = "INSERT INTO panel_tbl VALUES('',@bookid,@fullname)"
            cmd.Parameters.AddWithValue("@bookid", bkid)
            cmd.Parameters.AddWithValue("@fullname", name)
            dbconn.Open()
            cmd.ExecuteNonQuery()
            dbconn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Function IsEmpty() As Boolean
        Dim c As Boolean
        If tbBookID.Text = "" Or tbAdviser.Text = "" Or tbCritic.Text = "" Or CBMonth.Text = "" Or CBYear.Text = "" Or Me.LBoxPanel.Items.Count <= 0 Or Me.LBoxResearcher.Items.Count <= 0 Then
            c = False
        Else
            c = True
        End If
        Return c
    End Function
    Private Sub BookInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.GetWorkingArea(Me).Size
        For start As Integer = Integer.Parse(Date.Now.ToString("yyyy")) To 2000 Step -1
            Me.CBYear.Items.Add(start)
        Next
        Me.ToolStripStatusLabelCount.Text = Me.DGVBookInfo.Rows.Count
        unlockControls(False)
        loadBooks("")
        BtnCancel.Enabled = False
        BtnAddSave.Enabled = False
    End Sub

    Private Sub BtnAddSave_Click(sender As Object, e As EventArgs) Handles BtnAddSave.Click
        If BtnAddSave.Text = " SAVE" Then
            If IsEmpty() = False Then
                MsgBox("Fill in all field. If not applicable, type in dash (-)", MsgBoxStyle.Exclamation)
                'MsgBox("Fill in neccessary fields!", MsgBoxStyle.Exclamation, "Error Message")
            Else
                objAssign()
                Dim cmd As New MySqlCommand("", dbconn)
                cmd.CommandText = "INSERT INTO book_tbl VALUES(@bookid,@title,@monthyr,@adviser,@critic)"
                cmd.Parameters.AddWithValue("@bookid", bookid)
                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@monthyr", monthyr)
                cmd.Parameters.AddWithValue("@adviser", adviser)
                cmd.Parameters.AddWithValue("@critic", critic)
                If MsgBox("Are you sure you want to save?", vbYesNo) = vbYes Then
                    dbconn.Open()
                    cmd.ExecuteNonQuery()
                    dbconn.Close()
                    Dim author As String = ""
                    'add Name from lbox to dbase
                    For i As Integer = 0 To LBoxResearcher.Items.Count - 1
                        author = LBoxResearcher.Items(i).ToString
                        insertAuthor(Me.tbBookID.Text, author)
                    Next

                    For x As Integer = 0 To LBoxPanel.Items.Count - 1
                        insertPanel(Me.tbBookID.Text, LBoxPanel.Items(x).ToString)
                    Next
                    MsgBox("The data has been successfully added", MsgBoxStyle.Information)

                    unlockControls(False)
                    BtnCancel.Enabled = False
                    BtnAddSave.Enabled = False
                    'dito ako nag insert ng code

                    BookLocationForm.tbBookID.Text = Me.tbBookID.Text
                    BookLocationForm.ShowDialog()
                    'ending
                    loadBooks("")
                    ClearFields("")
                    Form1.loadTotalBooks()
                    DGVBookInfo.Enabled = True
                    Me.ToolStripStatusLabelCount.Text = Me.DGVBookInfo.Rows.Count
                End If

            End If
        ElseIf BtnAddSave.Text = " UPDATE" Then
            updateBook()
            BtnAddSave.Text = " SAVE"
            unlockControls(False)
            BtnCancel.Enabled = False
            BtnAddSave.Enabled = False
            DGVBookInfo.Enabled = True
            ClearFields("")
        End If

    End Sub

    Sub updateBook()
        objAssign()
        Dim sql As String = "UPDATE book_tbl SET Title=@title, MonthYearSubmitted=@mysub, Adviser=@adviser, CriticReader=@creader where BookID=@bid;"
        Dim cmd As New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("title", Me.tbThesisTitle.Text)
        cmd.Parameters.AddWithValue("mysub", monthyr)
        cmd.Parameters.AddWithValue("adviser", Me.tbAdviser.Text)
        cmd.Parameters.AddWithValue("creader", Me.tbCritic.Text)
        cmd.Parameters.AddWithValue("bid", Me.tbBookID.Text)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
        MsgBox("Update Executed!")
        loadBooks("")
        'Load()
        'sql = ""
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If BtnAddSave.Text = " UPDATE" Then
            BtnCancel.Enabled = False
            BtnAddSave.Enabled = False
            BtnAddSave.Text = " SAVE"
            DGVBookInfo.Enabled = True
        Else
            BtnCancel.Enabled = False
            BtnAddSave.Enabled = False
            BtnAddSave.Text = " SAVE"
            DGVBookInfo.Enabled = True
            ClearFields("")
        End If



    End Sub



    Private Sub tbResearcher_KeyDown(sender As Object, e As KeyEventArgs) Handles tbResearcher.KeyDown
        If e.KeyCode = Keys.Enter Then
            If BtnAddSave.Text = " SAVE" Then
                Me.LBoxResearcher.Items.Add(Me.tbResearcher.Text.Trim())
                Me.tbResearcher.Text = ""

            ElseIf BtnAddSave.Text = " UPDATE" Then
                objAssign()
                insertAuthor(Me.tbBookID.Text, tbResearcher.Text)
                Me.LBoxResearcher.Items.Add(Me.tbResearcher.Text.Trim())
                Me.tbResearcher.Text = ""
            End If
        End If

    End Sub

    Private Sub tbPanel_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPanel.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                If BtnAddSave.Text = " SAVE" Then
                    Me.LBoxPanel.Items.Add(Me.tbPanel.Text.Trim())
                    Me.tbPanel.Text = ""
                ElseIf BtnAddSave.Text = " UPDATE" Then
                    'Dim full As String = LBoxPanel.Select 'edItem.ToString
                    objAssign()
                    insertPanel(Me.tbBookID.Text, tbPanel.Text)
                    Me.LBoxPanel.Items.Add(Me.tbPanel.Text.Trim())
                    Me.tbResearcher.Text = ""
                End If
            End If
        Catch ex As Exception
            Exit Try
        End Try


    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        loadBooks(Me.tbSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        unlockControls(True)
        ClearFields("")
        BtnCancel.Enabled = True
        BtnAddSave.Enabled = True
        DGVBookInfo.ReadOnly = True
        DGVBookInfo.Enabled = False
    End Sub

    Public Sub deletePanel(id As String)
        Dim cmd As New MySqlCommand("DELETE FROM panel_tbl where BookID=@bookid", dbconn)
        cmd.Parameters.AddWithValue("@bookid", id)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
    End Sub
    Public Sub deleteAuthor(id As String)
        Dim cmd As New MySqlCommand("DELETE FROM author_tbl where BookID=@bookid", dbconn)
        cmd.Parameters.AddWithValue("@bookid", id)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
    End Sub
    Public Sub deleteBook(id As String)
        Try
            Dim cmd As New MySqlCommand("DELETE FROM book_tbl where BookID=@bookid", dbconn)
            cmd.Parameters.AddWithValue("@bookid", id)
            dbconn.Open()
            cmd.ExecuteNonQuery()
            dbconn.Close()
            deleteAuthor(id)
            deletePanel(id)
            MsgBox("Record has been deleted", MsgBoxStyle.Information)
            loadBooks("")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DeleteBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBookToolStripMenuItem.Click
        Dim i As Integer = DGVBookInfo.CurrentRow.Index
        Dim id As String = DGVBookInfo.Item(0, i).Value
        MsgBox(id)
        deleteBook(id)
        Form1.loadTotalBooks()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = DGVBookInfo.CurrentRow.Index
        Dim id As String = DGVBookInfo.Item(0, i).Value
        MsgBox(id)
        deleteBook(id)
        Form1.loadTotalBooks()
    End Sub

    Private Sub EditBookInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditBookInformationToolStripMenuItem.Click
        unlockControls(True)
        Me.tbBookID.Enabled = False
        BtnCancel.Enabled = True
        BtnAddSave.Enabled = True
        BtnAddSave.Text = " UPDATE"
        DGVBookInfo.Enabled = False
    End Sub

    Sub loadPanel(id As String)
        Dim dba As New MySqlDataAdapter("Select * from panel_tbl where BookID='" & id & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Me.LBoxPanel.Items.Clear()

        If dbs.Tables(0).DefaultView.Count > 0 Then
            For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                Me.LBoxPanel.Items.Add(dbs.Tables(0).DefaultView.Item(i).Item("FullName").ToString)
            Next

        End If
    End Sub
    Sub loadAuthor(id As String)
        Dim dba As New MySqlDataAdapter("Select * from author_tbl where BookID='" & id & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Me.LBoxResearcher.Items.Clear()

        If dbs.Tables(0).DefaultView.Count > 0 Then
            For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                Me.LBoxResearcher.Items.Add(dbs.Tables(0).DefaultView.Item(i).Item("FullName").ToString)
            Next

        End If
    End Sub
    Private Sub DGVBookInfo_SelectionChanged(sender As Object, e As EventArgs) Handles DGVBookInfo.SelectionChanged
        Dim i As Integer = DGVBookInfo.CurrentRow.Index
        Dim id As String = DGVBookInfo.Item(0, i).Value

        Dim dba As New MySqlDataAdapter("Select * from book_tbl where BookID='" & id & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Me.tbBookID.Text = dbs.Tables(0).DefaultView.Item(0).Item("BookID").ToString
            Me.tbThesisTitle.Text = dbs.Tables(0).DefaultView.Item(0).Item("Title").ToString
            Dim moyr() As String
            moyr = dbs.Tables(0).DefaultView.Item(0).Item("MonthYearSubmitted").ToString.Split(", ")
            Me.CBMonth.SelectedItem = moyr(0)
            Me.CBYear.Text = moyr(1)
            Me.tbAdviser.Text = dbs.Tables(0).DefaultView.Item(0).Item("Adviser").ToString
            Me.tbCritic.Text = dbs.Tables(0).DefaultView.Item(0).Item("CriticReader").ToString
        End If
        loadPanel(id)
        loadAuthor(id)
    End Sub

    Private authorID As Integer
    Function getAuthorID(name As String) As Integer
        Dim authID As Integer
        Dim sql As String = "Select AuthorID from author_tbl where FullName=@fullname"
        Dim cmd As New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("fullname", Me.tbResearcher.Text)
        Dim dba As New MySqlDataAdapter(cmd)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            authID = CInt(dbs.Tables(0).DefaultView.Item(0).Item(0).ToString)
        End If
        Return authID
    End Function

    Private Sub LBoxResearcher_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LBoxResearcher.MouseDoubleClick
        Me.tbResearcher.Text = Me.LBoxResearcher.SelectedItem.ToString
        If BtnAddSave.Text = " UPDATE" Then
            authorID = getAuthorID(tbResearcher.Text)
            MsgBox(authorID)
            ResearcherModule.authorID = authorID
            ResearcherModule.tb_fullname.Text = Me.LBoxResearcher.SelectedItem.ToString
            ResearcherModule.ShowDialog()
        Else
            Me.tbResearcher.Text = Me.LBoxResearcher.SelectedItem.ToString
        End If
    End Sub

    Private panelID As Integer
    Function getPanelID(name As String) As Integer
        Dim panID As Integer
        Dim sql As String = "Select PanelNo from Panel_tbl where FullName=@fullname"
        Dim cmd As New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("fullname", Me.tbPanel.Text)
        Dim dba As New MySqlDataAdapter(cmd)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            panID = CInt(dbs.Tables(0).DefaultView.Item(0).Item("PanelNo").ToString)
        End If
        Return panID
    End Function
    Private Sub LBoxPanel_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LBoxPanel.MouseDoubleClick
        Me.tbPanel.Text = Me.LBoxPanel.SelectedItem.ToString
        If BtnAddSave.Text = " UPDATE" Then
            panelID = getPanelID(tbPanel.Text)
            PanelModule.panelid = panelID
            PanelModule.tb_fullname.Text = Me.LBoxPanel.SelectedItem.ToString
            PanelModule.Show()
        Else
            Me.tbPanel.Text = Me.LBoxPanel.SelectedItem.ToString
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        unlockControls(True)
        Me.tbBookID.Enabled = False
        BtnCancel.Enabled = True
        BtnAddSave.Enabled = True
        BtnAddSave.Text = " UPDATE"
        DGVBookInfo.Enabled = False
    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        BookLocationForm.tbBookID.Text = Me.tbBookID.Text
        BookLocationForm.ShowDialog()
    End Sub

    Private Sub DeleteAuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAuthorToolStripMenuItem.Click
        Dim fullname As String = LBoxResearcher.SelectedItem.ToString
        If MsgBox("You are about to delete this author. Are you sure of this action?", MsgBoxStyle.YesNo, "Confirm Action") = vbYes Then
            Dim cmd As New MySqlCommand("Delete from author_tbl where FullName='" & fullname & "'", dbconn)
            dbconn.Open()
            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Author selected has been remove from this book title.", MsgBoxStyle.Information, "Deleted Message")
                LBoxResearcher.Items.Remove(fullname)
            Else
                MsgBox("Warning: No Record Existed", MsgBoxStyle.Critical, "Warning Message")
            End If
            dbconn.Close()
        End If

    End Sub


End Class