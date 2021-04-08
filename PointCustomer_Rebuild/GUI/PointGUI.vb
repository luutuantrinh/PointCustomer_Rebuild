Public Class frmPointGUI
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Dim OBJ As New frmCustomerGUI
        OBJ.Show()
    End Sub

    Private Sub frmPointGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

#Region "mothod"

    Public Sub LoadData()

        Using dbInitializationPoint As New ContextClass
            TblInitializationPointBindingSource.DataSource = dbInitializationPoint.InitializationPoints.ToList()
        End Using

    End Sub

    Private Sub btnFromPointToAddPoint_Click(sender As Object, e As EventArgs) Handles btnFromPointToAddPoint.Click
        Me.Hide()
        Dim OBJ As New frmAddPointGUI
        OBJ.Show()
    End Sub


#End Region
End Class