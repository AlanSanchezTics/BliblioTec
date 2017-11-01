Public Class frmMenu
    Private Sub cerrarChildrens()
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub
    Private Sub PrestamosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrestamosToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New frmPrestamos
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub tsmPrestamos_Click(sender As System.Object, e As System.EventArgs) Handles tsmPrestamos.Click
        cerrarChildrens()
        Dim ven As New frmPrestamos
        ven.MdiParent = Me
        ven.Show()

    End Sub

    Private Sub frmMenu_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub


    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        cerrarChildrens()
        Dim ven As New frmDevoluciones
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DevolucionesToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New frmDevoluciones
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        cerrarChildrens()
        Dim ven As New Editoriales
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub EditorialesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditorialesToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New Editoriales
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CategoriasToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New Categorias
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        cerrarChildrens()
        Dim ven As New Categorias
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        cerrarChildrens()
        Dim ven As New FormLectores
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call inicio()
        lblNombre.Text = usuNombre
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        cerrarChildrens()
        Dim ven As New FormLibros
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        cerrarChildrens()
        Dim ven As New FormAmonestaciones
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub AmonestacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AmonestacionesToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New FormAmonestaciones
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LibrosToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New FormLibros
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub LectoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LectoresToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New FormLectores
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New Usuarios
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbldatetime.Text = Format(Date.Now().Date, "| yyyy-MM-dd |") & Format(Date.Now(), " hh:mm:ss |")
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        cerrarChildrens()
        Dim ven As New Usuarios
        ven.MdiParent = Me
        ven.Show()
    End Sub
End Class