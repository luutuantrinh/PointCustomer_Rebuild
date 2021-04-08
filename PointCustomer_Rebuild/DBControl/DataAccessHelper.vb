Public Class DataAccessHelper

    ReadOnly _dbContext As ContextClass = New ContextClass()

#Region "Fetch"
    Public Function FetchCustomer() As List(Of tblCustomer)
        Return _dbContext.Customers.ToList()
    End Function

    Public Function FetchEvent() As List(Of tblEvent)
        Return _dbContext.Events.ToList()
    End Function

    Public Function FetchInitializationPoint() As List(Of tblInitializationPoint)
        Return _dbContext.InitializationPoints.ToList()
    End Function
#End Region

#Region "FunctionAdd"
    Public Function AddCustomer(ByVal customer As tblCustomer) As Integer
        _dbContext.Customers.Add(customer)
        _dbContext.SaveChanges()
        Return customer.IDCustomer
    End Function

    Public Function AddEvent(ByVal _event As tblEvent) As Integer
        _dbContext.Events.Add(_event)
        _dbContext.SaveChanges()
        Return _event.IDDayEvent
    End Function


    Public Function AddInitialization(ByVal initializationPoint As tblInitializationPoint) As String
        _dbContext.InitializationPoints.Add(initializationPoint)
        _dbContext.SaveChanges()
        Return initializationPoint.IDInitializationPoint
    End Function

#End Region

End Class
