Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Public Class ReservaDAO

    Dim _reservasList As Collection

    Public Sub New()
        ReservasList = New Collection
    End Sub

    Public Property ReservasList As Collection
        Get
            Return _reservasList
        End Get
        Set(value As Collection)
            _reservasList = value
        End Set
    End Property

    Public Function ReadAll()
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM RESERVAS ORDER BY IdReserva;"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        While ole.Read
            Dim fechaini As String = ole("Fecha_inicio")
            Dim fechafin As String = ole("Fecha_fin")
            Dim idclient As String = ole("IdCliente")
            Dim fechareser As String = ole("Fecha_Reserva")
            Dim precio As Double = ole("Precio_Reserva")
            Dim reserva As New Reserva(fechaini, fechafin, idclient, fechareser, precio)
            reserva.IdReserva = ole("IdReserva")
            ReservasList.Add(reserva)
        End While

    End Function
    Public Function Insert(cl As Reserva) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "INSERT INTO RESERVAS (Fecha_inicio, Fecha_fin, IdCliente, Fecha_Reserva, Precio_Reserva) VALUES ('" & cl.FechaInicio & "','" & cl.FechaFin & "','" & cl.IdCliente & "','" & cl.FechaReserva & "'," & cl.PrecioReserva & ");"
        Return agente.modificar(sSQL)
    End Function
    Public Function Read(cl As Reserva) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM RESERVA  WHERE IdTipo=" & cl.IdTipo & ";"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        ole.Read()
        cl.IdTipo = ole("IdTipo")
        cl.Marca = ole("Marca")
        cl.Persomax = ole("PesoPermitido")
        cl.PrecioHora = ole("PrecioxHora")
        cl.Velocidad = ole("Velocidad")
    End Function
End Class
