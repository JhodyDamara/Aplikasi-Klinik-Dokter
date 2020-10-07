Imports System.Data.Odbc
Public Class Data_Dokter
    Private Sub Data_Dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        tampil()
        atur()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If Trim(kd_dok.Text) = "" Then
            MessageBox.Show("Kode Dokter Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If

        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into dokter(kd_dok,nama_dok,spesialis,jk,no_hp,alamat) values " & _
                                "('" & kd_dok.Text & "','" & nama_dok.Text & "','" & spesialis.Text & "','" & _
                                jk.Text & "','" & no_hp.Text & "','" & alamat.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If kd_dok.Text = "" Then
                MessageBox.Show("Harap Isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf (hasil > 0) Then
                MessageBox.Show("Data Dokter Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampil()
        Dim da As Odbc.OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from dokter", conn)
        ds = New DataSet
        da.Fill(ds, "dokter")
        DataGridView_Dokter.DataSource = ds.Tables("dokter")
    End Sub

    Private Sub DataGridView_Dokter_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Dokter.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView_Dokter.DataSource, DataGridView_Dokter.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            kd_dok.Text = dr(0).ToString
            nama_dok.Text = dr(1).ToString
            spesialis.Text = dr(2).ToString
            jk.Text = dr(3).ToString
            no_hp.Text = dr(4).ToString
            alamat.Text = dr(5).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(kd_dok.Text) = "" Then
            MessageBox.Show("Kode Dokter Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah anda yakin ingin merubah data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                sql = " update dokter set nama_dok='" & nama_dok.Text & "',spesialis='" & spesialis.Text & "',jk='" & jk.Text & "',no_hp='" & _
                no_hp.Text & "',alamat='" & alamat.Text & "' where kd_dok='" & kd_dok.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Dokter Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(kd_dok.Text) = "" Then
            MessageBox.Show("Kode Dokter Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If
        Dim result = MessageBox.Show("Apakah Anda Yakin ingin Menghapus Data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from dokter where kd_dok = '" & kd_dok.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Dokter Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        kd_dok.Clear()
        nama_dok.Clear()
        spesialis.Clear()
        jk.Text = "pilih"
        no_hp.Clear()
        alamat.Clear()

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        tampil_cari()
    End Sub
    Sub tampil_cari()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * FROM dokter where nama_dok LIKE'" & cari.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "dokter")
        DataGridView_Dokter.DataSource = ds.Tables("dokter")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tanggal.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        waktu.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek.Click
        Call ODBC_KONEK()
        cmd = New OdbcCommand("Select * from dokter where kd_dok in (select max(kd_dok) from dokter)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "DOK" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "DOK" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        kd_dok.Text = UrutanKode

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        form_laporan_dokter.Show()
    End Sub

    Sub atur()
        Try
            DataGridView_Dokter.Columns(0).Width = 100
            DataGridView_Dokter.Columns(1).Width = 160
            DataGridView_Dokter.Columns(2).Width = 130
            DataGridView_Dokter.Columns(3).Width = 125
            DataGridView_Dokter.Columns(4).Width = 120
            DataGridView_Dokter.Columns(5).Width = 140
            DataGridView_Dokter.Columns(0).HeaderText = "KODE"
            DataGridView_Dokter.Columns(1).HeaderText = "NAMA"
            DataGridView_Dokter.Columns(2).HeaderText = "SPESIALIS"
            DataGridView_Dokter.Columns(3).HeaderText = "KELAMIN"
            DataGridView_Dokter.Columns(4).HeaderText = "NO HP"
            DataGridView_Dokter.Columns(5).HeaderText = "ALAMAT"
        Catch ex As Exception
        End Try
    End Sub
End Class