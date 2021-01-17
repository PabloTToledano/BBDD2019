Imports Practica3

Public Class Client
    Dim _dni As String
    Dim _nombre As String
    Dim _telefono As Int32
    Dim _direccion As String
    Dim _email As String
    Dim _clientDao As ClientDAO

    Public Sub New()
        _clientDao = New ClientDAO
    End Sub

    Public Sub New(dni As String, nombre As String, telefono As Integer, direccion As String, email As String)
        _dni = dni
        _nombre = nombre
        _telefono = telefono
        _direccion = direccion
        _email = email
        _clientDao = New ClientDAO
    End Sub

    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property ClientDao As ClientDAO
        Get
            Return _clientDao
        End Get
        Set(value As ClientDAO)
            _clientDao = value
        End Set
    End Property

    Public Function ReadAll()
        _clientDao.ReadAll()
    End Function
    Public Function Insert() As Integer
        _clientDao.Insert(Me)
    End Function
    Public Function Read()
        _clientDao.Read(Me)
    End Function
    Public Function Delete() As Integer
        Return _clientDao.Delete(Me)
    End Function
    Public Function Update() As Integer
        Return _clientDao.Update(Me)
    End Function
End Class
