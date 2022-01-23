Imports LMS.DataConfig

Public Class Login
    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        Functions.TryLogin(Me.tb_user.Text, Me.tb_pass.Text)
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        dialog.Text = "Do you want to exit?"
        dialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        dialog.Caption = "Confirmation"
        dialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        If Me.dialog.Show() = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
