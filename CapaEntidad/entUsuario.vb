Public Class entUsuario
    Private _username As String
    Private _passuser As String
   

    
    Public Property userName As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
    Public Property passuser As String
        Get
            Return _passuser
        End Get
        Set(value As String)
            _passuser = value
        End Set
    End Property
    
    

End Class

