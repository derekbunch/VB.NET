Public Class Form1

	Private Sub btnCalculate_Click() Handles btnCalculate.Click
		Dim decAnnualSalary As Decimal	' Annual salary
		Dim intPayPeriods As Integer	' Number of pay periods per year
		Dim decSalary As Decimal		' Salary per pay period
		lblStatus.Text = String.Empty

		Try
			' Get the annual salary and number of pay periods.
			decAnnualSalary = CDec(txtAnnualSalary.Text)

			Try
				' Get the number of pay periods.
				intPayPeriods = CInt(txtPayPeriods.Text)

				Try
					' Calculate the salary per pay period.
					decSalary = decAnnualSalary / intPayPeriods

					' Display the salary per pay period.
					lblSalary.Text = decSalary.ToString("c")
				Catch
					' Error message for division-by-zero.
					lblStatus.Text = "Pay periods cannot be zero."
				End Try

			Catch
				' Error message for invalid pay periods.
				lblStatus.Text = "Pay periods must be an integer."
			End Try

		Catch
			' Error message for invalid salary.
			lblStatus.Text = "Enter a numeric value for salary."
		End Try
	End Sub
End Class
