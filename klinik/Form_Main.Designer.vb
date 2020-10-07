<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
        Me.SelamatDatangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataDokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TindakanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TindakanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TindakanToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.tanggal = New System.Windows.Forms.Label
        Me.waktu = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MENUUTAMAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.REKAMMEDISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.PendaftaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TindakanToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LaporanToolStripMenuItem
        '
        LaporanToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        LaporanToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        LaporanToolStripMenuItem.Text = "Laporan"
        '
        'ToolStripMenuItem8
        '
        ToolStripMenuItem8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New System.Drawing.Size(81, 20)
        ToolStripMenuItem8.Text = "Laporan"
        AddHandler ToolStripMenuItem8.Click, AddressOf Me.ToolStripMenuItem8_Click
        '
        'SelamatDatangToolStripMenuItem
        '
        Me.SelamatDatangToolStripMenuItem.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SelamatDatangToolStripMenuItem.Enabled = False
        Me.SelamatDatangToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelamatDatangToolStripMenuItem.Name = "SelamatDatangToolStripMenuItem"
        Me.SelamatDatangToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.SelamatDatangToolStripMenuItem.Text = "Selamat Datang"
        '
        'MenuUtamaToolStripMenuItem
        '
        Me.MenuUtamaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuUtamaToolStripMenuItem.Checked = True
        Me.MenuUtamaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuUtamaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDokterToolStripMenuItem, Me.DataPegawaiToolStripMenuItem, Me.DataPasienToolStripMenuItem})
        Me.MenuUtamaToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuUtamaToolStripMenuItem.Name = "MenuUtamaToolStripMenuItem"
        Me.MenuUtamaToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.MenuUtamaToolStripMenuItem.Text = "Menu Utama"
        '
        'DataDokterToolStripMenuItem
        '
        Me.DataDokterToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDokterToolStripMenuItem.Name = "DataDokterToolStripMenuItem"
        Me.DataDokterToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DataDokterToolStripMenuItem.Text = "Data Dokter"
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DataPegawaiToolStripMenuItem.Text = "Data Perawat"
        '
        'DataPasienToolStripMenuItem
        '
        Me.DataPasienToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPasienToolStripMenuItem.Name = "DataPasienToolStripMenuItem"
        Me.DataPasienToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DataPasienToolStripMenuItem.Text = "Data Pasien"
        '
        'TindakanToolStripMenuItem
        '
        Me.TindakanToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TindakanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TindakanToolStripMenuItem1, Me.TindakanToolStripMenuItem2})
        Me.TindakanToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TindakanToolStripMenuItem.Name = "TindakanToolStripMenuItem"
        Me.TindakanToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.TindakanToolStripMenuItem.Text = "Rekam Medis"
        '
        'TindakanToolStripMenuItem1
        '
        Me.TindakanToolStripMenuItem1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TindakanToolStripMenuItem1.Name = "TindakanToolStripMenuItem1"
        Me.TindakanToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.TindakanToolStripMenuItem1.Text = "Pendaftaran"
        '
        'TindakanToolStripMenuItem2
        '
        Me.TindakanToolStripMenuItem2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TindakanToolStripMenuItem2.Name = "TindakanToolStripMenuItem2"
        Me.TindakanToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.TindakanToolStripMenuItem2.Text = "Tindakan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(12, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1342, 590)
        Me.Panel2.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.klinik.My.Resources.Resources.main
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.tanggal)
        Me.Panel5.Controls.Add(Me.waktu)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(12, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1317, 551)
        Me.Panel5.TabIndex = 0
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.Color.Transparent
        Me.tanggal.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.ForeColor = System.Drawing.Color.Navy
        Me.tanggal.Location = New System.Drawing.Point(428, 18)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(48, 32)
        Me.tanggal.TabIndex = 15
        Me.tanggal.Text = "tgl"
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.BackColor = System.Drawing.Color.Transparent
        Me.waktu.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktu.ForeColor = System.Drawing.Color.Navy
        Me.waktu.Location = New System.Drawing.Point(782, 18)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(63, 32)
        Me.waktu.TabIndex = 14
        Me.waktu.Text = "jam"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(377, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(606, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = ":   KAMI MEMBERIKAN PELAYANAN TERBAIK BAGI KESEHATAN ANDA "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(377, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = ":   082384964868"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(377, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = ":   RIZKY FEBRINA PANE, dr"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(377, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(594, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = ":   JL. KUBANG RAYA KM. 11 KEC. SIAK HULU - KAMPAR - PEKANBARU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(225, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "MOTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(224, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "KONTAK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(215, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "MANEJER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(223, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ALAMAT"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BackgroundImage = Global.klinik.My.Resources.Resources.blue
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1342, 111)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.klinik.My.Resources.Resources.cv
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(1163, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 108)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.klinik.My.Resources.Resources.vd
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(12, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 105)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(356, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(668, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEM INFORMASI KLINIK DOKTER RINI 2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                  KUBANG PRKANBARU"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 20)
        Me.ToolStripMenuItem1.Text = "SELAMATDATANG"
        '
        'MENUUTAMAToolStripMenuItem1
        '
        Me.MENUUTAMAToolStripMenuItem1.Name = "MENUUTAMAToolStripMenuItem1"
        Me.MENUUTAMAToolStripMenuItem1.Size = New System.Drawing.Size(127, 20)
        Me.MENUUTAMAToolStripMenuItem1.Text = "MENU UTAMA"
        '
        'REKAMMEDISToolStripMenuItem
        '
        Me.REKAMMEDISToolStripMenuItem.Name = "REKAMMEDISToolStripMenuItem"
        Me.REKAMMEDISToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.REKAMMEDISToolStripMenuItem.Text = "REKAM MEDIS"
        '
        'LAPORANToolStripMenuItem1
        '
        Me.LAPORANToolStripMenuItem1.Name = "LAPORANToolStripMenuItem1"
        Me.LAPORANToolStripMenuItem1.Size = New System.Drawing.Size(93, 20)
        Me.LAPORANToolStripMenuItem1.Text = "LAPORAN"
        '
        'EXITToolStripMenuItem1
        '
        Me.EXITToolStripMenuItem1.Name = "EXITToolStripMenuItem1"
        Me.EXITToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.EXITToolStripMenuItem1.Text = "EXIT"
        '
        'HaiToolStripMenuItem
        '
        Me.HaiToolStripMenuItem.Name = "HaiToolStripMenuItem"
        Me.HaiToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HaiToolStripMenuItem.Text = "Hai"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem7, ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(132, 20)
        Me.ToolStripMenuItem2.Text = "Selamat Datang"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(98, 20)
        Me.ToolStripMenuItem3.Text = "Input Data"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "Data Pasien"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem5.Text = "Data Dokter"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripMenuItem6.Text = "Data Perawat"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendaftaranToolStripMenuItem, Me.TindakanToolStripMenuItem3})
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(116, 20)
        Me.ToolStripMenuItem7.Text = "Rekam Medis"
        '
        'PendaftaranToolStripMenuItem
        '
        Me.PendaftaranToolStripMenuItem.Name = "PendaftaranToolStripMenuItem"
        Me.PendaftaranToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PendaftaranToolStripMenuItem.Text = "Pendaftaran"
        '
        'TindakanToolStripMenuItem3
        '
        Me.TindakanToolStripMenuItem3.Name = "TindakanToolStripMenuItem3"
        Me.TindakanToolStripMenuItem3.Size = New System.Drawing.Size(164, 22)
        Me.TindakanToolStripMenuItem3.Text = "Tindakan"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem9.Text = "Exit"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOME"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SelamatDatangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUtamaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataDokterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TindakanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents waktu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TindakanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TindakanToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MENUUTAMAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REKAMMEDISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendaftaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TindakanToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
End Class
