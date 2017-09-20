Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			Dim strInput As String
			Dim intIndex As Integer = 99
			strInput = lstMonths.Items(intIndex).ToString()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub
End Class
