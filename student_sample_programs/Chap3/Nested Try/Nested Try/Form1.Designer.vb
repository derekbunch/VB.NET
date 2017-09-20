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
		Me.lblSalary = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPayPeriods = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblSalary
		'
		Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblSalary.Location = New System.Drawing.Point(203, 118)
		Me.lblSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSalary.Name = "lblSalary"
		Me.lblSalary.Size = New System.Drawing.Size(155, 28)
		Me.lblSalary.TabIndex = 44
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(25, 117)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(169, 28)
		Me.Label3.TabIndex = 47
		Me.Label3.Text = "Salary per pay period:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtPayPeriods
		'
		Me.txtPayPeriods.Location = New System.Drawing.Point(203, 75)
		Me.txtPayPeriods.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtPayPeriods.Name = "txtPayPeriods"
		Me.txtPayPeriods.Size = New System.Drawing.Size(153, 23)
		Me.txtPayPeriods.TabIndex = 43
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(43, 73)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(152, 28)
		Me.Label2.TabIndex = 45
		Me.Label2.Text = "Pay periods per year:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(158, 169)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(100, 28)
		Me.btnCalculate.TabIndex = 46
		Me.btnCalculate.Text = "Calculate"
		'
		'txtAnnualSalary
		'
		Me.txtAnnualSalary.Location = New System.Drawing.Point(203, 28)
		Me.txtAnnualSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtAnnualSalary.Name = "txtAnnualSalary"
		Me.txtAnnualSalary.Size = New System.Drawing.Size(153, 23)
		Me.txtAnnualSalary.TabIndex = 41
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(68, 25)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(127, 28)
		Me.Label1.TabIndex = 42
		Me.Label1.Text = "Annual salary:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 222)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(416, 22)
		Me.StatusStrip1.TabIndex = 48
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(416, 244)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.lblSalary)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtPayPeriods)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.txtAnnualSalary)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Salary Calculator"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPayPeriods As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtAnnualSalary As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
