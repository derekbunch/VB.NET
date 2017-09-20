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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtYearsOnJob = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtSalary = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.btnCheckQual = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtYearsOnJob)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtSalary)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(371, 123)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Enter the following information:"
		'
		'txtYearsOnJob
		'
		Me.txtYearsOnJob.Location = New System.Drawing.Point(178, 75)
		Me.txtYearsOnJob.Margin = New System.Windows.Forms.Padding(4)
		Me.txtYearsOnJob.Name = "txtYearsOnJob"
		Me.txtYearsOnJob.Size = New System.Drawing.Size(102, 23)
		Me.txtYearsOnJob.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(41, 69)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(129, 34)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Number of years at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " your current job:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtSalary
		'
		Me.txtSalary.Location = New System.Drawing.Point(178, 39)
		Me.txtSalary.Margin = New System.Windows.Forms.Padding(4)
		Me.txtSalary.Name = "txtSalary"
		Me.txtSalary.Size = New System.Drawing.Size(102, 23)
		Me.txtSalary.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(72, 39)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Annual salary:"
		'
		'lblMessage
		'
		Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMessage.Location = New System.Drawing.Point(16, 153)
		Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(371, 28)
		Me.lblMessage.TabIndex = 4
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnCheckQual
		'
		Me.btnCheckQual.Location = New System.Drawing.Point(16, 196)
		Me.btnCheckQual.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCheckQual.Name = "btnCheckQual"
		Me.btnCheckQual.Size = New System.Drawing.Size(122, 48)
		Me.btnCheckQual.TabIndex = 1
		Me.btnCheckQual.Text = "Check Qualifications"
		Me.btnCheckQual.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(168, 196)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(101, 48)
		Me.btnClear.TabIndex = 2
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(293, 196)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(94, 48)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(408, 258)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCheckQual)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.GroupBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Loan Qualifier"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYearsOnJob As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCheckQual As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
