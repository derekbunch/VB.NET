Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decA As Decimal     'Class A total
        Dim decB As Decimal     'Class B total
        Dim decC As Decimal     'Class C total
        Dim decTotal As Decimal 'Total revenue

        StatusStrip1.Text = String.Empty
        Try
            'Calculate Class A total
            decA = CDec(txtA.Text) * 15
            lblA.Text = decA.ToString("c")

            'Calculate Class B total
            decB = CDec(txtB.Text) * 12
            lblB.Text = decB.ToString("c")

            'Calculate Class C total
            decC = CDec(txtC.Text) * 9
            lblC.Text = decC.ToString("c")

            'Calculate total revenue
            decTotal = decA + decB + decC
            lblTotal.Text = decTotal.ToString("c")
        Catch ex As Exception
            'Error message
            StatusStrip1.Text = " All input must be valid numeric values."
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear the Class A fields
        txtA.Clear()
        lblA.Text = String.Empty

        'Clear the Class B fields
        txtB.Clear()
        lblB.Text = String.Empty

        'Clear the Class C fields
        txtC.Clear()
        lblC.Text = String.Empty

        'Clear the total revenue field
        lblTotal.Text = String.Empty

        'Reset the focus to the first field.
        txtA.Focus()
    End Sub
End Class
