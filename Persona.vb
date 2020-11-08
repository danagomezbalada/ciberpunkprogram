Public Class Persona
    Private nom As String
    Private cognom As String
    Private edat As Int32
    Private territori As String
    Private capacitat As String
    Private espai As String
    Private educacio As String
    Private gremi As String

    Public Sub New(ByVal nom As String, ByVal cognom As String, ByVal edat As Int32, ByVal territori As String, ByVal capacitat As String, ByVal espai As String, ByVal educacio As String, ByVal gremi As String)
        Me.nom = nom
        Me.cognom = cognom
        Me.edat = edat
        Me.territori = territori
        Me.capacitat = capacitat
        Me.espai = espai
        Me.educacio = educacio
        Me.gremi = gremi
    End Sub

    Public Sub setNom(ByVal nom As String)
        Me.nom = nom
    End Sub
    Public Function getNom() As String
        Return Me.nom
    End Function
    Public Sub setCognom(ByVal cognom As String)
        Me.cognom = cognom
    End Sub
    Public Function getCognom() As String
        Return Me.cognom
    End Function
    Public Sub setEdat(ByVal edat As Int32)
        Me.edat = edat
    End Sub
    Public Function getEdat() As Int32
        Return Me.edat
    End Function
    Public Sub setTerritori(ByVal territori As String)
        Me.territori = territori
    End Sub
    Public Function getTerritori() As String
        Return Me.territori
    End Function
    Public Sub setCapacitat(ByVal capacitat As String)
        Me.capacitat = capacitat
    End Sub
    Public Function getCapacitat() As String
        Return Me.capacitat
    End Function
    Public Sub setEspai(ByVal espai As String)
        Me.espai = espai
    End Sub
    Public Function getEspai() As String
        Return Me.espai
    End Function
    Public Sub setEducacio(ByVal educacio As String)
        Me.educacio = educacio
    End Sub
    Public Function getEducacio() As String
        Return Me.educacio
    End Function
    Public Sub setGremi(ByVal gremi As String)
        Me.gremi = gremi
    End Sub
    Public Function getGremi() As String
        Return Me.gremi
    End Function
End Class
