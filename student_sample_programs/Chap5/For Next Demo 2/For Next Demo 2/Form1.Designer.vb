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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPropellerCap = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPropellerCap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPropellerCap
        '
        Me.picPropellerCap.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picPropellerCap.Image = CType(resources.GetObject("picPropellerCap.Image"), System.Drawing.Image)
        Me.picPropellerCap.Location = New System.Drawing.Point(12, 12)
        Me.picPropellerCap.Name = "picPropellerCap"
        Me.picPropellerCap.Size = New System.Drawing.Size(64, 50)
        Me.picPropellerCap.TabIndex = 8
        Me.picPropellerCap.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(117, 108)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(80, 30)
        Me.btnGo.TabIndex = 9
        Me.btnGo.Text = "&Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(203, 108)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 150)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picPropellerCap)
        Me.Name = "Form1"
        Me.Text = "For Next Demo 2"
        CType(Me.picPropellerCap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPropellerCap As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
