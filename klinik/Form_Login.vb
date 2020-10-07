Public Class Form_Login

    Private Sub Form_Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        username.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(username.Text) = "" Then
            MessageBox.Show("Username Dan Password Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End If

        If username.Text = "admin" And password.Text = "klinik" Then
            MsgBox("Login Sukses")
            Form_Main.Show()
            Me.Hide()
        Else
            MsgBox("Username atau Password Anda Salah")
            username.Clear()
            password.Clear()
        End If
    End Sub

    Private Sub username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = Chr(13) Then
            password.Focus()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

End Class


