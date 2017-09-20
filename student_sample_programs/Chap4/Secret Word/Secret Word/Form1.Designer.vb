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
		Me.txtInput = New System.Windows.Forms.TextBox()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(39, 20)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(135, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Enter the secret word:"
		'
		'txtInput
		'
		Me.txtInput.Location = New System.Drawing.Point(182, 14)
		Me.txtInput.Margin = New System.Windows.Forms.Padding(4)
		Me.txtInput.Name = "txtInput"
		Me.txtInput.Size = New System.Drawing.Size(149, 22)
		Me.txtInput.TabIndex = 1
		'
		'lblMessage
		'
		Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
		Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMessage.Location = New System.Drawing.Point(23, 63)
		Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMessage.Size = New System.Drawing.Size(308, 41)
		Me.lblMessage.TabIndex = 4
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(79, 122)
		Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(100, 28)
		Me.btnOk.TabIndex = 2
		Me.btnOk.Text = "&Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(187, 122)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
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
		Me.ClientSize = New System.Drawing.Size(347, 165)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.txtInput)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Secret Word"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Public WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
