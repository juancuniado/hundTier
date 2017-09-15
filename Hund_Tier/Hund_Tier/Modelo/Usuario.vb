Public Class Usuario
    Private Property idUsuario As Integer
    Private Property nombre As String
    Private Property username As String
    Private Property email As String


    Public Function getIdUsuario() As Integer
        Return idUsuario
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getEmail() As String
        Return email
    End Function

    Public Sub setNombre(ByVal nombreUsuario As String)
        nombre = nombreUsuario
    End Sub

    Public Sub setUsername(ByVal nombreUsuario As String)
        username = nombreUsuario
    End Sub

    Public Sub setEmail(ByVal emailUsuario As String)
        email = emailUsuario
    End Sub


    Public Overrides Function toString() As String
        Return nombre
    End Function



End Class
