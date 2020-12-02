Imports MySql.Data.MySqlClient

Public Class Territoris
    Dim connexio As MySqlConnection
    Dim query As String

    Dim correcte As Boolean
    Dim territori As Territori

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

    Private Sub Territoris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connexio = New MySqlConnection()
            connexio.ConnectionString = "server=localhost;user id=root;password=alumne;database=persones"
            connexio.Open()
            Label1.Text = "Connectat"
            correcte = True
        Catch
            Label1.Text = "Error"
            correcte = False
        End Try
        If correcte = True Then
            carregarTaula()
            mostrarTerritori(0)
        Else
            taula_dades.BackgroundColor = Color.Black
        End If
    End Sub
    Private Sub botons_MouseEnter(sender As System.Object, e As System.EventArgs) Handles boto_afegir.MouseEnter, boto_anterior.MouseEnter, boto_borrar.MouseEnter, boto_seguent.MouseEnter, boto_actualitzar.MouseEnter
        sender.BackColor = Color.DimGray
    End Sub
    Private Sub botons_MouseLeave(sender As System.Object, e As System.EventArgs) Handles boto_afegir.MouseLeave, boto_anterior.MouseLeave, boto_borrar.MouseLeave, boto_seguent.MouseLeave, boto_actualitzar.MouseLeave
        sender.BackColor = Color.Black
    End Sub
    Private Sub boto_afegir_Click(sender As Object, e As EventArgs) Handles boto_afegir.Click
        If correcte Then
            afegirTerritori()
            carregarTaula()
            Dim i As Int32 = taula_dades.RowCount - 2
            mostrarTerritori(i)
            taula_dades.ClearSelection()
            taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
            taula_dades.Rows(i).Selected = True
        End If
    End Sub
    Private Sub boto_borrar_Click(sender As Object, e As EventArgs) Handles boto_borrar.Click
        If correcte Then
            borrarTerritori()
            carregarTaula()
            mostrarTerritori(0)
        End If
    End Sub
    Private Sub boto_actualitzar_Click(sender As Object, e As EventArgs) Handles boto_actualitzar.Click
        If correcte Then
            Dim i As Integer = taula_dades.CurrentRow.Index
            actualitzarTerritori()
            carregarTaula()
            mostrarTerritori(i)
            taula_dades.ClearSelection()
            taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
            taula_dades.Rows(i).Selected = True
        End If
    End Sub
    Private Sub carregarTaula()
        query = "SELECT * FROM territoris"
        Dim comanda As New MySqlCommand(query, connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_dades.DataSource = conjunt_dades
    End Sub

    Private Sub mostrarTerritori(index As Integer)
        territori = New Territori("", "")
        territori.setTerritori(taula_dades.Rows(index).Cells("Territori").Value.ToString)
        territori.setGremi(taula_dades.Rows(index).Cells("Gremi").Value.ToString)

        text_territori.Text = territori.getTerritori()
        text_gremi.Text = territori.getGremi()
    End Sub
    Private Sub afegirTerritori()
        query = "INSERT INTO `territoris` (`Territori`, `Gremi`) VALUES ('', '')"
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub
    Private Sub actualitzarTerritori()
        Dim i As Integer = taula_dades.CurrentRow.Index
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        Dim id As String = taula_dades.Rows(i).Cells(0).Value.ToString
        query = "UPDATE `territoris` SET `Territori`='" + text_territori.Text + "', `Gremi`='" + text_gremi.Text + "' WHERE `ID`=" + id + ""
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub
    Private Sub borrarTerritori()
        Dim i As Integer = taula_dades.CurrentRow.Index
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        Dim id As String = taula_dades.Rows(i).Cells(0).Value.ToString
        query = "DELETE FROM `territoris` WHERE `ID`=" + id + ""
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub

    Private Sub boto_seguent_Click(sender As Object, e As EventArgs) Handles boto_seguent.Click
        If taula_dades.RowCount > 0 Then
            Dim i As Integer
            If taula_dades.CurrentRow.Index < taula_dades.RowCount - 2 Then
                i = taula_dades.CurrentRow.Index + 1
            End If
            taula_dades.ClearSelection()
            taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
            taula_dades.Rows(i).Selected = True
            mostrarTerritori(i)
        End If
    End Sub

    Private Sub boto_anterior_Click(sender As Object, e As EventArgs) Handles boto_anterior.Click
        If taula_dades.RowCount > 0 Then
            Dim i As Integer
            If taula_dades.CurrentRow.Index < taula_dades.RowCount - 1 Then
                i = taula_dades.CurrentRow.Index - 1
            End If
            If i < 0 Then
                i = taula_dades.Rows.Count - 2
            End If
            taula_dades.ClearSelection()
            taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
            taula_dades.Rows(i).Selected = True
            mostrarTerritori(i)
        End If
    End Sub
    Private Sub taulaDades_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles taula_dades.CellClick
        Dim i As Integer
        With taula_dades
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                mostrarTerritori(i)
            End If
        End With
    End Sub
End Class