''' <summary>
''' La classe Trajet permet de modéliser 
''' un parcours entre une ville de départ et une ville d'arrivée
''' et d'y associer la distance parcourue
''' </summary>
Public Class Trajet
    Private ReadOnly _départ As String = "ici"
    Private ReadOnly _arrivée As String = "là"
    Private ReadOnly _distance As Distance = New Distance

    Public Sub New()
    End Sub

    Public Sub New(départ As String, arrivée As String, distance As Integer)
        _départ = départ
        _arrivée = arrivée
        _distance = New Distance(distance)
    End Sub

    Public Overrides Function ToString() As String
        Return _départ & " -> " & _arrivée & " : " & _distance.LaDistance
    End Function

End Class
