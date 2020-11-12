<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.boto_tancar = New System.Windows.Forms.Button()
        Me.boto_minimitzar = New System.Windows.Forms.Button()
        Me.boto_persones = New System.Windows.Forms.Button()
        Me.boto_territoris = New System.Windows.Forms.Button()
        Me.boto_gremis = New System.Windows.Forms.Button()
        Me.boto_capa = New System.Windows.Forms.Button()
        Me.logo_onu = New System.Windows.Forms.PictureBox()
        Me.label_benvingut = New System.Windows.Forms.Label()
        Me.fons_negre = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.logo_onu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fons_negre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boto_tancar
        '
        Me.boto_tancar.BackColor = System.Drawing.Color.Black
        Me.boto_tancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_tancar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_tancar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_tancar.Location = New System.Drawing.Point(1064, -1)
        Me.boto_tancar.Name = "boto_tancar"
        Me.boto_tancar.Size = New System.Drawing.Size(56, 49)
        Me.boto_tancar.TabIndex = 0
        Me.boto_tancar.Text = "x"
        Me.boto_tancar.UseVisualStyleBackColor = False
        '
        'boto_minimitzar
        '
        Me.boto_minimitzar.BackColor = System.Drawing.Color.Black
        Me.boto_minimitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_minimitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_minimitzar.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_minimitzar.Location = New System.Drawing.Point(1011, -1)
        Me.boto_minimitzar.Name = "boto_minimitzar"
        Me.boto_minimitzar.Size = New System.Drawing.Size(56, 49)
        Me.boto_minimitzar.TabIndex = 3
        Me.boto_minimitzar.Text = "—"
        Me.boto_minimitzar.UseVisualStyleBackColor = False
        '
        'boto_persones
        '
        Me.boto_persones.BackColor = System.Drawing.Color.Black
        Me.boto_persones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_persones.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_persones.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_persones.Location = New System.Drawing.Point(684, 180)
        Me.boto_persones.Name = "boto_persones"
        Me.boto_persones.Size = New System.Drawing.Size(285, 91)
        Me.boto_persones.TabIndex = 4
        Me.boto_persones.Text = "Persones"
        Me.boto_persones.UseVisualStyleBackColor = False
        '
        'boto_territoris
        '
        Me.boto_territoris.BackColor = System.Drawing.Color.Black
        Me.boto_territoris.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_territoris.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_territoris.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_territoris.Location = New System.Drawing.Point(684, 288)
        Me.boto_territoris.Name = "boto_territoris"
        Me.boto_territoris.Size = New System.Drawing.Size(285, 89)
        Me.boto_territoris.TabIndex = 5
        Me.boto_territoris.Text = "Territoris"
        Me.boto_territoris.UseVisualStyleBackColor = False
        '
        'boto_gremis
        '
        Me.boto_gremis.BackColor = System.Drawing.Color.Black
        Me.boto_gremis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_gremis.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_gremis.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_gremis.Location = New System.Drawing.Point(684, 504)
        Me.boto_gremis.Name = "boto_gremis"
        Me.boto_gremis.Size = New System.Drawing.Size(285, 86)
        Me.boto_gremis.TabIndex = 6
        Me.boto_gremis.Text = "Gremis"
        Me.boto_gremis.UseVisualStyleBackColor = False
        '
        'boto_capa
        '
        Me.boto_capa.BackColor = System.Drawing.Color.Black
        Me.boto_capa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_capa.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_capa.ForeColor = System.Drawing.SystemColors.Control
        Me.boto_capa.Location = New System.Drawing.Point(684, 396)
        Me.boto_capa.Name = "boto_capa"
        Me.boto_capa.Size = New System.Drawing.Size(285, 85)
        Me.boto_capa.TabIndex = 7
        Me.boto_capa.Text = "Capacitats"
        Me.boto_capa.UseVisualStyleBackColor = False
        '
        'logo_onu
        '
        Me.logo_onu.BackColor = System.Drawing.Color.Transparent
        Me.logo_onu.BackgroundImage = CType(resources.GetObject("logo_onu.BackgroundImage"), System.Drawing.Image)
        Me.logo_onu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo_onu.Location = New System.Drawing.Point(31, 37)
        Me.logo_onu.Name = "logo_onu"
        Me.logo_onu.Size = New System.Drawing.Size(169, 144)
        Me.logo_onu.TabIndex = 8
        Me.logo_onu.TabStop = False
        '
        'label_benvingut
        '
        Me.label_benvingut.AutoSize = True
        Me.label_benvingut.Font = New System.Drawing.Font("Sitka Small", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_benvingut.ForeColor = System.Drawing.Color.DodgerBlue
        Me.label_benvingut.Location = New System.Drawing.Point(206, 64)
        Me.label_benvingut.Name = "label_benvingut"
        Me.label_benvingut.Size = New System.Drawing.Size(288, 74)
        Me.label_benvingut.TabIndex = 9
        Me.label_benvingut.Text = "Benvingut"
        '
        'fons_negre
        '
        Me.fons_negre.BackColor = System.Drawing.Color.Black
        Me.fons_negre.Location = New System.Drawing.Point(-1, -12)
        Me.fons_negre.Name = "fons_negre"
        Me.fons_negre.Size = New System.Drawing.Size(688, 649)
        Me.fons_negre.TabIndex = 10
        Me.fons_negre.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(31, 341)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(533, 278)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(261, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 42)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Quines dades voldria modificar?"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1113, 621)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_benvingut)
        Me.Controls.Add(Me.logo_onu)
        Me.Controls.Add(Me.boto_capa)
        Me.Controls.Add(Me.boto_gremis)
        Me.Controls.Add(Me.boto_territoris)
        Me.Controls.Add(Me.boto_persones)
        Me.Controls.Add(Me.boto_minimitzar)
        Me.Controls.Add(Me.boto_tancar)
        Me.Controls.Add(Me.fons_negre)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Form1"
        CType(Me.logo_onu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fons_negre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boto_tancar As Button
    Friend WithEvents boto_minimitzar As Button
    Friend WithEvents boto_persones As Button
    Friend WithEvents boto_territoris As Button
    Friend WithEvents boto_gremis As Button
    Friend WithEvents boto_capa As Button
    Friend WithEvents logo_onu As PictureBox
    Friend WithEvents label_benvingut As Label
    Friend WithEvents fons_negre As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
