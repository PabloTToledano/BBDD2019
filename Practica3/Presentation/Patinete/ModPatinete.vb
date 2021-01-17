Public Class modPatinete
    Private Sub lblPeso_Click(sender As Object, e As EventArgs) Handles lblPeso.Click

    End Sub

    Private Sub modPatinete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.Visible = False
        Dim gestor As New Gestor
        Dim patinetes As Collection = gestor.ReadAllPatinetes
        For Each patinete In patinetes
            lbxPatinetes.Items.Add(patinete.idPatinete)
        Next
        Dim tipos As Collection = gestor.ReadAllTipoPatinetes
        For Each tipo In tipos
            cbbTipo.Items.Add(tipo.idTipo)
        Next
    End Sub

    Private Sub lbxPatinetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPatinetes.SelectedIndexChanged
        Try
            lblMensaje.Visible = False
            Dim idPatinete As String = lbxPatinetes.SelectedItem.ToString
            Dim patinete As New Patinete
            patinete.IdPatinete = idPatinete
            patinete.Read()
            txtDescripcion.Text = patinete.Descripcion
            cbbTipo.SelectedItem = patinete.IdTipo


        Catch ex As System.NullReferenceException

        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim cl As New Patinete(cbbTipo.SelectedItem.ToString, txtDescripcion.Text)
            cl.IdPatinete = lbxPatinetes.SelectedItem.ToString
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

    Private Sub lblPatinete_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub
End Class