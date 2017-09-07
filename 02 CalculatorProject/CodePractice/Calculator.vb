Public Class Calculator
    Private intTotal

    Public Function ReturnTotal() As Integer
        Return intTotal
    End Function
    Public Sub Add(intInput As Integer)
        intTotal = Val(intTotal) + intInput
    End Sub
    Public Sub Subtract(intInput As Integer)
        intTotal = Val(intTotal) - intInput
    End Sub
    Public Sub Multiply(intInput As Integer)
        intTotal = Val(intTotal) * intInput
    End Sub
    Public Sub Devide(intInput As Integer)
        intTotal = Val(intTotal) / intInput
    End Sub
    Public Sub Clear()

    End Sub


End Class
