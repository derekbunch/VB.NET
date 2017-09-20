Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' Compare the input entered with the secret word.
        If txtInput.Text = "PROSPERO" Then
            lblMessage.Text = "Congratulations! That " &
                              "is the secret word!"
        Else
            lblMessage.Text = "Wrong! That is NOT the secret word!"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
