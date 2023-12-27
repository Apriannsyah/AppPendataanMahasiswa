Public Class MasukFormAdmin

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedType As String = ComboBox1.SelectedItem.ToString()

        If selectedType = "Mahasiswa" Then
            MessageBox.Show("Data Mahasiswa")
            Dim mhsData As New FormAdmin_Mhs()
            FormAdmin_Mhs.Show()
            Me.Hide()
        ElseIf selectedType = "Dosen" Then
            MessageBox.Show("Data Dosen")
            Dim dsnData As New FormAdmin_Dsn()
            FormAdmin_Dsn.Show()
            Me.Hide()
        End If
    End Sub
End Class