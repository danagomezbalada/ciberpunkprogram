<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Territoris
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Territoris))
        Me.boto_minimitzar = New System.Windows.Forms.Button()
        Me.boto_tancar = New System.Windows.Forms.Button()
        Me.text_territori = New System.Windows.Forms.TextBox()
        Me.tag_territori = New System.Windows.Forms.Label()
        Me.boto_cancelar = New System.Windows.Forms.Button()
        Me.boto_actualitzar = New System.Windows.Forms.Button()
        Me.boto_borrar = New System.Windows.Forms.Button()
        Me.boto_afegir = New System.Windows.Forms.Button()
        Me.logo_onu = New System.Windows.Forms.PictureBox()
        Me.text_gremi = New System.Windows.Forms.TextBox()
        Me.tag_gremi = New System.Windows.Forms.Label()
        Me.taula_dades = New System.Windows.Forms.DataGridView()
        Me.label_seccio = New System.Windows.Forms.Label()
        CType(Me.logo_onu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taula_dades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boto_minimitzar
        '
        Me.boto_minimitzar.BackColor = System.Drawing.Color.Black
        Me.boto_minimitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_minimitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_minimitzar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.boto_minimitzar.Location = New System.Drawing.Point(1003, 0)
        Me.boto_minimitzar.Name = "boto_minimitzar"
        Me.boto_minimitzar.Size = New System.Drawing.Size(56, 49)
        Me.boto_minimitzar.TabIndex = 7
        Me.boto_minimitzar.Text = "—"
        Me.boto_minimitzar.UseVisualStyleBackColor = False
        '
        'boto_tancar
        '
        Me.boto_tancar.BackColor = System.Drawing.Color.Black
        Me.boto_tancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_tancar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_tancar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.boto_tancar.Location = New System.Drawing.Point(1056, 0)
        Me.boto_tancar.Name = "boto_tancar"
        Me.boto_tancar.Size = New System.Drawing.Size(56, 49)
        Me.boto_tancar.TabIndex = 6
        Me.boto_tancar.Text = "x"
        Me.boto_tancar.UseVisualStyleBackColor = False
        '
        'text_territori
        '
        Me.text_territori.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_territori.Location = New System.Drawing.Point(247, 279)
        Me.text_territori.Multiline = True
        Me.text_territori.Name = "text_territori"
        Me.text_territori.Size = New System.Drawing.Size(261, 53)
        Me.text_territori.TabIndex = 83
        '
        'tag_territori
        '
        Me.tag_territori.AutoSize = True
        Me.tag_territori.Font = New System.Drawing.Font("Agency FB", 16.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_territori.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_territori.Location = New System.Drawing.Point(154, 288)
        Me.tag_territori.Name = "tag_territori"
        Me.tag_territori.Size = New System.Drawing.Size(83, 33)
        Me.tag_territori.TabIndex = 82
        Me.tag_territori.Text = "Territori"
        '
        'boto_cancelar
        '
        Me.boto_cancelar.BackColor = System.Drawing.Color.Black
        Me.boto_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_cancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_cancelar.Location = New System.Drawing.Point(498, 387)
        Me.boto_cancelar.Name = "boto_cancelar"
        Me.boto_cancelar.Size = New System.Drawing.Size(132, 86)
        Me.boto_cancelar.TabIndex = 81
        Me.boto_cancelar.Text = "Cancel·lar"
        Me.boto_cancelar.UseVisualStyleBackColor = False
        '
        'boto_actualitzar
        '
        Me.boto_actualitzar.BackColor = System.Drawing.Color.Black
        Me.boto_actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_actualitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_actualitzar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_actualitzar.Location = New System.Drawing.Point(349, 387)
        Me.boto_actualitzar.Name = "boto_actualitzar"
        Me.boto_actualitzar.Size = New System.Drawing.Size(132, 86)
        Me.boto_actualitzar.TabIndex = 80
        Me.boto_actualitzar.Text = "Actualitzar"
        Me.boto_actualitzar.UseVisualStyleBackColor = False
        '
        'boto_borrar
        '
        Me.boto_borrar.BackColor = System.Drawing.Color.Black
        Me.boto_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_borrar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_borrar.Location = New System.Drawing.Point(202, 387)
        Me.boto_borrar.Name = "boto_borrar"
        Me.boto_borrar.Size = New System.Drawing.Size(132, 86)
        Me.boto_borrar.TabIndex = 79
        Me.boto_borrar.Text = "Esborrar"
        Me.boto_borrar.UseVisualStyleBackColor = False
        '
        'boto_afegir
        '
        Me.boto_afegir.BackColor = System.Drawing.Color.Black
        Me.boto_afegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_afegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_afegir.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_afegir.Location = New System.Drawing.Point(51, 387)
        Me.boto_afegir.Name = "boto_afegir"
        Me.boto_afegir.Size = New System.Drawing.Size(132, 86)
        Me.boto_afegir.TabIndex = 78
        Me.boto_afegir.Text = "Afegir"
        Me.boto_afegir.UseVisualStyleBackColor = False
        '
        'logo_onu
        '
        Me.logo_onu.BackColor = System.Drawing.Color.Transparent
        Me.logo_onu.BackgroundImage = CType(resources.GetObject("logo_onu.BackgroundImage"), System.Drawing.Image)
        Me.logo_onu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo_onu.Location = New System.Drawing.Point(15, 11)
        Me.logo_onu.Name = "logo_onu"
        Me.logo_onu.Size = New System.Drawing.Size(107, 94)
        Me.logo_onu.TabIndex = 77
        Me.logo_onu.TabStop = False
        '
        'text_gremi
        '
        Me.text_gremi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_gremi.Location = New System.Drawing.Point(247, 175)
        Me.text_gremi.Multiline = True
        Me.text_gremi.Name = "text_gremi"
        Me.text_gremi.Size = New System.Drawing.Size(261, 62)
        Me.text_gremi.TabIndex = 76
        '
        'tag_gremi
        '
        Me.tag_gremi.AutoSize = True
        Me.tag_gremi.Font = New System.Drawing.Font("Agency FB", 16.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag_gremi.ForeColor = System.Drawing.SystemColors.Control
        Me.tag_gremi.Location = New System.Drawing.Point(175, 188)
        Me.tag_gremi.Name = "tag_gremi"
        Me.tag_gremi.Size = New System.Drawing.Size(65, 33)
        Me.tag_gremi.TabIndex = 75
        Me.tag_gremi.Text = "Gremi"
        '
        'taula_dades
        '
        Me.taula_dades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taula_dades.Location = New System.Drawing.Point(675, 109)
        Me.taula_dades.Name = "taula_dades"
        Me.taula_dades.RowHeadersWidth = 51
        Me.taula_dades.RowTemplate.Height = 24
        Me.taula_dades.Size = New System.Drawing.Size(394, 414)
        Me.taula_dades.TabIndex = 72
        '
        'label_seccio
        '
        Me.label_seccio.AutoSize = True
        Me.label_seccio.Font = New System.Drawing.Font("Sitka Small", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_seccio.ForeColor = System.Drawing.Color.DodgerBlue
        Me.label_seccio.Location = New System.Drawing.Point(135, 11)
        Me.label_seccio.Name = "label_seccio"
        Me.label_seccio.Size = New System.Drawing.Size(260, 69)
        Me.label_seccio.TabIndex = 87
        Me.label_seccio.Text = "Territoris"
        '
        'Territoris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1113, 621)
        Me.Controls.Add(Me.label_seccio)
        Me.Controls.Add(Me.text_territori)
        Me.Controls.Add(Me.tag_territori)
        Me.Controls.Add(Me.boto_cancelar)
        Me.Controls.Add(Me.boto_actualitzar)
        Me.Controls.Add(Me.boto_borrar)
        Me.Controls.Add(Me.boto_afegir)
        Me.Controls.Add(Me.logo_onu)
        Me.Controls.Add(Me.text_gremi)
        Me.Controls.Add(Me.tag_gremi)
        Me.Controls.Add(Me.taula_dades)
        Me.Controls.Add(Me.boto_minimitzar)
        Me.Controls.Add(Me.boto_tancar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Territoris"
        Me.Text = "Territoris"
        CType(Me.logo_onu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taula_dades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boto_minimitzar As Button
    Friend WithEvents boto_tancar As Button
    Friend WithEvents text_territori As TextBox
    Friend WithEvents tag_territori As Label
    Friend WithEvents boto_cancelar As Button
    Friend WithEvents boto_actualitzar As Button
    Friend WithEvents boto_borrar As Button
    Friend WithEvents boto_afegir As Button
    Friend WithEvents logo_onu As PictureBox
    Friend WithEvents text_gremi As TextBox
    Friend WithEvents tag_gremi As Label
    Friend WithEvents taula_dades As DataGridView
    Friend WithEvents label_seccio As Label
End Class
