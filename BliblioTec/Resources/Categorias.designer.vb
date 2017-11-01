<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdEliminar = New System.Windows.Forms.Button()
        Me.CmdEditar = New System.Windows.Forms.Button()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.DtgCategorias = New System.Windows.Forms.DataGridView()
        Me.GpoDatos = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DtgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdSalir
        '
        Me.CmdSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdSalir.Location = New System.Drawing.Point(707, 506)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(55, 54)
        Me.CmdSalir.TabIndex = 29
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdEliminar.Location = New System.Drawing.Point(563, 506)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(55, 54)
        Me.CmdEliminar.TabIndex = 30
        Me.CmdEliminar.Text = "Eliminar"
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'CmdEditar
        '
        Me.CmdEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdEditar.Location = New System.Drawing.Point(392, 506)
        Me.CmdEditar.Name = "CmdEditar"
        Me.CmdEditar.Size = New System.Drawing.Size(51, 54)
        Me.CmdEditar.TabIndex = 31
        Me.CmdEditar.Text = "Editar"
        Me.CmdEditar.UseVisualStyleBackColor = True
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdGuardar.Enabled = False
        Me.CmdGuardar.Location = New System.Drawing.Point(226, 506)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(54, 54)
        Me.CmdGuardar.TabIndex = 32
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdNuevo.Location = New System.Drawing.Point(54, 506)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(58, 54)
        Me.CmdNuevo.TabIndex = 33
        Me.CmdNuevo.Text = "Nuevo"
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'DtgCategorias
        '
        Me.DtgCategorias.AllowUserToAddRows = False
        Me.DtgCategorias.AllowUserToDeleteRows = False
        Me.DtgCategorias.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DtgCategorias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCategorias.Location = New System.Drawing.Point(9, 258)
        Me.DtgCategorias.Name = "DtgCategorias"
        Me.DtgCategorias.ReadOnly = True
        Me.DtgCategorias.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DtgCategorias.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgCategorias.Size = New System.Drawing.Size(766, 231)
        Me.DtgCategorias.TabIndex = 28
        '
        'GpoDatos
        '
        Me.GpoDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpoDatos.Controls.Add(Me.TxtDescripcion)
        Me.GpoDatos.Controls.Add(Me.Label5)
        Me.GpoDatos.Controls.Add(Me.TxtCategoria)
        Me.GpoDatos.Controls.Add(Me.Label1)
        Me.GpoDatos.Location = New System.Drawing.Point(30, 31)
        Me.GpoDatos.Name = "GpoDatos"
        Me.GpoDatos.Size = New System.Drawing.Size(732, 203)
        Me.GpoDatos.TabIndex = 27
        Me.GpoDatos.TabStop = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(55, 111)
        Me.TxtDescripcion.MaxLength = 80
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(658, 69)
        Me.TxtDescripcion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripcion"
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtCategoria.Enabled = False
        Me.TxtCategoria.Location = New System.Drawing.Point(112, 49)
        Me.TxtCategoria.MaxLength = 80
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(570, 20)
        Me.TxtCategoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(790, 581)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdEliminar)
        Me.Controls.Add(Me.CmdEditar)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Controls.Add(Me.CmdNuevo)
        Me.Controls.Add(Me.DtgCategorias)
        Me.Controls.Add(Me.GpoDatos)
        Me.Enabled = False
        Me.MinimizeBox = False
        Me.Name = "Categorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        CType(Me.DtgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpoDatos.ResumeLayout(False)
        Me.GpoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents CmdEditar As System.Windows.Forms.Button
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DtgCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents GpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
