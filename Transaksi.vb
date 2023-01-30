Imports System.Data.SqlClient
Public Class Transaksi
    Dim tglsql As String
    Sub kondisiAwal()
        LBLNopesan.Text = ""
        LBLnama.Text = ""
        LBLjeniskelmain.Text = ""
        LBLalamat.Text = ""
        LBLTGGL.Text = Today
        LBLegawei.Text = Form1.STLabel4.Text
        TextBox1.Text = ""
        LBLNma.Text = ""
        LBLHarga.Text = ""
        TextBox2.Text = ""
        TextBox2.Enabled = False
        Label9.Text = ""
        TextBox1.Text = "MNU001"
        TextBox3.Text = ""
        Label8.Text = ""
        LblItem.Text = ""

    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        Call munculIDPembeli()
        Call NoOtomatis()
        Call DGVColom()
        Label8.Text = "0"


    End Sub
    Sub munculIDPembeli()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New SqlCommand(" Select * from TBL_Pembeli", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJAM.Text = TimeOfDay
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New SqlCommand("select * from TBL_Pembeli where id_Pembeli = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLnama.Text = Rd!Nama
            LBLjeniskelmain.Text = Rd!Jenis_Kelamin
            LBLalamat.Text = Rd!Alamat
        End If
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * From TBL_DetailTransakasi  where No_Jual in (select Max(No_Jual) From TBL_DetailTransakasi )", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PSN" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PSN" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNopesan.Text = UrutanKode
    End Sub
    Sub DGVColom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode_pesan")
        DataGridView1.Columns.Add("Nama", "Nama_Menu")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("jumlah", "jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("select * from TBL_Mnu where Kode_Menu = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Text = Rd.Item("Kode_Menu")
                LBLNma.Text = Rd.Item("Nama_Menu")
                LBLHarga.Text = Rd.Item("Harga")
                TextBox2.Enabled = True

            Else
                MsgBox("Data tidak ada")
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LBLHarga.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isi Kode Anda dan tekan Enter")

        Else
            DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLNma.Text, LBLHarga.Text, TextBox2.Text, Val(LBLHarga.Text) * Val(TextBox2.Text)})
            Call RumusTotal()
            Call rumusMecariItem()

        End If

    End Sub

    Sub RumusTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            Label8.Text = hitung

        Next
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox3.Text) < Val(Label8.Text) Then
                MsgBox("Uang anda kurang")
            ElseIf Val(TextBox3.Text) = Val(Label8.Text) Then
                Label9.Text = 0
            ElseIf Val(TextBox3.Text) > Val(Label8.Text) Then
                Label9.Text = Val(TextBox3.Text) - Val(Label8.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Sub rumusMecariItem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungItem = hitungItem + DataGridView1.Rows(i).Cells(3).Value
            LblItem.Text = hitungItem

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label9.Text = "" Or LBLnama.Text = "" Or Label8.Text = "" Then
            MsgBox("Transaksi tidak ada ,silahkan lakukan transaksi terlebih dahulu!!")
        Else
            tglsql = Format(Today, "yyyy-MM-dd ")
            Call Koneksi()
            Dim Simpan As String = "insert into TBL_DetailTransakasi values ('" & LBLNopesan.Text & "','" & tglsql & "','" & LBLJAM.Text & "','" & LblItem.Text & "','" & Label8.Text & "','" & TextBox3.Text & "','" & Label9.Text & "','" & ComboBox1.Text & "','" & Form1.STLabel2.Text & "')"
            Cmd = New SqlCommand(Simpan, Conn)
            Cmd.ExecuteNonQuery()
            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into TBL_DETELTRANSAKSI  values ('" & LBLNopesan.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New SqlCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Call Koneksi()
                Cmd = New SqlCommand("select * from TBL_Mnu where Kode_Menu = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim kurangistok As String = "Update TBL_Mnu set Stok = '" & Rd.Item("Stok") - DataGridView1.Rows(Baris).Cells(4).Value & "' where Kode_Menu= '" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New SqlCommand(kurangistok, Conn)
                Cmd.ExecuteNonQuery()

            Next
            Call kondisiAwal()
            MsgBox("transaksi telah berhasil")



        End If
    End Sub

    Private Sub LBLTGGL_Click(sender As Object, e As EventArgs) Handles LBLTGGL.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call kondisiAwal()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class