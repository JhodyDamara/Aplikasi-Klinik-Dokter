<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Dokter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Dokter))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cari = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView_Dokter = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tanggal = New System.Windows.Forms.Label
        Me.waktu = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.jk = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.nama_dok = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.alamat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.no_hp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.spesialis = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.kd_dok = New System.Windows.Forms.TextBox
        Me.cek = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.reset = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.simpan = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView_Dokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.klinik.My.Resources.Resources.blue1
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cari)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.DataGridView_Dokter)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 302)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(872, 302)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Dokter"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(704, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 28)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(24, 23)
        Me.cari.Multiline = True
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(176, 25)
        Me.cari.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.Image = Global.klinik.My.Resources.Resources.Search
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(206, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 33)
        Me.Button5.TabIndex = 11
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView_Dokter
        '
        Me.DataGridView_Dokter.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView_Dokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Dokter.Location = New System.Drawing.Point(24, 61)
        Me.DataGridView_Dokter.Name = "DataGridView_Dokter"
        Me.DataGridView_Dokter.Size = New System.Drawing.Size(819, 218)
        Me.DataGridView_Dokter.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.tanggal)
        Me.GroupBox2.Controls.Add(Me.waktu)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(739, 263)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Data Dokter"
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.BackColor = System.Drawing.Color.Transparent
        Me.tanggal.Location = New System.Drawing.Point(499, 12)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(58, 19)
        Me.tanggal.TabIndex = 13
        Me.tanggal.Text = "tanggal"
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.BackColor = System.Drawing.Color.Transparent
        Me.waktu.Location = New System.Drawing.Point(567, 33)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(49, 19)
        Me.waktu.TabIndex = 12
        Me.waktu.Text = "waktu"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.jk)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(401, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(294, 36)
        Me.Panel4.TabIndex = 4
        '
        'jk
        '
        Me.jk.FormattingEnabled = True
        Me.jk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.jk.Location = New System.Drawing.Point(110, 7)
        Me.jk.Name = "jk"
        Me.jk.Size = New System.Drawing.Size(172, 23)
        Me.jk.TabIndex = 1
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
        Me.Panel6.Controls.Add(Me.nama_dok)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(24, 113)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(294, 36)
        Me.Panel6.TabIndex = 2
        '
        'nama_dok
        '
        Me.nama_dok.Location = New System.Drawing.Point(105, 7)
        Me.nama_dok.Name = "nama_dok"
        Me.nama_dok.Size = New System.Drawing.Size(181, 22)
        Me.nama_dok.TabIndex = 2
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.alamat)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(401, 167)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(294, 36)
        Me.Panel5.TabIndex = 6
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(110, 7)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(172, 22)
        Me.alamat.TabIndex = 4
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
        Me.Panel3.Location = New System.Drawing.Point(401, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 36)
        Me.Panel3.TabIndex = 5
        '
        'no_hp
        '
        Me.no_hp.Location = New System.Drawing.Point(110, 7)
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Size = New System.Drawing.Size(172, 22)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.spesialis)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(24, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 36)
        Me.Panel2.TabIndex = 3
        '
        'spesialis
        '
        Me.spesialis.Location = New System.Drawing.Point(105, 7)
        Me.spesialis.Name = "spesialis"
        Me.spesialis.Size = New System.Drawing.Size(181, 22)
        Me.spesialis.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Spesialis"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.kd_dok)
        Me.Panel1.Controls.Add(Me.cek)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(24, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 36)
        Me.Panel1.TabIndex = 1
        '
        'kd_dok
        '
        Me.kd_dok.Location = New System.Drawing.Point(105, 7)
        Me.kd_dok.Name = "kd_dok"
        Me.kd_dok.Size = New System.Drawing.Size(134, 22)
        Me.kd_dok.TabIndex = 1
        '
        'cek
        '
        Me.cek.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cek.Location = New System.Drawing.Point(245, 2)
        Me.cek.Name = "cek"
        Me.cek.Size = New System.Drawing.Size(42, 32)
        Me.cek.TabIndex = 7
        Me.cek.Text = "cek"
        Me.cek.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Dokter"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.klinik.My.Resources.Resources.blue1
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.reset)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.simpan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(752, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 263)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proses"
        '
        'reset
        '
        Me.reset.Image = Global.klinik.My.Resources.Resources.resett
        Me.reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.reset.Location = New System.Drawing.Point(28, 158)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(70, 44)
        Me.reset.TabIndex = 10
        Me.reset.Text = "Reset"
        Me.reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.reset.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.klinik.My.Resources.Resources.Exit1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(30, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 49)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Keluar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.klinik.My.Resources.Resources.Delete
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(29, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 45)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Hapus"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.klinik.My.Resources.Resources.Modify
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(28, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 46)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Edit"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Image = Global.klinik.My.Resources.Resources.Save
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.simpan.Location = New System.Drawing.Point(28, 16)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(72, 50)
        Me.simpan.TabIndex = 7
        Me.simpan.Text = "Simpan"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Data_Dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.klinik.My.Resources.Resources.ugd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 647)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Data_Dokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Dokter"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView_Dokter, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Dokter As System.Windows.Forms.DataGridView
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents waktu As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents jk As System.Windows.Forms.ComboBox
    Friend WithEvents nama_dok As System.Windows.Forms.TextBox
    Friend WithEvents spesialis As System.Windows.Forms.TextBox
    Friend WithEvents kd_dok As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents no_hp As System.Windows.Forms.TextBox
    Friend WithEvents cek As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
