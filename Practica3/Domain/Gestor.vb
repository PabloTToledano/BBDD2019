Public Class Gestor
    Public Sub New()
    End Sub

    Public Function FirstConection(dir As String)
        Dim agente As AgenteBD = AgenteBD.getAgente(dir)
    End Function
    Public Function ReadAllClients() As Collection
        Dim cliente As New Client()
        cliente.ReadAll()
        Return cliente.ClientDao.ClientList
    End Function
    Public Function ReadAllTipoPatinetes() As Collection
        Dim tipo As New TipoPatinete()
        tipo.ReadAll()
        Return tipo.TipoPatineteDAO.TipopatiList
    End Function
    Public Function ReadAllPatinetes() As Collection
        Dim patinete As New Patinete()
        patinete.ReadAll()
        Return patinete.PatiDAO.PatineteList

    End Function
    Public Function ReadAllUsoPatinetes() As Collection
        Dim usopati As New UsoPatinete
        usopati.ReadAll()
        Return usopati.UsopatiDAO.UsopatineteList
    End Function
    Public Function ReadAllReservas() As Collection
        Dim reser As New Reserva
        reser.ReadAll()
        Return reser.ReservaDAO.ReservasList
    End Function
    Public Function ReadPatinetesDisp() As Collection
        Dim patinetes As Collection = ReadAllPatinetes()
        Dim patireservados As Collection = ReadAllUsoPatinetes()
        For Each p In patinetes
            For Each reser In patireservados
                If p.IdPatinete = reser.IdPatinete Then
                    patinetes.Remove(p)
                End If
            Next
        Next
        Return patinetes
    End Function
    Public Function CalculatePrecio(patis As Collection, horas As Integer) As Double
        Dim precio As Double = 0
        Dim tipoPat As New TipoPatinete
        Dim patinete As New Patinete
        For Each pat In patis
            patinete.IdPatinete = pat
            patinete.Read()
            tipoPat.IdTipo = patinete.IdTipo
            tipoPat.Read()
            precio = precio + (horas * tipoPat.PrecioHora)
        Next
        Return precio
    End Function
    Public Function CrearReserva(patis As Collection, reser As Reserva) As Integer
        Dim control As Integer = reser.Insert

    End Function


End Class
