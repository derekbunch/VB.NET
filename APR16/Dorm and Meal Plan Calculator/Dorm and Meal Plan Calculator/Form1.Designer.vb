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
        Me.lstDorms = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMeals = New System.Windows.Forms.Label()
        Me.lblDorm = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDorm = New System.Windows.Forms.Button()
        Me.btnMeals = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstDorms)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(128, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Dormitory"
        '
        'lstDorms
        '
        Me.lstDorms.FormattingEnabled = True
        Me.lstDorms.Items.AddRange(New Object() {"Allen Hall", "Pike Hall", "Farthing Hall", "University Suites"})
        Me.lstDorms.Location = New System.Drawing.Point(5, 18)
        Me.lstDorms.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstDorms.Name = "lstDorms"
        Me.lstDorms.Size = New System.Drawing.Size(109, 69)
        Me.lstDorms.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblMeals)
        Me.GroupBox2.Controls.Add(Me.lblDorm)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(150, 104)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges for the Semester"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(66, 72)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 19)
        Me.lblTotal.TabIndex = 5
        '
        'lblMeals
        '
        Me.lblMeals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMeals.Location = New System.Drawing.Point(66, 50)
        Me.lblMeals.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMeals.Name = "lblMeals"
        Me.lblMeals.Size = New System.Drawing.Size(75, 19)
        Me.lblMeals.TabIndex = 4
        '
        'lblDorm
        '
        Me.lblDorm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDorm.Location = New System.Drawing.Point(66, 28)
        Me.lblDorm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDorm.Name = "lblDorm"
        Me.lblDorm.Size = New System.Drawing.Size(75, 19)
        Me.lblDorm.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meal Plan:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dormitory:"
        '
        'btnDorm
        '
        Me.btnDorm.Location = New System.Drawing.Point(15, 132)
        Me.btnDorm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDorm.Name = "btnDorm"
        Me.btnDorm.Size = New System.Drawing.Size(70, 38)
        Me.btnDorm.TabIndex = 2
        Me.btnDorm.Text = "Add Dormitory"
        Me.btnDorm.UseVisualStyleBackColor = True
        '
        'btnMeals
        '
        Me.btnMeals.Location = New System.Drawing.Point(90, 132)
        Me.btnMeals.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMeals.Name = "btnMeals"
        Me.btnMeals.Size = New System.Drawing.Size(64, 38)
        Me.btnMeals.TabIndex = 3
        Me.btnMeals.Text = "View Meal Plans"
        Me.btnMeals.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(160, 132)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 38)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(230, 132)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 181)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnMeals)
        Me.Controls.Add(Me.btnDorm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Dorm and Meal Plan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstDorms As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMeals As System.Windows.Forms.Label
    Friend WithEvents lblDorm As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDorm As System.Windows.Forms.Button
    Friend WithEvents btnMeals As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
