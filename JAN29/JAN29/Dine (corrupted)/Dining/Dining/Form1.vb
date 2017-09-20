Public Class Form1
    Dim totalbill, tip, grandtotal As Double

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalbill = 32.73
        TextBox1.Text = totalbill.ToString("c")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tip = CDbl(TextBox2.Text)
        TextBox2.Text = tip.ToString("c")
        grandtotal = totalbill + tip
        TextBox3.Text = grandtotal.ToString("c")
    End Sub
End Class