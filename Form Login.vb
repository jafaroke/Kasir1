Imports System.Data.SqlClient
Public Class Form_Login
    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "PGW01"
        TextBox2.Text = "ADMIN"
        TextBox2.PasswordChar = "X"

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
    Sub terbuka()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogoutToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("Select * From TBL_Pegawe where id_Pegawai ='" & TextBox1.Text & "' and Password_Pegawai ='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call terbuka()
            Form1.STLabel2.Text = Rd!id_Pegawai
            Form1.STLabel4.Text = Rd!Nama_Pegawai
            Form1.STLabel6.Text = Rd!Level_pegawai
        Else
            MsgBox("Maaf Kode dan Pasword salah!")

        End If

    End Sub


End Class