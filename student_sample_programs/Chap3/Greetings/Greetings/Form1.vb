Public Class Form1

    Private Sub btnShowGreeting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGreeting.Click
        ' Display a customized greeting to the user
        ' in the lblGreeting control.
        lblGreeting.Text = "Hello " & txtUserName.Text
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
