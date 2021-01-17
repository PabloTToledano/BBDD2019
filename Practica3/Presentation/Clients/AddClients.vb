Public Class AddClients
    Private Sub AddClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTelefono_Click(sender As Object, e As EventArgs) Handles lblTelefono.Click

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim dni As String
        Dim nombre As String
        Dim telefono As Int32
        Dim direccion As String
        Dim email As String
        Try
            dni = txtDNI.Text
            nombre = txtNombre.Text
            telefono = txtTlfno.Text
            direccion = txtDireccion.Text
            email = txtEmail.Text
            Dim c1 As New Client(dni, nombre, telefono, direccion, email)
            c1.Insert()
        Catch InvalidCastException As Exception
            'AQUI PONGO UN MENSAJE O UN POPUP O LO QUE SALGA Y LIMPIO CAMPOS, TODO DEBE ESTAR RELLENADO
        End Try

    End Sub

    Private Sub lblMensaje_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub
End Class