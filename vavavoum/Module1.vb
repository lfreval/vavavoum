Option Explicit On
Option Strict On

Module Module1
    ReadOnly maClio As New Voiture()
    Dim monTrajet As New Trajet()
    ReadOnly listeDeCommutateurs As New List(Of String) From {"--help", "-help", "/?"}

    Sub Main()

        'maClio.lesRoues = "3x155/55R14"
        'Console.WriteLine(maClio)
        'Console.WriteLine(maClio.getMoteur)
        'Console.ReadKey()
        For Each argument As String In My.Application.CommandLineArgs
            If listeDeCommutateurs.Contains(argument) Then
                Aide()
                Environment.Exit(0)
            End If
        Next

        Saisir()
        Console.WriteLine(monTrajet)
        Console.ReadKey()

    End Sub

    Public Function Saisir(prompt As String, type As String) As Object
        Dim value As String
        Console.Write(prompt & " ")
        value = Console.ReadLine()

        If type.Equals("String") Then
            Return value
        ElseIf type.Equals("Integer") And IsNumeric(value) Then
            Return CInt(value)
        Else
            Return Nothing
        End If
    End Function
    Public Sub Saisir()
        Dim dep As String
        Dim arr As String
        Dim dist As Integer

        Console.Write(My.Resources.Départ)
        dep = Console.ReadLine()

        Console.Write(My.Resources.Arrivée)
        arr = Console.ReadLine()

        dist = 300
        monTrajet = New Trajet(dep, arr, dist)
    End Sub

    Sub Aide()
        Console.WriteLine("ce programme permet d'enregistrer un trajet effectué en voiture")
    End Sub
End Module
