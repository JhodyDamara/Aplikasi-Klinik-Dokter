Imports System.Data.Odbc
Public Class Form_Pendaftaran


    Private Sub Form_Pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        tampil()
        atur()
        Call tampil_dokComboBox()
        Call tampil_perComboBox()
        Call tampil_pasComboBox()
        'untuk melihat dgv terakhir
        DataGridView_Pendaftaran.CurrentCell = DataGridView_Pendaftaran(0, DataGridView_Pendaftaran.Rows.Count - 1)
    End Sub
    Sub tampil_pasComboBox()
        Try
            Call ODBC_KONEK()
            Dim str As String
            str = ("select kd_pas from pasien ORDER BY kd_pas DESC")
            cmd = New OdbcCommand(str, conn)
            Rd = cmd.ExecuteReader

            If Rd.HasRows Then
                Do While Rd.Read
                    kd_pas.Items.Add(Rd("kd_pas"))
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub kd_pas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kd_pas.SelectedIndexChanged
        cmd = New OdbcCommand("Select * from pasien where kd_pas='" & kd_pas.Text & "'", conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            nama_pas.Text = Rd.Item("nama_pas")
            usia.Text = Rd.Item("usia")
            keluhan.Focus()
        End If
    End Sub
    Sub tampil_dokComboBox()
        Try
            Call ODBC_KONEK()
            Dim str As String
            str = ("select nama_dok from dokter")
            cmd = New OdbcCommand(str, conn)
            Rd = cmd.ExecuteReader

            If Rd.HasRows Then
                Do While Rd.Read
                    cmbnama_dok.Items.Add(Rd("nama_dok"))
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub tampil_perComboBox()
        Try
            Call ODBC_KONEK()
            Dim str As String
            str = ("select nama_per from perawat")
            cmd = New OdbcCommand(str, conn)
            Rd = cmd.ExecuteReader

            If Rd.HasRows Then
                Do While Rd.Read
                    cmbnama_per.Items.Add(Rd("nama_per"))
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek.Click
        Call ODBC_KONEK()
        cmd = New OdbcCommand("Select * from pendaftaran where kd_daftar in (select max(kd_daftar) from pendaftaran)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "dft" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "dft" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        kd_daftar.Text = UrutanKode
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If Trim(kd_daftar.Text) = "" Then
            MessageBox.Show("Kode Pendaftaran Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into pendaftaran(kd_daftar,tgl_daftar,nama_dok,nama_per,kd_pas,nama_pas,usia,keluhan) values " & _
                                "('" & kd_daftar.Text & _
                                "','" & Format(tgl_daftar.Value, "dd/MM/yyyy") & _
                                "','" & cmbnama_dok.Text & _
                                "','" & cmbnama_per.Text & _
                                "','" & kd_pas.Text & _
                                "','" & nama_pas.Text & _
                                "','" & usia.Text & _
                                "','" & keluhan.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
                DataGridView_Pendaftaran.CurrentCell = DataGridView_Pendaftaran(0, DataGridView_Pendaftaran.Rows.Count - 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampil()
        Dim da As Odbc.OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from pendaftaran", conn)
        ds = New DataSet
        da.Fill(ds, "pendaftaran")
        DataGridView_Pendaftaran.DataSource = ds.Tables("pendaftaran")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(kd_daftar.Text) = "" Then
            MessageBox.Show("Kode Pendaftaran Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah anda yakin ingin merubah data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                sql = " update pendaftaran set tgl_daftar='" & Format(tgl_daftar.Value, "dd/MM/yyyy") & _
                "',nama_dok='" & cmbnama_dok.Text & _
                "',nama_per='" & cmbnama_per.Text & _
                "',kd_pas='" & kd_pas.Text & _
                "',nama_pas='" & nama_pas.Text & _
                "',usia='" & usia.Text & _
                "',keluhan='" & keluhan.Text & _
                "' where kd_daftar='" & kd_daftar.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
                DataGridView_Pendaftaran.CurrentCell = DataGridView_Pendaftaran(0, DataGridView_Pendaftaran.Rows.Count - 1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(kd_daftar.Text) = "" Then
            MessageBox.Show("Kode Pendaftaran Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah Anda Yakin ingin Menghapus Data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from pendaftaran where kd_daftar = '" & kd_daftar.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
                DataGridView_Pendaftaran.CurrentCell = DataGridView_Pendaftaran(0, DataGridView_Pendaftaran.Rows.Count - 1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        kd_daftar.Clear()
        cmbnama_dok.Text = ""
        cmbnama_per.Text = ""
        kd_pas.Text = ""
        nama_pas.Clear()
        usia.Clear()
        keluhan.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        tampil_cari()
    End Sub
    Sub tampil_cari()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * FROM pendaftaran where nama_pas LIKE'" & cari.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "pendaftaran")
        DataGridView_Pendaftaran.DataSource = ds.Tables("pendaftaran")
    End Sub
    Sub atur()
        Try
            DataGridView_Pendaftaran.Columns(0).Width = 66
            DataGridView_Pendaftaran.Columns(1).Width = 130
            DataGridView_Pendaftaran.Columns(2).Width = 105
            DataGridView_Pendaftaran.Columns(3).Width = 105
            DataGridView_Pendaftaran.Columns(4).Width = 90
            DataGridView_Pendaftaran.Columns(5).Width = 115
            DataGridView_Pendaftaran.Columns(6).Width = 50
            DataGridView_Pendaftaran.Columns(7).Width = 169

            DataGridView_Pendaftaran.Columns(0).HeaderText = "KODE"
            DataGridView_Pendaftaran.Columns(1).HeaderText = "TANGGAL"
            DataGridView_Pendaftaran.Columns(2).HeaderText = "DOKTER"
            DataGridView_Pendaftaran.Columns(3).HeaderText = "PERAWAT"
            DataGridView_Pendaftaran.Columns(4).HeaderText = "KD_PASIEN"
            DataGridView_Pendaftaran.Columns(5).HeaderText = "PASIEN"
            DataGridView_Pendaftaran.Columns(6).HeaderText = "USIA"
            DataGridView_Pendaftaran.Columns(7).HeaderText = "KELUHAN"

        Catch ex As Exception
        End Try
    End Sub

    Private Sub laporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cetak.Click
        Form_Cetak_Pendaftaran.CrystalReportViewer1.ReportSource = ("Cetak_Pendaftaran.rpt")
        Form_Cetak_Pendaftaran.CrystalReportViewer1.SelectionFormula = "{Pendaftaran.kd_daftar}=  '" & kd_daftar.Text & "'"
        Form_Cetak_Pendaftaran.CrystalReportViewer1.Refresh()
        Form_Cetak_Pendaftaran.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tanggal.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        waktu.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub DataGridView_Pendaftaran_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Pendaftaran.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView_Pendaftaran.DataSource, DataGridView_Pendaftaran.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            kd_daftar.Text = dr(0).ToString
            tgl_daftar.Text = dr(1).ToString
            cmbnama_dok.Text = dr(2).ToString
            cmbnama_per.Text = dr(3).ToString
            kd_pas.Text = dr(4).ToString
            nama_pas.Text = dr(5).ToString
            usia.Text = dr(6).ToString
            keluhan.Text = dr(7).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form_Laporan_Pendaftaran.Show()
    End Sub

End Class