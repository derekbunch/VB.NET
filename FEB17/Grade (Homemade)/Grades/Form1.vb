Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ex1, ex2, ex3, final, tot, ftot As Double

        ex1 = CDbl(ex1.Text)
        ex2 = CDbl(ex2.Text)
        ex3 = CDbl(ex3.Text)
        final = CDbl(final.Text)

        tot = (ex1 + ex2 + ex3 + final) / 4

        Label9.Text = tot.ToString

        ftot = tot

        If CheckBox1.Checked = True Then
            If tot < 94 Then
                ftot = ftot + 5
            End If
        End If

        label15.text = ftot.ToString

        If RadioButton1.Checked = False Then
            label14.text = "H O N O R S "
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        textbox1.Clear()
        textbox2.Clear()
    End Sub
End Class
