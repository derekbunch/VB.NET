Public Class InchesToMetricForm

    Private Sub btnInchesToMM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInchesToMM.Click
        Dim dblInches As Double         ' To hold the inches
        Dim dblMillimeters As Double    ' To hold the millimeters

        Try
            ' Get the inches.
            dblInches = CDbl(txtInches.Text)

            ' Convert inches to millimeters.
            dblMillimeters = InchesToMM(dblInches)

            ' Display the result.
            MessageBox.Show(dblInches.ToString() & " inches equals " &
                            dblMillimeters.ToString() & " millimeters.")
        Catch
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Enter a numeric value.")
        End Try
    End Sub

    Private Sub btnInchesToCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInchesToCM.Click
        Dim dblInches As Double         ' To hold the inches
        Dim dblCentimeters As Double    ' To hold the centimeters

        Try
            ' Get the inches.
            dblInches = CDbl(txtInches.Text)

            ' Convert inches to centimeters.
            dblCentimeters = InchesToCM(dblInches)

            ' Display the result.
            MessageBox.Show(dblInches.ToString() & " inches equals " &
                            dblCentimeters.ToString() & " centimeters.")
        Catch
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Enter a numeric value.")
        End Try
    End Sub

    Private Sub btnInchesToMeters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInchesToMeters.Click
        Dim dblInches As Double     ' To hold the inches
        Dim dblMeters As Double     ' To hold the millimeters

        Try
            ' Get the inches.
            dblInches = CDbl(txtInches.Text)

            ' Convert inches to millimeters.
            dblMeters = InchesToMeters(dblInches)

            ' Display the result.
            MessageBox.Show(dblInches.ToString() & " inches equals " &
                            dblMeters.ToString() & " meters.")
        Catch
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Enter a numeric value.")
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class