Public Class AddReservas
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dateInicio_ValueChanged(sender As Object, e As EventArgs) Handles dateInicio.ValueChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim dni As String = cbbDNI.SelectedItem.ToString
        Dim fechaini As Date = dateInicio.Value
        Dim fechafin As Date = dateFin.Value
        Dim fechaactu As Date = Date.Today
        Dim patis As New Collection
        For Each pat In clbPatinetes.CheckedItems
            patis.Add(pat)
        Next
        Dim gestor As New Gestor
        Dim precio As Double = gestor.CalculatePrecio(patis, DateDiff(DateInterval.Hour, fechaini, fechafin)) 'date diff calcula la diferencia entre dos fechas
        txtPrecio.Text = precio
    End Sub

    Private Sub clbPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbPatinetes.SelectedIndexChanged

    End Sub

    Private Sub AddReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gestor As New Gestor
        Dim patidispo As Collection = gestor.ReadPatinetesDisp
        For Each pati In patidispo
            clbPatinetes.Items.Add(pati.IdPatinete)
        Next
        Dim clients As Collection = gestor.ReadAllClients
        For Each cl In clients
            cbbDNI.Items.Add(cl.Dni)
        Next
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim dni As String = cbbDNI.SelectedItem.ToString
        Dim fechaini As Date = dateInicio.Value
        Dim fechafin As Date = dateFin.Value
        Dim fechaactu As Date = Date.Today
        Dim patis As New Collection
        For Each pat In clbPatinetes.CheckedItems
            patis.Add(pat)
        Next
        Dim gestor As New Gestor
        Dim precio As Double = gestor.CalculatePrecio(patis, DateDiff(DateInterval.Hour, fechaini, fechafin)) 'date diff calcula la diferencia entre dos fechas
        Dim reser As New Reserva(fechaini, fechafin, dni, Date.Now, precio)
        gestor.CrearReserva(patis, reser)


    End Sub
End Class