Public Class Form1

    ' Class-level variable used to count seconds.
    Private intSeconds As Integer

    Private Sub btnToggleTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggleTimer.Click
        ' Toggle the timer.
        If tmrSeconds.Enabled = True Then
            tmrSeconds.Enabled = False
            btnToggleTimer.Text = "&Start Timer"
        Else
            tmrSeconds.Enabled = True
            btnToggleTimer.Text = "&Stop Timer"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub tmrSeconds_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSeconds.Tick
        ' Update the seconds display by one second.
        intSeconds += 1
        lblCounter.Text = intSeconds.ToString()
    End Sub
End Class
