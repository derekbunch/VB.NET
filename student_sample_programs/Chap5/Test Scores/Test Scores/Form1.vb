Public Class Form1

    Private Sub btnGetScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetScores.Click
        ' This procedure gets the test scores, then calculates and
        ' displays the average.
        Dim intNumScores As Integer     ' The number of test scores
        Dim dblTestScore As Double      ' To hold a test score
        Dim dblTotal As Double = 0      ' Accumulator, initialized to 0
        Dim dblAverage As Double        ' The average of the test scores
        Dim strInput As String          ' To hold user input
        Dim intCount As Integer = 1     ' Counter variable, initialized to 1

        ' Prompt the user for the number of test scores. 
        strInput = InputBox("How many test scores do you want to average?")

        ' Convert the input to an integer.
        If Integer.TryParse(strInput, intNumScores) Then

            ' Get the test scores.
            Do Until intCount > intNumScores
                ' Prompt the user for a score.
                strInput = InputBox("Enter test score " &
                                    intCount.ToString())

                ' Convert the input to a Double.
                If Double.TryParse(strInput, dblTestScore) Then

                    ' Add the score to the accumulator.
                    dblTotal += dblTestScore

                    ' Add 1 to the counter.
                    intCount += 1
                Else
                    ' Invalid test score.
                    MessageBox.Show("Enter a numeric test score.")
                End If
            Loop

            ' Calculate and display the average.
            If intNumScores > 0 Then
                dblAverage = dblTotal / intNumScores
                lblAverage.Text = dblAverage.ToString()
            End If

        Else
            ' Invalid number of test scores.
            MessageBox.Show("Enter an integer value for number of test scores.")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
