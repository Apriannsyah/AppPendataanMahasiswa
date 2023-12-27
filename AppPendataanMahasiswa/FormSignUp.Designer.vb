<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNewUsername = New System.Windows.Forms.TextBox()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxUserType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Thin", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Thin", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TxtNewUsername
        '
        Me.TxtNewUsername.Location = New System.Drawing.Point(108, 47)
        Me.TxtNewUsername.Name = "TxtNewUsername"
        Me.TxtNewUsername.Size = New System.Drawing.Size(215, 20)
        Me.TxtNewUsername.TabIndex = 2
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Location = New System.Drawing.Point(108, 78)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(215, 20)
        Me.TxtNewPassword.TabIndex = 3
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(256, 108)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(67, 23)
        Me.BtnSignUp.TabIndex = 4
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Image = Global.AppPendataanMahasiswa.My.Resources.Resources.show
        Me.CheckBox1.Location = New System.Drawing.Point(329, 74)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(39, 31)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Thin", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Type"
        '
        'ComboBoxUserType
        '
        Me.ComboBoxUserType.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Dosen", "Mahasiswa"})
        Me.ComboBoxUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxUserType.FormattingEnabled = True
        Me.ComboBoxUserType.Items.AddRange(New Object() {"Admin", "Dosen", "Mahasiswa"})
        Me.ComboBoxUserType.Location = New System.Drawing.Point(108, 108)
        Me.ComboBoxUserType.Name = "ComboBoxUserType"
        Me.ComboBoxUserType.Size = New System.Drawing.Size(142, 21)
        Me.ComboBoxUserType.TabIndex = 8
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(371, 159)
        Me.Controls.Add(Me.ComboBoxUserType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.TxtNewUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSignUp"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNewUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnSignUp As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUserType As System.Windows.Forms.ComboBox
End Class
