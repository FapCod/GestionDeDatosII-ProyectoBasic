Imports System.Data.SqlClient
Public Class datConexion


    Public cnn As SqlConnection
    Private _BaseDatos As String
    Private _Servidor As String
    Public Property BaseDatos As String
        Get
            Return _BaseDatos
        End Get
        Set(value As String)
            _BaseDatos = value
        End Set
    End Property
    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property
    Public Function Conectar(usuario As String, contrasena As String,
                             autenticacion As Boolean) As Boolean
        Dim cadena As String
        cadena = "Data Source=" + _Servidor + ";Initial Catalog=" + _BaseDatos
        If autenticacion Then
            cadena = cadena & ";Integrated Security=True"
        Else
            cadena = cadena & ";User Id=" & usuario &
                ";Password=" & contrasena
        End If
        Try
            cnn = New SqlConnection(cadena)
            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Protected Function Conectar() As SqlConnection
        Return New SqlConnection("Server=FAPCOD\SQLEXPRESS;DataBase=gestionDII; integrated security=true")
    End Function

    ''segundo metodo para acceder
    'Private connectionString As String
    'Protected Sub New()
    '    connectionString = "Server=FAPCOD\SQLEXPRESS;DataBase=gestionDII; integrated security=true"
    'End Sub
    ''Las funciones son protegidas porque no quiero que sean modificas del exterior sino que solo sean modificadas desde el mismo codigo.
    'Protected Function GetConnection() As SqlConnection
    '    Return New SqlConnection(connectionString)
    'End Function
End Class
