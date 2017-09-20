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
		Me.lblAverage = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtScore3 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtScore2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtScore1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblAverage)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtScore3)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtScore2)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtScore1)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(264, 185)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Enter Three Test Scores"
		'
		'lblAverage
		'
		Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAverage.Location = New System.Drawing.Point(109, 144)
		Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblAverage.Name = "lblAverage"
		Me.lblAverage.Size = New System.Drawing.Size(87, 25)
		Me.lblAverage.TabIndex = 7
		Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(38, 148)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(63, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Average:"
		'
		'txtScore3
		'
		Me.txtScore3.Location = New System.Drawing.Point(109, 98)
		Me.txtScore3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtScore3.Name = "txtScore3"
		Me.txtScore3.Size = New System.Drawing.Size(85, 22)
		Me.txtScore3.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(44, 101)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(57, 16)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Score 3:"
		'
		'txtScore2
		'
		Me.txtScore2.Location = New System.Drawing.Point(109, 66)
		Me.txtScore2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtScore2.Name = "txtScore2"
		Me.txtScore2.Size = New System.Drawing.Size(85, 22)
		Me.txtScore2.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(44, 69)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 16)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Score 2:"
		'
		'txtScore1
		'
		Me.txtScore1.Location = New System.Drawing.Point(109, 34)
		Me.txtScore1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtScore1.Name = "txtScore1"
		Me.txtScore1.Size = New System.Drawing.Size(85, 22)
		Me.txtScore1.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(44, 37)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(57, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Score 1:"
		'
		'lblMessage
		'
		Me.lblMessage.Location = New System.Drawing.Point(16, 203)
		Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(293, 31)
		Me.lblMessage.TabIndex = 4
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(47, 250)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(103, 46)
		Me.btnCalculate.TabIndex = 1
		Me.btnCalculate.Text = "&Calculate Average"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(180, 246)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(100, 28)
		Me.btnClear.TabIndex = 2
		Me.btnClear.Text = "Cl&ear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(180, 282)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(304, 325)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.GroupBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Test Score Average"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScore3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtScore1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
