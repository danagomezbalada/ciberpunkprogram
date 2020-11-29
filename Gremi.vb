Public Class Gremi
    Private territori As String
    Private capacitat As String
    Private gremi As String

    Public Sub New(ByVal territori As String, ByVal capacitat As String, ByVal gremi As String)
        Me.territori = territori
        Me.capacitat = capacitat
        Me.gremi = gremi
    End Sub
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
    Public Sub setGremi(ByVal gremi As String)
        Me.gremi = gremi
    End Sub
    Public Function getGremi() As String
        Return Me.gremi
    End Function
End Class
