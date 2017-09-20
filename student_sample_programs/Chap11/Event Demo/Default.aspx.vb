
Partial Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load() Handles Me.Load
		lstEvents.Items.Add("Page_Load")
	End Sub
	Protected Sub txtName_TextChanged() Handles txtName.TextChanged
		lstEvents.Items.Add("TextChanged")
	End Sub
	Protected Sub btnOk_Click() Handles btnOk.Click
		lstEvents.Items.Add("Button Click")
	End Sub

End Class
