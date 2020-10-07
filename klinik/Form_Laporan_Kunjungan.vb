Imports CrystalDecisions.CrystalReports.Engine
Public Class Form_Laporan_Kunjungan

    Private Sub Form_Laporan_Keuangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LAPORAN()
    End Sub

    Sub LAPORAN()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\User\My Documents\Visual Studio 2008\Projects\klinik\klinik\Laporan_Kunjungan.rpt")
        crv.ReportSource = cryRpt
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'crv.ReportSource = Nothing
        'crv.SelectionFormula = "({pendaftaran.tgl_daftar})= date('" & DTPharian.Text & "')"
        'crv.ReportSource = "Laporan_kunjungan.rpt"
        'crv.RefreshReport()

        'crv.ReportSource = Nothing
        'crv.RefreshReport()
        'crv.SelectionFormula = "totext({pendaftaran.tgl_daftar})in date ('" & DTPharian.Text & "')"
        'crv.ReportSource = "Laporan_Kunjungan.rpt"

        'crv.ReportSource = Nothing
        'crv.RefreshReport()
        'crv.SelectionFormula = "({pendaftaran.tgl_daftar})='" & Format(DTPharian.Value, "dd/MM/yyyy") & "'"
        'crv.ReportSource = "Laporan_Kunjungan.rpt"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        crv.ReportSource = ("Laporan_Kunjungan.rpt")
        crv.SelectionFormula = "{tindakan.tgl_daftar} >= #" & CDate(Format(DTPawal.Value, "yyyy/MM/dd")) & "# and {tindakan.tgl_daftar} <= #" & CDate(Format(DTPakhir.Value, "yyyy/MM/dd")) & "#"
        crv.RefreshReport()
    End Sub
End Class
