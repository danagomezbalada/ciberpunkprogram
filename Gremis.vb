Imports MySql.Data.MySqlClient

Public Class Gremis
    Dim connexio As MySqlConnection
    Dim query As String

    Dim correcte As Boolean
    Dim gremi As Gremi

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
        Try
            connexio = New MySqlConnection()
            connexio.ConnectionString = "server=localhost;user id=root;password=;database=persones"
            connexio.Open()
            Label1.Text = "Connectat"
            correcte = True
        Catch
            Label1.Text = "Error"
            correcte = False
        End Try
        If correcte = True Then
            carregarTaula()
            mostrarGremi(0)
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
            afegirGremi()
            carregarTaula()
            Dim i As Int32 = taula_dades.RowCount - 2
            mostrarGremi(i)
            taula_dades.ClearSelection()
            taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
            taula_dades.Rows(i).Selected = True
        End If
    End Sub
    Private Sub boto_borrar_Click(sender As Object, e As EventArgs) Handles boto_borrar.Click
        If correcte Then
            borrarGremi()
            carregarTaula()
            mostrarGremi(0)
        End If
    End Sub
    Private Sub boto_actualitzar_Click(sender As Object, e As EventArgs) Handles boto_actualitzar.Click
        If correcte Then
            Dim i As Integer = taula_dades.CurrentRow.Index
            actualitzarGremi()
            carregarTaula()
            mostrarGremi(i)
            taula_dades.ClearSelection()
            taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
            taula_dades.Rows(i).Selected = True
        End If
    End Sub
    Private Sub carregarTaula()
        query = "SELECT * FROM gremis"
        Dim comanda As New MySqlCommand(query, connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_dades.DataSource = conjunt_dades
    End Sub

    Private Sub mostrarGremi(index As Integer)
        gremi = New Gremi("", "", "")
        gremi.setTerritori(taula_dades.Rows(index).Cells("Territori").Value.ToString)
        gremi.setCapacitat(taula_dades.Rows(index).Cells("Capacitat").Value.ToString)
        gremi.setGremi(taula_dades.Rows(index).Cells("Gremi").Value.ToString)

        text_territori.Text = gremi.getTerritori()
        text_capacitat.Text = gremi.getCapacitat()
        text_gremi.Text = gremi.getGremi()
    End Sub
    Private Sub afegirGremi()
        query = "INSERT INTO `gremis` (`Territori`, `Capacitat`, `Gremi`) VALUES ( '', '', '')"
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub
    Private Sub actualitzarGremi()
        Dim i As Integer = taula_dades.CurrentRow.Index
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        Dim id As String = taula_dades.Rows(i).Cells(0).Value.ToString
        query = "UPDATE `gremis` SET `Territori`='" + text_territori.Text + "', `Capacitat`='" + text_capacitat.Text + "', `Gremi`='" + text_gremi.Text + "' WHERE `ID`=" + id + ""
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub
    Private Sub borrarGremi()
        Dim i As Integer = taula_dades.CurrentRow.Index
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        Dim id As String = taula_dades.Rows(i).Cells(0).Value.ToString
        query = "DELETE FROM `gremis` WHERE `ID`=" + id + ""
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
            mostrarGremi(i)
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
            mostrarGremi(i)
        End If
    End Sub
    Private Sub taulaDades_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles taula_dades.CellClick
        Dim i As Integer
        With taula_dades
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                mostrarGremi(i)
            End If
        End With
    End Sub
End Class