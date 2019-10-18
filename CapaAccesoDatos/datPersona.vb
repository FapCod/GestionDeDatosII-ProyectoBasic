Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datPersona
    Public Function nuevo(objPersona As entPersona) As Boolean
        Try
            Dim objdao As New datConexion
            'Dim dt As DataTable
            'Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO persona VALUES(@nom,@app,@edad,@sexo)"

            cmd.Parameters.AddWithValue("@nom", objPersona.nombres)
            cmd.Parameters.AddWithValue("@app", objPersona.apellidos)
            cmd.Parameters.AddWithValue("@edad", objPersona.edad)
            cmd.Parameters.AddWithValue("@sexo", objPersona.sexo)
            objdao.BaseDatos = "gestionDII"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try

        Return False
    End Function
    Public Function actualizar(objPersona As entPersona, id As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            'Dim dt As DataTable
            'Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            'Dim id As Integer
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update PERSONA set NOMBRE = @nom, APELLIDO = @app, EDAD = @edad, SEXO= @sexo where idPersona =@id"
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nom", objPersona.nombres)
            cmd.Parameters.AddWithValue("@app", objPersona.apellidos)
            cmd.Parameters.AddWithValue("@edad", objPersona.edad)
            cmd.Parameters.AddWithValue("@sexo", objPersona.sexo)
            objdao.BaseDatos = "gestionDII"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try

        Return False
    End Function
    Public Function eliminar(id As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            'Dim dt As DataTable
            'Dim da As SqlDataAdapter
            Dim cmd As New SqlCommand
            'Dim id As Integer
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "EXEC EliminarPersona  @id"
            cmd.Parameters.AddWithValue("@id", id)
            objdao.BaseDatos = "gestionDII"
            objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try

        Return False
    End Function
    Public Function getDataTable(ByVal query As String) As DataTable
        Dim dt As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cadena = "Server=FAPCOD\SQLEXPRESS;DataBase=gestionDII; integrated security=true"
        cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim cmd As New SqlCommand(query, cnn)
        Dim dt1 As New DataTable
        dt1.Load(cmd.ExecuteReader())
        Return dt1
    End Function
    Public Function getDataTableLike(ByVal query As String) As DataTable
        'Dim dt As DataTable
        Dim cnn As SqlConnection
        Dim cadena As String
        cadena = "Server=FAPCOD\SQLEXPRESS;DataBase=gestionDII; integrated security=true"
        cnn = New SqlConnection(cadena)
        cnn.Open()
        Dim da = New SqlDataAdapter(query, cnn)
        'Dim cmd As New SqlCommand(query, cnn)
        Dim dt1 As New DataTable
        da.Fill(dt1)
        Return dt1
    End Function

End Class
