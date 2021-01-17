Public Class AddPatinete
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim descripcion As String = txtDescripcion.Text
            Dim tipo As String = cbbTipo.SelectedItem.ToString
            Dim pati As New Patinete(tipo, descripcion)
            pati.Insert()
        Catch ex As InvalidCastException

        End Try


    End Sub

    Private Sub AddPatinete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gestor As New Gestor
        Dim tipos As Collection = gestor.ReadAllTipoPatinetes
        For Each tipo In tipos
            cbbTipo.Items.Add(tipo.idTipo)
        Next

    End Sub

    Private Sub cbbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTipo.SelectedIndexChanged

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub
End Class