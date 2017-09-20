Public Class Form1

    Private Sub btnEnterSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterSales.Click
        Dim intCount As Integer = 1         ' Loop counter
        Dim decSales As Decimal = 0         ' To hold daily sales
        Dim decTotal As Decimal = 0         ' To hold the total sales
        Dim intNumDays As Integer           ' To hold the number of days
        Dim strInput As String              ' To hold string input

        Try
            ' Get the number of days from the user.
            strInput = InputBox("How many days do you have sales figures for?")

            ' Convert the user's input to an integer.
            intNumDays = CInt(strInput)

            ' Get the sales for each day.
            Do While intCount <= intNumDays
                ' Get a daily sales amount from the user.
                strInput = InputBox("Enter the sales for day " &
                                    intCount.ToString())

                Try
                    ' Convert the input to a Decimal.
                    decSales = CDec(strInput)

                    ' Add the daily sales to the total sales.
                    decTotal += decSales

                    ' Add 1 to the loop counter.
                    intCount += 1
                Catch
                    ' Display an error message for invalid input.
                    MessageBox.Show("Enter a numeric value.")
                End Try
            Loop

            ' Display the total sales.
            lblTotal.Text = decTotal.ToString("c")
        Catch
            ' Display an error message for invalid number of days.
            MessageBox.Show("The number of days must be an integer.")
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
