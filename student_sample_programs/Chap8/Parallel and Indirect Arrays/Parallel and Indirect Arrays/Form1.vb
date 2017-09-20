Public Class Form1

	Private strPhoneNumbers(2) As String

	'Const intMAX As Integer = 4

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lstPeople.Items.Add("Jean James")
		lstPeople.Items.Add("Kevin Smith")
		lstPeople.Items.Add("Joe Harrison")

		strPhoneNumbers(0) = "555-2987"
		strPhoneNumbers(1) = "555-5656"
		strPhoneNumbers(2) = "555-8897"
	End Sub

	Private Sub btnParallel_Click(sender As Object, e As EventArgs) Handles btnParallel.Click
		With lstPeople
            If .SelectedIndex > -1 And
            .SelectedIndex < strPhoneNumbers.Length Then
                MessageBox.Show(strPhoneNumbers(.SelectedIndex))
            Else
                MessageBox.Show("That is not a valid selection.")
            End If
		End With
	End Sub

	Private Sub btnIndirect_Click(sender As Object, e As EventArgs) Handles btnIndirect.Click

		Dim strWorkshops() As String = {"Negotiating Skills", "Lowering Stress", "Teamwork", "Building Resumes"}
		Dim decCosts() As String = {500D, 450D, 720D, 250D}
		Dim strCities() As String = {"Chicago", "Miami", "Atlanta", "Denver", "Topeka", "Indianapolis"}
		Dim intLocations() As Integer = {3, 0, 1, 4}

		For i As Integer = 0 To strWorkshops.Length - 1
			lstShow.Items.Add(strWorkshops(i) & " will cost " & decCosts(i) &
			" and will be held in " & strCities(intLocations(i)))
		Next i

	End Sub
End Class
