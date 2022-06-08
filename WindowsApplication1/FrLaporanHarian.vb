Imports MySql.Data.MySqlClient
Public Class FrLaporanHarian
    Private Sub bttampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil.Click
        AxCrystalReport1.SelectionFormula = "totext({tbkunjungan.tanggal_kunjungan})='" & dtlaphar.Value & "'"
        AxCrystalReport1.ReportFileName = "laporankunjungan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class