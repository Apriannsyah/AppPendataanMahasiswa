Imports System.Data.OleDb

Public Class FormSignUp

    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AppVb\AppPendataanMahasiswa\AppPendataanMahasiswa\bin\Debug\TabelForm.mdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TxtNewPassword.UseSystemPasswordChar = False
        Else
            TxtNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnSignUp_Click(sender As System.Object, e As System.EventArgs) Handles BtnSignUp.Click
        Dim userType As String = CStr(ComboBoxUserType.SelectedItem)

        If String.IsNullOrEmpty(userType) Then
            MsgBox("Please select a user type.", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        If RegisterUser(TxtNewUsername.Text, TxtNewPassword.Text, userType) Then
            MsgBox("User successfully registered!", MsgBoxStyle.Information, "Success")
            Me.Close()
        Else
            MsgBox("Failed to register user!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Function RegisterUser(username As String, password As String, userType As String) As Boolean
        Try
            ' Open connection
            connection.Open()

            ' Check if the username already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM TblUser WHERE Username=?"
            Using checkCmd As New OleDbCommand(checkQuery, connection)
                checkCmd.Parameters.AddWithValue("Username", username)
                Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MsgBox("Username already exists. Please choose a different username.", MsgBoxStyle.Exclamation, "Error")
                    Return False
                End If
            End Using

            ' Insert new user with user type
            Dim insertQuery As String = "INSERT INTO TblUser (Username, [Password], UserType) VALUES (?, ?, ?)"
            Using insertCmd As New OleDbCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("Username", username)
                insertCmd.Parameters.AddWithValue("Password", password)
                insertCmd.Parameters.AddWithValue("UserType", userType)
                insertCmd.ExecuteNonQuery()
            End Using

            Return True
        Catch ex As Exception
            ' Handle exceptions (log or show an error message)
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            ' Close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function
End Class
