Imports CrystalDecisions.CrystalReports.Engine
Public Class form_rekam_medis

    Private Sub form_rekam_medis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LAPORAN()
    End Sub

    Sub LAPORAN()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\User\My Documents\Visual Studio 2008\Projects\klinik\klinik\Laporan_Rekam_Medis.rpt")
        crv.ReportSource = cryRpt

    End Sub
End Class