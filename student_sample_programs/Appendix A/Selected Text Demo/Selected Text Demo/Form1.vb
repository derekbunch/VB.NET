Public Class Form1

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        ' Variables for hours, pay rate, and gross pay
        Dim dblHours, dblPayRate, dblGrossPay As Double

        ' Clear any existing errors.
        ErrorProvider1.SetError(txtHours, String.Empty)
        ErrorProvider1.SetError(txtPayRate, String.Empty)

        ' Get values and calculate gross pay.
        Try
            ' Get the hours worked.
            dblHours = CDbl(txtHours.Text)

            Try
                ' Get the pay rate.
                dblPayRate = CDbl(txtPayRate.Text)

                ' Calculate the gross pay.
                dblGrossPay = dblHours * dblPayRate

                ' display the gross pay.
                lblGrossPay.Text = dblGrossPay.ToString("c")
            Catch ex As Exception
                ' Invalid pay rate
                ErrorProvider1.SetError(txtPayRate, "Pay rate must be numeric.")

                ' Select the invalid input.
                txtPayRate.Focus()
                txtPayRate.SelectionStart = 0
                txtPayRate.SelectionLength = txtPayRate.Text.Length
            End Try
        Catch ex As Exception
            ' Invalid hours
            ErrorProvider1.SetError(txtHours, "Hours must be numeric.")

            ' Select the invalid input.
            txtHours.Focus()
            txtHours.SelectionStart = 0
            txtHours.SelectionLength = txtHours.Text.Length
        End Try
    End Sub
End Class
