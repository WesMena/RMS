<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminClient
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
        Me.AdminUserControl1 = New RMS1._0.AdminUserControl()
        Me.SuspendLayout()
        '
        'AdminUserControl1
        '
        Me.AdminUserControl1.Location = New System.Drawing.Point(1, -1)
        Me.AdminUserControl1.Name = "AdminUserControl1"
        Me.AdminUserControl1.Size = New System.Drawing.Size(920, 482)
        Me.AdminUserControl1.TabIndex = 0
        '
        'AdminClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 479)
        Me.Controls.Add(Me.AdminUserControl1)
        Me.Name = "AdminClient"
        Me.Text = "AdminClient"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminUserControl1 As AdminUserControl
End Class
