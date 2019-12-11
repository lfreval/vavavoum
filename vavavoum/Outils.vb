Module Outils

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

    Sub Aide()
        Console.WriteLine("ce programme permet d'enregistrer un trajet effectué en voiture")
    End Sub

    Function TestSaisir() As Boolean
        Dim valeur As Object

        valeur = Saisir("chaine", "String")
        If TypeOf valeur IsNot String Then
            Return False
        End If

        valeur = Saisir("entier", "Integer")
        If TypeOf valeur IsNot Integer Then
            Return False
        End If

        valeur = Saisir("entier", "Autre Chose")
        If valeur IsNot Nothing Then
            Return False
        End If

        Return True
    End Function
End Module
