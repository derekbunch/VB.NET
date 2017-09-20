Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ccost As Double
        Dim bevcost As Double
        Dim tcost As Double
        Dim addcost As Double
        Dim totalcost As Double

        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please choose a beverage.")
            Return
        End If

        TextBox1.Text = ListBox1.SelectedItem

        ccost = ListBox1.SelectedIndex

        Select Case ccost
            Case Is = 0
                bevcost = 2D
            Case Is = 1
                bevcost = 2.5D
            Case Is = 2
                bevcost = 3D
            Case Is = 3
                bevcost = 2.5D
            Case Else
                MessageBox.Show("Invalid beverage")
        End Select

        If ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("No topping selected.")
            tcost = 0
        Else
            'They selected a topping so we must cost it.

            TextBox2.Text = ListBox2.SelectedItem

            tcost = ListBox2.SelectedIndex

            Select Case tcost
                Case Is = 0
                    addcost = 0.25D
                Case Is = 1
                    addcost = 0.5D
                Case Is = 2
                    addcost = 0.75D
                Case Else
                    MessageBox.Show("Invalid supplement")
            End Select

        End If

        'Display total cost of purchase

        totalcost = bevcost + addcost
        Label3.Text = totalcost.tostring("C")

    End Sub
End Class
