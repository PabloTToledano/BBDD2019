<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTipoPatinete
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
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtPesoMax = New System.Windows.Forms.TextBox()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblPesoMax = New System.Windows.Forms.Label()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(88, 30)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(126, 20)
        Me.txtMarca.TabIndex = 0
        '
        'txtPesoMax
        '
        Me.txtPesoMax.Location = New System.Drawing.Point(88, 53)
        Me.txtPesoMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPesoMax.Name = "txtPesoMax"
        Me.txtPesoMax.Size = New System.Drawing.Size(126, 20)
        Me.txtPesoMax.TabIndex = 1
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(88, 76)
        Me.txtVelocidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(126, 20)
        Me.txtVelocidad.TabIndex = 2
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(88, 98)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(126, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(49, 32)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 4
        Me.lblMarca.Text = "Marca"
        '
        'lblPesoMax
        '
        Me.lblPesoMax.AutoSize = True
        Me.lblPesoMax.Location = New System.Drawing.Point(16, 55)
        Me.lblPesoMax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPesoMax.Name = "lblPesoMax"
        Me.lblPesoMax.Size = New System.Drawing.Size(70, 13)
        Me.lblPesoMax.TabIndex = 5
        Me.lblPesoMax.Text = "Peso Máximo"
        '
        'lblVelocidad
        '
        Me.lblVelocidad.AutoSize = True
        Me.lblVelocidad.Location = New System.Drawing.Point(32, 78)
        Me.lblVelocidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(54, 13)
        Me.lblVelocidad.TabIndex = 6
        Me.lblVelocidad.Text = "Velocidad"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(22, 101)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(65, 13)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "Precio/Hora"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(28, 143)
        Me.btnAñadir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(56, 19)
        Me.btnAñadir.TabIndex = 8
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(88, 143)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(124, 19)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(26, 200)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 10
        Me.lblMensaje.Text = "Label1"
        Me.lblMensaje.Visible = False
        '
        'AddTipoPatinete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 260)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.lblPesoMax)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.txtPesoMax)
        Me.Controls.Add(Me.txtMarca)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AddTipoPatinete"
        Me.Text = "Añadir Tipo Patinete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtPesoMax As TextBox
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblPesoMax As Label
    Friend WithEvents lblVelocidad As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblMensaje As Label
End Class
