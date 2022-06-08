Imports MySql.Data.MySqlClient
Public Class FrLaporan
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Silahkan Isi data Berdasarkan jenis kelamin")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbkunjungan where jenis_kelamin=@jenis_kelamin", cn)
            cmd.Parameters.AddWithValue("@jenis_kelamin", ComboBox1.SelectedItem)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Tidak Ada data !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbkunjungan.jenis_kelamin})='" & ComboBox1.SelectedItem & "'"
            AxCrystalReport1.ReportFileName = "laporankunjunganrentang.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub
        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            If ComboBox2.SelectedItem = "" Then
                MsgBox("Silahkan Isi data Berdasarkan Wilayah")
            Else
                koneksi()
            cmd = New MySqlCommand("select*from tbkunjungan where wilayah=@wilayah", cn)
            cmd.Parameters.AddWithValue("@wilayah", ComboBox2.SelectedItem)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows = True Then
                    MsgBox("Tidak Ada data !!", vbOKOnly + vbCritical, "Hang")
                    dr.Close()
                Else
                End If
            AxCrystalReport1.SelectionFormula = "totext({tbkunjungan.wilayah})='" & ComboBox2.SelectedItem & "'"
                AxCrystalReport1.ReportFileName = "laporankunjunganrentang.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1
            End If
        End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox3.SelectedItem = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Cara Bayar")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbkunjungan where cara_bayar=@cara_bayar", cn)
            cmd.Parameters.AddWithValue("@cara_bayar", ComboBox3.SelectedItem)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Tidak Ada data !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbkunjungan.cara_bayar})='" & ComboBox3.SelectedItem & "'"
            AxCrystalReport1.ReportFileName = "laporankunjunganrentang.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox4.SelectedItem = "" Then
            MsgBox("Silahkan Isi data Berdasarkan poli")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbkunjungan where poli=@poli", cn)
            cmd.Parameters.AddWithValue("@poli", ComboBox4.SelectedItem)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Tidak Ada data !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbkunjungan.poli})='" & ComboBox4.SelectedItem & "'"
            AxCrystalReport1.ReportFileName = "laporankunjunganrentang.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class