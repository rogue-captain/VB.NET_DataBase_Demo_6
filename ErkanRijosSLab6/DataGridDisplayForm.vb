'Programmer: Sully Erkan-Rijos

'Class: CST -226

'Lab: 6

'Description: 
'This Program produces a form that allows the user to select if they want to see the database data in standard or DataGrid view with
'The option of two buttons. Upon a selection, the user can interface with the data base. The user can view, add, delete, modifty and
'import external files to add to the database. 


Imports System.IO
Public Class DataGridDisplayForm
    Inherits System.Windows.Forms.Form
    Public Sub DataGridDisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the '_Birthdays_2_DataSetATTEMPT2.Birthdays' table. You can move, or remove it, as needed.
        Me.BirthdaysTableAdapter.Fill(Me._Birthdays_2_DataSetATTEMPT2.Birthdays)

        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.database_symbol_32x32))

        'assign cursor
        If Not cur Is Nothing Then

            Me.Cursor = cur

        Else

            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub BirthdaysBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BirthdaysBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.BirthdaysBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Birthdays_2_DataSetATTEMPT2)

    End Sub

    Private Sub standardDataViewBtn_Click(sender As Object, e As EventArgs) Handles standardDataViewBtn.Click

        Dim NoDataGridDisplayForm As NoDataGridDisplayForm
        NoDataGridDisplayForm = New NoDataGridDisplayForm
        NoDataGridDisplayForm.ShowDialog()

    End Sub

    Private Sub addRecordBtn_Click(sender As Object, e As EventArgs) Handles addRecordBtn.Click

        AddIndividualRecordsFromFile()

    End Sub

    Private Sub addAllRecordsBtn_Click(sender As Object, e As EventArgs) Handles addAllRecordsBtn.Click

        AddAllRecordsFromFile()

    End Sub



    Public Sub AddIndividualRecordsFromFile()

        'Variables for seperating lines of string 
        Dim FirstName As String
        Dim LastName As String
        Dim Birthdate As Date

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Multiselect = True
        openFileDialog.Filter = "Text Files|*.txt|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog.FileName

            ' Display the message box asking whether the user wants to use file
            Dim confirmationResult As DialogResult = MessageBox.Show($"Data from file: {filePath}

            {Environment.NewLine}Do you want to use this File?", "Confirm File Record Addition",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmationResult = DialogResult.Yes Then
                Try
                    ' Read all lines from the file
                    Dim individualRecordLine As String() = File.ReadAllLines(filePath)

                    ' Iterate over each line
                    For Each line As String In individualRecordLine

                        ' Display the line to the user and ask if they want to add a record
                        Dim result As DialogResult = MessageBox.Show($"Data from file: {line}

                    {Environment.NewLine}Do you want to add this record?", "Confirm Record Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        ' Split the line 
                        Dim parts As String() = line.Split(New Char() {" "c, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries)

                        If parts.Length >= 3 Then

                            FirstName = parts(0).Trim()
                            LastName = parts(1).Trim()

                            If Date.TryParse(parts(2).Trim(), Birthdate) Then

                                MessageBox.Show($"First Name: {FirstName}, Last Name: {LastName}, Birthday: {Birthdate}")
                                'or MessageBox.Show("First Name:" & FirstName)

                            Else
                                MessageBox.Show($"Invalid date format on line: {line}")
                            End If

                        Else
                            MessageBox.Show($"Invalid line format: {line}")
                        End If

                        ' Add the record if the user confirms
                        If result = DialogResult.Yes Then

                            Me.BirthdaysTableAdapter.Fill(Me._Birthdays_2_DataSetATTEMPT2.Birthdays)
                            Me.BirthdaysTableAdapter.Insert(FirstName, LastName, Birthdate)
                            Me.BirthdaysTableAdapter.Fill(Me._Birthdays_2_DataSetATTEMPT2.Birthdays)

                            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Next
                Catch ex As Exception

                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub

    Sub AddAllRecordsFromFile()

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True
        openFileDialog.Filter = "Text Files|*.txt|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog.FileName

            ' Display the line to the user and ask if they want to add a record
            Dim result As DialogResult = MessageBox.Show($"Data from file: {filePath}

            {Environment.NewLine}Do you want to add this entire File?", "Confirm entire file Record Addition",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then

                MessageBox.Show("No records were added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Try
                ' Read all lines from the file
                Dim entireRecord As String() = File.ReadAllLines(filePath)

                ' Initialize lists to hold extracted records
                Dim firstNames As New List(Of String)()
                Dim lastNames As New List(Of String)()
                Dim birthdates As New List(Of Date)()

                ' Iterate over each line
                For Each line As String In entireRecord

                    ' Split the line into variables and list
                    Dim parts As String() = line.Split(New Char() {" "c, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries)

                    If parts.Length >= 3 Then

                        ' Extract first name
                        Dim firstName As String = parts(0).Trim()

                        firstNames.Add(firstName)

                        ' Extract last name
                        Dim lastName As String = parts(1).Trim()

                        lastNames.Add(lastName)

                        ' Extract birthdate
                        Dim birthdate As Date

                        If Date.TryParse(parts(2).Trim(), birthdate) Then

                            birthdates.Add(birthdate)
                        Else

                            MessageBox.Show($"Invalid date format on line: {line}")
                        End If

                    Else

                        MessageBox.Show($"Invalid line format: {line}")
                    End If
                Next

                ' Bulk insert all records into the database
                If firstNames.Count > 0 AndAlso lastNames.Count > 0 AndAlso birthdates.Count > 0 Then

                    For i As Integer = 0 To firstNames.Count - 1

                        Me.BirthdaysTableAdapter.Insert(firstNames(i), lastNames(i), birthdates(i))
                    Next

                    ' Refresh dataset
                    Me.BirthdaysTableAdapter.Fill(Me._Birthdays_2_DataSetATTEMPT2.Birthdays)

                    MessageBox.Show("All records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    MessageBox.Show("No valid records found in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception

                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class