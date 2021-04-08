<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPointGUI
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbIDCustomer = New System.Windows.Forms.ComboBox()
        Me.lblIDCustomer = New System.Windows.Forms.Label()
        Me.txtIDInitialization = New System.Windows.Forms.TextBox()
        Me.lblIDInitializationPoint = New System.Windows.Forms.Label()
        Me.txtNameOfCustomer = New System.Windows.Forms.TextBox()
        Me.lblNameOfCustomer = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblPointCalculator = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusActive = New System.Windows.Forms.Label()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(471, 12)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(176, 24)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Nhập điểm tích lũy"
        '
        'cbIDCustomer
        '
        Me.cbIDCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbIDCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cbIDCustomer.FormattingEnabled = True
        Me.cbIDCustomer.Location = New System.Drawing.Point(208, 156)
        Me.cbIDCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.cbIDCustomer.Name = "cbIDCustomer"
        Me.cbIDCustomer.Size = New System.Drawing.Size(253, 25)
        Me.cbIDCustomer.TabIndex = 3
        '
        'lblIDCustomer
        '
        Me.lblIDCustomer.AutoSize = True
        Me.lblIDCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblIDCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblIDCustomer.Location = New System.Drawing.Point(33, 160)
        Me.lblIDCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDCustomer.Name = "lblIDCustomer"
        Me.lblIDCustomer.Size = New System.Drawing.Size(108, 17)
        Me.lblIDCustomer.TabIndex = 4
        Me.lblIDCustomer.Text = "Mã khách hàng"
        '
        'txtIDInitialization
        '
        Me.txtIDInitialization.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtIDInitialization.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtIDInitialization.Location = New System.Drawing.Point(210, 102)
        Me.txtIDInitialization.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDInitialization.Name = "txtIDInitialization"
        Me.txtIDInitialization.Size = New System.Drawing.Size(252, 25)
        Me.txtIDInitialization.TabIndex = 6
        '
        'lblIDInitializationPoint
        '
        Me.lblIDInitializationPoint.AutoSize = True
        Me.lblIDInitializationPoint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblIDInitializationPoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblIDInitializationPoint.Location = New System.Drawing.Point(33, 106)
        Me.lblIDInitializationPoint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDInitializationPoint.Name = "lblIDInitializationPoint"
        Me.lblIDInitializationPoint.Size = New System.Drawing.Size(92, 17)
        Me.lblIDInitializationPoint.TabIndex = 5
        Me.lblIDInitializationPoint.Text = "Mã giao dịch"
        '
        'txtNameOfCustomer
        '
        Me.txtNameOfCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNameOfCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtNameOfCustomer.Location = New System.Drawing.Point(210, 222)
        Me.txtNameOfCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNameOfCustomer.Name = "txtNameOfCustomer"
        Me.txtNameOfCustomer.Size = New System.Drawing.Size(252, 25)
        Me.txtNameOfCustomer.TabIndex = 8
        '
        'lblNameOfCustomer
        '
        Me.lblNameOfCustomer.AutoSize = True
        Me.lblNameOfCustomer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNameOfCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblNameOfCustomer.Location = New System.Drawing.Point(33, 226)
        Me.lblNameOfCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameOfCustomer.Name = "lblNameOfCustomer"
        Me.lblNameOfCustomer.Size = New System.Drawing.Size(112, 17)
        Me.lblNameOfCustomer.TabIndex = 7
        Me.lblNameOfCustomer.Text = "Tên khách hàng"
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblPoint.Location = New System.Drawing.Point(512, 160)
        Me.lblPoint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(95, 17)
        Me.lblPoint.TabIndex = 9
        Me.lblPoint.Text = "Quy đổi điểm"
        '
        'txtMoney
        '
        Me.txtMoney.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtMoney.Location = New System.Drawing.Point(616, 102)
        Me.txtMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(252, 25)
        Me.txtMoney.TabIndex = 11
        Me.txtMoney.Text = "Nhập vào số tiền"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblMoney.Location = New System.Drawing.Point(512, 106)
        Me.lblMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(53, 17)
        Me.lblMoney.TabIndex = 10
        Me.lblMoney.Text = "Số tiền"
        '
        'lblPointCalculator
        '
        Me.lblPointCalculator.AutoSize = True
        Me.lblPointCalculator.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblPointCalculator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblPointCalculator.Location = New System.Drawing.Point(615, 160)
        Me.lblPointCalculator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPointCalculator.Name = "lblPointCalculator"
        Me.lblPointCalculator.Size = New System.Drawing.Size(60, 17)
        Me.lblPointCalculator.TabIndex = 12
        Me.lblPointCalculator.Text = "Số điểm"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(512, 222)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(74, 17)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Trạng thái"
        '
        'lblStatusActive
        '
        Me.lblStatusActive.AutoSize = True
        Me.lblStatusActive.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblStatusActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblStatusActive.Location = New System.Drawing.Point(617, 222)
        Me.lblStatusActive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusActive.Name = "lblStatusActive"
        Me.lblStatusActive.Size = New System.Drawing.Size(30, 17)
        Me.lblStatusActive.TabIndex = 14
        Me.lblStatusActive.Text = "X 0"
        '
        'btnCalculator
        '
        Me.btnCalculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnCalculator.Location = New System.Drawing.Point(731, 140)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(137, 41)
        Me.btnCalculator.TabIndex = 15
        Me.btnCalculator.Text = "Tính điểm"
        Me.btnCalculator.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(971, 85)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(147, 56)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Lưu"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(971, 183)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(147, 56)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Thoát"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(620, 267)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 25)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(512, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ngày giao dịch"
        '
        'frmAddPointGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 321)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.lblStatusActive)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPointCalculator)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.txtNameOfCustomer)
        Me.Controls.Add(Me.lblNameOfCustomer)
        Me.Controls.Add(Me.txtIDInitialization)
        Me.Controls.Add(Me.lblIDInitializationPoint)
        Me.Controls.Add(Me.lblIDCustomer)
        Me.Controls.Add(Me.cbIDCustomer)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddPointGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPointGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cbIDCustomer As ComboBox
    Friend WithEvents lblIDCustomer As Label
    Friend WithEvents txtIDInitialization As TextBox
    Friend WithEvents lblIDInitializationPoint As Label
    Friend WithEvents txtNameOfCustomer As TextBox
    Friend WithEvents lblNameOfCustomer As Label
    Friend WithEvents lblPoint As Label
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblPointCalculator As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStatusActive As Label
    Friend WithEvents btnCalculator As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
