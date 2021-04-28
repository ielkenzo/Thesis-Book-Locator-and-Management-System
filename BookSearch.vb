Imports System.Data
Imports MySql.Data.MySqlClient
Public Class BookSearch
    Public WithEvents btn As Button
    Private dba As MySqlDataAdapter
    Private dbs As DataSet
    Public BookID As String
    'Public Sub btn_click(sender As Object, e As EventArgs)
    '    Dim bkid() As String
    '    bkid = sender.tag.ToString.Split(" ")
    '    BookID = bkid(1)
    '    Dim dba As New MySqlDataAdapter()
    '    dba = New MySqlDataAdapter("Select BookID, Title, Adviser from book_tbl where BookID='" & BookID.Trim & "'", dbconn)
    '    Dim dbs As New DataSet
    '    dbs.Clear()
    '    dba.Fill(dbs)
    '    If dbs.Tables(0).DefaultView.Count > 0 Then
    '        BookDetails.lblBookID.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
    '        BookDetails.lblTitle.Text = dbs.Tables(0).DefaultView.Item(0).Item("Title").ToString
    '        BookDetails.lbl_adviser.Text = dbs.Tables(0).DefaultView.Item(0).Item("Adviser").ToString
    '    End If

    '    dba = New MySqlDataAdapter("Select * from author_tbl where BookID='" & BookID.Trim & "'", dbconn)
    '    dbs.Reset()
    '    dba.Fill(dbs)
    '    If dbs.Tables(0).DefaultView.Count > 0 Then
    '        'BookDetails.ListBox1.Items.Clear()
    '        BookDetails.lbl_author.Text = ""
    '        For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
    '            '  BookDetails.ListBox1.Items.Add(dbs.Tables(0).DefaultView.Item(i).Item("FullName").ToString)
    '            BookDetails.lbl_author.Text &= dbs.Tables(0).DefaultView.Item(i).Item("FullName").ToString & vbCrLf
    '        Next
    '    End If

    '    dba = New MySqlDataAdapter("Select ShelfCode,RowNo,ColumnNo from booklocation_tbl where BookID='" & BookID.Trim & "'", dbconn)
    '    dbs.Reset()
    '    dba.Fill(dbs)
    '    If dbs.Tables(0).DefaultView.Count > 0 Then
    '        BookDetails.lblShelfcode.Text = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString
    '        BookDetails.lblshelfrow.Text = dbs.Tables(0).DefaultView.Item(0).Item(1).ToString
    '        BookDetails.lblshelfcol.Text = dbs.Tables(0).DefaultView.Item(0).Item(2).ToString
    '    End If
    '    BookDetails.ShowDialog()

    'End Sub


    Private Sub BookSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayBooks(4)
        Me.Size = Screen.GetWorkingArea(Me).Size
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

        'Dim xbtn As Integer
        'xbtn = (Panel3.Width - Me.btn_search.Width) / 2
        'Me.btn_search.Location = New Point(xbtn, 42)
        Me.Label3.Location = New Point(x1, 26)
        Me.tbSearchBook.Location = New Point(x2, 57)

        Dim xx As Integer
        xx = (Panel8.Width - Me.Label5.Width) / 2
        Me.Label5.Location = New Point(xx, 18)


    End Sub



    'Private Sub tbSearchBook_TextChanged(sender As Object, e As EventArgs) Handles tbSearchBook.TextChanged
    '    If tbSearchBook.Text = Nothing Then
    '        resetColor()
    '    Else
    '        Dim colz() As String = searchBookTitle(tbSearchBook.Text.Trim)
    '        If colz.Count > 0 Then
    '            resetColor()
    '            For x As Integer = 0 To colz.Count - 1
    '                searchbook(colz(x))
    '            Next
    '        Else
    '            MsgBox("No result found")
    '            resetColor()
    '        End If

    '    End If
    'End Sub

    'Function searchBook(id As String) As String()
    '    Dim dba As New MySqlDataAdapter("Select distinct BookID, Title from searchbook_view where Title like '%" & id & "%' or AuthorName like '%" & id & "%'", dbconn)
    '    Dim dbs As New DataSet
    '    dbs.Reset()
    '    dba.Fill(dbs)
    '    Dim i As Integer
    '    Dim ids() As String = {}
    '    If dbs.Tables(0).DefaultView.Count > 0 Then
    '        Dim cnt As Integer = dbs.Tables(0).DefaultView.Count
    '        ids = New String(cnt) {}
    '        For i = 0 To dbs.Tables(0).DefaultView.Count - 1
    '            ids(i) = dbs.Tables(0).DefaultView.Item(i).Item(1).ToString
    '        Next
    '    End If
    '    Return ids
    'End Function
    Private Sub tbSearchBook_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearchBook.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbSearchBook.Text = Nothing Then
                resetColor()
            Else
                Dim colz() As String = searchBookTitle(tbSearchBook.Text.Trim)
                If colz.Count > 0 Then
                    resetColor()
                    For x As Integer = 0 To colz.Count - 1
                        searchbook(colz(x))
                    Next
                Else
                    MsgBox("No result found")
                    resetColor()
                End If

            End If

        End If
    End Sub

    'Sub resetColor()

    '    For i As Integer = 0 To flp.Controls.Count - 1
    '        flp.Controls.Item(i).BackgroundImage = Nothing
    '        flp.Controls.Item(i).BackgroundImage = Image.FromFile(Application.StartupPath & "/red.png")
    '    Next

    'End Sub
    Sub searching(title As String)

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

    ' generate book here
    Sub DisplayBooks(row As Integer)
        For i As Integer = 1 To row
            ' Dim dba As New MySqlDataAdapter("select ColumnNo, IF(ColumnNo in(SELECT ColumnNo from booklocation_tbl where RowNo=" & i & "),'YES','NO') as ExistStat from column_tbl", dbc)
            Dim dba As New MySqlDataAdapter("select ColumnNo, if(ColumnNo IN(SELECT ColumnNo from booksview where RowNo=" & i & "), 'Exists','Not Exists') AS Located FROM column_tbl;", dbconn)

            Dim dbs As New DataSet
            dbs.Reset()
            dba.Fill(dbs)
            If dbs.Tables(0).DefaultView.Count > 0 Then
                Dim stat As String
                Dim rw As Integer = i
                Dim ctr As Integer = 0
                For j As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                    stat = dbs.Tables(0).DefaultView.Item(j).Item(1).ToString
                    Dim btn As New Button
                    Dim splt As New Splitter
                    If stat.Equals("Exists") Then
                        With btn
                            .Name = "book" & j + 1 & "_" & i
                            .Height = 125
                            .Width = 19
                            .FlatStyle = FlatStyle.Flat
                            .FlatAppearance.BorderSize = 0
                            .BackgroundImage = Image.FromFile(Application.StartupPath & "/red.png")
                            .BackgroundImageLayout = ImageLayout.Stretch
                            .Tag = i & "-" & dbs.Tables(0).DefaultView.Item(j).Item(0).ToString
                        End With
                    ElseIf stat.Equals("Not Exists") Then
                        With btn
                            .Name = "book-null" & j + 1
                            .Height = 125
                            .Width = 19
                            .FlatStyle = FlatStyle.Flat
                            .FlatAppearance.BorderSize = 0
                            .BackgroundImage = Image.FromFile(Application.StartupPath & "/gray.png")
                            .BackgroundImageLayout = ImageLayout.Stretch
                            .Tag = "NULL"
                            .Enabled = False
                            '.Tag = dbs.Tables(0).DefaultView.Item(j).Item(0).ToString
                        End With
                    End If

                    flp.Controls.Add(btn)
                    ctr = ctr + 1
                    If ctr = 20 Or ctr = 40 Then
                        With splt
                            .BackColor = Color.Black
                            .BorderStyle = BorderStyle.FixedSingle
                            .Tag = "black"
                        End With
                        flp.Controls.Add(splt)
                    End If
                    AddHandler btn.Click, AddressOf btn_Click
                    If j.Equals(dbs.Tables(0).DefaultView.Count - 1) Then
                        flp.SetFlowBreak(btn, True)
                        ctr = 0
                    End If
                Next

            End If

        Next
    End Sub

    Public Sub btn_Click(sender As Object, e As EventArgs)
        Dim msg() As String = sender.Tag.ToString.Split("-")
        Dim bookID As String = getBookID(msg(1).Trim, msg(0).Trim)
        'MsgBox(bookID)
        dba = New MySqlDataAdapter("Select * from book_tbl where BookID='" & bookID & "'", dbconn)
        dbs = New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim Title As String = dbs.Tables(0).DefaultView.Item(0).Item(1).ToString
            Dim DateSubmitted As String = dbs.Tables(0).DefaultView.Item(0).Item(2).ToString
            Dim Adviser As String = dbs.Tables(0).DefaultView.Item(0).Item(3).ToString
            Dim Critic As String = dbs.Tables(0).DefaultView.Item(0).Item(4).ToString

            BookDetails.lblBookID.Text = bookID
            BookDetails.lblTitle.Text = Title
            BookDetails.lbl_adviser.Text = Adviser

        End If
        'retrieving author's names 
        dba = New MySqlDataAdapter("Select * from author_tbl where BookID='" & bookID & "'", dbconn)
        dbs = New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim researchers As String = ""
            For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                researchers = dbs.Tables(0).DefaultView.Item(i).Item("FullName").ToString & vbCrLf
            Next
            BookDetails.lbl_author.Text = researchers
        End If

        'get coordinates
        dba = New MySqlDataAdapter("Select * from booklocation_tbl where BookID='" & bookID & "'", dbconn)
        dbs = New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            Dim col As String = dbs.Tables(0).DefaultView.Item(0).Item("ColumnNo").ToString
            Dim row As String = dbs.Tables(0).DefaultView.Item(0).Item("RowNo").ToString
            Dim shelf As String = dbs.Tables(0).DefaultView.Item(0).Item("ShelfCode").ToString
            Dim status As String = dbs.Tables(0).DefaultView.Item(0).Item("Status").ToString
            BookDetails.lblShelfcode.Text = shelf
            BookDetails.lblshelfcol.Text = col
            BookDetails.lblshelfrow.Text = row
            BookDetails.status.Text = status
        End If

        BookDetails.ShowDialog()
    End Sub

    Function getBookID(col As Integer, row As Integer) As String
        Dim bid As String = ""
        Dim dba As New MySqlDataAdapter("Select BookID, Title, ShelfCode, RowNo, ColumnNo from booksview where ColumnNo=" & col & " and RowNo=" & row, dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)
        If dbs.Tables(0).DefaultView.Count > 0 Then
            bid = dbs.Tables(0).DefaultView.Item(0).Item(0).ToString

        End If
        Return bid
    End Function


    'this part take the coordinate of book location
    Function searchBookTitle(title As String) As String()
        Dim dba As New MySqlDataAdapter("select CONCAT_WS('-',RowNo,ColumnNo) as Location, BookID, Title from booksview where Title like '%" & title & "%';", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)

        Dim x As Integer = dbs.Tables(0).DefaultView.Count
        Dim cols(x - 1) As String
        If dbs.Tables(0).DefaultView.Count > 0 Then
            For i As Integer = 0 To x - 1
                cols(i) = dbs.Tables(0).DefaultView.Item(i).Item(0).ToString
            Next
        End If
        Return cols
    End Function

    'reset the color searches
    Sub resetColor()

        For i As Integer = 0 To flp.Controls.Count - 1
            flp.Controls.Item(i).BackgroundImage = Nothing
            If flp.Controls.Item(i).Tag.ToString.Equals("NULL") Then
                flp.Controls.Item(i).BackgroundImage = Image.FromFile(Application.StartupPath & "/gray.png")
            Else
                flp.Controls.Item(i).BackgroundImage = Image.FromFile(Application.StartupPath & "/red.png")
            End If

        Next
    End Sub

    Sub searchbook(keyword As String)
        Dim x As Integer = flp.Controls.Count
        If x > 0 Then
            Try
                For i As Integer = 0 To x - 1
                    If flp.Controls.Item(i).Tag.ToString.Equals(keyword) Then
                        flp.Controls.Item(i).BackgroundImage = Image.FromFile(Application.StartupPath & "/green.png")
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub


End Class