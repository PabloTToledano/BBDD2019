Public Class Form1

    Private Sub RutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaToolStripMenuItem.Click
        Dim dirDb As String
        ofd1.Filter = "Data Bases files (*.accdb)|*.accdb"
        Dim resultDir As DialogResult = ofd1.ShowDialog()
        If resultDir = DialogResult.OK Then
            dirDb = ofd1.FileName
            txtRuta.Text = dirDb
            HolaToolStripMenuItem.Enabled = True
            PatineteToolStripMenuItem.Enabled = True
            ReservasToolStripMenuItem.Enabled = True
            Dim gestor As New Gestor
            gestor.FirstConection(dirDb)
            'aqui va la creacion del agente y la conexion
        End If
    End Sub

    Private Sub MeGustaComerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles anadirbutton.Click
        AddClients.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        AddPatinete.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem2.Click
        AddTipoPatinete.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModClients.Show()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        DeleteClient.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        modPatinete.Show()
    End Sub

    Private Sub BorrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem1.Click
        DeletePatinete.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem3.Click
        ModTipoPatinete.Show()
    End Sub

    Private Sub BorrarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem3.Click
        DeleteTipoPatiente.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRuta.Enabled = False
        HolaToolStripMenuItem.Enabled = False
        PatineteToolStripMenuItem.Enabled = False
        ReservasToolStripMenuItem.Enabled = False

    End Sub

    Private Sub AñadirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem1.Click
        AddReservas.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem2.Click
        ModReservas.Show()
    End Sub

    Private Sub BorrarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem2.Click
        DeleteReservas.Show()
    End Sub
End Class
