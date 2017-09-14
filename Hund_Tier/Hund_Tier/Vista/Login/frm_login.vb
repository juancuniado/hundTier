Public Class frm_login
    Private flagSalir As Boolean = True

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim strSQL As String
        Dim tabla As DataTable
        'Validamos que las cajas no esten vacías
        'If String.IsNullOrEmpty(txt_password.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
        If txt_password.Text = String.Empty Or txt_email.Text = String.Empty Then
            MessageBox.Show("Olvidó ingresar email y/o password", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            strSQL = "Select u.email AS 'email_usuario' , u.nombre AS 'nombre_usuario' From Usuarios u Where u.email = '" & txt_email.Text & "' AND u.password = '" & txt_password.Text & "'"
            tabla = BDHelper.getDBHelper().ConsultaSQL(strSQL)
            If tabla.Rows.Count > 0 Then
                'lbl_prueba.Text = "Nombre usuario: " & tabla.Rows(0).Item("nombre_usuario").ToString()
                Frm_main.actualizarUsuarioLogueado("Usuario: " & tabla.Rows(0).Item("nombre_usuario").ToString())
                flagSalir = False
                Me.Close()
            Else
                MessageBox.Show("Usuario y/o password incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
                txt_password.Text = String.Empty
                txt_email.Text = String.Empty
                txt_email.Focus()
            End If
        End If
    End Sub

    Private Sub lbl_registrate_Click(sender As Object, e As EventArgs) Handles lbl_registrate.Click
        frm_UsuarioABM.ShowDialog()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        solicitar_iniciar_sesion()
    End Sub

    'Funcion que solo muestra una ventana informando sobre la necesidad de ingresar usuario y contraseña
    Friend Sub solicitar_iniciar_sesion()
        MessageBox.Show("Por favor ingrese su email y contraseña", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'End termina la ejecucion de la app
        End
    End Sub
End Class