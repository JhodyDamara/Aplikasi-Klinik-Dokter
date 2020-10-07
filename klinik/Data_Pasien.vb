Imports System.Data.Odbc
Public Class Data_Pasien

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(kd_pas.Text) = "" Then
            MessageBox.Show("Kode Pasien Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into pasien(kd_pas,nik,nama_pas,tmpt_lahir,tgl_lahir, jk, usia, pekerjaan, no_hp, alamat) values " & _
                                "('" & kd_pas.Text & _
                                "','" & nik.Text & _
                                "','" & nama_pas.Text & _
                                "','" & tmpt_lahir.Text & _
                                "','" & tgl_lahir.Text & _
                                "','" & jk.Text & _
                                "','" & usia.Text & _
                                "','" & pekerjaan.Text & _
                                "','" & no_hp.Text & _
                                "','" & alamat.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("Data Pasien Berhasil Disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampil()
        Dim da As Odbc.OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from pasien", conn)
        ds = New DataSet
        da.Fill(ds, "pasien")
        DataGridView_pasien.DataSource = ds.Tables("pasien")
    End Sub

    Private Sub Data_Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        tampil()
        atur()
        DataGridView_pasien.CurrentCell = DataGridView_pasien(0, DataGridView_pasien.Rows.Count - 1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(kd_pas.Text) = "" Then
            MessageBox.Show("Kode Pasien Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah anda yakin ingin merubah data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                sql = " update pasien set nik='" & nik.Text & _
                        "',nama_pas='" & nama_pas.Text & _
                        "',tmpt_lahir='" & tmpt_lahir.Text & _
                        "',tgl_lahir='" & tgl_lahir.Text & _
                        "',jk='" & jk.Text & _
                        "',usia='" & usia.Text & _
                        "',pekerjaan='" & pekerjaan.Text & _
                        "',no_hp='" & no_hp.Text & _
                        "',alamat='" & alamat.Text & _
                        "' where kd_pas='" & kd_pas.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Pasien Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(kd_pas.Text) = "" Then
            MessageBox.Show("Kode Pasien Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        
        Dim result = MessageBox.Show("Apakah Anda Yakin ingin Menghapus Data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from pasien where kd_pas= '" & kd_pas.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Pasien Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        kd_pas.Clear()
        nik.Clear()
        nama_pas.Clear()
        tmpt_lahir.Clear()
        jk.Text = "pilih"
        usia.Clear()
        pekerjaan.Clear()
        no_hp.Clear()
        alamat.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_pasien_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_pasien.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView_pasien.DataSource, DataGridView_pasien.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            kd_pas.Text = dr(0).ToString
            nik.Text = dr(1).ToString
            nama_pas.Text = dr(2).ToString
            tmpt_lahir.Text = dr(3).ToString
            tgl_lahir.Text = dr(4).ToString
            jk.Text = dr(5).ToString
            usia.Text = dr(6).ToString
            pekerjaan.Text = dr(7).ToString
            no_hp.Text = dr(8).ToString
            alamat.Text = dr(9).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        tampil_cari()
    End Sub
    Sub tampil_cari()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * FROM pasien where nama_pas LIKE'" & cari.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "pasien")
        DataGridView_pasien.DataSource = ds.Tables("pasien")
    End Sub
    Private Sub tgl_lahir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tgl_lahir.ValueChanged
        Dim hitung As Date = tgl_lahir.Value
        Dim tahun As Integer
        While tahun <= (Now.Year - hitung.Year)
            tahun += 1
        End While
        tahun -= 1
        usia.Text = tahun
    End Sub

    Private Sub cek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek.Click
        Call ODBC_KONEK()
        cmd = New OdbcCommand("Select * from pasien where kd_pas in (select max(kd_pas) from pasien)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "pas" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "pas" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        kd_pas.Text = UrutanKode
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        form_laporan_pasien.Show()
    End Sub
    Sub atur()
        Try
            DataGridView_pasien.Columns(0).Width = 60
            DataGridView_pasien.Columns(1).Width = 130
            DataGridView_pasien.Columns(2).Width = 115
            DataGridView_pasien.Columns(3).Width = 115
            DataGridView_pasien.Columns(4).Width = 115
            DataGridView_pasien.Columns(6).Width = 50
            DataGridView_pasien.Columns(0).HeaderText = "KODE"
            DataGridView_pasien.Columns(1).HeaderText = "NIK"
            DataGridView_pasien.Columns(2).HeaderText = "NAMA"
            DataGridView_pasien.Columns(3).HeaderText = "TMPT LAHIR"
            DataGridView_pasien.Columns(4).HeaderText = "TGL LAHIR"
            DataGridView_pasien.Columns(5).HeaderText = "KELAMIN"
            DataGridView_pasien.Columns(6).HeaderText = "USIA"
            DataGridView_pasien.Columns(7).HeaderText = "PEKERJAAN"
            DataGridView_pasien.Columns(8).HeaderText = "NO HP"
            DataGridView_pasien.Columns(9).HeaderText = "ALAMAT"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub kartu_pasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kartu_pasien.Click

        form_kartu_pasien.CrystalReportViewer1.ReportSource = ("kartu_pasien.rpt")
        form_kartu_pasien.CrystalReportViewer1.SelectionFormula = "{pasien.kd_pas}=  '" & kd_pas.Text & "'"
        form_kartu_pasien.CrystalReportViewer1.Refresh()
        form_kartu_pasien.Show()

    End Sub

End Class