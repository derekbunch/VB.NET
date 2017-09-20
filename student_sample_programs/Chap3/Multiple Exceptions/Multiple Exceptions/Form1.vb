Public Class Form1

	Private Sub btnCalculate_Click() Handles btnCalculate.Click
		Dim decAnnualSalary As Decimal	' Annual salary
		Dim intPayPeriods As Integer	' Number of pay periods per year
		Dim decSalary As Decimal		' Salary per pay period
		lblStatus.Text = String.Empty

		Try
			' Get the annual salary and number of pay periods.
			decAnnualSalary = CDec(txtAnnualSalary.Text)
			intPayPeriods = CInt(txtPayPeriods.Text)

			' Calculate the salary per pay period.
			decSalary = decAnnualSalary / intPayPeriods

			' Display the salary per pay period.
			lblSalary.Text = decSalary.ToString("c")

		Catch ex As Exception
			' Display the default error message.
			lblStatus.Text = ex.Message
		End Try
	End Sub

	'Private Sub btnCalculate_Click() Handles btnCalculate.Click
	'	Dim decAnnualSalary As Decimal	' Annual salary
	'	Dim intPayPeriods As Integer	' Number of pay periods per year
	'	Dim decSalary As Decimal		' Salary per pay period
	'	lblStatus.Text = String.Empty

	'	Try
	'		' Get the annual salary and number of pay periods.
	'		decAnnualSalary = CDec(txtAnnualSalary.Text)
	'		intPayPeriods = CInt(txtPayPeriods.Text)

	'		' Calculate the salary per pay period.
	'		decSalary = decAnnualSalary / intPayPeriods

	'		' Display the salary per pay period.
	'		lblSalary.Text = decSalary.ToString("c")

	'	Catch ex As InvalidCastException
	'		' An invalid value as entered.
	'		lblStatus.Text = "Error: Input must be numeric."

	'	Catch ex As DivideByZeroException
	'		' Zero was entered for pay periods.
	'		lblStatus.Text = "Error: Enter nonzero values."
	'	End Try
	'End Sub
End Class
