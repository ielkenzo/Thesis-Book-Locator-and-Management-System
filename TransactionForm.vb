Imports System.Data
Imports MySql.Data.MySqlClient
Public Class TransactionForm
    Private subID As Integer
    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.GetWorkingArea(Me).Size
        Dim x, y As Integer
        x = (Panel1.Width - Me.Label1.Width) / 2
        y = (Panel1.Height - Me.Label1.Height) / 2
        Label1.Location = New Point(x, y)
        'tb_rfidQR.Enabled = False
        'Me.btn_remove.Enabled = False
        'Me.btn_add.Enabled = False

        'Me.btnDone.Enabled = False

        loadCheckoutList()
    End Sub

    Private Sub TransactionForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' this code retains the self checkout window label in the center even after maximized
        Dim x, y As Integer
        x = (Panel1.Width - Me.Label1.Width) / 2
        y = (Panel1.Height - Me.Label1.Height) / 2
        Label1.Location = New Point(x, y)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub


    Private Sub tb_studentID_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_studentID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cmd As New MySqlCommand("Select CONCAT(LastName, ' ', FirstName, ', ', MiddleName) as FullName from borrowers_tbl where studentID=@sid", dbconn)
            cmd.Parameters.AddWithValue("sid", tb_studentID.Text)
            Dim dba As New MySqlDataAdapter(cmd)
            Dim dbs As New DataSet
            dbs.Reset()
            dba.Fill(dbs)
            If dbs.Tables(0).DefaultView.Count > 0 Then
                Me.lbl_fullname.Text = dbs.Tables(0).DefaultView.Item(0).Item("FullName").ToString
                Me.lbl_fullname.ForeColor = Color.FromArgb(72, 219, 251)
                tb_rfidQR.Enabled = True
                tb_studentID.Enabled = False
                btn_add_Click(sender, e)
            Else
                MsgBox("Student ID does not exist. Enter and try again.", MsgBoxStyle.OkCancel, "Invalid ID Message")
            End If


        End If
    End Sub

    Private Sub tb_rfidQR_TextChanged(sender As Object, e As EventArgs) Handles tb_rfidQR.TextChanged

    End Sub

    Private Sub tb_rfidQR_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_rfidQR.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cmd As New MySqlCommand("select Title  from book_tbl where BookID=@bid", dbconn)
            cmd.Parameters.AddWithValue("bid", tb_rfidQR.Text)
            Dim dba As New MySqlDataAdapter(cmd)
            Dim dbs As New DataSet
            dbs.Reset()
            dba.Fill(dbs)
            If dbs.Tables(0).DefaultView.Count > 0 Then
                Me.lbl_bookTitle.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
                Me.lbl_bookTitle.ForeColor = Color.FromArgb(72, 219, 251)

            End If
        End If
    End Sub
    '
    Sub loadCheckoutList()
        Dim dba As New MySqlDataAdapter("select subtrans,BookID,Title,DateBorrowed from checkoutlist_view where TransactionID=(select max(TransactionID) from transaction_tbl) and studentID='" & tb_studentID.Text & "';", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        DataGridView1.DataSource = dbs.Tables(0).DefaultView
    End Sub

    Function checkIfOut(bid As String) As Boolean
        Dim isOut As Boolean
        Dim dba As New MySqlDataAdapter("select Status from booklocation_tbl where BookID='" & bid & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            If dbs.Tables(0).DefaultView.Item(0).Item(0).ToString = "CHECKED OUT" Then
                isOut = True
                ' MsgBox("This book is in checkout status. Please check the QR code value and try again.")
            End If
        End If
        Return isOut
    End Function

    Function CheckIfInList(bid As String) As Boolean
        Dim inList As Boolean
        If DataGridView1.Rows.Count > 0 Then
            Dim countr As Integer = DataGridView1.Rows.Count
            For i As Integer = 0 To countr - 1
                If DataGridView1.Item(1, i).Value.ToString = Me.tb_rfidQR.Text Then
                    inList = True
                    ' MsgBox("The book you are adding is already in your list. Please try another book")
                End If
            Next
        End If
        Return inList
    End Function
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "START" Then
            'If Me.tb_studentID.Text = "" Then
            '    MsgBox("Please enter detail on the textboxes", MsgBoxStyle.Critical, "Warning Message")
            'Else
            Dim cmd As New MySqlCommand("INSERT INTO transaction_tbl VALUES('',NULL,@curdate)", dbconn)
            'cmd.Parameters.AddWithValue("sid", tb_studentID.Text)
            cmd.Parameters.AddWithValue("curdate", Now.ToString("yyyy-MM-dd"))
            dbconn.Open()
            cmd.ExecuteNonQuery()
            dbconn.Close()
            'End If
            btn_add.Text = "ADD TO LIST"
            Me.btn_remove.Enabled = True
            Me.btn_add.Enabled = True
            Me.btnDone.Enabled = True
        ElseIf btn_add.Text = "ADD TO LIST" Then
            '       Me.tb_studentID.Text = "" Or
            If Me.tb_rfidQR.Text = "" Then
                MsgBox("Please enter detail on the textboxes", MsgBoxStyle.Critical, "Warning Message")
            ElseIf checkIfOut(tb_rfidQR.Text) = True Then
                MsgBox("This book is in checkout status. Please check the QR code value and try again.", MsgBoxStyle.Critical, "Warning")
            ElseIf CheckIfInList(tb_rfidQR.Text) = True Then
                MsgBox("The book you are adding is already in your list. Please try another book", MsgBoxStyle.Critical, "Warning")
            Else
                Dim cmd As New MySqlCommand("insert into subtransaction_tbl(subtrans,TransactionID,BookID,DateBorrowed) values('',(select max(TransactionID) from transaction_tbl),@bid,@curdate);", dbconn)
                cmd.Parameters.AddWithValue("bid", tb_rfidQR.Text)
                cmd.Parameters.AddWithValue("curdate", Now.ToString("yyyy-MM-dd"))
                dbconn.Open()
                cmd.ExecuteNonQuery()
                dbconn.Close()
                loadCheckoutList()
            End If
            Me.tb_rfidQR.Text = ""
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        MsgBox(subID)
        Dim cmd As New MySqlCommand("DELETE FROM subtransaction_tbl where subtrans=" & subID, dbconn)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
        MsgBox("Book removed from the list", MsgBoxStyle.Information, "Confirmation Message")
        loadCheckoutList()
    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        subID = CInt(DataGridView1.Item(0, i).Value)
    End Sub



    Sub updateStatus(BID As String)
        Dim cmd As New MySqlCommand("UPDATE booklocation_tbl SET Status='CHECKED OUT' where BookID='" & BID & "'", dbconn)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Dim bookID As String =
        Dim bookCheckout As String = ""
        If DataGridView1.Rows.Count > 0 Then
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim bookid As String = DataGridView1.Item(1, i).Value
                updateStatus(bookid)
                'bookCheckout &= bookid & vbCrLf
            Next
            'MsgBox(bookCheckout)
            MsgBox("Checkout Successful.")
            Me.Close()
        Else
            MsgBox("Sorry no book/s is/are checkout.", vbCritical)
        End If

    End Sub


End Class