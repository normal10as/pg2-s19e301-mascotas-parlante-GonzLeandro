Imports Entidades
Module CotorraTest
    Sub CotorraTest()
        Dim cotorra1 As New Cotorra()

        cotorra1.Nombre = "Joa"
        cotorra1.FechaNacimiento = #01-10-2010#

        Console.WriteLine("Nombre: " & cotorra1.Nombre)
        Console.WriteLine("Fecha de nacimiento: " & cotorra1.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra1.edadHumana)

        cotorra1.Escuchar("papita ")
        cotorra1.Escuchar("para la ")
        cotorra1.Escuchar("cottora joa")
        cotorra1.Escuchar("Azucar")

        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine(cotorra1.Hablar)

        Console.ReadKey()
    End Sub
End Module
