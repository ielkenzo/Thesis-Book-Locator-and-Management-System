<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelModule
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.tb_fullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSaveUpdate)
        Me.Guna2GroupBox1.Controls.Add(Me.btn_cancel)
        Me.Guna2GroupBox1.Controls.Add(Me.tb_fullname)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(499, 255)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Panel Module"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(198, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Full Name"
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.BorderRadius = 20
        Me.btnSaveUpdate.CheckedState.Parent = Me.btnSaveUpdate
        Me.btnSaveUpdate.CustomImages.Parent = Me.btnSaveUpdate
        Me.btnSaveUpdate.FillColor = System.Drawing.Color.ForestGreen
        Me.btnSaveUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveUpdate.ForeColor = System.Drawing.Color.White
        Me.btnSaveUpdate.HoverState.Parent = Me.btnSaveUpdate
        Me.btnSaveUpdate.Location = New System.Drawing.Point(253, 183)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.ShadowDecoration.Parent = Me.btnSaveUpdate
        Me.btnSaveUpdate.Size = New System.Drawing.Size(145, 45)
        Me.btnSaveUpdate.TabIndex = 2
        Me.btnSaveUpdate.Text = "Update"
        '
        'btn_cancel
        '
        Me.btn_cancel.BorderRadius = 20
        Me.btn_cancel.CheckedState.Parent = Me.btn_cancel
        Me.btn_cancel.CustomImages.Parent = Me.btn_cancel
        Me.btn_cancel.FillColor = System.Drawing.Color.Red
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.HoverState.Parent = Me.btn_cancel
        Me.btn_cancel.Location = New System.Drawing.Point(97, 183)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.ShadowDecoration.Parent = Me.btn_cancel
        Me.btn_cancel.Size = New System.Drawing.Size(145, 45)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        '
        'tb_fullname
        '
        Me.tb_fullname.BorderRadius = 10
        Me.tb_fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_fullname.DefaultText = ""
        Me.tb_fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_fullname.DisabledState.Parent = Me.tb_fullname
        Me.tb_fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_fullname.FocusedState.Parent = Me.tb_fullname
        Me.tb_fullname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_fullname.HoverState.Parent = Me.tb_fullname
        Me.tb_fullname.Location = New System.Drawing.Point(86, 123)
        Me.tb_fullname.Name = "tb_fullname"
        Me.tb_fullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_fullname.PlaceholderText = ""
        Me.tb_fullname.SelectedText = ""
        Me.tb_fullname.ShadowDecoration.Parent = Me.tb_fullname
        Me.tb_fullname.Size = New System.Drawing.Size(324, 36)
        Me.tb_fullname.TabIndex = 0
        '
        'PanelModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "PanelModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents tb_fullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
End Class
