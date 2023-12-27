Imports System.Data.OleDb

Public Class FormAdmin_Dsn

    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AppVb\AppPendataanMahasiswa\AppPendataanMahasiswa\bin\Debug\TabelForm.mdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub LoadData()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Query to retrieve data from the database
                Dim query As String = "SELECT * FROM TblDsn"
                Dim command As New OleDbCommand(query, connection)
                Dim dataAdapter As New OleDbDataAdapter(command)
                Dim dataSet As New DataSet()

                ' Fill the DataSet with data from the database
                dataAdapter.Fill(dataSet, "TblDsn")

                ' Display the data in the DataGridView
                DataGridView1.DataSource = dataSet.Tables("TblDsn")
            End Using
        Catch ex As OleDbException
            ' Handle OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FormAdmin_Dsn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi LoadData saat form terbuka
        LoadData()
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        ' Input data from TextBox
        Dim kode As String = TxtKd.Text
        Dim nama As String = TxtNama.Text
        Dim matkul As String = TxtMatkul.Text

        ' Check if the TextBox is not empty
        If String.IsNullOrEmpty(kode) Then
            MessageBox.Show("Please enter a kode")
            Return
        ElseIf String.IsNullOrEmpty(nama) Then
            MessageBox.Show("Please enter a nama")
            Return
        ElseIf String.IsNullOrEmpty(matkul) Then
            MessageBox.Show("Please enter a mata kuliah")
            Return
        End If

        ' SQL INSERT statement
        Dim insertQuery As String = "INSERT INTO TblDsn (kd_dosen, Nama_Dosen, Matkul_Diampu) VALUES (?, ?, ?)"

        Using connectionInsert As New OleDbConnection(connectionString)
            Try
                connectionInsert.Open()

                ' Create a command with parameters
                Dim command As New OleDbCommand(insertQuery, connectionInsert)
                command.Parameters.AddWithValue("?", kode)
                command.Parameters.AddWithValue("?", nama)
                command.Parameters.AddWithValue("?", matkul)

                ' Execute the INSERT statement
                command.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil Ditambah!")
                LoadData()

            Catch ex As OleDbException
                ' Handle OleDbException
                MessageBox.Show("OleDbException: " & ex.Message)

            Catch ex As Exception
                ' Handle other exceptions
                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using
    End Sub

    Private Sub BtnDlt_Click(sender As System.Object, e As System.EventArgs) Handles BtnDlt.Click
        ' Get the selected row in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Assuming the "NIM" column is in a specific position, adjust if needed
            Dim dataToDelete As String = DataGridView1.Rows(selectedRowIndex).Cells("Kd_dosen").Value.ToString()

            ' Set the value in the Nim textbox
            TxtKd.Text = dataToDelete

            ' SQL DELETE statement
            Dim deleteQuery As String = "DELETE FROM TblDsn WHERE kd_dosen = ?"

            Try
                Using connectionDelete As New OleDbConnection(connectionString)
                    connectionDelete.Open()

                    ' Create a command with parameters
                    Dim command As New OleDbCommand(deleteQuery, connectionDelete)
                    command.Parameters.AddWithValue("?", dataToDelete)

                    ' Execute the DELETE statement
                    command.ExecuteNonQuery()

                    MessageBox.Show("Data Berhasil Dihapus!")

                    ' Refresh the DataGridView after deleting data
                    LoadData()
                End Using
            Catch ex As OleDbException
                ' Handle OleDbException
                MessageBox.Show("OleDbException: " & ex.Message)
            Catch ex As Exception
                ' Handle other exceptions
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private isEditMode As Boolean = False '
    Private Sub BtnEdt_Click(sender As Object, e As EventArgs) Handles BtnEdt.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Assuming the "kd_dosen" column is in a specific position, adjust if needed
            Dim kdToEdit As String = DataGridView1.Rows(selectedRowIndex).Cells("kd_dosen").Value.ToString()

            ' Set the value in the Nim textbox
            TxtKd.Text = kdToEdit

            If Not isEditMode Then
                ' Display data in TextBoxes for editing
                TxtNama.Text = DataGridView1.Rows(selectedRowIndex).Cells("Nama_Dosen").Value.ToString()
                TxtMatkul.Text = DataGridView1.Rows(selectedRowIndex).Cells("Matkul_Diampu").Value.ToString()

                ' Enable controls for editing
                TxtNama.Enabled = True
                TxtMatkul.Enabled = True
                BtnEdt.Text = "Save Edit"
            Else
                ' Save edits to the database
                SaveEdits()
            End If

            ' Toggle edit mode
            isEditMode = Not isEditMode
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub SaveEdits()
        ' Get the NIM value from TxtNIM
        Dim kodeToEdit As String = TxtKd.Text

        ' Check if the NIM is not empty
        If String.IsNullOrEmpty(kodeToEdit) Then
            MessageBox.Show("Please enter a kode to edit.")
            Return
        End If

        ' Get the edited values from TextBoxes
        Dim editedName As String = TxtNama.Text
        Dim editedMatkul As String = TxtMatkul.Text

        ' SQL UPDATE statement
        Dim updateQuery As String = "UPDATE TblDsn SET Nama_Dosen = ?, Matkul_Diampu = ? WHERE kd_dosen = ?"

        Try
            Using connectionUpdate As New OleDbConnection(connectionString)
                connectionUpdate.Open()

                MsgBox("Do you want to continue", MsgBoxStyle.YesNo)

                ' Create a command with parameters
                Dim command As New OleDbCommand(updateQuery, connectionUpdate)
                command.Parameters.AddWithValue("?", editedName)
                command.Parameters.AddWithValue("?", editedMatkul)
                command.Parameters.AddWithValue("?", kodeToEdit)

                ' Execute the UPDATE statement
                command.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil Diupdate!")

                ' Refresh the DataGridView after updating data
                LoadData()

                ' Disable controls after saving edits
                TxtNama.Enabled = False
                TxtMatkul.Enabled = False
                BtnEdt.Text = "Edit"
            End Using
        Catch ex As OleDbException
            ' Handle OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class