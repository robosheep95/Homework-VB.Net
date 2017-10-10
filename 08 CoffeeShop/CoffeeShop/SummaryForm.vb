Public Class SummaryForm
    Public Sub New(input As Double())

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TotalSalesTextBox.Text = input(0)
        AverageSalesTextBox.Text = input(1)
        NumberCustomersTextBox.Text = input(2)

    End Sub

End Class