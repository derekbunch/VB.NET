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
		Me.btnAndAlso = New System.Windows.Forms.Button()
		Me.btnAnd = New System.Windows.Forms.Button()
		Me.btnOrElse = New System.Windows.Forms.Button()
		Me.btnOr = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtValueA = New System.Windows.Forms.TextBox()
		Me.txtValueC = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtValueD = New System.Windows.Forms.TextBox()
		Me.txtValueB = New System.Windows.Forms.TextBox()
		Me.lstResult = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnAndAlso
		'
		Me.btnAndAlso.Location = New System.Drawing.Point(23, 244)
		Me.btnAndAlso.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAndAlso.Name = "btnAndAlso"
		Me.btnAndAlso.Size = New System.Drawing.Size(160, 28)
		Me.btnAndAlso.TabIndex = 16
		Me.btnAndAlso.Text = "AndAlso Operator"
		'
		'btnAnd
		'
		Me.btnAnd.Location = New System.Drawing.Point(23, 208)
		Me.btnAnd.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAnd.Name = "btnAnd"
		Me.btnAnd.Size = New System.Drawing.Size(160, 28)
		Me.btnAnd.TabIndex = 15
		Me.btnAnd.Text = "AND Operator"
		'
		'btnOrElse
		'
		Me.btnOrElse.Location = New System.Drawing.Point(23, 172)
		Me.btnOrElse.Margin = New System.Windows.Forms.Padding(4)
		Me.btnOrElse.Name = "btnOrElse"
		Me.btnOrElse.Size = New System.Drawing.Size(160, 28)
		Me.btnOrElse.TabIndex = 14
		Me.btnOrElse.Text = "OrElse Operator"
		'
		'btnOr
		'
		Me.btnOr.Location = New System.Drawing.Point(23, 136)
		Me.btnOr.Margin = New System.Windows.Forms.Padding(4)
		Me.btnOr.Name = "btnOr"
		Me.btnOr.Size = New System.Drawing.Size(160, 28)
		Me.btnOr.TabIndex = 12
		Me.btnOr.Text = "OR Operator"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(86, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 17)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Expression 1:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(86, 91)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(93, 17)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Expression 2:"
		'
		'txtValueA
		'
		Me.txtValueA.Location = New System.Drawing.Point(205, 26)
		Me.txtValueA.Name = "txtValueA"
		Me.txtValueA.Size = New System.Drawing.Size(41, 23)
		Me.txtValueA.TabIndex = 19
		Me.txtValueA.Text = "5"
		'
		'txtValueC
		'
		Me.txtValueC.Location = New System.Drawing.Point(205, 85)
		Me.txtValueC.Name = "txtValueC"
		Me.txtValueC.Size = New System.Drawing.Size(41, 23)
		Me.txtValueC.TabIndex = 20
		Me.txtValueC.Text = "7"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(252, 26)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(25, 25)
		Me.Label3.TabIndex = 21
		Me.Label3.Text = ">"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(252, 84)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(25, 25)
		Me.Label4.TabIndex = 22
		Me.Label4.Text = "<"
		'
		'txtValueD
		'
		Me.txtValueD.Location = New System.Drawing.Point(300, 85)
		Me.txtValueD.Name = "txtValueD"
		Me.txtValueD.Size = New System.Drawing.Size(41, 23)
		Me.txtValueD.TabIndex = 24
		Me.txtValueD.Text = "7"
		'
		'txtValueB
		'
		Me.txtValueB.Location = New System.Drawing.Point(300, 26)
		Me.txtValueB.Name = "txtValueB"
		Me.txtValueB.Size = New System.Drawing.Size(41, 23)
		Me.txtValueB.TabIndex = 23
		Me.txtValueB.Text = "4"
		'
		'lstResult
		'
		Me.lstResult.FormattingEnabled = True
		Me.lstResult.ItemHeight = 16
		Me.lstResult.Location = New System.Drawing.Point(212, 136)
		Me.lstResult.Name = "lstResult"
		Me.lstResult.Size = New System.Drawing.Size(198, 148)
		Me.lstResult.TabIndex = 25
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(489, 307)
		Me.Controls.Add(Me.lstResult)
		Me.Controls.Add(Me.txtValueD)
		Me.Controls.Add(Me.txtValueB)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtValueC)
		Me.Controls.Add(Me.txtValueA)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnAndAlso)
		Me.Controls.Add(Me.btnAnd)
		Me.Controls.Add(Me.btnOrElse)
		Me.Controls.Add(Me.btnOr)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Short Circuit Evaluation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnAndAlso As System.Windows.Forms.Button
	Friend WithEvents btnAnd As System.Windows.Forms.Button
	Friend WithEvents btnOrElse As System.Windows.Forms.Button
	Friend WithEvents btnOr As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtValueA As System.Windows.Forms.TextBox
	Friend WithEvents txtValueC As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtValueD As System.Windows.Forms.TextBox
	Friend WithEvents txtValueB As System.Windows.Forms.TextBox
	Friend WithEvents lstResult As System.Windows.Forms.ListBox

End Class
