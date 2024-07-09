'Programmer: Sully Erkan-Rijos

'Class: CST -226

'Lab: 6

'Description: 
'This Program produces a form that allows the user to select if they want to see the database data in standard or DataGrid view with
'The option of two buttons. Upon a selection, the user can interface with the data base. The user can view, add, delete, modifty and
'import external files to add to the database. 
Public Class birthdayDatabaseForm
    Inherits System.Windows.Forms.Form

    Private Sub birthdayDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.database_symbol_32x32))

        'assign cursor
        If Not cur Is Nothing Then

            Me.Cursor = cur

        Else

            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub noGridDataBtn_Click(sender As Object, e As EventArgs) Handles noGridDataBtn.Click

        Dim NoDataGridDisplayForm As NoDataGridDisplayForm
        NoDataGridDisplayForm = New NoDataGridDisplayForm
        NoDataGridDisplayForm.ShowDialog()

    End Sub

    Private Sub gridDataBtn_Click(sender As Object, e As EventArgs) Handles gridDataBtn.Click

        Dim DataGridDisplayForm As DataGridDisplayForm
        DataGridDisplayForm = New DataGridDisplayForm
        DataGridDisplayForm.ShowDialog()

    End Sub

End Class
