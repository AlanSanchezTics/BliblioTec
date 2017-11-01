Module bDatos
    Public conexion As SqlClient.SqlConnection
    Public comando As SqlClient.SqlCommand
    Public strSQL As String
    Public dts As New DataSet
    Public idbusqueda As Long
    Public usuNombre As String

    Public Sub inicio()
        conexion = New SqlClient.SqlConnection("server=ALANSANCHEZ\SQLEXPRESS; database=BDDBIBLIOTECA; uid=SA; pwd=12345;")
    End Sub

    Public Function conectar() As Boolean
        Dim ret As Boolean
        Try
            comando.Connection.Open()
            comando.ExecuteNonQuery()
            ret = True
        Catch ex As Exception
            ret = False
            MsgBox("Se ha producido el SIGUIENTE ERROR: " & ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical)
        End Try
        comando.Connection.Close()
        Return ret
    End Function
End Module
