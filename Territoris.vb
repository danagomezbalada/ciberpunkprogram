Public Class Territoris
    Dim ex, ey As Integer
    Dim arrossega As Boolean
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        arrossega = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        arrossega = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If arrossega Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub
    Private Sub boto_minimitzar_Click(sender As Object, e As EventArgs) Handles boto_minimitzar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub boto_tancar_Click(sender As Object, e As EventArgs) Handles boto_tancar.Click
        Principal.Show()
        Me.Close()
    End Sub
End Class