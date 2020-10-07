Imports System.Data.Odbc
Public Class Data_Perawat

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If Trim(kd_per.Text) = "" Then
            MessageBox.Show("Kode Perawat Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into perawat(kd_per,nama_per,jk,no_hp,alamat) values " & _
                                "('" & kd_per.Text & "','" & nama_per.Text & "','" & jk.Text & "','" & no_hp.Text & "','" & alamat.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("Data Perawat Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampil()
        Dim da As Odbc.OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from perawat", conn)
        ds = New DataSet
        da.Fill(ds, "perawat")
        DataGridView_Perawat.DataSource = ds.Tables("perawat")
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If Trim(kd_per.Text) = "" Then
            MessageBox.Show("Kode Perawat Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah anda yakin ingin merubah data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                sql = " update perawat set nama_per='" & nama_per.Text & "',jk='" & jk.Text & "',no_hp='" & _
                no_hp.Text & "',alamat='" & alamat.Text & "' where kd_per='" & kd_per.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Perawat Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        If Trim(kd_per.Text) = "" Then
            MessageBox.Show("Kode Perawat Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah Anda Yakin ingin Menghapus Data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from perawat where kd_per = '" & kd_per.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Perawat Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_Perawat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Perawat.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView_Perawat.DataSource, DataGridView_Perawat.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            kd_per.Text = dr(0).ToString
            nama_per.Text = dr(1).ToString
            jk.Text = dr(2).ToString
            no_hp.Text = dr(3).ToString
            alamat.Text = dr(4).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        kd_per.Clear()
        nama_per.Clear()
        jk.Text = "pilih"
        no_hp.Clear()
        alamat.Clear()
    End Sub

    Private Sub Data_Perawat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        tampil()
        atur()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        tampil_cari()
    End Sub
    Sub tampil_cari()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * FROM perawat where nama_per LIKE'" & cari.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "perawat")
        DataGridView_Perawat.DataSource = ds.Tables("perawat")
    End Sub

    Private Sub cek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek.Click
        Call ODBC_KONEK()
        cmd = New OdbcCommand("Select * from perawat where kd_per in (select max(kd_per) from perawat)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PER" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "PER" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        kd_per.Text = UrutanKode
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tanggal.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        waktu.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        form_laporan_perawat.Show()
    End Sub

    Sub atur()
        Try
            DataGridView_Perawat.Columns(0).Width = 100
            DataGridView_Perawat.Columns(1).Width = 160
            DataGridView_Perawat.Columns(2).Width = 130
            DataGridView_Perawat.Columns(3).Width = 125
            DataGridView_Perawat.Columns(4).Width = 149
            DataGridView_Perawat.Columns(0).HeaderText = "KODE"
            DataGridView_Perawat.Columns(1).HeaderText = "NAMA"
            DataGridView_Perawat.Columns(2).HeaderText = "KELAMIN"
            DataGridView_Perawat.Columns(3).HeaderText = "NO HP"
            DataGridView_Perawat.Columns(4).HeaderText = "ALAMAT"
        Catch ex As Exception
        End Try
    End Sub
End Class