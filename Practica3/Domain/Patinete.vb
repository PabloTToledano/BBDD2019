Imports Practica3

Public Class Patinete
    Dim _idTipo As Int32
    Dim _descripcion As String
    Dim _patiDAO As PatineteDAO
    Dim _idPatinete As Integer

    Public Sub New()
        PatiDAO = New PatineteDAO
    End Sub
    Public Sub New(idTipo As Integer, descripcion As String)
        _idTipo = idTipo
        _descripcion = descripcion
        PatiDAO = New PatineteDAO
    End Sub

    Public Property IdTipo As Integer
        Get
            Return _idTipo
        End Get
        Set(value As Integer)
            _idTipo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property IdPatinete As Integer
        Get
            Return _idPatinete
        End Get
        Set(value As Integer)
            _idPatinete = value
        End Set
    End Property

    Public Property PatiDAO As PatineteDAO
        Get
            Return _patiDAO
        End Get
        Set(value As PatineteDAO)
            _patiDAO = value
        End Set
    End Property

    Public Function Insert() As Integer
        PatiDAO.Insert(Me)
    End Function
    Public Function ReadAll()
        PatiDAO.ReadAll()
    End Function
    Public Function Read()
        PatiDAO.Read(Me)
    End Function
    Public Function Update() As Integer
        Return PatiDAO.Update(Me)
    End Function
    Public Function Delete() As Integer
        Return PatiDAO.Delete(Me)
    End Function

End Class
