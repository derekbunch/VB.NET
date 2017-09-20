Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the property values for the scroll bar control.
        ' These properties can also be set at Design
        ' time in the Properties window.
        vsbScrollBar.Value = 0
        vsbScrollBar.Minimum = 0
        vsbScrollBar.Maximum = 100
        vsbScrollBar.LargeChange = 10
        vsbScrollBar.SmallChange = 1

        ' Display the scroll bar's initial value
        ' in the label control.
        lblValue.Text = vsbScrollBar.Value.ToString
    End Sub

    Private Sub vsbScrollBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbScrollBar.Scroll
        ' Display the scroll bar value.
        lblValue.Text = vsbScrollBar.Value.ToString()
    End Sub
End Class
