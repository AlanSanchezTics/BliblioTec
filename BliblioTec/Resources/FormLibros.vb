Public Class FormLibros

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            FormRegistroLibros.ShowDialog()
    End Sub

    Private Sub FormLibros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized

    End Sub
End Class
