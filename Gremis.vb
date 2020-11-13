Imports MySql.Data.MySqlClient

Public Class Gremis
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
        connexio.Close()
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub Gremis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            taula_dades.BackgroundColor = Color.White
        Else
            taula_dades.BackgroundColor = Color.Black
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles boto_afegir.MouseEnter, boto_actualitzar.MouseEnter, boto_borrar.MouseEnter, boto_cancelar.MouseEnter
        If sender Is boto_afegir Then
            Me.boto_afegir.BackColor = Color.DimGray
        ElseIf sender Is boto_actualitzar Then
            Me.boto_actualitzar.BackColor = Color.DimGray
        ElseIf sender Is boto_borrar Then
            Me.boto_borrar.BackColor = Color.DimGray
        Else
            Me.boto_cancelar.BackColor = Color.DimGray
        End If
    End Sub
    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles boto_afegir.MouseLeave, boto_actualitzar.MouseLeave, boto_borrar.MouseLeave, boto_cancelar.MouseLeave
        Me.boto_afegir.BackColor = Color.Black
        Me.boto_actualitzar.BackColor = Color.Black
        Me.boto_borrar.BackColor = Color.Black
        Me.boto_cancelar.BackColor = Color.Black
    End Sub
End Class