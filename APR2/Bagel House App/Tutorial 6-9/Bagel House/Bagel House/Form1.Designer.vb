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
		Me.components = New System.ComponentModel.Container()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.radWheat = New System.Windows.Forms.RadioButton()
		Me.radWhite = New System.Windows.Forms.RadioButton()
		Me.lblTax = New System.Windows.Forms.Label()
		Me.chkPeach = New System.Windows.Forms.CheckBox()
		Me.chkRaspberry = New System.Windows.Forms.CheckBox()
		Me.chkBlueberry = New System.Windows.Forms.CheckBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.lblSubtotal = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
		Me.radCappuccino = New System.Windows.Forms.RadioButton()
		Me.radRegCoffee = New System.Windows.Forms.RadioButton()
		Me.radNoCoffee = New System.Windows.Forms.RadioButton()
		Me.chkButter = New System.Windows.Forms.CheckBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.radWheat)
		Me.GroupBox1.Controls.Add(Me.radWhite)
		Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(203, 89)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Pick a Bagel"
		'
		'radWheat
		'
		Me.radWheat.AutoSize = True
		Me.radWheat.Location = New System.Drawing.Point(9, 53)
		Me.radWheat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.radWheat.Name = "radWheat"
		Me.radWheat.Size = New System.Drawing.Size(161, 21)
		Me.radWheat.TabIndex = 1
		Me.radWheat.Text = "Whole Wheat ($1.50)"
		Me.ToolTip1.SetToolTip(Me.radWheat, "Click here to choose a whole wheat bagel.")
		Me.radWheat.UseVisualStyleBackColor = True
		'
		'radWhite
		'
		Me.radWhite.AutoSize = True
		Me.radWhite.Checked = True
		Me.radWhite.Location = New System.Drawing.Point(9, 25)
		Me.radWhite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.radWhite.Name = "radWhite"
		Me.radWhite.Size = New System.Drawing.Size(112, 21)
		Me.radWhite.TabIndex = 0
		Me.radWhite.TabStop = True
		Me.radWhite.Text = "White ($1.25)"
		Me.ToolTip1.SetToolTip(Me.radWhite, "Click here to choose a white bagel.")
		Me.radWhite.UseVisualStyleBackColor = True
		'
		'lblTax
		'
		Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTax.Location = New System.Drawing.Point(108, 59)
		Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTax.Name = "lblTax"
		Me.lblTax.Size = New System.Drawing.Size(57, 20)
		Me.lblTax.TabIndex = 4
		'
		'chkPeach
		'
		Me.chkPeach.AutoSize = True
		Me.chkPeach.Location = New System.Drawing.Point(8, 149)
		Me.chkPeach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chkPeach.Name = "chkPeach"
		Me.chkPeach.Size = New System.Drawing.Size(141, 21)
		Me.chkPeach.TabIndex = 4
		Me.chkPeach.Text = "Peach Jelly ($.75)"
		Me.ToolTip1.SetToolTip(Me.chkPeach, "Click here to choose peach jelly.")
		Me.chkPeach.UseVisualStyleBackColor = True
		'
		'chkRaspberry
		'
		Me.chkRaspberry.AutoSize = True
		Me.chkRaspberry.Location = New System.Drawing.Point(8, 119)
		Me.chkRaspberry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chkRaspberry.Name = "chkRaspberry"
		Me.chkRaspberry.Size = New System.Drawing.Size(165, 21)
		Me.chkRaspberry.TabIndex = 3
		Me.chkRaspberry.Text = "Raspberry Jam ($.75)"
		Me.ToolTip1.SetToolTip(Me.chkRaspberry, "Click here to choose raspberry jam.")
		Me.chkRaspberry.UseVisualStyleBackColor = True
		'
		'chkBlueberry
		'
		Me.chkBlueberry.AutoSize = True
		Me.chkBlueberry.Location = New System.Drawing.Point(8, 90)
		Me.chkBlueberry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chkBlueberry.Name = "chkBlueberry"
		Me.chkBlueberry.Size = New System.Drawing.Size(160, 21)
		Me.chkBlueberry.TabIndex = 2
		Me.chkBlueberry.Text = "Blueberry Jam ($.75)"
		Me.ToolTip1.SetToolTip(Me.chkBlueberry, "Click here to choose blueberry jam.")
		Me.chkBlueberry.UseVisualStyleBackColor = True
		'
		'lblTotal
		'
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotal.Location = New System.Drawing.Point(108, 90)
		Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(57, 20)
		Me.lblTotal.TabIndex = 5
		'
		'lblSubtotal
		'
		Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubtotal.Location = New System.Drawing.Point(108, 30)
		Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSubtotal.Name = "lblSubtotal"
		Me.lblSubtotal.Size = New System.Drawing.Size(57, 20)
		Me.lblSubtotal.TabIndex = 3
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(381, 426)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(128, 30)
		Me.btnExit.TabIndex = 12
		Me.btnExit.Text = "E&xit"
		Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit.")
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(63, 426)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(149, 30)
		Me.btnCalculate.TabIndex = 10
		Me.btnCalculate.Text = "&Calculate Total"
		Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click here to calculate the total of the order.")
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.Location = New System.Drawing.Point(224, 426)
		Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(146, 30)
		Me.btnReset.TabIndex = 11
		Me.btnReset.Text = "&Reset Form"
		Me.ToolTip1.SetToolTip(Me.btnReset, "Click here to clear the form and start over.")
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(59, 90)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(40, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Total"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.lblTotal)
		Me.GroupBox4.Controls.Add(Me.lblTax)
		Me.GroupBox4.Controls.Add(Me.lblSubtotal)
		Me.GroupBox4.Controls.Add(Me.Label3)
		Me.GroupBox4.Controls.Add(Me.Label2)
		Me.GroupBox4.Controls.Add(Me.Label1)
		Me.GroupBox4.Location = New System.Drawing.Point(25, 12)
		Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox4.Size = New System.Drawing.Size(222, 122)
		Me.GroupBox4.TabIndex = 13
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Price"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(67, 59)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(31, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Tax"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(39, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Subtotal"
		'
		'chkCreamCheese
		'
		Me.chkCreamCheese.AutoSize = True
		Me.chkCreamCheese.Location = New System.Drawing.Point(8, 32)
		Me.chkCreamCheese.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chkCreamCheese.Name = "chkCreamCheese"
		Me.chkCreamCheese.Size = New System.Drawing.Size(162, 21)
		Me.chkCreamCheese.TabIndex = 0
		Me.chkCreamCheese.Text = "Cream Cheese ($.50)"
		Me.ToolTip1.SetToolTip(Me.chkCreamCheese, "Click here to choose cream cheese.")
		Me.chkCreamCheese.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.radCafeAuLait)
		Me.GroupBox2.Controls.Add(Me.radCappuccino)
		Me.GroupBox2.Controls.Add(Me.radRegCoffee)
		Me.GroupBox2.Controls.Add(Me.radNoCoffee)
		Me.GroupBox2.Location = New System.Drawing.Point(23, 11)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Size = New System.Drawing.Size(224, 146)
		Me.GroupBox2.TabIndex = 9
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Want Coffee with That?"
		'
		'radCafeAuLait
		'
		Me.radCafeAuLait.AutoSize = True
		Me.radCafeAuLait.Location = New System.Drawing.Point(9, 113)
		Me.radCafeAuLait.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.radCafeAuLait.Name = "radCafeAuLait"
		Me.radCafeAuLait.Size = New System.Drawing.Size(147, 21)
		Me.radCafeAuLait.TabIndex = 3
		Me.radCafeAuLait.TabStop = True
		Me.radCafeAuLait.Text = "Cafe au lait ($1.75)"
		Me.ToolTip1.SetToolTip(Me.radCafeAuLait, "Click here to choose cafe au lait.")
		Me.radCafeAuLait.UseVisualStyleBackColor = True
		'
		'radCappuccino
		'
		Me.radCappuccino.AutoSize = True
		Me.radCappuccino.Location = New System.Drawing.Point(9, 84)
		Me.radCappuccino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.radCappuccino.Name = "radCappuccino"
		Me.radCappuccino.Size = New System.Drawing.Size(150, 21)
		Me.radCappuccino.TabIndex = 2
		Me.radCappuccino.TabStop = True
		Me.radCappuccino.Text = "Cappuccino ($2.00)"
		Me.ToolTip1.SetToolTip(Me.radCappuccino, "Click here to choose cappuccino.")
		Me.radCappuccino.UseVisualStyleBackColor = True
		'
		'radRegCoffee
		'
		Me.radRegCoffee.AutoSize = True
		Me.radRegCoffee.Checked = True
		Me.radRegCoffee.Location = New System.Drawing.Point(9, 54)
		Me.radRegCoffee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.radRegCoffee.Name = "radRegCoffee"
		Me.radRegCoffee.Size = New System.Drawing.Size(171, 21)
		Me.radRegCoffee.TabIndex = 1
		Me.radRegCoffee.TabStop = True
		Me.radRegCoffee.Text = "Regular Coffee ($1.25)"
		Me.ToolTip1.SetToolTip(Me.radRegCoffee, "Click here to choose regular coffee.")
		Me.radRegCoffee.UseVisualStyleBackColor = True
		'
		'radNoCoffee
		'
		Me.radNoCoffee.AutoSize = True
		Me.radNoCoffee.Location = New System.Drawing.Point(9, 25)
		Me.radNoCoffee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.radNoCoffee.Name = "radNoCoffee"
		Me.radNoCoffee.Size = New System.Drawing.Size(60, 21)
		Me.radNoCoffee.TabIndex = 0
		Me.radNoCoffee.Text = "None"
		Me.ToolTip1.SetToolTip(Me.radNoCoffee, "Click here to choose no coffee.")
		Me.radNoCoffee.UseVisualStyleBackColor = True
		'
		'chkButter
		'
		Me.chkButter.AutoSize = True
		Me.chkButter.Location = New System.Drawing.Point(8, 60)
		Me.chkButter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.chkButter.Name = "chkButter"
		Me.chkButter.Size = New System.Drawing.Size(107, 21)
		Me.chkButter.TabIndex = 1
		Me.chkButter.Text = "Butter ($.25)"
		Me.ToolTip1.SetToolTip(Me.chkButter, "Click here to choose butter.")
		Me.chkButter.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.chkPeach)
		Me.GroupBox3.Controls.Add(Me.chkRaspberry)
		Me.GroupBox3.Controls.Add(Me.chkBlueberry)
		Me.GroupBox3.Controls.Add(Me.chkButter)
		Me.GroupBox3.Controls.Add(Me.chkCreamCheese)
		Me.GroupBox3.Location = New System.Drawing.Point(15, 124)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox3.Size = New System.Drawing.Size(203, 180)
		Me.GroupBox3.TabIndex = 8
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Pick Your Toppings"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.GroupBox1)
		Me.Panel1.Controls.Add(Me.GroupBox3)
		Me.Panel1.Location = New System.Drawing.Point(25, 77)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(238, 331)
		Me.Panel1.TabIndex = 14
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel2.Controls.Add(Me.GroupBox2)
		Me.Panel2.Location = New System.Drawing.Point(278, 77)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(269, 176)
		Me.Panel2.TabIndex = 15
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel3.Controls.Add(Me.GroupBox4)
		Me.Panel3.Location = New System.Drawing.Point(278, 262)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(269, 146)
		Me.Panel3.TabIndex = 16
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(25, 9)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(538, 33)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Brandi's Bagel House"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
		Me.Panel4.Location = New System.Drawing.Point(25, 50)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(521, 5)
		Me.Panel4.TabIndex = 18
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(574, 469)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.btnReset)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Bagel and Coffee Price Calculator"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radWheat As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents radWhite As System.Windows.Forms.RadioButton
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents chkPeach As System.Windows.Forms.CheckBox
    Friend WithEvents chkRaspberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlueberry As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkCreamCheese As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radCafeAuLait As System.Windows.Forms.RadioButton
    Friend WithEvents radCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radRegCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents radNoCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents chkButter As System.Windows.Forms.CheckBox
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Panel4 As System.Windows.Forms.Panel

End Class
