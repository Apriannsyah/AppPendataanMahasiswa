Imports System.Data.OleDb

Public Class FormMahasiswa

    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AppVb\AppPendataanMahasiswa\AppPendataanMahasiswa\bin\Debug\TabelForm.mdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub LoadData()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Query to retrieve data from the database
                Dim query As String = "SELECT * FROM Mata_Kuliah1A"
                Dim command As New OleDbCommand(query, connection)
                Dim dataAdapter As New OleDbDataAdapter(command)
                Dim dataSet As New DataSet()

                ' Fill the DataSet with data from the database
                dataAdapter.Fill(dataSet, "Mata_Kuliah1A")

                ' Display the data in the DataGridView
                DataGridView1.DataSource = dataSet.Tables("Mata_Kuliah1A")
            End Using
        Catch ex As OleDbException
            ' Handle OleDbException
            MessageBox.Show("OleDbException: " & ex.Message)
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Menutup koneksi jika sudah terbuka sebelumnya
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        Try
            Dim table As String = ""

            If ComboBox1.SelectedIndex = 0 Then
                table = "SELECT * FROM Mata_Kuliah1A"
            ElseIf ComboBox1.SelectedIndex = 1 Then
                table = "SELECT * FROM Mata_Kuliah1B"
            ElseIf ComboBox1.SelectedIndex = 2 Then
                table = "SELECT * FROM Mata_Kuliah1C"
            End If

            Dim command As New OleDbCommand(table, connection)
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


    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Menutup koneksi jika sudah terbuka sebelumnya
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        Try
            ' Membuka koneksi
            connection.Open()

            ' Query untuk mengambil data dari database
            Dim query As String = ""

            If ComboBox2.SelectedIndex = 0 Then
                query = "SELECT * FROM Kelas_1A"
            ElseIf ComboBox2.SelectedIndex = 1 Then
                query = "SELECT * FROM Kelas_1B"
            ElseIf ComboBox2.SelectedIndex = 2 Then
                query = "SELECT * FROM Kelas_1C"
            End If

            Dim command As New OleDbCommand(query, connection)
            Dim dataAdapter As New OleDbDataAdapter(command)
            Dim dataSet As New DataSet()

            ' Mengisi DataSet dengan data dari database
            dataAdapter.Fill(dataSet, ComboBox2.Text)

            ' Menampilkan data di DataGridView
            DataGridView1.DataSource = dataSet.Tables(ComboBox2.Text)

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

    Private Sub FormMahasiswa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class