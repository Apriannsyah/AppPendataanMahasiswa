Imports System.Data.OleDb

Public Class FormAdmin_Mhs
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AppVb\AppPendataanMahasiswa\AppPendataanMahasiswa\bin\Debug\TabelForm.mdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Menutup koneksi jika sudah terbuka sebelumnya
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        Try
            ' Membuka koneksi
            connection.Open()

            ' Query untuk mengambil data dari database
            Dim query As String = ""

            If ComboBox1.Text = "Kelas_1A" Then
                query = "SELECT * FROM Kelas_1A"
            ElseIf ComboBox1.Text = "Kelas_1B" Then
                query = "SELECT * FROM Kelas_1B"
            ElseIf ComboBox1.Text = "Kelas_1C" Then
                query = "SELECT * FROM Kelas_1C"
            End If

            Dim command As New OleDbCommand(query, connection)
            Dim dataAdapter As New OleDbDataAdapter(command)
            Dim dataSet As New DataSet()

            ' Mengisi DataSet dengan data dari database
            dataAdapter.Fill(dataSet, ComboBox1.Text)

            ' Menampilkan data di DataGridView
            DataGridView1.DataSource = dataSet.Tables(ComboBox1.Text)

        Catch ex As OleDbException
            ' Menangani OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Menangani exception lainnya
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Menutup koneksi setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadDataForSelectedClass()
        ' Menutup koneksi jika sudah terbuka sebelumnya
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        Try
            ' Membuka koneksi
            connection.Open()

            ' Query untuk mengambil data dari database
            Dim query As String = "SELECT * FROM " & ComboBox1.Text
            Dim command As New OleDbCommand(query, connection)
            Dim dataAdapter As New OleDbDataAdapter(command)
            Dim dataSet As New DataSet()

            ' Mengisi DataSet dengan data dari database
            dataAdapter.Fill(dataSet, ComboBox1.Text)

            ' Menampilkan data di DataGridView
            DataGridView1.DataSource = dataSet.Tables(ComboBox1.Text)

        Catch ex As OleDbException
            ' Menangani OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Menangani exception lainnya
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Menutup koneksi setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        ' Input data from TextBox
        Dim nama As String = TxtNama.Text
        Dim nim As String = TxtNIM.Text
        Dim kls As String = TxtKls.Text

        ' Check if the TextBox is not empty
        If String.IsNullOrEmpty(nim) Then
            MessageBox.Show("Please enter a NIM")
            Return
        ElseIf String.IsNullOrEmpty(nama) Then
            MessageBox.Show("Please enter a name")
            Return
        ElseIf String.IsNullOrEmpty(kls) Then
            MessageBox.Show("Please enter a kelas")
            Return
        End If

        ' SQL INSERT statement
        Dim insertQuery As String = "INSERT INTO " & ComboBox1.Text & " (NIM, Nama, Kelas) VALUES (?, ?, ?)"

        Using connectionInsert As New OleDbConnection(connectionString)
            Try
                connectionInsert.Open()

                ' Create a command with parameters
                Dim command As New OleDbCommand(insertQuery, connectionInsert)
                command.Parameters.AddWithValue("?", nim)
                command.Parameters.AddWithValue("?", nama)
                command.Parameters.AddWithValue("?", kls)

                ' Execute the INSERT statement
                command.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil Ditambah!")
                LoadDataForSelectedClass()

            Catch ex As OleDbException
                ' Handle OleDbException
                MessageBox.Show("OleDbException: " & ex.Message)

            Catch ex As Exception
                ' Handle other exceptions
                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ' Manually refresh the DataGridView
        LoadDataForSelectedClass()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Get the selected row in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Assuming the "NIM" column is in a specific position, adjust if needed
            Dim nimToDelete As String = DataGridView1.Rows(selectedRowIndex).Cells("NIM").Value.ToString()

            ' Set the value in the Nim textbox
            TxtNIM.Text = nimToDelete

            ' SQL DELETE statement

            Dim deleteQuery As String = "DELETE FROM " & ComboBox1.Text & " WHERE NIM = ?"
            Try
                Using connectionDelete As New OleDbConnection(connectionString)
                    connectionDelete.Open()

                    ' Create a command with parameters
                    Dim command As New OleDbCommand(deleteQuery, connectionDelete)
                    command.Parameters.AddWithValue("?", nimToDelete)

                    ' Execute the DELETE statement
                    command.ExecuteNonQuery()

                    MessageBox.Show("Berhasil Menghapus!")

                    ' Refresh the DataGridView after deleting data
                    LoadDataForSelectedClass()
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

    Private isEditMode As Boolean = False ' Flag to track edit mode

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Assuming the "NIM" column is in a specific position, adjust if needed
            Dim nimToEdit As String = DataGridView1.Rows(selectedRowIndex).Cells("NIM").Value.ToString()

            ' Set the value in the Nim textbox
            TxtNIM.Text = nimToEdit

            If Not isEditMode Then
                ' Display data in TextBoxes for editing
                TxtNama.Text = DataGridView1.Rows(selectedRowIndex).Cells("Nama").Value.ToString()
                TxtKls.Text = DataGridView1.Rows(selectedRowIndex).Cells("Kelas").Value.ToString()


                ' Enable controls for editing
                TxtNama.Enabled = True
                TxtKls.Enabled = True
                BtnEdit.Text = "Save Edit"
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
        Dim nimToEdit As String = TxtNIM.Text

        ' Check if the NIM is not empty
        If String.IsNullOrEmpty(nimToEdit) Then
            MessageBox.Show("Please enter a NIM to edit.")
            Return
        End If

        ' Get the edited values from TextBoxes
        Dim editedName As String = TxtNama.Text
        Dim editedKelas As String = TxtKls.Text

        ' SQL UPDATE statement
        Dim updateQuery As String = "UPDATE " & ComboBox1.Text & " SET Nama = ?, Kelas = ? WHERE NIM = ?"

        Try
            Using connectionUpdate As New OleDbConnection(connectionString)
                connectionUpdate.Open()

                ' Create a command with parameters
                Dim command As New OleDbCommand(updateQuery, connectionUpdate)
                command.Parameters.AddWithValue("?", editedName)
                command.Parameters.AddWithValue("?", editedKelas)
                command.Parameters.AddWithValue("?", nimToEdit)

                ' Execute the UPDATE statement
                command.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil Diupdate!")

                ' Refresh the DataGridView after updating data
                LoadDataForSelectedClass()

                ' Disable controls after saving edits
                TxtNama.Enabled = False
                TxtKls.Enabled = False
                BtnEdit.Text = "Edit"
            End Using
        Catch ex As OleDbException
            ' Handle OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FormAdmin_Mhs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class