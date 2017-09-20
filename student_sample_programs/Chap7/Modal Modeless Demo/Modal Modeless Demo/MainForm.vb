Public Class MainForm

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		' Clear the list box.
		lstOutput.Items.Clear()
	End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnShowModal_Click(sender As Object, e As EventArgs) Handles btnShowModal.Click

    End Sub
End Class
