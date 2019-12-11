Option Explicit On
Option Strict On

Module Module1
    ReadOnly maClio As New Voiture()
    ReadOnly monTrajet As New Trajet()


    Sub Main()

        'maClio.lesRoues = "3x155/55R14"
        Console.WriteLine(maClio)
        Console.WriteLine(maClio.getMoteur)
        Console.ReadKey()

        monTrajet.Saisir()
        Console.WriteLine(monTrajet)
        Console.ReadKey()

    End Sub

End Module
