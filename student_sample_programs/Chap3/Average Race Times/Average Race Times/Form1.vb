Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' This prodecure calculates the average race time of
        ' three runners and displays the average in lblAverageTime.

        ' Variables
        Dim dblRunner1 As Double        ' Runner #1's time
        Dim dblRunner2 As Double        ' Runner #2's time
        Dim dblRunner3 As Double        ' Runner #3's time
        Dim dblAverage As Double        ' Average race time

        ' Get the times entered by the user
        dblRunner1 = CDbl(txtRunner1.Text)
        dblRunner2 = CDbl(txtRunner2.Text)
        dblRunner3 = CDbl(txtRunner3.Text)

        ' Calculate the average time
        dblAverage = dblRunner1 + dblRunner2 + dblRunner3 / 3

        ' Display the average time
        lblAverageTime.Text = dblAverage.ToString("n1")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the TextBoxes.
        txtRunner1.Text = String.Empty
        txtRunner2.Text = String.Empty
        txtRunner3.Text = String.Empty
        lblAverageTime.Text = String.Empty

        ' Reset the focus.
        txtRunner1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the application by closing the window.
        Me.Close()
    End Sub
End Class
