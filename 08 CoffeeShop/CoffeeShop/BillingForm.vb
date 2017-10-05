Public Class frmMain
    Private coffeeManager
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coffeeManager = New CoffeeCalcs()
    End Sub


End Class
