<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DineInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DineInToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarryOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DineInToolStripMenuItem, Me.DeliveryToolStripMenuItem, Me.EndShiftToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DineInToolStripMenuItem
        '
        Me.DineInToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DineInToolStripMenuItem1, Me.CarryOutToolStripMenuItem})
        Me.DineInToolStripMenuItem.Name = "DineInToolStripMenuItem"
        Me.DineInToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.DineInToolStripMenuItem.Text = "Dining"
        '
        'DineInToolStripMenuItem1
        '
        Me.DineInToolStripMenuItem1.Name = "DineInToolStripMenuItem1"
        Me.DineInToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.DineInToolStripMenuItem1.Text = "Dine In"
        '
        'CarryOutToolStripMenuItem
        '
        Me.CarryOutToolStripMenuItem.Name = "CarryOutToolStripMenuItem"
        Me.CarryOutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CarryOutToolStripMenuItem.Text = "Carry Out"
        '
        'DeliveryToolStripMenuItem
        '
        Me.DeliveryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FastToolStripMenuItem, Me.StandardToolStripMenuItem})
        Me.DeliveryToolStripMenuItem.Name = "DeliveryToolStripMenuItem"
        Me.DeliveryToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.DeliveryToolStripMenuItem.Text = "Delivery"
        '
        'FastToolStripMenuItem
        '
        Me.FastToolStripMenuItem.Name = "FastToolStripMenuItem"
        Me.FastToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.FastToolStripMenuItem.Text = "Fast"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'EndShiftToolStripMenuItem
        '
        Me.EndShiftToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.EndShiftToolStripMenuItem.Name = "EndShiftToolStripMenuItem"
        Me.EndShiftToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.EndShiftToolStripMenuItem.Text = "End Shift"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DineInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DineInToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarryOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndShiftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
