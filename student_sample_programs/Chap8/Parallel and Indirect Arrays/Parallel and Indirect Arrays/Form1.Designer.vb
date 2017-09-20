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
		Me.btnParallel = New System.Windows.Forms.Button()
		Me.btnIndirect = New System.Windows.Forms.Button()
		Me.lstPeople = New System.Windows.Forms.ListBox()
		Me.lstShow = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnParallel
		'
		Me.btnParallel.Location = New System.Drawing.Point(14, 13)
		Me.btnParallel.Margin = New System.Windows.Forms.Padding(4)
		Me.btnParallel.Name = "btnParallel"
		Me.btnParallel.Size = New System.Drawing.Size(223, 30)
		Me.btnParallel.TabIndex = 0
		Me.btnParallel.Text = "Run Parallel Arrays Example"
		Me.btnParallel.UseVisualStyleBackColor = True
		'
		'btnIndirect
		'
		Me.btnIndirect.Location = New System.Drawing.Point(14, 51)
		Me.btnIndirect.Margin = New System.Windows.Forms.Padding(4)
		Me.btnIndirect.Name = "btnIndirect"
		Me.btnIndirect.Size = New System.Drawing.Size(223, 30)
		Me.btnIndirect.TabIndex = 1
		Me.btnIndirect.Text = "Run Indirect Arrays Example"
		Me.btnIndirect.UseVisualStyleBackColor = True
		'
		'lstPeople
		'
		Me.lstPeople.FormattingEnabled = True
		Me.lstPeople.ItemHeight = 16
		Me.lstPeople.Location = New System.Drawing.Point(270, 13)
		Me.lstPeople.Name = "lstPeople"
		Me.lstPeople.Size = New System.Drawing.Size(130, 68)
		Me.lstPeople.TabIndex = 2
		'
		'lstShow
		'
		Me.lstShow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
		  Or System.Windows.Forms.AnchorStyles.Left) _
		  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstShow.FormattingEnabled = True
		Me.lstShow.ItemHeight = 16
		Me.lstShow.Location = New System.Drawing.Point(14, 88)
		Me.lstShow.Name = "lstShow"
		Me.lstShow.Size = New System.Drawing.Size(432, 100)
		Me.lstShow.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(453, 194)
		Me.Controls.Add(Me.lstShow)
		Me.Controls.Add(Me.lstPeople)
		Me.Controls.Add(Me.btnIndirect)
		Me.Controls.Add(Me.btnParallel)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Parallel and Indirect Arrays"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnParallel As System.Windows.Forms.Button
	Friend WithEvents btnIndirect As System.Windows.Forms.Button
	Friend WithEvents lstPeople As System.Windows.Forms.ListBox
	Friend WithEvents lstShow As System.Windows.Forms.ListBox

End Class
