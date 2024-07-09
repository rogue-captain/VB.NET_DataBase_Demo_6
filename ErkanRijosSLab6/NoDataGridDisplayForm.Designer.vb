<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoDataGridDisplayForm
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstLabel As System.Windows.Forms.Label
        Dim LastLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoDataGridDisplayForm))
        Me._Birthdays_2_DataSetATTEMPT2 = New ErkanRijosSLab6._Birthdays_2_DataSetATTEMPT2()
        Me.BirthdaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BirthdaysTableAdapter = New ErkanRijosSLab6._Birthdays_2_DataSetATTEMPT2TableAdapters.BirthdaysTableAdapter()
        Me.TableAdapterManager = New ErkanRijosSLab6._Birthdays_2_DataSetATTEMPT2TableAdapters.TableAdapterManager()
        Me.BirthdaysBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BirthdaysBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.dataGridViewBtn = New System.Windows.Forms.Button()
        Me.addSingleRecordBtn = New System.Windows.Forms.Button()
        Me.addAllRecordsBtn = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        FirstLabel = New System.Windows.Forms.Label()
        LastLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        CType(Me._Birthdays_2_DataSetATTEMPT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthdaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthdaysBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BirthdaysBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(130, 115)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'FirstLabel
        '
        FirstLabel.AutoSize = True
        FirstLabel.Location = New System.Drawing.Point(116, 161)
        FirstLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FirstLabel.Name = "FirstLabel"
        FirstLabel.Size = New System.Drawing.Size(39, 17)
        FirstLabel.TabIndex = 3
        FirstLabel.Text = "First:"
        '
        'LastLabel
        '
        LastLabel.AutoSize = True
        LastLabel.Location = New System.Drawing.Point(116, 202)
        LastLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LastLabel.Name = "LastLabel"
        LastLabel.Size = New System.Drawing.Size(39, 17)
        LastLabel.TabIndex = 5
        LastLabel.Text = "Last:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(91, 239)
        BirthdayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(64, 17)
        BirthdayLabel.TabIndex = 7
        BirthdayLabel.Text = "Birthday:"
        '
        '_Birthdays_2_DataSetATTEMPT2
        '
        Me._Birthdays_2_DataSetATTEMPT2.DataSetName = "_Birthdays_2_DataSetATTEMPT2"
        Me._Birthdays_2_DataSetATTEMPT2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BirthdaysBindingSource
        '
        Me.BirthdaysBindingSource.DataMember = "Birthdays"
        Me.BirthdaysBindingSource.DataSource = Me._Birthdays_2_DataSetATTEMPT2
        '
        'BirthdaysTableAdapter
        '
        Me.BirthdaysTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BirthdaysTableAdapter = Me.BirthdaysTableAdapter
        Me.TableAdapterManager.UpdateOrder = ErkanRijosSLab6._Birthdays_2_DataSetATTEMPT2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BirthdaysBindingNavigator
        '
        Me.BirthdaysBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BirthdaysBindingNavigator.BindingSource = Me.BirthdaysBindingSource
        Me.BirthdaysBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BirthdaysBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BirthdaysBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BirthdaysBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BirthdaysBindingNavigatorSaveItem})
        Me.BirthdaysBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BirthdaysBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BirthdaysBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BirthdaysBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BirthdaysBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BirthdaysBindingNavigator.Name = "BirthdaysBindingNavigator"
        Me.BirthdaysBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BirthdaysBindingNavigator.Size = New System.Drawing.Size(589, 27)
        Me.BirthdaysBindingNavigator.TabIndex = 0
        Me.BirthdaysBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BirthdaysBindingNavigatorSaveItem
        '
        Me.BirthdaysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BirthdaysBindingNavigatorSaveItem.Image = CType(resources.GetObject("BirthdaysBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BirthdaysBindingNavigatorSaveItem.Name = "BirthdaysBindingNavigatorSaveItem"
        Me.BirthdaysBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.BirthdaysBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdaysBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(188, 112)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'FirstTextBox
        '
        Me.FirstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdaysBindingSource, "First", True))
        Me.FirstTextBox.Location = New System.Drawing.Point(188, 153)
        Me.FirstTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(132, 22)
        Me.FirstTextBox.TabIndex = 4
        '
        'LastTextBox
        '
        Me.LastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BirthdaysBindingSource, "Last", True))
        Me.LastTextBox.Location = New System.Drawing.Point(188, 193)
        Me.LastTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LastTextBox.TabIndex = 6
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BirthdaysBindingSource, "Birthday", True))
        Me.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(188, 234)
        Me.BirthdayDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(132, 22)
        Me.BirthdayDateTimePicker.TabIndex = 8
        '
        'dataGridViewBtn
        '
        Me.dataGridViewBtn.Location = New System.Drawing.Point(413, 109)
        Me.dataGridViewBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridViewBtn.Name = "dataGridViewBtn"
        Me.dataGridViewBtn.Size = New System.Drawing.Size(133, 28)
        Me.dataGridViewBtn.TabIndex = 9
        Me.dataGridViewBtn.Text = "Data Grid View"
        Me.dataGridViewBtn.UseVisualStyleBackColor = True
        '
        'addSingleRecordBtn
        '
        Me.addSingleRecordBtn.Location = New System.Drawing.Point(413, 152)
        Me.addSingleRecordBtn.Name = "addSingleRecordBtn"
        Me.addSingleRecordBtn.Size = New System.Drawing.Size(133, 26)
        Me.addSingleRecordBtn.TabIndex = 10
        Me.addSingleRecordBtn.Text = "Add a Record"
        Me.addSingleRecordBtn.UseVisualStyleBackColor = True
        '
        'addAllRecordsBtn
        '
        Me.addAllRecordsBtn.Location = New System.Drawing.Point(413, 193)
        Me.addAllRecordsBtn.Name = "addAllRecordsBtn"
        Me.addAllRecordsBtn.Size = New System.Drawing.Size(133, 26)
        Me.addAllRecordsBtn.TabIndex = 11
        Me.addAllRecordsBtn.Text = "Add All Records"
        Me.addAllRecordsBtn.UseVisualStyleBackColor = True
        '
        'NoDataGridDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 356)
        Me.Controls.Add(Me.addAllRecordsBtn)
        Me.Controls.Add(Me.addSingleRecordBtn)
        Me.Controls.Add(Me.dataGridViewBtn)
        Me.Controls.Add(BirthdayLabel)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(LastLabel)
        Me.Controls.Add(Me.LastTextBox)
        Me.Controls.Add(FirstLabel)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.BirthdaysBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NoDataGridDisplayForm"
        Me.Text = "No Data Grid Display Form"
        CType(Me._Birthdays_2_DataSetATTEMPT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthdaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthdaysBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BirthdaysBindingNavigator.ResumeLayout(False)
        Me.BirthdaysBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Birthdays_2_DataSetATTEMPT2 As _Birthdays_2_DataSetATTEMPT2
    Friend WithEvents BirthdaysBindingSource As BindingSource
    Friend WithEvents BirthdaysTableAdapter As _Birthdays_2_DataSetATTEMPT2TableAdapters.BirthdaysTableAdapter
    Friend WithEvents TableAdapterManager As _Birthdays_2_DataSetATTEMPT2TableAdapters.TableAdapterManager
    Friend WithEvents BirthdaysBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BirthdaysBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents dataGridViewBtn As Button
    Friend WithEvents addSingleRecordBtn As Button
    Friend WithEvents addAllRecordsBtn As Button
End Class
