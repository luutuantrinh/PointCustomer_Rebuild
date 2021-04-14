Public Class IntroGUI
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 2
        If (Panel2.Width >= 705) Then
            Timer1.Stop()
            Dim obj As New frmCustomerGUI
            obj.Show()
            Me.Hide()
        End If
    End Sub
End Class