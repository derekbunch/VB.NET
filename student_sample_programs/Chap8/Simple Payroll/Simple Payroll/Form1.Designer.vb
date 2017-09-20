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
		Me.btnCalcPay = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lstOutput
		'
		Me.lstOutput.FormattingEnabled = True
		Me.lstOutput.ItemHeight = 16
		Me.lstOutput.Location = New System.Drawing.Point(28, 24)
		Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lstOutput.Name = "lstOutput"
		Me.lstOutput.Size = New System.Drawing.Size(349, 180)
		Me.lstOutput.TabIndex = 8
		'
		'btnCalcPay
		'
		Me.btnCalcPay.Location = New System.Drawing.Point(60, 221)
		Me.btnCalcPay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalcPay.Name = "btnCalcPay"
		Me.btnCalcPay.Size = New System.Drawing.Size(133, 37)
		Me.btnCalcPay.TabIndex = 9
		Me.btnCalcPay.Text = "&Calculate Payroll"
		Me.btnCalcPay.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(216, 221)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 37)
		Me.btnExit.TabIndex = 10
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(403, 280)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCalcPay)
		Me.Controls.Add(Me.lstOutput)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Simple Payroll"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnCalcPay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
