Imports CrystalDecisions.CrystalReports.Engine

Public Class form_kartu_pasien

    Sub LAPORAN()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\User\My Documents\Visual Studio 2008\Projects\klinik\klinik\kartu_pasien.rpt")
        CrystalReportViewer1.ReportSource = cryRpt

    End Sub
    Private Sub laporan_dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LAPORAN()
    End Sub

End Class