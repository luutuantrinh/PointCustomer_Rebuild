Public Class frmAddPointGUI
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Dim OBJ As New frmPointGUI
        OBJ.Show()
    End Sub

    Private Sub frmAddPointGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As ContextClass = New ContextClass
        cbIDCustomer.DataSource = (From c In db.Customers Select c.IDCustomer, c.FullName).ToList()
        cbIDCustomer.DisplayMember = "IDCustomer"
    End Sub

    Private Sub cbIDCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIDCustomer.SelectedIndexChanged
        Dim a = cbIDCustomer.SelectedItem
        txtNameOfCustomer.Text = a.FullName
    End Sub

#Region "Xử lý với tính toàn số tiền"
    Private Sub txtMoney_Enter(sender As Object, e As EventArgs) Handles txtMoney.Enter
        If txtMoney.Text = "Nhập vào số tiền" Then
            txtMoney.Text = ""
        End If
    End Sub

    'Chặn người dùng nhập chữ vào
    Private Sub txtMoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMoney.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso ((TryCast(sender, TextBox)).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    ' Chuyển tiền thành điểm 
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Dim tempPoint As Integer
        tempPoint = 0
        tempPoint = Convert.ToInt32(Me.txtMoney.Text) / 50000
        If Me.lblStatusActive.Text = "X 2" Then
            tempPoint *= 2
        ElseIf Me.lblStatusActive.Text = "X 1" Then
            tempPoint = tempPoint * 1

        End If
        lblPointCalculator.Text = tempPoint.ToString
        XuLyNgay()

    End Sub

#Region " Xử lý ngày để quyết xem có nhân đôi điểm không "

    Protected Sub XuLyNgay()
        Dim tempDate As Date
        tempDate = DateTimePicker1.Value.ToShortDateString()
        'MsgBox(tempDate)
        Dim db As ContextClass = New ContextClass()

        Dim dateVariables As Date
        dateVariables = db.Events.Where(Function(u) u.DayOfEvent = tempDate).Select(Function(u) u.DayOfEvent).SingleOrDefault()
        'MsgBox(dateVariables)
        If dateVariables = tempDate Then
            Me.lblStatusActive.Text = "X 2"
        Else
            Me.lblStatusActive.Text = "X 1"
        End If
    End Sub
#End Region

#End Region


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tempDate As Date
        tempDate = DateTimePicker1.Value.ToShortDateString()
        MsgBox(tempDate)
        Dim db As ContextClass = New ContextClass()

        Dim dateVariables As Date
        dateVariables = db.Events.Where(Function(u) u.DayOfEvent = tempDate).Select(Function(u) u.DayOfEvent).SingleOrDefault()
        MsgBox(dateVariables)
        If dateVariables = tempDate Then
            MsgBox("ok")
        End If
    End Sub

End Class