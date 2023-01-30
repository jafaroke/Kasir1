Public Class Form1
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkunci()
        STLabel10.Text = Today
    End Sub

    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form_Login.ShowDialog()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call terkunci()

    End Sub

    Private Sub ManajerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajerToolStripMenuItem.Click
        MasterPegawai.ShowDialog()

    End Sub

    Private Sub MenuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem1.Click
        MasterManajer.ShowDialog()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        MasterMenu.ShowDialog()

    End Sub

    Private Sub PemesanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemesanToolStripMenuItem.Click
        MasterPemesan.ShowDialog()

    End Sub

    Private Sub PesanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PesanToolStripMenuItem1.Click
        Transaksi.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        STLabel8.Text = TimeOfDay
    End Sub
End Class
