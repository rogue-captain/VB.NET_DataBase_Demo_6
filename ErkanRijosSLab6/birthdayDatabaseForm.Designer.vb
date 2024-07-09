<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class birthdayDatabaseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(birthdayDatabaseForm))
        Me.noGridDataBtn = New System.Windows.Forms.Button()
        Me.gridDataBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'noGridDataBtn
        '
        Me.noGridDataBtn.Location = New System.Drawing.Point(45, 146)
        Me.noGridDataBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.noGridDataBtn.Name = "noGridDataBtn"
        Me.noGridDataBtn.Size = New System.Drawing.Size(109, 63)
        Me.noGridDataBtn.TabIndex = 2
        Me.noGridDataBtn.Text = "Data with No Grid"
        Me.noGridDataBtn.UseVisualStyleBackColor = True
        '
        'gridDataBtn
        '
        Me.gridDataBtn.Location = New System.Drawing.Point(391, 146)
        Me.gridDataBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridDataBtn.Name = "gridDataBtn"
        Me.gridDataBtn.Size = New System.Drawing.Size(117, 63)
        Me.gridDataBtn.TabIndex = 3
        Me.gridDataBtn.Text = "Data with Grid"
        Me.gridDataBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "*Select how data is to be displayed. Text File for use included with Lab 6*"
        '
        'birthdayDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridDataBtn)
        Me.Controls.Add(Me.noGridDataBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "birthdayDatabaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Birthday Database Form "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents noGridDataBtn As Button
    Friend WithEvents gridDataBtn As Button
    Friend WithEvents Label1 As Label
End Class
