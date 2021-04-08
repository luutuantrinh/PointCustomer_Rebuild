Imports System.Threading

Public Class frmQuickUpdate
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#Region "Lưu Lại dữ liệu"

#Region " Đóng gói dữ liệu và chuyển đi"
    Public Delegate Sub GoiDuLieuXuLy()
    Dim th_GoiDuLieu As Thread

    Public Sub start_thearing()
        th_GoiDuLieu = New Thread(AddressOf XuLyGoiDuLieu)
        th_GoiDuLieu.IsBackground = True
        th_GoiDuLieu.Start()
    End Sub

    Dim f As Boolean
    Public Sub XuLyGoiDuLieu()
        While True
            If f = True Then
                Me.BeginInvoke(New GoiDuLieuXuLy(AddressOf GoiDuLieu))
            End If
            Thread.Sleep(300)
            Exit Sub
        End While
    End Sub

    Public Sub GoiDuLieu()
        frmCustomerGUI.start = True
    End Sub


#End Region

#Region "Thao tác lưu"
    Protected Sub UpdateToGridView()

        Dim db As ContextClass = New ContextClass
        Dim model As tblCustomer = New tblCustomer()
        Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0
    Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Chưa có dữ liệu trong các ô , hãy chọn 1 trường dữ liệu",
                    String.Join(",", emptyTextBoxes)))
        Else
            model = db.Customers.Where(Function(x) x.IDCustomer = txtIDCustomer.Text).FirstOrDefault()
            If (model Is Nothing) Then

            End If
            model.IDCustomer = txtIDCustomer.Text
            model.FullName = txtNameOfCustomer.Text
            model.DateOfBirth = Convert.ToDateTime(txtDayOfBirth.Text)
            model.Contact = txtContact.Text
            model.DateOfCreate = Convert.ToDateTime(txtDayOfCreate.Text)
            'db.Entry(model).State = EntityState.Modified
            Dim a = db.SaveChanges()

            If (a > 0) Then
                MsgBox("Cập nhật thành công")


            Else
                MsgBox("Chưa cập nhật thành công")
            End If




        End If
    End Sub
#End Region

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateToGridView()
        f = True
        start_thearing()
        Me.Hide()
    End Sub
#End Region
End Class