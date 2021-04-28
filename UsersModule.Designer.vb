<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersModule
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.CB_access = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_designation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_initial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.CB_access)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.tb_designation)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tb_initial)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.tb_fname)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.tb_lastname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tb_password)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tb_username)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(569, 633)
        Me.Panel2.TabIndex = 2
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 20
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Location = New System.Drawing.Point(341, 570)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(180, 45)
        Me.btn_save.TabIndex = 35
        Me.btn_save.Text = "Save"
        '
        'btn_cancel
        '
        Me.btn_cancel.BorderRadius = 20
        Me.btn_cancel.CheckedState.Parent = Me.btn_cancel
        Me.btn_cancel.CustomImages.Parent = Me.btn_cancel
        Me.btn_cancel.FillColor = System.Drawing.Color.Red
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.HoverState.Parent = Me.btn_cancel
        Me.btn_cancel.Location = New System.Drawing.Point(155, 570)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.ShadowDecoration.Parent = Me.btn_cancel
        Me.btn_cancel.Size = New System.Drawing.Size(180, 45)
        Me.btn_cancel.TabIndex = 34
        Me.btn_cancel.Text = "Cancel"
        '
        'CB_access
        '
        Me.CB_access.Animated = True
        Me.CB_access.AutoRoundedCorners = True
        Me.CB_access.BackColor = System.Drawing.Color.Transparent
        Me.CB_access.BorderRadius = 17
        Me.CB_access.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_access.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_access.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_access.FocusedState.Parent = Me.CB_access
        Me.CB_access.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_access.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_access.HoverState.Parent = Me.CB_access
        Me.CB_access.ItemHeight = 30
        Me.CB_access.Items.AddRange(New Object() {"ADMIN", "USER", "OTHER USER"})
        Me.CB_access.ItemsAppearance.Parent = Me.CB_access
        Me.CB_access.Location = New System.Drawing.Point(34, 508)
        Me.CB_access.Name = "CB_access"
        Me.CB_access.ShadowDecoration.Parent = Me.CB_access
        Me.CB_access.Size = New System.Drawing.Size(487, 36)
        Me.CB_access.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(37, 475)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Access Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(34, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Designation"
        '
        'tb_designation
        '
        Me.tb_designation.BorderRadius = 10
        Me.tb_designation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_designation.DefaultText = ""
        Me.tb_designation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_designation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_designation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_designation.DisabledState.Parent = Me.tb_designation
        Me.tb_designation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_designation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_designation.FocusedState.Parent = Me.tb_designation
        Me.tb_designation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_designation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_designation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_designation.HoverState.Parent = Me.tb_designation
        Me.tb_designation.Location = New System.Drawing.Point(34, 436)
        Me.tb_designation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_designation.Name = "tb_designation"
        Me.tb_designation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_designation.PlaceholderText = ""
        Me.tb_designation.SelectedText = ""
        Me.tb_designation.ShadowDecoration.Parent = Me.tb_designation
        Me.tb_designation.Size = New System.Drawing.Size(487, 31)
        Me.tb_designation.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 25)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Middle Initial"
        '
        'tb_initial
        '
        Me.tb_initial.BorderRadius = 10
        Me.tb_initial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_initial.DefaultText = ""
        Me.tb_initial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_initial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_initial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_initial.DisabledState.Parent = Me.tb_initial
        Me.tb_initial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_initial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_initial.FocusedState.Parent = Me.tb_initial
        Me.tb_initial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_initial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_initial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_initial.HoverState.Parent = Me.tb_initial
        Me.tb_initial.Location = New System.Drawing.Point(34, 370)
        Me.tb_initial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_initial.Name = "tb_initial"
        Me.tb_initial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_initial.PlaceholderText = ""
        Me.tb_initial.SelectedText = ""
        Me.tb_initial.ShadowDecoration.Parent = Me.tb_initial
        Me.tb_initial.Size = New System.Drawing.Size(487, 31)
        Me.tb_initial.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "First Name"
        '
        'tb_fname
        '
        Me.tb_fname.BorderRadius = 10
        Me.tb_fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_fname.DefaultText = ""
        Me.tb_fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_fname.DisabledState.Parent = Me.tb_fname
        Me.tb_fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_fname.FocusedState.Parent = Me.tb_fname
        Me.tb_fname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_fname.HoverState.Parent = Me.tb_fname
        Me.tb_fname.Location = New System.Drawing.Point(34, 301)
        Me.tb_fname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_fname.Name = "tb_fname"
        Me.tb_fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_fname.PlaceholderText = ""
        Me.tb_fname.SelectedText = ""
        Me.tb_fname.ShadowDecoration.Parent = Me.tb_fname
        Me.tb_fname.Size = New System.Drawing.Size(487, 31)
        Me.tb_fname.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Last Name"
        '
        'tb_lastname
        '
        Me.tb_lastname.BorderRadius = 10
        Me.tb_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_lastname.DefaultText = ""
        Me.tb_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_lastname.DisabledState.Parent = Me.tb_lastname
        Me.tb_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_lastname.FocusedState.Parent = Me.tb_lastname
        Me.tb_lastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_lastname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_lastname.HoverState.Parent = Me.tb_lastname
        Me.tb_lastname.Location = New System.Drawing.Point(34, 234)
        Me.tb_lastname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_lastname.PlaceholderText = ""
        Me.tb_lastname.SelectedText = ""
        Me.tb_lastname.ShadowDecoration.Parent = Me.tb_lastname
        Me.tb_lastname.Size = New System.Drawing.Size(487, 31)
        Me.tb_lastname.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Password"
        '
        'tb_password
        '
        Me.tb_password.BorderRadius = 10
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_password.DefaultText = ""
        Me.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.DisabledState.Parent = Me.tb_password
        Me.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.FocusedState.Parent = Me.tb_password
        Me.tb_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.HoverState.Parent = Me.tb_password
        Me.tb_password.Location = New System.Drawing.Point(34, 170)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tb_password.PlaceholderText = ""
        Me.tb_password.SelectedText = ""
        Me.tb_password.ShadowDecoration.Parent = Me.tb_password
        Me.tb_password.Size = New System.Drawing.Size(487, 31)
        Me.tb_password.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Username"
        '
        'tb_username
        '
        Me.tb_username.BorderRadius = 10
        Me.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_username.DefaultText = ""
        Me.tb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.DisabledState.Parent = Me.tb_username
        Me.tb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.FocusedState.Parent = Me.tb_username
        Me.tb_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.HoverState.Parent = Me.tb_username
        Me.tb_username.Location = New System.Drawing.Point(34, 97)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.PlaceholderText = ""
        Me.tb_username.SelectedText = ""
        Me.tb_username.ShadowDecoration.Parent = Me.tb_username
        Me.tb_username.Size = New System.Drawing.Size(487, 31)
        Me.tb_username.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 39)
        Me.Panel1.TabIndex = 18
        '
        'btn_close
        '
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.cancel
        Me.btn_close.Location = New System.Drawing.Point(508, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(61, 39)
        Me.btn_close.TabIndex = 1
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Information Module"
        '
        'UsersModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.HelpButton = True
        Me.Name = "UsersModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CB_access As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_designation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_initial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_password As Guna.UI2.WinForms.Guna2TextBox
End Class
