Public Class DeleteClient
    Private Sub DeleteClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDireccion.Enabled = False
        txtDNI.Enabled = False
        txtEmail.Enabled = False
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        Dim gestor As New Gestor
        Dim clientes As Collection = gestor.ReadAllClients
        For Each client In clientes
            lbxClients.Items.Add(client.DNI)
        Next
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim cl As New Client(txtDNI.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, txtEmail.Text)
            If cl.Delete() = 0 Then
                lblMensaje.Text = "Error al borrar"
                lblMensaje.Visible = True
            Else
                lblMensaje.Text = "Borrado realizado correctamente"
                lblMensaje.Visible = True
                lbxClients.Items.Remove(cl.Dni)
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