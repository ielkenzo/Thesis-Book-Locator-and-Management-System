<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_bookTitle = New System.Windows.Forms.Label()
        Me.tb_rfidQR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_studentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_remove = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_add = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 64)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.remove_button
        Me.PictureBox2.Location = New System.Drawing.Point(1007, 17)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(246, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELF CHECKOUT WINDOW "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl_bookTitle)
        Me.Panel2.Controls.Add(Me.tb_rfidQR)
        Me.Panel2.Controls.Add(Me.tb_studentID)
        Me.Panel2.Controls.Add(Me.btn_remove)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.lbl_fullname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 595)
        Me.Panel2.TabIndex = 1
        '
        'lbl_bookTitle
        '
        Me.lbl_bookTitle.AutoSize = True
        Me.lbl_bookTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_bookTitle.Location = New System.Drawing.Point(47, 448)
        Me.lbl_bookTitle.Name = "lbl_bookTitle"
        Me.lbl_bookTitle.Size = New System.Drawing.Size(293, 28)
        Me.lbl_bookTitle.TabIndex = 12
        Me.lbl_bookTitle.Text = "Book Title Will Appear Here..."
        '
        'tb_rfidQR
        '
        Me.tb_rfidQR.AutoRoundedCorners = True
        Me.tb_rfidQR.BorderRadius = 17
        Me.tb_rfidQR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rfidQR.DefaultText = ""
        Me.tb_rfidQR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_rfidQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_rfidQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_rfidQR.DisabledState.Parent = Me.tb_rfidQR
        Me.tb_rfidQR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_rfidQR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_rfidQR.FocusedState.Parent = Me.tb_rfidQR
        Me.tb_rfidQR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_rfidQR.ForeColor = System.Drawing.Color.Black
        Me.tb_rfidQR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_rfidQR.HoverState.Parent = Me.tb_rfidQR
        Me.tb_rfidQR.Location = New System.Drawing.Point(38, 400)
        Me.tb_rfidQR.Name = "tb_rfidQR"
        Me.tb_rfidQR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_rfidQR.PlaceholderText = ""
        Me.tb_rfidQR.SelectedText = ""
        Me.tb_rfidQR.ShadowDecoration.Parent = Me.tb_rfidQR
        Me.tb_rfidQR.Size = New System.Drawing.Size(312, 36)
        Me.tb_rfidQR.TabIndex = 11
        '
        'tb_studentID
        '
        Me.tb_studentID.AutoRoundedCorners = True
        Me.tb_studentID.BorderRadius = 17
        Me.tb_studentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_studentID.DefaultText = ""
        Me.tb_studentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_studentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_studentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_studentID.DisabledState.Parent = Me.tb_studentID
        Me.tb_studentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_studentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_studentID.FocusedState.Parent = Me.tb_studentID
        Me.tb_studentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_studentID.ForeColor = System.Drawing.Color.Black
        Me.tb_studentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_studentID.HoverState.Parent = Me.tb_studentID
        Me.tb_studentID.Location = New System.Drawing.Point(38, 286)
        Me.tb_studentID.Name = "tb_studentID"
        Me.tb_studentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_studentID.PlaceholderText = ""
        Me.tb_studentID.SelectedText = ""
        Me.tb_studentID.ShadowDecoration.Parent = Me.tb_studentID
        Me.tb_studentID.Size = New System.Drawing.Size(312, 36)
        Me.tb_studentID.TabIndex = 10
        '
        'btn_remove
        '
        Me.btn_remove.AutoRoundedCorners = True
        Me.btn_remove.BorderRadius = 21
        Me.btn_remove.CheckedState.Parent = Me.btn_remove
        Me.btn_remove.CustomImages.Parent = Me.btn_remove
        Me.btn_remove.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_remove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.HoverState.Parent = Me.btn_remove
        Me.btn_remove.Location = New System.Drawing.Point(30, 490)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.ShadowDecoration.Parent = Me.btn_remove
        Me.btn_remove.Size = New System.Drawing.Size(168, 45)
        Me.btn_remove.TabIndex = 9
        Me.btn_remove.Text = "REMOVE"
        '
        'btn_add
        '
        Me.btn_add.AutoRoundedCorners = True
        Me.btn_add.BorderRadius = 21
        Me.btn_add.CheckedState.Parent = Me.btn_add
        Me.btn_add.CustomImages.Parent = Me.btn_add
        Me.btn_add.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.HoverState.Parent = Me.btn_add
        Me.btn_add.Location = New System.Drawing.Point(204, 490)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.ShadowDecoration.Parent = Me.btn_add
        Me.btn_add.Size = New System.Drawing.Size(153, 45)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "START"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.White
        Me.lbl_fullname.Location = New System.Drawing.Point(55, 329)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(285, 28)
        Me.lbl_fullname.TabIndex = 7
        Me.lbl_fullname.Text = "Your Name Will Appear Here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(53, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SCAN BOOK RFID TAG/ QR CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(91, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SCAN YOUR ID QR CODE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(107, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnDone)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(391, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(666, 59)
        Me.Panel3.TabIndex = 2
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.BorderRadius = 25
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.checked
        Me.btnDone.Location = New System.Drawing.Point(552, 8)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.Size = New System.Drawing.Size(105, 45)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "DONE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CHECKOUT LIST"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(391, 123)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(666, 536)
        Me.Panel4.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(666, 536)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 659)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransactionForm"
        Me.Text = "Transaction Window"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tb_rfidQR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_studentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_remove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents lbl_bookTitle As Label
    Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
End Class
