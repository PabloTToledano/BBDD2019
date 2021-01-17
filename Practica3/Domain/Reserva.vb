Imports Practica3

Public Class Reserva
    Dim _fechaInicio As Date
    Dim _fechaFin As Date
    Dim _idCliente As String
    Dim _fechaReserva As Date
    Dim _PrecioReserva As Double
    Dim _idReserva As Integer
    Dim _reservaDAO As ReservaDAO

    Public Sub New()
        ReservaDAO = New ReservaDAO
    End Sub

    Public Sub New(fechaInicio As Date, fechaFin As Date, idCliente As String, fechaReserva As Date, PrecioReserva As Double)
        _fechaInicio = fechaInicio
        _fechaFin = fechaFin
        _idCliente = idCliente
        _fechaReserva = fechaReserva
        _PrecioReserva = PrecioReserva
        ReservaDAO = New ReservaDAO
    End Sub

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property FechaReserva As Date
        Get
            Return _fechaReserva
        End Get
        Set(value As Date)
            _fechaReserva = value
        End Set
    End Property

    Public Property PrecioReserva As Double
        Get
            Return _PrecioReserva
        End Get
        Set(value As Double)
            _PrecioReserva = value
        End Set
    End Property

    Public Property FechaFin As Date
        Get
            Return _fechaFin
        End Get
        Set(value As Date)
            _fechaFin = value
        End Set
    End Property

    Public Property FechaInicio As Date
        Get
            Return _fechaInicio
        End Get
        Set(value As Date)
            _fechaInicio = value
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

    Public Property ReservaDAO As ReservaDAO
        Get
            Return _reservaDAO
        End Get
        Set(value As ReservaDAO)
            _reservaDAO = value
        End Set
    End Property
    Public Function ReadAll()
        _reservaDAO.ReadAll()
    End Function
    Public Function Insert() As Integer
        Return _reservaDAO.Insert(Me)
    End Function
    Public Function Read() As Integer
        Return _reservaDAO.Read(Me)
    End Function
End Class
