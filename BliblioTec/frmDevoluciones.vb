﻿Public Class frmDevoluciones

    Private Sub frmDevoluciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'BDDBIBLIOTECADataSet.viewDev' table. You can move, or remove it, as needed.
        Me.ViewDevTableAdapter.Connection = conexion
        Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, 0)

    End Sub

    Private Sub btnbuscarlector_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlector.Click
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
            Me.btndevolucion.Enabled = True
            Me.btnmod.Enabled = True
            Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, idbusqueda)
        Else
            MsgBox("El numero de lector no esta registrado en el sistema", MsgBoxStyle.Critical, "Lector no Existe")
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
            MsgBox("Libro Recibido", MsgBoxStyle.MsgBoxRight, "Accion Realizada")
            Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, idbusqueda)
        End If
    End Sub

    Private Sub btnmod_Click(sender As System.Object, e As System.EventArgs) Handles btnmod.Click
        Dim ven As New selecfechadev
        If ven.ShowDialog = Windows.Forms.DialogResult.OK Then
            MsgBox(fechaf)
            strSQL = "proModFecha"
            comando = New SqlClient.SqlCommand(strSQL, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@IDDETPRESTAMOS", SqlDbType.BigInt).Value = Me.dtgprestamos.CurrentRow.Cells("IDDETPRESTAMO").Value
            'comando.Parameters.Add("@fechadev",SqlDbType.DateTime).Value =
            If conectar() = True Then
                MsgBox("La fecha de entrega del libro ha sido modificada", MsgBoxStyle.MsgBoxRight, "Accion Realizada")
                Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev, idbusqueda)
            End If
        End If
    End Sub
End Class