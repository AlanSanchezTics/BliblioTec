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
        btnbuscarlibro.Enabled = False
        btnagregar.Enabled = False
        btnrentar.Enabled = False
        dtgRentas.Rows.Clear()
    End Sub
    Private Sub btnagregar_Click(sender As System.Object, e As System.EventArgs) Handles btnagregar.Click
        dtgRentas.Rows.Add(txtisbn.Text, lbltitulo.Text, lblautor.Text, lbledicion.Text, lbleditorial.Text, lblaño.Text)
    End Sub

    Private Sub frmPrestamos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Me.BuscarLibroTableAdapter.Connection = conexion
    End Sub

    Private Sub btnbuscarlector_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlector.Click
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
        Else
            MsgBox("El numero de lector no esta registrado en el sistema", MsgBoxStyle.Critical, "Lector no Existe")
        End If
    End Sub

    Private Sub btnbuscarlibro_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlibro.Click
        Try
            Me.BuscarLibroTableAdapter.Fill(Me.BddbibliotecaDataSet.BuscarLibro, txtisbn.Text)
        Catch ex As System.Exception
            MsgBox("El Libro No esta disponible", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class