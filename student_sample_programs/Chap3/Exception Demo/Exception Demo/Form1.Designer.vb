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
		Me.btnOk = New System.Windows.Forms.Button()
		Me.txtSalary = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblResult = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(192, 66)
		Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(100, 28)
		Me.btnOk.TabIndex = 14
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'txtSalary
		'
		Me.txtSalary.Location = New System.Drawing.Point(192, 26)
		Me.txtSalary.Margin = New System.Windows.Forms.Padding(4)
		Me.txtSalary.Name = "txtSalary"
		Me.txtSalary.Size = New System.Drawing.Size(132, 23)
		Me.txtSalary.TabIndex = 13
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(64, 31)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(120, 17)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Enter your salary:"
		'
		'lblResult
		'
		Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblResult.Location = New System.Drawing.Point(21, 104)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(333, 27)
		Me.lblResult.TabIndex = 16
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(390, 147)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.txtSalary)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Exception Demo"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents txtSalary As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
