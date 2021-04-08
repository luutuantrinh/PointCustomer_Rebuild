<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPointGUI
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblNameOfFromCus = New System.Windows.Forms.Label()
        Me.DataGridViewPontCustomer = New System.Windows.Forms.DataGridView()
        Me.btnFromPointToAddPoint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.IDInitializationPointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInitializationPointBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridViewPontCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInitializationPointBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNameOfFromCus
        '
        Me.lblNameOfFromCus.AutoSize = True
        Me.lblNameOfFromCus.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNameOfFromCus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblNameOfFromCus.Location = New System.Drawing.Point(363, 24)
        Me.lblNameOfFromCus.Name = "lblNameOfFromCus"
        Me.lblNameOfFromCus.Size = New System.Drawing.Size(252, 24)
        Me.lblNameOfFromCus.TabIndex = 1
        Me.lblNameOfFromCus.Text = "Thông tin điểm khách hàng"
        '
        'DataGridViewPontCustomer
        '
        Me.DataGridViewPontCustomer.AutoGenerateColumns = False
        Me.DataGridViewPontCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPontCustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewPontCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewPontCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPontCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDInitializationPointDataGridViewTextBoxColumn, Me.IDCustomerDataGridViewTextBoxColumn, Me.MoneyDataGridViewTextBoxColumn, Me.PointDataGridViewTextBoxColumn, Me.DateOfPurchaseDataGridViewTextBoxColumn})
        Me.DataGridViewPontCustomer.DataSource = Me.TblInitializationPointBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPontCustomer.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPontCustomer.Location = New System.Drawing.Point(32, 63)
        Me.DataGridViewPontCustomer.Name = "DataGridViewPontCustomer"
        Me.DataGridViewPontCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPontCustomer.Size = New System.Drawing.Size(899, 318)
        Me.DataGridViewPontCustomer.TabIndex = 2
        '
        'btnFromPointToAddPoint
        '
        Me.btnFromPointToAddPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnFromPointToAddPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnFromPointToAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFromPointToAddPoint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFromPointToAddPoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnFromPointToAddPoint.Location = New System.Drawing.Point(601, 388)
        Me.btnFromPointToAddPoint.Name = "btnFromPointToAddPoint"
        Me.btnFromPointToAddPoint.Size = New System.Drawing.Size(147, 56)
        Me.btnFromPointToAddPoint.TabIndex = 13
        Me.btnFromPointToAddPoint.Text = "Nhập điểm KH"
        Me.btnFromPointToAddPoint.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(784, 388)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 56)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Thoát"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'IDInitializationPointDataGridViewTextBoxColumn
        '
        Me.IDInitializationPointDataGridViewTextBoxColumn.DataPropertyName = "IDInitializationPoint"
        Me.IDInitializationPointDataGridViewTextBoxColumn.HeaderText = "IDInitializationPoint"
        Me.IDInitializationPointDataGridViewTextBoxColumn.Name = "IDInitializationPointDataGridViewTextBoxColumn"
        '
        'IDCustomerDataGridViewTextBoxColumn
        '
        Me.IDCustomerDataGridViewTextBoxColumn.DataPropertyName = "IDCustomer"
        Me.IDCustomerDataGridViewTextBoxColumn.HeaderText = "IDCustomer"
        Me.IDCustomerDataGridViewTextBoxColumn.Name = "IDCustomerDataGridViewTextBoxColumn"
        '
        'MoneyDataGridViewTextBoxColumn
        '
        Me.MoneyDataGridViewTextBoxColumn.DataPropertyName = "Money"
        Me.MoneyDataGridViewTextBoxColumn.HeaderText = "Money"
        Me.MoneyDataGridViewTextBoxColumn.Name = "MoneyDataGridViewTextBoxColumn"
        '
        'PointDataGridViewTextBoxColumn
        '
        Me.PointDataGridViewTextBoxColumn.DataPropertyName = "Point"
        Me.PointDataGridViewTextBoxColumn.HeaderText = "Point"
        Me.PointDataGridViewTextBoxColumn.Name = "PointDataGridViewTextBoxColumn"
        '
        'DateOfPurchaseDataGridViewTextBoxColumn
        '
        Me.DateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "DateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "DateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Name = "DateOfPurchaseDataGridViewTextBoxColumn"
        '
        'TblInitializationPointBindingSource
        '
        Me.TblInitializationPointBindingSource.DataSource = GetType(PointCustomer_Rebuild.tblInitializationPoint)
        '
        'frmPointGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(961, 456)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFromPointToAddPoint)
        Me.Controls.Add(Me.DataGridViewPontCustomer)
        Me.Controls.Add(Me.lblNameOfFromCus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPointGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PointGUI"
        CType(Me.DataGridViewPontCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInitializationPointBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameOfFromCus As Label
    Friend WithEvents DataGridViewPontCustomer As DataGridView
    Friend WithEvents btnFromPointToAddPoint As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents TblInitializationPointBindingSource As BindingSource
    Friend WithEvents IDInitializationPointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
