Imports System.Data.Entity

Public Class frmAddPointGUI
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Dim OBJ As New frmPointGUI
        OBJ.Show()
    End Sub

    Private Sub frmAddPointGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As ContextClass = New ContextClass
        cbIDCustomer.DataSource = (From c In db.Customers Select c.IDCustomer, c.FullName, c.Contact, c.DateOfCreate).ToList()
        cbIDCustomer.DisplayMember = "IDCustomer"
    End Sub

    Private Sub cbIDCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIDCustomer.SelectedIndexChanged
        Dim a = cbIDCustomer.SelectedItem
        txtNameOfCustomer.Text = a.FullName
        txtContact.Text = a.Contact
        txtDayOfCreate.Text = a.DateOfCreate
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

    '' Chuyển tiền thành điểm 
    'Private Sub btnCalculator_Click(sender As Object, e As EventArgs)
    '    XuLyNgay()
    '    Dim tempPoint As Integer
    '    tempPoint = 0
    '    'Fix lỗi lượng tiền chứa dc là quá nhỏ ToInt32 > ToInt64
    '    tempPoint = Convert.ToInt64(Me.txtMoney.Text) / 50000
    '    If Me.lblStatusActive.Text = "X 2" Then
    '        tempPoint *= 2
    '    ElseIf Me.lblStatusActive.Text = "X 1" Then
    '        tempPoint = tempPoint * 1

    '    End If
    '    lblPointCalculator.Text = tempPoint.ToString


    'End Sub

    'Xử lý sự kiện khi thay đổi timePicker
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dim tempDate As Date
        tempDate = DateTimePicker1.Value.ToShortDateString()
        'MsgBox(tempDate)
        Dim db As ContextClass = New ContextClass()

        'Lấy ngày trùng với ngày có trong bảng Event 
        Dim dateVariables As Date
        dateVariables = db.Events.Where(Function(u) u.DayOfEvent = tempDate).Select(Function(u) u.DayOfEvent).SingleOrDefault()
        'MsgBox(dateVariables)

        'Lấy ra ngày sinh trùng với mã khách hàng trong textbox 
        Dim dateVariablesBỉthday As Date
        dateVariablesBỉthday = db.Customers.Where(Function(u) u.IDCustomer = cbIDCustomer.Text).Select(Function(u) u.DateOfBirth).SingleOrDefault()
        ' MsgBox(dateVariablesBỉthday)

        'Lấy ngày tháng của ngày chọn trong ngày sinh của người đang được chọn 
        Dim monthBirth = dateVariablesBỉthday.Month()
        Dim dayBirth = dateVariablesBỉthday.Day()

        'Lấy ngày tháng của ngày chọn trong picktime
        Dim tempDateCustom As Date
        tempDateCustom = DateTimePicker1.Value.Date()
        Dim month = tempDateCustom.Month()
        Dim day = tempDateCustom.Day()

        Dim tempNumberOfCoefficientNormal As Integer
        tempNumberOfCoefficientNormal = db.Coefficients.Where(Function(u) u.IDCoefficient = "CO01").Select(Function(u) u.CoefficientNumber).SingleOrDefault()
        'MsgBox(tempNumberOfCoefficientNormal)
        Dim tempNumberOfCoefficientEvent As Integer
        tempNumberOfCoefficientEvent = db.Coefficients.Where(Function(u) u.IDCoefficient = "CO02").Select(Function(u) u.CoefficientNumber).SingleOrDefault()

        Dim tempNumberOfCoefficientBirthday As Integer
        tempNumberOfCoefficientBirthday = db.Coefficients.Where(Function(u) u.IDCoefficient = "CO03").Select(Function(u) u.CoefficientNumber).SingleOrDefault()
        'MsgBox(tempNumberOfCoefficientBirthday)

        Dim tempPoint As Integer
        tempPoint = 0


        'Fix lỗi lượng tiền chứa dc là quá nhỏ ToInt32 > ToInt64
        tempPoint = Convert.ToInt64(Me.txtMoney.Text) / 50000

        'Hiển thị hệ số và tính toán mức điểm 
        If dateVariables = tempDate Then
            Me.lblStatusActive.Text = "X " + Convert.ToString(tempNumberOfCoefficientEvent)
            tempPoint *= tempNumberOfCoefficientEvent
        ElseIf month = monthBirth And day = dayBirth Then

            Me.lblStatusActive.Text = "X " + Convert.ToString(tempNumberOfCoefficientBirthday)
            tempPoint *= tempNumberOfCoefficientBirthday
        Else
            Me.lblStatusActive.Text = "X " + Convert.ToString(tempNumberOfCoefficientNormal)
            tempPoint *= tempNumberOfCoefficientNormal
        End If
        lblPointCalculator.Text = tempPoint.ToString


    End Sub
    '#Region " Xử lý ngày để quyết xem có thay đổi hệ số điểm không "

    '    Protected Sub XuLyNgay()
    '        Dim tempDate As Date
    '        tempDate = DateTimePicker1.Value.ToShortDateString()
    '        'MsgBox(tempDate)
    '        Dim db As ContextClass = New ContextClass()

    '        'Lấy ngày trùng với ngày có trong bảng Event 
    '        Dim dateVariables As Date
    '        dateVariables = db.Events.Where(Function(u) u.DayOfEvent = tempDate).Select(Function(u) u.DayOfEvent).SingleOrDefault()
    '        'MsgBox(dateVariables)

    '        'Lấy ra ngày sinh trùng với mã khách hàng trong textbox 
    '        Dim dateVariablesBỉthday As Date
    '        dateVariablesBỉthday = db.Customers.Where(Function(u) u.IDCustomer = cbIDCustomer.Text).Select(Function(u) u.DateOfBirth).SingleOrDefault()
    '        ' MsgBox(dateVariablesBỉthday)

    '        'Lấy ngày tháng của ngày chọn trong ngày sinh của người đang được chọn 
    '        Dim monthBirth = dateVariablesBỉthday.Month()
    '        Dim dayBirth = dateVariablesBỉthday.Day()

    '        'Lấy ngày tháng của ngày chọn trong picktime
    '        Dim tempDateCustom As Date
    '        tempDateCustom = DateTimePicker1.Value.Date()
    '        Dim month = tempDateCustom.Month()
    '        Dim day = tempDateCustom.Day()

    '        Dim tempNumberOfCoefficientNormal As Integer
    '        tempNumberOfCoefficientNormal = db.Coefficients.Where(Function(u) u.IDCoefficient = "CO01").Select(Function(u) u.CoefficientNumber).SingleOrDefault()
    '        'MsgBox(tempNumberOfCoefficientNormal)
    '        Dim tempNumberOfCoefficientEvent As Integer
    '        tempNumberOfCoefficientEvent = db.Coefficients.Where(Function(u) u.IDCoefficient = "CO02").Select(Function(u) u.CoefficientNumber).SingleOrDefault()

    '        Dim tempNumberOfCoefficientBirthday As Integer
    '        tempNumberOfCoefficientBirthday = db.Coefficients.Where(Function(u) u.IDCoefficient = "CO03").Select(Function(u) u.CoefficientNumber).SingleOrDefault()
    '        'MsgBox(tempNumberOfCoefficientBirthday)

    '        If dateVariables = tempDate Then
    '            Me.lblStatusActive.Text = "X " + Convert.ToString(tempNumberOfCoefficientEvent)
    '        ElseIf month = monthBirth And day = dayBirth Then

    '            Me.lblStatusActive.Text = "X " + Convert.ToString(tempNumberOfCoefficientBirthday)
    '        Else
    '            Me.lblStatusActive.Text = "X " + Convert.ToString(tempNumberOfCoefficientNormal)
    '        End If
    '    End Sub
    '#End Region

#End Region


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    Dim tempDate As Date
    '    tempDate = DateTimePicker1.Value.ToShortDateString()
    '    MsgBox(tempDate)
    '    Dim db As ContextClass = New ContextClass()

    '    Dim dateVariables As Date
    '    dateVariables = db.Events.Where(Function(u) u.DayOfEvent = tempDate).Select(Function(u) u.DayOfEvent).SingleOrDefault()
    '    MsgBox(dateVariables)
    '    If dateVariables = tempDate Then
    '        MsgBox("ok")
    '    End If
    'End Sub

#Region "Lưu dữ liêu vào data"

    Protected Sub UpdateToGridView()

        Dim db As ContextClass = New ContextClass
        Dim model As tblInitializationPoint = New tblInitializationPoint()
        Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0
    Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Bạn cần vào số tiền rồi bấm vào tính điểm hoặc bạn chưa nhập dữ liệu vào các trường sau: {0}",
                    String.Join(",", emptyTextBoxes)))
        Else
            model.IDInitializationPoint = txtIDInitialization.Text
            model.IDCustomer = cbIDCustomer.Text
            model.Money = Convert.ToInt32(txtMoney.Text)
            model.DateOfPurchase = Convert.ToDateTime(DateTimePicker1.Text)
            model.Point = Convert.ToInt32(lblPointCalculator.Text)
            db.InitializationPoints.Add(model)
            Dim a = db.SaveChanges()
            If a > 0 Then
                MsgBox("Thêm vào thành công")
            Else
                MsgBox("Chưa được thêm vào")
            End If
        End If


        ' db.Entry(model).State = EntityState.Modified

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim db As ContextClass = New ContextClass()
        Dim idVariables As String
        idVariables = db.InitializationPoints.Where(Function(u) u.IDInitializationPoint = txtIDInitialization.Text).Select(Function(u) u.IDInitializationPoint).SingleOrDefault()
        ' MsgBox(idVariables)
        If idVariables = txtIDInitialization.Text Then
            MsgBox("Mã này đã tồn tại , sử dụng mã khác. ")
            txtIDInitialization.Clear()
        Else
            UpdateToGridView()
        End If


    End Sub

#End Region

End Class