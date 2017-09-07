Public Class frmMain
    Private Sub cbxContact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxContact.SelectedIndexChanged
        If sender.Text = "Cell Phone" Then
            tbxOutput.Text = "(816) 500-6730"
        ElseIf sender.Text = "Work Phone" Then
            tbxOutput.Text = "(816) 229-6000"
        ElseIf sender.Text = "Address" Then
            tbxOutput.Text = "Grain Valley, Missouri"
        ElseIf sender.Text = "Website" Then
            tbxOutput.Text = "www.terra-dome.com"
        Else
            tbxOutput.Text = "<-- Select Contact Option"
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxContact.SelectedIndex = 0
    End Sub
End Class
