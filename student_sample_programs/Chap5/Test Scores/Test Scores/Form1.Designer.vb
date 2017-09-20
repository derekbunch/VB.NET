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
		Me.lblAverage = New System.Windows.Forms.Label()
		Me.btnGetScores = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(36, 41)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Test Average:"
		'
		'lblAverage
		'
		Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAverage.Location = New System.Drawing.Point(137, 35)
		Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblAverage.Name = "lblAverage"
		Me.lblAverage.Size = New System.Drawing.Size(100, 28)
		Me.lblAverage.TabIndex = 1
		Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnGetScores
		'
		Me.btnGetScores.Location = New System.Drawing.Point(39, 89)
		Me.btnGetScores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnGetScores.Name = "btnGetScores"
		Me.btnGetScores.Size = New System.Drawing.Size(110, 37)
		Me.btnGetScores.TabIndex = 2
		Me.btnGetScores.Text = "&Get Scores"
		Me.btnGetScores.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(175, 89)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(87, 37)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(290, 146)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnGetScores)
		Me.Controls.Add(Me.lblAverage)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Test Score Average"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents btnGetScores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
