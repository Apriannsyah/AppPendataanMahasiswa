<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeranda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBeranda))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormDosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Firebrick
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplikasiToolStripMenuItem, Me.AkunToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplikasiToolStripMenuItem
        '
        Me.AplikasiToolStripMenuItem.BackColor = System.Drawing.Color.Brown
        Me.AplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormAdminToolStripMenuItem, Me.FormMahasiswaToolStripMenuItem, Me.FormDosenToolStripMenuItem})
        Me.AplikasiToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AplikasiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
        Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
        '
        'FormAdminToolStripMenuItem
        '
        Me.FormAdminToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormAdminToolStripMenuItem.Name = "FormAdminToolStripMenuItem"
        Me.FormAdminToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FormAdminToolStripMenuItem.Text = "Form Admin"
        '
        'FormMahasiswaToolStripMenuItem
        '
        Me.FormMahasiswaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormMahasiswaToolStripMenuItem.Name = "FormMahasiswaToolStripMenuItem"
        Me.FormMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FormMahasiswaToolStripMenuItem.Text = "Form Mahasiswa"
        '
        'FormDosenToolStripMenuItem
        '
        Me.FormDosenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormDosenToolStripMenuItem.Name = "FormDosenToolStripMenuItem"
        Me.FormDosenToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FormDosenToolStripMenuItem.Text = "Form Dosen"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.BackColor = System.Drawing.Color.Brown
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatAkunToolStripMenuItem})
        Me.AkunToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AkunToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'BuatAkunToolStripMenuItem
        '
        Me.BuatAkunToolStripMenuItem.Name = "BuatAkunToolStripMenuItem"
        Me.BuatAkunToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BuatAkunToolStripMenuItem.Text = "Buat Akun"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.Brown
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarAplikasiToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Montserrat Thin ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(696, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELAMAT DATANG DI APLIKASI PENDATAAN MAHASISWA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(696, 450)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.MediumTurquoise
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-3, 24)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(910, 519)
        '
        'LabelWelcome
        '
        Me.LabelWelcome.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.LabelWelcome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LabelWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelWelcome.Font = New System.Drawing.Font("Montserrat Thin ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.Location = New System.Drawing.Point(0, 24)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(696, 37)
        Me.LabelWelcome.TabIndex = 5
        Me.LabelWelcome.Text = "Welcome"
        Me.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(215, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormBeranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 450)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormBeranda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beranda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormDosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BuatAkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelWelcome As System.Windows.Forms.Label
End Class
