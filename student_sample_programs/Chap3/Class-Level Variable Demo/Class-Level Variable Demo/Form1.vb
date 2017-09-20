Public Class Form1
    ' Declare a class-level variable.
    Dim intValue As Integer

    Private Sub btnSetValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetValue.Click
        intValue = 99
    End Sub

    Private Sub btnShowValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowValue.Click
        MessageBox.Show(intValue.ToString())
    End Sub
End Class
