Imports System.Data.SqlClient

Public Class MasterManajer

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True


        Call Koneksi()
        Da = New SqlDataAdapter(" Select * From TBL_Manajer", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_Manajer")
        DataGridView1.DataSource = (Ds.Tables("TBL_Manajer"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
        TextBox3.PasswordChar = "X"

    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True

    End Sub
    Private Sub MasterManajer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        TextBox1.MaxLength = 5
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 30

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'INSERT
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua terisi")
            Else
                Call Koneksi()
                Dim SimpanData As String = " insert into TBL_Manajer values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New SqlCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah")
                Call kondisiAwal()
            End If

        End If
    End Sub
    'updat
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua terisi")
            Else

                Call Koneksi()
                Dim EditData As String = "Update TBL_Manajer set Nama_Manajer ='" & TextBox2.Text & "',Password ='" & TextBox3.Text & "',Level_MN='" & ComboBox1.Text & "'where Id_Manajer = '" & TextBox1.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diEdit")
                Call kondisiAwal()
            End If
        End If

    End Sub
    'delete
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "SIMPAN"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua terisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete TBL_Manajer  where id_Manajer='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di Hapus")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            Me.Close()
        Else
            Call kondisiAwal()

        End If

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("select * from TBL_Manajer where Id_Manajer = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Nama_Manajer")
                TextBox3.Text = Rd.Item("Password")
                ComboBox1.Text = Rd.Item("Level_MN")
            Else
                MsgBox("Data tidak ada")
            End If

        End If
    End Sub
End Class