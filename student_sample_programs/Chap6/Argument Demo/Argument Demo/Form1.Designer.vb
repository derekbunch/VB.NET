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
		Me.btnDemo3 = New System.Windows.Forms.Button()
		Me.btnDemo2 = New System.Windows.Forms.Button()
		Me.btnDemo1 = New System.Windows.Forms.Button()
		Me.lstVals = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExit.Location = New System.Drawing.Point(19, 148)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnDemo3
		'
		Me.btnDemo3.Location = New System.Drawing.Point(19, 98)
		Me.btnDemo3.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDemo3.Name = "btnDemo3"
		Me.btnDemo3.Size = New System.Drawing.Size(100, 28)
		Me.btnDemo3.TabIndex = 2
		Me.btnDemo3.Text = "Demo &3"
		Me.btnDemo3.UseVisualStyleBackColor = True
		'
		'btnDemo2
		'
		Me.btnDemo2.Location = New System.Drawing.Point(19, 62)
		Me.btnDemo2.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDemo2.Name = "btnDemo2"
		Me.btnDemo2.Size = New System.Drawing.Size(100, 28)
		Me.btnDemo2.TabIndex = 1
		Me.btnDemo2.Text = "Demo &2"
		Me.btnDemo2.UseVisualStyleBackColor = True
		'
		'btnDemo1
		'
		Me.btnDemo1.Location = New System.Drawing.Point(19, 26)
		Me.btnDemo1.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDemo1.Name = "btnDemo1"
		Me.btnDemo1.Size = New System.Drawing.Size(100, 28)
		Me.btnDemo1.TabIndex = 0
		Me.btnDemo1.Text = "Demo &1"
		Me.btnDemo1.UseVisualStyleBackColor = True
		'
		'lstVals
		'
		Me.lstVals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lstVals.FormattingEnabled = True
		Me.lstVals.ItemHeight = 16
		Me.lstVals.Location = New System.Drawing.Point(150, 12)
		Me.lstVals.Name = "lstVals"
		Me.lstVals.Size = New System.Drawing.Size(99, 164)
		Me.lstVals.TabIndex = 4
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(264, 196)
		Me.Controls.Add(Me.lstVals)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnDemo3)
		Me.Controls.Add(Me.btnDemo2)
		Me.Controls.Add(Me.btnDemo1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Argument Demo"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDemo3 As System.Windows.Forms.Button
    Friend WithEvents btnDemo2 As System.Windows.Forms.Button
	Friend WithEvents btnDemo1 As System.Windows.Forms.Button
	Friend WithEvents lstVals As System.Windows.Forms.ListBox

End Class
