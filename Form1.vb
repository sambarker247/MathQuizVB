Public Class MathsProblemForm
    'Operation type, last used operation type, and a disposable
    'decimal for a Decimal.TryParse
    Dim opType As String
    Dim lastOpType As String
    Dim decimalParseResult As Decimal
    'Form startup
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Seed the RNG
        Randomize()
        MakeProblem("Add")
    End Sub

    'Make problem
    Private Sub MakeProblem(opType)
        Dim x As Integer
        Dim y As Integer
        Dim answer As Integer
        'For division
        Dim quotient As Decimal
        'Get random operands 1-10
        x = Rnd() * 10
        y = Rnd() * 10

        'Special case for division: can't have divide by zero,
        'because it throws an OverflowError
        While y = 0 And opType = "Divide"
            y = Rnd() * 10
        End While

        'Put operands in labels
        OperandLabel1.Text = x
        OperandLabel2.Text = y

        'Generate problem for selected operation type
        Select Case opType
            'In each case:
                'Calculate answer
                'Replace Answerlabel.Text with answer
                'Remember the opType in the form of lastOpType
            Case Is = "Add"
                answer = x + y
                AnswerLabel.Text = answer
                lastOpType = "Add"
            Case Is = "Subtract"
                answer = x - y
                AnswerLabel.Text = answer
                lastOpType = "Subtract"
            Case Is = "Multiply"
                answer = x * y
                AnswerLabel.Text = answer
                lastOpType = "Multiply"
            Case Is = "Divide"
                'Quotient rounded to 2 decimal places for ease of use 
                quotient = Math.Round((x / y), 2, MidpointRounding.AwayFromZero)
                AnswerLabel.Text = quotient
                lastOpType = "Divide"
        End Select
    End Sub

    'Check answer
    Private Sub CheckAnswer()
        'Check if answer is a number
        If (IsNumeric(AnswerTextBox.Text) = False) Then
            'Display error message
            CurrentMsgLabel.Text = "Enter an Integer!"
        ElseIf (Decimal.TryParse(AnswerTextBox.Text, decimalParseResult)) Then
            'Check if it's decimal ^
            If Decimal.Parse(AnswerTextBox.Text) = Decimal.Parse(AnswerLabel.Text) Then
                CurrentMsgLabel.Text = "Correct!"
            Else
                CurrentMsgLabel.Text = "Incorrect, answer was " & AnswerLabel.Text
            End If
        Else
            'Check if it's correct
            'If integer value of answer text box == answer
            If Integer.Parse(AnswerTextBox.Text) = Integer.Parse(AnswerLabel.Text) Then
                CurrentMsgLabel.Text = "Correct"
            Else
                CurrentMsgLabel.Text = "Incorrect, answer was " & AnswerLabel.Text
            End If
        End If
        MakeProblem(lastOpType)
        AnswerTextBox.Text = ""
    End Sub

    'Generate new problem
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NewProblemButton.Click
        MakeProblem(lastOpType)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AnswerButton.Click
        CheckAnswer()
    End Sub

    'Dropdown to select operation type from add, subtract or divide
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OpDropdown.SelectedIndexChanged
        Select Case OpDropdown.Text
            'Make problem based on dropdown selection, replace sign and
            'operation name at the top with the appropriate ones
            Case Is = "Add"
                MakeProblem("Add")
                OpLabel.Text = "+"
                OpNameLabel.Text = "ADDITION"
            Case Is = "Subtract"
                MakeProblem("Subtract")
                OpLabel.Text = "-"
                OpNameLabel.Text = "SUBTRACTION"
            Case Is = "Multiply"
                MakeProblem("Multiply")
                OpLabel.Text = "*"
                OpNameLabel.Text = "MULTIPLICATION"
            Case Is = "Divide"
                MakeProblem("Divide")
                OpLabel.Text = "/"
                OpNameLabel.Text = "DIVISION TO 2 D.P. (HARD)"
        End Select
    End Sub

    'Toggle answer with Home key
    Private Sub Form1_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.ToString = "Home" And AnswerLabel.Visible = True Then
            AnswerLabel.Visible = False
        ElseIf e.KeyCode.ToString = "Home" And AnswerLabel.Visible = False Then
            AnswerLabel.Visible = True
        End If
    End Sub
End Class
