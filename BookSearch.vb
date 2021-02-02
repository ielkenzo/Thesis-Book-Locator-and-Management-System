Imports System.Data
Imports MySql.Data.MySqlClient
Public Class BookSearch
    Public WithEvents btn As Button

    Public BookID As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label2.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Function countColumn(row As Integer) As Integer
        Dim dba As New MySqlDataAdapter("select COUNT(ColumnNo) from booklocation_tbl where RowNo=" & row & " and ShelfCode='SHELF1';", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Dim count As Integer
        If dbs.Tables(0).DefaultView.Count > 0 Then
            count = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
        Else
            count = 0
        End If
        Return count
    End Function
    Sub genShelf(x As Integer)
        'Dim dba As New MySqlDataAdapter("")
        Try
            Dim i, j As Integer
            For i = 0 To x - 1
                ' Dim counter As Integer = countColumn(i + 1)
                ' Dim dba As New MySqlDataAdapter("SELECT * FROM books_view where BookID IN (SELECT BookID from booklocation_tbl where ShelfCode IN(select ShelfCode from booklocation_tbl) AND RowNo=" & i + 1 & ");", dbconn)
                Dim dba As New MySqlDataAdapter("SELECT * FROM books_view where BookID IN (SELECT BookID from booklocation_tbl where ShelfCode IN(select ShelfCode from booklocation_tbl where ShelfCode='SHELF1') AND RowNo=" & i + 1 & ") Order by Location;", dbconn)
                Dim dbs As New DataSet
                dbs.Reset()
                dba.Fill(dbs)

                Dim title As String = ""
                Dim loc As String = ""
                Dim ccount As Integer = dbs.Tables(0).DefaultView.Count
                ' MsgBox(ccount)
                If dbs.Tables(0).DefaultView.Count > 0 Then
                    For a As Integer = 0 To ccount - 1
                        BookID = dbs.Tables(0).DefaultView.Item(a).Item("BookID").ToString
                        title = dbs.Tables(0).DefaultView.Item(a).Item("Title").ToString
                        loc = dbs.Tables(0).DefaultView.Item(a).Item("Location").ToString
                        Dim btn As New Button
                        With btn
                            .Name = "btn" & i & j
                            .Width = 15
                            .Height = 75
                            '.Text = title
                            '.BackColor = Color.Red
                            .FlatStyle = FlatStyle.Flat
                            .FlatAppearance.BorderSize = 0
                            .ForeColor = Color.White
                            .Visible = True
                            .BackgroundImage = Image.FromFile(Application.StartupPath & "/red.png")
                            .BackgroundImageLayout = ImageLayout.Stretch
                            .Tag = "BookID: " & BookID & vbCrLf & " Book Title:" & title & vbCrLf & "Location: " & loc
                        End With

                        flp.Controls.Add(btn)
                        AddHandler btn.Click, AddressOf btn_click

                        If a.Equals(ccount - 1) Then
                            flp.SetFlowBreak(btn, True)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub btn_click(sender As Object, e As EventArgs)
        Dim bkid() As String
        bkid = sender.tag.ToString.Split(" ")
        BookID = bkid(1)
        Dim dba As New MySqlDataAdapter()
        dba = New MySqlDataAdapter("Select BookID, Title from book_tbl where BookID='" & BookID.Trim & "'", dbconn)
        Dim dbs As New DataSet
        dbs.Clear()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            BookDetails.lblBookID.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
            BookDetails.lblTitle.Text = dbs.Tables(0).DefaultView.Item(0).Item("Title").ToString
        End If

        dba = New MySqlDataAdapter("Select * from author_tbl where BookID='" & BookID.Trim & "'", dbconn)
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            BookDetails.ListBox1.Items.Clear()

            For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                BookDetails.ListBox1.Items.Add(dbs.Tables(0).DefaultView.Item(i).Item("FullName").ToString)
            Next
        End If

        dba = New MySqlDataAdapter("Select ShelfCode,RowNo,ColumnNo from booklocation_tbl where BookID='" & BookID.Trim & "'", dbconn)
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            BookDetails.lblShelfcode.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
            BookDetails.lblshelfrow.Text = dbs.Tables(0).DefaultView.Item(0).Item(1).ToString
            BookDetails.lblshelfcol.Text = dbs.Tables(0).DefaultView.Item(0).Item(2).ToString
        End If
        BookDetails.ShowDialog()

    End Sub


    Private Sub BookSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        genShelf(3)
        Me.Timer1.Enabled = True
        Dim x, y As Integer
        x = (Me.Panel1.Width - Me.Label1.Width) / 2
        y = (Me.Panel1.Height - Me.Label1.Height) / 2
        Me.Label1.Location = New Point(x, y)

        Dim x1, y1, x2, y2 As Integer
        x1 = (Panel3.Width - Me.Label3.Width) / 2
        y1 = (Panel3.Height - Me.Label3.Height) / 2
        x2 = (Panel3.Width - Me.tbSearchBook.Width) / 2
        y2 = (Panel3.Height - Me.tbSearchBook.Height) / 2

        Me.Label3.Location = New Point(x1, 26)
        Me.tbSearchBook.Location = New Point(x2, 57)

        Dim xx As Integer
        xx = (Panel8.Width - Me.Label5.Width) / 2
        Me.Label5.Location = New Point(xx, 18)
    End Sub

    Private Sub BookSearch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x, y As Integer
        x = (Me.Panel1.Width - Me.Label1.Width) / 2
        y = (Me.Panel1.Height - Me.Label1.Height) / 2
        Me.Label1.Location = New Point(x, y)

        Dim x1, y1, x2, y2 As Integer
        x1 = (Panel3.Width - Me.Label3.Width) / 2
        y1 = (Panel3.Height - Me.Label3.Height) / 2
        x2 = (Panel3.Width - Me.tbSearchBook.Width) / 2
        y2 = (Panel3.Height - Me.tbSearchBook.Height) / 2

        Me.Label3.Location = New Point(x1, 26)
        Me.tbSearchBook.Location = New Point(x2, 57)

        Dim xx As Integer
        xx = (Panel8.Width - Me.Label5.Width) / 2
        Me.Label5.Location = New Point(xx, 18)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tbSearchBook_TextChanged(sender As Object, e As EventArgs) Handles tbSearchBook.TextChanged
        If tbSearchBook.TextLength <= 0 Then
            resetColor()
        Else
            resetColor()
            For Each x As String In searchBook(Me.tbSearchBook.Text)
                If x <> "" Then
                    searching(x)
                End If

            Next
        End If
    End Sub

    Function searchBook(id As String) As String()
        Dim dba As New MySqlDataAdapter("Select distinct BookID, Title from searchbook_view where Title like '%" & id & "%' or AuthorName like '%" & id & "%'", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        Dim i As Integer
        Dim ids() As String = {}
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim cnt As Integer = dbs.Tables(0).DefaultView.Count
            ids = New String(cnt) {}
            For i = 0 To dbs.Tables(0).DefaultView.Count - 1
                ids(i) = dbs.Tables(0).DefaultView.Item(i).Item(1).ToString
            Next
        End If
        Return ids
    End Function
    Private Sub tbSearchBook_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearchBook.KeyDown
        If e.KeyCode = Keys.Enter Then
            If searchBook(Me.tbSearchBook.Text).Length > 0 Then
                If MsgBox("There are " & searchBook(Me.tbSearchBook.Text).Length - 1 & "records found" & vbCrLf & "Would you like to see them all?", MsgBoxStyle.YesNo) = vbYes Then
                    'searching(searchBook(Me.tbSearchBook.Text))
                    resetColor()
                    For Each x As String In searchBook(Me.tbSearchBook.Text)
                        If x <> "" Then
                            searching(x)
                        End If

                    Next
                End If
            End If

           
        End If
    End Sub

    Sub resetColor()

        For i As Integer = 0 To flp.Controls.Count - 1
            flp.Controls.Item(i).BackgroundImage = Nothing
            flp.Controls.Item(i).BackgroundImage = Image.FromFile(Application.StartupPath & "/red.png")
        Next

    End Sub
    Sub searching(title As String)
        'Try
        ' If tbSearchBook.TextLength > 0 Then
        ' resetColor()
        Dim x As Integer = flp.Controls.Count
        For i As Integer = 0 To x - 1
            Try
                If flp.Controls.Item(i).Tag.ToString.Contains(title) Then
                    flp.Controls.Item(i).BackgroundImage = Image.FromFile(Application.StartupPath & "/green.png")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Next

    End Sub
End Class