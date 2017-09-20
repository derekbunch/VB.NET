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
		Me.btnEnterSales = New System.Windows.Forms.Button()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(165, 74)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(89, 37)
		Me.btnExit.TabIndex = 7
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnEnterSales
		'
		Me.btnEnterSales.Location = New System.Drawing.Point(35, 74)
		Me.btnEnterSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnEnterSales.Name = "btnEnterSales"
		Me.btnEnterSales.Size = New System.Drawing.Size(107, 37)
		Me.btnEnterSales.TabIndex = 6
		Me.btnEnterSales.Text = "&Enter Sales"
		Me.btnEnterSales.UseVisualStyleBackColor = True
		'
		'lblTotal
		'
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotal.Location = New System.Drawing.Point(121, 27)
		Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(133, 28)
		Me.lblTotal.TabIndex = 5
		Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(32, 33)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 16)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Total Sales:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(285, 140)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnEnterSales)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Total Sales"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnterSales As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
