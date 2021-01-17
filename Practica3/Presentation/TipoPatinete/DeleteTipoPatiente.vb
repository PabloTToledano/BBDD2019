Public Class DeleteTipoPatiente
    Private Sub DeleteTipoPatiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMarca.Enabled = False
        txtPeso.Enabled = False
        txtPrecio.Enabled = False
        txtVelocidad.Enabled = False
        Dim gestor As New Gestor
        Dim tipos As Collection = gestor.ReadAllTipoPatinetes
        For Each tipo In tipos
            lbxPatinetes.Items.Add(tipo.idTipo)
        Next
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim cl As New TipoPatinete(txtMarca.Text, txtPrecio.Text, txtVelocidad.Text, txtPrecio.Text)
            cl.IdTipo = lbxPatinetes.SelectedItem
            If cl.Delete() = 0 Then
                lblMensaje.Text = "Error al borrar"
                lblMensaje.Visible = True
            Else
                lblMensaje.Text = "Borrado realizado correctamente"
                lblMensaje.Visible = True
                lbxPatinetes.Items.Remove(cl.IdTipo)
            End If
        Catch ex As InvalidCastException

        End Try
    End Sub

    Private Sub lbxPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPatinetes.SelectedIndexChanged
        Try
            Dim idTipo As String = lbxPatinetes.SelectedItem.ToString
            Dim tipo As New TipoPatinete
            tipo.IdTipo = idTipo
            tipo.Read()
            txtMarca.Text = tipo.Marca
            txtPeso.Text = tipo.Persomax
            txtPrecio.Text = tipo.PrecioHora
            txtVelocidad.Text = tipo.Velocidad

        Catch ex As System.NullReferenceException

        End Try
    End Sub
End Class