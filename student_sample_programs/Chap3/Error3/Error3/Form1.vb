Public Class Form1

    ' This application contains a very tricky error!

    Private Sub btnCalculate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare some variables
        Dim number1 As Single
        Dim number2 As Single
        Dim sum As Single

        ' Get the two numbers
        number1 = CSng(txtNumber1.Text)
        number2 = CSng(txtNumber2.Text)

        '  Calculate their sum... is the next line working?
        sum = numberl + number2

        ' Display the result
        lblSum.Text = sum.ToString
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
