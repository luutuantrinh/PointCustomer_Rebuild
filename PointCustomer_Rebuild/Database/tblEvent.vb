Imports System.ComponentModel.DataAnnotations

Public Class tblEvent
    <Key>
    <StringLength(10)>
    Public Property IDDayEvent As String
    <StringLength(255)>
    Public Property NameOfEvent As String
    Public Property DayOfEvent As Date

End Class
