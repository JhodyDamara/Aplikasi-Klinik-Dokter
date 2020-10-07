<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Perawat
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.reset = New System.Windows.Forms.Button
        Me.keluar = New System.Windows.Forms.Button
        Me.hapus = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.simpan = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cari = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView_Perawat = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tanggal = New System.Windows.Forms.Label
        Me.waktu = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.jk = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.nama_per = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.alamat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.no_hp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.kd_per = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cek = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView_Perawat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.klinik.My.Resources.Resources.blue
        Me.GroupBox1.Controls.Add(Me.reset)
        Me.GroupBox1.Controls.Add(Me.keluar)
        Me.GroupBox1.Controls.Add(Me.hapus)
        Me.GroupBox1.Controls.Add(Me.edit)
        Me.GroupBox1.Controls.Add(Me.simpan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(686, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 264)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proses"
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Image = Global.klinik.My.Resources.Resources.resett
        Me.reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.reset.Location = New System.Drawing.Point(12, 160)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(70, 44)
        Me.reset.TabIndex = 5
        Me.reset.Text = "Reset"
        Me.reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.reset.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluar.Image = Global.klinik.My.Resources.Resources._Exit
        Me.keluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.keluar.Location = New System.Drawing.Point(13, 206)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(70, 50)
        Me.keluar.TabIndex = 3
        Me.keluar.Text = "Keluar"
        Me.keluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapus.Image = Global.klinik.My.Resources.Resources.Delete
        Me.hapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.hapus.Location = New System.Drawing.Point(13, 114)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(70, 45)
        Me.hapus.TabIndex = 2
        Me.hapus.Text = "Hapus"
        Me.hapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.hapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Image = Global.klinik.My.Resources.Resources.Modify
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.edit.Location = New System.Drawing.Point(12, 67)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(71, 46)
        Me.edit.TabIndex = 1
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.edit.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpan.Image = Global.klinik.My.Resources.Resources.Save
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.simpan.Location = New System.Drawing.Point(12, 16)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(72, 50)
        Me.simpan.TabIndex = 6
        Me.simpan.Text = "Simpan"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.simpan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.klinik.My.Resources.Resources.blue
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cari)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.DataGridView_Perawat)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(775, 273)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Perawat"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(584, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(15, 29)
        Me.cari.Multiline = True
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(176, 25)
        Me.cari.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.Image = Global.klinik.My.Resources.Resources.Search
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(197, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 33)
        Me.Button5.TabIndex = 13
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView_Perawat
        '
        Me.DataGridView_Perawat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView_Perawat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Perawat.Location = New System.Drawing.Point(16, 64)
        Me.DataGridView_Perawat.Name = "DataGridView_Perawat"
        Me.DataGridView_Perawat.Size = New System.Drawing.Size(707, 198)
        Me.DataGridView_Perawat.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.klinik.My.Resources.Resources.per
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.tanggal)
        Me.GroupBox2.Controls.Add(Me.waktu)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 263)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Data Perawat"
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.Color.Transparent
        Me.tanggal.Location = New System.Drawing.Point(454, 22)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(58, 19)
        Me.tanggal.TabIndex = 15
        Me.tanggal.Text = "tanggal"
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.BackColor = System.Drawing.Color.Transparent
        Me.waktu.Location = New System.Drawing.Point(522, 43)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(49, 19)
        Me.waktu.TabIndex = 14
        Me.waktu.Text = "waktu"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.jk)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(24, 137)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(294, 36)
        Me.Panel4.TabIndex = 3
        '
        'jk
        '
        Me.jk.FormattingEnabled = True
        Me.jk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.jk.Location = New System.Drawing.Point(104, 8)
        Me.jk.Name = "jk"
        Me.jk.Size = New System.Drawing.Size(176, 23)
        Me.jk.TabIndex = 3
        Me.jk.Text = "Pilih"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.nama_per)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(24, 85)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(294, 36)
        Me.Panel6.TabIndex = 2
        '
        'nama_per
        '
        Me.nama_per.Location = New System.Drawing.Point(104, 6)
        Me.nama_per.Multiline = True
        Me.nama_per.Name = "nama_per"
        Me.nama_per.Size = New System.Drawing.Size(176, 25)
        Me.nama_per.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nama Perawat"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.alamat)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(363, 137)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(294, 36)
        Me.Panel5.TabIndex = 5
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(109, 6)
        Me.alamat.Multiline = True
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(176, 25)
        Me.alamat.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.no_hp)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(363, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 36)
        Me.Panel3.TabIndex = 4
        '
        'no_hp
        '
        Me.no_hp.Location = New System.Drawing.Point(110, 6)
        Me.no_hp.Multiline = True
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Size = New System.Drawing.Size(176, 25)
        Me.no_hp.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No Handphone"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.kd_per)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cek)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(24, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 36)
        Me.Panel1.TabIndex = 1
        '
        'kd_per
        '
        Me.kd_per.Location = New System.Drawing.Point(104, 6)
        Me.kd_per.Multiline = True
        Me.kd_per.Name = "kd_per"
        Me.kd_per.Size = New System.Drawing.Size(139, 25)
        Me.kd_per.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Perawat"
        '
        'cek
        '
        Me.cek.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cek.Location = New System.Drawing.Point(249, 3)
        Me.cek.Name = "cek"
        Me.cek.Size = New System.Drawing.Size(42, 32)
        Me.cek.TabIndex = 8
        Me.cek.Text = "cek"
        Me.cek.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Data_Perawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 554)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Data_Perawat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Perawat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView_Perawat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Perawat As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents jk As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents nama_per As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents no_hp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents kd_per As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cek As System.Windows.Forms.Button
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents waktu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
