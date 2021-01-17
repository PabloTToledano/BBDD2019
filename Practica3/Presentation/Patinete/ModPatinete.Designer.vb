<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modPatinete
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lbxPatinetes = New System.Windows.Forms.ListBox()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.cbbTipo = New System.Windows.Forms.ComboBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(309, 291)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(197, 57)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(259, 14)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(82, 17)
        Me.lblPeso.TabIndex = 16
        Me.lblPeso.Text = "Descripción"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(283, 138)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 17)
        Me.lblTipo.TabIndex = 15
        Me.lblTipo.Text = "Tipo"
        '
        'lbxPatinetes
        '
        Me.lbxPatinetes.FormattingEnabled = True
        Me.lbxPatinetes.ItemHeight = 16
        Me.lbxPatinetes.Location = New System.Drawing.Point(12, 12)
        Me.lbxPatinetes.Name = "lbxPatinetes"
        Me.lbxPatinetes.Size = New System.Drawing.Size(214, 356)
        Me.lbxPatinetes.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(245, 34)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(261, 85)
        Me.txtDescripcion.TabIndex = 20
        Me.txtDescripcion.Text = ""
        '
        'cbbTipo
        '
        Me.cbbTipo.FormattingEnabled = True
        Me.cbbTipo.Location = New System.Drawing.Point(325, 138)
        Me.cbbTipo.Name = "cbbTipo"
        Me.cbbTipo.Size = New System.Drawing.Size(181, 24)
        Me.cbbTipo.TabIndex = 21
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(306, 351)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.lblMensaje.TabIndex = 22
        Me.lblMensaje.Text = "Label1"
        '
        'modPatinete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 391)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.cbbTipo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lbxPatinetes)
        Me.Name = "modPatinete"
        Me.Text = "modPatinete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lbxPatinetes As ListBox
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents cbbTipo As ComboBox
    Friend WithEvents lblMensaje As Label
End Class
