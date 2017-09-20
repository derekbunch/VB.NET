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
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnCalcGrossPay = New System.Windows.Forms.Button()
		Me.txtPayRate = New System.Windows.Forms.TextBox()
		Me.txtHoursWorked = New System.Windows.Forms.TextBox()
		Me.lblGrossPay = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.SystemColors.Control
		Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnClose.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClose.Location = New System.Drawing.Point(183, 172)
		Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClose.Size = New System.Drawing.Size(85, 49)
		Me.btnClose.TabIndex = 31
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'btnCalcGrossPay
		'
		Me.btnCalcGrossPay.BackColor = System.Drawing.SystemColors.Control
		Me.btnCalcGrossPay.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCalcGrossPay.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnCalcGrossPay.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalcGrossPay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCalcGrossPay.Location = New System.Drawing.Point(62, 172)
		Me.btnCalcGrossPay.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCalcGrossPay.Name = "btnCalcGrossPay"
		Me.btnCalcGrossPay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCalcGrossPay.Size = New System.Drawing.Size(98, 49)
		Me.btnCalcGrossPay.TabIndex = 30
		Me.btnCalcGrossPay.Text = "Calculate Gross Pay"
		Me.btnCalcGrossPay.UseVisualStyleBackColor = False
		'
		'txtPayRate
		'
		Me.txtPayRate.AcceptsReturn = True
		Me.txtPayRate.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayRate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayRate.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayRate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayRate.Location = New System.Drawing.Point(195, 78)
		Me.txtPayRate.Margin = New System.Windows.Forms.Padding(4)
		Me.txtPayRate.MaxLength = 0
		Me.txtPayRate.Name = "txtPayRate"
		Me.txtPayRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayRate.Size = New System.Drawing.Size(96, 22)
		Me.txtPayRate.TabIndex = 27
		'
		'txtHoursWorked
		'
		Me.txtHoursWorked.AcceptsReturn = True
		Me.txtHoursWorked.BackColor = System.Drawing.SystemColors.Window
		Me.txtHoursWorked.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHoursWorked.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHoursWorked.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHoursWorked.Location = New System.Drawing.Point(195, 29)
		Me.txtHoursWorked.Margin = New System.Windows.Forms.Padding(4)
		Me.txtHoursWorked.MaxLength = 0
		Me.txtHoursWorked.Name = "txtHoursWorked"
		Me.txtHoursWorked.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHoursWorked.Size = New System.Drawing.Size(96, 22)
		Me.txtHoursWorked.TabIndex = 25
		'
		'lblGrossPay
		'
		Me.lblGrossPay.BackColor = System.Drawing.SystemColors.Control
		Me.lblGrossPay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGrossPay.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrossPay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGrossPay.Location = New System.Drawing.Point(195, 131)
		Me.lblGrossPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGrossPay.Name = "lblGrossPay"
		Me.lblGrossPay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGrossPay.Size = New System.Drawing.Size(97, 21)
		Me.lblGrossPay.TabIndex = 29
		Me.lblGrossPay.Text = "$ 0.00"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(59, 129)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(128, 21)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Gross Pay Earned"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(73, 79)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(114, 21)
		Me.Label2.TabIndex = 26
		Me.Label2.Text = "Hourly Pay Rate"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(41, 30)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(146, 21)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "Number of Hours Worked"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(345, 252)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnCalcGrossPay)
		Me.Controls.Add(Me.txtPayRate)
		Me.Controls.Add(Me.txtHoursWorked)
		Me.Controls.Add(Me.lblGrossPay)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Wage Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents btnCalcGrossPay As System.Windows.Forms.Button
    Public WithEvents txtPayRate As System.Windows.Forms.TextBox
    Public WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Public WithEvents lblGrossPay As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label

End Class
