Public Class Territori
    Private territori As String
    Private gremi As String

    Public Sub New(ByVal territori As String, ByVal gremi As String)
        Me.territori = territori
        Me.gremi = gremi
    End Sub

    Public Sub setTerritori(ByVal territori As String)
        Me.territori = territori
    End Sub
    Public Function getTerritori() As String
        Return Me.territori
    End Function
    Public Sub setGremi(ByVal gremi As String)
        Me.gremi = gremi
    End Sub
    Public Function getGremi() As String
        Return Me.gremi
    End Function
End Class
