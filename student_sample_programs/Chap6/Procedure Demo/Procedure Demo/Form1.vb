Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        ' Display some text in the list box.
        lstOutput.Items.Add("Hello from the btnGo_Click procedure.")
        lstOutput.Items.Add("Now I am calling the DisplayMessage procedure.")

        ' Call the DisplayMessage procedure.
        DisplayMessage()

        ' Display some more text in the list box.
        lstOutput.Items.Add("Now I am back in the btnGo_Click procedure.")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Sub DisplayMessage()
        ' This procedure displays a message in the list box.
        lstOutput.Items.Add("")
        lstOutput.Items.Add("Hello from the DisplayMessage procedure.")
        lstOutput.Items.Add("")
    End Sub
End Class
