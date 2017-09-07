Public Class MainForm

    Private objCalculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCalculator = New Calculator
    End Sub

    Private Function IsValidNumbers(strInput1 As String, strInput2 As String) As Boolean
        If (IsNumeric(strInput1) And IsNumeric(strInput2)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub outputErrorMessage()
        MsgBox("Invalid Character Detected. Please use numbers only")
    End Sub
    Private Sub outputTotal()
        txtRibbon.Text = objCalculator.ReturnTotal()
    End Sub

    Private Sub WriteNumber(sender As Object, e As EventArgs) Handles btnNum2.Click, btnNum3.Click, btnNum4.Click, btnNum5.Click, btnNum6.Click, btnNum9.Click, btnNum8.Click, btnNum7.Click, btnNum0.Click, btnNum1.Click
        txtRibbon.Text = txtRibbon.Text + sender.Text
    End Sub
End Class