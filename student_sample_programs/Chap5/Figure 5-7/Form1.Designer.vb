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
		Me.lstMonths = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'lstMonths
		'
		Me.lstMonths.FormattingEnabled = True
		Me.lstMonths.Location = New System.Drawing.Point(29, 52)
		Me.lstMonths.Name = "lstMonths"
		Me.lstMonths.Size = New System.Drawing.Size(171, 108)
		Me.lstMonths.TabIndex = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(580, 290)
		Me.Controls.Add(Me.lstMonths)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lstMonths As System.Windows.Forms.ListBox

End Class
