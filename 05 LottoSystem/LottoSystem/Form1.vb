Public Class frmMain
    Private objLotto As Lotto
    Private intAnswer() As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objLotto = New Lotto()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim output As IEnumerable(Of Integer) = {Val(tbxInput1.Text.Trim), Val(tbxInput2.Text.Trim), Val(tbxInput3.Text.Trim), Val(tbxInput4.Text.Trim), Val(tbxInput5.Text.Trim)}
        If (output.Contains(Val("")) Or output.Distinct.Count <> output.Count) Then
            MsgBox("Invalid Input", vbOK + vbExclamation, "Input Error")
        Else
            DisplayAnswer(objLotto.GenerateAnswer())
            objLotto.CalculateCorrect(output, Val(tbxPowerballInput.Text))
            lblBalance.Text = objLotto.GetBalance().ToString
        End If
    End Sub
    Private Sub DisplayAnswer(input() As Integer)
        tbxNum1.Text = input(0).ToString
        tbxNum2.Text = input(1).ToString
        tbxNum3.Text = input(2).ToString
        tbxNum4.Text = input(3).ToString
        tbxNum5.Text = input(4).ToString
        tbxPowerball.Text = input(5).ToString
    End Sub
End Class
