<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homescreen2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homescreen2))
        Me.orderlbl = New System.Windows.Forms.Button()
        Me.itemdescriptionlbl = New System.Windows.Forms.Label()
        Me.itemnamelbl = New System.Windows.Forms.Label()
        Me.justlbl = New System.Windows.Forms.Label()
        Me.pricelbl = New System.Windows.Forms.Label()
        Me.itempicpb = New System.Windows.Forms.PictureBox()
        CType(Me.itempicpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orderlbl
        '
        Me.orderlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.orderlbl.FlatAppearance.BorderSize = 0
        Me.orderlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderlbl.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderlbl.ForeColor = System.Drawing.Color.White
        Me.orderlbl.Location = New System.Drawing.Point(117, 337)
        Me.orderlbl.Name = "orderlbl"
        Me.orderlbl.Size = New System.Drawing.Size(279, 28)
        Me.orderlbl.TabIndex = 11
        Me.orderlbl.Text = "Ordenar"
        Me.orderlbl.UseVisualStyleBackColor = False
        '
        'itemdescriptionlbl
        '
        Me.itemdescriptionlbl.AutoSize = True
        Me.itemdescriptionlbl.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemdescriptionlbl.ForeColor = System.Drawing.Color.Black
        Me.itemdescriptionlbl.Location = New System.Drawing.Point(138, 274)
        Me.itemdescriptionlbl.Name = "itemdescriptionlbl"
        Me.itemdescriptionlbl.Size = New System.Drawing.Size(240, 40)
        Me.itemdescriptionlbl.TabIndex = 10
        Me.itemdescriptionlbl.Text = "Ojo de bife asado con hongos, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "romero y soya." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'itemnamelbl
        '
        Me.itemnamelbl.AutoSize = True
        Me.itemnamelbl.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemnamelbl.ForeColor = System.Drawing.Color.Black
        Me.itemnamelbl.Location = New System.Drawing.Point(133, 225)
        Me.itemnamelbl.Name = "itemnamelbl"
        Me.itemnamelbl.Size = New System.Drawing.Size(202, 41)
        Me.itemnamelbl.TabIndex = 9
        Me.itemnamelbl.Text = "Roast Beef "
        '
        'justlbl
        '
        Me.justlbl.AutoSize = True
        Me.justlbl.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.justlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.justlbl.Location = New System.Drawing.Point(256, 33)
        Me.justlbl.Name = "justlbl"
        Me.justlbl.Size = New System.Drawing.Size(214, 36)
        Me.justlbl.TabIndex = 8
        Me.justlbl.Text = "PLATO DEL DÍA"
        '
        'pricelbl
        '
        Me.pricelbl.AutoSize = True
        Me.pricelbl.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.pricelbl.Location = New System.Drawing.Point(63, 78)
        Me.pricelbl.Name = "pricelbl"
        Me.pricelbl.Size = New System.Drawing.Size(407, 123)
        Me.pricelbl.TabIndex = 7
        Me.pricelbl.Text = "₡5500"
        '
        'itempicpb
        '
        Me.itempicpb.Image = CType(resources.GetObject("itempicpb.Image"), System.Drawing.Image)
        Me.itempicpb.Location = New System.Drawing.Point(436, 215)
        Me.itempicpb.Name = "itempicpb"
        Me.itempicpb.Size = New System.Drawing.Size(383, 298)
        Me.itempicpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.itempicpb.TabIndex = 12
        Me.itempicpb.TabStop = False
        '
        'homescreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.orderlbl)
        Me.Controls.Add(Me.itemdescriptionlbl)
        Me.Controls.Add(Me.itemnamelbl)
        Me.Controls.Add(Me.justlbl)
        Me.Controls.Add(Me.pricelbl)
        Me.Controls.Add(Me.itempicpb)
        Me.Name = "homescreen2"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.itempicpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents orderlbl As Button
    Friend WithEvents itemdescriptionlbl As Label
    Friend WithEvents itemnamelbl As Label
    Friend WithEvents justlbl As Label
    Friend WithEvents pricelbl As Label
    Friend WithEvents itempicpb As PictureBox
End Class
