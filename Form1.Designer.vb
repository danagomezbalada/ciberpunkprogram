<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.boto_tancar = New System.Windows.Forms.Button()
        Me.boto_persones = New System.Windows.Forms.Button()
        Me.boto_minimitzar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boto_tancar
        '
        Me.boto_tancar.BackColor = System.Drawing.Color.Black
        Me.boto_tancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_tancar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_tancar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.boto_tancar.Location = New System.Drawing.Point(1064, -1)
        Me.boto_tancar.Name = "boto_tancar"
        Me.boto_tancar.Size = New System.Drawing.Size(56, 49)
        Me.boto_tancar.TabIndex = 0
        Me.boto_tancar.Text = "x"
        Me.boto_tancar.UseVisualStyleBackColor = False
        '
        'boto_persones
        '
        Me.boto_persones.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boto_persones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_persones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_persones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.boto_persones.Location = New System.Drawing.Point(124, 242)
        Me.boto_persones.Name = "boto_persones"
        Me.boto_persones.Size = New System.Drawing.Size(138, 63)
        Me.boto_persones.TabIndex = 1
        Me.boto_persones.Text = "Persones"
        Me.boto_persones.UseVisualStyleBackColor = False
        '
        'boto_minimitzar
        '
        Me.boto_minimitzar.BackColor = System.Drawing.Color.Black
        Me.boto_minimitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boto_minimitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boto_minimitzar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.boto_minimitzar.Location = New System.Drawing.Point(1011, -1)
        Me.boto_minimitzar.Name = "boto_minimitzar"
        Me.boto_minimitzar.Size = New System.Drawing.Size(56, 49)
        Me.boto_minimitzar.TabIndex = 3
        Me.boto_minimitzar.Text = "—"
        Me.boto_minimitzar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 152)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1113, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.boto_minimitzar)
        Me.Controls.Add(Me.boto_persones)
        Me.Controls.Add(Me.boto_tancar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boto_tancar As Button
    Friend WithEvents boto_persones As Button
    Friend WithEvents boto_minimitzar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
