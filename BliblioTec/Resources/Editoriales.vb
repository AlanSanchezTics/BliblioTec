Public Class Editoriales

    Private Sub Editoriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CmdNuevo_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevo.Click
        Me.GpoDatos.Enabled = True
        Me.CmdGuardar.Enabled = True
    End Sub
End Class