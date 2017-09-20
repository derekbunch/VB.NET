Public Class Form1

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        ' This event handler performs addition.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "+" as the operation.
        lblOperation.Text = "+"

        ' Add the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        ' This event handler performs subtraction.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "-" as the operation.
        lblOperation.Text = "-"

        ' Subtract Number 2 from Number 1 and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        ' This event procedure performs multiplication.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "*" as the operation.
        lblOperation.Text = "*"

        ' Multiply the two numbers and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExponent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExponent.Click
        ' This event handler raises a number to a power.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "^" as the operation.
        lblOperation.Text = "^"

        ' Raise Number  to the power of Number 2 
        ' and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        ' This event handler performs floating-point division.
        ' Declare a variable to hold the result.
        Dim dblResult As Double

        ' Indicate "/" as the operation.
        lblOperation.Text = "/"

        ' Divide Number 1 by Number 2 and store the result in dblResult.
        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnIntegerDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntegerDivide.Click
        ' This event handler performs integer division.
        ' Declare a variable to hold the result.
        Dim intResult As Integer

        ' Indicate "\" as the operation.
        lblOperation.Text = "\"

        ' Integer-divide Number 1 by Number 2 and 
        ' store the result in dblResult.
        intResult = CInt(txtNumber1.Text) \ CInt(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(intResult)
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        ' This event handler performs modulus division with integers.
        ' Declare a variable to hold the result.
        Dim intResult As Integer

        ' Indicate "MOD" as the operation.
        lblOperation.Text = "MOD"

        ' Divide Number 1 by Number 2 and store the remainder in dblResult.
        intResult = CInt(txtNumber1.Text) Mod CInt(txtNumber2.Text)

        ' Display the result.
        lblResult.Text = CStr(intResult)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' This event handler clears the numbers.
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblResult.Text = String.Empty

        ' Clear the operation label
        lblOperation.Text = String.Empty

        ' Reset the focus
        txtNumber1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
