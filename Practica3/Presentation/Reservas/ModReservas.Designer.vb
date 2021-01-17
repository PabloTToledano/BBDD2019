<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModReservas
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtFechaReserva = New System.Windows.Forms.TextBox()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.lbReservas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(182, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(49, 15)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(127, 22)
        Me.txtDNI.TabIndex = 6
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(12, 18)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblDNI.TabIndex = 5
        Me.lblDNI.Text = "DNI"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(369, 189)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(171, 58)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha Reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha Inicio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(415, 140)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(125, 22)
        Me.txtPrecio.TabIndex = 16
        '
        'txtFechaReserva
        '
        Me.txtFechaReserva.Location = New System.Drawing.Point(415, 112)
        Me.txtFechaReserva.Name = "txtFechaReserva"
        Me.txtFechaReserva.Size = New System.Drawing.Size(125, 22)
        Me.txtFechaReserva.TabIndex = 15
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(415, 84)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(125, 22)
        Me.txtFechaFin.TabIndex = 14
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Location = New System.Drawing.Point(415, 56)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(125, 22)
        Me.txtFechaInicio.TabIndex = 13
        '
        'lbReservas
        '
        Me.lbReservas.FormattingEnabled = True
        Me.lbReservas.ItemHeight = 16
        Me.lbReservas.Location = New System.Drawing.Point(12, 44)
        Me.lbReservas.Name = "lbReservas"
        Me.lbReservas.Size = New System.Drawing.Size(245, 420)
        Me.lbReservas.TabIndex = 22
        '
        'ModPatinetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 486)
        Me.Controls.Add(Me.lbReservas)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtFechaReserva)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Name = "ModPatinetes"
        Me.Text = "ModPatinetes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtFechaReserva As TextBox
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents lbReservas As ListBox
End Class
