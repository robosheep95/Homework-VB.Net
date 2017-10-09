Public Class CoffeeCalcs

    Private coffeePrice As Double()

    Public Sub New()
        coffeePrice = New Double() {4.25, 5.0, 4.5, 4.5, 4.25}
    End Sub

    Public Function getPrice(i As Integer)
        Return coffeePrice(i)
    End Function

End Class
