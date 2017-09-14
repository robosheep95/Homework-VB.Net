Public Class frmMainMenu
    Private intTotal As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intTotal = 0
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If (rbnDeposit.Checked()) Then
            lbxTransactions.Items.Add(String.Format("{0} {1}", "Check", tbxInput.Text, vbCrLf))
            intTotal += Val(tbxInput.Text)
        ElseIf (rbnCheck.Checked()) Then
            If ((intTotal - Val(tbxInput.Text) > 0)) Then
                lbxTransactions.Items.Add(String.Format("{0} {1}", "Deposit", "-" + tbxInput.Text, vbCrLf))
                intTotal -= Val(tbxInput.Text)
            Else
                MsgBox("Insufficient funds. An overdraft of $10 has been credited to your account", vbOK + vbExclamation, "Insufficient funds")
                lbxTransactions.Items.Add(String.Format("{0} {1}", "Service Charge", "-10", vbCrLf))
                intTotal -= 10
            End If

        ElseIf (rbnService.Checked()) Then
            lbxTransactions.Items.Add(String.Format("{0} {1}", "Service Charge", "-" + tbxInput.Text, vbCrLf))
            intTotal -= Val(tbxInput.Text)
        Else
            MsgBox("Please select a tranaction type.", vbOK + vbExclamation, "Transaction Error")
        End If
        tbxTotal.Text = intTotal.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxTransactions.Items.Clear()
        intTotal = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim intTotalDeposit As Integer = 0
        Dim intTotalDepositAmount As Integer = 0
        Dim intTotalCheck As Integer = 0
        Dim intTotalCheckAmount As Integer = 0
        Dim intTotalService As Integer = 0
        Dim intTotalServiceAmount As Integer = 0
        For Each item In lbxTransactions.Items
            Dim strItem As String = item.ToString
            If (strItem.Contains("Deposit")) Then
                intTotalDeposit += 1
                intTotalDepositAmount += Val(strItem.Substring(8))
            ElseIf (strItem.Contains("Check")) Then
                intTotalCheck += 1
                intTotalCheckAmount += Val(strItem.Substring(6))
            ElseIf (strItem.Contains("Service Charge")) Then
                intTotalService += 1
                intTotalServiceAmount += Val(strItem.Substring(14))
            End If
        Next
        MsgBox("Summary:" & Environment.NewLine &
               "Number of Checks: " + intTotalCheck.ToString + "" & Environment.NewLine &
               "Total Amount of Checks: " + intTotalCheckAmount.ToString + "" & Environment.NewLine &
               "Number of Deposits:" + intTotalDeposit.ToString + "" & Environment.NewLine &
               "Total Amount of Deposits: " + intTotalDepositAmount.ToString + "" & Environment.NewLine &
               "Number of Service Charges: " + intTotalService.ToString + "" & Environment.NewLine &
               "Total Amount of Service Charges: " + intTotalServiceAmount.ToString,
               vbOK + vbInformation, "Summary")
    End Sub
End Class
