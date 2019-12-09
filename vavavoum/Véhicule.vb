Public Class Véhicule
    Private _chassis As String = "RT"
    Private _carrosserie As String = "rouge"
    Protected _moteur As String = "V6"

    Public Property leMoteur As String
        Get
            Return _moteur
        End Get
        Set(value As String)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "> " & _chassis & ":" & _carrosserie
    End Function

End Class
