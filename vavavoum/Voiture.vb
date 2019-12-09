Public Class Voiture
    Inherits Véhicule
    Private _roues As String = "4x195/55R16"

    Public Property lesRoues As String
        Get
            Return _roues
        End Get
        Protected Set(value As String)
            _roues = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return _roues & MyBase.ToString
    End Function

    Public Function getMoteur() As String
        Return _moteur
    End Function
End Class
