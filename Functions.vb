Imports LMS.DataConfig

Public Class Functions
    Public Shared Sub TryLogin(ByRef user As String, ByRef pass As String)
        Connect()
        Read._User = New User(user, pass)
        Dim usr As User = Read.FindUser
        If Not (String.IsNullOrEmpty(usr.Role)) Then
            MessageBox.Show($"Id: {usr.Id}{vbCrLf}Role: {usr.Role}")
        End If
        DisConnect()
    End Sub
End Class
