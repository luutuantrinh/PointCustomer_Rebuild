Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class tblInitializationPoint
    <Key>
    <StringLength(10)>
    Public Property IDInitializationPoint As String


    Public Property Money As System.Nullable(Of Integer)

    Public Property Point As System.Nullable(Of Integer)
    Public Property DateOfPurchase As Date
    Public Property IDCustomer As String

    Public Overridable Property Customer As tblCustomer

End Class
