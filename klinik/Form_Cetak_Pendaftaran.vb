Imports CrystalDecisions.CrystalReports.Engine
Public Class Form_Cetak_Pendaftaran

    Private Sub Form_Cetak_Pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LAPORAN()
    End Sub
    Sub LAPORAN()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\User\My Documents\Visual Studio 2008\Projects\klinik\klinik\Cetak_Pendaftaran.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class