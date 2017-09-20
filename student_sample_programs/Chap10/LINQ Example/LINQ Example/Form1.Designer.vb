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
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnSortAcending = New System.Windows.Forms.Button()
        Me.btnExecuteQuery = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplayValues = New System.Windows.Forms.Button()
        Me.btnSortDecending = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(16, 11)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(120, 212)
        Me.lstResults.TabIndex = 5
        '
        'btnSortAcending
        '
        Me.btnSortAcending.Location = New System.Drawing.Point(142, 100)
        Me.btnSortAcending.Name = "btnSortAcending"
        Me.btnSortAcending.Size = New System.Drawing.Size(86, 37)
        Me.btnSortAcending.TabIndex = 2
        Me.btnSortAcending.Text = "Sort &Ascending"
        Me.btnSortAcending.UseVisualStyleBackColor = True
        '
        'btnExecuteQuery
        '
        Me.btnExecuteQuery.Location = New System.Drawing.Point(142, 57)
        Me.btnExecuteQuery.Name = "btnExecuteQuery"
        Me.btnExecuteQuery.Size = New System.Drawing.Size(86, 37)
        Me.btnExecuteQuery.TabIndex = 1
        Me.btnExecuteQuery.Text = "Execute &Query"
        Me.btnExecuteQuery.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(142, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDisplayValues
        '
        Me.btnDisplayValues.Location = New System.Drawing.Point(142, 11)
        Me.btnDisplayValues.Name = "btnDisplayValues"
        Me.btnDisplayValues.Size = New System.Drawing.Size(86, 37)
        Me.btnDisplayValues.TabIndex = 0
        Me.btnDisplayValues.Text = "&Display Values"
        Me.btnDisplayValues.UseVisualStyleBackColor = True
        '
        'btnSortDecending
        '
        Me.btnSortDecending.Location = New System.Drawing.Point(142, 143)
        Me.btnSortDecending.Name = "btnSortDecending"
        Me.btnSortDecending.Size = New System.Drawing.Size(86, 37)
        Me.btnSortDecending.TabIndex = 3
        Me.btnSortDecending.Text = "Sort &Decending"
        Me.btnSortDecending.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 234)
        Me.Controls.Add(Me.btnDisplayValues)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExecuteQuery)
        Me.Controls.Add(Me.btnSortDecending)
        Me.Controls.Add(Me.btnSortAcending)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "Form1"
        Me.Text = "LINQ Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents btnSortAcending As System.Windows.Forms.Button
    Friend WithEvents btnExecuteQuery As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDisplayValues As System.Windows.Forms.Button
    Friend WithEvents btnSortDecending As System.Windows.Forms.Button

End Class
