
Partial Class _Default
    Inherits System.Web.UI.Page

	Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		lblResult.Text = "You selected: " & ListBox1.SelectedItem.ToString
	End Sub
End Class
