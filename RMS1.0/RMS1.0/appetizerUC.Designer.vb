<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appetizerUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appetizerUC))
        Me.appetizerlbl = New System.Windows.Forms.Label()
        Me.appetizerpb = New System.Windows.Forms.PictureBox()
        Me.Itemtemplate2 = New RMS1._0.itemtemplate()
        Me.Itemtemplate3 = New RMS1._0.itemtemplate()
        CType(Me.appetizerpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'appetizerlbl
        '
        Me.appetizerlbl.AutoSize = True
        Me.appetizerlbl.BackColor = System.Drawing.Color.Transparent
        Me.appetizerlbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appetizerlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.appetizerlbl.Location = New System.Drawing.Point(305, 12)
        Me.appetizerlbl.Name = "appetizerlbl"
        Me.appetizerlbl.Size = New System.Drawing.Size(165, 36)
        Me.appetizerlbl.TabIndex = 15
        Me.appetizerlbl.Text = "ENTRADAS "
        '
        'appetizerpb
        '
        Me.appetizerpb.Image = CType(resources.GetObject("appetizerpb.Image"), System.Drawing.Image)
        Me.appetizerpb.Location = New System.Drawing.Point(0, 51)
        Me.appetizerpb.Name = "appetizerpb"
        Me.appetizerpb.Size = New System.Drawing.Size(774, 99)
        Me.appetizerpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.appetizerpb.TabIndex = 16
        Me.appetizerpb.TabStop = False
        '
        'Itemtemplate2
        '
        Me.Itemtemplate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate2.Location = New System.Drawing.Point(171, 191)
        Me.Itemtemplate2.Name = "Itemtemplate2"
        Me.Itemtemplate2.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate2.TabIndex = 18
        '
        'Itemtemplate3
        '
        Me.Itemtemplate3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate3.Location = New System.Drawing.Point(171, 321)
        Me.Itemtemplate3.Name = "Itemtemplate3"
        Me.Itemtemplate3.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate3.TabIndex = 19
        '
        'appetizerUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Itemtemplate3)
        Me.Controls.Add(Me.appetizerlbl)
        Me.Controls.Add(Me.Itemtemplate2)
        Me.Controls.Add(Me.appetizerpb)
        Me.Name = "appetizerUC"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.appetizerpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents appetizerlbl As Label
    Friend WithEvents appetizerpb As PictureBox
    Friend WithEvents Itemtemplate2 As itemtemplate
    Friend WithEvents Itemtemplate3 As itemtemplate
End Class
