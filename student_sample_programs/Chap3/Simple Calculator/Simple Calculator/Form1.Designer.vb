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
		Me.btnMod = New System.Windows.Forms.Button()
		Me.btnIntegerDivide = New System.Windows.Forms.Button()
		Me.btnDivide = New System.Windows.Forms.Button()
		Me.btnExponent = New System.Windows.Forms.Button()
		Me.btnMultiply = New System.Windows.Forms.Button()
		Me.btnMinus = New System.Windows.Forms.Button()
		Me.btnPlus = New System.Windows.Forms.Button()
		Me.lblOperation = New System.Windows.Forms.Label()
		Me.lblResult = New System.Windows.Forms.Label()
		Me.txtNumber2 = New System.Windows.Forms.TextBox()
		Me.txtNumber1 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(299, 187)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(107, 28)
		Me.btnExit.TabIndex = 50
		Me.btnExit.Text = "Exit"
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(299, 148)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(107, 28)
		Me.btnClear.TabIndex = 49
		Me.btnClear.Text = "Clear"
		'
		'btnMod
		'
		Me.btnMod.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMod.Location = New System.Drawing.Point(320, 98)
		Me.btnMod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnMod.Name = "btnMod"
		Me.btnMod.Size = New System.Drawing.Size(64, 31)
		Me.btnMod.TabIndex = 48
		Me.btnMod.Text = "MOD"
		'
		'btnIntegerDivide
		'
		Me.btnIntegerDivide.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnIntegerDivide.Location = New System.Drawing.Point(384, 59)
		Me.btnIntegerDivide.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnIntegerDivide.Name = "btnIntegerDivide"
		Me.btnIntegerDivide.Size = New System.Drawing.Size(43, 31)
		Me.btnIntegerDivide.TabIndex = 47
		Me.btnIntegerDivide.Text = "\"
		'
		'btnDivide
		'
		Me.btnDivide.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDivide.Location = New System.Drawing.Point(331, 59)
		Me.btnDivide.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnDivide.Name = "btnDivide"
		Me.btnDivide.Size = New System.Drawing.Size(43, 31)
		Me.btnDivide.TabIndex = 46
		Me.btnDivide.Text = "/"
		'
		'btnExponent
		'
		Me.btnExponent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExponent.Location = New System.Drawing.Point(277, 59)
		Me.btnExponent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExponent.Name = "btnExponent"
		Me.btnExponent.Size = New System.Drawing.Size(43, 31)
		Me.btnExponent.TabIndex = 45
		Me.btnExponent.Text = "^"
		'
		'btnMultiply
		'
		Me.btnMultiply.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMultiply.Location = New System.Drawing.Point(384, 20)
		Me.btnMultiply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnMultiply.Name = "btnMultiply"
		Me.btnMultiply.Size = New System.Drawing.Size(43, 31)
		Me.btnMultiply.TabIndex = 44
		Me.btnMultiply.Text = "*"
		'
		'btnMinus
		'
		Me.btnMinus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMinus.Location = New System.Drawing.Point(331, 20)
		Me.btnMinus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnMinus.Name = "btnMinus"
		Me.btnMinus.Size = New System.Drawing.Size(43, 31)
		Me.btnMinus.TabIndex = 43
		Me.btnMinus.Text = "-"
		'
		'btnPlus
		'
		Me.btnPlus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPlus.Location = New System.Drawing.Point(277, 20)
		Me.btnPlus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnPlus.Name = "btnPlus"
		Me.btnPlus.Size = New System.Drawing.Size(43, 31)
		Me.btnPlus.TabIndex = 42
		Me.btnPlus.Text = "+"
		'
		'lblOperation
		'
		Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOperation.Location = New System.Drawing.Point(117, 68)
		Me.lblOperation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblOperation.Name = "lblOperation"
		Me.lblOperation.Size = New System.Drawing.Size(128, 39)
		Me.lblOperation.TabIndex = 41
		Me.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblResult
		'
		Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResult.Location = New System.Drawing.Point(117, 197)
		Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(128, 28)
		Me.lblResult.TabIndex = 40
		Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtNumber2
		'
		Me.txtNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumber2.Location = New System.Drawing.Point(117, 141)
		Me.txtNumber2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtNumber2.Name = "txtNumber2"
		Me.txtNumber2.Size = New System.Drawing.Size(127, 21)
		Me.txtNumber2.TabIndex = 39
		'
		'txtNumber1
		'
		Me.txtNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumber1.Location = New System.Drawing.Point(117, 24)
		Me.txtNumber1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtNumber1.Name = "txtNumber1"
		Me.txtNumber1.Size = New System.Drawing.Size(127, 21)
		Me.txtNumber1.TabIndex = 38
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(21, 197)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(85, 28)
		Me.Label4.TabIndex = 37
		Me.Label4.Text = "Result:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(21, 138)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(85, 28)
		Me.Label3.TabIndex = 36
		Me.Label3.Text = "Number 2:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(21, 79)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(85, 28)
		Me.Label2.TabIndex = 35
		Me.Label2.Text = "Operation:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(21, 20)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(85, 28)
		Me.Label1.TabIndex = 34
		Me.Label1.Text = "Number 1:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(448, 244)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnMod)
		Me.Controls.Add(Me.btnIntegerDivide)
		Me.Controls.Add(Me.btnDivide)
		Me.Controls.Add(Me.btnExponent)
		Me.Controls.Add(Me.btnMultiply)
		Me.Controls.Add(Me.btnMinus)
		Me.Controls.Add(Me.btnPlus)
		Me.Controls.Add(Me.lblOperation)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.txtNumber2)
		Me.Controls.Add(Me.txtNumber1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Simple Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnIntegerDivide As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnExponent As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
