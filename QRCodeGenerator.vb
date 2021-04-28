
Imports MySql.Data.MySqlClient
Imports ThoughtWorks.QRCode.Codec
Public Class QRCodeGenerator
    Private Sub btn_qrcode_Click(sender As Object, e As EventArgs) Handles btn_qrcode.Click
        Dim lastcode As Integer = CInt(txt_lastqrcode.Text)
        Dim ctr As Integer = 0

        For i As Integer = CInt(txt_firstqrcode.Text) To lastcode Step 1
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
                Label3.Text = "QRCODE is being created... please wait"
                ctr = ctr + 1
            Catch ex As Exception
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
        Dim cmd As New MySqlCommand("insert into qrcode_tbl VALUES('',@bid,@qrcode)", dbc)
        cmd.Parameters.AddWithValue("bid", bid)
        cmd.Parameters.AddWithValue("qrcode", arrImage)
        dbc.Open()
        cmd.ExecuteNonQuery()
        dbc.Close()
    End Sub

    Private Sub btn_lastQRCode_Click(sender As Object, e As EventArgs) Handles btn_lastQRCode.Click
        Dim sql As String = "select substring(max(BookID),10,4) as lastNumber from qrcode_tbl;"
        Dim cmd As New MySqlCommand(sql, dbconn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet
        ds.Reset()
        da.Fill(ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            Me.txt_firstqrcode.Text = CInt(ds.Tables(0).DefaultView.Item(0).Item(0).ToString)
        Else
            MsgBox("No record found")
        End If

    End Sub

    Private Sub btn_printQR_Click(sender As Object, e As EventArgs) Handles btn_printQR.Click

        Dim dba As New MySqlDataAdapter("select BookID,QRCode from qrcode_tbl", dbconn)
        Dim ds As New DataSet
        ds.Reset()
        dba.Fill(ds, "dsQRCode")
        Dim rpt As New rptQRCode
        rpt.Load(Application.StartupPath & "\Reports\rptQRCode.rpt")
        rpt.SetDataSource(ds.Tables("dsQRCode"))
        PrintQRCode.CrystalReportViewer1.ReportSource = rpt
        PrintQRCode.CrystalReportViewer1.Refresh()
        PrintQRCode.ShowDialog()
    End Sub
End Class