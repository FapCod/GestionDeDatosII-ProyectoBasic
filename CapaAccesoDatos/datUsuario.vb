Imports System.Data.SqlClient
Imports CapaEntidad
Imports CapaAccesoDatos
Public Class datUsuario
    Inherits datConexion
    Public Function nuevo(objUsuario As entUsuario) As Boolean
        Try
            Dim objdao As New datConexion
            'Dim dt As DataTable
            'Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Users VALUES(@user,@pass)"

            cmd.Parameters.AddWithValue("@user", objUsuario.userName)
            cmd.Parameters.AddWithValue("@pass", objUsuario.passuser)

            objdao.BaseDatos = "gestionDII"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex")
        End Try

        Return False
    End Function


    Public Function existsUser(username As String, pass As String) As Boolean
        Using connection = Conectar()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from users where  userName=@userName and passUser=@pass"

                command.Parameters.AddWithValue("@userName", username)
                command.Parameters.AddWithValue("@pass", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function Login(user As String, pass As String) As Boolean
        'se usa using porque al terminar el proceso automaticamente sera liberada la memoria dependiendo de lo que haya estado ejecutandose.
        Using connection = Conectar()
            connection.Open()
            Using Comman = New SqlCommand()
                Comman.Connection = connection
                Comman.CommandText = "Select * from users Where userName=@user and passUser= @pass"
                Comman.Parameters.AddWithValue("@user", user)
                Comman.Parameters.AddWithValue("@pass", pass)
                Comman.CommandType = CommandType.Text
                Dim reader = Comman.ExecuteReader()
                'si la variable reader tiene filas entonces retornara true 
                If reader.HasRows Then

                    'While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                    '    ActiveUser.idUser = reader.GetInt32(0)
                    '    ActiveUser.userName = reader.GetString(1)
                    '    ActiveUser.passUser = reader.GetString(2)
                    '    ActiveUser.firstName = reader.GetString(3)
                    '    ActiveUser.lastName = reader.GetString(4)
                    '    ActiveUser.position = reader.GetString(5)
                    '    ActiveUser.email = reader.GetString(6)
                    'End While
                    'reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
End Class
