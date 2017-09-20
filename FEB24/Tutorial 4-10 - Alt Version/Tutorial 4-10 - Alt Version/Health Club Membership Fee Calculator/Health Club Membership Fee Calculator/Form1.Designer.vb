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
		Me.btnExit = New System.Windows.Forms.Button()
		Me.radSenior = New System.Windows.Forms.RadioButton()
		Me.radStudent = New System.Windows.Forms.RadioButton()
		Me.radChild = New System.Windows.Forms.RadioButton()
		Me.radAdult = New System.Windows.Forms.RadioButton()
		Me.chkTrainer = New System.Windows.Forms.CheckBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.chkKarate = New System.Windows.Forms.CheckBox()
		Me.chkYoga = New System.Windows.Forms.CheckBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.txtMonths = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblMonthlyFee = New System.Windows.Forms.Label()
		Me.lblTotalFee = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(295, 322)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 20
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'radSenior
		'
		Me.radSenior.AutoSize = True
		Me.radSenior.Location = New System.Drawing.Point(11, 117)
		Me.radSenior.Margin = New System.Windows.Forms.Padding(4)
		Me.radSenior.Name = "radSenior"
		Me.radSenior.Size = New System.Drawing.Size(113, 21)
		Me.radSenior.TabIndex = 3
		Me.radSenior.TabStop = True
		Me.radSenior.Text = "S&enior Citizen"
		Me.radSenior.UseVisualStyleBackColor = True
		'
		'radStudent
		'
		Me.radStudent.AutoSize = True
		Me.radStudent.Location = New System.Drawing.Point(11, 89)
		Me.radStudent.Margin = New System.Windows.Forms.Padding(4)
		Me.radStudent.Name = "radStudent"
		Me.radStudent.Size = New System.Drawing.Size(75, 21)
		Me.radStudent.TabIndex = 2
		Me.radStudent.TabStop = True
		Me.radStudent.Text = "&Student"
		Me.radStudent.UseVisualStyleBackColor = True
		'
		'radChild
		'
		Me.radChild.AutoSize = True
		Me.radChild.Location = New System.Drawing.Point(11, 60)
		Me.radChild.Margin = New System.Windows.Forms.Padding(4)
		Me.radChild.Name = "radChild"
		Me.radChild.Size = New System.Drawing.Size(141, 21)
		Me.radChild.TabIndex = 1
		Me.radChild.TabStop = True
		Me.radChild.Text = "Chil&d (12 && under)"
		Me.radChild.UseVisualStyleBackColor = True
		'
		'radAdult
		'
		Me.radAdult.AutoSize = True
		Me.radAdult.Location = New System.Drawing.Point(11, 32)
		Me.radAdult.Margin = New System.Windows.Forms.Padding(4)
		Me.radAdult.Name = "radAdult"
		Me.radAdult.Size = New System.Drawing.Size(120, 21)
		Me.radAdult.TabIndex = 0
		Me.radAdult.TabStop = True
		Me.radAdult.Text = "Standard &Adult"
		Me.radAdult.UseVisualStyleBackColor = True
		'
		'chkTrainer
		'
		Me.chkTrainer.AutoSize = True
		Me.chkTrainer.Location = New System.Drawing.Point(35, 112)
		Me.chkTrainer.Margin = New System.Windows.Forms.Padding(4)
		Me.chkTrainer.Name = "chkTrainer"
		Me.chkTrainer.Size = New System.Drawing.Size(133, 21)
		Me.chkTrainer.TabIndex = 2
		Me.chkTrainer.Text = "&Personal Trainer"
		Me.chkTrainer.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.chkTrainer)
		Me.GroupBox2.Controls.Add(Me.chkKarate)
		Me.GroupBox2.Controls.Add(Me.chkYoga)
		Me.GroupBox2.Location = New System.Drawing.Point(236, 21)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Size = New System.Drawing.Size(212, 151)
		Me.GroupBox2.TabIndex = 15
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Options"
		'
		'chkKarate
		'
		Me.chkKarate.AutoSize = True
		Me.chkKarate.Location = New System.Drawing.Point(35, 74)
		Me.chkKarate.Margin = New System.Windows.Forms.Padding(4)
		Me.chkKarate.Name = "chkKarate"
		Me.chkKarate.Size = New System.Drawing.Size(69, 21)
		Me.chkKarate.TabIndex = 1
		Me.chkKarate.Text = "&Karate"
		Me.chkKarate.UseVisualStyleBackColor = True
		'
		'chkYoga
		'
		Me.chkYoga.AutoSize = True
		Me.chkYoga.Location = New System.Drawing.Point(35, 36)
		Me.chkYoga.Margin = New System.Windows.Forms.Padding(4)
		Me.chkYoga.Name = "chkYoga"
		Me.chkYoga.Size = New System.Drawing.Size(60, 21)
		Me.chkYoga.TabIndex = 0
		Me.chkYoga.Text = "&Yoga"
		Me.chkYoga.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.txtMonths)
		Me.GroupBox3.Controls.Add(Me.Label1)
		Me.GroupBox3.Location = New System.Drawing.Point(28, 180)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox3.Size = New System.Drawing.Size(181, 123)
		Me.GroupBox3.TabIndex = 16
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Membership Length"
		'
		'txtMonths
		'
		Me.txtMonths.Location = New System.Drawing.Point(15, 82)
		Me.txtMonths.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMonths.Name = "txtMonths"
		Me.txtMonths.Size = New System.Drawing.Size(131, 23)
		Me.txtMonths.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 42)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(124, 34)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Enter the Number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Months:"
		'
		'lblMonthlyFee
		'
		Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMonthlyFee.Location = New System.Drawing.Point(107, 41)
		Me.lblMonthlyFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblMonthlyFee.Name = "lblMonthlyFee"
		Me.lblMonthlyFee.Size = New System.Drawing.Size(89, 28)
		Me.lblMonthlyFee.TabIndex = 2
		'
		'lblTotalFee
		'
		Me.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotalFee.Location = New System.Drawing.Point(107, 86)
		Me.lblTotalFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotalFee.Name = "lblTotalFee"
		Me.lblTotalFee.Size = New System.Drawing.Size(89, 28)
		Me.lblTotalFee.TabIndex = 3
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.lblTotalFee)
		Me.GroupBox4.Controls.Add(Me.lblMonthlyFee)
		Me.GroupBox4.Controls.Add(Me.Label3)
		Me.GroupBox4.Controls.Add(Me.Label2)
		Me.GroupBox4.Location = New System.Drawing.Point(236, 180)
		Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox4.Size = New System.Drawing.Size(220, 123)
		Me.GroupBox4.TabIndex = 17
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Membership Fees"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(53, 89)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(44, 17)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "Total:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 42)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Monthly Fee:"
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(179, 322)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(100, 28)
		Me.btnClear.TabIndex = 19
		Me.btnClear.Text = "Clea&r"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(62, 322)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(100, 28)
		Me.btnCalculate.TabIndex = 18
		Me.btnCalculate.Text = "&Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.radSenior)
		Me.GroupBox1.Controls.Add(Me.radStudent)
		Me.GroupBox1.Controls.Add(Me.radChild)
		Me.GroupBox1.Controls.Add(Me.radAdult)
		Me.GroupBox1.Location = New System.Drawing.Point(28, 21)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(181, 151)
		Me.GroupBox1.TabIndex = 14
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Type of Membership"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
		Me.StatusStrip1.TabIndex = 21
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
		Me.ClientSize = New System.Drawing.Size(484, 386)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.GroupBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Membership Fee Calculator"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radSenior As System.Windows.Forms.RadioButton
    Friend WithEvents radStudent As System.Windows.Forms.RadioButton
    Friend WithEvents radChild As System.Windows.Forms.RadioButton
    Friend WithEvents radAdult As System.Windows.Forms.RadioButton
    Friend WithEvents chkTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkKarate As System.Windows.Forms.CheckBox
    Friend WithEvents chkYoga As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyFee As System.Windows.Forms.Label
    Friend WithEvents lblTotalFee As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
