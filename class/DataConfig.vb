Imports MySql.Data.MySqlClient

Public Class DataConfig
    Private Shared ReadOnly Property _duser = "root"
    Private Shared Property _passw = ""
    Protected Shared ReadOnly con As MySqlConnection = New MySqlConnection($"server=localhost;database=lms_db; user={_duser}; password={_passw};")
    Shared Function Connect() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Shared Function DisConnect() As Boolean
        Try
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
End Class
