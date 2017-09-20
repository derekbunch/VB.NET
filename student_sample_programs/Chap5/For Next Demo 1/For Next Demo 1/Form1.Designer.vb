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
		Me.btnRunDemo = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lstOutput
		'
		Me.lstOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstOutput.FormattingEnabled = True
		Me.lstOutput.ItemHeight = 16
		Me.lstOutput.Location = New System.Drawing.Point(22, 12)
		Me.lstOutput.Name = "lstOutput"
		Me.lstOutput.Size = New System.Drawing.Size(270, 196)
		Me.lstOutput.TabIndex = 0
		'
		'btnRunDemo
		'
		Me.btnRunDemo.Location = New System.Drawing.Point(31, 222)
		Me.btnRunDemo.Name = "btnRunDemo"
		Me.btnRunDemo.Size = New System.Drawing.Size(80, 30)
		Me.btnRunDemo.TabIndex = 1
		Me.btnRunDemo.Text = "&Run Demo"
		Me.btnRunDemo.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(117, 222)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(80, 30)
		Me.btnClear.TabIndex = 2
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(203, 222)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(80, 30)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(314, 264)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnRunDemo)
		Me.Controls.Add(Me.lstOutput)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "For Next Demo 1"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnRunDemo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
