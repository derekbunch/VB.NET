Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the application.
        Me.Close()
    End Sub

    Private Sub btnFeet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeet.Click
        ' Display the conversion to feet.
        lblMessage.Text = "1 Kilometer = 3,281 feet"
    End Sub

    Private Sub btnInches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInches.Click
        ' Display the conversion to inches.
        lblMessage.Text = "1 Kilometer = 39,370 inches"
    End Sub

    Private Sub btnMiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiles.Click
        ' Display the conversion to miles.
        lblMessage.Text = "1 Kilometer = 0.6214 miles"
    End Sub

    Private Sub btnYards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYards.Click
        ' Display the conversion to yards.
        lblMessage.Text = "1 Kilometer = 1,093.6 yards"
    End Sub
End Class
