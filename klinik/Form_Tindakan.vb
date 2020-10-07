Imports System.Data.Odbc
Public Class Form_Tindakan


    Private Sub Form_Tindakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        tampil()
        atur()
        Call tampil_kodeComboBox()
        DataGridView_Tindakan.CurrentCell = DataGridView_Tindakan(0, DataGridView_Tindakan.Rows.Count - 1)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tanggal.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        waktu.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub cek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek.Click
        Call ODBC_KONEK()
        cmd = New OdbcCommand("Select * from tindakan where kd_tindak in (select max(kd_tindak) from tindakan)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "RM" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "RM" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        kd_tindak.Text = UrutanKode
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If Trim(kd_tindak.Text) = "" Then
            MessageBox.Show("NO RM Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into tindakan(kd_tindak,kd_daftar,tgl_daftar,nama_pas,usia,keluhan,tindakan,diagnosa,biaya) values " & _
                                "('" & kd_tindak.Text & _
                                "','" & kd_daftar.Text & _
                                "','" & tgl_daftar.Text & _
                                "','" & nama_pas.Text & _
                                "','" & usia.Text & _
                                "','" & keluhan.Text & _
                                "','" & tindakan.Text & _
                                "','" & diagnosa.Text & _
                                "','" & biaya.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
                DataGridView_Tindakan.CurrentCell = DataGridView_Tindakan(0, DataGridView_Tindakan.Rows.Count - 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampil()
        Dim da As Odbc.OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from tindakan", conn)
        ds = New DataSet
        da.Fill(ds, "tindakan")
        DataGridView_Tindakan.DataSource = ds.Tables("tindakan")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(kd_tindak.Text) = "" Then
            MessageBox.Show("NO RM Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah anda yakin ingin merubah data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                sql = " update tindakan set kd_daftar='" & kd_daftar.Text & _
                "',tgl_daftar='" & tgl_daftar.Text & _
                "',nama_pas='" & nama_pas.Text & _
                "',usia='" & usia.Text & _
                "',keluhan='" & keluhan.Text & _
                "',tindakan='" & tindakan.Text & _
                "',diagnosa='" & diagnosa.Text & _
                "',biaya='" & biaya.Text & _
                "' where kd_tindak='" & kd_tindak.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
                DataGridView_Tindakan.CurrentCell = DataGridView_Tindakan(0, DataGridView_Tindakan.Rows.Count - 1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(kd_tindak.Text) = "" Then
            MessageBox.Show("NO RM Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah Anda Yakin ingin Menghapus Data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from tindakan where kd_tindak = '" & kd_tindak.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
                DataGridView_Tindakan.CurrentCell = DataGridView_Tindakan(0, DataGridView_Tindakan.Rows.Count - 1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        kd_tindak.Clear()
        kd_daftar.Text = ""
        tgl_daftar.Clear()
        nama_pas.Clear()
        usia.Clear()
        keluhan.Clear()
        tindakan.Text = ""
        diagnosa.Clear()
        biaya.Clear()

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
        da = New OdbcDataAdapter("SELECT * FROM tindakan where nama_pas LIKE'" & cari.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "tindakan")
        DataGridView_Tindakan.DataSource = ds.Tables("tindakan")
    End Sub

    Private Sub DataGridView_Tindakan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Tindakan.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView_Tindakan.DataSource, DataGridView_Tindakan.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            kd_tindak.Text = dr(0).ToString
            kd_daftar.Text = dr(1).ToString
            tgl_daftar.Text = dr(2).ToString
            nama_pas.Text = dr(3).ToString
            usia.Text = dr(4).ToString
            keluhan.Text = dr(5).ToString
            tindakan.Text = dr(6).ToString
            diagnosa.Text = dr(7).ToString
            biaya.Text = dr(8).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub atur()
        Try
            DataGridView_Tindakan.Columns(0).Width = 80
            DataGridView_Tindakan.Columns(1).Width = 90
            DataGridView_Tindakan.Columns(2).Width = 75
            DataGridView_Tindakan.Columns(3).Width = 75
            DataGridView_Tindakan.Columns(4).Width = 60
            DataGridView_Tindakan.Columns(5).Width = 117
            DataGridView_Tindakan.Columns(6).Width = 115
            DataGridView_Tindakan.Columns(7).Width = 115
            DataGridView_Tindakan.Columns(8).Width = 85

            DataGridView_Tindakan.Columns(0).HeaderText = "NO RM"
            DataGridView_Tindakan.Columns(1).HeaderText = "NO DFT"
            DataGridView_Tindakan.Columns(2).HeaderText = "TANGGAL"
            DataGridView_Tindakan.Columns(3).HeaderText = "PASIEN"
            DataGridView_Tindakan.Columns(4).HeaderText = "USIA"
            DataGridView_Tindakan.Columns(5).HeaderText = "KELUHAN"
            DataGridView_Tindakan.Columns(6).HeaderText = "TINDAKAN"
            DataGridView_Tindakan.Columns(7).HeaderText = "DIAGNOSA"
            DataGridView_Tindakan.Columns(8).HeaderText = "BIAYA"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub laporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles laporan.Click
        form_kunjungan_perpasien.crv.ReportSource = ("laporan_kunjungan_perpasien.rpt")
        form_kunjungan_perpasien.crv.SelectionFormula = "{tindakan.kd_tindak}=  '" & kd_tindak.Text & "'"
        form_kunjungan_perpasien.crv.Refresh()
        form_kunjungan_perpasien.Show()

    End Sub

    Private Sub kd_daftar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil_teks()
    End Sub
    Sub tampil_teks()
        Try
            Call ODBC_KONEK()
            Dim str As String
            str = "select * from pendaftaran where kd_daftar = '" & kd_daftar.Text & "'"
            cmd = New OdbcCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If Rd.HasRows Then
                tgl_daftar.Text = Rd.Item("tgl_daftar")
                nama_pas.Text = Rd.Item("nama_pas")
                usia.Text = Rd.Item("usia")
                keluhan.Text = Rd.Item("keluhan")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cetak.Click
        Form_Laporan_Tindakan.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cetak_rekam_medis.Click
        form_rekam_medis.crv.ReportSource = ("Laporan_Rekam_Medis.rpt")
        form_rekam_medis.crv.SelectionFormula = "{pendaftaran.nama_pas}=  '" & nama_pas.Text & "'"
        form_rekam_medis.crv.Refresh()
        form_rekam_medis.Show()
    End Sub

    Private Sub tindakan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tindakan.SelectedIndexChanged
        If tindakan.Text = "Periksa" Then
            biaya.Text = "50000"
        ElseIf tindakan.Text = "Suntik" Then
            biaya.Text = "100000"
        ElseIf tindakan.Text = "Rawat" Then
            biaya.Text = "150000"
        ElseIf tindakan.Text = "Ronsen" Then
            biaya.Text = "170000"
        End If
        diagnosa.Focus()
    End Sub

    Sub tampil_kodeComboBox()
        Try
            Call ODBC_KONEK()
            Dim str As String
            str = ("select kd_daftar from tindakan ORDER BY kd_daftar DESC")
            cmd = New OdbcCommand(str, conn)
            Rd = cmd.ExecuteReader

            If Rd.HasRows Then
                Do While Rd.Read
                    kd_daftar.Items.Add(Rd("kd_daftar"))
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub kd_daftar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kd_daftar.SelectedIndexChanged
        cmd = New OdbcCommand("Select * from tindakan where kd_daftar='" & kd_daftar.Text & "'", conn)
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            tgl_daftar.Text = Rd.Item("tgl_daftar")
            nama_pas.Text = Rd.Item("nama_pas")
            usia.Text = Rd.Item("usia")
            keluhan.Text = Rd.Item("keluhan")
            tindakan.Focus()
        End If
    End Sub
End Class