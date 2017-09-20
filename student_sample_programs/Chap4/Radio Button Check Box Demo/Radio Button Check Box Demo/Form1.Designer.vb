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
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.radSoftDrink = New System.Windows.Forms.RadioButton()
		Me.radTea = New System.Windows.Forms.RadioButton()
		Me.radCoffee = New System.Windows.Forms.RadioButton()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.chkAmaretto = New System.Windows.Forms.CheckBox()
		Me.chkMoca = New System.Windows.Forms.CheckBox()
		Me.chkWhipped = New System.Windows.Forms.CheckBox()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblResult = New System.Windows.Forms.ToolStripStatusLabel()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(91, 172)
		Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(100, 28)
		Me.btnOk.TabIndex = 2
		Me.btnOk.Text = "&OK"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(220, 172)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.radSoftDrink)
		Me.GroupBox1.Controls.Add(Me.radTea)
		Me.GroupBox1.Controls.Add(Me.radCoffee)
		Me.GroupBox1.Location = New System.Drawing.Point(40, 15)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(140, 128)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Select a Drink"
		'
		'radSoftDrink
		'
		Me.radSoftDrink.AutoSize = True
		Me.radSoftDrink.Location = New System.Drawing.Point(25, 84)
		Me.radSoftDrink.Margin = New System.Windows.Forms.Padding(4)
		Me.radSoftDrink.Name = "radSoftDrink"
		Me.radSoftDrink.Size = New System.Drawing.Size(88, 21)
		Me.radSoftDrink.TabIndex = 2
		Me.radSoftDrink.TabStop = True
		Me.radSoftDrink.Text = "Soft Drink"
		Me.radSoftDrink.UseVisualStyleBackColor = True
		'
		'radTea
		'
		Me.radTea.AutoSize = True
		Me.radTea.Location = New System.Drawing.Point(25, 55)
		Me.radTea.Margin = New System.Windows.Forms.Padding(4)
		Me.radTea.Name = "radTea"
		Me.radTea.Size = New System.Drawing.Size(51, 21)
		Me.radTea.TabIndex = 1
		Me.radTea.TabStop = True
		Me.radTea.Text = "Tea"
		Me.radTea.UseVisualStyleBackColor = True
		'
		'radCoffee
		'
		Me.radCoffee.AutoSize = True
		Me.radCoffee.Location = New System.Drawing.Point(25, 26)
		Me.radCoffee.Margin = New System.Windows.Forms.Padding(4)
		Me.radCoffee.Name = "radCoffee"
		Me.radCoffee.Size = New System.Drawing.Size(67, 21)
		Me.radCoffee.TabIndex = 0
		Me.radCoffee.TabStop = True
		Me.radCoffee.Text = "Coffee"
		Me.radCoffee.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.chkAmaretto)
		Me.GroupBox2.Controls.Add(Me.chkMoca)
		Me.GroupBox2.Controls.Add(Me.chkWhipped)
		Me.GroupBox2.Location = New System.Drawing.Point(220, 15)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Size = New System.Drawing.Size(164, 128)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Select Extras"
		'
		'chkAmaretto
		'
		Me.chkAmaretto.AutoSize = True
		Me.chkAmaretto.Location = New System.Drawing.Point(24, 85)
		Me.chkAmaretto.Margin = New System.Windows.Forms.Padding(4)
		Me.chkAmaretto.Name = "chkAmaretto"
		Me.chkAmaretto.Size = New System.Drawing.Size(84, 21)
		Me.chkAmaretto.TabIndex = 2
		Me.chkAmaretto.Text = "Amaretto"
		Me.chkAmaretto.UseVisualStyleBackColor = True
		'
		'chkMoca
		'
		Me.chkMoca.AutoSize = True
		Me.chkMoca.Location = New System.Drawing.Point(24, 56)
		Me.chkMoca.Margin = New System.Windows.Forms.Padding(4)
		Me.chkMoca.Name = "chkMoca"
		Me.chkMoca.Size = New System.Drawing.Size(61, 21)
		Me.chkMoca.TabIndex = 1
		Me.chkMoca.Text = "Moca"
		Me.chkMoca.UseVisualStyleBackColor = True
		'
		'chkWhipped
		'
		Me.chkWhipped.AutoSize = True
		Me.chkWhipped.Location = New System.Drawing.Point(24, 26)
		Me.chkWhipped.Margin = New System.Windows.Forms.Padding(4)
		Me.chkWhipped.Name = "chkWhipped"
		Me.chkWhipped.Size = New System.Drawing.Size(128, 21)
		Me.chkWhipped.TabIndex = 0
		Me.chkWhipped.Text = "Whipped Cream"
		Me.chkWhipped.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblResult})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 228)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(419, 22)
		Me.StatusStrip1.TabIndex = 4
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblResult
		'
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(419, 250)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnOk)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Radio Buttons and Check Boxes"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSoftDrink As System.Windows.Forms.RadioButton
    Friend WithEvents radTea As System.Windows.Forms.RadioButton
    Friend WithEvents radCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAmaretto As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoca As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhipped As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblResult As System.Windows.Forms.ToolStripStatusLabel

End Class
