<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModTipoPatinete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbxPatinetes = New System.Windows.Forms.ListBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxPatinetes
        '
        Me.lbxPatinetes.FormattingEnabled = True
        Me.lbxPatinetes.ItemHeight = 16
        Me.lbxPatinetes.Location = New System.Drawing.Point(27, 31)
        Me.lbxPatinetes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbxPatinetes.Name = "lbxPatinetes"
        Me.lbxPatinetes.Size = New System.Drawing.Size(215, 356)
        Me.lbxPatinetes.TabIndex = 0
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(347, 46)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(173, 22)
        Me.txtMarca.TabIndex = 1
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(347, 74)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(173, 22)
        Me.txtPeso.TabIndex = 2
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(347, 102)
        Me.txtVelocidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(173, 22)
        Me.txtVelocidad.TabIndex = 3
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(347, 130)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(173, 22)
        Me.txtPrecio.TabIndex = 4
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(295, 49)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(47, 17)
        Me.lblMarca.TabIndex = 5
        Me.lblMarca.Text = "Marca"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(273, 78)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(69, 17)
        Me.lblPeso.TabIndex = 6
        Me.lblPeso.Text = "Peso Max"
        '
        'lblVelocidad
        '
        Me.lblVelocidad.AutoSize = True
        Me.lblVelocidad.Location = New System.Drawing.Point(272, 105)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(70, 17)
        Me.lblVelocidad.TabIndex = 7
        Me.lblVelocidad.Text = "Velocidad"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(295, 133)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(48, 17)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(324, 279)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(197, 57)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(320, 356)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.lblMensaje.TabIndex = 35
        Me.lblMensaje.Text = "Label1"
        Me.lblMensaje.Visible = False
        '
        'ModTipoPatinete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 409)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lbxPatinetes)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModTipoPatinete"
        Me.Text = "ModTipoPatinete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxPatinetes As ListBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblVelocidad As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblMensaje As Label
End Class
