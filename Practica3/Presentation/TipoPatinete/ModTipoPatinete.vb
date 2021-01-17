Public Class ModTipoPatinete
    Private Sub ModTipoPatinete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gestor As New Gestor
        Dim tipos As Collection = gestor.ReadAllTipoPatinetes
        For Each tipo In tipos
            lbxPatinetes.Items.Add(tipo.idTipo)
        Next
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim cl As New TipoPatinete(txtMarca.Text, txtPrecio.Text, txtVelocidad.Text, txtPrecio.Text)
            cl.IdTipo = lbxPatinetes.SelectedItem.ToString
            If cl.Update() = 0 Then
                lblMensaje.Text = "Error al actualizar"
                lblMensaje.Visible = True
            Else
                lblMensaje.Text = "Cambio realizado correctamente"
                lblMensaje.Visible = True
            End If
        Catch ex As InvalidCastException

        End Try

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub lblMensaje_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub
End Class