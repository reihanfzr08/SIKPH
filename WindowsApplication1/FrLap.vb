Imports MySql.Data.MySqlClient
Public Class FrLap
    Private Sub FrLap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbulan.Items.Clear()
        cbbulan.Items.Add("01 - JANUARI")
        cbbulan.Items.Add("02 - FEBRUARI")
        cbbulan.Items.Add("03 - MARET")
        cbbulan.Items.Add("04 - APRIL")
        cbbulan.Items.Add("05 - MEI")
        cbbulan.Items.Add("06 - JUNI")
        cbbulan.Items.Add("07 - JULI")
        cbbulan.Items.Add("08 - AGUSTUS")
        cbbulan.Items.Add("09 - SEPTEMBER")
        cbbulan.Items.Add("10 - OKTOBER")
        cbbulan.Items.Add("11 - NOVEMBER")
        cbbulan.Items.Add("12 - DESEMBER")

        cbtahun.Items.Clear()
        cbtahun.Text = Date.Now.Year
        For i As Integer = 0 To 5
            cbtahun.Items.Add(Date.Now.Year - i)
        Next


        Label10.Text = "2021, 10, 27"
        Label11.Text = "2021, 10, 28"
        Label10.Text = Format(dtdarike.Value, "yyyy, MM, dd")
        Label11.Text = Format(dtsampaike.Value, "yyyy, MM, dd")

    End Sub
    Private Sub bttampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil.Click
        AxCrystalReport1.SelectionFormula = "{tbkunjungan.tanggal_kunjungan} in date (" & Label10.Text & ") to date (" & Label11.Text & ")"
        AxCrystalReport1.ReportFileName = "laporankunjunganrentang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1

    End Sub

    Private Sub dtdarike_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtdarike.ValueChanged
        Label10.Text = Format(dtdarike.Value, "yyyy, MM, dd")
    End Sub

    Private Sub dtsampaike_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsampaike.ValueChanged
        Label11.Text = Format(dtsampaike.Value, "yyyy, MM, dd")
    End Sub
    Private Sub bttampilbln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampilbln.Click
        If cbbulan.Text = "" Or cbtahun.Text = "" Then
            MsgBox("Silahkan Isi Bulan dan Tahunnya Terlebih Dahulu")
        Else
            AxCrystalReport1.SelectionFormula = "Month({tbkunjungan.tanggal_kunjungan})=" & Val(cbbulan.Text) & " and year({tbkunjungan.tanggal_kunjungan})=" & Val(cbtahun.Text)
            AxCrystalReport1.ReportFileName = "laporankunjunganbulantahun.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class