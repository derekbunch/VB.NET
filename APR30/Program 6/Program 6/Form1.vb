Public Class Form1
    Dim decNumber As Decimal                'Array to hold the numbers entered by the user
    Const intMAX_SUBSCRIPT As Integer = 9   'Constant amount of numbers to be entered by the user
    Dim intMax As Integer                   'Variable to hold the Maximum value
    Dim intMin As Integer                   'Variable to hold the Minimum value
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create an array to hold number amounts entered by user
        Dim decNumber(intMAX_SUBSCRIPT) As Decimal

        GetStuff(decNumber)
    End Sub

    ' The GetStuff procedure accepts a Decimal array as an argument.
    ' It fills the array with numbers entered by the user.

    Public Function GetStuff(ByRef decNumber() As Decimal)
        Dim intCount As Integer = 0     ' Loop counter, set to 0

        'Maximum Variables
        Dim intNumbers() As Decimal = decNumber
        Dim intCounted As Integer = 0

        'Minimum Variables
        Dim intNumbered() As Decimal = decNumber
        Dim intcounting As Integer = 0

        ' Fill the decNumber array with values entered by the user.
        Do While intCount < decNumber.Length
            Try
                ' Get the numbers.
                decNumber(intCount) =
                 CDec(InputBox("Enter number " &
                        (intCount + 1).ToString()))
                ListBox1.Items.Add(decNumber(intCount))
                ' Increment intCount.
                intCount += 1
            Catch
                ' Display an error message for invalid input.
                MessageBox.Show("Enter a valid numeric value.")
            End Try
        Loop

        'Max
        'Get the first value in the array.
        intMax = intNumbers(0)

        'Search for the lowest value.
        For intCounted = 1 To (intNumbers.Length - 1)
            If intNumbers(intCounted) > intMax Then
                intMax = intNumbers(intCounted)
            End If
        Next

        'Min
        ' Get the first value in the array.
        intMin = intNumbered(0)

        ' Search for the lowest value.
        For intCount = 1 To (intNumbered.Length - 1)
            If intNumbered(intCount) < intMin Then
                intMin = intNumbered(intCount)
            End If
        Next

        Return decNumber
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        lblInfo.Text = ("The largest value is " & intMax & " and the smallest value is " & intMin & ".")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        lblInfo.Text = String.Empty
        ListBox1.Items.Add("Input Values")
    End Sub
End Class
