Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' Declare a variable to hold the user's salary.
        Dim decSalary As Decimal

		' Get the user's input and convert it to a Decimal.
		decSalary = CDec(txtSalary.Text)

		' Display the user's salary.
		lblResult.Text = "Your salary is " & decSalary.ToString("c")

	End Sub
End Class






		' Alternative version, uses exception handling.
		'Try
		'	decSalary = CDec(txtSalary.Text)
		'	lblResult.Text = "Your salary is " & decSalary.ToString("c")
		'Catch
		'	lblResult.Text = "Please try again, and enter a number."
		'End Try

