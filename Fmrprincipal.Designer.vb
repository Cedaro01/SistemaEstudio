<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmrprincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParametroToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.CiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.horafecha = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(106, 687)
        Me.Panel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton6, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(101, 687)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.SistemaEstudio.My.Resources.Resources.Pacientes
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(98, 86)
        Me.ToolStripButton2.Text = "Pacientes"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.SistemaEstudio.My.Resources.Resources.ObraSocial
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(98, 86)
        Me.ToolStripButton1.Text = "Obra Social"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(98, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.SistemaEstudio.My.Resources.Resources.Turnos
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(98, 86)
        Me.ToolStripButton3.Text = "Turnos"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.SistemaEstudio.My.Resources.Resources.Estudios
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(98, 86)
        Me.ToolStripButton6.Text = "Estudios"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = Global.SistemaEstudio.My.Resources.Resources.Agenda
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(98, 86)
        Me.ToolStripButton4.Text = "Agenda"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(98, 6)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = Global.SistemaEstudio.My.Resources.Resources.Salir
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(98, 86)
        Me.ToolStripButton5.Text = "Salida"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(106, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 687)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(879, 108)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sistema de Gestión"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParametroToolStripMenuItem
        '
        Me.ParametroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ParametroToolStripMenuItem.Checked = True
        Me.ParametroToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ParametroToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ParametroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CiudadesToolStripMenuItem, Me.TipoDocumentoToolStripMenuItem})
        Me.ParametroToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParametroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ParametroToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ParametroToolStripMenuItem.IconColor = System.Drawing.Color.Black
        Me.ParametroToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ParametroToolStripMenuItem.Name = "ParametroToolStripMenuItem"
        Me.ParametroToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ParametroToolStripMenuItem.Text = "Parametro"
        '
        'CiudadesToolStripMenuItem
        '
        Me.CiudadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight
        Me.CiudadesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CiudadesToolStripMenuItem.Name = "CiudadesToolStripMenuItem"
        Me.CiudadesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CiudadesToolStripMenuItem.Text = "Localidad"
        '
        'TipoDocumentoToolStripMenuItem
        '
        Me.TipoDocumentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight
        Me.TipoDocumentoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TipoDocumentoToolStripMenuItem.Name = "TipoDocumentoToolStripMenuItem"
        Me.TipoDocumentoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TipoDocumentoToolStripMenuItem.Text = "Tipo Documento"
        '
        'horafecha
        '
        Me.horafecha.Enabled = True
        '
        'Fmrprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 687)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fmrprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Estudio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents horafecha As Timer
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ParametroToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents CiudadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
