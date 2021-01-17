Public Class DeletePatinete
    Private Sub DeletePatinete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.Visible = False
        rtxDescripcion.Enabled = False
        txtTipo.Enabled = False
        Dim gestor As New Gestor
        Dim patinetes As Collection = gestor.ReadAllPatinetes
        For Each patinete In patinetes
            lbxPatinetes.Items.Add(patinete.IdPatinete)
        Next

    End Sub

    Private Sub lbxPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPatinetes.SelectedIndexChanged
        Try
            lblMensaje.Visible = False
            Dim idPatinete As String = lbxPatinetes.SelectedItem.ToString
            Dim patinete As New Patinete
            patinete.IdPatinete = idPatinete
            patinete.Read()
            rtxDescripcion.Text = patinete.Descripcion
            txtTipo.Text = patinete.IdTipo
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim cl As New Patinete(txtTipo.Text, rtxDescripcion.Text)
            cl.IdPatinete = lbxPatinetes.SelectedItem.ToString
            If cl.Delete() > 0 Then
                lblMensaje.Text = "Borrado realizado correctamente"
                lblMensaje.Visible = True
                lbxPatinetes.Items.Remove(cl.IdPatinete)

            Else
                lblMensaje.Text = "Error al borrar"
                lblMensaje.Visible = True
            End If
        Catch ex As InvalidCastException

        End Try
    End Sub
End Class