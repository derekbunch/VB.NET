Public Class Form1

	Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
		' Create an array to hold sales amounts.
		Const intMAX_SUBSCRIPT As Integer = 4
		Dim decSales(intMAX_SUBSCRIPT) As Decimal

		' Other local variables
		Dim decTotalSales As Decimal	  ' To hold the total sales
		Dim decAverageSales As Decimal  ' To hold the average sales
		Dim decHighestSales As Decimal  ' To hold the highest sales
		Dim decLowestSales As Decimal	  ' To hold the lowest sales

		' Get sales amounts from the user.
		GetSalesData(decSales)

		' Get the total sales, average sales, highest sales
		' amount and lowest sales amount.
		decTotalSales = TotalArray(decSales)
		decAverageSales = AverageArray(decSales)
		decHighestSales = Highest(decSales)
		decLowestSales = Lowest(decSales)

		' Display the results.
		lblTotal.Text = decTotalSales.ToString("c")
		lblAverage.Text = decAverageSales.ToString("c")
		lblHighest.Text = decHighestSales.ToString("c")
		lblLowest.Text = decLowestSales.ToString("c")
	End Sub

    ' The GetSalesData procedure accepts a Decimal array as an argument.
    ' It fills the array with sales amounts entered by the user.

    Sub GetSalesData(ByRef decSales() As Decimal)
        Dim intCount As Integer = 0     ' Loop counter, set to 0

        ' Fill the decSales array with values entered by the user.
        Do While intCount < decSales.Length
            Try
                ' Get the sales for a day.
                : decSales(intCount) =
                 CDec(InputBox("Enter the sales for day " &
                              (intCount + 1).ToString()))
                ' Increment intCount.
                intCount += 1
            Catch
                ' Display an error message for invalid input.
                MessageBox.Show("Enter a valid numeric value.")
            End Try
        Loop

    End Sub

    ' The TotalArray function accepts a Decimal array as an
    ' argument and returns the total of its values.

	Function TotalArray(decValues() As Decimal) As Decimal
		Dim decTotal As Decimal = 0	 ' Accumulator
		Dim intCount As Integer			 ' Loop counter

		' Calculate the total of the array's elements.
		For intCount = 0 To (decValues.Length - 1)
			decTotal += decValues(intCount)
		Next

		' Return the total.
		Return decTotal
	End Function

    ' The AverageArray function accepts a Decimal array as an
    ' argument and returns the total of its values.

	Function AverageArray(decValues() As Decimal) As Decimal
		Return TotalArray(decValues) / decValues.Length
	End Function

    ' The Highest function accepts a Decimal array as an
    ' argument and returns the highest value it contains.

	Function Highest(decValues() As Decimal) As Decimal
		Dim intCount As Integer		 ' Loop counter
		Dim decHighest As Decimal	 ' To hold the highest value

		' Get the first value in the array.
		decHighest = decValues(0)

		' Search for the highest value.
		For intCount = 1 To (decValues.Length - 1)
			If decValues(intCount) > decHighest Then
				decHighest = decValues(intCount)
			End If
		Next

		' Return the highest value.
		Return decHighest
	End Function

    ' The Lowest function accepts a Decimal array as an
    ' argument and returns the lowest value it contains.

	Function Lowest(decValues() As Decimal) As Decimal
		Dim intCount As Integer		 ' Loop counter
		Dim decLowest As Decimal	 ' To hold the lowest value

		' Get the first value in the array.
		decLowest = decValues(0)

		' Search for the lowest value.
		For intCount = 1 To (decValues.Length - 1)
			If decValues(intCount) < decLowest Then
				decLowest = decValues(intCount)
			End If
		Next

		' Return the lowest value.
		Return decLowest
	End Function

	Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
		' Close the form.
		Me.Close()
	End Sub
End Class
