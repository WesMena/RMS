<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homescreen1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homescreen1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.justlbl = New System.Windows.Forms.Label()
        Me.orderlbl = New System.Windows.Forms.Button()
        Me.itemdescriptionlbl = New System.Windows.Forms.Label()
        Me.itemnamelbl = New System.Windows.Forms.Label()
        Me.pricelbl = New System.Windows.Forms.Label()
        Me.itempicpb = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.itempicpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.justlbl)
        Me.Panel1.Controls.Add(Me.orderlbl)
        Me.Panel1.Controls.Add(Me.itemdescriptionlbl)
        Me.Panel1.Controls.Add(Me.itemnamelbl)
        Me.Panel1.Controls.Add(Me.pricelbl)
        Me.Panel1.Controls.Add(Me.itempicpb)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 453)
        Me.Panel1.TabIndex = 0
        '
        'justlbl
        '
        Me.justlbl.AutoSize = True
        Me.justlbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.justlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.justlbl.Location = New System.Drawing.Point(120, 15)
        Me.justlbl.Name = "justlbl"
        Me.justlbl.Size = New System.Drawing.Size(100, 28)
        Me.justlbl.TabIndex = 1
        Me.justlbl.Text = "A SOLO"
        '
        'orderlbl
        '
        Me.orderlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.orderlbl.FlatAppearance.BorderSize = 0
        Me.orderlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderlbl.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderlbl.ForeColor = System.Drawing.Color.White
        Me.orderlbl.Location = New System.Drawing.Point(66, 317)
        Me.orderlbl.Name = "orderlbl"
        Me.orderlbl.Size = New System.Drawing.Size(279, 28)
        Me.orderlbl.TabIndex = 5
        Me.orderlbl.Text = "Ordenar"
        Me.orderlbl.UseVisualStyleBackColor = False
        '
        'itemdescriptionlbl
        '
        Me.itemdescriptionlbl.AutoSize = True
        Me.itemdescriptionlbl.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemdescriptionlbl.ForeColor = System.Drawing.Color.Black
        Me.itemdescriptionlbl.Location = New System.Drawing.Point(89, 236)
        Me.itemdescriptionlbl.Name = "itemdescriptionlbl"
        Me.itemdescriptionlbl.Size = New System.Drawing.Size(241, 20)
        Me.itemdescriptionlbl.TabIndex = 3
        Me.itemdescriptionlbl.Text = "Con Cebolla, Tomate y Ketchup"
        '
        'itemnamelbl
        '
        Me.itemnamelbl.AutoSize = True
        Me.itemnamelbl.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemnamelbl.ForeColor = System.Drawing.Color.Black
        Me.itemnamelbl.Location = New System.Drawing.Point(59, 184)
        Me.itemnamelbl.Name = "itemnamelbl"
        Me.itemnamelbl.Size = New System.Drawing.Size(286, 41)
        Me.itemnamelbl.TabIndex = 2
        Me.itemnamelbl.Text = "Quesoburguesa"
        '
        'pricelbl
        '
        Me.pricelbl.AutoSize = True
        Me.pricelbl.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pricelbl.Location = New System.Drawing.Point(23, 58)
        Me.pricelbl.Name = "pricelbl"
        Me.pricelbl.Size = New System.Drawing.Size(420, 123)
        Me.pricelbl.TabIndex = 0
        Me.pricelbl.Text = "₡2000"
        '
        'itempicpb
        '
        Me.itempicpb.BackColor = System.Drawing.Color.Transparent
        Me.itempicpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.itempicpb.Image = CType(resources.GetObject("itempicpb.Image"), System.Drawing.Image)
        Me.itempicpb.Location = New System.Drawing.Point(421, 184)
        Me.itempicpb.Name = "itempicpb"
        Me.itempicpb.Size = New System.Drawing.Size(350, 269)
        Me.itempicpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.itempicpb.TabIndex = 6
        Me.itempicpb.TabStop = False
        '
        'homescreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "homescreen1"
        Me.Size = New System.Drawing.Size(774, 453)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.itempicpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents itemdescriptionlbl As Label
    Friend WithEvents itemnamelbl As Label
    Friend WithEvents justlbl As Label
    Friend WithEvents pricelbl As Label
    Friend WithEvents itempicpb As PictureBox
    Friend WithEvents orderlbl As Button
End Class
