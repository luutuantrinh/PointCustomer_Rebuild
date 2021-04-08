Imports System.Data.Entity

Public Class ContextClass
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=con")
        Database.SetInitializer(Of ContextClass)(New CreateDatabaseIfNotExists(Of ContextClass)())
    End Sub


    ' cách chạy auto stored procedured toàn bộ hàm vào cơ sở dữ liệu 

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Types().Configure(Function(t) t.MapToStoredProcedures())
    End Sub
    Public Property Customers As DbSet(Of tblCustomer)

    Public Property Events As DbSet(Of tblEvent)
    Public Property InitializationPoints As DbSet(Of tblInitializationPoint)
End Class
