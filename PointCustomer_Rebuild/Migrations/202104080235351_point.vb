Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class point
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.tblCustomers",
                Function(c) New With
                    {
                        .IDCustomer = c.String(nullable := False, maxLength := 10),
                        .FullName = c.String(maxLength := 255),
                        .DateOfBirth = c.DateTime(nullable := False),
                        .Contact = c.String(maxLength := 10),
                        .DateOfCreate = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.IDCustomer)
            
            CreateTable(
                "dbo.tblInitializationPoints",
                Function(c) New With
                    {
                        .IDInitializationPoint = c.String(nullable := False, maxLength := 10),
                        .Money = c.Int(),
                        .Point = c.Int(),
                        .DateOfPurchase = c.DateTime(nullable := False),
                        .IDCustomer = c.String(maxLength := 10)
                    }) _
                .PrimaryKey(Function(t) t.IDInitializationPoint) _
                .ForeignKey("dbo.tblCustomers", Function(t) t.IDCustomer) _
                .Index(Function(t) t.IDCustomer)
            
            CreateTable(
                "dbo.tblEvents",
                Function(c) New With
                    {
                        .IDDayEvent = c.String(nullable := False, maxLength := 10),
                        .NameOfEvent = c.String(maxLength := 255),
                        .DayOfEvent = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.IDDayEvent)
            
            CreateStoredProcedure(
                "dbo.tblCustomer_Insert",
                Function(p) New With
                    {
                        .IDCustomer = p.String(maxLength := 10),
                        .FullName = p.String(maxLength := 255),
                        .DateOfBirth = p.DateTime(),
                        .Contact = p.String(maxLength := 10),
                        .DateOfCreate = p.DateTime()
                    },
                body :=
                    "INSERT [dbo].[tblCustomers]([IDCustomer], [FullName], [DateOfBirth], [Contact], [DateOfCreate])" & vbCrLf & _
                    "VALUES (@IDCustomer, @FullName, @DateOfBirth, @Contact, @DateOfCreate)"
            )
            
            CreateStoredProcedure(
                "dbo.tblCustomer_Update",
                Function(p) New With
                    {
                        .IDCustomer = p.String(maxLength := 10),
                        .FullName = p.String(maxLength := 255),
                        .DateOfBirth = p.DateTime(),
                        .Contact = p.String(maxLength := 10),
                        .DateOfCreate = p.DateTime()
                    },
                body :=
                    "UPDATE [dbo].[tblCustomers]" & vbCrLf & _
                    "SET [FullName] = @FullName, [DateOfBirth] = @DateOfBirth, [Contact] = @Contact, [DateOfCreate] = @DateOfCreate" & vbCrLf & _
                    "WHERE ([IDCustomer] = @IDCustomer)"
            )
            
            CreateStoredProcedure(
                "dbo.tblCustomer_Delete",
                Function(p) New With
                    {
                        .IDCustomer = p.String(maxLength := 10)
                    },
                body :=
                    "DELETE [dbo].[tblCustomers]" & vbCrLf & _
                    "WHERE ([IDCustomer] = @IDCustomer)"
            )
            
            CreateStoredProcedure(
                "dbo.tblInitializationPoint_Insert",
                Function(p) New With
                    {
                        .IDInitializationPoint = p.String(maxLength := 10),
                        .Money = p.Int(),
                        .Point = p.Int(),
                        .DateOfPurchase = p.DateTime(),
                        .IDCustomer = p.String(maxLength := 10)
                    },
                body :=
                    "INSERT [dbo].[tblInitializationPoints]([IDInitializationPoint], [Money], [Point], [DateOfPurchase], [IDCustomer])" & vbCrLf & _
                    "VALUES (@IDInitializationPoint, @Money, @Point, @DateOfPurchase, @IDCustomer)"
            )
            
            CreateStoredProcedure(
                "dbo.tblInitializationPoint_Update",
                Function(p) New With
                    {
                        .IDInitializationPoint = p.String(maxLength := 10),
                        .Money = p.Int(),
                        .Point = p.Int(),
                        .DateOfPurchase = p.DateTime(),
                        .IDCustomer = p.String(maxLength := 10)
                    },
                body :=
                    "UPDATE [dbo].[tblInitializationPoints]" & vbCrLf & _
                    "SET [Money] = @Money, [Point] = @Point, [DateOfPurchase] = @DateOfPurchase, [IDCustomer] = @IDCustomer" & vbCrLf & _
                    "WHERE ([IDInitializationPoint] = @IDInitializationPoint)"
            )
            
            CreateStoredProcedure(
                "dbo.tblInitializationPoint_Delete",
                Function(p) New With
                    {
                        .IDInitializationPoint = p.String(maxLength := 10)
                    },
                body :=
                    "DELETE [dbo].[tblInitializationPoints]" & vbCrLf & _
                    "WHERE ([IDInitializationPoint] = @IDInitializationPoint)"
            )
            
            CreateStoredProcedure(
                "dbo.tblEvent_Insert",
                Function(p) New With
                    {
                        .IDDayEvent = p.String(maxLength := 10),
                        .NameOfEvent = p.String(maxLength := 255),
                        .DayOfEvent = p.DateTime()
                    },
                body :=
                    "INSERT [dbo].[tblEvents]([IDDayEvent], [NameOfEvent], [DayOfEvent])" & vbCrLf & _
                    "VALUES (@IDDayEvent, @NameOfEvent, @DayOfEvent)"
            )
            
            CreateStoredProcedure(
                "dbo.tblEvent_Update",
                Function(p) New With
                    {
                        .IDDayEvent = p.String(maxLength := 10),
                        .NameOfEvent = p.String(maxLength := 255),
                        .DayOfEvent = p.DateTime()
                    },
                body :=
                    "UPDATE [dbo].[tblEvents]" & vbCrLf & _
                    "SET [NameOfEvent] = @NameOfEvent, [DayOfEvent] = @DayOfEvent" & vbCrLf & _
                    "WHERE ([IDDayEvent] = @IDDayEvent)"
            )
            
            CreateStoredProcedure(
                "dbo.tblEvent_Delete",
                Function(p) New With
                    {
                        .IDDayEvent = p.String(maxLength := 10)
                    },
                body :=
                    "DELETE [dbo].[tblEvents]" & vbCrLf & _
                    "WHERE ([IDDayEvent] = @IDDayEvent)"
            )
            
        End Sub
        
        Public Overrides Sub Down()
            DropStoredProcedure("dbo.tblEvent_Delete")
            DropStoredProcedure("dbo.tblEvent_Update")
            DropStoredProcedure("dbo.tblEvent_Insert")
            DropStoredProcedure("dbo.tblInitializationPoint_Delete")
            DropStoredProcedure("dbo.tblInitializationPoint_Update")
            DropStoredProcedure("dbo.tblInitializationPoint_Insert")
            DropStoredProcedure("dbo.tblCustomer_Delete")
            DropStoredProcedure("dbo.tblCustomer_Update")
            DropStoredProcedure("dbo.tblCustomer_Insert")
            DropForeignKey("dbo.tblInitializationPoints", "IDCustomer", "dbo.tblCustomers")
            DropIndex("dbo.tblInitializationPoints", New String() { "IDCustomer" })
            DropTable("dbo.tblEvents")
            DropTable("dbo.tblInitializationPoints")
            DropTable("dbo.tblCustomers")
        End Sub
    End Class
End Namespace
