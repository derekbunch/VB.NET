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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.hsbScrollBar = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Slide to adjust the value."
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValue.Location = New System.Drawing.Point(101, 21)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(65, 23)
        Me.lblValue.TabIndex = 5
        '
        'hsbScrollBar
        '
        Me.hsbScrollBar.Location = New System.Drawing.Point(9, 68)
        Me.hsbScrollBar.Name = "hsbScrollBar"
        Me.hsbScrollBar.Size = New System.Drawing.Size(206, 23)
        Me.hsbScrollBar.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 134)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.hsbScrollBar)
        Me.Name = "Form1"
        Me.Text = "HScrollBar Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents hsbScrollBar As System.Windows.Forms.HScrollBar

End Class
