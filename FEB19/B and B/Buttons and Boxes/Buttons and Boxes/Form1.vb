Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblStatus.Text = "LOAD SUB is being executed. "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Process radio button selection
        If RadioButton1.Checked = True Then
            lblStatus.Text = " You selected Coffee"
        ElseIf RadioButton2.Checked = True Then
            lblStatus.Text = " You selected Tea"
        ElseIf RadioButton3.Checked = True Then
            lblStatus.Text = " You selected Soft Drink"
        End If

        'Process the selection of extras
        If CheckBox1.Checked = True Then
            lblStatus.Text &= ", and Whipped Cream."
        End If

        If CheckBox2.Checked = True Then
            lblStatus.Text &= ", and Mocha."
        End If

        If CheckBox3.Checked = True Then
            lblStatus.Text &= ", and Amaretto."
        End If
    End Sub
End Class
