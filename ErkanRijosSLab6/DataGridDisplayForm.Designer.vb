<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridDisplayForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataGridDisplayForm))
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
        Me.BirthdaysDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.standardDataViewBtn = New System.Windows.Forms.Button()
        Me.addRecordBtn = New System.Windows.Forms.Button()
        Me.addAllRecordsBtn = New System.Windows.Forms.Button()
        CType(Me._Birthdays_2_DataSetATTEMPT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthdaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthdaysBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BirthdaysBindingNavigator.SuspendLayout()
        CType(Me.BirthdaysDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BirthdaysBindingNavigator.Size = New System.Drawing.Size(1067, 27)
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
        'BirthdaysDataGridView
        '
        Me.BirthdaysDataGridView.AutoGenerateColumns = False
        Me.BirthdaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BirthdaysDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.BirthdaysDataGridView.DataSource = Me.BirthdaysBindingSource
        Me.BirthdaysDataGridView.Location = New System.Drawing.Point(16, 47)
        Me.BirthdaysDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BirthdaysDataGridView.Name = "BirthdaysDataGridView"
        Me.BirthdaysDataGridView.RowHeadersWidth = 51
        Me.BirthdaysDataGridView.Size = New System.Drawing.Size(612, 492)
        Me.BirthdaysDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Birthday"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Birthday"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'standardDataViewBtn
        '
        Me.standardDataViewBtn.Location = New System.Drawing.Point(753, 47)
        Me.standardDataViewBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.standardDataViewBtn.Name = "standardDataViewBtn"
        Me.standardDataViewBtn.Size = New System.Drawing.Size(176, 28)
        Me.standardDataViewBtn.TabIndex = 2
        Me.standardDataViewBtn.Text = "Standard Data View"
        Me.standardDataViewBtn.UseVisualStyleBackColor = True
        '
        'addRecordBtn
        '
        Me.addRecordBtn.Location = New System.Drawing.Point(753, 121)
        Me.addRecordBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addRecordBtn.Name = "addRecordBtn"
        Me.addRecordBtn.Size = New System.Drawing.Size(176, 28)
        Me.addRecordBtn.TabIndex = 3
        Me.addRecordBtn.Text = "Add a record"
        Me.addRecordBtn.UseVisualStyleBackColor = True
        '
        'addAllRecordsBtn
        '
        Me.addAllRecordsBtn.Location = New System.Drawing.Point(753, 194)
        Me.addAllRecordsBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addAllRecordsBtn.Name = "addAllRecordsBtn"
        Me.addAllRecordsBtn.Size = New System.Drawing.Size(176, 28)
        Me.addAllRecordsBtn.TabIndex = 4
        Me.addAllRecordsBtn.Text = "Add All Records"
        Me.addAllRecordsBtn.UseVisualStyleBackColor = True
        '
        'DataGridDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.addAllRecordsBtn)
        Me.Controls.Add(Me.addRecordBtn)
        Me.Controls.Add(Me.standardDataViewBtn)
        Me.Controls.Add(Me.BirthdaysDataGridView)
        Me.Controls.Add(Me.BirthdaysBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DataGridDisplayForm"
        Me.Text = "Data Grid Display Form"
        CType(Me._Birthdays_2_DataSetATTEMPT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthdaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthdaysBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BirthdaysBindingNavigator.ResumeLayout(False)
        Me.BirthdaysBindingNavigator.PerformLayout()
        CType(Me.BirthdaysDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BirthdaysDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents standardDataViewBtn As Button
    Friend WithEvents addRecordBtn As Button
    Friend WithEvents addAllRecordsBtn As Button
End Class
