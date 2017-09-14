Public Class frmMainMenu
    Private dtbTranactions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtbTranactions = New DataTable("Transactions")
        Dim colLable = New DataColumn()
        Dim colAmount = New DataColumn()
        dtbTranactions.Columns.Add(colLable)
        dtbTranactions.Columns.Add(colAmount)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If (rbnCheck.Checked()) Then
            Dim workRow As DataRow = dtbTranactions.NewRow()
            workRow(0) = "Check"
            workRow(1) = tbxInput
            dtbTranactions.Rows.Add(workRow)
        ElseIf (rbnDeposit.Checked()) Then

        ElseIf (rbnService.Checked()) Then

        Else
            MsgBox("Please select a tranaction type.", vbOK + vbExclamation, "Transaction Error")
        End If
    End Sub

    Private Sub rbnCheck_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCheck.CheckedChanged

    End Sub
End Class
