Public Class Form1

    Private Sub btnClear_Click() Handles btnClear.Click
        ' Clear the TextBoxes and the Label
        txtSalary.Clear()
        txtYearsOnJob.Clear()
        lblMessage.Text = String.Empty

        ' Give the focus to txtSalary
        txtSalary.Focus()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
