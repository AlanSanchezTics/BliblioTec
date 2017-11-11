Public Class frmDevoluciones
    Private Sub limpiar()
        lblnombre.Text = ""
        lbltel.Text = ""
        lbldireccion.Text = ""
        lblemail.Text = ""
        btndevolucion.Enabled = False
        dtgprestamos.Rows.Clear()
        btnmod.Enabled = False
        pbFotolector.Image = Nothing
    End Sub
    Private Sub frmDevoluciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'BDDBIBLIOTECADataSet.viewDev' table. You can move, or remove it, as needed.
        Me.ViewDevTableAdapter.Connection = conexion
        Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, 0)

    End Sub

    Private Sub btnbuscarlector_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlector.Click
        If txtnlector.Text = "" Then
            txtnlector.Focus()
            limpiar()
            Exit Sub
        End If
        strSQL = "SELECT * FROM TBL_LECTORES WHERE ID_NUMLECTOR = " & Me.txtnlector.Text
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
            Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, idbusqueda)
            If dtgprestamos.RowCount > 0 Then
                Me.btndevolucion.Enabled = True
                Me.btnmod.Enabled = True
            Else
                MsgBox("No tiene prestamos pendientes", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("El numero de lector no esta registrado en el sistema", MsgBoxStyle.Critical, "Lector no Existe")
            txtnlector.Focus()
            limpiar()
        End If
    End Sub

    Private Sub txtnlector_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnlector.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btndevolucion_Click(sender As System.Object, e As System.EventArgs) Handles btndevolucion.Click
        strSQL = "proDevoluciones"
        comando = New SqlClient.SqlCommand(strSQL, conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@ISBN", SqlDbType.BigInt).Value = Me.dtgprestamos.CurrentRow.Cells("ISBN").Value
        comando.Parameters.Add("@IDDETPRESTAMOS", SqlDbType.BigInt).Value = Me.dtgprestamos.CurrentRow.Cells("IDDETPRESTAMO").Value
        If conectar() = True Then
            MsgBox("Libro Recibido", MsgBoxStyle.Information, "Accion Realizada")
            Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, idbusqueda)
        End If
    End Sub

    Private Sub btnmod_Click(sender As System.Object, e As System.EventArgs) Handles btnmod.Click
        Dim ven As New selecfechadev
        If ven.ShowDialog = Windows.Forms.DialogResult.OK Then
            strSQL = "proModFecha"
            comando = New SqlClient.SqlCommand(strSQL, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@IDDETPRESTAMOS", SqlDbType.BigInt).Value = Me.dtgprestamos.CurrentRow.Cells("IDDETPRESTAMO").Value
            comando.Parameters.Add("@fechadev", SqlDbType.DateTime).Value = fechaf
            If conectar() = True Then
                MsgBox("La fecha de entrega del libro ha sido modificada", MsgBoxStyle.Information, "Accion Realizada")
                Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, idbusqueda)
            End If
        End If
    End Sub
End Class