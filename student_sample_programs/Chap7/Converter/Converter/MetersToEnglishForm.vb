Public Class MetersToEnglishForm

    Private Sub btnMetersToInches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMetersToInches.Click
        Dim dblMeters As Double     ' To hold the meters
        Dim dblInches As Double     ' To hold the inches

        Try
            ' Get the meters.
            dblMeters = CDbl(txtMeters.Text)

            ' Convert meters to inches.
            dblInches = MetersToInches(dblMeters)

            ' Display the result.
            MessageBox.Show(dblMeters.ToString() & " meters equals " &
                            dblInches.ToString() & " inches.")
        Catch
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Enter a numeric value.")
        End Try
    End Sub

    Private Sub btnMetersToFeet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMetersToFeet.Click
        Dim dblMeters As Double   ' To hold the meters
        Dim dblFeet As Double     ' To hold the feet

        Try
            ' Get the meters.
            dblMeters = CDbl(txtMeters.Text)

            ' Convert meters to feet.
            dblFeet = MetersToFeet(dblMeters)

            ' Display the result.
            MessageBox.Show(dblMeters.ToString() & " meters equals " &
                            dblFeet.ToString() & " feet.")
        Catch
            ' Display an error message for invalid input.
            MessageBox.Show("Error: Enter a numeric value.")
        End Try
    End Sub

    Private Sub btnMetersToYards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMetersToYards.Click
        Dim dblMeters As Double     ' To hold the meters
        Dim dblYards As Double      ' To hold the yards

        Try
            ' Get the meters.
            dblMeters = CDbl(txtMeters.Text)

            ' Convert meters to yards.
            dblYards = MetersToYards(dblMeters)

            ' Display the result.
            MessageBox.Show(dblMeters.ToString() & " meters equals " &
                            dblYards.ToString() & " yards.")
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