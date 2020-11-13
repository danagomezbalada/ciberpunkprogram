Public Class Principal

    Dim ex, ey As Integer
    Dim arrossega As Boolean

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, fons_negre.MouseDown
        ex = e.X
        ey = e.Y
        arrossega = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, fons_negre.MouseUp
        arrossega = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, fons_negre.MouseMove
        If arrossega Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_benvingut.Parent = fons_negre
        logo_onu.Parent = fons_negre
    End Sub

    Private Sub boto_minimitzar_Click(sender As Object, e As EventArgs) Handles boto_minimitzar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub boto_tancar_Click(sender As Object, e As EventArgs) Handles boto_tancar.Click
        Me.Close()
    End Sub
    Private Sub boto_persones_Click(sender As Object, e As EventArgs) Handles boto_persones.Click
        Persones.Show()
        Me.Hide()
    End Sub
    Private Sub boto_territoris_Click(sender As Object, e As EventArgs) Handles boto_territoris.Click
        Territoris.Show()
        Me.Hide()
    End Sub
    Private Sub boto_gremis_Click(sender As Object, e As EventArgs) Handles boto_gremis.Click
        Gremis.Show()
        Me.Hide()
    End Sub
    Private Sub boto_capa_Click(sender As Object, e As EventArgs) Handles boto_capa.Click
        Capacitats.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles boto_persones.MouseEnter, boto_gremis.MouseEnter, boto_territoris.MouseEnter, boto_capa.MouseEnter
        If sender Is boto_persones Then
            Me.boto_persones.BackColor = Color.DimGray
        ElseIf sender Is boto_gremis Then
            Me.boto_gremis.BackColor = Color.DimGray
        ElseIf sender Is boto_territoris Then
            Me.boto_territoris.BackColor = Color.DimGray
        Else
            Me.boto_capa.BackColor = Color.DimGray
        End If
    End Sub
    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles boto_persones.MouseLeave, boto_gremis.MouseLeave, boto_territoris.MouseLeave, boto_capa.MouseLeave
        Me.boto_persones.BackColor = Color.Black
        Me.boto_territoris.BackColor = Color.Black
        Me.boto_gremis.BackColor = Color.Black
        Me.boto_capa.BackColor = Color.Black
    End Sub


End Class