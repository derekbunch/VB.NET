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
		Me.lstOutput = New System.Windows.Forms.ListBox()
		Me.btnGo = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lstOutput
		'
		Me.lstOutput.FormattingEnabled = True
		Me.lstOutput.ItemHeight = 16
		Me.lstOutput.Location = New System.Drawing.Point(16, 15)
		Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lstOutput.Name = "lstOutput"
		Me.lstOutput.Size = New System.Drawing.Size(425, 196)
		Me.lstOutput.TabIndex = 0
		'
		'btnGo
		'
		Me.btnGo.Location = New System.Drawing.Point(125, 220)
		Me.btnGo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.Size = New System.Drawing.Size(100, 28)
		Me.btnGo.TabIndex = 1
		Me.btnGo.Text = "&Go!"
		Me.btnGo.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(233, 220)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 2
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(459, 263)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnGo)
		Me.Controls.Add(Me.lstOutput)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "ByVal ByRef Demo"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
