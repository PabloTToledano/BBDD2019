<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteTipoPatiente
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
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lbxPatinetes = New System.Windows.Forms.ListBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(233, 208)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(148, 46)
        Me.btnBorrar.TabIndex = 19
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(211, 93)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 18
        Me.lblPrecio.Text = "Precio"
        '
        'lblVelocidad
        '
        Me.lblVelocidad.AutoSize = True
        Me.lblVelocidad.Location = New System.Drawing.Point(194, 70)
        Me.lblVelocidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(54, 13)
        Me.lblVelocidad.TabIndex = 17
        Me.lblVelocidad.Text = "Velocidad"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(194, 47)
        Me.lblPeso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(54, 13)
        Me.lblPeso.TabIndex = 16
        Me.lblPeso.Text = "Peso Max"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(211, 24)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 15
        Me.lblMarca.Text = "Marca"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(250, 90)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(131, 20)
        Me.txtPrecio.TabIndex = 14
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(250, 67)
        Me.txtVelocidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(131, 20)
        Me.txtVelocidad.TabIndex = 13
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(250, 45)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(131, 20)
        Me.txtPeso.TabIndex = 12
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(250, 22)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(131, 20)
        Me.txtMarca.TabIndex = 11
        '
        'lbxPatinetes
        '
        Me.lbxPatinetes.FormattingEnabled = True
        Me.lbxPatinetes.Location = New System.Drawing.Point(9, 10)
        Me.lbxPatinetes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbxPatinetes.Name = "lbxPatinetes"
        Me.lbxPatinetes.Size = New System.Drawing.Size(162, 290)
        Me.lbxPatinetes.TabIndex = 10
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(230, 274)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 35
        Me.lblMensaje.Text = "Label1"
        Me.lblMensaje.Visible = False
        '
        'DeleteTipoPatiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 312)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lbxPatinetes)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DeleteTipoPatiente"
        Me.Text = "DeleteTipoPatiente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblVelocidad As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents lbxPatinetes As ListBox
    Friend WithEvents lblMensaje As Label
End Class
