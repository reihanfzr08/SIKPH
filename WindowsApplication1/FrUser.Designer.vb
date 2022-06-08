<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbjumlah = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvuser = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 113)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FORM USER KUNJUNGAN HARIAN"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(34, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NIP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(34, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(34, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(34, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Password"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(141, 159)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(100, 20)
        Me.txtnip.TabIndex = 7
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(141, 228)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 20)
        Me.txtuser.TabIndex = 8
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(141, 265)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(140, 20)
        Me.txtpass.TabIndex = 9
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(141, 195)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(140, 20)
        Me.txtnama.TabIndex = 10
        '
        'btbaru
        '
        Me.btbaru.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbaru.Location = New System.Drawing.Point(37, 342)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(76, 33)
        Me.btbaru.TabIndex = 15
        Me.btbaru.Text = "BARU"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btclose.Location = New System.Drawing.Point(750, 381)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(85, 32)
        Me.btclose.TabIndex = 16
        Me.btclose.Text = "KELUAR"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.Location = New System.Drawing.Point(134, 342)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(76, 33)
        Me.btsave.TabIndex = 17
        Me.btsave.Text = "SIMPAN"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.Location = New System.Drawing.Point(238, 342)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(76, 33)
        Me.btupdate.TabIndex = 18
        Me.btupdate.Text = "UBAH"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdelete.Location = New System.Drawing.Point(341, 342)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(76, 33)
        Me.btdelete.TabIndex = 19
        Me.btdelete.Text = "HAPUS"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(528, 388)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(197, 20)
        Me.txtcari.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(34, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "jumlah data"
        '
        'lbjumlah
        '
        Me.lbjumlah.AutoSize = True
        Me.lbjumlah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lbjumlah.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjumlah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbjumlah.Image = CType(resources.GetObject("lbjumlah.Image"), System.Drawing.Image)
        Me.lbjumlah.Location = New System.Drawing.Point(131, 393)
        Me.lbjumlah.Name = "lbjumlah"
        Me.lbjumlah.Size = New System.Drawing.Size(16, 18)
        Me.lbjumlah.TabIndex = 22
        Me.lbjumlah.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(131, 393)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(476, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cari"
        '
        'dgvuser
        '
        Me.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvuser.Location = New System.Drawing.Point(303, 125)
        Me.dgvuser.Name = "dgvuser"
        Me.dgvuser.Size = New System.Drawing.Size(544, 211)
        Me.dgvuser.TabIndex = 24
        '
        'FrUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(847, 432)
        Me.Controls.Add(Me.dgvuser)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbjumlah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrUser"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbjumlah As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvuser As System.Windows.Forms.DataGridView
End Class
