<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editoriales
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdEliminar = New System.Windows.Forms.Button()
        Me.CmdEditar = New System.Windows.Forms.Button()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.DtgEditoriales = New System.Windows.Forms.DataGridView()
        Me.GpoDatos = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEemail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEdireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEditorial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DtgEditoriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdSalir
        '
        Me.CmdSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdSalir.Location = New System.Drawing.Point(691, 572)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(55, 54)
        Me.CmdSalir.TabIndex = 29
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdEliminar.Location = New System.Drawing.Point(547, 572)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(55, 54)
        Me.CmdEliminar.TabIndex = 30
        Me.CmdEliminar.Text = "Eliminar"
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'CmdEditar
        '
        Me.CmdEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdEditar.Location = New System.Drawing.Point(376, 572)
        Me.CmdEditar.Name = "CmdEditar"
        Me.CmdEditar.Size = New System.Drawing.Size(51, 54)
        Me.CmdEditar.TabIndex = 31
        Me.CmdEditar.Text = "Editar"
        Me.CmdEditar.UseVisualStyleBackColor = True
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdGuardar.Location = New System.Drawing.Point(210, 572)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(54, 54)
        Me.CmdGuardar.TabIndex = 32
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdNuevo.Location = New System.Drawing.Point(38, 572)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(58, 54)
        Me.CmdNuevo.TabIndex = 33
        Me.CmdNuevo.Text = "Nuevo"
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'DtgEditoriales
        '
        Me.DtgEditoriales.AllowUserToAddRows = False
        Me.DtgEditoriales.AllowUserToDeleteRows = False
        Me.DtgEditoriales.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DtgEditoriales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DtgEditoriales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgEditoriales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DtgEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgEditoriales.DefaultCellStyle = DataGridViewCellStyle13
        Me.DtgEditoriales.Location = New System.Drawing.Point(15, 316)
        Me.DtgEditoriales.Name = "DtgEditoriales"
        Me.DtgEditoriales.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgEditoriales.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DtgEditoriales.RowHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DtgEditoriales.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DtgEditoriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgEditoriales.Size = New System.Drawing.Size(766, 236)
        Me.DtgEditoriales.TabIndex = 28
        '
        'GpoDatos
        '
        Me.GpoDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpoDatos.Controls.Add(Me.MaskedTextBox1)
        Me.GpoDatos.Controls.Add(Me.TxtEemail)
        Me.GpoDatos.Controls.Add(Me.Label9)
        Me.GpoDatos.Controls.Add(Me.Label8)
        Me.GpoDatos.Controls.Add(Me.TxtEdireccion)
        Me.GpoDatos.Controls.Add(Me.Label7)
        Me.GpoDatos.Controls.Add(Me.TxtEditorial)
        Me.GpoDatos.Controls.Add(Me.Label1)
        Me.GpoDatos.Enabled = False
        Me.GpoDatos.Location = New System.Drawing.Point(38, 62)
        Me.GpoDatos.Name = "GpoDatos"
        Me.GpoDatos.Size = New System.Drawing.Size(718, 248)
        Me.GpoDatos.TabIndex = 27
        Me.GpoDatos.TabStop = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(113, 176)
        Me.MaskedTextBox1.Mask = "000-000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(230, 20)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'TxtEemail
        '
        Me.TxtEemail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtEemail.Location = New System.Drawing.Point(405, 177)
        Me.TxtEemail.MaxLength = 80
        Me.TxtEemail.Name = "TxtEemail"
        Me.TxtEemail.Size = New System.Drawing.Size(292, 20)
        Me.TxtEemail.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(362, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "EMail"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Telefono"
        '
        'TxtEdireccion
        '
        Me.TxtEdireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtEdireccion.Location = New System.Drawing.Point(113, 105)
        Me.TxtEdireccion.MaxLength = 80
        Me.TxtEdireccion.Name = "TxtEdireccion"
        Me.TxtEdireccion.Size = New System.Drawing.Size(584, 20)
        Me.TxtEdireccion.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Direccion"
        '
        'TxtEditorial
        '
        Me.TxtEditorial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TxtEditorial.Location = New System.Drawing.Point(111, 38)
        Me.TxtEditorial.MaxLength = 80
        Me.TxtEditorial.Name = "TxtEditorial"
        Me.TxtEditorial.Size = New System.Drawing.Size(586, 20)
        Me.TxtEditorial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 32)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Editoriales"
        '
        'Editoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(790, 638)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdEliminar)
        Me.Controls.Add(Me.CmdEditar)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Controls.Add(Me.CmdNuevo)
        Me.Controls.Add(Me.DtgEditoriales)
        Me.Controls.Add(Me.GpoDatos)
        Me.MinimizeBox = False
        Me.Name = "Editoriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editoriales"
        CType(Me.DtgEditoriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpoDatos.ResumeLayout(False)
        Me.GpoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents CmdEditar As System.Windows.Forms.Button
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DtgEditoriales As System.Windows.Forms.DataGridView
    Friend WithEvents GpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEemail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtEdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEditorial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
