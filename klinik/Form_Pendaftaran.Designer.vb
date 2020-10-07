<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pendaftaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Pendaftaran))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.cetak = New System.Windows.Forms.Button
        Me.cari = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView_Pendaftaran = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.waktu = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.usia = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tanggal = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.nama_pas = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.kd_pas = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.tgl_daftar = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.keluhan = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cmbnama_dok = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmbnama_per = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.kd_daftar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cek = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.reset = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.simpan = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView_Pendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.cetak)
        Me.GroupBox3.Controls.Add(Me.cari)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.DataGridView_Pendaftaran)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 355)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 273)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Pendaftaran"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(720, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 51)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Laporan"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cetak
        '
        Me.cetak.Image = Global.klinik.My.Resources.Resources.Print
        Me.cetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cetak.Location = New System.Drawing.Point(552, 10)
        Me.cetak.Name = "cetak"
        Me.cetak.Size = New System.Drawing.Size(107, 51)
        Me.cetak.TabIndex = 16
        Me.cetak.Text = "Cetak"
        Me.cetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cetak.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(24, 24)
        Me.cari.Multiline = True
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(176, 25)
        Me.cari.TabIndex = 10
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(206, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 33)
        Me.Button5.TabIndex = 11
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView_Pendaftaran
        '
        Me.DataGridView_Pendaftaran.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView_Pendaftaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Pendaftaran.Location = New System.Drawing.Point(24, 63)
        Me.DataGridView_Pendaftaran.Name = "DataGridView_Pendaftaran"
        Me.DataGridView_Pendaftaran.Size = New System.Drawing.Size(874, 193)
        Me.DataGridView_Pendaftaran.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.waktu)
        Me.GroupBox2.Controls.Add(Me.Panel10)
        Me.GroupBox2.Controls.Add(Me.tanggal)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Panel9)
        Me.GroupBox2.Controls.Add(Me.Panel8)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 338)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Pendaftaran"
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.BackColor = System.Drawing.Color.SkyBlue
        Me.waktu.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktu.Location = New System.Drawing.Point(469, 53)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(61, 22)
        Me.waktu.TabIndex = 18
        Me.waktu.Text = "waktu"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.usia)
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(363, 178)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(294, 36)
        Me.Panel10.TabIndex = 7
        '
        'usia
        '
        Me.usia.Location = New System.Drawing.Point(110, 7)
        Me.usia.Name = "usia"
        Me.usia.Size = New System.Drawing.Size(175, 22)
        Me.usia.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Usia"
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.Color.SkyBlue
        Me.tanggal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(411, 22)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(71, 22)
        Me.tanggal.TabIndex = 15
        Me.tanggal.Text = "tanggal"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.nama_pas)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(363, 137)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(294, 36)
        Me.Panel5.TabIndex = 6
        '
        'nama_pas
        '
        Me.nama_pas.Location = New System.Drawing.Point(110, 7)
        Me.nama_pas.Name = "nama_pas"
        Me.nama_pas.Size = New System.Drawing.Size(175, 22)
        Me.nama_pas.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nama Pasien"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.kd_pas)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(363, 96)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(294, 36)
        Me.Panel9.TabIndex = 5
        '
        'kd_pas
        '
        Me.kd_pas.FormattingEnabled = True
        Me.kd_pas.Location = New System.Drawing.Point(110, 6)
        Me.kd_pas.Name = "kd_pas"
        Me.kd_pas.Size = New System.Drawing.Size(175, 23)
        Me.kd_pas.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kode Pasien"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.tgl_daftar)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(22, 96)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(310, 36)
        Me.Panel8.TabIndex = 2
        '
        'tgl_daftar
        '
        Me.tgl_daftar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl_daftar.Location = New System.Drawing.Point(114, 5)
        Me.tgl_daftar.Name = "tgl_daftar"
        Me.tgl_daftar.Size = New System.Drawing.Size(189, 22)
        Me.tgl_daftar.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tanggal"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.keluhan)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(363, 219)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(294, 96)
        Me.Panel4.TabIndex = 8
        '
        'keluhan
        '
        Me.keluhan.Location = New System.Drawing.Point(110, 8)
        Me.keluhan.Multiline = True
        Me.keluhan.Name = "keluhan"
        Me.keluhan.Size = New System.Drawing.Size(175, 78)
        Me.keluhan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Keluhan"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmbnama_dok)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(22, 141)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(308, 36)
        Me.Panel6.TabIndex = 3
        '
        'cmbnama_dok
        '
        Me.cmbnama_dok.FormattingEnabled = True
        Me.cmbnama_dok.Location = New System.Drawing.Point(114, 6)
        Me.cmbnama_dok.Name = "cmbnama_dok"
        Me.cmbnama_dok.Size = New System.Drawing.Size(189, 23)
        Me.cmbnama_dok.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nama Dokter"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbnama_per)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(22, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(308, 36)
        Me.Panel2.TabIndex = 4
        '
        'cmbnama_per
        '
        Me.cmbnama_per.FormattingEnabled = True
        Me.cmbnama_per.Location = New System.Drawing.Point(114, 6)
        Me.cmbnama_per.Name = "cmbnama_per"
        Me.cmbnama_per.Size = New System.Drawing.Size(189, 23)
        Me.cmbnama_per.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Perawat"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.kd_daftar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cek)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(22, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 36)
        Me.Panel1.TabIndex = 1
        '
        'kd_daftar
        '
        Me.kd_daftar.Location = New System.Drawing.Point(114, 6)
        Me.kd_daftar.Multiline = True
        Me.kd_daftar.Name = "kd_daftar"
        Me.kd_daftar.Size = New System.Drawing.Size(143, 25)
        Me.kd_daftar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pendaftaran"
        '
        'cek
        '
        Me.cek.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cek.Location = New System.Drawing.Point(261, 3)
        Me.cek.Name = "cek"
        Me.cek.Size = New System.Drawing.Size(42, 32)
        Me.cek.TabIndex = 11
        Me.cek.Text = "cek"
        Me.cek.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.reset)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.simpan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(730, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 338)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proses"
        '
        'reset
        '
        Me.reset.Image = CType(resources.GetObject("reset.Image"), System.Drawing.Image)
        Me.reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.reset.Location = New System.Drawing.Point(28, 212)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(72, 44)
        Me.reset.TabIndex = 4
        Me.reset.Text = "Reset"
        Me.reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.reset.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(29, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Keluar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(29, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hapus"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(28, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.simpan.Location = New System.Drawing.Point(28, 31)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(71, 50)
        Me.simpan.TabIndex = 10
        Me.simpan.Text = "Simpan"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form_Pendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.klinik.My.Resources.Resources.ugd1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 658)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Pendaftaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Pendaftaran"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView_Pendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cetak As System.Windows.Forms.Button
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Pendaftaran As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents waktu As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents usia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents nama_pas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents tgl_daftar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents keluhan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmbnama_dok As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbnama_per As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents kd_daftar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cek As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents kd_pas As System.Windows.Forms.ComboBox
End Class
