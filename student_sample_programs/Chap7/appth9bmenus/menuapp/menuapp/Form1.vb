Public Class Form1


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DineInToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DineInToolStripMenuItem1.Click
        Dim dineinmenu As New Dineinmenu
        dineinmenu.showdialog()

    End Sub

    Private Sub CarryOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarryOutToolStripMenuItem.Click
        Dim carryout As New carryout
        carryout.ShowDialog()
    End Sub
End Class
