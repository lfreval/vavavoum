﻿Option Explicit On
Option Strict On

Module Module1
    ReadOnly maClio As New Voiture()
    Public monTrajet As New Trajet()
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

        monTrajet = New Trajet(Saisir(My.Resources.Départ, "String"), Saisir(My.Resources.Départ, "String"), Saisir("Distance ?", "Integer"))
        Console.WriteLine(monTrajet)
        Console.ReadKey()

    End Sub


End Module
