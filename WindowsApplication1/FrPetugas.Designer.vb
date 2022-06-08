<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPetugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrPetugas))
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.txtnampet = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnotelepon = New System.Windows.Forms.TextBox()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbjabatan = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.lbjumlah = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btdelete
        '
        Me.btdelete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdelete.Location = New System.Drawing.Point(341, 387)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(76, 33)
        Me.btdelete.TabIndex = 35
        Me.btdelete.Text = "HAPUS"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.Location = New System.Drawing.Point(238, 387)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(76, 33)
        Me.btupdate.TabIndex = 34
        Me.btupdate.Text = "UBAH"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.Location = New System.Drawing.Point(134, 387)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(76, 33)
        Me.btsave.TabIndex = 33
        Me.btsave.Text = "SIMPAN"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btclose.Location = New System.Drawing.Point(749, 380)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(85, 32)
        Me.btclose.TabIndex = 32
        Me.btclose.Text = "KELUAR"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbaru.Location = New System.Drawing.Point(37, 387)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(76, 33)
        Me.btbaru.TabIndex = 31
        Me.btbaru.Text = "BARU"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'txtnampet
        '
        Me.txtnampet.Location = New System.Drawing.Point(146, 168)
        Me.txtnampet.Name = "txtnampet"
        Me.txtnampet.Size = New System.Drawing.Size(140, 20)
        Me.txtnampet.TabIndex = 29
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(146, 304)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(250, 69)
        Me.txtalamat.TabIndex = 28
        '
        'txtnotelepon
        '
        Me.txtnotelepon.Location = New System.Drawing.Point(146, 267)
        Me.txtnotelepon.Name = "txtnotelepon"
        Me.txtnotelepon.Size = New System.Drawing.Size(100, 20)
        Me.txtnotelepon.TabIndex = 27
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(146, 132)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(100, 20)
        Me.txtnip.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(39, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(39, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "No. Telp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(423, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FORM DATA PETUGAS KUNJUNGAN HARIAN"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(734, 3)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(39, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Nama Petugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(39, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "NIP"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(434, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(400, 242)
        Me.DataGridView1.TabIndex = 21
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
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 113)
        Me.Panel1.TabIndex = 20
        '
        'dtbirth
        '
        Me.dtbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbirth.Location = New System.Drawing.Point(146, 229)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(200, 20)
        Me.dtbirth.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(39, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 18)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Tanggal Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(39, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Jabatan"
        '
        'cbjabatan
        '
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Items.AddRange(New Object() {"Staff Umum", "Staff Gigi", "Staff KIA", "Staff Anak", "Staff Medrec", "Kepala Medrec"})
        Me.cbjabatan.Location = New System.Drawing.Point(146, 199)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(121, 21)
        Me.cbjabatan.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(448, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 18)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(496, 381)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(153, 20)
        Me.txtcari.TabIndex = 40
        '
        'lbjumlah
        '
        Me.lbjumlah.AutoSize = True
        Me.lbjumlah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lbjumlah.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjumlah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbjumlah.Image = CType(resources.GetObject("lbjumlah.Image"), System.Drawing.Image)
        Me.lbjumlah.Location = New System.Drawing.Point(547, 410)
        Me.lbjumlah.Name = "lbjumlah"
        Me.lbjumlah.Size = New System.Drawing.Size(16, 18)
        Me.lbjumlah.TabIndex = 45
        Me.lbjumlah.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(448, 410)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 18)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Jumlah data :"
        '
        'FrPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(851, 432)
        Me.Controls.Add(Me.lbjumlah)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.cbjabatan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtbirth)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.txtnampet)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnotelepon)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrPetugas"
        Me.Text = "FormPetugas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents txtnampet As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnotelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents lbjumlah As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
