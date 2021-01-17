Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Public Class ClientDAO
    Dim _clientList As New Collection

    Public Sub New()
    End Sub

    Public Property ClientList As Collection
        Get
            Return _clientList
        End Get
        Set(value As Collection)
            _clientList = value
        End Set
    End Property
    Public Function ReadAll()

        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM CLIENTES ORDER BY DNI;"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        While ole.Read()
            Dim nombre As String = ole("Nombre")
            Dim dni As String = ole("DNI")
            Dim telefono As Int32 = ole("Teléfono")
            Dim direccion As String = ole("Dirección")
            Dim email As String = ole("Email")
            Dim c1 As New Client(dni, nombre, telefono, direccion, email)
            _clientList.Add(c1)
        End While

    End Function
    Public Function Insert(cl As Client) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "INSERT INTO CLIENTES VALUES ('" & cl.Dni & "','" & cl.Nombre & "','" & cl.Telefono & "','" & cl.Direccion & "','" & cl.Email & "');"
        Return agente.modificar(sSQL)
    End Function
    Public Function Read(cl As Client)
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM CLIENTES WHERE DNI='" & cl.Dni & "';"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        ole.Read()
        cl.Nombre = ole("Nombre")
        cl.Telefono = ole("Teléfono")
        cl.Direccion = ole("Dirección")
        cl.Email = ole("Email")
    End Function
    Public Function Update(cl As Client) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "UPDATE CLIENTES SET Nombre='" & cl.Nombre & "',Teléfono='" & cl.Telefono & "',Dirección='" & cl.Direccion & "',Email='" & cl.Email & "'WHERE DNI='" & cl.Dni & "';"
        Return agente.modificar(sSQL)
    End Function
    Public Function Delete(cl As Client) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "DELETE FROM CLIENTES WHERE DNI='" & cl.Dni & "';"
        Return agente.modificar(sSQL)
    End Function
End Class
