''' <summary>
''' Une distance avec l'unité de distance
''' </summary>
Public Class Distance
    Private _d As Integer = 0
    Private ReadOnly _unité = "km"

    Public Sub New()

    End Sub
    Public Sub New(dist As Integer)
        _d = dist
    End Sub
    Public Property LaDistance As Integer
        Get
            Return _d
        End Get
        Set(value As Integer)
            _d = value
        End Set

    End Property

    Public Overrides Function ToString() As String
        Return _d & _unité
    End Function

    Public Shared Operator &(c1 As String, d1 As Distance) As String
        If d1 IsNot Nothing Then
            Return c1 & d1.ToString
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Widening Operator CType(v As Distance) As String
        If v IsNot Nothing Then
            Return v.ToString
        Else
            Return Nothing
        End If
    End Operator

    Public Shared Operator &(d1 As Distance, c1 As String) As String
        If d1 IsNot Nothing Then
            Return d1.ToString & c1
        Else
            Return Nothing
        End If
    End Operator
End Class
