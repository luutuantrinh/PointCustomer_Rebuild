Imports System.Threading

Public Class frmCustomerGUI
    Dim is_viewing = False
    Private Sub CustomerGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        LoadData()
    End Sub

#Region "Thoát chương trình"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub
#End Region

#Region " Menutrip"
    Private Sub NhậpĐiểmTíchLũyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpĐiểmTíchLũyToolStripMenuItem.Click
        Dim OBJ As New frmAddPointGUI
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub DanhSáchĐiểmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchĐiểmToolStripMenuItem.Click
        Dim OBJ As New frmPointGUI
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub VềChúngTôiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VềChúngTôiToolStripMenuItem.Click

    End Sub
#End Region

#Region " Method"
    Public Sub LoadData()

        Using dbCustomer As New ContextClass
            TblCustomerBindingSource.DataSource = dbCustomer.Customers.ToList()
        End Using

    End Sub
    Public Sub ResetGridView()
        Using dbCustomer As New ContextClass
            TblCustomerBindingSource.DataSource = dbCustomer.Customers.ToList()
        End Using
        DataGridViewCustomer.Refresh()
        'MsgBox("Ok")
    End Sub

    Private Sub DataGridViewCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomer.CellClick
        Dim i As Integer
        i = DataGridViewCustomer.CurrentRow.Index
        Me.txtIDCustomer.Text = DataGridViewCustomer.Item(0, i).Value
        Me.txtNameOfCustomer.Text = DataGridViewCustomer.Item(1, i).Value
        Me.txtDayOfBirth.Text = DataGridViewCustomer.Item(2, i).Value
        Me.txtContact.Text = DataGridViewCustomer.Item(3, i).Value
        Me.txtDayOfCreate.Text = DataGridViewCustomer.Item(4, i).Value
    End Sub

    'làm sạch dữ liệu ở các ô 
    Public Sub ClearTextBox(parent As Control)

        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If
        is_viewing = False
        DataGridViewCustomer.ClearSelection()
    End Sub


#End Region

#Region "Tác vụ"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextBox(Me)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
#End Region

#Region "Tìm kiếm"

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Nhập vào ID khách hàng" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black

        End If
    End Sub

    Private Sub FilterButton_Click()
        Dim db As ContextClass = New ContextClass

        'Dim result = From c In db.Customers Select c.IDCustomer, c.FullName, c.DateOfBirth, c.Contact, c.DateOfCreate
        TblCustomerBindingSource.DataSource = db.Customers.ToList()
        If String.IsNullOrEmpty(Me.txtSearch.Text) Then
            Me.DataGridViewCustomer.DataSource = db.Customers.ToList()
        Else
            Dim filteredData = db.Customers.ToList().Where(Function(x) x.IDCustomer.Contains(Me.txtSearch.Text.ToUpper()))
            Me.DataGridViewCustomer.DataSource = db.Customers.Count() > 0

            Me.DataGridViewCustomer.DataSource = filteredData.ToList()

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterButton_Click()
    End Sub



#End Region

#Region "Cập nhật thông tin row"

    Public Shared start As Boolean
    Private Sub DataGridViewCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomer.CellDoubleClick
        start_thearing()
        Dim OBJ As New frmQuickUpdate

        Dim i As Integer
        i = DataGridViewCustomer.CurrentRow.Index
        OBJ.lblNameOfCustomer.Text = DataGridViewCustomer.Item(1, i).Value
        OBJ.txtIDCustomer.Text = DataGridViewCustomer.Item(0, i).Value
        OBJ.txtNameOfCustomer.Text = DataGridViewCustomer.Item(1, i).Value
        OBJ.txtDayOfBirth.Text = DataGridViewCustomer.Item(2, i).Value
        OBJ.txtContact.Text = DataGridViewCustomer.Item(3, i).Value
        OBJ.txtDayOfCreate.Text = DataGridViewCustomer.Item(4, i).Value
        OBJ.Show()
    End Sub


#Region "Xử lý với Thread - nhận bản ghi "
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf ResetGridView))
                End If
                start = False
                Thread.Sleep(300)
            End While
        Catch ex As Exception

        End Try

    End Sub

    Public Sub start_thearing()
        th_NhanDuLieu = New Thread(AddressOf XuLy)
        th_NhanDuLieu.IsBackground = True
        th_NhanDuLieu.Start()
    End Sub

#End Region

#End Region
End Class