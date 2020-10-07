Public Class Form_Main


    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Data_Pasien.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Data_Dokter.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Data_Perawat.Show()
    End Sub

    Private Sub PendaftaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendaftaranToolStripMenuItem.Click
        Form_Pendaftaran.Show()
    End Sub

    Private Sub TindakanToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TindakanToolStripMenuItem3.Click
        Form_Tindakan.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_Laporan_Kunjungan.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tanggal.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        waktu.Text = Format(Now, "hh:mm:ss tt")
    End Sub
End Class