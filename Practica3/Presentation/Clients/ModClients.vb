Public Class ModClients
    Private Sub lblVelocidad_Click(sender As Object, e As EventArgs) Handles lblTelefono.Click

    End Sub

    Private Sub ModClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gestor As New Gestor
        txtDNI.Enabled = False
        Dim clientes As Collection = gestor.ReadAllClients
        For Each client In clientes
            lbxClients.Items.Add(client.DNI)
        Next
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim cl As New Client(txtDNI.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text)

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

    Private Sub lbxClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxClients.SelectedIndexChanged
        Try
            Dim dni As String = lbxClients.SelectedItem.ToString
            txtDNI.Text = dni
            Dim cl As New Client()
            cl.Dni = dni
            cl.Read()
            txtDireccion.Text = cl.Direccion
            txtEmail.Text = cl.Email
            txtNombre.Text = cl.Nombre
            txtTelefono.Text = cl.Telefono
            lblMensaje.Visible = False
        Catch ex As System.NullReferenceException

        End Try
    End Sub
End Class