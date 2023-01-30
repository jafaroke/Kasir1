Imports System.Data.SqlClient
Public Class MasterPemesan

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox1.Enabled = False
        TextBox3.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New SqlDataAdapter("select * From TBL_Pembeli", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_Pembeli")
        DataGridView1.DataSource = (Ds.Tables("TBL_Pembeli"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("PRIA")
        ComboBox1.Items.Add("WANITA")
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ComboBox1.Enabled = True
        TextBox3.Enabled = True


    End Sub

    Private Sub MasterPemesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        TextBox1.MaxLength = 50
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 50

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
            Call NoOtomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()

        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan semua terisi")
            Else
                Call Koneksi()
                Dim SimpanData As String = " insert into TBL_Pembeli values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "')"
                Cmd = New SqlCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah")
                Call kondisiAwal()
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan semua terisi")
            Else

                Call Koneksi()
                Dim EditData As String = "Update TBL_Pembeli set Nama='" & TextBox2.Text & "',Jenis_Kelamin ='" & ComboBox1.Text & "',Alamat ='" & TextBox3.Text & "'where Id_Pembeli = '" & TextBox1.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diEdit")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "SIMPAN"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan semua terisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete TBL_Pembeli  where Id_Pembeli='" & TextBox1.Text & "'"
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
    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * From TBL_Pembeli where Id_Pembeli in (select Max(Id_Pembeli) From TBL_Pembeli )", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PM" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "PM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("select * from TBL_Pembeli   where Id_Pembeli= '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Nama")
                ComboBox1.Text = Rd.Item("Jenis_Kelamin")
                TextBox3.Text = Rd.Item("Alamat")
            Else
                MsgBox("Data tidak ada")
            End If

        End If
    End Sub
End Class