Public Class FrMenu
    Sub aktiff()
        datapasienToolStripMenuItem.Enabled = True
        datapetugasToolStripMenuItem.Enabled = True
        datakunjunganToolStripMenuItem.Enabled = True
        LaporanHarianKunjunganPasienToolStripMenuItem.Enabled = True
        LaporanBulananTahunanKunjunganPasienToolStripMenuItem.Enabled = True
        LaporanPerKategoriKunjunganPasienToolStripMenuItem.Enabled = True
        logoutToolStripMenuItem.Enabled = True
        loginToolStripMenuItem.Enabled = False
    End Sub
    Sub nonaktif()
        lbnama.Text = ""
        datapasienToolStripMenuItem.Enabled = False
        datapetugasToolStripMenuItem.Enabled = False
        datakunjunganToolStripMenuItem.Enabled = False
        LaporanHarianKunjunganPasienToolStripMenuItem.Enabled = False
        LaporanBulananTahunanKunjunganPasienToolStripMenuItem.Enabled = False
        LaporanPerKategoriKunjunganPasienToolStripMenuItem.Enabled = False
        logoutToolStripMenuItem.Enabled = False
        loginToolStripMenuItem.Enabled = True
    End Sub
    Private Sub loginToolstripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginToolStripMenuItem.Click
        Frlogin.Show()
        'Me.Hide()
    End Sub

    Private Sub dataPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datapasienToolStripMenuItem.Click
        FrPasien.Show()
        'Me.Hide()
    End Sub

    Private Sub datapetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datapetugasToolStripMenuItem.Click
        FrPetugas.Show()
        'Me.Hide()
    End Sub
    Private Sub datakunjunganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datakunjunganToolStripMenuItem.Click
        FrKunjungan.Show()
        'Me.Hide()
    End Sub

    Private Sub logoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoutToolStripMenuItem.Click
        nonaktif()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        FrUser.Show()
        'Me.Hide()

    End Sub
    Private Sub FrMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nonaktif()

    End Sub

    Private Sub LaporanHarianKunjunganPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHarianKunjunganPasienToolStripMenuItem.Click
        FrLaporanHarian.Show()
        'Me.hide()
    End Sub

    Private Sub LaporanBulananTahunanKunjunganPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanBulananTahunanKunjunganPasienToolStripMenuItem.Click
        FrLap.Show()
        'Me.hide()
    End Sub

    Private Sub LaporanPerKategoriKunjunganPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPerKategoriKunjunganPasienToolStripMenuItem.Click
        FrLaporan.Show()
        'Me.hide()
    End Sub
End Class