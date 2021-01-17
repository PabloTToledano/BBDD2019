<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClients
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtTlfno = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(160, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(162, 22)
        Me.txtNombre.TabIndex = 0
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(160, 66)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(162, 22)
        Me.txtDNI.TabIndex = 1
        '
        'txtTlfno
        '
        Me.txtTlfno.Location = New System.Drawing.Point(160, 97)
        Me.txtTlfno.Name = "txtTlfno"
        Me.txtTlfno.Size = New System.Drawing.Size(162, 22)
        Me.txtTlfno.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(160, 125)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(162, 22)
        Me.txtDireccion.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(160, 153)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(162, 22)
        Me.txtEmail.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(65, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(65, 71)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblDNI.TabIndex = 7
        Me.lblDNI.Text = "DNI"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(65, 102)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(65, 128)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Dirección"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(65, 156)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(68, 234)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 12
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(160, 234)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(162, 23)
        Me.btnLimpiarCampos.TabIndex = 13
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(72, 279)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.lblMensaje.TabIndex = 14
        Me.lblMensaje.Text = "Label1"
        '
        'AddClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 320)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTlfno)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "AddClients"
        Me.Text = "Añadir Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtTlfno As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents lblMensaje As Label
End Class
