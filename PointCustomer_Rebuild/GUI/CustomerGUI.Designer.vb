<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerGUI
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblNameOfFromCus = New System.Windows.Forms.Label()
        Me.lblIDCustomer = New System.Windows.Forms.Label()
        Me.txtIDCustomer = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDayOfCreate = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtDayOfBirth = New System.Windows.Forms.TextBox()
        Me.lblDayOfCreate = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblDayOfBirth = New System.Windows.Forms.Label()
        Me.txtNameOfCustomer = New System.Windows.Forms.TextBox()
        Me.lblNameOfCustomer = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchĐiểmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhậpĐiểmTíchLũyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinHệSốToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VềChúngTôiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewCustomer = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfCreateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNameOfFromCus
        '
        Me.lblNameOfFromCus.AutoSize = True
        Me.lblNameOfFromCus.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNameOfFromCus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNameOfFromCus.Location = New System.Drawing.Point(504, 29)
        Me.lblNameOfFromCus.Name = "lblNameOfFromCus"
        Me.lblNameOfFromCus.Size = New System.Drawing.Size(208, 24)
        Me.lblNameOfFromCus.TabIndex = 0
        Me.lblNameOfFromCus.Text = "Thông tin khách hàng "
        '
        'lblIDCustomer
        '
        Me.lblIDCustomer.AutoSize = True
        Me.lblIDCustomer.Location = New System.Drawing.Point(34, 43)
        Me.lblIDCustomer.Name = "lblIDCustomer"
        Me.lblIDCustomer.Size = New System.Drawing.Size(108, 17)
        Me.lblIDCustomer.TabIndex = 1
        Me.lblIDCustomer.Text = "Mã khách hàng"
        '
        'txtIDCustomer
        '
        Me.txtIDCustomer.ForeColor = System.Drawing.Color.Black
        Me.txtIDCustomer.Location = New System.Drawing.Point(152, 40)
        Me.txtIDCustomer.Name = "txtIDCustomer"
        Me.txtIDCustomer.Size = New System.Drawing.Size(120, 25)
        Me.txtIDCustomer.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtDayOfCreate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtDayOfBirth)
        Me.GroupBox1.Controls.Add(Me.lblDayOfCreate)
        Me.GroupBox1.Controls.Add(Me.lblContact)
        Me.GroupBox1.Controls.Add(Me.lblDayOfBirth)
        Me.GroupBox1.Controls.Add(Me.txtNameOfCustomer)
        Me.GroupBox1.Controls.Add(Me.lblNameOfCustomer)
        Me.GroupBox1.Controls.Add(Me.txtIDCustomer)
        Me.GroupBox1.Controls.Add(Me.lblIDCustomer)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 423)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1322, 165)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tác vụ người dùng"
        '
        'txtDayOfCreate
        '
        Me.txtDayOfCreate.Location = New System.Drawing.Point(955, 40)
        Me.txtDayOfCreate.Name = "txtDayOfCreate"
        Me.txtDayOfCreate.Size = New System.Drawing.Size(120, 25)
        Me.txtDayOfCreate.TabIndex = 12
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(1139, 101)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 44)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Xóa người dùng"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(1182, 40)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(120, 25)
        Me.txtContact.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(942, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(169, 44)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtDayOfBirth
        '
        Me.txtDayOfBirth.Location = New System.Drawing.Point(673, 40)
        Me.txtDayOfBirth.Name = "txtDayOfBirth"
        Me.txtDayOfBirth.Size = New System.Drawing.Size(120, 25)
        Me.txtDayOfBirth.TabIndex = 10
        '
        'lblDayOfCreate
        '
        Me.lblDayOfCreate.AutoSize = True
        Me.lblDayOfCreate.Location = New System.Drawing.Point(832, 43)
        Me.lblDayOfCreate.Name = "lblDayOfCreate"
        Me.lblDayOfCreate.Size = New System.Drawing.Size(100, 17)
        Me.lblDayOfCreate.TabIndex = 9
        Me.lblDayOfCreate.Text = "Ngày tham gia"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(1099, 44)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(58, 17)
        Me.lblContact.TabIndex = 7
        Me.lblContact.Text = "Liên hệ"
        '
        'lblDayOfBirth
        '
        Me.lblDayOfBirth.AutoSize = True
        Me.lblDayOfBirth.Location = New System.Drawing.Point(590, 43)
        Me.lblDayOfBirth.Name = "lblDayOfBirth"
        Me.lblDayOfBirth.Size = New System.Drawing.Size(77, 17)
        Me.lblDayOfBirth.TabIndex = 5
        Me.lblDayOfBirth.Text = "Ngày Sinh "
        '
        'txtNameOfCustomer
        '
        Me.txtNameOfCustomer.Location = New System.Drawing.Point(433, 40)
        Me.txtNameOfCustomer.Name = "txtNameOfCustomer"
        Me.txtNameOfCustomer.Size = New System.Drawing.Size(120, 25)
        Me.txtNameOfCustomer.TabIndex = 4
        '
        'lblNameOfCustomer
        '
        Me.lblNameOfCustomer.AutoSize = True
        Me.lblNameOfCustomer.Location = New System.Drawing.Point(315, 43)
        Me.lblNameOfCustomer.Name = "lblNameOfCustomer"
        Me.lblNameOfCustomer.Size = New System.Drawing.Size(112, 17)
        Me.lblNameOfCustomer.TabIndex = 3
        Me.lblNameOfCustomer.Text = "Tên khách hàng"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 71)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(149, 17)
        Me.lblSearch.TabIndex = 6
        Me.lblSearch.Text = "Tìm kiếm khách hàng"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(1179, 604)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Thoát"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearch.Location = New System.Drawing.Point(170, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(169, 25)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.Text = "Nhập vào ID khách hàng"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChungToolStripMenuItem, Me.ThôngTinToolStripMenuItem, Me.ThêmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1353, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChungToolStripMenuItem
        '
        Me.ChungToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.ChungToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ChungToolStripMenuItem.Name = "ChungToolStripMenuItem"
        Me.ChungToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ChungToolStripMenuItem.Text = "Chung"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchĐiểmToolStripMenuItem, Me.NhậpĐiểmTíchLũyToolStripMenuItem, Me.ThôngTinHệSốToolStripMenuItem})
        Me.ThôngTinToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ThôngTinToolStripMenuItem.Text = "Thông Tin"
        '
        'DanhSáchĐiểmToolStripMenuItem
        '
        Me.DanhSáchĐiểmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.DanhSáchĐiểmToolStripMenuItem.Name = "DanhSáchĐiểmToolStripMenuItem"
        Me.DanhSáchĐiểmToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DanhSáchĐiểmToolStripMenuItem.Text = "Danh sách điểm "
        '
        'NhậpĐiểmTíchLũyToolStripMenuItem
        '
        Me.NhậpĐiểmTíchLũyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.NhậpĐiểmTíchLũyToolStripMenuItem.Name = "NhậpĐiểmTíchLũyToolStripMenuItem"
        Me.NhậpĐiểmTíchLũyToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NhậpĐiểmTíchLũyToolStripMenuItem.Text = "Nhập điểm tích lũy "
        '
        'ThôngTinHệSốToolStripMenuItem
        '
        Me.ThôngTinHệSốToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ThôngTinHệSốToolStripMenuItem.Name = "ThôngTinHệSốToolStripMenuItem"
        Me.ThôngTinHệSốToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ThôngTinHệSốToolStripMenuItem.Text = "Thông tin hệ số"
        '
        'ThêmToolStripMenuItem
        '
        Me.ThêmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VềChúngTôiToolStripMenuItem})
        Me.ThêmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ThêmToolStripMenuItem.Name = "ThêmToolStripMenuItem"
        Me.ThêmToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ThêmToolStripMenuItem.Text = "Thêm"
        '
        'VềChúngTôiToolStripMenuItem
        '
        Me.VềChúngTôiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.VềChúngTôiToolStripMenuItem.Name = "VềChúngTôiToolStripMenuItem"
        Me.VềChúngTôiToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.VềChúngTôiToolStripMenuItem.Text = "Về chúng tôi"
        '
        'DataGridViewCustomer
        '
        Me.DataGridViewCustomer.AutoGenerateColumns = False
        Me.DataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCustomerDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.DateOfCreateDataGridViewTextBoxColumn})
        Me.DataGridViewCustomer.DataSource = Me.TblCustomerBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCustomer.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewCustomer.Location = New System.Drawing.Point(19, 110)
        Me.DataGridViewCustomer.Name = "DataGridViewCustomer"
        Me.DataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCustomer.Size = New System.Drawing.Size(1322, 299)
        Me.DataGridViewCustomer.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(345, 54)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(105, 44)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataSource = GetType(PointCustomer_Rebuild.tblCustomer)
        '
        'IDCustomerDataGridViewTextBoxColumn
        '
        Me.IDCustomerDataGridViewTextBoxColumn.DataPropertyName = "IDCustomer"
        Me.IDCustomerDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng"
        Me.IDCustomerDataGridViewTextBoxColumn.Name = "IDCustomerDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DateOfBirthDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Ngày sinh "
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ContactDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "SĐT Liên hệ"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'DateOfCreateDataGridViewTextBoxColumn
        '
        Me.DateOfCreateDataGridViewTextBoxColumn.DataPropertyName = "DateOfCreate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DateOfCreateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateOfCreateDataGridViewTextBoxColumn.HeaderText = "Ngày tạo"
        Me.DateOfCreateDataGridViewTextBoxColumn.Name = "DateOfCreateDataGridViewTextBoxColumn"
        '
        'frmCustomerGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1353, 660)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.DataGridViewCustomer)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNameOfFromCus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCustomerGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý khách hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameOfFromCus As Label
    Friend WithEvents lblIDCustomer As Label
    Friend WithEvents txtIDCustomer As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDayOfCreate As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblDayOfBirth As Label
    Friend WithEvents txtNameOfCustomer As TextBox
    Friend WithEvents lblNameOfCustomer As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtDayOfCreate As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtDayOfBirth As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchĐiểmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhậpĐiểmTíchLũyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VềChúngTôiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TblCustomerBindingSource As BindingSource
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridViewCustomer As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents ThôngTinHệSốToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfCreateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
