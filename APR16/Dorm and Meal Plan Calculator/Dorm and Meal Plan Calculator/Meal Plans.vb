Public Class Meal_Plans
    Dim totCost As Integer
    Dim hallcost As Integer
    Dim Results As Integer
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Meals7 As Integer = 560
        Dim Meals14 As Integer = 1095
        Dim Unlimited As Integer = 1500
        Select Case lstMeals.SelectedIndex
            Case -1
                MessageBox.Show("Select a meal plan", "Error")
            Case 0
                Results = Meals7
            Case 1
                Results = Meals14
            Case 2
                Results = Unlimited
        End Select
        Form1.lblMeals.Text = Results.ToString("C")
        Call Calculate(hallcost)
    End Sub
    Public Sub Calculate(ByVal hallcost As Integer)
        Dim AllenHall As Integer = 1500
        Dim PikeHall As Integer = 1600
        Dim FathingHall As Integer = 1200
        Dim UniversitySuites As Integer = 1800
        Dim Cost As Integer
        Select Case Form1.lstDorms.SelectedIndex
            Case 0
                Form1.lblDorm.Text = AllenHall.ToString("C")
                Cost = AllenHall
            Case 1
                Form1.lblDorm.Text = PikeHall.ToString("C")
                Cost = PikeHall
            Case 2
                Form1.lblDorm.Text = FathingHall.ToString("C")
                Cost = FathingHall
            Case 3
                Form1.lblDorm.Text = UniversitySuites.ToString("C")
                Cost = UniversitySuites
        End Select
        totCost = Cost + Results
        Form1.lblTotal.Text = totCost.ToString("C")
    End Sub
End Class