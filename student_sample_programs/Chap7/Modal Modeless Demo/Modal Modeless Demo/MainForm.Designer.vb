<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnShowModal = New System.Windows.Forms.Button()
        Me.btnShowModeless = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(16, 15)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(239, 184)
        Me.lstOutput.TabIndex = 0
        '
        'btnShowModal
        '
        Me.btnShowModal.Location = New System.Drawing.Point(279, 15)
        Me.btnShowModal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowModal.Name = "btnShowModal"
        Me.btnShowModal.Size = New System.Drawing.Size(120, 49)
        Me.btnShowModal.TabIndex = 1
        Me.btnShowModal.Text = "&Show a Modal Form"
        Me.btnShowModal.UseVisualStyleBackColor = True
        '
        'btnShowModeless
        '
        Me.btnShowModeless.Location = New System.Drawing.Point(279, 71)
        Me.btnShowModeless.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowModeless.Name = "btnShowModeless"
        Me.btnShowModeless.Size = New System.Drawing.Size(120, 49)
        Me.btnShowModeless.TabIndex = 2
        Me.btnShowModeless.Text = "Show a &Modeless Form"
        Me.btnShowModeless.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(279, 128)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 37)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear List Box"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(279, 175)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 226)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowModeless)
        Me.Controls.Add(Me.btnShowModal)
        Me.Controls.Add(Me.lstOutput)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Modal Modeless Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnShowModal As System.Windows.Forms.Button
    Friend WithEvents btnShowModeless As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
