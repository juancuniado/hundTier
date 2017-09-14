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
        frm_UsuarioABM.ShowDialog()
    End Sub
End Class