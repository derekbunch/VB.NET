Public Class Form1

    Private Sub btnShowMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMessage.Click
        ' Store the Hello World message in
        ' the label's Text property.
        lblMessage.Text = Hello World
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
