Public Class Loro
    Public Sub New(_memoria As Queue(Of String), _edad As Short, _fechaNacimiento As Date, _nombre As String)

    End Sub
    Private _memoria As Queue(Of String)
    Public Property Memoria As Queue(Of String)
        Get
            Return _memoria
        End Get
        Set(value As Queue(Of String))
            _memoria = value
        End Set
    End Property
    Private _edad As Short
    ReadOnly Property Edad As Short
        Get
            Return _edad
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


End Class
