Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblstatus.text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim INTCUPS As Integer
        Dim dectotal As Decimal

        lblStatus.Text = ""

        If Integer.TryParse(TextBox1.Text, INTCUPS) = False Then
            lblStatus.Text = "NUMBER OF CUPS MUST BE AN INTEGER NUMERIC."
            Return
        End If

        INTCUPS = CInt(TextBox1.Text)

        If INTCUPS < 1 Or INTCUPS > 6 Then
            lblStatus.Text = "NUMBER OF CUPS MUST BE BETWEEN 1 AND 6 ONLY."
            Return
        End If

        If RadioButton1.Checked = True Then
            dectotal = INTCUPS * 4.5
        ElseIf RadioButton2.Checked = True Then
            dectotal = INTCUPS * 6.75
        ElseIf RadioButton3.Checked = True Then
            dectotal = INTCUPS * 7
        End If

        Label3.Text = dectotal.ToString("C")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox1.Text = ""
        Label3.Text = ""
        lblStatus.Text = ""
    End Sub
End Class
