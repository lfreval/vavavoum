Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim maClio As New Voiture()
        'maClio.lesRoues = "3x155/55R14"
        Console.WriteLine(maClio)
        Console.WriteLine(maClio.leMoteur)
        Console.ReadKey()
    End Sub

End Module
