Imports Practica3

Public Class TipoPatinete
    Dim _marca As String
    Dim _persomax As Integer
    Dim _velocidad As Integer
    Dim _precioHora As Integer
    Dim _tipoPatineteDAO As TipoPatienteDAO
    Dim _idTipo As Integer

    Public Sub New()
        _tipoPatineteDAO = New TipoPatienteDAO
    End Sub


    Public Sub New(marca As String, persomax As Double, velocidad As Double, precioHora As Double)
        _marca = marca
        _persomax = persomax
        _velocidad = velocidad
        _precioHora = precioHora
        TipoPatineteDAO = New TipoPatienteDAO
    End Sub

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Persomax As Double
        Get
            Return _persomax
        End Get
        Set(value As Double)
            _persomax = value
        End Set
    End Property

    Public Property PrecioHora As Double
        Get
            Return _precioHora
        End Get
        Set(value As Double)
            _precioHora = value
        End Set
    End Property

    Public Property Velocidad As Double
        Get
            Return _velocidad
        End Get
        Set(value As Double)
            _velocidad = value
        End Set
    End Property

    Public Property TipoPatineteDAO As TipoPatienteDAO
        Get
            Return _tipoPatineteDAO
        End Get
        Set(value As TipoPatienteDAO)
            _tipoPatineteDAO = value
        End Set
    End Property

    Public Property IdTipo As Integer
        Get
            Return _idTipo
        End Get
        Set(value As Integer)
            _idTipo = value
        End Set
    End Property

    Public Function Insert() As Integer
        Return TipoPatineteDAO.Insert(Me)
    End Function
    Public Function ReadAll()
        _tipoPatineteDAO.ReadAll()
    End Function
    Public Function Read()
        _tipoPatineteDAO.Read(Me)
    End Function
    Public Function Update() As Integer
        Return _tipoPatineteDAO.Update(Me)
    End Function
    Public Function Delete() As Integer
        Return _tipoPatineteDAO.Delete(Me)
    End Function
End Class
