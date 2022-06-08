Imports MySql.Data.MySqlClient
Public Class Frlogin
    Sub see_auth()
        cmd = New MySqlCommand("select*from tbuser", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
    End Sub
    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        cmd = New MySqlCommand("select*from tbuser where username=@Username and Password=@Password", cn)
        cmd.Parameters.AddWithValue("@Username", txtuser.Text)
        cmd.Parameters.AddWithValue("@Password", txtpass.Text)

        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Login Berhasil !")
            Close()
            FrMenu.aktiff()
            FrMenu.lbnama.Text = "Selamat Datang_" & dr.Item(1)
            dr.Close()
        Else
            MsgBox("Login Gagal !")
            dr.Close()
        End If
        see_auth()

    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Close()

    End Sub
    Private Sub Frlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        see_auth()
    End Sub
End Class