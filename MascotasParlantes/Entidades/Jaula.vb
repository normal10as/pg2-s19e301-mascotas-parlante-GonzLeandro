Public Class Jaula
    Inherits Cotorra
    Public Sub New()

    End Sub

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Private _cotorra As List(Of Cotorra)
    Private _loro As Loro

End Class
