Imports System.Data.OleDb
Public Class AgenteBD

    Private Shared CadConexion = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source=“
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteBD

    Private Sub New()
        AgenteBD.mConexion = New OleDbConnection(CadConexion)
        AgenteBD.mConexion.Open()
    End Sub

    Public Shared Function getAgente(cad As String) As AgenteBD
        CadConexion = CadConexion & cad

        If mInstancia Is Nothing Then
            mInstancia = New AgenteBD
        End If
        Return mInstancia
    End Function

    Public Shared Function getAgente() As AgenteBD
        Return mInstancia
    End Function

    Public Function leer(ByVal sql As String) As OleDbDataReader
        getAgente(sql)
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function
End Class
