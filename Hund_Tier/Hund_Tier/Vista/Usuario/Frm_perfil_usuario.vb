Public Class Frm_perfil_usuario
    Private Property usuario As Usuario
    Private Property bandera_edicion = False

    Enum Opcion
        insert
        update
        delete
    End Enum

    Private Sub Frm_perfil_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ni bien carga el formulario se llenan los campos con los datos del usuario que
        'fue pasado por parametro por frm_main
        llenar_campos()


    End Sub

    'Funcion que nos permite recibir el usuario pasado desde cualquier otra form para
    'cargar los campos con los datos de dicho usuario.
    'TODO agregar un segundo parametro para que verifique como entra a este formulario
    'si es update o que.
    Public Sub seleccionar_usuario(ByVal user As Usuario)
        usuario = user
        'Obtengo el nombre del usuario con el que voy a recuperar los datos
        'de la BD
        Dim strSql = "Select U.nombre, U.apellido, U.email, U.password, U.username, B.nombre AS 'nombre_barrio'"
        strSql += " From usuarios  U Join barrios B on U.id_barrio = B.id_barrio"
        strSql += " WHERE U.username = '" & user.getUsername & "'"
        Dim tabla = BDHelper.getDBHelper.ConsultaSQL(strSql)
        If tabla.Rows.Count > 0 Then
            usuario.setNombre(tabla.Rows(0).Item("nombre").ToString)
            usuario.setEmail(tabla.Rows(0).Item("email").ToString)
            usuario.setUsername(tabla.Rows(0).Item("username").ToString)
            usuario.setApellido(tabla.Rows(0).Item("apellido").ToString)
            usuario.setBarrio(tabla.Rows(0).Item("nombre_barrio").ToString)
            usuario.setPassword(tabla.Rows(0).Item("password").ToString)
        End If
    End Sub

    Private Sub llenar_campos()
        txt_nombre.Text = usuario.getNombre
        txt_apellido.Text = usuario.getApellido
        txt_email.Text = usuario.getEmail
        txt_username.Text = usuario.getUsername
        txt_barrio.Text = usuario.getBarrio
        txt_password.Text = usuario.getPassword

    End Sub

    Private Sub btn_modificar_info_Click(sender As Object, e As EventArgs) Handles btn_modificar_info.Click
        bandera_edicion = True
        permitir_edicion(bandera_edicion)
    End Sub

    Private Sub permitir_edicion(ByVal valor As Boolean)
        If valor Then
            txt_nombre.ReadOnly = True
            txt_apellido.ReadOnly = True
            txt_telefono.ReadOnly = True
            txt_calle.ReadOnly = True
            txt_numero.ReadOnly = True
            txt_piso.ReadOnly = True
            txt_depto.ReadOnly = True
        End If
    End Sub
End Class