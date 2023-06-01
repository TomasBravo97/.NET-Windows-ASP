Public Class Order
    Public Property OrderId As String
    Public Property RequiredShippedTimestamp As Long

    Public Property Address As String

    Public Sub New(newOrderId As String, newRequiredShippedTimestamp As Long, newAddress As String)
        OrderId = newOrderId
        RequiredShippedTimestamp = newRequiredShippedTimestamp
        Address = newAddress


    End Sub
End Class
