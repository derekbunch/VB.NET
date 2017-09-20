Public Class Form1
    Dim totalbill, tip, grandtotal As Double
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalbill = 32.73
        TextBox1.Text = totalbill.ToString("C")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            tip = CDbl(TextBox2.Text)
            If tip < 0 Then
                tip = tip * -1
            End If
            TextBox2.Text = tip.ToString("C")
            grandtotal = totalbill + tip
            TextBox3.Text = grandtotal.ToString("C")
        Catch
            MessageBox.Show("The tip must be a NUMERIC value")
            TextBox2.Clear()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
