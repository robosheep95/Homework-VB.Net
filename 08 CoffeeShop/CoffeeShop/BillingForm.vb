Public Class frmMain
    Private coffeeManager

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coffeeManager = New CoffeeCalcs()

    End Sub

    Private Sub SelectCoffee(sender As Object, e As EventArgs) Handles RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click
        ItemAmountTextBox.Text = coffeeManager.getPrice(Val(CType(sender, RadioButton).Text.ElementAt(10)))

    End Sub
End Class
