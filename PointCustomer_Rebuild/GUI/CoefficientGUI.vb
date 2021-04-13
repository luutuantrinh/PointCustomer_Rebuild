Imports System.Threading

Public Class frmCoefficientGUI
    Private Sub CoefficientGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim OBJ As New frmCustomerGUI
        OBJ.Show()
        Me.Close()
    End Sub

#Region "Method"

    Public Sub LoadData()

        Using dbCoefficient As New ContextClass
            TblCoefficientBindingSource.DataSource = dbCoefficient.Coefficients.ToList()
        End Using

    End Sub

    Public Sub ResetGridView()
        Using dbCoefficient As New ContextClass
            TblCoefficientBindingSource.DataSource = dbCoefficient.Coefficients.ToList()
        End Using
        DataGridViewCoefficient.Refresh()
        'MsgBox("Ok")
    End Sub

#End Region


#Region "Cập nhật thông tin row"

    Public Shared start_1 As Boolean

#Region "Đưa dữ liệu sang form khác"

    Private Sub DataGridViewCoefficient_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCoefficient.CellDoubleClick
        start_thearing()
        Dim OBJ As New frmQuickChange_Coeficent

        Dim i As Integer
        i = DataGridViewCoefficient.CurrentRow.Index
        OBJ.txtIDCoefficient.Text = DataGridViewCoefficient.Item(0, i).Value
        OBJ.txtNameOfEvent_Coeffient.Text = DataGridViewCoefficient.Item(1, i).Value
        OBJ.txtNumberOfCoefficient.Text = DataGridViewCoefficient.Item(2, i).Value
        OBJ.Show()
    End Sub

#End Region

#Region "Xử lý với Thread - nhận bản ghi "
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start_1 = True Then
                    Me.BeginInvoke(New process_data(AddressOf ResetGridView))
                End If
                start_1 = False
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