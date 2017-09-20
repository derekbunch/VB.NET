Public Class Form1
    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        ' Declare variables
        Dim intHours As Integer     ' Hours worked
        Dim decPayRate As Decimal   ' Hourly Pay Rate
        Dim decGrossPay As Decimal  ' Gross Pay
        lblStatus.Text = String.Empty

        ' Get the hours worked.
        If Integer.TryParse(txtHours.Text, intHours) Then
            ' Get the hourly pay rate.
            If Decimal.TryParse(txtPayRate.Text, decPayRate) Then
                ' Calculate the gross pay.
                decGrossPay = intHours * decPayRate

                ' Display the gross pay.
                lblGrossPay.Text = decGrossPay.ToString("c")
            Else
                ' Display pay rate error message.
                lblStatus.Text = "Enter a valid value for hourly pay rate."
            End If
        Else
            ' Display hours worked error message.
            lblStatus.Text = "Enter a valid integer for hours worked."
        End If
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click

        ' Close the form.
        Me.Close()
    End Sub
End Class
