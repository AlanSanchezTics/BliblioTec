<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevoluciones
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
        Me.components = New System.ComponentModel.Container()
        Me.btnbuscarlector = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbltel = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbFotolector = New System.Windows.Forms.PictureBox()
        Me.txtnlector = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgprestamos = New System.Windows.Forms.DataGridView()
        Me.IDPRESTAMODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPrestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDevolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExisteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ViewDevBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSet = New BliblioTec.BDDBIBLIOTECADataSet()
        Me.btndevolucion = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.ViewDevTableAdapter = New BliblioTec.BDDBIBLIOTECADataSetTableAdapters.viewDevTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFotolector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgprestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDevBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbuscarlector
        '
        Me.btnbuscarlector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscarlector.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarlector.Location = New System.Drawing.Point(253, 88)
        Me.btnbuscarlector.Name = "btnbuscarlector"
        Me.btnbuscarlector.Size = New System.Drawing.Size(149, 23)
        Me.btnbuscarlector.TabIndex = 7
        Me.btnbuscarlector.Text = "Buscar"
        Me.btnbuscarlector.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.lbltel)
        Me.GroupBox1.Controls.Add(Me.lbldireccion)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pbFotolector)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 160)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Lector"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(454, 77)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(45, 15)
        Me.lblemail.TabIndex = 8
        Me.lblemail.Text = "Label9"
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.Location = New System.Drawing.Point(454, 37)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(45, 15)
        Me.lbltel.TabIndex = 7
        Me.lbltel.Text = "Label8"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(178, 77)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(45, 15)
        Me.lbldireccion.TabIndex = 6
        Me.lbldireccion.Text = "Label7"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(178, 40)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(45, 15)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(396, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'pbFotolector
        '
        Me.pbFotolector.Location = New System.Drawing.Point(17, 32)
        Me.pbFotolector.Name = "pbFotolector"
        Me.pbFotolector.Size = New System.Drawing.Size(93, 108)
        Me.pbFotolector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotolector.TabIndex = 0
        Me.pbFotolector.TabStop = False
        '
        'txtnlector
        '
        Me.txtnlector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnlector.Location = New System.Drawing.Point(147, 90)
        Me.txtnlector.Name = "txtnlector"
        Me.txtnlector.Size = New System.Drawing.Size(100, 20)
        Me.txtnlector.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lector:"
        '
        'dtgprestamos
        '
        Me.dtgprestamos.AllowUserToAddRows = False
        Me.dtgprestamos.AllowUserToDeleteRows = False
        Me.dtgprestamos.AllowUserToResizeColumns = False
        Me.dtgprestamos.AllowUserToResizeRows = False
        Me.dtgprestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgprestamos.AutoGenerateColumns = False
        Me.dtgprestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgprestamos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgprestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgprestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRESTAMODataGridViewTextBoxColumn, Me.TituloDataGridViewTextBoxColumn, Me.FechaPrestamoDataGridViewTextBoxColumn, Me.FechaDevolDataGridViewTextBoxColumn, Me.ExisteDataGridViewCheckBoxColumn})
        Me.dtgprestamos.DataSource = Me.ViewDevBindingSource
        Me.dtgprestamos.Location = New System.Drawing.Point(705, 117)
        Me.dtgprestamos.MultiSelect = False
        Me.dtgprestamos.Name = "dtgprestamos"
        Me.dtgprestamos.ReadOnly = True
        Me.dtgprestamos.RowHeadersVisible = False
        Me.dtgprestamos.Size = New System.Drawing.Size(550, 285)
        Me.dtgprestamos.TabIndex = 8
        '
        'IDPRESTAMODataGridViewTextBoxColumn
        '
        Me.IDPRESTAMODataGridViewTextBoxColumn.DataPropertyName = "ID_PRESTAMO"
        Me.IDPRESTAMODataGridViewTextBoxColumn.HeaderText = "ID_PRESTAMO"
        Me.IDPRESTAMODataGridViewTextBoxColumn.Name = "IDPRESTAMODataGridViewTextBoxColumn"
        Me.IDPRESTAMODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        Me.TituloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaPrestamoDataGridViewTextBoxColumn
        '
        Me.FechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Prestamo"
        Me.FechaPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha de Prestamo"
        Me.FechaPrestamoDataGridViewTextBoxColumn.Name = "FechaPrestamoDataGridViewTextBoxColumn"
        Me.FechaPrestamoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDevolDataGridViewTextBoxColumn
        '
        Me.FechaDevolDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Devol"
        Me.FechaDevolDataGridViewTextBoxColumn.HeaderText = "Fecha de Devolucion"
        Me.FechaDevolDataGridViewTextBoxColumn.Name = "FechaDevolDataGridViewTextBoxColumn"
        Me.FechaDevolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExisteDataGridViewCheckBoxColumn
        '
        Me.ExisteDataGridViewCheckBoxColumn.DataPropertyName = "Existe"
        Me.ExisteDataGridViewCheckBoxColumn.HeaderText = "Existe"
        Me.ExisteDataGridViewCheckBoxColumn.Name = "ExisteDataGridViewCheckBoxColumn"
        Me.ExisteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ExisteDataGridViewCheckBoxColumn.Visible = False
        '
        'ViewDevBindingSource
        '
        Me.ViewDevBindingSource.DataMember = "viewDev"
        Me.ViewDevBindingSource.DataSource = Me.BDDBIBLIOTECADataSet
        '
        'BDDBIBLIOTECADataSet
        '
        Me.BDDBIBLIOTECADataSet.DataSetName = "BDDBIBLIOTECADataSet"
        Me.BDDBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btndevolucion
        '
        Me.btndevolucion.Location = New System.Drawing.Point(579, 283)
        Me.btndevolucion.Name = "btndevolucion"
        Me.btndevolucion.Size = New System.Drawing.Size(108, 42)
        Me.btndevolucion.TabIndex = 9
        Me.btndevolucion.Text = "Realizar Devolucion"
        Me.btndevolucion.UseVisualStyleBackColor = True
        '
        'btnmod
        '
        Me.btnmod.Location = New System.Drawing.Point(579, 331)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(108, 42)
        Me.btnmod.TabIndex = 10
        Me.btnmod.Text = "Modificar fecha de entrega"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'ViewDevTableAdapter
        '
        Me.ViewDevTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 27.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(80, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 51)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Devoluciones"
        '
        'frmDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1312, 428)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btndevolucion)
        Me.Controls.Add(Me.dtgprestamos)
        Me.Controls.Add(Me.btnbuscarlector)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnlector)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDevoluciones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Realizar Devolucion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFotolector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgprestamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDevBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbuscarlector As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbFotolector As System.Windows.Forms.PictureBox
    Friend WithEvents txtnlector As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgprestamos As System.Windows.Forms.DataGridView
    Friend WithEvents btndevolucion As System.Windows.Forms.Button
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents BDDBIBLIOTECADataSet As BliblioTec.BDDBIBLIOTECADataSet
    Friend WithEvents ViewDevBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewDevTableAdapter As BliblioTec.BDDBIBLIOTECADataSetTableAdapters.viewDevTableAdapter
    Friend WithEvents IDPRESTAMODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TituloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPrestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDevolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExisteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
