Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Public Class UsoPatineteDAO
    Dim _usopatineteList As Collection

    Public Sub New()
        _usopatineteList = New Collection
    End Sub

    Public Property UsopatineteList As Collection
        Get
            Return _usopatineteList
        End Get
        Set(value As Collection)
            _usopatineteList = value
        End Set
    End Property
    Public Function ReadAll()
        Dim agente As AgenteBD = AgenteBD.getAgente()
        Dim sSQL As String = "SELECT * FROM USO_PATINETES ORDER BY IdPatinete;"
        Dim ole As OleDbDataReader = agente.leer(sSQL)
        While ole.Read
            Dim idPatinete As Integer = ole("IdPatinete")
            Dim idReserva As Integer = ole("IdReserva")
            Dim usopati As New UsoPatinete(idPatinete, idReserva)
            _usopatineteList.Add(usopati)
        End While
    End Function

End Class
