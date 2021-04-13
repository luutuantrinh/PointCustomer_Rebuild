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
#End Region
End Class