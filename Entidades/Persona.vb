Public Class Persona
    Inherits Contacto

    Private _Apellido As String
    Private _DNI As String
    Private _FechaNacimiento As Date

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    Public ReadOnly Property NombreCompleto As String
        Get
            Return _Apellido & ", " & _Nombre
        End Get
    End Property
    Public Property DNI As String
        Get
            Return _DNI
        End Get
        Set(value As String)
            _DNI = value
        End Set
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
        End Set
    End Property
    Public ReadOnly Property Edad As Integer
        Get
            Return DateDiff(DateInterval.Year, _FechaNacimiento, DateTime.Now)
        End Get
    End Property

    'Constructor
    Sub New()

    End Sub

End Class
