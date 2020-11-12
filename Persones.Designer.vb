<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Persones))
        Me.boto_minimitzar = New System.Windows.Forms.Button()
        Me.boto_tancar = New System.Windows.Forms.Button()
        Me.taula_dades = New System.Windows.Forms.DataGridView()
        Me.tag_nom = New System.Windows.Forms.Label()
        Me.text_nom = New System.Windows.Forms.TextBox()
        Me.text_cognom = New System.Windows.Forms.TextBox()
        Me.tag_cognom = New System.Windows.Forms.Label()
        Me.text_edat = New System.Windows.Forms.TextBox()
        Me.tag_edat = New System.Windows.Forms.Label()
        Me.text_territori = New System.Windows.Forms.TextBox()
        Me.tag_territori = New System.Windows.Forms.Label()
        Me.text_capacitat = New System.Windows.Forms.TextBox()
        Me.tag_capacitat = New System.Windows.Forms.Label()
        Me.text_espai = New System.Windows.Forms.TextBox()
        Me.tag_espai = New System.Windows.Forms.Label()
        Me.text_educacio = New System.Windows.Forms.TextBox()
        Me.tag_educacio = New System.Windows.Forms.Label()
        Me.text_gremi = New System.Windows.Forms.TextBox()
        Me.tag_gremi = New System.Windows.Forms.Label()
        Me.boto_afegir = New System.Windows.Forms.Button()
        Me.boto_borrar = New System.Windows.Forms.Button()
        Me.boto_actualitzar = New System.Windows.Forms.Button()
        Me.boto_cancelar = New System.Windows.Forms.Button()
        Me.logo_onu = New System.Windows.Forms.PictureBox()
        CType(Me.taula_dades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_onu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boto_minimitzar
        '
        Me.boto_minimitzar.BackColor = System.Drawing.Color.Black
        Me.boto_minimitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_minimitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_minimitzar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.boto_minimitzar.Location = New System.Drawing.Point(1007, -2)
        Me.boto_minimitzar.Name = "boto_minimitzar"
        Me.boto_minimitzar.Size = New System.Drawing.Size(56, 49)
        Me.boto_minimitzar.TabIndex = 5
        Me.boto_minimitzar.Text = "—"
        Me.boto_minimitzar.UseVisualStyleBackColor = False
        '
        'boto_tancar
        '
        Me.boto_tancar.BackColor = System.Drawing.Color.Black
        Me.boto_tancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_tancar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_tancar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.boto_tancar.Location = New System.Drawing.Point(1060, -2)
        Me.boto_tancar.Name = "boto_tancar"
        Me.boto_tancar.Size = New System.Drawing.Size(56, 49)
        Me.boto_tancar.TabIndex = 4
        Me.boto_tancar.Text = "x"
        Me.boto_tancar.UseVisualStyleBackColor = False
        '
        'taula_dades
        '
        Me.taula_dades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_dades.Location = New System.Drawing.Point(685, 110)
        Me.taula_dades.Name = "taula_dades"
        Me.taula_dades.RowHeadersWidth = 51
        Me.taula_dades.RowTemplate.Height = 24
        Me.taula_dades.Size = New System.Drawing.Size(394, 414)
        Me.taula_dades.TabIndex = 12
        '
        'tag_nom
        '
        Me.tag_nom.AutoSize = True
        Me.tag_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_nom.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_nom.Location = New System.Drawing.Point(65, 142)
        Me.tag_nom.Name = "tag_nom"
        Me.tag_nom.Size = New System.Drawing.Size(67, 29)
        Me.tag_nom.TabIndex = 13
        Me.tag_nom.Text = "Nom"
        '
        'text_nom
        '
        Me.text_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nom.Location = New System.Drawing.Point(138, 139)
        Me.text_nom.Name = "text_nom"
        Me.text_nom.Size = New System.Drawing.Size(192, 36)
        Me.text_nom.TabIndex = 14
        '
        'text_cognom
        '
        Me.text_cognom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_cognom.Location = New System.Drawing.Point(138, 204)
        Me.text_cognom.Name = "text_cognom"
        Me.text_cognom.Size = New System.Drawing.Size(192, 36)
        Me.text_cognom.TabIndex = 16
        '
        'tag_cognom
        '
        Me.tag_cognom.AutoSize = True
        Me.tag_cognom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_cognom.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_cognom.Location = New System.Drawing.Point(23, 207)
        Me.tag_cognom.Name = "tag_cognom"
        Me.tag_cognom.Size = New System.Drawing.Size(109, 29)
        Me.tag_cognom.TabIndex = 15
        Me.tag_cognom.Text = "Cognom"
        '
        'text_edat
        '
        Me.text_edat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_edat.Location = New System.Drawing.Point(138, 268)
        Me.text_edat.Name = "text_edat"
        Me.text_edat.Size = New System.Drawing.Size(192, 36)
        Me.text_edat.TabIndex = 18
        '
        'tag_edat
        '
        Me.tag_edat.AutoSize = True
        Me.tag_edat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_edat.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_edat.Location = New System.Drawing.Point(65, 271)
        Me.tag_edat.Name = "tag_edat"
        Me.tag_edat.Size = New System.Drawing.Size(65, 29)
        Me.tag_edat.TabIndex = 17
        Me.tag_edat.Text = "Edat"
        '
        'text_territori
        '
        Me.text_territori.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_territori.Location = New System.Drawing.Point(138, 338)
        Me.text_territori.Name = "text_territori"
        Me.text_territori.Size = New System.Drawing.Size(192, 36)
        Me.text_territori.TabIndex = 20
        '
        'tag_territori
        '
        Me.tag_territori.AutoSize = True
        Me.tag_territori.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_territori.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_territori.Location = New System.Drawing.Point(33, 341)
        Me.tag_territori.Name = "tag_territori"
        Me.tag_territori.Size = New System.Drawing.Size(99, 29)
        Me.tag_territori.TabIndex = 19
        Me.tag_territori.Text = "Territori"
        '
        'text_capacitat
        '
        Me.text_capacitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_capacitat.Location = New System.Drawing.Point(471, 131)
        Me.text_capacitat.Name = "text_capacitat"
        Me.text_capacitat.Size = New System.Drawing.Size(192, 36)
        Me.text_capacitat.TabIndex = 22
        '
        'tag_capacitat
        '
        Me.tag_capacitat.AutoSize = True
        Me.tag_capacitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_capacitat.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_capacitat.Location = New System.Drawing.Point(346, 134)
        Me.tag_capacitat.Name = "tag_capacitat"
        Me.tag_capacitat.Size = New System.Drawing.Size(120, 29)
        Me.tag_capacitat.TabIndex = 21
        Me.tag_capacitat.Text = "Capacitat"
        '
        'text_espai
        '
        Me.text_espai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_espai.Location = New System.Drawing.Point(471, 204)
        Me.text_espai.Name = "text_espai"
        Me.text_espai.Size = New System.Drawing.Size(192, 36)
        Me.text_espai.TabIndex = 24
        '
        'tag_espai
        '
        Me.tag_espai.AutoSize = True
        Me.tag_espai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_espai.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_espai.Location = New System.Drawing.Point(385, 207)
        Me.tag_espai.Name = "tag_espai"
        Me.tag_espai.Size = New System.Drawing.Size(77, 29)
        Me.tag_espai.TabIndex = 23
        Me.tag_espai.Text = "Espai"
        '
        'text_educacio
        '
        Me.text_educacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_educacio.Location = New System.Drawing.Point(471, 276)
        Me.text_educacio.Name = "text_educacio"
        Me.text_educacio.Size = New System.Drawing.Size(192, 36)
        Me.text_educacio.TabIndex = 26
        '
        'tag_educacio
        '
        Me.tag_educacio.AutoSize = True
        Me.tag_educacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_educacio.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_educacio.Location = New System.Drawing.Point(348, 279)
        Me.tag_educacio.Name = "tag_educacio"
        Me.tag_educacio.Size = New System.Drawing.Size(118, 29)
        Me.tag_educacio.TabIndex = 25
        Me.tag_educacio.Text = "Educacio"
        '
        'text_gremi
        '
        Me.text_gremi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_gremi.Location = New System.Drawing.Point(471, 346)
        Me.text_gremi.Name = "text_gremi"
        Me.text_gremi.Size = New System.Drawing.Size(192, 36)
        Me.text_gremi.TabIndex = 28
        '
        'tag_gremi
        '
        Me.tag_gremi.AutoSize = True
        Me.tag_gremi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_gremi.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_gremi.Location = New System.Drawing.Point(380, 349)
        Me.tag_gremi.Name = "tag_gremi"
        Me.tag_gremi.Size = New System.Drawing.Size(82, 29)
        Me.tag_gremi.TabIndex = 27
        Me.tag_gremi.Text = "Gremi"
        '
        'boto_afegir
        '
        Me.boto_afegir.BackColor = System.Drawing.Color.Black
        Me.boto_afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_afegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_afegir.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_afegir.Location = New System.Drawing.Point(80, 419)
        Me.boto_afegir.Name = "boto_afegir"
        Me.boto_afegir.Size = New System.Drawing.Size(117, 86)
        Me.boto_afegir.TabIndex = 29
        Me.boto_afegir.Text = "Afegir"
        Me.boto_afegir.UseVisualStyleBackColor = False
        '
        'boto_borrar
        '
        Me.boto_borrar.BackColor = System.Drawing.Color.Black
        Me.boto_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_borrar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_borrar.Location = New System.Drawing.Point(214, 419)
        Me.boto_borrar.Name = "boto_borrar"
        Me.boto_borrar.Size = New System.Drawing.Size(117, 86)
        Me.boto_borrar.TabIndex = 30
        Me.boto_borrar.Text = "Borrar"
        Me.boto_borrar.UseVisualStyleBackColor = False
        '
        'boto_actualitzar
        '
        Me.boto_actualitzar.BackColor = System.Drawing.Color.Black
        Me.boto_actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_actualitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_actualitzar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_actualitzar.Location = New System.Drawing.Point(349, 419)
        Me.boto_actualitzar.Name = "boto_actualitzar"
        Me.boto_actualitzar.Size = New System.Drawing.Size(117, 86)
        Me.boto_actualitzar.TabIndex = 31
        Me.boto_actualitzar.Text = "Actualitzar"
        Me.boto_actualitzar.UseVisualStyleBackColor = False
        '
        'boto_cancelar
        '
        Me.boto_cancelar.BackColor = System.Drawing.Color.Black
        Me.boto_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_cancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_cancelar.Location = New System.Drawing.Point(483, 419)
        Me.boto_cancelar.Name = "boto_cancelar"
        Me.boto_cancelar.Size = New System.Drawing.Size(117, 86)
        Me.boto_cancelar.TabIndex = 32
        Me.boto_cancelar.Text = "Cancelar"
        Me.boto_cancelar.UseVisualStyleBackColor = False
        '
        'logo_onu
        '
        Me.logo_onu.BackColor = System.Drawing.Color.Transparent
        Me.logo_onu.BackgroundImage = CType(resources.GetObject("logo_onu.BackgroundImage"), System.Drawing.Image)
        Me.logo_onu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo_onu.Location = New System.Drawing.Point(25, 12)
        Me.logo_onu.Name = "logo_onu"
        Me.logo_onu.Size = New System.Drawing.Size(107, 94)
        Me.logo_onu.TabIndex = 33
        Me.logo_onu.TabStop = False
        '
        'Persones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1113, 621)
        Me.Controls.Add(Me.logo_onu)
        Me.Controls.Add(Me.boto_cancelar)
        Me.Controls.Add(Me.boto_actualitzar)
        Me.Controls.Add(Me.boto_borrar)
        Me.Controls.Add(Me.boto_afegir)
        Me.Controls.Add(Me.text_gremi)
        Me.Controls.Add(Me.tag_gremi)
        Me.Controls.Add(Me.text_educacio)
        Me.Controls.Add(Me.tag_educacio)
        Me.Controls.Add(Me.text_espai)
        Me.Controls.Add(Me.tag_espai)
        Me.Controls.Add(Me.text_capacitat)
        Me.Controls.Add(Me.tag_capacitat)
        Me.Controls.Add(Me.text_territori)
        Me.Controls.Add(Me.tag_territori)
        Me.Controls.Add(Me.text_edat)
        Me.Controls.Add(Me.tag_edat)
        Me.Controls.Add(Me.text_cognom)
        Me.Controls.Add(Me.tag_cognom)
        Me.Controls.Add(Me.text_nom)
        Me.Controls.Add(Me.tag_nom)
        Me.Controls.Add(Me.taula_dades)
        Me.Controls.Add(Me.boto_minimitzar)
        Me.Controls.Add(Me.boto_tancar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Persones"
        Me.Text = "Persones"
        CType(Me.taula_dades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_onu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boto_minimitzar As Button
    Friend WithEvents boto_tancar As Button
    Friend WithEvents taula_dades As DataGridView
    Friend WithEvents tag_nom As Label
    Friend WithEvents text_nom As TextBox
    Friend WithEvents text_cognom As TextBox
    Friend WithEvents tag_cognom As Label
    Friend WithEvents text_edat As TextBox
    Friend WithEvents tag_edat As Label
    Friend WithEvents text_territori As TextBox
    Friend WithEvents tag_territori As Label
    Friend WithEvents text_capacitat As TextBox
    Friend WithEvents tag_capacitat As Label
    Friend WithEvents text_espai As TextBox
    Friend WithEvents tag_espai As Label
    Friend WithEvents text_educacio As TextBox
    Friend WithEvents tag_educacio As Label
    Friend WithEvents text_gremi As TextBox
    Friend WithEvents tag_gremi As Label
    Friend WithEvents boto_afegir As Button
    Friend WithEvents boto_borrar As Button
    Friend WithEvents boto_actualitzar As Button
    Friend WithEvents boto_cancelar As Button
    Friend WithEvents logo_onu As PictureBox
End Class
