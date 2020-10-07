Public Class Splash

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick

        Dim f_utama As New Form_Login
        tmr.Enabled = True
        pgb.Value += 10
        If pgb.Value = 200 Then
            tmr.Dispose()
            Me.Visible = False
            f_utama = New Form_Login
            f_utama.Show()

        End If
    End Sub

End Class
