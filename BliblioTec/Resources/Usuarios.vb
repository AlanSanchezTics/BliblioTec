Public Class Usuarios

    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub DtgUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgUsuarios.CellContentClick

    End Sub

    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_USUARIOS' Puede moverla o quitarla según sea necesario.
    End Sub

    Private Sub GpoDatos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpoDatos.Enter

    End Sub

    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click

    End Sub

    Private Sub CmdNuevo_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevo.Click
        GpoDatos.Enabled = True
        CmdGuardar.Enabled = True
    End Sub
End Class