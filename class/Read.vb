Imports MySql.Data.MySqlClient


Public Class Read
    Inherits DataConfig

    Public Shared _User As User

    Public Shared Function FindUser() As User
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `tb_user` WHERE username=@user && password=@pass")
        cmd.Connection = con

        cmd.Parameters.AddWithValue("@user", _User.Username)
        cmd.Parameters.AddWithValue("@pass", _User.Password)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            _User.Id = reader("id")
            _User.Role = reader("role")
        Else
            Login.dialog.Text = "Username or Password Incorrect!!"
            Login.dialog.Show()
        End If

        reader.Close()

        Return _User
    End Function

End Class
