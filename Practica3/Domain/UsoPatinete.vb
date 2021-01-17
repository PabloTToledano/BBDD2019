Imports Practica3

Public Class UsoPatinete
    Dim _idPatinete As Integer
    Dim _idReserva As Integer
    Dim _usopatiDAO As UsoPatineteDAO
    Public Sub New()
        UsopatiDAO = New UsoPatineteDAO
    End Sub

    Public Sub New(idPatinete As Integer, idReserva As Integer)
        _idPatinete = idPatinete
        _idReserva = idReserva
        UsopatiDAO = New UsoPatineteDAO
    End Sub

    Public Property IdPatinete As Integer
        Get
            Return _idPatinete
        End Get
        Set(value As Integer)
            _idPatinete = value
        End Set
    End Property

    Public Property IdReserva As Integer
        Get
            Return _idReserva
        End Get
        Set(value As Integer)
            _idReserva = value
        End Set
    End Property

    Public Property UsopatiDAO As UsoPatineteDAO
        Get
            Return _usopatiDAO
        End Get
        Set(value As UsoPatineteDAO)
            _usopatiDAO = value
        End Set
    End Property

    Public Function ReadAll()
        UsopatiDAO.ReadAll()

    End Function
End Class
