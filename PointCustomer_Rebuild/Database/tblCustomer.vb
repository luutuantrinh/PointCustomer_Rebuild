Imports System.ComponentModel.DataAnnotations

Public Class tblCustomer
    <Key>
    <StringLength(10)>
    Public Property IDCustomer As String
    <StringLength(255)>
    Public Property FullName As String
    Public Property DateOfBirth As Date
    <StringLength(10)>
    Public Property Contact As String
    Public Property DateOfCreate As Date

    Public Property InitializationPoints As ICollection(Of tblInitializationPoint)

End Class
