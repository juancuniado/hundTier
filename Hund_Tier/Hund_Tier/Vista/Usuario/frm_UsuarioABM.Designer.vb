<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UsuarioABM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_info_mail = New System.Windows.Forms.Label()
        Me.lbl_info_username = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.grpbx_datosPersonales = New System.Windows.Forms.GroupBox()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.grpbx_datosUsuario = New System.Windows.Forms.GroupBox()
        Me.lbl_info_confirmar_password = New System.Windows.Forms.Label()
        Me.lbl_info_password = New System.Windows.Forms.Label()
        Me.lbl_confirmarPass = New System.Windows.Forms.Label()
        Me.txt_confirmarPass = New System.Windows.Forms.TextBox()
        Me.lbl_pasword = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_add_user = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.grpbx_datosPersonales.SuspendLayout()
        Me.grpbx_datosUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(0, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(50, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre: "
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(56, 19)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(203, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(56, 45)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(203, 20)
        Me.txt_apellido.TabIndex = 3
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(0, 48)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 2
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(56, 14)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(247, 20)
        Me.txt_email.TabIndex = 5
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(15, 17)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(35, 13)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "Email:"
        '
        'lbl_info_mail
        '
        Me.lbl_info_mail.AutoSize = True
        Me.lbl_info_mail.Location = New System.Drawing.Point(309, 17)
        Me.lbl_info_mail.Name = "lbl_info_mail"
        Me.lbl_info_mail.Size = New System.Drawing.Size(16, 13)
        Me.lbl_info_mail.TabIndex = 6
        Me.lbl_info_mail.Text = "---"
        '
        'lbl_info_username
        '
        Me.lbl_info_username.AutoSize = True
        Me.lbl_info_username.Location = New System.Drawing.Point(218, 89)
        Me.lbl_info_username.Name = "lbl_info_username"
        Me.lbl_info_username.Size = New System.Drawing.Size(16, 13)
        Me.lbl_info_username.TabIndex = 9
        Me.lbl_info_username.Text = "---"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(114, 88)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(97, 20)
        Me.txt_username.TabIndex = 8
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(15, 91)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(99, 13)
        Me.lbl_username.TabIndex = 7
        Me.lbl_username.Text = "Nombre de usuario:"
        '
        'grpbx_datosPersonales
        '
        Me.grpbx_datosPersonales.Controls.Add(Me.cmb_barrio)
        Me.grpbx_datosPersonales.Controls.Add(Me.lbl_barrio)
        Me.grpbx_datosPersonales.Controls.Add(Me.txt_nombre)
        Me.grpbx_datosPersonales.Controls.Add(Me.lbl_nombre)
        Me.grpbx_datosPersonales.Controls.Add(Me.lbl_apellido)
        Me.grpbx_datosPersonales.Controls.Add(Me.txt_apellido)
        Me.grpbx_datosPersonales.Location = New System.Drawing.Point(13, 13)
        Me.grpbx_datosPersonales.Name = "grpbx_datosPersonales"
        Me.grpbx_datosPersonales.Size = New System.Drawing.Size(267, 100)
        Me.grpbx_datosPersonales.TabIndex = 10
        Me.grpbx_datosPersonales.TabStop = False
        Me.grpbx_datosPersonales.Text = "Datos personales"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(56, 73)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(203, 21)
        Me.cmb_barrio.TabIndex = 5
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(0, 71)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_barrio.TabIndex = 4
        Me.lbl_barrio.Text = "Barrio:"
        '
        'grpbx_datosUsuario
        '
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_info_confirmar_password)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_info_password)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_confirmarPass)
        Me.grpbx_datosUsuario.Controls.Add(Me.txt_confirmarPass)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_pasword)
        Me.grpbx_datosUsuario.Controls.Add(Me.txt_password)
        Me.grpbx_datosUsuario.Controls.Add(Me.txt_username)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_email)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_info_username)
        Me.grpbx_datosUsuario.Controls.Add(Me.txt_email)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_info_mail)
        Me.grpbx_datosUsuario.Controls.Add(Me.lbl_username)
        Me.grpbx_datosUsuario.Location = New System.Drawing.Point(13, 119)
        Me.grpbx_datosUsuario.Name = "grpbx_datosUsuario"
        Me.grpbx_datosUsuario.Size = New System.Drawing.Size(331, 114)
        Me.grpbx_datosUsuario.TabIndex = 11
        Me.grpbx_datosUsuario.TabStop = False
        Me.grpbx_datosUsuario.Text = "Crea un usuario"
        '
        'lbl_info_confirmar_password
        '
        Me.lbl_info_confirmar_password.AutoSize = True
        Me.lbl_info_confirmar_password.Location = New System.Drawing.Point(309, 65)
        Me.lbl_info_confirmar_password.Name = "lbl_info_confirmar_password"
        Me.lbl_info_confirmar_password.Size = New System.Drawing.Size(16, 13)
        Me.lbl_info_confirmar_password.TabIndex = 15
        Me.lbl_info_confirmar_password.Text = "---"
        '
        'lbl_info_password
        '
        Me.lbl_info_password.AutoSize = True
        Me.lbl_info_password.Location = New System.Drawing.Point(309, 47)
        Me.lbl_info_password.Name = "lbl_info_password"
        Me.lbl_info_password.Size = New System.Drawing.Size(16, 13)
        Me.lbl_info_password.TabIndex = 14
        Me.lbl_info_password.Text = "---"
        '
        'lbl_confirmarPass
        '
        Me.lbl_confirmarPass.AutoSize = True
        Me.lbl_confirmarPass.Location = New System.Drawing.Point(6, 65)
        Me.lbl_confirmarPass.Name = "lbl_confirmarPass"
        Me.lbl_confirmarPass.Size = New System.Drawing.Size(110, 13)
        Me.lbl_confirmarPass.TabIndex = 12
        Me.lbl_confirmarPass.Text = "Confirmar contraseña:"
        '
        'txt_confirmarPass
        '
        Me.txt_confirmarPass.Location = New System.Drawing.Point(122, 62)
        Me.txt_confirmarPass.Name = "txt_confirmarPass"
        Me.txt_confirmarPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmarPass.Size = New System.Drawing.Size(181, 20)
        Me.txt_confirmarPass.TabIndex = 13
        '
        'lbl_pasword
        '
        Me.lbl_pasword.AutoSize = True
        Me.lbl_pasword.Location = New System.Drawing.Point(6, 47)
        Me.lbl_pasword.Name = "lbl_pasword"
        Me.lbl_pasword.Size = New System.Drawing.Size(64, 13)
        Me.lbl_pasword.TabIndex = 10
        Me.lbl_pasword.Text = "Contraseña:"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(122, 40)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(181, 20)
        Me.txt_password.TabIndex = 11
        '
        'btn_add_user
        '
        Me.btn_add_user.Location = New System.Drawing.Point(268, 260)
        Me.btn_add_user.Name = "btn_add_user"
        Me.btn_add_user.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_user.TabIndex = 12
        Me.btn_add_user.Text = "Registrarme"
        Me.btn_add_user.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(187, 260)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_UsuarioABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 295)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_add_user)
        Me.Controls.Add(Me.grpbx_datosUsuario)
        Me.Controls.Add(Me.grpbx_datosPersonales)
        Me.Name = "frm_UsuarioABM"
        Me.Text = "frm_UsuarioABM"
        Me.grpbx_datosPersonales.ResumeLayout(False)
        Me.grpbx_datosPersonales.PerformLayout()
        Me.grpbx_datosUsuario.ResumeLayout(False)
        Me.grpbx_datosUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_info_mail As Label
    Friend WithEvents lbl_info_username As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents grpbx_datosPersonales As GroupBox
    Friend WithEvents grpbx_datosUsuario As GroupBox
    Friend WithEvents lbl_pasword As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_confirmarPass As Label
    Friend WithEvents txt_confirmarPass As TextBox
    Friend WithEvents lbl_info_confirmar_password As Label
    Friend WithEvents lbl_info_password As Label
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents lbl_barrio As Label
    Friend WithEvents btn_add_user As Button
    Friend WithEvents btn_cancelar As Button
End Class
