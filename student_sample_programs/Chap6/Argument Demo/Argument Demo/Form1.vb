Public Class Form1

	Private Sub btnDemo1_Click(sender As Object, e As EventArgs) Handles btnDemo1.Click

		' This event handler calls the DisplayValue procedure,
		' passing 5 as an argument.
		lstVals.Items.Clear()
		DisplayValue(5)
	End Sub

	Private Sub btnDemo2_Click(sender As System.Object, e As System.EventArgs) Handles btnDemo2.Click

		lstVals.Items.Clear()
		' Call the DisplayValue procedure several times,
		' passing different arguments each time.
		DisplayValue(5)
		DisplayValue(10)
		DisplayValue(2)
		DisplayValue(16)
		' The value of an expression is passed to the
		' DisplayValue procedure.
		DisplayValue(3 + 5)
	End Sub

	Private Sub btnDemo3_Click(sender As System.Object, e As System.EventArgs) Handles btnDemo3.Click

		' Use a loop to call the DisplayValue procedure
		' passing a variable as the argument.
		lstVals.Items.Clear()
		Dim intCount As Integer
		For intCount = 1 To 10
			DisplayValue(intCount)
		Next
	End Sub

	Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

		' Close the form.
		Me.Close()
	End Sub

	Sub DisplayValue(intNumber As Integer)
		' This procedure adds a value to the list box.
		lstVals.Items.Add(intNumber.ToString())
	End Sub
End Class
