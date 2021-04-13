<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickUpdate
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
        Me.lblCustomerFirst = New System.Windows.Forms.Label()
        Me.lblNameOfCustomer = New System.Windows.Forms.Label()
        Me.lblIDCustomer = New System.Windows.Forms.Label()
        Me.txtIDCustomer = New System.Windows.Forms.TextBox()
        Me.txtNameOfCustomer = New System.Windows.Forms.TextBox()
        Me.lblNameOfCustomerSecond = New System.Windows.Forms.Label()
        Me.txtDayOfBirth = New System.Windows.Forms.TextBox()
        Me.txDayOfBirth = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtDayOfCreate = New System.Windows.Forms.TextBox()
        Me.lblDateOfCreate = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCustomerFirst
        '
        Me.lblCustomerFirst.AutoSize = True
        Me.lblCustomerFirst.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCustomerFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblCustomerFirst.Location = New System.Drawing.Point(30, 34)
        Me.lblCustomerFirst.Name = "lblCustomerFirst"
        Me.lblCustomerFirst.Size = New System.Drawing.Size(85, 17)
        Me.lblCustomerFirst.TabIndex = 0
        Me.lblCustomerFirst.Text = "Khách hàng"
        '
        'lblNameOfCustomer
        '
        Me.lblNameOfCustomer.AutoSize = True
        Me.lblNameOfCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNameOfCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNameOfCustomer.Location = New System.Drawing.Point(157, 34)
        Me.lblNameOfCustomer.Name = "lblNameOfCustomer"
        Me.lblNameOfCustomer.Size = New System.Drawing.Size(101, 17)
        Me.lblNameOfCustomer.TabIndex = 1
        Me.lblNameOfCustomer.Text = "Nguyễn Văn A"
        '
        'lblIDCustomer
        '
        Me.lblIDCustomer.AutoSize = True
        Me.lblIDCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblIDCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblIDCustomer.Location = New System.Drawing.Point(30, 84)
        Me.lblIDCustomer.Name = "lblIDCustomer"
        Me.lblIDCustomer.Size = New System.Drawing.Size(108, 17)
        Me.lblIDCustomer.TabIndex = 2
        Me.lblIDCustomer.Text = "Mã khách hàng"
        '
        'txtIDCustomer
        '
        Me.txtIDCustomer.Enabled = False
        Me.txtIDCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtIDCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtIDCustomer.Location = New System.Drawing.Point(160, 80)
        Me.txtIDCustomer.Name = "txtIDCustomer"
        Me.txtIDCustomer.Size = New System.Drawing.Size(100, 25)
        Me.txtIDCustomer.TabIndex = 3
        '
        'txtNameOfCustomer
        '
        Me.txtNameOfCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNameOfCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtNameOfCustomer.Location = New System.Drawing.Point(429, 77)
        Me.txtNameOfCustomer.Name = "txtNameOfCustomer"
        Me.txtNameOfCustomer.Size = New System.Drawing.Size(143, 25)
        Me.txtNameOfCustomer.TabIndex = 5
        '
        'lblNameOfCustomerSecond
        '
        Me.lblNameOfCustomerSecond.AutoSize = True
        Me.lblNameOfCustomerSecond.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNameOfCustomerSecond.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNameOfCustomerSecond.Location = New System.Drawing.Point(314, 80)
        Me.lblNameOfCustomerSecond.Name = "lblNameOfCustomerSecond"
        Me.lblNameOfCustomerSecond.Size = New System.Drawing.Size(112, 17)
        Me.lblNameOfCustomerSecond.TabIndex = 4
        Me.lblNameOfCustomerSecond.Text = "Tên khách hàng"
        '
        'txtDayOfBirth
        '
        Me.txtDayOfBirth.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDayOfBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtDayOfBirth.Location = New System.Drawing.Point(429, 127)
        Me.txtDayOfBirth.Name = "txtDayOfBirth"
        Me.txtDayOfBirth.Size = New System.Drawing.Size(143, 25)
        Me.txtDayOfBirth.TabIndex = 7
        '
        'txDayOfBirth
        '
        Me.txDayOfBirth.AutoSize = True
        Me.txDayOfBirth.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txDayOfBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txDayOfBirth.Location = New System.Drawing.Point(314, 130)
        Me.txDayOfBirth.Name = "txDayOfBirth"
        Me.txDayOfBirth.Size = New System.Drawing.Size(72, 17)
        Me.txDayOfBirth.TabIndex = 6
        Me.txDayOfBirth.Text = "Ngày sinh"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(739, 77)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(146, 25)
        Me.txtContact.TabIndex = 9
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(624, 80)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(92, 17)
        Me.lblContact.TabIndex = 8
        Me.lblContact.Text = "Số điện thoại"
        '
        'txtDayOfCreate
        '
        Me.txtDayOfCreate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDayOfCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtDayOfCreate.Location = New System.Drawing.Point(739, 130)
        Me.txtDayOfCreate.Name = "txtDayOfCreate"
        Me.txtDayOfCreate.Size = New System.Drawing.Size(146, 25)
        Me.txtDayOfCreate.TabIndex = 11
        '
        'lblDateOfCreate
        '
        Me.lblDateOfCreate.AutoSize = True
        Me.lblDateOfCreate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDateOfCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblDateOfCreate.Location = New System.Drawing.Point(624, 133)
        Me.lblDateOfCreate.Name = "lblDateOfCreate"
        Me.lblDateOfCreate.Size = New System.Drawing.Size(96, 17)
        Me.lblDateOfCreate.TabIndex = 10
        Me.lblDateOfCreate.Text = "Ngày đăng ký"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(928, 34)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(147, 56)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Cập nhật"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(928, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 56)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Thoát"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmQuickUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 233)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtDayOfCreate)
        Me.Controls.Add(Me.lblDateOfCreate)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtDayOfBirth)
        Me.Controls.Add(Me.txDayOfBirth)
        Me.Controls.Add(Me.txtNameOfCustomer)
        Me.Controls.Add(Me.lblNameOfCustomerSecond)
        Me.Controls.Add(Me.txtIDCustomer)
        Me.Controls.Add(Me.lblIDCustomer)
        Me.Controls.Add(Me.lblNameOfCustomer)
        Me.Controls.Add(Me.lblCustomerFirst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuickUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuickUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerFirst As Label
    Friend WithEvents lblNameOfCustomer As Label
    Friend WithEvents lblIDCustomer As Label
    Friend WithEvents txtIDCustomer As TextBox
    Friend WithEvents txtNameOfCustomer As TextBox
    Friend WithEvents lblNameOfCustomerSecond As Label
    Friend WithEvents txtDayOfBirth As TextBox
    Friend WithEvents txDayOfBirth As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtDayOfCreate As TextBox
    Friend WithEvents lblDateOfCreate As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
