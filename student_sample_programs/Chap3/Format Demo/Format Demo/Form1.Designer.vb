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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnNumber = New System.Windows.Forms.Button()
		Me.btnExponential = New System.Windows.Forms.Button()
		Me.btnLongTime = New System.Windows.Forms.Button()
		Me.btnShortTime = New System.Windows.Forms.Button()
		Me.btnLongDate = New System.Windows.Forms.Button()
		Me.btnShortDate = New System.Windows.Forms.Button()
		Me.btnFixedPoint = New System.Windows.Forms.Button()
		Me.btnPercent = New System.Windows.Forms.Button()
		Me.btnCurrency = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtValue = New System.Windows.Forms.TextBox()
		Me.lblFormatted = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.btnNumber)
		Me.GroupBox1.Controls.Add(Me.btnExponential)
		Me.GroupBox1.Controls.Add(Me.btnLongTime)
		Me.GroupBox1.Controls.Add(Me.btnShortTime)
		Me.GroupBox1.Controls.Add(Me.btnLongDate)
		Me.GroupBox1.Controls.Add(Me.btnShortDate)
		Me.GroupBox1.Controls.Add(Me.btnFixedPoint)
		Me.GroupBox1.Controls.Add(Me.btnPercent)
		Me.GroupBox1.Controls.Add(Me.btnCurrency)
		Me.GroupBox1.Location = New System.Drawing.Point(16, 124)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(490, 249)
		Me.GroupBox1.TabIndex = 17
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Select a Format"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(295, 197)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(177, 34)
		Me.Button1.TabIndex = 13
		Me.Button1.Text = "Full date / time ( F )"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.UseVisualStyleBackColor = True
		'
		'btnNumber
		'
		Me.btnNumber.Location = New System.Drawing.Point(28, 30)
		Me.btnNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnNumber.Name = "btnNumber"
		Me.btnNumber.Size = New System.Drawing.Size(236, 34)
		Me.btnNumber.TabIndex = 12
		Me.btnNumber.Text = "Number format ( n )"
		Me.btnNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnNumber.UseVisualStyleBackColor = True
		'
		'btnExponential
		'
		Me.btnExponential.Location = New System.Drawing.Point(28, 114)
		Me.btnExponential.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExponential.Name = "btnExponential"
		Me.btnExponential.Size = New System.Drawing.Size(236, 34)
		Me.btnExponential.TabIndex = 11
		Me.btnExponential.Text = "Exponential format ( e )"
		Me.btnExponential.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnExponential.UseVisualStyleBackColor = True
		'
		'btnLongTime
		'
		Me.btnLongTime.Location = New System.Drawing.Point(295, 156)
		Me.btnLongTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnLongTime.Name = "btnLongTime"
		Me.btnLongTime.Size = New System.Drawing.Size(177, 34)
		Me.btnLongTime.TabIndex = 10
		Me.btnLongTime.Text = "Long time ( T )"
		Me.btnLongTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLongTime.UseVisualStyleBackColor = True
		'
		'btnShortTime
		'
		Me.btnShortTime.Location = New System.Drawing.Point(295, 114)
		Me.btnShortTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnShortTime.Name = "btnShortTime"
		Me.btnShortTime.Size = New System.Drawing.Size(177, 34)
		Me.btnShortTime.TabIndex = 9
		Me.btnShortTime.Text = "Short time ( t )"
		Me.btnShortTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnShortTime.UseVisualStyleBackColor = True
		'
		'btnLongDate
		'
		Me.btnLongDate.Location = New System.Drawing.Point(295, 72)
		Me.btnLongDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnLongDate.Name = "btnLongDate"
		Me.btnLongDate.Size = New System.Drawing.Size(177, 34)
		Me.btnLongDate.TabIndex = 8
		Me.btnLongDate.Text = "Long date ( D )"
		Me.btnLongDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLongDate.UseVisualStyleBackColor = True
		'
		'btnShortDate
		'
		Me.btnShortDate.Location = New System.Drawing.Point(295, 30)
		Me.btnShortDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnShortDate.Name = "btnShortDate"
		Me.btnShortDate.Size = New System.Drawing.Size(177, 34)
		Me.btnShortDate.TabIndex = 7
		Me.btnShortDate.Text = "Short date ( d )"
		Me.btnShortDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnShortDate.UseVisualStyleBackColor = True
		'
		'btnFixedPoint
		'
		Me.btnFixedPoint.Location = New System.Drawing.Point(28, 72)
		Me.btnFixedPoint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnFixedPoint.Name = "btnFixedPoint"
		Me.btnFixedPoint.Size = New System.Drawing.Size(236, 34)
		Me.btnFixedPoint.TabIndex = 4
		Me.btnFixedPoint.Text = "Fixed-point format ( f )"
		Me.btnFixedPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnFixedPoint.UseVisualStyleBackColor = True
		'
		'btnPercent
		'
		Me.btnPercent.Location = New System.Drawing.Point(28, 197)
		Me.btnPercent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnPercent.Name = "btnPercent"
		Me.btnPercent.Size = New System.Drawing.Size(236, 34)
		Me.btnPercent.TabIndex = 6
		Me.btnPercent.Text = "Percent format ( p )"
		Me.btnPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPercent.UseVisualStyleBackColor = True
		'
		'btnCurrency
		'
		Me.btnCurrency.Location = New System.Drawing.Point(28, 156)
		Me.btnCurrency.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCurrency.Name = "btnCurrency"
		Me.btnCurrency.Size = New System.Drawing.Size(236, 34)
		Me.btnCurrency.TabIndex = 5
		Me.btnCurrency.Text = "Currency format ( c )"
		Me.btnCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnCurrency.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(50, 33)
		Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(146, 16)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Enter a number or date:"
		'
		'txtValue
		'
		Me.txtValue.Location = New System.Drawing.Point(206, 30)
		Me.txtValue.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
		Me.txtValue.Name = "txtValue"
		Me.txtValue.Size = New System.Drawing.Size(282, 22)
		Me.txtValue.TabIndex = 14
		'
		'lblFormatted
		'
		Me.lblFormatted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblFormatted.Location = New System.Drawing.Point(206, 73)
		Me.lblFormatted.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.lblFormatted.Name = "lblFormatted"
		Me.lblFormatted.Size = New System.Drawing.Size(282, 26)
		Me.lblFormatted.TabIndex = 16
		Me.lblFormatted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(124, 78)
		Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(72, 16)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Formatted:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(532, 390)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtValue)
		Me.Controls.Add(Me.lblFormatted)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Format Demo"
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNumber As System.Windows.Forms.Button
    Friend WithEvents btnExponential As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnFixedPoint As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
