Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ex1, ex2, ex3, final, tot, ftot As Double
        'Collect the four input grades'
        ex1 = CDbl(TextBox1.Text)
        ex2 = CDbl(TextBox3.Text)
        ex3 = CDbl(TextBox2.Text)
        final = CDbl(TextBox4.Text)
        MessageBox.Show("First 4 grades Data collected.")
        ftot = (ex1 + ex2 + ex3 + final) / 4
        Label13.Text = ftot.ToString
        'Check for extra credit
        If CheckBox1.Checked = True Then
            If ftot < 94 Then ftot = ftot + 5
            MessageBox.Show("Just added 5 points.")
            If CheckBox1.Checked = False Then
            End If


        End If
        'Show Final Total Average Score
        Label8.Text = ftot.ToString
        'Process the radio buttons
        If RadioButton1.Checked = False Then
            Label16.Text = "Honors"
        End If
        ' Compute and display letter grades '
        If ftot < 60 Then
            Label9.Text = "F"
        ElseIf ftot < 70 Then
            Label9.Text = "D"
        ElseIf ftot < 80 Then
            Label9.Text = "C"
        ElseIf ftot < 90 Then
            Label9.Text = "B"
        ElseIf ftot <= 100 Then
            Label9.Text = "A"
        Else
            Label9.Text = "Invalid Grade"





        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        Label8.Text = ""
        Label9.Text = ""
        Label16.Text = ""
        Label13.Text = ""
        RadioButton1.Checked = True
        CheckBox1.Checked = False

    End Sub
End Class
