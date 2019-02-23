<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homescreen3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homescreen3))
        Me.orderlbl = New System.Windows.Forms.Button()
        Me.itemdescriptionlbl = New System.Windows.Forms.Label()
        Me.itemnamelbl = New System.Windows.Forms.Label()
        Me.justlbl = New System.Windows.Forms.Label()
        Me.pricelbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orderlbl
        '
        Me.orderlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.orderlbl.FlatAppearance.BorderSize = 0
        Me.orderlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderlbl.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderlbl.ForeColor = System.Drawing.Color.White
        Me.orderlbl.Location = New System.Drawing.Point(81, 378)
        Me.orderlbl.Name = "orderlbl"
        Me.orderlbl.Size = New System.Drawing.Size(279, 28)
        Me.orderlbl.TabIndex = 17
        Me.orderlbl.Text = "Ordenar"
        Me.orderlbl.UseVisualStyleBackColor = False
        '
        'itemdescriptionlbl
        '
        Me.itemdescriptionlbl.AutoSize = True
        Me.itemdescriptionlbl.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemdescriptionlbl.ForeColor = System.Drawing.Color.Black
        Me.itemdescriptionlbl.Location = New System.Drawing.Point(77, 293)
        Me.itemdescriptionlbl.Name = "itemdescriptionlbl"
        Me.itemdescriptionlbl.Size = New System.Drawing.Size(316, 40)
        Me.itemdescriptionlbl.TabIndex = 16
        Me.itemdescriptionlbl.Text = "Café 100% puro hecho con granos traídos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de la región de Tarrazú."
        '
        'itemnamelbl
        '
        Me.itemnamelbl.AutoSize = True
        Me.itemnamelbl.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemnamelbl.ForeColor = System.Drawing.Color.Black
        Me.itemnamelbl.Location = New System.Drawing.Point(91, 231)
        Me.itemnamelbl.Name = "itemnamelbl"
        Me.itemnamelbl.Size = New System.Drawing.Size(100, 41)
        Me.itemnamelbl.TabIndex = 15
        Me.itemnamelbl.Text = "Café"
        '
        'justlbl
        '
        Me.justlbl.AutoSize = True
        Me.justlbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.justlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.justlbl.Location = New System.Drawing.Point(120, 36)
        Me.justlbl.Name = "justlbl"
        Me.justlbl.Size = New System.Drawing.Size(226, 36)
        Me.justlbl.TabIndex = 14
        Me.justlbl.Text = "SOLO POR HOY"
        '
        'pricelbl
        '
        Me.pricelbl.AutoSize = True
        Me.pricelbl.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pricelbl.Location = New System.Drawing.Point(78, 108)
        Me.pricelbl.Name = "pricelbl"
        Me.pricelbl.Size = New System.Drawing.Size(315, 123)
        Me.pricelbl.TabIndex = 13
        Me.pricelbl.Text = "-50%"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(416, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'homescreen3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.orderlbl)
        Me.Controls.Add(Me.itemdescriptionlbl)
        Me.Controls.Add(Me.itemnamelbl)
        Me.Controls.Add(Me.justlbl)
        Me.Controls.Add(Me.pricelbl)
        Me.Name = "homescreen3"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents orderlbl As Button
    Friend WithEvents itemdescriptionlbl As Label
    Friend WithEvents itemnamelbl As Label
    Friend WithEvents justlbl As Label
    Friend WithEvents pricelbl As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
