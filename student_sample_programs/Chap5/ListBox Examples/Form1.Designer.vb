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
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.ListBox2 = New System.Windows.Forms.ListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ListBox3 = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(20, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Dogs"
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.ItemHeight = 16
		Me.ListBox1.Items.AddRange(New Object() {"Poodle", "Great Dane", "German Shepherd", "Terrier"})
		Me.ListBox1.Location = New System.Drawing.Point(23, 52)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(141, 68)
		Me.ListBox1.TabIndex = 1
		'
		'ListBox2
		'
		Me.ListBox2.FormattingEnabled = True
		Me.ListBox2.ItemHeight = 16
		Me.ListBox2.Items.AddRange(New Object() {"Siamese", "Persian", "Bobtail", "Burmese", "Mongolian"})
		Me.ListBox2.Location = New System.Drawing.Point(192, 52)
		Me.ListBox2.Name = "ListBox2"
		Me.ListBox2.Size = New System.Drawing.Size(120, 68)
		Me.ListBox2.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(189, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(36, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Cats"
		'
		'ListBox3
		'
		Me.ListBox3.FormattingEnabled = True
		Me.ListBox3.ItemHeight = 16
		Me.ListBox3.Location = New System.Drawing.Point(34, 171)
		Me.ListBox3.Name = "ListBox3"
		Me.ListBox3.Size = New System.Drawing.Size(120, 84)
		Me.ListBox3.TabIndex = 4
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(515, 316)
		Me.Controls.Add(Me.ListBox3)
		Me.Controls.Add(Me.ListBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "List Box Examples"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
	Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents ListBox3 As System.Windows.Forms.ListBox

End Class
