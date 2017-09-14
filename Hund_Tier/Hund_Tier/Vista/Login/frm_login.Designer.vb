<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_sinCuenta = New System.Windows.Forms.Label()
        Me.lbl_registrate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(42, 13)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 0
        Me.lbl_email.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(80, 10)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(160, 20)
        Me.txt_email.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(80, 36)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(160, 20)
        Me.txt_password.TabIndex = 3
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(13, 39)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(61, 13)
        Me.lbl_password.TabIndex = 2
        Me.lbl_password.Text = "Contraseña"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(266, 68)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(185, 68)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_sinCuenta
        '
        Me.lbl_sinCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_sinCuenta.AutoSize = True
        Me.lbl_sinCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_sinCuenta.Location = New System.Drawing.Point(250, 18)
        Me.lbl_sinCuenta.Name = "lbl_sinCuenta"
        Me.lbl_sinCuenta.Size = New System.Drawing.Size(99, 13)
        Me.lbl_sinCuenta.TabIndex = 8
        Me.lbl_sinCuenta.Text = "¿No tenes usuario?"
        '
        'lbl_registrate
        '
        Me.lbl_registrate.AutoSize = True
        Me.lbl_registrate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_registrate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_registrate.Location = New System.Drawing.Point(272, 35)
        Me.lbl_registrate.Name = "lbl_registrate"
        Me.lbl_registrate.Size = New System.Drawing.Size(61, 13)
        Me.lbl_registrate.TabIndex = 9
        Me.lbl_registrate.Text = "!Registrate!"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 97)
        Me.Controls.Add(Me.lbl_registrate)
        Me.Controls.Add(Me.lbl_sinCuenta)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_email)
        Me.Name = "frm_login"
        Me.Text = "Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_sinCuenta As Label
    Friend WithEvents lbl_registrate As Label
End Class
