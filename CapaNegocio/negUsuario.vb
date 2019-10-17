Imports CapaAccesoDatos
Imports CapaEntidad
Public Class negUsuario
    'Condiciones para crear un Usuario
    Public Function nuevo(objUsuario As entUsuario) As Boolean
        Dim objdat As New datUsuario
        If objUsuario.passuser.Length < 8 Then
            Return False
        End If
        Return objdat.nuevo(objUsuario)
    End Function
    'Condiciones para crear Persona
    Public Function nuevoPersona(objPersona As entPersona) As Boolean
        Dim objdatP As New datPersona
        If objPersona.edad >= 100 Then
            Return False
        End If
        Return objdatP.nuevo(objPersona)
    End Function
    'Login Condicion
    Dim userDao As New datUsuario()
    'se crea una funcion que llama a otra para el login
    Public Function login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function
End Class