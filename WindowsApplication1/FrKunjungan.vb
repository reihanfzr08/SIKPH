Imports MySql.Data.MySqlClient
Public Class FrKunjungan
    Sub see_kunjungan()
        cmd = New MySqlCommand("select*from tbkunjungan", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Private Sub FrKunjunganLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        see_kunjungan()
        dtkunjung.Format = DateTimePickerFormat.Custom
        dtkunjung.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtumur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtumur.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtrt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrt.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtrw_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrw.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnorm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnorm.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New MySqlCommand("select*from tbpasien where no_rm=@no_rm", cn)
            cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txtnampas.Text = dr.Item(1)
                cbjekel.Text = dr.Item("jenis_kelamin")
                txtumur.Text = dr.Item("umur")
                txtalamat.Text = dr.Item("alamat")
                dr.Close()
            Else
                dr.Close()
                MsgBox("data tidak ditemukan!!", vbOKOnly + vbCritical, "eror")
            End If
        End If
    End Sub
    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbkunjungan where no=@a and no_rm=@no_rm", cn)
        cmd.Parameters.AddWithValue("@a", txtno.Text)
        cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)

        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data kunjungan ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbkunjungan values(@no,@no_reg,@no_rm,@nama_pasien,@jenis_kelamin,@umur,@alamat,@rt,@rw,@wilayah,@cara_bayar,@poli,@petugas,@tanggal_kunjungan)", cn)
            cmd.Parameters.AddWithValue("@no", txtno.Text)
            cmd.Parameters.AddWithValue("@no_reg", cbnoreg.SelectedItem)
            cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)
            cmd.Parameters.AddWithValue("@nama_pasien", txtnampas.Text)
            cmd.Parameters.AddWithValue("@jenis_kelamin", cbjekel.SelectedItem)
            cmd.Parameters.AddWithValue("@umur", txtumur.Text)
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@rt", txtrt.Text)
            cmd.Parameters.AddWithValue("@rw", txtrw.Text)
            cmd.Parameters.AddWithValue("@wilayah", cbwilayah.SelectedItem)
            cmd.Parameters.AddWithValue("@cara_bayar", cbcarabayar.SelectedItem)
            cmd.Parameters.AddWithValue("@poli", cbpoli.SelectedItem)
            cmd.Parameters.AddWithValue("@petugas", cbpetugas.SelectedItem)
            cmd.Parameters.AddWithValue("@tanggal_kunjungan", dtkunjung.Text)
            cmd.ExecuteNonQuery()
            txtno.Clear()
            cbnoreg.SelectedIndex = -1
            txtnorm.Clear()
            txtnampas.Clear()
            cbjekel.SelectedIndex = -1
            txtumur.Clear()
            txtalamat.Clear()
            txtrt.Clear()
            txtrw.Clear()
            cbwilayah.SelectedIndex = -1
            cbcarabayar.SelectedIndex = -1
            cbpoli.SelectedIndex = -1
            cbpetugas.SelectedIndex = -1
            dtkunjung.Text = ""
            MsgBox("Data kunjungan Berhasil Disimpan!", vbOKOnly + vbInformation, "sukses")
        End If
        see_kunjungan()
    End Sub
    Private Sub bttutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttutup.Click
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
        txtno.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        cbnoreg.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtnorm.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtnampas.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        cbjekel.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtumur.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtalamat.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtrt.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtrw.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        cbwilayah.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        cbcarabayar.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        cbpoli.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        cbpetugas.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        dtkunjung.Text = DataGridView1.CurrentRow.Cells(13).Value.date
        btsave.Enabled = False
        txtno.Enabled = False
        txtnorm.Focus()
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbkunjungan set no_reg=@no_reg, no_rm=@no_rm, nama_pasien=@nama_pasien, jenis_kelamin=@jenis_kelamin, umur=@umur, alamat=@alamat, rt=@rt, rw=@rw, wilayah=@wilayah, cara_bayar=@cara_bayar, poli=@poli, petugas=@petugas, tanggal_kunjungan=@tanggal_kunjungan where no=@no", cn)
        cmd.Parameters.AddWithValue("@no", txtno.Text)
        cmd.Parameters.AddWithValue("@no_reg", cbnoreg.SelectedItem)
        cmd.Parameters.AddWithValue("@no_rm", txtnorm.Text)
        cmd.Parameters.AddWithValue("@nama_pasien", txtnampas.Text)
        cmd.Parameters.AddWithValue("@jenis_kelamin", cbjekel.SelectedItem)
        cmd.Parameters.AddWithValue("@umur", txtumur.Text)
        cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@rt", txtrt.Text)
        cmd.Parameters.AddWithValue("@rw", txtrw.Text)
        cmd.Parameters.AddWithValue("@wilayah", cbwilayah.SelectedItem)
        cmd.Parameters.AddWithValue("@cara_bayar", cbcarabayar.SelectedItem)
        cmd.Parameters.AddWithValue("@poli", cbpoli.SelectedItem)
        cmd.Parameters.AddWithValue("@petugas", cbpetugas.SelectedItem)
        cmd.Parameters.AddWithValue("@tanggal_kunjungan", dtkunjung.Text)
        cmd.ExecuteNonQuery()
        see_kunjungan()
        txtno.Clear()
        cbnoreg.SelectedIndex = -1
        txtnorm.Clear()
        txtnampas.Clear()
        cbjekel.SelectedIndex = -1
        txtumur.Clear()
        txtalamat.Clear()
        txtrt.Clear()
        txtrw.Clear()
        cbwilayah.SelectedIndex = -1
        cbcarabayar.SelectedIndex = -1
        cbpoli.SelectedIndex = -1
        cbpetugas.SelectedIndex = -1
        dtkunjung.Text = ""
        MsgBox("Data Kunjungan Berhasil di Update !", vbOKOnly + vbInformation, "sukses")

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbkunjungan where no=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtno.Text)
        cmd.ExecuteNonQuery()
        see_kunjungan()
        txtno.Clear()
        cbnoreg.SelectedIndex = -1
        txtnorm.Clear()
        txtnampas.Clear()
        cbjekel.SelectedIndex = -1
        txtumur.Clear()
        txtalamat.Clear()
        txtrt.Clear()
        txtrw.Clear()
        cbwilayah.SelectedIndex = -1
        cbcarabayar.SelectedIndex = -1
        cbpoli.SelectedIndex = -1
        cbpetugas.SelectedIndex = -1
        dtkunjung.Text = ""
        txtno.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Kunjungan Berhasil Dihapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            see_kunjungan()
        Else
            cmd = New MySqlCommand("select*from tbkunjungan where no_reg like @no_reg or no_rm like @no_rm or nama_pasien like @nama_pasien or jenis_kelamin like @jenis_kelamin or umur like @umur or alamat like @alamat or rt like @rt or rw like @rw or wilayah like @wilayah or cara_bayar like @cara_bayar or poli like @poli or petugas like @petugas or tanggal_kunjungan like @tanggal_kunjungan limit 10", cn)
            cmd.Parameters.AddWithValue("@no", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@no_reg", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@no_rm", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@nama_pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@jenis_kelamin", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@umur", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@alamat", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@rt", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@rw", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@wilayah", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@cara_bayar", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@poli", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@petugas", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@tanggal_kunjungan", txtcari.Text & "%")
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
