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
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnShowName = New System.Windows.Forms.Button()
		Me.lblFullName = New System.Windows.Forms.Label()
		Me.txtLastName = New System.Windows.Forms.TextBox()
		Me.txtFirstName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(277, 184)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 35
		Me.btnExit.Text = "E&xit"
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(160, 184)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(100, 28)
		Me.btnClear.TabIndex = 34
		Me.btnClear.Text = "&Clear"
		'
		'btnShowName
		'
		Me.btnShowName.Location = New System.Drawing.Point(43, 184)
		Me.btnShowName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnShowName.Name = "btnShowName"
		Me.btnShowName.Size = New System.Drawing.Size(100, 28)
		Me.btnShowName.TabIndex = 33
		Me.btnShowName.Text = "Show &Name"
		'
		'lblFullName
		'
		Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblFullName.Location = New System.Drawing.Point(167, 122)
		Me.lblFullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFullName.Name = "lblFullName"
		Me.lblFullName.Size = New System.Drawing.Size(235, 28)
		Me.lblFullName.TabIndex = 32
		'
		'txtLastName
		'
		Me.txtLastName.Location = New System.Drawing.Point(167, 63)
		Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(169, 22)
		Me.txtLastName.TabIndex = 31
		'
		'txtFirstName
		'
		Me.txtFirstName.Location = New System.Drawing.Point(167, 24)
		Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(169, 22)
		Me.txtFirstName.TabIndex = 30
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(19, 122)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(137, 28)
		Me.Label3.TabIndex = 29
		Me.Label3.Text = "This is your full name:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(16, 63)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(140, 28)
		Me.Label2.TabIndex = 28
		Me.Label2.Text = "Enter your last name:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(13, 24)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 28)
		Me.Label1.TabIndex = 27
		Me.Label1.Text = "Enter your first name:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(416, 234)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnShowName)
		Me.Controls.Add(Me.lblFullName)
		Me.Controls.Add(Me.txtLastName)
		Me.Controls.Add(Me.txtFirstName)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Variable Demo"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnShowName As System.Windows.Forms.Button
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
