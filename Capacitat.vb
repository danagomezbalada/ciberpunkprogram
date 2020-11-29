Public Class Capacitat
    Private capacitat As String
    Private gremi As String

    Public Sub New(ByVal capacitat As String, ByVal gremi As String)
        Me.capacitat = capacitat
        Me.gremi = gremi
    End Sub
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
