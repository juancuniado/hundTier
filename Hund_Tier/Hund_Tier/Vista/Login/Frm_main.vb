Public Class Frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario principal cargamos y mostramos el formulario: Frm_login en forma MODAL.
        mnu_frm_main.Visible = False
        frm_login.ShowDialog()
    End Sub

    Public Sub actualizarUsuarioLogueado(ByVal userLogin As String)
        lbl_nombre_usuario.Text = userLogin
        mnu_frm_main.Visible = True
    End Sub

    Private Sub MiPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiPerfilToolStripMenuItem.Click
        'Obtengo el nombre del usuario con el que voy a recuperar los datos
        'de la BD
        Dim nombre_usuario = lbl_nombre_usuario.Text
        Dim strSql = "SELECT * FROM Usuarios WHERE username='" & nombre_usuario & "'"
        Dim tabla = BDHelper.getDBHelper.ConsultaSQL(strSql)
        If tabla.Rows.Count > 0 Then
            Frm_perfil_usuario.seleccionar_usuario(tabla)
        End If


        Frm_perfil_usuario.ShowDialog()
    End Sub
End Class