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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Full_TimeLabel As System.Windows.Forms.Label
        Dim Hire_DateLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Me.SalesStaffDataSet = New Binding_Example.SalesStaffDataSet()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesStaffTableAdapter = New Binding_Example.SalesStaffDataSetTableAdapters.SalesStaffTableAdapter()
        Me.TableAdapterManager = New Binding_Example.SalesStaffDataSetTableAdapters.TableAdapterManager()
        Me.SalesStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesStaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Full_TimeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Hire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Full_TimeLabel = New System.Windows.Forms.Label()
        Hire_DateLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        CType(Me.SalesStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesStaffBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesStaffDataSet
        '
        Me.SalesStaffDataSet.DataSetName = "SalesStaffDataSet"
        Me.SalesStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.SalesStaffDataSet
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesStaffTableAdapter = Me.SalesStaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = Binding_Example.SalesStaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesStaffBindingNavigator
        '
        Me.SalesStaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesStaffBindingNavigator.BindingSource = Me.SalesStaffBindingSource
        Me.SalesStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesStaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesStaffBindingNavigatorSaveItem})
        Me.SalesStaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesStaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesStaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesStaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesStaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesStaffBindingNavigator.Name = "SalesStaffBindingNavigator"
        Me.SalesStaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesStaffBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.SalesStaffBindingNavigator.TabIndex = 0
        Me.SalesStaffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SalesStaffBindingNavigatorSaveItem
        '
        Me.SalesStaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesStaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesStaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesStaffBindingNavigatorSaveItem.Name = "SalesStaffBindingNavigatorSaveItem"
        Me.SalesStaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesStaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(97, 45)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDLabel1
        '
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(124, 40)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(50, 23)
        Me.IDLabel1.TabIndex = 2
        Me.IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(57, 69)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(124, 66)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(58, 95)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(124, 92)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 6
        '
        'Full_TimeLabel
        '
        Full_TimeLabel.AutoSize = True
        Full_TimeLabel.Location = New System.Drawing.Point(66, 123)
        Full_TimeLabel.Name = "Full_TimeLabel"
        Full_TimeLabel.Size = New System.Drawing.Size(52, 13)
        Full_TimeLabel.TabIndex = 7
        Full_TimeLabel.Text = "Full Time:"
        '
        'Full_TimeCheckBox
        '
        Me.Full_TimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesStaffBindingSource, "Full_Time", True))
        Me.Full_TimeCheckBox.Location = New System.Drawing.Point(124, 118)
        Me.Full_TimeCheckBox.Name = "Full_TimeCheckBox"
        Me.Full_TimeCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Full_TimeCheckBox.TabIndex = 8
        Me.Full_TimeCheckBox.UseVisualStyleBackColor = True
        '
        'Hire_DateLabel
        '
        Hire_DateLabel.AutoSize = True
        Hire_DateLabel.Location = New System.Drawing.Point(63, 152)
        Hire_DateLabel.Name = "Hire_DateLabel"
        Hire_DateLabel.Size = New System.Drawing.Size(55, 13)
        Hire_DateLabel.TabIndex = 9
        Hire_DateLabel.Text = "Hire Date:"
        '
        'Hire_DateDateTimePicker
        '
        Me.Hire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesStaffBindingSource, "Hire_Date", True))
        Me.Hire_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Hire_DateDateTimePicker.Location = New System.Drawing.Point(124, 148)
        Me.Hire_DateDateTimePicker.Name = "Hire_DateDateTimePicker"
        Me.Hire_DateDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.Hire_DateDateTimePicker.TabIndex = 10
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(79, 177)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(39, 13)
        SalaryLabel.TabIndex = 11
        SalaryLabel.Text = "Salary:"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(124, 174)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTextBox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 214)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Hire_DateLabel)
        Me.Controls.Add(Me.Hire_DateDateTimePicker)
        Me.Controls.Add(Full_TimeLabel)
        Me.Controls.Add(Me.Full_TimeCheckBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Me.SalesStaffBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "SalesStaff Binding Example"
        CType(Me.SalesStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesStaffBindingNavigator.ResumeLayout(False)
        Me.SalesStaffBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalesStaffDataSet As Binding_Example.SalesStaffDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As Binding_Example.SalesStaffDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents TableAdapterManager As Binding_Example.SalesStaffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesStaffBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalesStaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_TimeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Hire_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox

End Class
