Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Variables to hold scores and the average score
		Dim dblScore1, dblScore2, dblScore3 As Double
		Dim dblAverage As Double
		Const NUM_SCORES As Integer = 3

        ' Constant for a high score.
        Const dblHIGH_SCORE As Double = 95.0
        Try
            ' Copy the TextBox scores into the variables.
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            ' Calculate the average score.
			dblAverage = (dblScore1 + dblScore2 +
			 dblScore3) / NUM_SCORES

            ' Display the average, rounded to 2 decimal places.
            lblAverage.Text = dblAverage.ToString("n2")

            ' If the score is high, compliment the student.
            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great Job!"
            End If
        Catch
            ' Display an error message.
			lblMessage.Text = "Scores must be numeric.""Scores must be numeric."
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the TextBoxes and Labels.
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty

        ' Give the focus to txtScore1
        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
