Public Class Form1
    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        ' Display the French word for one.
		lblStatus.Text = "un"
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        ' Display the French word for two.
		lblStatus.Text = "deux"
	End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        ' Display the French word for three.
		lblStatus.Text = "trois"
	End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        ' Display the French word for four.
		lblStatus.Text = "quatre"
	End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        ' Display the French word for five.
		lblStatus.Text = "cinq"
	End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
