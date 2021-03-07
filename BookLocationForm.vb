
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class BookLocationForm


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Sub loadBookLocation(id As String)
        Try
            Dim dba As New MySqlDataAdapter("select * from booklocation_tbl where BookID like'%" & id & "%'", dbconn)
            Dim dbs As New DataSet
            dbs.Clear()
            dba.Fill(dbs)
            DGVBookLocation.DataSource = dbs.Tables(0).DefaultView
        Catch ex As Exception

        End Try
    End Sub

    Sub lockControls(a As Boolean)
        Me.btnSave.Enabled = a
        btnCancel.Enabled = a
        tbBookID.Enabled = a
        cbShelfCode.Enabled = a
        cbShelfCol.Enabled = a
        cbShelfRow.Enabled = a
        cbStatus.Enabled = a
    End Sub

    Sub ClearFields(c As String)
        tbBookID.Text = c
        cbShelfCode.Text = c
        cbShelfCol.Text = c
        cbShelfRow.Text = c
        cbStatus.Text = c
    End Sub

    Private Sub BookLocationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadBookLocation("")
        lockControls(False)
        loadShelfColumn()
        If tbBookID.Text <> "" Then
            btnNew_Click(sender, e)
            tbBookID.Text = BookInfoForm.tbBookID.Text
            TextBox2.Text = BookInfoForm.tbBookID.Text
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lockControls(True)
        ClearFields("")
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        Me.tbBookID.Focus()
    End Sub

    Sub loadShelfColumn()
        Dim dba As New MySqlDataAdapter("select * from columndummy WHERE columnNo NOT IN (Select ColumnNo from booklocation_tbl where ShelfCode='" & cbShelfCode.Text & "' and RowNo=" & Val(cbShelfRow.Text) & ");", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Me.cbShelfCol.Items.Clear()
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim col As Integer
            For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                col = dbs.Tables(0).DefaultView.Item(i).Item(0).ToString
                Me.cbShelfCol.Items.Add(col)
            Next
        End If



    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bookid, shelfcode, shelfrow, shelfcol, status As String
        bookid = Me.tbBookID.Text
        shelfcode = cbShelfCode.Text
        shelfrow = cbShelfRow.Text
        shelfcol = Me.cbShelfCol.Text
        status = cbStatus.Text

        If tbBookID.Text = "" Or cbShelfCode.Text = "" Or cbShelfCol.Text = "" Or cbShelfRow.Text = "" Or cbStatus.Text = "" Then
            MsgBox("Fill in the fields", MsgBoxStyle.Critical, "Required Fields")
        Else

            Dim cmd As New MySqlCommand("", dbconn)
            If btnSave.Text = "SAVE" Then
                cmd.CommandText = "INSERT INTO booklocation_tbl VALUES('',@bookid,@shelf,@row,@col,@status)"
                cmd.Parameters.AddWithValue("@bookid", bookid)
                cmd.Parameters.AddWithValue("@shelf", shelfcode)
                cmd.Parameters.AddWithValue("@row", shelfrow)
                cmd.Parameters.AddWithValue("@col", shelfcol)
                cmd.Parameters.AddWithValue("@status", status)
                dbconn.Open()
                cmd.ExecuteNonQuery()
                dbconn.Close()

                lockControls(False)
                ClearFields("")
                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                loadBookLocation("")
                MsgBox("New Book Location Added Successfully", MsgBoxStyle.Information, "Insert Prompt")
            ElseIf btnSave.Text = "UPDATE" Then
                cmd.CommandText = "UPDATE booklocation_tbl SET ShelfCode=@shelf, RowNo=@row,ColumnNo=@col,Status=@status WHERE BookID=@bookid"
                cmd.Parameters.AddWithValue("@bookid", bookid)
                cmd.Parameters.AddWithValue("@shelf", shelfcode)
                cmd.Parameters.AddWithValue("@row", shelfrow)
                cmd.Parameters.AddWithValue("@col", shelfcol)
                cmd.Parameters.AddWithValue("@status", status)
                dbconn.Open()
                cmd.ExecuteNonQuery()
                dbconn.Close()

                lockControls(False)
                ClearFields("")
                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                loadBookLocation("")
                Form1.loadCheckedIn()
                MsgBox("The Book Location of this book has been updated", MsgBoxStyle.Information, "Update Prompt")
                btnSave.Text = "SAVE"

            End If

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        lockControls(False)
        ClearFields("")
        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub tbBookID_TextChanged(sender As Object, e As EventArgs) Handles tbBookID.TextChanged

    End Sub


    Function checkBookID(id As String) As Boolean
        Dim dba As New MySqlDataAdapter("SELECT BookID from booklocation_tbl where BookID ='" & id & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Dim bidExist As Boolean = False
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim bid As String

            bid = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
            If bid = tbBookID.Text Then
                bidExist = True
            Else
                bidExist = False
            End If
        End If
        Return bidExist
    End Function
    Private Sub tbBookID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBookID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkBookID(Me.tbBookID.Text) = True Then
                MsgBox("The Book ID has been assigned already!", MsgBoxStyle.Exclamation)
                Me.tbBookID.Text = ""
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        loadBookLocation(Me.TextBox2.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = DGVBookLocation.CurrentRow.Index
        Dim id As String = DGVBookLocation.Item(0, i).Value
        Try
            If MsgBox("You are about to delete this record and once deleted it cannot no longer be retrieved?", MsgBoxStyle.YesNo) = vbYes Then
                Dim cmd As New MySqlCommand("DELETE FROM booklocation_tbl where LocationID=" & id, dbconn)
                dbconn.Open()
                cmd.ExecuteNonQuery()
                dbconn.Close()
                MsgBox("Book Location Deleted", MsgBoxStyle.Information)
                loadBookLocation("")

            End If
            Form1.loadCheckedIn()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbShelfRow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbShelfRow.SelectedIndexChanged
        loadShelfColumn()
    End Sub

    Private Sub cbShelfRow_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbShelfRow.SelectedValueChanged
        loadShelfColumn()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        lockControls(True)
        ClearFields("")
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        Me.tbBookID.ReadOnly = True
        Me.btnSave.Text = "UPDATE"
        Dim i As Integer = DGVBookLocation.CurrentRow.Index
        tbBookID.Text = DGVBookLocation.Item(1, i).Value
        cbShelfCode.Text = DGVBookLocation.Item(2, i).Value
        cbShelfRow.Text = DGVBookLocation.Item(3, i).Value
        cbShelfCol.Text = DGVBookLocation.Item(4, i).Value
        cbStatus.Text = DGVBookLocation.Item(5, i).Value
    End Sub

    Private Sub TSMdelete_Click(sender As Object, e As EventArgs) Handles TSMdelete.Click
        Dim i As Integer = DGVBookLocation.CurrentRow.Index
        Dim id As String = DGVBookLocation.Item(0, i).Value

        Try
            If MsgBox("You are about to delete this record and once deleted it cannot no longer be retrieved?", MsgBoxStyle.YesNo) = vbYes Then
                Dim cmd As New MySqlCommand("DELETE FROM booklocation_tbl where LocationID=" & id, dbconn)
                dbconn.Open()
                cmd.ExecuteNonQuery()
                dbconn.Close()
                MsgBox("Book Location Deleted", MsgBoxStyle.Information)
                loadBookLocation("")

            End If
            Form1.loadCheckedIn()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TSMEdit_Click(sender As Object, e As EventArgs) Handles TSMEdit.Click
        lockControls(True)
        ClearFields("")
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        Me.tbBookID.ReadOnly = True
        Me.btnSave.Text = "UPDATE"
        Dim i As Integer = DGVBookLocation.CurrentRow.Index
        tbBookID.Text = DGVBookLocation.Item(1, i).Value
        cbShelfCode.Text = DGVBookLocation.Item(2, i).Value
        cbShelfRow.Text = DGVBookLocation.Item(3, i).Value
        cbShelfCol.Text = DGVBookLocation.Item(4, i).Value
        cbStatus.Text = DGVBookLocation.Item(5, i).Value

    End Sub


End Class