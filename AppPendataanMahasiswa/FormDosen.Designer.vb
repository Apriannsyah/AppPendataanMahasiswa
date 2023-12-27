<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDosen
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnHadir = New System.Windows.Forms.Button()
        Me.BtnSakit = New System.Windows.Forms.Button()
        Me.BtnIzin = New System.Windows.Forms.Button()
        Me.BtnAlpa = New System.Windows.Forms.Button()
        Me.GroupBoxKehadiran = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNilai = New System.Windows.Forms.TextBox()
        Me.GroupBoxNilai = New System.Windows.Forms.GroupBox()
        Me.BtnKirim = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxKehadiran.SuspendLayout()
        Me.GroupBoxNilai.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(578, 254)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Absensi Mahasiswa", "Input Nilai Mahasiswa"})
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Absensi Mahasiswa", "Input Nilai Mahasiswa"})
        Me.ComboBox1.Location = New System.Drawing.Point(29, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(30, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Kelas1A"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(30, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kelas1B"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(30, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Kelas1C"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 90)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Kelas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(107, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(214, 152)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(75, 23)
        Me.BtnShow.TabIndex = 8
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(214, 126)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnHadir
        '
        Me.BtnHadir.Location = New System.Drawing.Point(6, 23)
        Me.BtnHadir.Name = "BtnHadir"
        Me.BtnHadir.Size = New System.Drawing.Size(66, 23)
        Me.BtnHadir.TabIndex = 10
        Me.BtnHadir.Text = "Hadir"
        Me.BtnHadir.UseVisualStyleBackColor = True
        '
        'BtnSakit
        '
        Me.BtnSakit.Location = New System.Drawing.Point(6, 52)
        Me.BtnSakit.Name = "BtnSakit"
        Me.BtnSakit.Size = New System.Drawing.Size(66, 23)
        Me.BtnSakit.TabIndex = 11
        Me.BtnSakit.Text = "Sakit"
        Me.BtnSakit.UseVisualStyleBackColor = True
        '
        'BtnIzin
        '
        Me.BtnIzin.Location = New System.Drawing.Point(78, 52)
        Me.BtnIzin.Name = "BtnIzin"
        Me.BtnIzin.Size = New System.Drawing.Size(66, 23)
        Me.BtnIzin.TabIndex = 12
        Me.BtnIzin.Text = "Izin"
        Me.BtnIzin.UseVisualStyleBackColor = True
        '
        'BtnAlpa
        '
        Me.BtnAlpa.Location = New System.Drawing.Point(78, 23)
        Me.BtnAlpa.Name = "BtnAlpa"
        Me.BtnAlpa.Size = New System.Drawing.Size(66, 23)
        Me.BtnAlpa.TabIndex = 13
        Me.BtnAlpa.Text = "Alpa"
        Me.BtnAlpa.UseVisualStyleBackColor = True
        '
        'GroupBoxKehadiran
        '
        Me.GroupBoxKehadiran.Controls.Add(Me.BtnHadir)
        Me.GroupBoxKehadiran.Controls.Add(Me.BtnSakit)
        Me.GroupBoxKehadiran.Controls.Add(Me.BtnIzin)
        Me.GroupBoxKehadiran.Controls.Add(Me.BtnAlpa)
        Me.GroupBoxKehadiran.Location = New System.Drawing.Point(295, 87)
        Me.GroupBoxKehadiran.Name = "GroupBoxKehadiran"
        Me.GroupBoxKehadiran.Size = New System.Drawing.Size(154, 90)
        Me.GroupBoxKehadiran.TabIndex = 14
        Me.GroupBoxKehadiran.TabStop = False
        Me.GroupBoxKehadiran.Text = "Kehadiran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Pilih Data"
        '
        'txtNilai
        '
        Me.txtNilai.Location = New System.Drawing.Point(6, 12)
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Size = New System.Drawing.Size(92, 20)
        Me.txtNilai.TabIndex = 16
        '
        'GroupBoxNilai
        '
        Me.GroupBoxNilai.Controls.Add(Me.BtnKirim)
        Me.GroupBoxNilai.Controls.Add(Me.txtNilai)
        Me.GroupBoxNilai.Location = New System.Drawing.Point(455, 139)
        Me.GroupBoxNilai.Name = "GroupBoxNilai"
        Me.GroupBoxNilai.Size = New System.Drawing.Size(152, 36)
        Me.GroupBoxNilai.TabIndex = 17
        Me.GroupBoxNilai.TabStop = False
        Me.GroupBoxNilai.Text = "Masukkan Nilai"
        '
        'BtnKirim
        '
        Me.BtnKirim.Location = New System.Drawing.Point(100, 13)
        Me.BtnKirim.Name = "BtnKirim"
        Me.BtnKirim.Size = New System.Drawing.Size(48, 20)
        Me.BtnKirim.TabIndex = 18
        Me.BtnKirim.Text = "Kirim"
        Me.BtnKirim.UseVisualStyleBackColor = True
        '
        'FormDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(640, 463)
        Me.Controls.Add(Me.GroupBoxNilai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxKehadiran)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Dosen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxKehadiran.ResumeLayout(False)
        Me.GroupBoxNilai.ResumeLayout(False)
        Me.GroupBoxNilai.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnHadir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSakit As System.Windows.Forms.Button
    Friend WithEvents BtnIzin As System.Windows.Forms.Button
    Friend WithEvents BtnAlpa As System.Windows.Forms.Button
    Friend WithEvents GroupBoxKehadiran As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNilai As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxNilai As System.Windows.Forms.GroupBox
    Friend WithEvents BtnKirim As System.Windows.Forms.Button
End Class
