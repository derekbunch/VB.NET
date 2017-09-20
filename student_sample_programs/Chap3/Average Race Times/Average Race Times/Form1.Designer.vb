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
		Me.lblAverageTime = New System.Windows.Forms.Label()
		Me.txtRunner3 = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtRunner2 = New System.Windows.Forms.TextBox()
		Me.txtRunner1 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblAverageTime
		'
		Me.lblAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAverageTime.Location = New System.Drawing.Point(139, 148)
		Me.lblAverageTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblAverageTime.Name = "lblAverageTime"
		Me.lblAverageTime.Size = New System.Drawing.Size(133, 28)
		Me.lblAverageTime.TabIndex = 8
		Me.lblAverageTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtRunner3
		'
		Me.txtRunner3.Location = New System.Drawing.Point(139, 108)
		Me.txtRunner3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtRunner3.Name = "txtRunner3"
		Me.txtRunner3.Size = New System.Drawing.Size(132, 22)
		Me.txtRunner3.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblAverageTime)
		Me.GroupBox1.Controls.Add(Me.txtRunner3)
		Me.GroupBox1.Controls.Add(Me.txtRunner2)
		Me.GroupBox1.Controls.Add(Me.txtRunner1)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(328, 197)
		Me.GroupBox1.TabIndex = 16
		Me.GroupBox1.TabStop = False
		'
		'txtRunner2
		'
		Me.txtRunner2.Location = New System.Drawing.Point(139, 69)
		Me.txtRunner2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtRunner2.Name = "txtRunner2"
		Me.txtRunner2.Size = New System.Drawing.Size(132, 22)
		Me.txtRunner2.TabIndex = 6
		'
		'txtRunner1
		'
		Me.txtRunner1.Location = New System.Drawing.Point(139, 30)
		Me.txtRunner1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtRunner1.Name = "txtRunner1"
		Me.txtRunner1.Size = New System.Drawing.Size(132, 22)
		Me.txtRunner1.TabIndex = 5
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(23, 148)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(107, 28)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Average Time"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(55, 108)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(75, 28)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Runner &3"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(55, 69)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 28)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Runner &2"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(55, 30)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 28)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Runner &1"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(23, 226)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(100, 44)
		Me.btnCalculate.TabIndex = 17
		Me.btnCalculate.Text = "Calculate &Average"
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(140, 226)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(78, 44)
		Me.btnClear.TabIndex = 18
		Me.btnClear.Text = "&Clear"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(236, 226)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(78, 44)
		Me.btnExit.TabIndex = 19
		Me.btnExit.Text = "E&xit"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(363, 288)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnExit)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Average Race Times"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents lblAverageTime As System.Windows.Forms.Label
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
