Public Class Lotto
    Private intEarnings(5) As Integer
    Private intJackPot As Integer
    Private intBalance As Integer
    Private intAnswer(4) As Integer
    Private intPowerball As Integer
    Sub New()
        intEarnings = {4, 7, 100, 50000, 1000000, 40000000}
        intBalance = 0
        intAnswer = {0, 0, 0, 0, 0}
        intPowerball = 0
    End Sub
    Sub CalculateCorrect(intGuess() As Integer, intPowerballGuess As Integer)
        intBalance -= 2
        Dim intCorrect As Integer = 0
        For Each guess In intGuess
            If intAnswer.Contains(guess) Then
                intCorrect += 1
            End If
        Next
        Dim strNumCorrect As String = intCorrect.ToString + "+"
        If (intPowerballGuess = intPowerball) Then
            strNumCorrect += "1"
        Else
            strNumCorrect += "0"
        End If

        If (strNumCorrect = "0+1" Or strNumCorrect = "1+1") Then
            intBalance += intEarnings(0)
        ElseIf (strNumCorrect = "2+1" Or strNumCorrect = "3+0") Then
            intBalance += intEarnings(1)
        ElseIf (strNumCorrect = "3+1" Or strNumCorrect = "4+0") Then
            intBalance += intEarnings(2)
        ElseIf (strNumCorrect = "4+1") Then
            intBalance += intEarnings(3)
        ElseIf (strNumCorrect = "5+0") Then
            intBalance += intEarnings(4)
        ElseIf (strNumCorrect = "5+1") Then
            intBalance += intEarnings(5)
        End If
        'MsgBox(strNumCorrect)
    End Sub

    Function GenerateAnswer() As Integer()
        intAnswer = {0, 0, 0, 0, 0, 0}
        intPowerball = 0
        Dim intOutput(5) As Integer
        Randomize()
        For i = 0 To 4
            Dim bolUnique As Boolean = False
            Do Until bolUnique = True
                Dim intRndNum = CInt(Math.Floor((69) * Rnd())) + 1
                If intAnswer.Contains(intRndNum) Then
                    bolUnique = False
                Else
                    intAnswer(i) = intRndNum
                    intOutput(i) = intRndNum
                    bolUnique = True
                End If

            Loop
        Next
        intOutput(5) = CInt(Math.Floor((26) * Rnd())) + 1
        intPowerball = intOutput(5)
        'intOutput = {1, 2, 3, 4, 5, 6}
        'intAnswer = {1, 2, 3, 4, 5}
        'intPowerball = 6
        Return intOutput
    End Function

    Function GetBalance() As Integer
        Return intBalance
    End Function
End Class
