﻿Module Outils

    Public Function Saisir(prompt As String, type As String) As Object
        Dim value As String
        Console.Write(prompt & " ")
        value = Console.ReadLine()

        If type.Equals("String", System.StringComparison.CurrentCulture) Then
            Return value
        ElseIf type.Equals("Integer", System.StringComparison.CurrentCulture) And IsNumeric(value) Then
            Return CInt(value)
        Else
            Return Nothing
        End If
    End Function
    Public Sub Saisir()
        Dim dep As String
        Dim arr As String
        Dim dist As Integer

        Console.Write(My.Resources.Départ & " ")
        dep = Console.ReadLine()

        Console.Write(My.Resources.Arrivée & " ")
        arr = Console.ReadLine()

        dist = 300
        monTrajet = New Trajet(dep, arr, dist)
    End Sub

    Sub Aide()
        Console.WriteLine("ce programme permet d'enregistrer un trajet effectué en voiture")
    End Sub

    Function TestSaisir() As Boolean
        Dim OK As Boolean = True
        Dim valeur As Object = Nothing

        valeur = Saisir("chaine", "String")
        If TypeOf valeur IsNot String Then
            OK = OK And False
        End If

        valeur = Saisir("entier", "Integer")
        If TypeOf valeur IsNot Integer Then
            OK = OK And False
        End If

        valeur = Saisir("entier", "Autre Chose")
        If valeur IsNot Nothing Then
            OK = OK And False
        End If

        Return OK
    End Function
End Module
