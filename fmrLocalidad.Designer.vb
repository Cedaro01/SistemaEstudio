<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmrLocalidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Grillalocalidad = New System.Windows.Forms.DataGridView()
        Me.ID_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregarlocalidad = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificarlocalidad = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminarlocalidad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdsalirlocalidad = New System.Windows.Forms.ToolStripButton()
        Me.lblseñallocalidad = New System.Windows.Forms.Label()
        CType(Me.Grillalocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grillalocalidad
        '
        Me.Grillalocalidad.AllowUserToAddRows = False
        Me.Grillalocalidad.BackgroundColor = System.Drawing.Color.DimGray
        Me.Grillalocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grillalocalidad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grillalocalidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillalocalidad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grillalocalidad.ColumnHeadersHeight = 35
        Me.Grillalocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grillalocalidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_localidad, Me.Nombre, Me.Activo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grillalocalidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grillalocalidad.EnableHeadersVisualStyles = False
        Me.Grillalocalidad.GridColor = System.Drawing.Color.DarkGray
        Me.Grillalocalidad.Location = New System.Drawing.Point(0, 110)
        Me.Grillalocalidad.Name = "Grillalocalidad"
        Me.Grillalocalidad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillalocalidad.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Grillalocalidad.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Grillalocalidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grillalocalidad.Size = New System.Drawing.Size(321, 325)
        Me.Grillalocalidad.TabIndex = 5
        '
        'ID_localidad
        '
        Me.ID_localidad.HeaderText = "Numero"
        Me.ID_localidad.Name = "ID_localidad"
        Me.ID_localidad.Width = 80
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregarlocalidad, Me.CmdModificarlocalidad, Me.Cmdeliminarlocalidad, Me.ToolStripSeparator1, Me.cmdsalirlocalidad})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(322, 71)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregarlocalidad
        '
        Me.Cmdagregarlocalidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregarlocalidad.Image = Global.SistemaEstudio.My.Resources.Resources.Agregar
        Me.Cmdagregarlocalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregarlocalidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregarlocalidad.Name = "Cmdagregarlocalidad"
        Me.Cmdagregarlocalidad.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregarlocalidad.Text = "Agregar"
        Me.Cmdagregarlocalidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CmdModificarlocalidad
        '
        Me.CmdModificarlocalidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdModificarlocalidad.Image = Global.SistemaEstudio.My.Resources.Resources.Modificar
        Me.CmdModificarlocalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdModificarlocalidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdModificarlocalidad.Name = "CmdModificarlocalidad"
        Me.CmdModificarlocalidad.Size = New System.Drawing.Size(68, 68)
        Me.CmdModificarlocalidad.Text = "Modificar"
        Me.CmdModificarlocalidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cmdeliminarlocalidad
        '
        Me.Cmdeliminarlocalidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdeliminarlocalidad.Image = Global.SistemaEstudio.My.Resources.Resources.Eliminar
        Me.Cmdeliminarlocalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdeliminarlocalidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdeliminarlocalidad.Name = "Cmdeliminarlocalidad"
        Me.Cmdeliminarlocalidad.Size = New System.Drawing.Size(68, 68)
        Me.Cmdeliminarlocalidad.Text = "Eliminar"
        Me.Cmdeliminarlocalidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'cmdsalirlocalidad
        '
        Me.cmdsalirlocalidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalirlocalidad.Image = Global.SistemaEstudio.My.Resources.Resources.Salir
        Me.cmdsalirlocalidad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsalirlocalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalirlocalidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalirlocalidad.Name = "cmdsalirlocalidad"
        Me.cmdsalirlocalidad.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalirlocalidad.Text = "Salir"
        '
        'lblseñallocalidad
        '
        Me.lblseñallocalidad.AutoSize = True
        Me.lblseñallocalidad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñallocalidad.ForeColor = System.Drawing.Color.White
        Me.lblseñallocalidad.Location = New System.Drawing.Point(247, 88)
        Me.lblseñallocalidad.Name = "lblseñallocalidad"
        Me.lblseñallocalidad.Size = New System.Drawing.Size(63, 19)
        Me.lblseñallocalidad.TabIndex = 44
        Me.lblseñallocalidad.Text = "Label10"
        Me.lblseñallocalidad.Visible = False
        '
        'fmrLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(322, 437)
        Me.Controls.Add(Me.lblseñallocalidad)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Grillalocalidad)
        Me.Name = "fmrLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localidad"
        CType(Me.Grillalocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grillalocalidad As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregarlocalidad As ToolStripButton
    Friend WithEvents CmdModificarlocalidad As ToolStripButton
    Friend WithEvents Cmdeliminarlocalidad As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdsalirlocalidad As ToolStripButton
    Friend WithEvents ID_localidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents lblseñallocalidad As Label
End Class
