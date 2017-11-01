Public Class frmPrestamos


    Private Sub btnagregar_Click(sender As System.Object, e As System.EventArgs) Handles btnagregar.Click
        dtgRentas.Rows.Add(txtisbn.Text, lbltitulo.Text, lblautor.Text, lbledicion.Text, lbleditorial.Text, lblaño.Text)
    End Sub

    Private Sub frmPrestamos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
    End Sub
End Class