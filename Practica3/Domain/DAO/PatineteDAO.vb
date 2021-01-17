Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Public Class PatineteDAO
    Dim _patineteList As Collection

    Public Sub New()
        _patineteList = New Collection
    End Sub

    Public Property PatineteList As Collection
        Get
            Return _patineteList
        End Get
        Set(value As Collection)
            _patineteList = value
        End Set
    End Property
    Public Function ReadAll()
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM PATINETES ORDER BY IdPatinete;"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        While ole.Read
            Dim descripcion As String = ole("Descripción")
            Dim idtipo As Double = ole("IdTipo")
            Dim idPatinete As Integer = ole("IdPatinete")
            Dim pati As New Patinete(idtipo, descripcion)
            pati.IdPatinete = idPatinete
            _patineteList.Add(pati)
        End While

    End Function
    Public Function Insert(cl As Patinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "INSERT INTO PATINETES (Descripción, IdTipo) VALUES ('" & cl.Descripcion & "'," & cl.IdTipo & ");"
        Return agente.modificar(sSQL)
    End Function
    Public Function Read(c1 As Patinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM PATINETES WHERE IdPatinete=" & c1.IdPatinete & ";"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        ole.Read()
        c1.IdPatinete = ole("IdPatinete")
        c1.Descripcion = ole("Descripción")
        c1.IdTipo = ole("IdTipo")
    End Function
    Public Function Delete(cl As Patinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "DELETE FROM PATINETES WHERE IdTipo=" & cl.IdPatinete & ";"
        Return agente.modificar(sSQL)
    End Function
    Public Function Update(cl As Patinete) As Integer
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "UPDATE PATINETES SET Descripción='" & cl.Descripcion & "',IdTipo=" & cl.IdTipo & " WHERE IdPatinete=" & cl.IdPatinete & ";"
        Return agente.modificar(sSQL)
    End Function

End Class
