﻿Imports CrystalDecisions.CrystalReports.Engine
Public Class form_kunjungan_perpasien

    Private Sub form_kunjungan_perpasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LAPORAN()
    End Sub

    Sub LAPORAN()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\User\My Documents\Visual Studio 2008\Projects\klinik\klinik\Laporan_Kunjungan_Perpasien.rpt")
        crv.ReportSource = cryRpt

    End Sub
End Class