Imports System.Data.OleDb

Public Class FormDosen
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AppVb\AppPendataanMahasiswa\AppPendataanMahasiswa\bin\Debug\TabelForm.mdb;"
    Dim connection As New OleDbConnection(connectionString)
    Dim dataSet As New DataSet()
    Dim tableName As String = ""

    Private Sub BtnShow_Click(sender As System.Object, e As System.EventArgs) Handles BtnShow.Click
        LoadData()
    End Sub

Private Function GetSelectedTableName() As String
        Dim selectedTable As String = ""

        If ComboBox1.SelectedIndex = 0 Then
            If RadioButton1.Checked Then
                selectedTable = "TblAbsen1A"
            ElseIf RadioButton2.Checked Then
                selectedTable = "TblAbsen1B"
            ElseIf RadioButton3.Checked Then
                selectedTable = "TblAbsen1C"
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
            If RadioButton1.Checked Then
                selectedTable = "TblNilai1A"
            ElseIf RadioButton2.Checked Then
                selectedTable = "TblNilai1B"
            ElseIf RadioButton3.Checked Then
                selectedTable = "TblNilai1C"
            End If
        End If

        ' Show/Hide GroupBoxes based on the selection
        If selectedTable.StartsWith("TblAbsen") Then
            GroupBoxNilai.Hide()
            GroupBoxKehadiran.Show()
        ElseIf selectedTable.StartsWith("TblNilai") Then
            GroupBoxKehadiran.Hide()
            GroupBoxNilai.Show()
        Else
            GroupBoxKehadiran.Hide()
            GroupBoxNilai.Hide()
        End If

        Return selectedTable
    End Function

    Private Sub LoadData()
        ' Menutup koneksi jika sudah terbuka sebelumnya
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        Try
            ' Membuka koneksi
            connection.Open()

            ' Menentukan tabel berdasarkan ComboBox dan RadioButton
            tableName = GetSelectedTableName()

            ' Cek apakah setidaknya satu radio button terpilih
            If String.IsNullOrEmpty(tableName) Then
                MessageBox.Show("Please select a radio button.")
                Return
            End If

            ' Query untuk mengambil data dari database
            Dim query As String = "SELECT * FROM " & tableName
            Dim command As New OleDbCommand(query, connection)
            Dim dataAdapter As New OleDbDataAdapter(command)

            ' Mengisi DataSet dengan data dari database
            dataAdapter.Fill(dataSet, tableName)

            ' Menampilkan data di DataGridView
            DataGridView1.DataSource = dataSet.Tables(tableName)

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

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        ' Check if a table is selected
        If String.IsNullOrEmpty(tableName) Then
            MessageBox.Show("Please select a table before saving.")
            Return
        End If

        Try
            ' Open connection
            connection.Open()

            ' Create data adapter with SELECT command
            Dim dataAdapter As New OleDbDataAdapter("SELECT * FROM " & tableName, connection)

            ' Create command builder
            Dim commandBuilder As New OleDbCommandBuilder(dataAdapter)

            ' Set the primary key for the DataTable (replace "NIM" with the actual column name)
            dataSet.Tables(tableName).PrimaryKey = {dataSet.Tables(tableName).Columns("NIM")}

            ' Manually specify the UpdateCommand
            dataAdapter.UpdateCommand = New OleDbCommand("UPDATE " & tableName & " SET Nama=?, Kelas=?, Minggu_1=?, Minggu_2=?, Minggu_3=?, Minggu_4=?, Minggu_5=? WHERE NIM=?", connection)

            ' Replace placeholders with the actual column names in your table
            dataAdapter.UpdateCommand.Parameters.Add("Nama", OleDbType.VarChar, 255, "nama")
            dataAdapter.UpdateCommand.Parameters.Add("Kelas", OleDbType.VarChar, 255, "kelas")
            dataAdapter.UpdateCommand.Parameters.Add("Minggu_1", OleDbType.VarChar, 255, "Minggu_1")
            dataAdapter.UpdateCommand.Parameters.Add("Minggu_2", OleDbType.VarChar, 255, "Minggu_2")
            dataAdapter.UpdateCommand.Parameters.Add("Minggu_3", OleDbType.VarChar, 255, "Minggu_3")
            dataAdapter.UpdateCommand.Parameters.Add("Minggu_4", OleDbType.VarChar, 255, "Minggu_4")
            dataAdapter.UpdateCommand.Parameters.Add("Minggu_5", OleDbType.VarChar, 255, "Minggu_5")
            dataAdapter.UpdateCommand.Parameters.Add("NIM", OleDbType.VarChar, 255, "NIM").SourceVersion = DataRowVersion.Original

            ' Update changes in the DataSet back to the database
            dataAdapter.Update(dataSet, tableName)

            ' Inform the user that changes have been saved
            MessageBox.Show("Data Berhasil Disave.")

        Catch ex As OleDbException
            ' Handle OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close connection when done
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub




    Private Sub BtnHadir_Click(sender As System.Object, e As System.EventArgs) Handles BtnHadir.Click
        UpdateColumnWithValue("H")
    End Sub

    Private Sub BtnSakit_Click(sender As System.Object, e As System.EventArgs) Handles BtnSakit.Click
        UpdateColumnWithValue("S")
    End Sub

    Private Sub BtnAlpa_Click(sender As System.Object, e As System.EventArgs) Handles BtnAlpa.Click
        UpdateColumnWithValue("A")
    End Sub

    Private Sub BtnIzin_Click(sender As System.Object, e As System.EventArgs) Handles BtnIzin.Click
        UpdateColumnWithValue("I")
    End Sub

    Private Sub UpdateColumnWithValue(value As String)
        If DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a column.")
            Return
        End If

        ' Update the specified column in the DataGridView
        For Each selectedCell As DataGridViewCell In DataGridView1.SelectedCells
            selectedCell.Value = value
        Next

        ' Update the corresponding TextBox value to the selected value
        txtNilai.Text = value
        value = value
    End Sub

Private Sub BtnKirim_Click(sender As System.Object, e As System.EventArgs) Handles BtnKirim.Click
        ' Get the selected column index in the DataGridView
        Dim selectedColumnIndex As Integer = DataGridView1.CurrentCell.ColumnIndex

        ' Check if a column is selected
        If selectedColumnIndex = -1 Then
            MessageBox.Show("Please select a column.")
            Return
        End If

        ' Get the selected value from the TextBox
        Dim columnValue As String = txtNilai.Text()

        ' Check if the TextBox is not empty
        If String.IsNullOrEmpty(columnValue) Then
            MessageBox.Show("Please enter a value in the TextBox.")
            Return
        End If

        ' Update the selected column in the DataGridView with the TextBox value
        For Each selectedCell As DataGridViewCell In DataGridView1.SelectedCells
            selectedCell.Value = columnValue
        Next
    End Sub

End Class
