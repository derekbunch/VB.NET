Public Class Form1

    Private Sub btnRunDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunDemo.Click
        Dim intCount As Integer     ' Loop counter
        Dim intSquare As Integer    ' To hold squares
        Dim strTemp As String       ' To hold output

        For intCount = 1 To 10
            ' Calculate the square of intCount.
            intSquare = CInt(intCount ^ 2)

            ' Create a string to display.
            strTemp = "The square of " & intCount.ToString() &
                " is " & intSquare.ToString()

            ' Add the string to the list box.
            lstOutput.Items.Add(strTemp)
        Next
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the list box.
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
