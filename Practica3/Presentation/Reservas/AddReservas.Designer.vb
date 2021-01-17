<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReservas
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
        Me.clbPatinetes = New System.Windows.Forms.CheckedListBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.dateInicio = New System.Windows.Forms.DateTimePicker()
        Me.dateFin = New System.Windows.Forms.DateTimePicker()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.cbbDNI = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'clbPatinetes
        '
        Me.clbPatinetes.FormattingEnabled = True
        Me.clbPatinetes.Location = New System.Drawing.Point(9, 10)
        Me.clbPatinetes.Margin = New System.Windows.Forms.Padding(2)
        Me.clbPatinetes.Name = "clbPatinetes"
        Me.clbPatinetes.Size = New System.Drawing.Size(162, 304)
        Me.clbPatinetes.TabIndex = 0
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(224, 32)
        Me.lblDNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI"
        '
        'dateInicio
        '
        Me.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dateInicio.Location = New System.Drawing.Point(251, 51)
        Me.dateInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dateInicio.Name = "dateInicio"
        Me.dateInicio.Size = New System.Drawing.Size(115, 20)
        Me.dateInicio.TabIndex = 4
        '
        'dateFin
        '
        Me.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dateFin.Location = New System.Drawing.Point(251, 74)
        Me.dateFin.Margin = New System.Windows.Forms.Padding(2)
        Me.dateFin.Name = "dateFin"
        Me.dateFin.Size = New System.Drawing.Size(115, 20)
        Me.dateFin.TabIndex = 5
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(184, 55)
        Me.lblInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(65, 13)
        Me.lblInicio.TabIndex = 6
        Me.lblInicio.Text = "Fecha Inicio"
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.Location = New System.Drawing.Point(194, 78)
        Me.lblFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(54, 13)
        Me.lblFin.TabIndex = 7
        Me.lblFin.Text = "Fecha Fin"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(251, 106)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(115, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(370, 106)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(56, 19)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(211, 108)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 10
        Me.lblPrecio.Text = "Precio"
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(299, 275)
        Me.btnAnadir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(127, 42)
        Me.btnAnadir.TabIndex = 11
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'cbbDNI
        '
        Me.cbbDNI.FormattingEnabled = True
        Me.cbbDNI.Location = New System.Drawing.Point(251, 26)
        Me.cbbDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbDNI.Name = "cbbDNI"
        Me.cbbDNI.Size = New System.Drawing.Size(115, 21)
        Me.cbbDNI.TabIndex = 12
        '
        'AddReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 334)
        Me.Controls.Add(Me.cbbDNI)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblFin)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.dateFin)
        Me.Controls.Add(Me.dateInicio)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.clbPatinetes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddReservas"
        Me.Text = "AddReservas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clbPatinetes As CheckedListBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents dateInicio As DateTimePicker
    Friend WithEvents dateFin As DateTimePicker
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblFin As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnAnadir As Button
    Friend WithEvents cbbDNI As ComboBox
End Class
