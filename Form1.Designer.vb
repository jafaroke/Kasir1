<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemesanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(341, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManajerToolStripMenuItem, Me.MenuToolStripMenuItem1, Me.MenuToolStripMenuItem, Me.PemesanToolStripMenuItem})
        Me.MasterToolStripMenuItem.Image = CType(resources.GetObject("MasterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(81, 23)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'ManajerToolStripMenuItem
        '
        Me.ManajerToolStripMenuItem.Image = CType(resources.GetObject("ManajerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManajerToolStripMenuItem.Name = "ManajerToolStripMenuItem"
        Me.ManajerToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.ManajerToolStripMenuItem.Text = "Pegawai"
        '
        'MenuToolStripMenuItem1
        '
        Me.MenuToolStripMenuItem1.Image = CType(resources.GetObject("MenuToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem1.Name = "MenuToolStripMenuItem1"
        Me.MenuToolStripMenuItem1.Size = New System.Drawing.Size(134, 24)
        Me.MenuToolStripMenuItem1.Text = "Manejer"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PemesanToolStripMenuItem
        '
        Me.PemesanToolStripMenuItem.Image = CType(resources.GetObject("PemesanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PemesanToolStripMenuItem.Name = "PemesanToolStripMenuItem"
        Me.PemesanToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.PemesanToolStripMenuItem.Text = "Pemesan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesanToolStripMenuItem1})
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(101, 23)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PesanToolStripMenuItem1
        '
        Me.PesanToolStripMenuItem1.Image = CType(resources.GetObject("PesanToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PesanToolStripMenuItem1.Name = "PesanToolStripMenuItem1"
        Me.PesanToolStripMenuItem1.Size = New System.Drawing.Size(115, 24)
        Me.PesanToolStripMenuItem1.Text = "Pesan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(89, 23)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STLabel1, Me.STLabel2, Me.STLabel3, Me.STLabel4, Me.STLabel5, Me.STLabel6, Me.STLabel7, Me.STLabel8, Me.STLabel9, Me.STLabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STLabel1
        '
        Me.STLabel1.Name = "STLabel1"
        Me.STLabel1.Size = New System.Drawing.Size(42, 17)
        Me.STLabel1.Text = "KODE :"
        '
        'STLabel2
        '
        Me.STLabel2.Name = "STLabel2"
        Me.STLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel3
        '
        Me.STLabel3.Name = "STLabel3"
        Me.STLabel3.Size = New System.Drawing.Size(49, 17)
        Me.STLabel3.Text = "NAMA :"
        '
        'STLabel4
        '
        Me.STLabel4.Name = "STLabel4"
        Me.STLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel5
        '
        Me.STLabel5.Name = "STLabel5"
        Me.STLabel5.Size = New System.Drawing.Size(41, 17)
        Me.STLabel5.Text = "lEVEL :"
        '
        'STLabel6
        '
        Me.STLabel6.Name = "STLabel6"
        Me.STLabel6.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel7
        '
        Me.STLabel7.Name = "STLabel7"
        Me.STLabel7.Size = New System.Drawing.Size(36, 17)
        Me.STLabel7.Text = "JAM :"
        '
        'STLabel8
        '
        Me.STLabel8.Name = "STLabel8"
        Me.STLabel8.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel9
        '
        Me.STLabel9.Name = "STLabel9"
        Me.STLabel9.Size = New System.Drawing.Size(65, 17)
        Me.STLabel9.Text = "TANGGAL :"
        '
        'STLabel10
        '
        Me.STLabel10.Name = "STLabel10"
        Me.STLabel10.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(392, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Caffe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(518, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 60)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "JS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 530)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KASIR"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemesanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STLabel1 As ToolStripStatusLabel
    Friend WithEvents STLabel2 As ToolStripStatusLabel
    Friend WithEvents STLabel3 As ToolStripStatusLabel
    Friend WithEvents STLabel4 As ToolStripStatusLabel
    Friend WithEvents STLabel5 As ToolStripStatusLabel
    Friend WithEvents STLabel6 As ToolStripStatusLabel
    Friend WithEvents STLabel7 As ToolStripStatusLabel
    Friend WithEvents STLabel8 As ToolStripStatusLabel
    Friend WithEvents STLabel9 As ToolStripStatusLabel
    Friend WithEvents STLabel10 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
