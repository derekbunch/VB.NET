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
        Me.btnSum = New System.Windows.Forms.Button()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(108, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(27, 168)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 33)
        Me.btnSum.TabIndex = 11
        Me.btnSum.Text = "Show &Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'lblSum
        '
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Location = New System.Drawing.Point(55, 127)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(100, 23)
        Me.lblSum.TabIndex = 15
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(55, 43)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 8
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(55, 69)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 9
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(55, 95)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(100, 20)
        Me.txtNum3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sum:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Enter 3 numbers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 214)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Find the Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
