Public Class Form1
    Dim grandcost As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'define variables
        Dim ccost As Double
        Dim workshopcost As Double
        Dim tcost As Double
        Dim locationcost As Double
        Dim days As Double
        Dim totalcost As Double

        Const fivedays As Integer = 5
        Const threedays As Integer = 3
        Const oneday As Integer = 1

        days = fivedays Or threedays

        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please choose a workshop.")
            Return
        End If

        ccost = ListBox1.SelectedIndex

        Select Case ccost
            Case Is = 0
                workshopcost = 595D
                days = threedays
            Case Is = 1
                workshopcost = 695D
                days = threedays
            Case Is = 2
                workshopcost = 995D
                days = threedays
            Case Is = 3
                workshopcost = 1295D
                days = fivedays
            Case Is = 4
                workshopcost = 395D
                days = oneday
            Case Else
                MessageBox.Show("Invalid workshop")
        End Select

        If ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("No location selected.")
            tcost = 0
        Else
            'They selected a location so we must cost it.

            tcost = ListBox2.SelectedIndex

            Select Case tcost
                Case Is = 0
                    locationcost = 95D
                Case Is = 1
                    locationcost = 125D
                Case Is = 2
                    locationcost = 110D
                Case Is = 3
                    locationcost = 100D
                Case Is = 4
                    locationcost = 92D
                Case Is = 5
                    locationcost = 90D
                Case Else
                    MessageBox.Show("Invalid location")
            End Select

        End If

        'Display total cost of purchase

        totalcost = workshopcost + (locationcost * days)
        ListBox3.Items.Add(totalcost.ToString("C"))

        grandcost = grandcost + totalcost


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = -1
        ListBox3.Items.Clear()
        lblTotal.Text = String.Empty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblTotal.Text = grandcost.ToString("C")
    End Sub
End Class
