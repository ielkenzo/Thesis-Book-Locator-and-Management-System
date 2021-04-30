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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_lastqrcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_qrcode = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_printQR = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_selectToPrint = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(59, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "QR Code Count to Generate"
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
        Me.txt_lastqrcode.Location = New System.Drawing.Point(37, 178)
        Me.txt_lastqrcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_lastqrcode.Name = "txt_lastqrcode"
        Me.txt_lastqrcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastqrcode.PlaceholderText = ""
        Me.txt_lastqrcode.SelectedText = ""
        Me.txt_lastqrcode.ShadowDecoration.Parent = Me.txt_lastqrcode
        Me.txt_lastqrcode.Size = New System.Drawing.Size(300, 51)
        Me.txt_lastqrcode.TabIndex = 3
        '
        'btn_qrcode
        '
        Me.btn_qrcode.AutoRoundedCorners = True
        Me.btn_qrcode.BorderRadius = 26
        Me.btn_qrcode.CheckedState.Parent = Me.btn_qrcode
        Me.btn_qrcode.CustomImages.Parent = Me.btn_qrcode
        Me.btn_qrcode.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_qrcode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qrcode.ForeColor = System.Drawing.Color.White
        Me.btn_qrcode.HoverState.Parent = Me.btn_qrcode
        Me.btn_qrcode.Location = New System.Drawing.Point(42, 239)
        Me.btn_qrcode.Name = "btn_qrcode"
        Me.btn_qrcode.ShadowDecoration.Parent = Me.btn_qrcode
        Me.btn_qrcode.Size = New System.Drawing.Size(291, 55)
        Me.btn_qrcode.TabIndex = 5
        Me.btn_qrcode.Text = "GENERATE QRCODE"
        '
        'btn_printQR
        '
        Me.btn_printQR.Animated = True
        Me.btn_printQR.AutoRoundedCorners = True
        Me.btn_printQR.BorderRadius = 21
        Me.btn_printQR.CheckedState.Parent = Me.btn_printQR
        Me.btn_printQR.CustomImages.Parent = Me.btn_printQR
        Me.btn_printQR.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_printQR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_printQR.ForeColor = System.Drawing.Color.White
        Me.btn_printQR.HoverState.Parent = Me.btn_printQR
        Me.btn_printQR.Location = New System.Drawing.Point(46, 155)
        Me.btn_printQR.Name = "btn_printQR"
        Me.btn_printQR.ShadowDecoration.Parent = Me.btn_printQR
        Me.btn_printQR.Size = New System.Drawing.Size(244, 45)
        Me.btn_printQR.TabIndex = 8
        Me.btn_printQR.Text = "PRINT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_qrcode)
        Me.Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Panel1.Controls.Add(Me.txt_lastqrcode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 798)
        Me.Panel1.TabIndex = 9
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.cb_selectToPrint)
        Me.Guna2GroupBox2.Controls.Add(Me.btn_printQR)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(3, 544)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(369, 231)
        Me.Guna2GroupBox2.TabIndex = 12
        Me.Guna2GroupBox2.Text = "PRINT SECTION"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(120, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select to print"
        '
        'cb_selectToPrint
        '
        Me.cb_selectToPrint.Animated = True
        Me.cb_selectToPrint.AutoRoundedCorners = True
        Me.cb_selectToPrint.BackColor = System.Drawing.Color.Transparent
        Me.cb_selectToPrint.BorderRadius = 17
        Me.cb_selectToPrint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_selectToPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_selectToPrint.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_selectToPrint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_selectToPrint.FocusedState.Parent = Me.cb_selectToPrint
        Me.cb_selectToPrint.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_selectToPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_selectToPrint.HoverState.Parent = Me.cb_selectToPrint
        Me.cb_selectToPrint.ItemHeight = 30
        Me.cb_selectToPrint.Items.AddRange(New Object() {"All", "AVAILABLE", "USED"})
        Me.cb_selectToPrint.ItemsAppearance.Parent = Me.cb_selectToPrint
        Me.cb_selectToPrint.Location = New System.Drawing.Point(29, 94)
        Me.cb_selectToPrint.Name = "cb_selectToPrint"
        Me.cb_selectToPrint.ShadowDecoration.Parent = Me.cb_selectToPrint
        Me.cb_selectToPrint.Size = New System.Drawing.Size(291, 36)
        Me.cb_selectToPrint.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.qr_code__1_
        Me.PictureBox2.Location = New System.Drawing.Point(127, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.PictureBox1)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(42, 303)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(291, 235)
        Me.Guna2GroupBox1.TabIndex = 8
        Me.Guna2GroupBox1.Text = "GENERATED QRCODE"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(50, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(378, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1057, 798)
        Me.Panel2.TabIndex = 10
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1057, 798)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'QRCodeGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 798)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "QRCodeGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "QR Code Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_lastqrcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_qrcode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_printQR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cb_selectToPrint As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
End Class
