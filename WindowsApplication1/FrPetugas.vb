Imports MySql.Data.MySqlClient
Public Class FrPetugas
    Sub see_petugas()
        cmd = New MySqlCommand("select*from tbpetugas", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Private Sub FrPetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        see_petugas()
        dtbirth.Format = DateTimePickerFormat.Custom
        dtbirth.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub txtnip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnip.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnotelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotelepon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbpetugas where nip=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtnip.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data petugas ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbpetugas values(@nip,@nama_petugas,@jabatan,@tanggal_lahir,@nomor_telepon,@alamat)", cn)
            cmd.Parameters.AddWithValue("@nip", txtnip.Text)
            cmd.Parameters.AddWithValue("@nama_petugas", txtnampet.Text)
            cmd.Parameters.AddWithValue("@jabatan", cbjabatan.SelectedItem)
            cmd.Parameters.AddWithValue("@tanggal_lahir", dtbirth.Text)
            cmd.Parameters.AddWithValue("@nomor_telepon", txtnotelepon.Text)
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            cmd.ExecuteNonQuery()
            txtnip.Clear()
            txtnampet.Clear()
            cbjabatan.SelectedIndex = -1
            dtbirth.Text = ""
            txtnotelepon.Clear()
            txtalamat.Clear()
            MsgBox("Data Pasien Berhasil Disimpan!", vbOKOnly + vbInformation, "sukses")
        End If
        see_petugas()
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
        txtnip.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtnampet.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        cbjabatan.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        dtbirth.Text = DataGridView1.CurrentRow.Cells(3).Value.date
        txtnotelepon.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtalamat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        btsave.Enabled = False
        txtnip.Enabled = False
        txtnampet.Focus()
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbpetugas set nama_petugas=@nama_petugas, jabatan=@jabatan, tanggal_lahir=@tanggal_lahir, nomor_telepon=@nomor_telepon, alamat=@alamat where nip=@nip", cn)
        cmd.Parameters.AddWithValue("@nip", txtnip.Text)
        cmd.Parameters.AddWithValue("@nama_petugas", txtnampet.Text)
        cmd.Parameters.AddWithValue("@jabatan", cbjabatan.SelectedItem)
        cmd.Parameters.AddWithValue("@tanggal_lahir", dtbirth.Text)
        cmd.Parameters.AddWithValue("@nomor_telepon", txtnotelepon.Text)
        cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
        cmd.ExecuteNonQuery()
        see_petugas()
        txtnip.Clear()
        txtnampet.Clear()
        cbjabatan.SelectedIndex = -1
        dtbirth.Text = ""
        txtnotelepon.Clear()
        txtalamat.Clear()
        txtnip.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Pasien Berhasil di Update !", vbOKOnly + vbInformation, "sukses")

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbpetugas where nip=@nip", cn)
        cmd.Parameters.AddWithValue("@no_rm", txtnip.Text)
        cmd.ExecuteNonQuery()
        see_petugas()
        txtnip.Clear()
        txtnampet.Clear()
        cbjabatan.SelectedIndex = -1
        dtbirth.Text = ""
        txtnotelepon.Clear()
        txtalamat.Clear()
        txtnip.Enabled = True
        btsave.Enabled = True
        MsgBox("Data pasien Berhasil Dihapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            see_petugas()
        Else
            cmd = New MySqlCommand("select*from tbpetugas where nip like @nip or nama_petugas like @nama_petugas or jabatan like @jabatan or tanggal_lahir like @tanggal_lahir or alamat like @alamat or nomor_telepon like @nomor_telepon limit 10", cn)
            cmd.Parameters.AddWithValue("@nip", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@nama_petugas", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@jabatan", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@tanggal_lahir", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@alamat", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@nomor_telepon", txtcari.Text & "%")
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

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtbirth.ValueChanged

    End Sub
End Class
