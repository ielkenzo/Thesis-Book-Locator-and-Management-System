<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookInfoForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DGVBookInfo = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CBYear = New System.Windows.Forms.ComboBox()
        Me.CBMonth = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LBoxPanel = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPanel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBoxResearcher = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbResearcher = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCritic = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAdviser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbThesisTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbBookID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DeleteBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditBookInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAddSave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVBookInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1232, 43)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK INFORMATION"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1232, 743)
        Me.Panel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(350, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(882, 743)
        Me.Panel4.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 58)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(882, 685)
        Me.Panel6.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Controls.Add(Me.DGVBookInfo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(882, 685)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULT"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabelCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 653)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(876, 29)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(207, 23)
        Me.ToolStripStatusLabel1.Text = "TOTAL SEARCH RESULT :"
        '
        'ToolStripStatusLabelCount
        '
        Me.ToolStripStatusLabelCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabelCount.Name = "ToolStripStatusLabelCount"
        Me.ToolStripStatusLabelCount.Size = New System.Drawing.Size(20, 23)
        Me.ToolStripStatusLabelCount.Text = "0"
        '
        'DGVBookInfo
        '
        Me.DGVBookInfo.AllowUserToAddRows = False
        Me.DGVBookInfo.AllowUserToDeleteRows = False
        Me.DGVBookInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBookInfo.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGVBookInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVBookInfo.Location = New System.Drawing.Point(3, 26)
        Me.DGVBookInfo.Name = "DGVBookInfo"
        Me.DGVBookInfo.ReadOnly = True
        Me.DGVBookInfo.RowHeadersWidth = 51
        Me.DGVBookInfo.RowTemplate.Height = 24
        Me.DGVBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBookInfo.Size = New System.Drawing.Size(876, 656)
        Me.DGVBookInfo.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteBookToolStripMenuItem, Me.EditBookInformationToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(229, 82)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(228, 26)
        Me.ToolStripMenuItem1.Text = "Assign Book Location"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel5.Controls.Add(Me.BtnSearch)
        Me.Panel5.Controls.Add(Me.tbSearch)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(882, 58)
        Me.Panel5.TabIndex = 2
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(109, 11)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(517, 34)
        Me.tbSearch.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 23)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "FIND BOOK"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CBYear)
        Me.Panel3.Controls.Add(Me.CBMonth)
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Controls.Add(Me.LBoxPanel)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.tbPanel)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.BtnCancel)
        Me.Panel3.Controls.Add(Me.BtnAddSave)
        Me.Panel3.Controls.Add(Me.LBoxResearcher)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.tbResearcher)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.tbCritic)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.tbAdviser)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.tbThesisTitle)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tbBookID)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 743)
        Me.Panel3.TabIndex = 0
        '
        'CBYear
        '
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.Location = New System.Drawing.Point(190, 223)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Size = New System.Drawing.Size(146, 31)
        Me.CBYear.TabIndex = 22
        '
        'CBMonth
        '
        Me.CBMonth.FormattingEnabled = True
        Me.CBMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.CBMonth.Location = New System.Drawing.Point(19, 223)
        Me.CBMonth.Name = "CBMonth"
        Me.CBMonth.Size = New System.Drawing.Size(165, 31)
        Me.CBMonth.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(350, 31)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'LBoxPanel
        '
        Me.LBoxPanel.FormattingEnabled = True
        Me.LBoxPanel.ItemHeight = 23
        Me.LBoxPanel.Location = New System.Drawing.Point(12, 607)
        Me.LBoxPanel.Name = "LBoxPanel"
        Me.LBoxPanel.Size = New System.Drawing.Size(320, 50)
        Me.LBoxPanel.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Cyan
        Me.Label10.Location = New System.Drawing.Point(14, 554)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Enter Last Name, First Name, Middle Initial/s"
        '
        'tbPanel
        '
        Me.tbPanel.Location = New System.Drawing.Point(12, 571)
        Me.tbPanel.Name = "tbPanel"
        Me.tbPanel.Size = New System.Drawing.Size(320, 30)
        Me.tbPanel.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.tbPanel, "Scan RFID tag inside the book")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(11, 531)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "PANEL"
        '
        'LBoxResearcher
        '
        Me.LBoxResearcher.FormattingEnabled = True
        Me.LBoxResearcher.ItemHeight = 23
        Me.LBoxResearcher.Location = New System.Drawing.Point(12, 456)
        Me.LBoxResearcher.Name = "LBoxResearcher"
        Me.LBoxResearcher.Size = New System.Drawing.Size(320, 73)
        Me.LBoxResearcher.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(12, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Enter Last Name, First Name, Middle Initial/s"
        '
        'tbResearcher
        '
        Me.tbResearcher.Location = New System.Drawing.Point(12, 420)
        Me.tbResearcher.Name = "tbResearcher"
        Me.tbResearcher.Size = New System.Drawing.Size(320, 30)
        Me.tbResearcher.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(13, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "RESEARCHERS/PROPONENTS"
        '
        'tbCritic
        '
        Me.tbCritic.Location = New System.Drawing.Point(14, 346)
        Me.tbCritic.Name = "tbCritic"
        Me.tbCritic.Size = New System.Drawing.Size(320, 30)
        Me.tbCritic.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.tbCritic, "Enter the name of Critic Reader with format Ex. Dela Cruz, Juan")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(13, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CRITIC READER"
        '
        'tbAdviser
        '
        Me.tbAdviser.Location = New System.Drawing.Point(16, 285)
        Me.tbAdviser.Name = "tbAdviser"
        Me.tbAdviser.Size = New System.Drawing.Size(320, 30)
        Me.tbAdviser.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbAdviser, "Enter the name of Adviser with format Ex. Dela Cruz, Juan")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ADVISER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MONTH  YEAR SUBMITTED (MM, YYYY)"
        '
        'tbThesisTitle
        '
        Me.tbThesisTitle.Location = New System.Drawing.Point(15, 132)
        Me.tbThesisTitle.Multiline = True
        Me.tbThesisTitle.Name = "tbThesisTitle"
        Me.tbThesisTitle.Size = New System.Drawing.Size(320, 62)
        Me.tbThesisTitle.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbThesisTitle, "Enter the title of Thesis Book")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "THESIS TITLE"
        '
        'tbBookID
        '
        Me.tbBookID.Location = New System.Drawing.Point(14, 72)
        Me.tbBookID.Name = "tbBookID"
        Me.tbBookID.Size = New System.Drawing.Size(320, 30)
        Me.tbBookID.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbBookID, "Scan RFID tag inside the book")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BOOK ID"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Reminder"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.delete
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.DeleteBookToolStripMenuItem.Text = "Delete Book"
        '
        'EditBookInformationToolStripMenuItem
        '
        Me.EditBookInformationToolStripMenuItem.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.edit
        Me.EditBookInformationToolStripMenuItem.Name = "EditBookInformationToolStripMenuItem"
        Me.EditBookInformationToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.EditBookInformationToolStripMenuItem.Text = "Edit Book Information"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.search
        Me.BtnSearch.Location = New System.Drawing.Point(632, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(49, 30)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.plus
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(63, 28)
        Me.btnAdd.Text = "New"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 28)
        Me.btnEdit.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.delete
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 28)
        Me.btnDelete.Text = "Delete"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancel.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.cancel
        Me.BtnCancel.Location = New System.Drawing.Point(178, 684)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(156, 46)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = " CANCEL"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnAddSave
        '
        Me.BtnAddSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAddSave.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.save_file_option
        Me.BtnAddSave.Location = New System.Drawing.Point(16, 684)
        Me.BtnAddSave.Name = "BtnAddSave"
        Me.BtnAddSave.Size = New System.Drawing.Size(156, 46)
        Me.BtnAddSave.TabIndex = 14
        Me.BtnAddSave.Text = " SAVE"
        Me.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddSave.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Thesis_Book_Locator_and_Management_System.My.Resources.Resources.remove_button
        Me.PictureBox1.Location = New System.Drawing.Point(1193, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BookInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 786)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookInfoForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGVBookInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVBookInfo As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelCount As ToolStripStatusLabel
    Friend WithEvents BtnAddSave As Button
    Friend WithEvents LBoxResearcher As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbResearcher As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCritic As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbAdviser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbThesisTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbBookID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LBoxPanel As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbPanel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CBYear As ComboBox
    Friend WithEvents CBMonth As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditBookInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
