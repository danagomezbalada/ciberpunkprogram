Imports MySql.Data.MySqlClient

Public Class Persones

    Dim connexio As MySqlConnection
    Dim query As String

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

    Private Sub Persones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim correcte As Boolean
        Try
            connexio = New MySqlConnection()
            connexio.ConnectionString = "server=localhost;user id=root;password=;database=persones"
            connexio.Open()
            MessageBox.Show("Connectat")
            correcte = True
        Catch
            MessageBox.Show("Error")
            correcte = False
        End Try
        If correcte = True Then

        End If
    End Sub

End Class