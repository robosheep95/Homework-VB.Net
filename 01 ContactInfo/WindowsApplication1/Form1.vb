Public Class Form1
    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        lblTitle.Text = "Contact Name"
        lblInfo.Text = "Taylor Scafe"
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        lblTitle.Text = "Department"
        lblInfo.Text = "CSIT Department"
    End Sub

    Private Sub btnPhone_Click(sender As Object, e As EventArgs) Handles btnPhone.Click
        lblTitle.Text = "Phone Number"
        lblInfo.Text = "(816) 520 9247"
    End Sub
End Class
