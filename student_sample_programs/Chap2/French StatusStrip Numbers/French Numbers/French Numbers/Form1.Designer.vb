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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnFive = New System.Windows.Forms.Button()
		Me.btnFour = New System.Windows.Forms.Button()
		Me.btnThree = New System.Windows.Forms.Button()
		Me.btnTwo = New System.Windows.Forms.Button()
		Me.btnOne = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(9, 11)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(369, 67)
		Me.Label1.TabIndex = 27
		Me.Label1.Text = "Do you know the French words for the numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 through 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons bel" & _
	 "ow to see them."
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(164, 138)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(59, 28)
		Me.btnExit.TabIndex = 26
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnFive
		'
		Me.btnFive.Location = New System.Drawing.Point(294, 82)
		Me.btnFive.Margin = New System.Windows.Forms.Padding(4)
		Me.btnFive.Name = "btnFive"
		Me.btnFive.Size = New System.Drawing.Size(55, 28)
		Me.btnFive.TabIndex = 25
		Me.btnFive.Text = "5"
		Me.btnFive.UseVisualStyleBackColor = True
		'
		'btnFour
		'
		Me.btnFour.Location = New System.Drawing.Point(231, 82)
		Me.btnFour.Margin = New System.Windows.Forms.Padding(4)
		Me.btnFour.Name = "btnFour"
		Me.btnFour.Size = New System.Drawing.Size(55, 28)
		Me.btnFour.TabIndex = 24
		Me.btnFour.Text = "4"
		Me.btnFour.UseVisualStyleBackColor = True
		'
		'btnThree
		'
		Me.btnThree.Location = New System.Drawing.Point(168, 82)
		Me.btnThree.Margin = New System.Windows.Forms.Padding(4)
		Me.btnThree.Name = "btnThree"
		Me.btnThree.Size = New System.Drawing.Size(55, 28)
		Me.btnThree.TabIndex = 23
		Me.btnThree.Text = "3"
		Me.btnThree.UseVisualStyleBackColor = True
		'
		'btnTwo
		'
		Me.btnTwo.Location = New System.Drawing.Point(106, 82)
		Me.btnTwo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnTwo.Name = "btnTwo"
		Me.btnTwo.Size = New System.Drawing.Size(55, 28)
		Me.btnTwo.TabIndex = 22
		Me.btnTwo.Text = "2"
		Me.btnTwo.UseVisualStyleBackColor = True
		'
		'btnOne
		'
		Me.btnOne.Location = New System.Drawing.Point(43, 82)
		Me.btnOne.Margin = New System.Windows.Forms.Padding(4)
		Me.btnOne.Name = "btnOne"
		Me.btnOne.Size = New System.Drawing.Size(55, 28)
		Me.btnOne.TabIndex = 21
		Me.btnOne.Text = "1"
		Me.btnOne.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 189)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(391, 22)
		Me.StatusStrip1.TabIndex = 28
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(391, 211)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnFive)
		Me.Controls.Add(Me.btnFour)
		Me.Controls.Add(Me.btnThree)
		Me.Controls.Add(Me.btnTwo)
		Me.Controls.Add(Me.btnOne)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "French Numbers"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
	Friend WithEvents btnOne As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
