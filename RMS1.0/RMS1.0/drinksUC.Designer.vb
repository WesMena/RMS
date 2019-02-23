<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class drinksUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(drinksUC))
        Me.Itemtemplate3 = New RMS1._0.itemtemplate()
        Me.drinkslbl = New System.Windows.Forms.Label()
        Me.Itemtemplate2 = New RMS1._0.itemtemplate()
        Me.drinkspb = New System.Windows.Forms.PictureBox()
        CType(Me.drinkspb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Itemtemplate3
        '
        Me.Itemtemplate3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate3.Location = New System.Drawing.Point(171, 320)
        Me.Itemtemplate3.Name = "Itemtemplate3"
        Me.Itemtemplate3.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate3.TabIndex = 27
        '
        'drinkslbl
        '
        Me.drinkslbl.AutoSize = True
        Me.drinkslbl.BackColor = System.Drawing.Color.Transparent
        Me.drinkslbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drinkslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.drinkslbl.Location = New System.Drawing.Point(317, 11)
        Me.drinkslbl.Name = "drinkslbl"
        Me.drinkslbl.Size = New System.Drawing.Size(128, 36)
        Me.drinkslbl.TabIndex = 24
        Me.drinkslbl.Text = "BEBIDAS"
        '
        'Itemtemplate2
        '
        Me.Itemtemplate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Itemtemplate2.Location = New System.Drawing.Point(171, 190)
        Me.Itemtemplate2.Name = "Itemtemplate2"
        Me.Itemtemplate2.Size = New System.Drawing.Size(418, 104)
        Me.Itemtemplate2.TabIndex = 26
        '
        'drinkspb
        '
        Me.drinkspb.Image = CType(resources.GetObject("drinkspb.Image"), System.Drawing.Image)
        Me.drinkspb.Location = New System.Drawing.Point(0, 50)
        Me.drinkspb.Name = "drinkspb"
        Me.drinkspb.Size = New System.Drawing.Size(774, 99)
        Me.drinkspb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.drinkspb.TabIndex = 25
        Me.drinkspb.TabStop = False
        '
        'drinksUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Itemtemplate3)
        Me.Controls.Add(Me.drinkslbl)
        Me.Controls.Add(Me.Itemtemplate2)
        Me.Controls.Add(Me.drinkspb)
        Me.Name = "drinksUC"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.drinkspb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Itemtemplate3 As itemtemplate
    Friend WithEvents drinkslbl As Label
    Friend WithEvents Itemtemplate2 As itemtemplate
    Friend WithEvents drinkspb As PictureBox
End Class
