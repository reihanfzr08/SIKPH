<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMenu))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datapasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datapetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datakunjunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanHarianKunjunganPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBulananTahunanKunjunganPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPerKategoriKunjunganPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(714, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 113)
        Me.Panel1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FORM MENU KUNJUNGAN HARIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kota Bandung, Jawa Barat 40213"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jl. Mekar Hegar No.1, Cijerah, Kec. Bandung Kulon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UPT PUSKESMAS CIJERAH"
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbnama.Location = New System.Drawing.Point(310, 166)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(39, 13)
        Me.lbnama.TabIndex = 22
        Me.lbnama.Text = "Label5"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DataToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 117)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(242, 24)
        Me.MenuStrip2.TabIndex = 23
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loginToolStripMenuItem, Me.logoutToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.loginToolStripMenuItem.Text = "Login"
        '
        'logoutToolStripMenuItem
        '
        Me.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
        Me.logoutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.logoutToolStripMenuItem.Text = "Logout"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.datapasienToolStripMenuItem, Me.datapetugasToolStripMenuItem, Me.datakunjunganToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'datapasienToolStripMenuItem
        '
        Me.datapasienToolStripMenuItem.Name = "datapasienToolStripMenuItem"
        Me.datapasienToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.datapasienToolStripMenuItem.Text = "Data Pasien"
        '
        'datapetugasToolStripMenuItem
        '
        Me.datapetugasToolStripMenuItem.Name = "datapetugasToolStripMenuItem"
        Me.datapetugasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.datapetugasToolStripMenuItem.Text = "Data Petugas"
        '
        'datakunjunganToolStripMenuItem
        '
        Me.datakunjunganToolStripMenuItem.Name = "datakunjunganToolStripMenuItem"
        Me.datakunjunganToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.datakunjunganToolStripMenuItem.Text = "Data Kunjungan Medrec"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHarianKunjunganPasienToolStripMenuItem, Me.LaporanBulananTahunanKunjunganPasienToolStripMenuItem, Me.LaporanPerKategoriKunjunganPasienToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.TransaksiToolStripMenuItem.Text = "Laporan"
        '
        'LaporanHarianKunjunganPasienToolStripMenuItem
        '
        Me.LaporanHarianKunjunganPasienToolStripMenuItem.Name = "LaporanHarianKunjunganPasienToolStripMenuItem"
        Me.LaporanHarianKunjunganPasienToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.LaporanHarianKunjunganPasienToolStripMenuItem.Text = "Laporan Harian Kunjungan Pasien"
        '
        'LaporanBulananTahunanKunjunganPasienToolStripMenuItem
        '
        Me.LaporanBulananTahunanKunjunganPasienToolStripMenuItem.Name = "LaporanBulananTahunanKunjunganPasienToolStripMenuItem"
        Me.LaporanBulananTahunanKunjunganPasienToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.LaporanBulananTahunanKunjunganPasienToolStripMenuItem.Text = "Laporan Bulanan&Tahunan Kunjungan Pasien"
        '
        'LaporanPerKategoriKunjunganPasienToolStripMenuItem
        '
        Me.LaporanPerKategoriKunjunganPasienToolStripMenuItem.Name = "LaporanPerKategoriKunjunganPasienToolStripMenuItem"
        Me.LaporanPerKategoriKunjunganPasienToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.LaporanPerKategoriKunjunganPasienToolStripMenuItem.Text = "Laporan Per-Kategori Kunjungan Pasien"
        '
        'FrMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 476)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.lbnama)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrMenu"
        Me.Text = "FrMenu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datapasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datapetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datakunjunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHarianKunjunganPasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanBulananTahunanKunjunganPasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPerKategoriKunjunganPasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
