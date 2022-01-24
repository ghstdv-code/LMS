Public Class MainForm
    Private Sub datetime_Tick(sender As Object, e As EventArgs) Handles datetime.Tick
        lb_datenow.Text = $"Date: {Date.UtcNow.AddHours(8).ToString("MMMM dd, yyyy HH:mm:ss tt")} UTC+8"
    End Sub

    Private Sub bt_add_borrow_Click(sender As Object, e As EventArgs) Handles bt_add_borrow.Click
        Dim tform As New TransactInfo()
        tform.ShowDialog()
        tform.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


