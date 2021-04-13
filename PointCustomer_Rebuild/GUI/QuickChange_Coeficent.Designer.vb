<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickChange_Coeficent
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
        Me.txtIDCoefficient = New System.Windows.Forms.TextBox()
        Me.lblIDCoefficient = New System.Windows.Forms.Label()
        Me.txtNameOfEvent_Coeffient = New System.Windows.Forms.TextBox()
        Me.lblNameOfEvent_Coeffient = New System.Windows.Forms.Label()
        Me.txtNumberOfCoefficient = New System.Windows.Forms.TextBox()
        Me.lblNumberOfCoefficient = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIDCoefficient
        '
        Me.txtIDCoefficient.Enabled = False
        Me.txtIDCoefficient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtIDCoefficient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtIDCoefficient.Location = New System.Drawing.Point(140, 94)
        Me.txtIDCoefficient.Name = "txtIDCoefficient"
        Me.txtIDCoefficient.Size = New System.Drawing.Size(143, 25)
        Me.txtIDCoefficient.TabIndex = 7
        '
        'lblIDCoefficient
        '
        Me.lblIDCoefficient.AutoSize = True
        Me.lblIDCoefficient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblIDCoefficient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblIDCoefficient.Location = New System.Drawing.Point(25, 97)
        Me.lblIDCoefficient.Name = "lblIDCoefficient"
        Me.lblIDCoefficient.Size = New System.Drawing.Size(73, 17)
        Me.lblIDCoefficient.TabIndex = 6
        Me.lblIDCoefficient.Text = "Mã hệ số "
        '
        'txtNameOfEvent_Coeffient
        '
        Me.txtNameOfEvent_Coeffient.Enabled = False
        Me.txtNameOfEvent_Coeffient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNameOfEvent_Coeffient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtNameOfEvent_Coeffient.Location = New System.Drawing.Point(434, 94)
        Me.txtNameOfEvent_Coeffient.Name = "txtNameOfEvent_Coeffient"
        Me.txtNameOfEvent_Coeffient.Size = New System.Drawing.Size(143, 25)
        Me.txtNameOfEvent_Coeffient.TabIndex = 9
        '
        'lblNameOfEvent_Coeffient
        '
        Me.lblNameOfEvent_Coeffient.AutoSize = True
        Me.lblNameOfEvent_Coeffient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNameOfEvent_Coeffient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNameOfEvent_Coeffient.Location = New System.Drawing.Point(319, 97)
        Me.lblNameOfEvent_Coeffient.Name = "lblNameOfEvent_Coeffient"
        Me.lblNameOfEvent_Coeffient.Size = New System.Drawing.Size(87, 17)
        Me.lblNameOfEvent_Coeffient.TabIndex = 8
        Me.lblNameOfEvent_Coeffient.Text = "Tên sự kiện"
        '
        'txtNumberOfCoefficient
        '
        Me.txtNumberOfCoefficient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNumberOfCoefficient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtNumberOfCoefficient.Location = New System.Drawing.Point(687, 94)
        Me.txtNumberOfCoefficient.Name = "txtNumberOfCoefficient"
        Me.txtNumberOfCoefficient.Size = New System.Drawing.Size(143, 25)
        Me.txtNumberOfCoefficient.TabIndex = 11
        '
        'lblNumberOfCoefficient
        '
        Me.lblNumberOfCoefficient.AutoSize = True
        Me.lblNumberOfCoefficient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNumberOfCoefficient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNumberOfCoefficient.Location = New System.Drawing.Point(600, 97)
        Me.lblNumberOfCoefficient.Name = "lblNumberOfCoefficient"
        Me.lblNumberOfCoefficient.Size = New System.Drawing.Size(47, 17)
        Me.lblNumberOfCoefficient.TabIndex = 10
        Me.lblNumberOfCoefficient.Text = "Hệ số"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(851, 117)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 56)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Thoát"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(851, 31)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(147, 56)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Cập nhật"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmQuickChange_Coeficent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 200)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNumberOfCoefficient)
        Me.Controls.Add(Me.lblNumberOfCoefficient)
        Me.Controls.Add(Me.txtNameOfEvent_Coeffient)
        Me.Controls.Add(Me.lblNameOfEvent_Coeffient)
        Me.Controls.Add(Me.txtIDCoefficient)
        Me.Controls.Add(Me.lblIDCoefficient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuickChange_Coeficent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuickChange_Coeficent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIDCoefficient As TextBox
    Friend WithEvents lblIDCoefficient As Label
    Friend WithEvents txtNameOfEvent_Coeffient As TextBox
    Friend WithEvents lblNameOfEvent_Coeffient As Label
    Friend WithEvents txtNumberOfCoefficient As TextBox
    Friend WithEvents lblNumberOfCoefficient As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
End Class
