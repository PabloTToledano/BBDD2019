<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletePatinete
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
        Me.rtxDescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lbxPatinetes = New System.Windows.Forms.ListBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rtxDescripcion
        '
        Me.rtxDescripcion.Location = New System.Drawing.Point(245, 34)
        Me.rtxDescripcion.Name = "rtxDescripcion"
        Me.rtxDescripcion.Size = New System.Drawing.Size(261, 85)
        Me.rtxDescripcion.TabIndex = 26
        Me.rtxDescripcion.Text = ""
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(309, 291)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(197, 57)
        Me.btnBorrar.TabIndex = 25
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(259, 14)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(82, 17)
        Me.lblPeso.TabIndex = 24
        Me.lblPeso.Text = "Descripción"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(364, 138)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 17)
        Me.lblTipo.TabIndex = 23
        Me.lblTipo.Text = "Tipo"
        '
        'lbxPatinetes
        '
        Me.lbxPatinetes.FormattingEnabled = True
        Me.lbxPatinetes.ItemHeight = 16
        Me.lbxPatinetes.Location = New System.Drawing.Point(12, 12)
        Me.lbxPatinetes.Name = "lbxPatinetes"
        Me.lbxPatinetes.Size = New System.Drawing.Size(214, 356)
        Me.lbxPatinetes.TabIndex = 22
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(309, 356)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(51, 17)
        Me.lblMensaje.TabIndex = 28
        Me.lblMensaje.Text = "Label1"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(406, 133)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 22)
        Me.txtTipo.TabIndex = 29
        '
        'DeletePatinete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 385)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.rtxDescripcion)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lbxPatinetes)
        Me.Name = "DeletePatinete"
        Me.Text = "DeletePatinete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxDescripcion As RichTextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lbxPatinetes As ListBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents txtTipo As TextBox
End Class
