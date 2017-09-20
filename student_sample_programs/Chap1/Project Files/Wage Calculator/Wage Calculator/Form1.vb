Public Class Form1
    Private Sub btnCalcGrossPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcGrossPay.Click
        ' Declare variables we will use in the calculations.
        Dim dblHoursWorked As Double
        Dim dblPayRate As Double
        Dim dblGrossPay As Double

        ' Get the hours worked from the TextBox control.
        dblHoursWorked = CDbl(txtHoursWorked.Text)

        ' Get the hourly pay rate from the TextBox control.
        dblPayRate = CDbl(txtPayRate.Text)

        ' Calculate the employee's gross pay.
        dblGrossPay = dblHoursWorked * dblPayRate

        ' Assign the gross pay to a Label control,
        ' with currency formatting.
        lblGrossPay.Text = dblGrossPay.ToString("c")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' End the application by closing its window.
        Me.Close()
    End Sub
End Class
