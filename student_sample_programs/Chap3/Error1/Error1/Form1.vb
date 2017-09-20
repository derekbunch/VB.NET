Public Class Form1

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        Dim sum As Single

        sum = CSng(txtNum1.Text & txtNum2.Text & txtNum3.Text)
        lblSum.Text = sum.ToString
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
