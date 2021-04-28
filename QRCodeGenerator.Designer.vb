<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRCodeGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_firstqrcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_lastqrcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_qrcode = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_lastQRCode = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_printQR = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Start of QR Code"
        '
        'txt_firstqrcode
        '
        Me.txt_firstqrcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_firstqrcode.DefaultText = ""
        Me.txt_firstqrcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_firstqrcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_firstqrcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstqrcode.DisabledState.Parent = Me.txt_firstqrcode
        Me.txt_firstqrcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstqrcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstqrcode.FocusedState.Parent = Me.txt_firstqrcode
        Me.txt_firstqrcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_firstqrcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstqrcode.HoverState.Parent = Me.txt_firstqrcode
        Me.txt_firstqrcode.Location = New System.Drawing.Point(66, 88)
        Me.txt_firstqrcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_firstqrcode.Name = "txt_firstqrcode"
        Me.txt_firstqrcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_firstqrcode.PlaceholderText = ""
        Me.txt_firstqrcode.SelectedText = ""
        Me.txt_firstqrcode.ShadowDecoration.Parent = Me.txt_firstqrcode
        Me.txt_firstqrcode.Size = New System.Drawing.Size(550, 51)
        Me.txt_firstqrcode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'txt_lastqrcode
        '
        Me.txt_lastqrcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lastqrcode.DefaultText = ""
        Me.txt_lastqrcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lastqrcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lastqrcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastqrcode.DisabledState.Parent = Me.txt_lastqrcode
        Me.txt_lastqrcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastqrcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastqrcode.FocusedState.Parent = Me.txt_lastqrcode
        Me.txt_lastqrcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lastqrcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastqrcode.HoverState.Parent = Me.txt_lastqrcode
        Me.txt_lastqrcode.Location = New System.Drawing.Point(66, 177)
        Me.txt_lastqrcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_lastqrcode.Name = "txt_lastqrcode"
        Me.txt_lastqrcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastqrcode.PlaceholderText = ""
        Me.txt_lastqrcode.SelectedText = ""
        Me.txt_lastqrcode.ShadowDecoration.Parent = Me.txt_lastqrcode
        Me.txt_lastqrcode.Size = New System.Drawing.Size(550, 51)
        Me.txt_lastqrcode.TabIndex = 3
        '
        'btn_qrcode
        '
        Me.btn_qrcode.CheckedState.Parent = Me.btn_qrcode
        Me.btn_qrcode.CustomImages.Parent = Me.btn_qrcode
        Me.btn_qrcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_qrcode.ForeColor = System.Drawing.Color.White
        Me.btn_qrcode.HoverState.Parent = Me.btn_qrcode
        Me.btn_qrcode.Location = New System.Drawing.Point(372, 236)
        Me.btn_qrcode.Name = "btn_qrcode"
        Me.btn_qrcode.ShadowDecoration.Parent = Me.btn_qrcode
        Me.btn_qrcode.Size = New System.Drawing.Size(244, 45)
        Me.btn_qrcode.TabIndex = 5
        Me.btn_qrcode.Text = "GENERATE QRCODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'btn_lastQRCode
        '
        Me.btn_lastQRCode.CheckedState.Parent = Me.btn_lastQRCode
        Me.btn_lastQRCode.CustomImages.Parent = Me.btn_lastQRCode
        Me.btn_lastQRCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_lastQRCode.ForeColor = System.Drawing.Color.White
        Me.btn_lastQRCode.HoverState.Parent = Me.btn_lastQRCode
        Me.btn_lastQRCode.Location = New System.Drawing.Point(623, 88)
        Me.btn_lastQRCode.Name = "btn_lastQRCode"
        Me.btn_lastQRCode.ShadowDecoration.Parent = Me.btn_lastQRCode
        Me.btn_lastQRCode.Size = New System.Drawing.Size(180, 45)
        Me.btn_lastQRCode.TabIndex = 7
        Me.btn_lastQRCode.Text = "GET LAST QRCODE"
        '
        'btn_printQR
        '
        Me.btn_printQR.CheckedState.Parent = Me.btn_printQR
        Me.btn_printQR.CustomImages.Parent = Me.btn_printQR
        Me.btn_printQR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_printQR.ForeColor = System.Drawing.Color.White
        Me.btn_printQR.HoverState.Parent = Me.btn_printQR
        Me.btn_printQR.Location = New System.Drawing.Point(372, 350)
        Me.btn_printQR.Name = "btn_printQR"
        Me.btn_printQR.ShadowDecoration.Parent = Me.btn_printQR
        Me.btn_printQR.Size = New System.Drawing.Size(244, 45)
        Me.btn_printQR.TabIndex = 8
        Me.btn_printQR.Text = "PRINT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(66, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'QRCodeGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 613)
        Me.Controls.Add(Me.btn_printQR)
        Me.Controls.Add(Me.btn_lastQRCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_qrcode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_lastqrcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_firstqrcode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "QRCodeGenerator"
        Me.Text = "QRCodeGenerator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_firstqrcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_lastqrcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_qrcode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_lastQRCode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_printQR As Guna.UI2.WinForms.Guna2Button
End Class
