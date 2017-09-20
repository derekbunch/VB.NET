Public Class Form1

	Private Sub btnCalculate_Click() Handles btnCalculate.Click
		Dim decBaseFee As Decimal		' Base Monthly Fee
		Dim decTotalFee As Decimal		' Total Membership Fee
		Dim intMonths As Integer		' Number of months
		Dim blnInputOk As Boolean = True

		' Constants for base fees.
		Const decADULT_FEE As Decimal = 40D
		Const decCHILD_FEE As Decimal = 20D
		Const decSTUDENT_FEE As Decimal = 25D
		Const decSENIOR_FEE As Decimal = 30D

		' Constants for additional fees.
		Const decYOGA_FEE As Decimal = 10D
		Const decKARATE_FEE As Decimal = 30D
		Const decTRAINER_FEE As Decimal = 50D

		' Validate and convert the number of months.
		lblStatus.Text = String.Empty
		If Integer.TryParse(txtMonths.Text, intMonths) = False Then
			lblStatus.Text = "Months must be an integer."
			blnInputOk = False
		End If

		' Validate the number of months.
		If intMonths < 1 Or intMonths > 24 Then
			lblStatus.Text = "Months must be in the range 1 - 24."
			blnInputOk = False
		End If

		If blnInputOk = True Then
			' Determine the base monthly fee.
			If radAdult.Checked = True Then
				decBaseFee = decADULT_FEE
			ElseIf radChild.Checked = True Then
				decBaseFee = decCHILD_FEE
			ElseIf radStudent.Checked = True Then
				decBaseFee = decSTUDENT_FEE
            ElseIf radSenior.Checked = True Then
                If intMonths <= 11 Then
                    decBaseFee = decSENIOR_FEE
                Else : decBaseFee = (11 * decSENIOR_FEE + (intMonths - 11) * 29) / intMonths
                End If
        End If

			' Check for additional services.
            If chkYoga.Checked = True Then
                If radSenior.Checked = True Then
                    decBaseFee = decBaseFee + 8D
                Else
                    decBaseFee += decYOGA_FEE
                End If
            End If

            If chkKarate.Checked = True Then
                If radChild.Checked = True Then
                    lblStatus.Text = " No kids allowed in karate"
                    chkKarate.Checked = False
                Else
                    decBaseFee += decKARATE_FEE
                End If
            End If

            If chkTrainer.Checked = True Then
                decBaseFee += decTRAINER_FEE
            End If

            ' Calculate the total fee.
            decTotalFee = decBaseFee * intMonths

            ' Display the fees.
            lblMonthlyFee.Text = decBaseFee.ToString("c")
            lblTotalFee.Text = decTotalFee.ToString("c")
        End If
	End Sub

	Private Sub btnClear_Click() Handles btnClear.Click
		' Reset all labels, radio buttons, text boxes, and check boxes.
		radAdult.Checked = True
		chkYoga.Checked = False
		chkKarate.Checked = False
		chkTrainer.Checked = False
		txtMonths.Clear()
		lblMonthlyFee.Text = String.Empty
		lblTotalFee.Text = String.Empty
		lblStatus.Text = String.Empty

		' Give txtMonths the focus.
		txtMonths.Focus()
	End Sub

	Private Sub btnExit_Click() Handles btnExit.Click
		' Close the form.
		Me.Close()
	End Sub
End Class
