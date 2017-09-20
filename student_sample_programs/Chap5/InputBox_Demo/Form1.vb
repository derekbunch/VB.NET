Public Class Form1

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim strUsername As String
		strUsername = InputBox("Enter your username.", "Input Needed")
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		Dim strUserInput As String
		Dim dblDistance As Double
		strUserInput = InputBox("Enter the distance.", "Provide a Value")
		dblDistance = CDbl(strUserInput)

	End Sub

End Class
