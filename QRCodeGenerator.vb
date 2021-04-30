
Imports MySql.Data.MySqlClient
Imports ThoughtWorks.QRCode.Codec
Public Class QRCodeGenerator
    Private Sub btn_qrcode_Click(sender As Object, e As EventArgs) Handles btn_qrcode.Click

        Dim ctr As Integer = 0
        Dim start As Integer = getLastQRCode()
        Dim lastcode As Integer = CInt(txt_lastqrcode.Text) + start
        MsgBox("start: " & start & "  lastcode: " & lastcode)

        For i As Integer = start + 1 To lastcode Step 1
            Dim abbrev As String = "SLSU-CPE-"
            If i < 10 Then
                abbrev &= "000" & i
            ElseIf i < 100 Then
                abbrev &= "00" & i
            ElseIf i < 1000 Then
                abbrev &= "0" & i
            ElseIf i < 10000 Then
                abbrev &= i
            ElseIf i >= 10000 Then
                'uepstr = ""
                Exit For
            End If
            Dim QRCode As New QRCodeEncoder
            QRCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            QRCode.QRCodeBackgroundColor = Color.White
            QRCode.QRCodeForegroundColor = Color.Black
            QRCode.QRCodeVersion = 7
            QRCode.QRCodeVersion = 4
            QRCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
            Dim picImg As Image = QRCode.Encode(abbrev)
            PictureBox1.Image = picImg
            PictureBox1.Refresh()
            Try
                qrcodeAdd(abbrev, PictureBox1.Image)
                'Label3.Text = "QRCODE is being created... please wait"
                ctr = ctr + 1
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("Your are trying to generate " & abbrev & " which already exist on the database.", vbCritical)
            End Try
        Next
        MsgBox("Successfully created " & ctr & " QRCodes")


    End Sub
    Sub qrcodeAdd(bid As String, ByVal image As Image)
        Dim ms As New System.IO.MemoryStream
        image = PictureBox1.Image
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage As Byte() = ms.ToArray

        Dim dbc As New MySqlConnection("server=localhost;user=root;pwd=;database=bookfinder")
        Dim cmd As New MySqlCommand("insert into qrcode_tbl VALUES('',@bid,@qrcode,NULL)", dbc)
        cmd.Parameters.AddWithValue("bid", bid)
        cmd.Parameters.AddWithValue("qrcode", arrImage)
        dbc.Open()
        cmd.ExecuteNonQuery()
        dbc.Close()
    End Sub

    Function getLastQRCode() As Integer
        Dim lastQR As Integer = 0
        Try
            Dim sql As String = "select substring(max(BookID),10,4) as lastNumber from qrcode_tbl;"
            Dim cmd As New MySqlCommand(sql, dbconn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            ds.Reset()
            da.Fill(ds)
            If ds.Tables(0).DefaultView.Count > 0 Then
                lastQR = CInt(ds.Tables(0).DefaultView.Item(0).Item(0).ToString)
            Else
                MsgBox("No record found")
            End If
        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.ToString)
        End Try
        Return lastQR
    End Function

    Private Sub btn_lastQRCode_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btn_printQR_Click(sender As Object, e As EventArgs) Handles btn_printQR.Click
        Try
            Dim dba As New MySqlDataAdapter
            If cb_selectToPrint.Text = "All" Then
                dba = New MySqlDataAdapter("select BookID,QRCode from qrcode_tbl", dbconn)
            ElseIf cb_selectToPrint.Text = "AVAILABLE" Then
                dba = New MySqlDataAdapter("select BookID,QRCode from qrcode_tbl where Status IS NULL", dbconn)
            ElseIf cb_selectToPrint.Text = "USED" Then
                dba = New MySqlDataAdapter("select BookID,QRCode from qrcode_tbl where Status IN('USED','Used')", dbconn)
            Else
                MsgBox("Please select an option", MsgBoxStyle.Exclamation)
            End If

            Dim ds As New DataSet
            ds.Reset()
            dba.Fill(ds, "dsQRCode")
            Dim rpt As New rptQRCode
            rpt.Load(Application.StartupPath & "\Reports\rptQRCode.rpt")
            rpt.SetDataSource(ds.Tables("dsQRCode"))
            Me.CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try

        'PrintQRCode.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QRCodeGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Size = Screen.GetWorkingArea(Me).Size
    End Sub
End Class