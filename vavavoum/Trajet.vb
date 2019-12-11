Public Class Trajet
    Private _départ As String = "ici"
    Private _arrivée As String = "là"
    Private ReadOnly _distance As Distance = New Distance

    Public Sub Saisir()
        Console.Write(My.Resources.Départ)
        _départ = Console.ReadLine()

        Console.Write(My.Resources.Arrivée)
        _arrivée = Console.ReadLine()

        _distance.laDistance = 300
    End Sub
End Class
