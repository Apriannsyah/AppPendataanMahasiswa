Imports System.Data.OleDb

Public Class FormBeranda
    Public userType As String

    Private Sub FormBeranda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Display or enable controls based on user type
        Select Case userType
            Case "Admin"
                LabelWelcome.Text = "Welcome, Admin!"
                ' Admin has access to all forms
                ' Enable or show all necessary controls or forms

            Case "Dosen"
                ' Dosen (lecturer) has access to FormDosen
                ' Enable or show controls related to FormDosen
                LabelWelcome.Text = "Welcome, Dosen!"

            Case "Mahasiswa"
                ' Mahasiswa (student) has access to FormMahasiswa
                ' Enable or show controls related to FormMahasiswa
                LabelWelcome.Text = "Welcome, Mahasiswa!"

            Case Else
                ' Handle other user types or invalid cases
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close() ' Close the Beranda form if the user type is invalid
        End Select
    End Sub

    Private Sub FormAdminToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormAdminToolStripMenuItem.Click
        Dim formAdmin As New MasukFormAdmin()

        Select Case userType
            Case "Admin"
                ' Admin has access to the FormAdmin
                formAdmin.Show()
                Me.Hide()
            Case "Dosen", "Mahasiswa"
                ' Display a message for users with userType "Dosen" or "Mahasiswa"
                MessageBox.Show("You have no access to this form", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                ' Close the FormAdmin
                formAdmin.Close()

            Case Else
                ' Handle other user types or invalid cases
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub


    Private Sub FormDosenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormDosenToolStripMenuItem.Click
        Dim formDosen As New FormDosen()

        Select Case userType
            Case "Admin", "Dosen"
                formDosen.Show()
                Me.Hide()
            Case "Mahasiswa"
                MessageBox.Show("You have no access to this form", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Close the FormAdmin
                formDosen.Close()

            Case Else
                ' Handle other user types or invalid cases
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub FormMahasiswaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormMahasiswaToolStripMenuItem.Click
        Dim formMahasiswa As New FormMahasiswa()

        Select Case userType
            Case "Admin", "Mahasiswa"
                FormMahasiswa.Show()
                Me.Hide()
            Case "Dosen"
                MessageBox.Show("You have no access to this form", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                FormMahasiswa.Close()

            Case Else
                ' Handle other user types or invalid cases
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub BuatAkunToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuatAkunToolStripMenuItem.Click
        Dim formSignUp As New FormSignUp()
        formSignUp.Show()

        Select Case userType
            Case "Admin"
                formSignUp.Show()
                Me.Hide()
            Case "Dosen", "Mahasiswa"
                MessageBox.Show("You have no access to this form", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                formSignUp.Close()

            Case Else
                ' Handle other user types or invalid cases
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub KeluarAplikasiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarAplikasiToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class

Public Class MasukFormAdmin
    Private Sub MasukFormAdmin_FormClosing(sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Assuming FormBeranda is already open, find it among open forms
        For Each form As Form In Application.OpenForms
            If TypeOf form Is FormBeranda Then
                form.Show()
                Exit For
            End If
        Next
    End Sub
End Class
Public Class FormAdmin_Dsn
    Private Sub FormAdmin_Dsn_FormClosing(sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Assuming FormBeranda is already open, find it among open forms
        For Each form As Form In Application.OpenForms
            If TypeOf form Is FormBeranda Then
                form.Show()
                Exit For
            End If
        Next
    End Sub
End Class

Public Class FormAdmin_Mhs
    Private Sub FormAdmin_Mhs_FormClosing(sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Assuming FormBeranda is already open, find it among open forms
        For Each form As Form In Application.OpenForms
            If TypeOf form Is FormBeranda Then
                form.Show()
                Exit For
            End If
        Next
    End Sub
End Class


Public Class FormDosen
    Private Sub FormDosen_FormClosing(sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Assuming FormBeranda is already open, find it among open forms
        For Each form As Form In Application.OpenForms
            If TypeOf form Is FormBeranda Then
                form.Show()
                Exit For
            End If
        Next
    End Sub
End Class

Public Class FormMahasiswa
    Private Sub FormMahasiswa_FormClosing(sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Assuming FormBeranda is already open, find it among open forms
        For Each form As Form In Application.OpenForms
            If TypeOf form Is FormBeranda Then
                form.Show()
                Exit For
            End If
        Next
    End Sub
End Class

Public Class FormSignUp
    Private Sub FormSignUp_FormClosing(sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each form As Form In Application.OpenForms
            If TypeOf form Is FormBeranda Then
                form.Show()
                Exit For
            End If
        Next
    End Sub
End Class

