Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try
            WebBrowser1.Url = New Uri(txtURL.Text)
        Catch ex As Exception
            ' Error message for an invalid Web address.
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
