Public Class Form1

    Private Sub btnNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumber.Click
        Dim dblValue As Double = CDbl(txtValue.Text)
        lblFormatted.Text = dblValue.ToString("n")
    End Sub

    Private Sub btnFixedPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFixedPoint.Click
        Dim dblValue As Double = CDbl(txtValue.Text)
        lblFormatted.Text = dblValue.ToString("f")
    End Sub

    Private Sub btnExponential_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExponential.Click
        Dim dblValue As Double = CDbl(txtValue.Text)
        lblFormatted.Text = dblValue.ToString("e")
    End Sub

    Private Sub btnCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrency.Click
        Dim dblValue As Double = CDbl(txtValue.Text)
        lblFormatted.Text = dblValue.ToString("c")
    End Sub

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPercent.Click
        Dim dblValue As Double = CDbl(txtValue.Text)
        lblFormatted.Text = dblValue.ToString("p")
    End Sub

    Private Sub btnShortDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShortDate.Click
        Dim dtmValue As Date = CDate(txtValue.Text)
        lblFormatted.Text = dtmValue.ToString("d")
    End Sub

    Private Sub btnLongDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLongDate.Click
        Dim dtmValue As Date = CDate(txtValue.Text)
        lblFormatted.Text = dtmValue.ToString("D")
    End Sub

    Private Sub btnShortTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShortTime.Click
        Dim dtmValue As Date = CDate(txtValue.Text)
        lblFormatted.Text = dtmValue.ToString("t")
    End Sub

    Private Sub btnLongTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLongTime.Click
        Dim dtmValue As Date = CDate(txtValue.Text)
        lblFormatted.Text = dtmValue.ToString("T")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dtmValue As Date = CDate(txtValue.Text)
        lblFormatted.Text = dtmValue.ToString("F")
    End Sub
End Class
