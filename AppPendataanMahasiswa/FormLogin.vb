Imports System.Data.OleDb

Public Class FormLogin
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AppVb\AppPendataanMahasiswa\AppPendataanMahasiswa\bin\Debug\TabelForm.mdb;"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub FormLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNama.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim username As String = txtNama.Text
        Dim type As String = ComboBox1.Text
        Dim password As String = txtPassword.Text

        If AuthenticateUser(username, password, type) Then
            MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Success")

            ' Set userType in FormBeranda
            Dim berandaForm As New FormBeranda()
            berandaForm.userType = GetUserType(username)
            berandaForm.Show()

            Me.Hide()
        Else
            MsgBox("Nama, user type atau Password salah!", MsgBoxStyle.Critical, "Error")
            clearTxt()
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String, type As String) As Boolean
        Try
            ' Open connection
            connection.Open()

            ' Query to check if username and password match
            Dim query As String = "SELECT * FROM TblUser WHERE Username=? AND Password=? AND UserType=?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("Username", username)
                cmd.Parameters.AddWithValue("Password", password)
                cmd.Parameters.AddWithValue("UserType", type)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    Return reader.HasRows
                End Using
            End Using
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

    Private Function GetUserType(username As String) As String
        Try
            ' Open connection
            connection.Open()

            ' Query to get the user type
            Dim query As String = "SELECT UserType FROM TblUser WHERE Username=?"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("Username", username)

                Dim userType As Object = cmd.ExecuteScalar()
                Return If(userType IsNot Nothing, userType.ToString(), "")
            End Using
        Catch ex As Exception
            ' Handle exceptions (log or show an error message)
            MessageBox.Show("Error: " & ex.Message)
            Return ""
        Finally
            ' Close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function

    Sub clearTxt()
        txtNama.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub BtnKlr_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
End Class
