Public Class Frm_perfil_usuario

    Enum Opcion
        insert
        update
        delete
    End Enum

    Private Sub Frm_perfil_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub seleccionar_usuario(ByVal tabla As DataTable)
        txt_nombre.Text = tabla.Rows(0).Item("nombre").ToString()

    End Sub


End Class