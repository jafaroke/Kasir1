Imports System.Data.SqlClient 'untuk mengkoneksikan yang akan dibagikan di seluruh form
Module Module1
        Public Conn As SqlConnection 'dipulickkan agar berlaku untuk semua form dan sifatnya terbuka
        Public Da As SqlDataAdapter
        Public Ds As DataSet
        Public Rd As SqlDataReader
        Public Cmd As SqlCommand
    Public MyDB As String
    Public Sub Koneksi() 'koneksi = variabel
        'Mydb= server database 
        MyDB = "Data Source=DESKTOP-1AU1LCN\FARIT;Initial catalog=Kasir;Integrated Security=True"
        Conn = New SqlConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then Conn.Open()

        End Sub

    End Module

