''' <summary>
''' Une voiture est un type de véhicule terrestre avec des roues
''' </summary>
Public Class Voiture
    Inherits Véhicule
    Private _roues As String = "4x195/55R16"

    Public Property LesRoues As String
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

    Public Function GetMoteur() As String
        Return LeMoteur
    End Function
End Class
