Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class point2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.tblCoefficients",
                Function(c) New With
                    {
                        .IDCoefficient = c.String(nullable := False, maxLength := 10),
                        .CoefficientName = c.String(maxLength := 100),
                        .CoefficientNumber = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.IDCoefficient)
            
            CreateStoredProcedure(
                "dbo.tblCoefficient_Insert",
                Function(p) New With
                    {
                        .IDCoefficient = p.String(maxLength := 10),
                        .CoefficientName = p.String(maxLength := 100),
                        .CoefficientNumber = p.Int()
                    },
                body :=
                    "INSERT [dbo].[tblCoefficients]([IDCoefficient], [CoefficientName], [CoefficientNumber])" & vbCrLf & _
                    "VALUES (@IDCoefficient, @CoefficientName, @CoefficientNumber)"
            )
            
            CreateStoredProcedure(
                "dbo.tblCoefficient_Update",
                Function(p) New With
                    {
                        .IDCoefficient = p.String(maxLength := 10),
                        .CoefficientName = p.String(maxLength := 100),
                        .CoefficientNumber = p.Int()
                    },
                body :=
                    "UPDATE [dbo].[tblCoefficients]" & vbCrLf & _
                    "SET [CoefficientName] = @CoefficientName, [CoefficientNumber] = @CoefficientNumber" & vbCrLf & _
                    "WHERE ([IDCoefficient] = @IDCoefficient)"
            )
            
            CreateStoredProcedure(
                "dbo.tblCoefficient_Delete",
                Function(p) New With
                    {
                        .IDCoefficient = p.String(maxLength := 10)
                    },
                body :=
                    "DELETE [dbo].[tblCoefficients]" & vbCrLf & _
                    "WHERE ([IDCoefficient] = @IDCoefficient)"
            )
            
        End Sub
        
        Public Overrides Sub Down()
            DropStoredProcedure("dbo.tblCoefficient_Delete")
            DropStoredProcedure("dbo.tblCoefficient_Update")
            DropStoredProcedure("dbo.tblCoefficient_Insert")
            DropTable("dbo.tblCoefficients")
        End Sub
    End Class
End Namespace
