Public Class Form1
    Private Sub btnentrar_Click(sender As System.Object, e As System.EventArgs) Handles btnentrar.Click
        strSQL = "proLogin"
        comando = New SqlClient.SqlCommand(strSQL, conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@usuLogin", SqlDbType.VarChar, 20).Value = Me.txtusuario.Text
        comando.Parameters.Add("@usuClave", SqlDbType.VarChar, 20).Value = Me.txtclave.Text
        comando.Parameters.Add("@usuNombre", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
        comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
        comando.Parameters.Add("@usuID", SqlDbType.BigInt).Direction = ParameterDirection.Output
        If conectar() = True Then
            If comando.Parameters("@retorno").Value = 1 Then
                usuNombre = comando.Parameters("@usuNombre").Value
                usuid = comando.Parameters("@usuID").Value
                Dim ven As New frmMenu
                ven.Show()
                Me.Hide()
            Else
                MsgBox("Datos de usuario incorrectos. Intente de nuevo", MsgBoxStyle.Critical, "Error de acceso")
                txtusuario.Focus()
            End If
        End If
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call inicio()
    End Sub
End Class
