<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selecfechadev
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mCalendario = New System.Windows.Forms.MonthCalendar()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la nueva fecha de entrega"
        '
        'mCalendario
        '
        Me.mCalendario.Location = New System.Drawing.Point(72, 50)
        Me.mCalendario.MaxSelectionCount = 1
        Me.mCalendario.Name = "mCalendario"
        Me.mCalendario.TabIndex = 1
        '
        'btnListo
        '
        Me.btnListo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.Location = New System.Drawing.Point(162, 224)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(75, 23)
        Me.btnListo.TabIndex = 2
        Me.btnListo.Text = "Listo"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'selecfechadev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(404, 265)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.mCalendario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "selecfechadev"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mCalendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnListo As System.Windows.Forms.Button
End Class
