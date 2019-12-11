Public Class Véhicule
    Private ReadOnly _chassis As String = "RT"
    Private ReadOnly _carrosserie As String = "rouge"
    Private _moteur As String = "V6"

    Public Property LeMoteur As String
        Get
            Return _moteur
        End Get
        Set(value As String)
            _moteur = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "> " & _chassis & ":" & _carrosserie
    End Function

End Class
