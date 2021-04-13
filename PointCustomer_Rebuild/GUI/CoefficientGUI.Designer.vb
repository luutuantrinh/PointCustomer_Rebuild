<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoefficientGUI
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
        Me.lblCoefficient = New System.Windows.Forms.Label()
        Me.DataGridViewCoefficient = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.IDCoefficientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoefficientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoefficientNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCoefficientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridViewCoefficient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCoefficientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCoefficient
        '
        Me.lblCoefficient.AutoSize = True
        Me.lblCoefficient.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCoefficient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblCoefficient.Location = New System.Drawing.Point(226, 35)
        Me.lblCoefficient.Name = "lblCoefficient"
        Me.lblCoefficient.Size = New System.Drawing.Size(213, 24)
        Me.lblCoefficient.TabIndex = 2
        Me.lblCoefficient.Text = "Thông tin hệ số sự kiện"
        '
        'DataGridViewCoefficient
        '
        Me.DataGridViewCoefficient.AutoGenerateColumns = False
        Me.DataGridViewCoefficient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCoefficient.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewCoefficient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCoefficient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCoefficientDataGridViewTextBoxColumn, Me.CoefficientNameDataGridViewTextBoxColumn, Me.CoefficientNumberDataGridViewTextBoxColumn})
        Me.DataGridViewCoefficient.DataSource = Me.TblCoefficientBindingSource
        Me.DataGridViewCoefficient.Location = New System.Drawing.Point(20, 73)
        Me.DataGridViewCoefficient.Name = "DataGridViewCoefficient"
        Me.DataGridViewCoefficient.Size = New System.Drawing.Size(654, 280)
        Me.DataGridViewCoefficient.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(526, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 56)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Thoát"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'IDCoefficientDataGridViewTextBoxColumn
        '
        Me.IDCoefficientDataGridViewTextBoxColumn.DataPropertyName = "IDCoefficient"
        Me.IDCoefficientDataGridViewTextBoxColumn.HeaderText = "Mã hệ số"
        Me.IDCoefficientDataGridViewTextBoxColumn.Name = "IDCoefficientDataGridViewTextBoxColumn"
        '
        'CoefficientNameDataGridViewTextBoxColumn
        '
        Me.CoefficientNameDataGridViewTextBoxColumn.DataPropertyName = "CoefficientName"
        Me.CoefficientNameDataGridViewTextBoxColumn.HeaderText = "Tên sự kiện theo hệ số"
        Me.CoefficientNameDataGridViewTextBoxColumn.Name = "CoefficientNameDataGridViewTextBoxColumn"
        '
        'CoefficientNumberDataGridViewTextBoxColumn
        '
        Me.CoefficientNumberDataGridViewTextBoxColumn.DataPropertyName = "CoefficientNumber"
        Me.CoefficientNumberDataGridViewTextBoxColumn.HeaderText = "Hệ số"
        Me.CoefficientNumberDataGridViewTextBoxColumn.Name = "CoefficientNumberDataGridViewTextBoxColumn"
        '
        'TblCoefficientBindingSource
        '
        Me.TblCoefficientBindingSource.DataSource = GetType(PointCustomer_Rebuild.tblCoefficient)
        '
        'frmCoefficientGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(695, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DataGridViewCoefficient)
        Me.Controls.Add(Me.lblCoefficient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCoefficientGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoefficientGUI"
        CType(Me.DataGridViewCoefficient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCoefficientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCoefficient As Label
    Friend WithEvents DataGridViewCoefficient As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents IDCoefficientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoefficientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoefficientNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblCoefficientBindingSource As BindingSource
End Class
