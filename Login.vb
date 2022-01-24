Imports LMS.DataConfig
Imports Guna.UI2.WinForms

Public Class Login
    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        If CheckFields() Then
            Functions.TryLogin(tb_user.Text, tb_pass.Text)
        End If
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        dialog.Text = "Do you want to exit?"
        dialog.Icon = MessageDialogIcon.Information
        dialog.Caption = "Confirmation"
        dialog.Buttons = MessageDialogButtons.YesNo
        If Me.dialog.Show() = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Function CheckFields() As Boolean
        Dim ctlList As New List(Of Guna2TextBox)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Guna2TextBox Then
                If String.IsNullOrEmpty(CType(ctrl, Guna2TextBox).Text) OrElse String.IsNullOrWhiteSpace(CType(ctrl, Guna2TextBox).Text) Then
                    ctlList.Add(CType(ctrl, Guna2TextBox))
                End If
            End If
        Next

        If ctlList.Count > 0 Then
            dialog.Text = "Please fill up empty fields"
            dialog.Icon = MessageDialogIcon.Error
            dialog.Caption = "Invalid Inputs"
            dialog.Buttons = MessageDialogButtons.OK
            dialog.Show()
            For i As SByte = ctlList.Count - 1 To 0 Step -1
                ctlList(i).FillColor = Color.FromArgb(255, 204, 153)
            Next
            ctlList(ctlList.Count - 1).Focus()
        Else
            Return True
        End If

        Return False
    End Function

    Private Sub tb_textchanged(sender As Object, e As EventArgs) Handles tb_user.TextChanged, tb_pass.TextChanged
        tb_user.FillColor = Color.White
        tb_pass.FillColor = Color.White
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub
End Class
