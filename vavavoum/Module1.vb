Option Explicit On
Option Strict On

Module Module1
    ReadOnly maClio As New Voiture()
    ReadOnly monTrajet As New Trajet()
    ReadOnly listeDeCommutateurs As New List(Of String) From {"--help", "-help", "/?"}

    Sub Main()

        'maClio.lesRoues = "3x155/55R14"
        'Console.WriteLine(maClio)
        'Console.WriteLine(maClio.getMoteur)
        'Console.ReadKey()
        For Each argument As String In My.Application.CommandLineArgs
            If listeDeCommutateurs.Contains(argument) Then
                Aide()
                Exit Sub
            End If
        Next

        monTrajet.Saisir()
        Console.WriteLine(monTrajet)
        Console.ReadKey()

    End Sub

    Sub Aide()
        Console.WriteLine("ce programme permet d'enregistrer un trajet effectué en voiture")
    End Sub
End Module
