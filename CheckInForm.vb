Imports System.Data
Imports MySql.Data.MySqlClient
Public Class CheckInForm
    Private ds As New DataSet
    Private da As New MySqlDataAdapter
    Private cmd As New MySqlCommand
    Private sql As String
    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = (Me.Panel4.Width - Me.Label1.Width) / 2
        Me.Label1.Location = New Point(x, 7)
        Dim x2 As Integer = (Me.Panel3.Width - Me.Label2.Width) / 2
        Me.Label2.Location = New Point(x2, 28)
        Dim x3 As Integer = (Me.Panel3.Width - Me.Label3.Width) / 2
        Me.Label3.Location = New Point(x3, 51)
        Dim x4 As Integer = (Me.Panel1.Width - Me.Label4.Width) / 2
        Me.Label4.Location = New Point(x4, 8)
    End Sub

    Sub loadbookDetails(bookid As String)
        sql = "Select BookID, Title from book_tbl where BookID=@bid"
        cmd = New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("bid", bookid)
        da = New MySqlDataAdapter(cmd)
        ds.Reset()
        da.Fill(ds)
        If ds.Tables(0).DefaultView.Count = 1 Then
            lbl_bookID.Text = ds.Tables(0).DefaultView.Item(0).Item(0).ToString
            lbl_Title.Text = ds.Tables(0).DefaultView.Item(0).Item(1).ToString
        Else
            MsgBox("No record match!", vbCritical)
        End If
    End Sub
    Sub bookLocDetails(bookid As String)
        sql = "Select ShelfCode,RowNo, ColumnNo from booklocation_tbl where BookID=@bid"
        cmd = New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("bid", bookid)
        da = New MySqlDataAdapter(cmd)
        ds.Reset()
        da.Fill(ds)
        If ds.Tables(0).DefaultView.Count = 1 Then
            lbl_shelf.Text = "Shelf # : " & ds.Tables(0).DefaultView.Item(0).Item(0).ToString
            lbl_row.Text = "Shelf Row : " & ds.Tables(0).DefaultView.Item(0).Item(1).ToString
            lbl_column.Text = "Shelf Column : " & ds.Tables(0).DefaultView.Item(0).Item(2).ToString
        Else
            MsgBox("No record match!", vbCritical)

        End If
    End Sub

    Sub getLastBorrower(bid As String)
        sql = "select transaction_tbl.TransactionID, transaction_tbl.StudentID ,CONCAT(borrowers_tbl.LastName, ',',borrowers_tbl.FirstName) as FullName
from transaction_tbl INNER JOIN borrowers_tbl on transaction_tbl.StudentID=borrowers_tbl.studentID
where TransactionID=(select TransactionID from subtransaction_tbl where BookID=@bid and DateReturned IS NULL);"
        cmd = New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("bid", bid)
        da = New MySqlDataAdapter(cmd)
        ds.Reset()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            lbl_name.Text = ds.Tables(0).DefaultView.Item(0).Item(2).ToString
        Else
            MsgBox("This book is currently available and is not out. Check your BookID or SCAN the QR Code", vbExclamation)
            lbl_name.Text = "No Name Matched"
        End If
    End Sub

    Sub loadReturnGV(bid As String)
        sql = "SELECT
                subtransaction_tbl.subtrans,
                subtransaction_tbl.BookID,
                book_tbl.Title,
                subtransaction_tbl.DateBorrowed,
                subtransaction_tbl.DateReturned,
                subtransaction_tbl.TransactionID
                FROM
                subtransaction_tbl
                INNER JOIN transaction_tbl ON transaction_tbl.TransactionID = subtransaction_tbl.TransactionID
                INNER JOIN book_tbl ON subtransaction_tbl.BookID = book_tbl.BookID
                WHERE subtransaction_tbl.BookID=@bid and DateReturned IS NULL"
        cmd = New MySqlCommand(sql, dbconn)
        cmd.Parameters.AddWithValue("bid", bid)
        da = New MySqlDataAdapter(cmd)
        ds.Reset()
        da.Fill(ds)
        DGV_return.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub txt_qrcodeScan_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qrcodeScan.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadbookDetails(txt_qrcodeScan.Text)
            getLastBorrower(txt_qrcodeScan.Text)
            bookLocDetails(txt_qrcodeScan.Text)
            loadReturnGV(txt_qrcodeScan.Text)
        End If
    End Sub

    Private Sub CheckInForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = (Me.Panel4.Width - Me.Label1.Width) / 2
        Me.Label1.Location = New Point(x, 7)
        Dim x2 As Integer = (Me.Panel3.Width - Me.Label2.Width) / 2
        Me.Label2.Location = New Point(x2, 28)
        Dim x3 As Integer = (Me.Panel3.Width - Me.Label3.Width) / 2
        Me.Label3.Location = New Point(x3, 51)
        Dim x4 As Integer = (Me.Panel1.Width - Me.Label4.Width) / 2
        Me.Label4.Location = New Point(x4, 8)
    End Sub

    Private Sub btn_doneReturn_Click(sender As Object, e As EventArgs) Handles btn_doneReturn.Click
        Dim bookid As String = ""
        If DGV_return.Rows.Count > 0 Then
            For i As Integer = 0 To DGV_return.Rows.Count - 1
                bookid = DGV_return.Item(1, i).Value
                Dim id As Integer = DGV_return.Item(0, i).Value
                sql = "UPDATE subtransaction_tbl set DateReturned=@curdate where subtrans=@id;
                       UPDATE booklocation_tbl set status='AVAILABLE' where BookID=@bid;"
                cmd = New MySqlCommand(sql, dbconn)
                cmd.Parameters.AddWithValue("curdate", Now.ToString("yyyy-mm-dd"))
                cmd.Parameters.AddWithValue("bid", bookid)
                cmd.Parameters.AddWithValue("id", id)
                dbconn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("updated", vbInformation)
                End If
                dbconn.Close()
            Next
        End If
    End Sub
End Class