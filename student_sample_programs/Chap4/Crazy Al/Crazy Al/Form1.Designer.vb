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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblCommissionRate = New System.Windows.Forms.Label()
		Me.lblCommissionAmount = New System.Windows.Forms.Label()
		Me.lblNetPay = New System.Windows.Forms.Label()
		Me.txtAdvancePayAmount = New System.Windows.Forms.TextBox()
		Me.txtSalesAmount = New System.Windows.Forms.TextBox()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(75, 36)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(135, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Sales for the month:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(54, 73)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(152, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Advance pay awarded:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(89, 122)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(121, 17)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Commission Rate:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(123, 162)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(87, 17)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Commission:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(146, 203)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(62, 17)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Net Pay:"
		'
		'lblCommissionRate
		'
		Me.lblCommissionRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCommissionRate.Location = New System.Drawing.Point(218, 116)
		Me.lblCommissionRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCommissionRate.Name = "lblCommissionRate"
		Me.lblCommissionRate.Size = New System.Drawing.Size(133, 28)
		Me.lblCommissionRate.TabIndex = 8
		Me.lblCommissionRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblCommissionAmount
		'
		Me.lblCommissionAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCommissionAmount.Location = New System.Drawing.Point(218, 156)
		Me.lblCommissionAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCommissionAmount.Name = "lblCommissionAmount"
		Me.lblCommissionAmount.Size = New System.Drawing.Size(133, 28)
		Me.lblCommissionAmount.TabIndex = 10
		Me.lblCommissionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblNetPay
		'
		Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNetPay.Location = New System.Drawing.Point(218, 197)
		Me.lblNetPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNetPay.Name = "lblNetPay"
		Me.lblNetPay.Size = New System.Drawing.Size(133, 28)
		Me.lblNetPay.TabIndex = 12
		Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtAdvancePayAmount
		'
		Me.txtAdvancePayAmount.Location = New System.Drawing.Point(218, 68)
		Me.txtAdvancePayAmount.Margin = New System.Windows.Forms.Padding(4)
		Me.txtAdvancePayAmount.Name = "txtAdvancePayAmount"
		Me.txtAdvancePayAmount.Size = New System.Drawing.Size(132, 23)
		Me.txtAdvancePayAmount.TabIndex = 3
		'
		'txtSalesAmount
		'
		Me.txtSalesAmount.Location = New System.Drawing.Point(218, 31)
		Me.txtSalesAmount.Margin = New System.Windows.Forms.Padding(4)
		Me.txtSalesAmount.Name = "txtSalesAmount"
		Me.txtSalesAmount.Size = New System.Drawing.Size(132, 23)
		Me.txtSalesAmount.TabIndex = 1
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(31, 256)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(100, 28)
		Me.btnCalculate.TabIndex = 4
		Me.btnCalculate.Text = "&Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(171, 256)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(100, 28)
		Me.btnClear.TabIndex = 5
		Me.btnClear.Text = "Cl&ear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(290, 256)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 6
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 306)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(430, 22)
		Me.StatusStrip1.TabIndex = 13
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(430, 328)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.txtSalesAmount)
		Me.Controls.Add(Me.txtAdvancePayAmount)
		Me.Controls.Add(Me.lblNetPay)
		Me.Controls.Add(Me.lblCommissionAmount)
		Me.Controls.Add(Me.lblCommissionRate)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Crazy Al's Commission Calculator"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCommissionRate As System.Windows.Forms.Label
    Friend WithEvents lblCommissionAmount As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents txtAdvancePayAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
