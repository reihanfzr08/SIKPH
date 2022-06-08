Imports MySql.Data.MySqlClient
Public Class FrUser
    Sub see_auth()
        cmd = New MySqlCommand("select*from tbuser", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        dgvuser.DataSource = tb
    End Sub
    Private Sub FrUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        see_auth()
    End Sub
    Private Sub txtnip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnip.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbuser where nip=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtnip.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data user tersedia !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbuser (nip,nama,username,password)values(@nip,@nama,@username,@password)", cn)
            cmd.Parameters.AddWithValue("@nip", txtnip.Text)
            cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            cmd.Parameters.AddWithValue("@username", txtuser.Text)
            cmd.Parameters.AddWithValue("@password", txtpass.Text)
            cmd.ExecuteNonQuery()
            txtnip.Clear()
            txtnama.Clear()
            txtuser.Clear()
            txtpass.Clear()
            MsgBox("Data User Berhasil Disimpan !", vbOKOnly + vbInformation, "sukses")
        End If
        see_auth()
    End Sub

    Private Sub dgvuser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvuser.CellContentClick

    End Sub
    Private Sub dgvuser_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvuser.CellFormatting
        dgvuser.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub dgvuser_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvuser.CellContentDoubleClick

    End Sub

    Private Sub dgvuser_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvuser.CellDoubleClick
        txtnip.Text = dgvuser.CurrentRow.Cells(0).Value.ToString
        txtnama.Text = dgvuser.CurrentRow.Cells(1).Value.ToString
        txtuser.Text = dgvuser.CurrentRow.Cells(2).Value.ToString
        txtpass.Text = dgvuser.CurrentRow.Cells(3).Value.ToString
        btsave.Enabled = False
        txtnip.Enabled = True
        txtuser.Focus()

    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbuser set nama=@nama,username=@username,password=@password where nip=@nip", cn)
        cmd.Parameters.AddWithValue("@nip", txtnip.Text)
        cmd.Parameters.AddWithValue("@nama", txtnama.Text)
        cmd.Parameters.AddWithValue("@username", txtuser.Text)
        cmd.Parameters.AddWithValue("@password", txtpass.Text)
        cmd.ExecuteNonQuery()
        see_auth()
        txtnip.Clear()
        txtnama.Clear()
        txtuser.Clear()
        txtpass.Clear()
        txtnip.Enabled = True
        btsave.Enabled = True
        MsgBox("Data User Berhasil di update !", vbOKOnly + vbInformation, "sukses")

    End Sub
    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbuser where nip=@nip", cn)
        cmd.Parameters.AddWithValue("@nip", txtnip.Text)
        cmd.ExecuteNonQuery()
        see_auth()
        txtnip.Clear()
        txtnama.Clear()
        txtuser.Clear()
        txtpass.Clear()
        txtnip.Enabled = True
        btsave.Enabled = True
        MsgBox("Data User Berhasil Dihapuss !", vbOKOnly + vbInformation, "sukses duniawi entushiast")
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            see_auth()
        Else
            cmd = New MySqlCommand("select*from tbuser where nip like @nip or nama like @nama or username like @username limit 10", cn)
            cmd.Parameters.AddWithValue("@nip", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@nama", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@username", txtcari.Text & "%")
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(cmd)
            tb = New DataTable
            da.Fill(tb)
            dgvuser.DataSource = tb
            lbjumlah.Text = dgvuser.RowCount - 1
        End If
    End Sub
    Private Sub lbjumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbjumlah.Click

    End Sub


    Private Sub btclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Close()
    End Sub

    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
End Class