Public Class Form1
    Dim totCost As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmMainForm1 As New Form1
        frmMainForm1.ShowDialog()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Closes the forms
        Me.Close()
    End Sub
    Private Sub btnDorm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDorm.Click
        Dim AllenHall As Integer = 1500
        Dim PikeHall As Integer = 1600
        Dim FathingHall As Integer = 1200
        Dim UniversitySuites As Integer = 1800
        Dim Cost As Integer

        Select Case lstDorms.SelectedIndex
            Case -1
                MessageBox.Show("Select a meal plan", "Error")
            Case 0
                lblDorm.Text = AllenHall.ToString("C")
                Cost = AllenHall
            Case 1
                lblDorm.Text = PikeHall.ToString("C")
                Cost = PikeHall
            Case 2
                lblDorm.Text = FathingHall.ToString("C")
                Cost = FathingHall
            Case 3
                lblDorm.Text = UniversitySuites.ToString("C")
                Cost = UniversitySuites
        End Select


    End Sub
    Public Sub btnMeals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeals.Click
        Dim frmMealPlans As New Meal_Plans
        frmMealPlans.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstDorms.SelectedIndex = -1
        lblDorm.Text = String.Empty
        lblMeals.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
