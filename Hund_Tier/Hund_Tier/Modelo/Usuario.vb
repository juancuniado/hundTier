Public Class Usuario
    Private Property idUsuario As Integer
    Private Property nombre As String
    Private Property apellido As String
    Private Property barrio As String
    Private Property username As String
    Private Property email As String
    Private Property contrasena As String



    Public Function getIdUsuario() As Integer
        Return idUsuario
    End Function

    Public Function getBarrio() As String
        Return barrio
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getApellido() As String
        Return apellido
    End Function

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getEmail() As String
        Return email
    End Function
    Public Function getPassword() As String
        Return contrasena
    End Function

    Public Sub setNombre(ByVal nombreUsuario As String)
        nombre = nombreUsuario
    End Sub
    Public Sub setApellido(ByVal apellido_usuario As String)
        apellido = apellido_usuario
    End Sub

    Public Sub setUsername(ByVal nombreUsuario As String)
        username = nombreUsuario
    End Sub

    Public Sub setEmail(ByVal emailUsuario As String)
        email = emailUsuario
    End Sub
    Public Sub setBarrio(ByVal nuevoBarrioId As String)
        barrio = nuevoBarrioId
    End Sub
    Public Sub setPassword(ByVal contra As String)
        contrasena = contra
    End Sub

    Public Overrides Function toString() As String
        Return nombre
    End Function



End Class
