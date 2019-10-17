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



End Class
