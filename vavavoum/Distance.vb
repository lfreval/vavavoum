''' <summary>
''' Une distance avec l'unité de distance
''' </summary>
Public Class Distance
    Private _d As Integer = 0

    Public Property LaDistance As Integer
        Get
            Return _d
        End Get
        Set(value As Integer)
            _d = value
        End Set

    End Property
End Class
