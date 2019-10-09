Imports System
Imports Entidades

Module LoroTest
    Sub LoroTest()

        Dim loro1 As New Loro()
        loro1.Nombre = "Pepe"
        loro1.FechaNacimiento = #1998-04-16#

        Console.WriteLine(loro1.Nombre)
        Console.WriteLine(loro1.FechaNacimiento)
        Console.WriteLine("la edad es: " & loro1.Edad)

        loro1.Escuchar("papita")
        loro1.Escuchar("pa el loro")
        loro1.Escuchar("Pepe")

        Console.WriteLine("Hablar: ")

        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())

        Console.ReadKey()

    End Sub
End Module
