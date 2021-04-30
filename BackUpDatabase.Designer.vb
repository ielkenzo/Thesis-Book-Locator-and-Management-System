<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUpDatabase
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
        Me.cbdatabase = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_backup = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(121, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECT DATABASE"
        '
        'cbdatabase
        '
        Me.cbdatabase.BackColor = System.Drawing.Color.Transparent
        Me.cbdatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbdatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdatabase.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbdatabase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbdatabase.FocusedState.Parent = Me.cbdatabase
        Me.cbdatabase.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbdatabase.ForeColor = System.Drawing.Color.Black
        Me.cbdatabase.HoverState.Parent = Me.cbdatabase
        Me.cbdatabase.ItemHeight = 30
        Me.cbdatabase.ItemsAppearance.Parent = Me.cbdatabase
        Me.cbdatabase.Location = New System.Drawing.Point(105, 112)
        Me.cbdatabase.Name = "cbdatabase"
        Me.cbdatabase.ShadowDecoration.Parent = Me.cbdatabase
        Me.cbdatabase.Size = New System.Drawing.Size(270, 36)
        Me.cbdatabase.TabIndex = 2
        '
        'btn_backup
        '
        Me.btn_backup.Animated = True
        Me.btn_backup.AutoRoundedCorners = True
        Me.btn_backup.BorderRadius = 21
        Me.btn_backup.CheckedState.Parent = Me.btn_backup
        Me.btn_backup.CustomImages.Parent = Me.btn_backup
        Me.btn_backup.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_backup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.ForeColor = System.Drawing.Color.White
        Me.btn_backup.HoverState.Parent = Me.btn_backup
        Me.btn_backup.Location = New System.Drawing.Point(123, 178)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.ShadowDecoration.Parent = Me.btn_backup
        Me.btn_backup.Size = New System.Drawing.Size(234, 45)
        Me.btn_backup.TabIndex = 3
        Me.btn_backup.Text = "BACKUP DATA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 45)
        Me.Panel1.TabIndex = 4
        '
        'btn_close
        '
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.close_cross_symbol_in_a_circle
        Me.btn_close.Location = New System.Drawing.Point(402, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(56, 45)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.backup
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(15, 84)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'BackUpDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.cbdatabase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "BackUpDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbdatabase As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_backup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
