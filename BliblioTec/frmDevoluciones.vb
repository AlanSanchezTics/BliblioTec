Public Class frmDevoluciones

    Private Sub frmDevoluciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'BDDBIBLIOTECADataSet.viewDev' table. You can move, or remove it, as needed.
        Me.ViewDevTableAdapter.Connection = conexion
        Me.ViewDevTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.viewDev)

    End Sub

    Private Sub btnbuscarlector_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscarlector.Click

    End Sub
End Class