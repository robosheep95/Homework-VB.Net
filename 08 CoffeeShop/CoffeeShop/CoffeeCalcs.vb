''' <summary>
''' Calculations for the coffee shop
''' </summary>
Public Class CoffeeCalcs
    Private coffeePrice As Double()
    Private taxPercentage As Double
    Private PurchaseList As List(Of Double)
    Public Sub New()
        coffeePrice = {3.25, 3.75, 4.0, 3.5, 4.25}
        taxPercentage = 0.07
        PurchaseList = New List(Of Double)
    End Sub
    Public Function GetPrice(ByVal input As Integer)
        Return coffeePrice.ElementAt(input - 1)

    End Function
    Public Function CalculateData(ByVal quantity As Integer, ByVal itemAmount As Double, ByVal takeout As Boolean) As Double()
        Dim subTotal As Double = quantity * itemAmount
        Dim tax As Double
        If (takeout) Then
            tax = subTotal * (taxPercentage)
        Else
            tax = 0.0
        End If
        Dim total As Double = subTotal + tax
        PurchaseList.Add(total)
        Return ({subTotal, tax, total})
    End Function
    Public Function GetSummary() As Double()
        Dim totalSales As Double = PurchaseList.Sum
        Dim averageSales As Double = (PurchaseList.Sum / PurchaseList.Count)
        Dim numOfCustomers As Double = PurchaseList.Count
        Return ({totalSales, averageSales, numOfCustomers})
    End Function
End Class
