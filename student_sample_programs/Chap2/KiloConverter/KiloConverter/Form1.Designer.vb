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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMiles = New System.Windows.Forms.Button()
        Me.btnYards = New System.Windows.Forms.Button()
        Me.btnFeet = New System.Windows.Forms.Button()
        Me.btnInches = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblMessage.Location = New System.Drawing.Point(13, 21)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(318, 33)
        Me.lblMessage.TabIndex = 17
        Me.lblMessage.Text = "1 Kilometer = ?"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(136, 120)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMiles
        '
        Me.btnMiles.Location = New System.Drawing.Point(256, 91)
        Me.btnMiles.Name = "btnMiles"
        Me.btnMiles.Size = New System.Drawing.Size(75, 23)
        Me.btnMiles.TabIndex = 15
        Me.btnMiles.Text = "Miles"
        Me.btnMiles.UseVisualStyleBackColor = True
        '
        'btnYards
        '
        Me.btnYards.Location = New System.Drawing.Point(175, 91)
        Me.btnYards.Name = "btnYards"
        Me.btnYards.Size = New System.Drawing.Size(75, 23)
        Me.btnYards.TabIndex = 14
        Me.btnYards.Text = "Yards"
        Me.btnYards.UseVisualStyleBackColor = True
        '
        'btnFeet
        '
        Me.btnFeet.Location = New System.Drawing.Point(94, 91)
        Me.btnFeet.Name = "btnFeet"
        Me.btnFeet.Size = New System.Drawing.Size(75, 23)
        Me.btnFeet.TabIndex = 13
        Me.btnFeet.Text = "Feet"
        Me.btnFeet.UseVisualStyleBackColor = True
        '
        'btnInches
        '
        Me.btnInches.Location = New System.Drawing.Point(13, 91)
        Me.btnInches.Name = "btnInches"
        Me.btnInches.Size = New System.Drawing.Size(75, 23)
        Me.btnInches.TabIndex = 12
        Me.btnInches.Text = "Inches"
        Me.btnInches.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 164)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMiles)
        Me.Controls.Add(Me.btnYards)
        Me.Controls.Add(Me.btnFeet)
        Me.Controls.Add(Me.btnInches)
        Me.Name = "Form1"
        Me.Text = "Kilometer Converter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMiles As System.Windows.Forms.Button
    Friend WithEvents btnYards As System.Windows.Forms.Button
    Friend WithEvents btnFeet As System.Windows.Forms.Button
    Friend WithEvents btnInches As System.Windows.Forms.Button

End Class
