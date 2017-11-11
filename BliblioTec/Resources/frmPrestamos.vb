Public Class frmPrestamos

    Private Sub limpiarCampos()
        Me.txtnlector.Text = ""
        Me.txtisbn.Text = ""
        Me.txtisbn.Enabled = False
        idbusqueda = 0
        Me.lblnombre.Text = ""
        Me.lbldireccion.Text = ""
        Me.lbltel.Text = ""
        Me.lblemail.Text = ""
        Me.pbFotolector.Image = Nothing
        Me.pbfotolibro.Image = Nothing
        Me.lbltitulo.Text = ""
        Me.lblautor.Text = ""
        Me.lbledicion.Text = ""
        Me.lbleditorial.Text = ""
        Me.lblaño.Text = ""
        lblisbn.Text = ""
        btnbuscarlibro.Enabled = False
        btnagregar.Enabled = False
        btnrentar.Enabled = False
        dtgRentas.Rows.Clear()
        btnborrar.Enabled = False
    End Sub
    Private Sub btnagregar_Click(sender As System.Object, e As System.EventArgs) Handles btnagregar.Click
        Dim max As Integer = dtgRentas.RowCount
        For x As Integer = 0 To max - 1 Step 1
            If CInt(lblisbn.Text) = CInt(dtgRentas.Rows(x).Cells(0).Value) Then
                MsgBox("El libro ya esta en la lista de pedidos", MsgBoxStyle.Critical)
                Me.txtisbn.Text = ""
                Me.pbfotolibro.Image = Nothing
                Me.lbltitulo.Text = ""
                Me.lblautor.Text = ""
                Me.lbledicion.Text = ""
                Me.lbleditorial.Text = ""
                Me.lblaño.Text = ""
                lblisbn.Text = ""
                btnagregar.Enabled = False
                Exit Sub
            End If
        Next
        Dim ven As New selecfechadev
        If ven.ShowDialog = Windows.Forms.DialogResult.OK Then
            dtgRentas.Rows.Add(txtisbn.Text, lbltitulo.Text, lblautor.Text, lbledicion.Text, lbleditorial.Text, lblaño.Text, fechaf)
            btnrentar.Enabled = True
            Me.txtisbn.Text = ""
            Me.pbfotolibro.Image = Nothing
            Me.lbltitulo.Text = ""
            Me.lblautor.Text = ""
            Me.lbledicion.Text = ""
            Me.lbleditorial.Text = ""
            Me.lblaño.Text = ""
            lblisbn.Text = ""
            btnagregar.Enabled = False
            btnborrar.Enabled = True
        End If
    End Sub

    Private Sub frmPrestamos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Me.BuscarLibroTableAdapter.Connection = conexion
    End Sub

    Private Sub btnbuscarlector_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlector.Click
        If txtnlector.Text = "" Then
            limpiarCampos()
            txtnlector.Focus()
            Exit Sub
        End If
        strSQL = "SELECT * FROM TBL_LECTORES WHERE EXISTE = 1 AND ID_NUMLECTOR = " & Me.txtnlector.Text
        If BLector("TBL_LECTORES") = True Then
            idbusqueda = dts.Tables("TBL_LECTORES").Rows(0).Item(0)
            Me.lblnombre.Text = dts.Tables("TBL_LECTORES").Rows(0).Item(2) & " " & dts.Tables("TBL_LECTORES").Rows(0).Item(3) & " " & dts.Tables("TBL_LECTORES").Rows(0).Item(4)
            Me.lbldireccion.Text = dts.Tables("TBL_LECTORES").Rows(0).Item(5)
            Me.lbltel.Text = dts.Tables("TBL_LECTORES").Rows(0).Item(6)
            Me.lblemail.Text = dts.Tables("TBL_LECTORES").Rows(0).Item(7)
            'Dim imageBuffer As Byte
            'imageBuffer = CByte(dts.Tables("TBL_LECTORES").Rows(0).Item(1))
            'Dim ms As New System.IO.MemoryStream(imageBuffer)
            'Me.pbFotolector.Image = Image.FromStream(MS)
            Me.txtisbn.Enabled = True
            Me.btnbuscarlibro.Enabled = True
            txtisbn.Focus()
        Else
            MsgBox("El numero de lector no esta registrado en el sistema", MsgBoxStyle.Critical, "Lector no Existe")
            limpiarCampos()
            txtnlector.Focus()
        End If
    End Sub

    Private Sub btnbuscarlibro_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlibro.Click
        Try
            Me.BuscarLibroTableAdapter.Fill(Me.BddbibliotecaDataSet.BuscarLibro, txtisbn.Text)
            If lblisbn.Text = "" Then
                MsgBox("El Libro No esta disponible", MsgBoxStyle.Critical)
                btnagregar.Enabled = False
                txtisbn.Focus()
            Else
                btnagregar.Enabled = True
            End If

        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub btnrentar_Click(sender As System.Object, e As System.EventArgs) Handles btnrentar.Click
        strSQL = "proAltaPrestamo"
        comando = New SqlClient.SqlCommand(strSQL, conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@NUMLECTOR", SqlDbType.BigInt).Value = idbusqueda
        comando.Parameters.Add("@IDUSUARIO", SqlDbType.BigInt).Value = usuid
        comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
        If conectar() = True Then
            Dim folio As Integer = comando.Parameters("@retorno").Value
            strSQL = "proAltaDetPrestamo"
            Dim max As Integer = dtgRentas.RowCount
            For x As Integer = 0 To max - 1 Step 1
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@IDPRESTAMO", SqlDbType.BigInt).Value = folio
                comando.Parameters.Add("@FECHAPRESTAMO", SqlDbType.DateTime).Value = Format(Date.Now().Date, " yyyy-MM-dd")
                comando.Parameters.Add("@FECHADEV", SqlDbType.DateTime).Value = dtgRentas(6, x).Value
                comando.Parameters.Add("@ISBN", SqlDbType.BigInt).Value = dtgRentas(0, x).Value
                conectar()
            Next
            MsgBox("Prestamos Registrados en el sistema", MsgBoxStyle.Information, "Listo")
            limpiarCampos()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        limpiarCampos()
    End Sub

    Private Sub btnborrar_Click(sender As System.Object, e As System.EventArgs) Handles btnborrar.Click
        dtgRentas.Rows.RemoveAt(dtgRentas.CurrentRow.Index)
        If dtgRentas.RowCount = 0 Then
            btnrentar.Enabled = False
            btnborrar.Enabled = False
        End If

    End Sub

    Private Sub txtnlector_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnlector.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtisbn_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtisbn.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class