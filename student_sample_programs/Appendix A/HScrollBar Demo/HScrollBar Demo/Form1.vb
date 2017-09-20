Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the property values for the scroll bar control.
        ' These properties can also be set at Design
        ' time in the Properties window.
        hsbScrollBar.Value = 0
        hsbScrollBar.Minimum = 0
        hsbScrollBar.Maximum = 100
        hsbScrollBar.LargeChange = 10
        hsbScrollBar.SmallChange = 1

        ' Display the scroll bar's initial value
        ' in the label control.
        lblValue.Text = hsbScrollBar.Value.ToString
    End Sub

    Private Sub hsbScrollBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbScrollBar.Scroll
        ' Display the scroll bar value.
        lblValue.Text = hsbScrollBar.Value.ToString()
    End Sub
End Class
