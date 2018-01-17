Public Class Empresa
    Inherits Contacto

    Private _RUC As String

    Public Property RUC As String
        Get
            Return _RUC
        End Get
        Set(value As String)
            _RUC = value
        End Set
    End Property
End Class
