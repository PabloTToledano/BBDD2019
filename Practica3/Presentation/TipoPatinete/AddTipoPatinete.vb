Public Class AddTipoPatinete
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim marca As String
        Dim peso As Integer
        Dim velocidad As Integer
        Dim precioxHora As Integer
        Try
            marca = txtMarca.Text
            peso = txtPesoMax.Text
            velocidad = txtVelocidad.Text
            precioxHora = txtPesoMax.Text
            Dim tipoPatinete As New TipoPatinete(marca, peso, velocidad, precioxHora)
            If tipoPatinete.Insert() = 1 Then
                lblMensaje.Text = " Añadido correctamente"
                lblMensaje.Visible = True
            End If
        Catch ex As InvalidCastException
            lblMensaje.Text = "Algún campo vacio"
            lblMensaje.Visible = True
        End Try



    End Sub

    Private Sub AddTipoPatinete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class