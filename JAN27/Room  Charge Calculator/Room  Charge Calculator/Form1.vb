Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("d")

        'Get today's time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")
    End Sub
End Class
