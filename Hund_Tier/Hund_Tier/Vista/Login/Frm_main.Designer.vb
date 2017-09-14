<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_main
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
        Me.mnu_frm_main = New System.Windows.Forms.MenuStrip()
        Me.MiPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_nombre_usuario = New System.Windows.Forms.Label()
        Me.lbl_img_user = New System.Windows.Forms.Label()
        Me.mnu_frm_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_frm_main
        '
        Me.mnu_frm_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiPerfilToolStripMenuItem})
        Me.mnu_frm_main.Location = New System.Drawing.Point(0, 0)
        Me.mnu_frm_main.Name = "mnu_frm_main"
        Me.mnu_frm_main.Size = New System.Drawing.Size(284, 24)
        Me.mnu_frm_main.TabIndex = 0
        Me.mnu_frm_main.Text = "MenuStrip1"
        '
        'MiPerfilToolStripMenuItem
        '
        Me.MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem"
        Me.MiPerfilToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MiPerfilToolStripMenuItem.Text = "Mi perfil"
        '
        'lbl_nombre_usuario
        '
        Me.lbl_nombre_usuario.AutoSize = True
        Me.lbl_nombre_usuario.Location = New System.Drawing.Point(225, 45)
        Me.lbl_nombre_usuario.Name = "lbl_nombre_usuario"
        Me.lbl_nombre_usuario.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre_usuario.TabIndex = 1
        Me.lbl_nombre_usuario.Text = "Label1"
        Me.lbl_nombre_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_img_user
        '
        Me.lbl_img_user.AutoSize = True
        Me.lbl_img_user.Image = Global.Hund_Tier.My.Resources.Resources.user_log
        Me.lbl_img_user.Location = New System.Drawing.Point(189, 37)
        Me.lbl_img_user.MinimumSize = New System.Drawing.Size(30, 30)
        Me.lbl_img_user.Name = "lbl_img_user"
        Me.lbl_img_user.Size = New System.Drawing.Size(30, 30)
        Me.lbl_img_user.TabIndex = 2
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lbl_img_user)
        Me.Controls.Add(Me.lbl_nombre_usuario)
        Me.Controls.Add(Me.mnu_frm_main)
        Me.MainMenuStrip = Me.mnu_frm_main
        Me.Name = "Frm_main"
        Me.Text = "Hund Tier"
        Me.mnu_frm_main.ResumeLayout(False)
        Me.mnu_frm_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_frm_main As MenuStrip
    Friend WithEvents MiPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_nombre_usuario As Label
    Friend WithEvents lbl_img_user As Label
End Class
