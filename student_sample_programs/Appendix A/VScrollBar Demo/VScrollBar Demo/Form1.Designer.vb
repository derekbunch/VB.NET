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
        Me.vsbScrollBar = New System.Windows.Forms.VScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'vsbScrollBar
        '
        Me.vsbScrollBar.Location = New System.Drawing.Point(179, 28)
        Me.vsbScrollBar.Name = "vsbScrollBar"
        Me.vsbScrollBar.Size = New System.Drawing.Size(21, 114)
        Me.vsbScrollBar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Slide to adjust the value."
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValue.Location = New System.Drawing.Point(77, 23)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(65, 23)
        Me.lblValue.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 164)
        Me.Controls.Add(Me.vsbScrollBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblValue)
        Me.Name = "Form1"
        Me.Text = "VScrollBar Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsbScrollBar As System.Windows.Forms.VScrollBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label

End Class
