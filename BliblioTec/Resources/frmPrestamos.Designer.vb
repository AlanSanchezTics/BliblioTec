<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnlector = New System.Windows.Forms.TextBox()
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
        Me.btnbuscarlector = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbledicion = New System.Windows.Forms.Label()
        Me.BuscarLibroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BddbibliotecaDataSet = New BliblioTec.BDDBIBLIOTECADataSet()
        Me.lblaño = New System.Windows.Forms.Label()
        Me.lblautor = New System.Windows.Forms.Label()
        Me.lbleditorial = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbfotolibro = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtisbn = New System.Windows.Forms.TextBox()
        Me.btnbuscarlibro = New System.Windows.Forms.Button()
        Me.dtgRentas = New System.Windows.Forms.DataGridView()
        Me.Cisbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ctitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cautor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ceditorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnrentar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BuscarLibroTableAdapter = New BliblioTec.BDDBIBLIOTECADataSetTableAdapters.BuscarLibroTableAdapter()
        Me.TableAdapterManager = New BliblioTec.BDDBIBLIOTECADataSetTableAdapters.TableAdapterManager()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblisbn = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFotolector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BuscarLibroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BddbibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbfotolibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgRentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lector:"
        '
        'txtnlector
        '
        Me.txtnlector.Location = New System.Drawing.Point(114, 72)
        Me.txtnlector.Name = "txtnlector"
        Me.txtnlector.Size = New System.Drawing.Size(100, 20)
        Me.txtnlector.TabIndex = 1
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
        Me.GroupBox1.Location = New System.Drawing.Point(56, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 160)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Lector"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(454, 77)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(0, 15)
        Me.lblemail.TabIndex = 8
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.Location = New System.Drawing.Point(454, 37)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(0, 15)
        Me.lbltel.TabIndex = 7
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(178, 77)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(0, 15)
        Me.lbldireccion.TabIndex = 6
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(178, 40)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(0, 15)
        Me.lblnombre.TabIndex = 5
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
        'btnbuscarlector
        '
        Me.btnbuscarlector.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarlector.Location = New System.Drawing.Point(220, 70)
        Me.btnbuscarlector.Name = "btnbuscarlector"
        Me.btnbuscarlector.Size = New System.Drawing.Size(149, 23)
        Me.btnbuscarlector.TabIndex = 3
        Me.btnbuscarlector.Text = "Buscar"
        Me.btnbuscarlector.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblisbn)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lbledicion)
        Me.GroupBox2.Controls.Add(Me.lblaño)
        Me.GroupBox2.Controls.Add(Me.lblautor)
        Me.GroupBox2.Controls.Add(Me.lbleditorial)
        Me.GroupBox2.Controls.Add(Me.lbltitulo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.pbfotolibro)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 160)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del libro"
        '
        'lbledicion
        '
        Me.lbledicion.AutoSize = True
        Me.lbledicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarLibroBindingSource, "EDICION", True))
        Me.lbledicion.Location = New System.Drawing.Point(513, 32)
        Me.lbledicion.Name = "lbledicion"
        Me.lbledicion.Size = New System.Drawing.Size(0, 13)
        Me.lbledicion.TabIndex = 10
        '
        'BuscarLibroBindingSource
        '
        Me.BuscarLibroBindingSource.DataMember = "BuscarLibro"
        Me.BuscarLibroBindingSource.DataSource = Me.BddbibliotecaDataSet
        '
        'BddbibliotecaDataSet
        '
        Me.BddbibliotecaDataSet.DataSetName = "BDDBIBLIOTECADataSet"
        Me.BddbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarLibroBindingSource, "AÑO", True))
        Me.lblaño.Location = New System.Drawing.Point(338, 82)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(0, 13)
        Me.lblaño.TabIndex = 9
        '
        'lblautor
        '
        Me.lblautor.AutoSize = True
        Me.lblautor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarLibroBindingSource, "Autor", True))
        Me.lblautor.Location = New System.Drawing.Point(338, 32)
        Me.lblautor.Name = "lblautor"
        Me.lblautor.Size = New System.Drawing.Size(0, 13)
        Me.lblautor.TabIndex = 8
        '
        'lbleditorial
        '
        Me.lbleditorial.AutoSize = True
        Me.lbleditorial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarLibroBindingSource, "Nombre", True))
        Me.lbleditorial.Location = New System.Drawing.Point(161, 82)
        Me.lbleditorial.Name = "lbleditorial"
        Me.lbleditorial.Size = New System.Drawing.Size(0, 13)
        Me.lbleditorial.TabIndex = 7
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarLibroBindingSource, "Titulo", True))
        Me.lbltitulo.Location = New System.Drawing.Point(161, 32)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(0, 13)
        Me.lbltitulo.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Año:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Editorial:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(462, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Edicion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Autor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Titulo:"
        '
        'pbfotolibro
        '
        Me.pbfotolibro.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BuscarLibroBindingSource, "PORTADA", True))
        Me.pbfotolibro.Location = New System.Drawing.Point(12, 19)
        Me.pbfotolibro.Name = "pbfotolibro"
        Me.pbfotolibro.Size = New System.Drawing.Size(93, 106)
        Me.pbfotolibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbfotolibro.TabIndex = 0
        Me.pbfotolibro.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "ISBN:"
        '
        'txtisbn
        '
        Me.txtisbn.Enabled = False
        Me.txtisbn.Location = New System.Drawing.Point(101, 268)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(100, 20)
        Me.txtisbn.TabIndex = 6
        '
        'btnbuscarlibro
        '
        Me.btnbuscarlibro.Enabled = False
        Me.btnbuscarlibro.Location = New System.Drawing.Point(207, 266)
        Me.btnbuscarlibro.Name = "btnbuscarlibro"
        Me.btnbuscarlibro.Size = New System.Drawing.Size(162, 23)
        Me.btnbuscarlibro.TabIndex = 7
        Me.btnbuscarlibro.Text = "Buscar"
        Me.btnbuscarlibro.UseVisualStyleBackColor = True
        '
        'dtgRentas
        '
        Me.dtgRentas.AllowUserToAddRows = False
        Me.dtgRentas.AllowUserToDeleteRows = False
        Me.dtgRentas.AllowUserToResizeColumns = False
        Me.dtgRentas.AllowUserToResizeRows = False
        Me.dtgRentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgRentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgRentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cisbn, Me.Ctitulo, Me.Cautor, Me.Cedicion, Me.Ceditorial, Me.Caño})
        Me.dtgRentas.Location = New System.Drawing.Point(677, 128)
        Me.dtgRentas.MultiSelect = False
        Me.dtgRentas.Name = "dtgRentas"
        Me.dtgRentas.ReadOnly = True
        Me.dtgRentas.RowHeadersVisible = False
        Me.dtgRentas.Size = New System.Drawing.Size(546, 356)
        Me.dtgRentas.TabIndex = 8
        '
        'Cisbn
        '
        Me.Cisbn.HeaderText = "ISBN"
        Me.Cisbn.Name = "Cisbn"
        Me.Cisbn.ReadOnly = True
        '
        'Ctitulo
        '
        Me.Ctitulo.HeaderText = "Titulo"
        Me.Ctitulo.Name = "Ctitulo"
        Me.Ctitulo.ReadOnly = True
        '
        'Cautor
        '
        Me.Cautor.HeaderText = "Autor"
        Me.Cautor.Name = "Cautor"
        Me.Cautor.ReadOnly = True
        '
        'Cedicion
        '
        Me.Cedicion.HeaderText = "Edicion"
        Me.Cedicion.Name = "Cedicion"
        Me.Cedicion.ReadOnly = True
        '
        'Ceditorial
        '
        Me.Ceditorial.HeaderText = "Editorial"
        Me.Ceditorial.Name = "Ceditorial"
        Me.Ceditorial.ReadOnly = True
        '
        'Caño
        '
        Me.Caño.HeaderText = "Año"
        Me.Caño.Name = "Caño"
        Me.Caño.ReadOnly = True
        '
        'btnagregar
        '
        Me.btnagregar.Enabled = False
        Me.btnagregar.Location = New System.Drawing.Point(550, 461)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(104, 23)
        Me.btnagregar.TabIndex = 9
        Me.btnagregar.Text = "Agregar >>"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnrentar
        '
        Me.btnrentar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnrentar.Enabled = False
        Me.btnrentar.Location = New System.Drawing.Point(683, 502)
        Me.btnrentar.Name = "btnrentar"
        Me.btnrentar.Size = New System.Drawing.Size(174, 23)
        Me.btnrentar.TabIndex = 12
        Me.btnrentar.Text = "Realizar Renta de libros"
        Me.btnrentar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 27.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.Location = New System.Drawing.Point(64, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 51)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "prestamos"
        '
        'BuscarLibroTableAdapter
        '
        Me.BuscarLibroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.TBL_AMONESTACIONESTableAdapter = Nothing
        Me.TableAdapterManager.TBL_CATEGORIASTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DET_LIBROSTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DET_PRESTAMOSTableAdapter = Nothing
        Me.TableAdapterManager.TBL_EDITORIALESTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LECTORESTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LIBROSTableAdapter = Nothing
        Me.TableAdapterManager.TBL_PRESTAMOSTableAdapter = Nothing
        Me.TableAdapterManager.TBL_USUARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BliblioTec.BDDBIBLIOTECADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(1193, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Limpiar Campos"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(119, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "ISBN: "
        '
        'lblisbn
        '
        Me.lblisbn.AutoSize = True
        Me.lblisbn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarLibroBindingSource, "ISBN", True))
        Me.lblisbn.Location = New System.Drawing.Point(161, 121)
        Me.lblisbn.Name = "lblisbn"
        Me.lblisbn.Size = New System.Drawing.Size(0, 13)
        Me.lblisbn.TabIndex = 12
        '
        'btnborrar
        '
        Me.btnborrar.Enabled = False
        Me.btnborrar.Location = New System.Drawing.Point(550, 490)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(104, 23)
        Me.btnborrar.TabIndex = 15
        Me.btnborrar.Text = "<< borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1280, 557)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnrentar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dtgRentas)
        Me.Controls.Add(Me.btnbuscarlibro)
        Me.Controls.Add(Me.txtisbn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnbuscarlector)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnlector)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrestamos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Prestamo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFotolector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BuscarLibroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BddbibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbfotolibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgRentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnlector As System.Windows.Forms.TextBox
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
    Friend WithEvents btnbuscarlector As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbfotolibro As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtisbn As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscarlibro As System.Windows.Forms.Button
    Friend WithEvents dtgRentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents Cisbn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ctitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cautor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ceditorial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnrentar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BddbibliotecaDataSet As BliblioTec.BDDBIBLIOTECADataSet
    Friend WithEvents lbledicion As System.Windows.Forms.Label
    Friend WithEvents lblaño As System.Windows.Forms.Label
    Friend WithEvents lblautor As System.Windows.Forms.Label
    Friend WithEvents lbleditorial As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BuscarLibroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuscarLibroTableAdapter As BliblioTec.BDDBIBLIOTECADataSetTableAdapters.BuscarLibroTableAdapter
    Friend WithEvents TableAdapterManager As BliblioTec.BDDBIBLIOTECADataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblisbn As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnborrar As System.Windows.Forms.Button
End Class
