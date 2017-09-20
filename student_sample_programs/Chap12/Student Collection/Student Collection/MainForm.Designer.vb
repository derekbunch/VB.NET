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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTestAverage = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lstIdNumbers = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(57, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(38, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Add Student"
        '
        'lblTestAverage
        '
        Me.lblTestAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTestAverage.Location = New System.Drawing.Point(208, 128)
        Me.lblTestAverage.Name = "lblTestAverage"
        Me.lblTestAverage.Size = New System.Drawing.Size(40, 23)
        Me.lblTestAverage.TabIndex = 23
        Me.lblTestAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(174, 228)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(71, 23)
        Me.btnRemove.TabIndex = 13
        Me.btnRemove.Text = "&Remove"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdNumber.Location = New System.Drawing.Point(208, 96)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(144, 23)
        Me.lblIdNumber.TabIndex = 22
        '
        'lblFirstName
        '
        Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstName.Location = New System.Drawing.Point(208, 64)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(144, 23)
        Me.lblFirstName.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTestAverage)
        Me.GroupBox1.Controls.Add(Me.lblIdNumber)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblGrade)
        Me.GroupBox1.Controls.Add(Me.lstIdNumbers)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 200)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Students"
        '
        'lblLastName
        '
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Location = New System.Drawing.Point(208, 32)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(144, 23)
        Me.lblLastName.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(128, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Test grade:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(112, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Test average:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(128, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ID number:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(128, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "First name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(128, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Last name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(208, 160)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(40, 23)
        Me.lblGrade.TabIndex = 14
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstIdNumbers
        '
        Me.lstIdNumbers.Location = New System.Drawing.Point(8, 24)
        Me.lstIdNumbers.Name = "lstIdNumbers"
        Me.lstIdNumbers.Size = New System.Drawing.Size(96, 160)
        Me.lstIdNumbers.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 264)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Student Collection"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblTestAverage As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblIdNumber As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lstIdNumbers As System.Windows.Forms.ListBox

End Class
