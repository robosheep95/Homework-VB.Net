Public Class frmMain
    Private coffeeManager As CoffeeCalcs
    Private summaryForm As SummaryForm
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coffeeManager = New CoffeeCalcs()

    End Sub

    Private Sub SelectCoffee(sender As Object, e As EventArgs) Handles RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click
        If sender.text = "C&appuccino" Then
            ItemAmountTextBox.Text = coffeeManager.GetPrice(1)
        End If
        If sender.text = "Espress&o" Then
            ItemAmountTextBox.Text = coffeeManager.GetPrice(2)
        End If
        If sender.text = "La&tte" Then
            ItemAmountTextBox.Text = coffeeManager.GetPrice(3)
        End If
        If sender.text = "&Iced Latte" Then
            ItemAmountTextBox.Text = coffeeManager.GetPrice(4)
        End If
        If sender.text = "Iced Ca&ppuccino" Then
            ItemAmountTextBox.Text = coffeeManager.GetPrice(5)
        End If
    End Sub

    Private Sub CalculateData(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim dataBack As Double() = coffeeManager.CalculateData(Val(QuantityTextBox.Text), Val(ItemAmountTextBox.Text), TaxCheckBox.Checked)
        SubTotalTextBox.Text = dataBack.ElementAt(0)
        TaxTextBox.Text = dataBack.ElementAt(1)
        TotalTextBox.Text = dataBack.ElementAt(2)
        summaryForm = New SummaryForm(coffeeManager.GetSummary)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        QuantityTextBox.Clear()
        ItemAmountTextBox.Clear()
        SubTotalTextBox.Clear()
        TaxCheckBox.Checked = False
        TotalTextBox.Clear()
    End Sub
End Class
