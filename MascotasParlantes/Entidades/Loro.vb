Public Class Loro
    Public Sub New()
        FechaNacimiento = Date.Now
        Nombre = ""
        memoria = New Queue(Of String)
    End Sub
    Private memoria As Queue(Of String)

    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Private _fechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Dim DifEdad As Int16
        Dim fechaActual As Date = Date.Now

        DifEdad = (fechaActual.Year) - (FechaNacimiento.Year)
        If (fechaActual.Month - FechaNacimiento.Month) Then
            DifEdad -= 1
        ElseIf (fechaActual.Month = FechaNacimiento.Month And fechaActual.Day < FechaNacimiento.Day) Then
            DifEdad -= 1
        End If
        Return DifEdad
    End Function

    Public Overridable Sub Escuchar(frase As String)
        memoria.Enqueue(frase)
    End Sub
    Private frase As String
    Public Function Hablar() As String
        If memoria.Count > 0 Then
            frase += memoria.Dequeue()
        End If
        Return frase
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function


End Class
