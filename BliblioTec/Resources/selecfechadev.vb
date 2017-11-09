Public Class selecfechadev

    Private Sub btnListo_Click(sender As System.Object, e As System.EventArgs) Handles btnListo.Click
        fechaf = mCalendario.SelectionRange.Start.Date
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class