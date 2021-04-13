Imports System.ComponentModel.DataAnnotations

Public Class tblCoefficient
    <Key>
    <StringLength(10)>
    Public Property IDCoefficient As String
    <StringLength(100)>
    Public Property CoefficientName As String
    Public Property CoefficientNumber As System.Nullable(Of Integer)
End Class
