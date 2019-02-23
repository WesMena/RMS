<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dessertsUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dessertsUC))
        Me.Itemtemplate3 = New RMS1._0.itemtemplate()
        Me.dessertslbl = New System.Windows.Forms.Label()
        Me.Itemtemplate2 = New RMS1._0.itemtemplate()
        Me.dessertspb = New System.Windows.Forms.PictureBox()
        CType(Me.dessertspb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Itemtemplate3
        '
        Me.Itemtemplate3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate3.Location = New System.Drawing.Point(171, 320)
        Me.Itemtemplate3.Name = "Itemtemplate3"
        Me.Itemtemplate3.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate3.TabIndex = 31
        '
        'dessertslbl
        '
        Me.dessertslbl.AutoSize = True
        Me.dessertslbl.BackColor = System.Drawing.Color.Transparent
        Me.dessertslbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessertslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.dessertslbl.Location = New System.Drawing.Point(317, 11)
        Me.dessertslbl.Name = "dessertslbl"
        Me.dessertslbl.Size = New System.Drawing.Size(129, 36)
        Me.dessertslbl.TabIndex = 28
        Me.dessertslbl.Text = "POSTRES"
        '
        'Itemtemplate2
        '
        Me.Itemtemplate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate2.Location = New System.Drawing.Point(171, 190)
        Me.Itemtemplate2.Name = "Itemtemplate2"
        Me.Itemtemplate2.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate2.TabIndex = 30
        '
        'dessertspb
        '
        Me.dessertspb.Image = CType(resources.GetObject("dessertspb.Image"), System.Drawing.Image)
        Me.dessertspb.Location = New System.Drawing.Point(0, 50)
        Me.dessertspb.Name = "dessertspb"
        Me.dessertspb.Size = New System.Drawing.Size(774, 99)
        Me.dessertspb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.dessertspb.TabIndex = 29
        Me.dessertspb.TabStop = False
        '
        'dessertsUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Itemtemplate3)
        Me.Controls.Add(Me.dessertslbl)
        Me.Controls.Add(Me.Itemtemplate2)
        Me.Controls.Add(Me.dessertspb)
        Me.Name = "dessertsUC"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.dessertspb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Itemtemplate3 As itemtemplate
    Friend WithEvents dessertslbl As Label
    Friend WithEvents Itemtemplate2 As itemtemplate
    Friend WithEvents dessertspb As PictureBox
End Class
