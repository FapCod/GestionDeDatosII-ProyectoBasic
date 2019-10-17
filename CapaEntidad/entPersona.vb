Public Class entPersona
    Private _nombre As String
    Private _apellido As String
    Private _edad As String
    Private _sexo As Char


    Public Property nombres As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property apellidos As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property edad As String
        Get
            Return _edad
        End Get
        Set(value As String)
            _edad = value
        End Set
    End Property
    Public Property sexo As Char
        Get
            Return _sexo
        End Get
        Set(value As Char)
            _sexo = value
        End Set
    End Property

End Class
