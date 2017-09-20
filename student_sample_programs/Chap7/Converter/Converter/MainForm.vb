Public Class MainForm

    Private Sub btnConvertMeters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertMeters.Click
        ' Create an instance of the MetersToEnglish form.
        Dim frmMetersToEnglish As New MetersToEnglishForm

        ' Display the form in modal style.
        frmMetersToEnglish.ShowDialog()
    End Sub

    Private Sub btnConvertInches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertInches.Click
        ' Create an instance of the InchesToMetric form.
        Dim frmInchesToMetric As New InchesToMetricForm

        ' Display the form in modal style.
        frmInchesToMetric.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
