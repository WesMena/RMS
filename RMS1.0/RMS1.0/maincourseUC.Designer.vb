<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maincourseUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maincourseUC))
        Me.Itemtemplate3 = New RMS1._0.itemtemplate()
        Me.maincourselbl = New System.Windows.Forms.Label()
        Me.Itemtemplate2 = New RMS1._0.itemtemplate()
        Me.maincoursepb = New System.Windows.Forms.PictureBox()
        CType(Me.maincoursepb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Itemtemplate3
        '
        Me.Itemtemplate3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate3.Location = New System.Drawing.Point(171, 322)
        Me.Itemtemplate3.Name = "Itemtemplate3"
        Me.Itemtemplate3.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate3.TabIndex = 23
        '
        'maincourselbl
        '
        Me.maincourselbl.AutoSize = True
        Me.maincourselbl.BackColor = System.Drawing.Color.Transparent
        Me.maincourselbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maincourselbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.maincourselbl.Location = New System.Drawing.Point(279, 13)
        Me.maincourselbl.Name = "maincourselbl"
        Me.maincourselbl.Size = New System.Drawing.Size(231, 36)
        Me.maincourselbl.TabIndex = 20
        Me.maincourselbl.Text = "PLATOS FUERTES"
        '
        'Itemtemplate2
        '
        Me.Itemtemplate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate2.Location = New System.Drawing.Point(171, 192)
        Me.Itemtemplate2.Name = "Itemtemplate2"
        Me.Itemtemplate2.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate2.TabIndex = 22
        '
        'maincoursepb
        '
        Me.maincoursepb.Image = CType(resources.GetObject("maincoursepb.Image"), System.Drawing.Image)
        Me.maincoursepb.Location = New System.Drawing.Point(0, 52)
        Me.maincoursepb.Name = "maincoursepb"
        Me.maincoursepb.Size = New System.Drawing.Size(774, 99)
        Me.maincoursepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.maincoursepb.TabIndex = 21
        Me.maincoursepb.TabStop = False
        '
        'maincourseUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Itemtemplate3)
        Me.Controls.Add(Me.maincourselbl)
        Me.Controls.Add(Me.Itemtemplate2)
        Me.Controls.Add(Me.maincoursepb)
        Me.Name = "maincourseUC"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.maincoursepb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Itemtemplate3 As itemtemplate
    Friend WithEvents maincourselbl As Label
    Friend WithEvents Itemtemplate2 As itemtemplate
    Friend WithEvents maincoursepb As PictureBox
End Class
