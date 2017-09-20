Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        lblDate.Text = DateTimePicker1.Value.ToShortDateString
    End Sub
End Class
