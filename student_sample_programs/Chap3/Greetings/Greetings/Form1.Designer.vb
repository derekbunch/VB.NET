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
        Me.btnShowGreeting = New System.Windows.Forms.Button()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(151, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        '
        'btnShowGreeting
        '
        Me.btnShowGreeting.Location = New System.Drawing.Point(63, 140)
        Me.btnShowGreeting.Name = "btnShowGreeting"
        Me.btnShowGreeting.Size = New System.Drawing.Size(75, 35)
        Me.btnShowGreeting.TabIndex = 18
        Me.btnShowGreeting.Text = "Show Greeting"
        '
        'lblGreeting
        '
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreeting.Location = New System.Drawing.Point(26, 95)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(240, 24)
        Me.lblGreeting.TabIndex = 17
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(58, 55)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(168, 20)
        Me.txtUserName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(90, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter Your Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 198)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowGreeting)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShowGreeting As System.Windows.Forms.Button
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
