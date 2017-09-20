Public Class Form1

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        ' Variables for hours, pay rate, and gross pay
        Dim dblHours, dblPayRate, dblGrossPay As Double

        ' Get the hours worked.
        dblHours = CDbl(txtHours.Text)

        ' Get the pay rate.
        dblPayRate = CDbl(txtPayRate.Text)

        ' Calculate the gross pay.
        dblGrossPay = dblHours * dblPayRate

        ' display the gross pay.
        lblGrossPay.Text = dblGrossPay.ToString("c")
    End Sub

    Private Sub txtHours_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHours.Validating
        Try
            ' Get the hours, as a Double.
            Dim dblHours As Double = CDbl(txtHours.Text)

            ' Make sure it's in the range 0 - 40.
            If dblHours >= 0.0 And dblHours <= 40.0 Then
                ' The input is okay, so do NOT cancel the event.
                e.Cancel = False
            Else
                ' The input is out of range, so display an
                ' error message.
                MessageBox.Show("Hours must be in the range 0 through 40.")

                ' Now cancel the event.
                e.Cancel = True
            End If
        Catch ex As Exception
            ' The input is not a valid number, so display 
            ' an error message.
            MessageBox.Show("Hours must be a valid number.")

            ' Cancel the event.
            e.Cancel = True
        End Try
    End Sub

    Private Sub txtPayRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPayRate.Validating
        Try
            ' Get the pay rate, as a Double.
            Dim dblPayRate As Double = CDbl(txtPayRate.Text)

            ' Make sure it's 0 or greater.
            If dblPayRate >= 0.0 Then
                ' The input is okay, so do NOT cancel the event.
                e.Cancel = False
            Else
                ' The input is out of range, so display an
                ' error message.
                MessageBox.Show("Pay rate must be 0 or greater.")

                ' Now cancel the event.
                e.Cancel = True
            End If
        Catch ex As Exception
            ' The input is not a valid number, so display 
            ' an error message.
            MessageBox.Show("Pay rate must be a valid number.")

            ' Cancel the event.
            e.Cancel = True
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
    End Sub
End Class
