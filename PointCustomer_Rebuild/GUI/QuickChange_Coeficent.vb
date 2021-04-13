Imports System.Threading

Public Class frmQuickChange_Coeficent
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


#Region "Lưu dữ liệu vào bảng hệ số"
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
        frmCoefficientGUI.start_1 = True
    End Sub


#End Region

#Region "Thao tác lưu"
    Protected Sub UpdateToGridView()

        Dim db As ContextClass = New ContextClass
        Dim model As tblCoefficient = New tblCoefficient()
        Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0
    Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Chưa có dữ liệu trong các ô , hãy chọn 1 trường dữ liệu",
                    String.Join(",", emptyTextBoxes)))
        Else
            model = db.Coefficients.Where(Function(x) x.IDCoefficient = txtIDCoefficient.Text).FirstOrDefault()
            If (model Is Nothing) Then

            End If
            model.IDCoefficient = txtIDCoefficient.Text
            model.CoefficientName = txtNameOfEvent_Coeffient.Text
            model.CoefficientNumber = Convert.ToInt32(txtNumberOfCoefficient.Text)

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