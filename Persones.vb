Imports MySql.Data.MySqlClient

Public Class Persones

    Dim connexio As MySqlConnection
    Dim query As String

    Dim persona As Persona

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

    Private Sub Persones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim correcte As Boolean
        Try
            connexio = New MySqlConnection()
            connexio.ConnectionString = "server=localhost;user id=root;password=;database=persones"
            connexio.Open()
            label_connexio.Text = "Connectat"
            correcte = True
        Catch
            label_connexio.Text = "Error"
            correcte = False
        End Try
        If correcte = True Then
            carregarTaula()
            mostrarPersona(0)
        Else
            taula_dades.BackgroundColor = Color.Black
        End If
    End Sub

    Private Sub botons_MouseEnter(sender As System.Object, e As System.EventArgs) Handles boto_afegir.MouseEnter, boto_anterior.MouseEnter, boto_borrar.MouseEnter, boto_seguent.MouseEnter
        If sender Is boto_afegir Then
            Me.boto_afegir.BackColor = Color.DimGray
        ElseIf sender Is boto_anterior Then
            Me.boto_anterior.BackColor = Color.DimGray
        ElseIf sender Is boto_borrar Then
            Me.boto_borrar.BackColor = Color.DimGray
        Else
            Me.boto_seguent.BackColor = Color.DimGray
        End If
    End Sub
    Private Sub botons_MouseLeave(sender As System.Object, e As System.EventArgs) Handles boto_afegir.MouseLeave, boto_anterior.MouseLeave, boto_borrar.MouseLeave, boto_seguent.MouseLeave
        Me.boto_afegir.BackColor = Color.Black
        Me.boto_anterior.BackColor = Color.Black
        Me.boto_borrar.BackColor = Color.Black
        Me.boto_seguent.BackColor = Color.Black
    End Sub
    Private Sub boto_afegir_Click(sender As Object, e As EventArgs) Handles boto_afegir.Click
        afegirPersona()
        carregarTaula()
        Dim i As Int32 = taula_dades.RowCount - 2
        mostrarPersona(i)
        taula_dades.ClearSelection()
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        taula_dades.Rows(i).Selected = True
    End Sub
    Private Sub boto_borrar_Click(sender As Object, e As EventArgs) Handles boto_borrar.Click
        borrarPersona()
        carregarTaula()
        mostrarPersona(0)
    End Sub
    Private Sub boto_actualitzar_Click(sender As Object, e As EventArgs) Handles boto_actualitzar.Click
        Dim i As Integer = taula_dades.CurrentRow.Index
        actualitzarPersona()
        carregarTaula()
        mostrarPersona(i)
        taula_dades.ClearSelection()
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        taula_dades.Rows(i).Selected = True
    End Sub
    Private Sub carregarTaula()
        query = "SELECT * FROM persones"
        Dim comanda As New MySqlCommand(query, connexio)
        Dim adaptador As New MySqlDataAdapter(comanda)
        Dim conjunt_dades As New DataTable()
        adaptador.Fill(conjunt_dades)
        taula_dades.DataSource = conjunt_dades
    End Sub

    Private Sub mostrarPersona(index As Integer)
        persona = New Persona("", "", 0, "", "", "", "", "")
        persona.setNom(taula_dades.Rows(index).Cells("Nom").Value.ToString)
        persona.setCognom(taula_dades.Rows(index).Cells("Cognom").Value.ToString)
        persona.setEdat(taula_dades.Rows(index).Cells("Edat").Value)
        persona.setTerritori(taula_dades.Rows(index).Cells("Territori").Value.ToString)
        persona.setCapacitat(taula_dades.Rows(index).Cells("Capacitat").Value.ToString)
        persona.setEspai(taula_dades.Rows(index).Cells("Espai").Value.ToString)
        persona.setEducacio(taula_dades.Rows(index).Cells("Educacio").Value.ToString)
        persona.setGremi(taula_dades.Rows(index).Cells("Gremi").Value.ToString)

        text_nom.Text = persona.getNom()
        text_cognom.Text = persona.getCognom()
        text_edat.Text = persona.getEdat()
        text_territori.Text = persona.getTerritori()
        text_capacitat.Text = persona.getCapacitat()
        text_espai.Text = persona.getEspai()
        text_educacio.Text = persona.getEducacio()
        text_gremi.Text = persona.getGremi()
    End Sub
    Private Sub afegirPersona()
        query = "INSERT INTO `persones` (`Nom`, `Cognom`, `Edat`, `Territori`, `Capacitat`, `Espai`, `Educacio`, `Gremi`) VALUES ('', '', 0, '', '', '', '', '')"
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub
    Private Sub actualitzarPersona()
        Dim i As Integer = taula_dades.CurrentRow.Index
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        Dim id As String = taula_dades.Rows(i).Cells(0).Value.ToString
        query = "UPDATE `persones` SET `Nom`='" + text_nom.Text + "', `Cognom`='" + text_cognom.Text + "', `Edat`='" + text_edat.Text + "', `Territori`='" + text_territori.Text + "', `Capacitat`='" + text_capacitat.Text + "', `Espai`='" + text_espai.Text + "', `Educacio`='" + text_educacio.Text + "', `Gremi`='" + text_gremi.Text + "' WHERE `ID`=" + id + ""
        Dim comanda = New MySqlCommand(query, connexio)
        comanda.ExecuteNonQuery()
    End Sub
    Private Sub borrarPersona()
        Dim i As Integer = taula_dades.CurrentRow.Index
        taula_dades.CurrentCell = taula_dades.Rows(i).Cells(0)
        Dim id As String = taula_dades.Rows(i).Cells(0).Value.ToString
        query = "DELETE FROM `persones` WHERE `ID`=" + id + ""
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
            mostrarPersona(i)
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
            mostrarPersona(i)
        End If
    End Sub
    Private Sub taulaDades_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles taula_dades.CellClick
        Dim i As Integer
        With taula_dades
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                mostrarPersona(i)
            End If
        End With
    End Sub
End Class