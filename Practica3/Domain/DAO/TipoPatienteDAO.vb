Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Public Class TipoPatienteDAO
    Dim _tipopatiList As Collection

    Public Sub New()
        _tipopatiList = New Collection
    End Sub

    Public Property TipopatiList As Collection
        Get
            Return _tipopatiList
        End Get
        Set(value As Collection)
            _tipopatiList = value
        End Set
    End Property
    Public Function ReadAll()
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM TIPO_PATINETE ORDER BY IdTipo;"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        While ole.Read
            Dim marca As String = ole("Marca")
            Dim peso As Double = ole("PesoPermitido")
            Dim velocidad As Double = ole("Velocidad")
            Dim precio As Double = ole("PrecioxHora")
            Dim tipo As New TipoPatinete(marca, peso, velocidad, precio)
            tipo.IdTipo = ole("IdTipo")
            _tipopatiList.Add(tipo)
        End While

    End Function
    Public Function Insert(cl As TipoPatinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "INSERT INTO TIPO_PATINETE (Marca, PesoPermitido, Velocidad, PrecioxHora) VALUES ('" & cl.Marca & "'," & cl.Persomax & "," & cl.Velocidad & "," & cl.PrecioHora & ");"
        Return agente.modificar(sSQL)
    End Function
    Public Function Read(cl As TipoPatinete)
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM TIPO_PATINETE WHERE IdTipo=" & cl.IdTipo & ";"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        ole.Read()
        cl.IdTipo = ole("IdTipo")
        cl.Marca = ole("Marca")
        cl.Persomax = ole("PesoPermitido")
        cl.PrecioHora = ole("PrecioxHora")
        cl.Velocidad = ole("Velocidad")
    End Function
    Public Function Delete(cl As TipoPatinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "DELETE FROM TIPO_PATINETE WHERE IdTipo=" & cl.IdTipo & ";"
        Return agente.modificar(sSQL)

    End Function
    Public Function Update(cl As TipoPatinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "UPDATE TIPO_PATINETE SET Marca='" & cl.Marca & "',PesoPermitido=" & cl.Persomax & ",Velocidad=" & cl.Velocidad & ",PrecioxHora=" & cl.PrecioHora & " WHERE IdTipo=" & cl.IdTipo & ";"
        Return agente.modificar(sSQL)
    End Function
End Class
