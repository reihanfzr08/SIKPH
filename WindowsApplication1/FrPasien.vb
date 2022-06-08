Imports MySql.Data.MySqlClient
Public Class FrPasien
    Sub see_pasien()
        cmd = New MySqlCommand("select*from tbpasien", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Private Sub FrPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        see_pasien()
        dtbirth.Format = DateTimePickerFormat.Custom
        dtbirth.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub txtumur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtumur.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnotelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotelepon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnobpjs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnobpjs.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbpasien where no_rm=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtnorm.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data pasien ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbpasien values(@no_rm,@nama_pasien,@jenis_kelamin,@tempat_lahir,@tanggal_lahir,@umur,@alamat,@no_telepon,@no_bpjs)", cn)
            cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)
            cmd.Parameters.AddWithValue("@nama_pasien", txtnampas.Text)
            cmd.Parameters.AddWithValue("@jenis_kelamin", cbjekel.SelectedItem)
            cmd.Parameters.AddWithValue("@tempat_lahir", txttempatlahir.Text)
            cmd.Parameters.AddWithValue("@tanggal_lahir", dtbirth.Text)
            cmd.Parameters.AddWithValue("@umur", txtumur.Text)
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@no_telepon", txtnotelepon.Text)
            cmd.Parameters.AddWithValue("@no_bpjs", txtnobpjs.Text)
            cmd.ExecuteNonQuery()
            txtnorm.Clear()
            txtnampas.Clear()
            cbjekel.SelectedIndex = -1
            dtbirth.Text = ""
            txtumur.Clear()
            txtalamat.Clear()
            txtalamat.Clear()
            txtnotelepon.Clear()
            txtnobpjs.Clear()
            MsgBox("Data Pasien Berhasil Disimpan!", vbOKOnly + vbInformation, "sukses")
        End If
        see_pasien()
    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtnorm.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtnampas.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        cbjekel.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txttempatlahir.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        dtbirth.Text = DataGridView1.CurrentRow.Cells(4).Value.date
        txtumur.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtalamat.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtnotelepon.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtnobpjs.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        btsave.Enabled = False
        txtnorm.Enabled = False
        txtnampas.Focus()
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbpasien set nama_pasien=@nama_pasien, jenis_kelamin=@jenis_kelamin, tempat_lahir=@tempat_lahir, tanggal_lahir=@tanggal_lahir, umur=@umur, alamat=@alamat, no_telepon=@no_telepon, no_bpjs=@no_bpjs where no_rm=@no_rm", cn)
        cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)
        cmd.Parameters.AddWithValue("@nama_pasien", txtnampas.Text)
        cmd.Parameters.AddWithValue("@jenis_kelamin", cbjekel.SelectedItem)
        cmd.Parameters.AddWithValue("@tempat_lahir", txttempatlahir.Text)
        cmd.Parameters.AddWithValue("@tanggal_lahir", dtbirth.Text)
        cmd.Parameters.AddWithValue("@umur", txtumur.Text)
        cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@no_telepon", txtnotelepon.Text)
        cmd.Parameters.AddWithValue("@no_bpjs", txtnobpjs.Text)
        cmd.ExecuteNonQuery()
        see_pasien()
        txtnorm.Clear()
        txtnampas.Clear()
        cbjekel.SelectedIndex = -1
        dtbirth.Text = ""
        txtumur.Clear()
        txtalamat.Clear()
        txtalamat.Clear()
        txtnotelepon.Clear()
        txtnobpjs.Clear()
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Pasien Berhasil di Update !", vbOKOnly + vbInformation, "sukses")

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbpasien where no_rm=@no_rm", cn)
        cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)
        cmd.ExecuteNonQuery()
        see_pasien()
        txtnorm.Clear()
        txtnampas.Clear()
        cbjekel.SelectedIndex = -1
        dtbirth.Text = ""
        txtumur.Clear()
        txtalamat.Clear()
        txtalamat.Clear()
        txtnotelepon.Clear()
        txtnobpjs.Clear()
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data pasien Berhasil Dihapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            see_pasien()
        Else
            cmd = New MySqlCommand("select*from tbpasien where no_rm like @no_rm or nama_pasien like @nama_pasien or jenis_kelamin like @jenis_kelamin or tempat_lahir like @tempat_lahir or tanggal_lahir like @tanggal_lahir or umur like @umur or alamat like @alamat or no_telepon like @no_telepon or no_bpjs like @no_bpjs limit 10", cn)
            cmd.Parameters.AddWithValue("@no_rm", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@nama_pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@jenis_kelamin", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@tempat_lahir", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@tanggal_lahir", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@umur", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@alamat", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@no_telepon", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@no_bpjs", txtcari.Text & "%")
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(cmd)
            tb = New DataTable
            da.Fill(tb)
            DataGridView1.DataSource = tb
            lbjumlah.Text = DataGridView1.RowCount - 1
        End If
    End Sub

    Private Sub lbjumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbjumlah.Click

    End Sub
    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

End Class
