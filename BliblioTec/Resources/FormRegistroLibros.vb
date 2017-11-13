Public Class FormRegistroLibros

    Private Sub FormRegistroLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDDBIBLIOTECADataSet.TBL_LIBROS' table. You can move, or remove it, as needed.
        Call inicio()
        Me.TBL_LIBROSTableAdapter.Connection = conexion
        Me.TBL_LIBROSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LIBROS)
        Dim msg As MsgBoxResult
        TextTitulo.Visible = True
        Textautor.Visible = True
        Label4.Visible = True
        Comtitulo.Visible = False
        msg = MsgBox("El Titulo y Autor ya existen", MsgBoxStyle.YesNo, "Registro")
        If msg = MsgBoxResult.Yes Then
            TextTitulo.Visible = False
            Textautor.Visible = False
            Label4.Visible = False
            Comtitulo.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgimagen.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        Dim ms As New System.IO.MemoryStream
        PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        'aqui va el parametro con la igualacion ms.GetBuffer();  comando.parameters.add("@fotolibro",image).value=ms.GetBuffer();
    End Sub
End Class