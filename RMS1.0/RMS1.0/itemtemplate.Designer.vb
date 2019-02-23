<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemtemplate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemtemplate))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.itemlbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.descriptionlbl = New System.Windows.Forms.Label()
        Me.pricelbl = New System.Windows.Forms.Label()
        Me.addbtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.idlbl = New System.Windows.Forms.Label()
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'itemlbl
        '
        Me.itemlbl.AutoSize = True
        Me.itemlbl.BackColor = System.Drawing.Color.Transparent
        Me.itemlbl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.itemlbl.Location = New System.Drawing.Point(19, 16)
        Me.itemlbl.Name = "itemlbl"
        Me.itemlbl.Size = New System.Drawing.Size(155, 23)
        Me.itemlbl.TabIndex = 0
        Me.itemlbl.Text = "Pizza Cardinale"
        '
        'descriptionlbl
        '
        Me.descriptionlbl.AutoSize = True
        Me.descriptionlbl.BackColor = System.Drawing.Color.Transparent
        Me.descriptionlbl.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.descriptionlbl.Location = New System.Drawing.Point(19, 65)
        Me.descriptionlbl.Name = "descriptionlbl"
        Me.descriptionlbl.Size = New System.Drawing.Size(235, 20)
        Me.descriptionlbl.TabIndex = 2
        Me.descriptionlbl.Text = "Tomate, mozzarella y prosciutto"
        Me.descriptionlbl.UseMnemonic = False
        '
        'pricelbl
        '
        Me.pricelbl.AutoSize = True
        Me.pricelbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pricelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pricelbl.Location = New System.Drawing.Point(300, 50)
        Me.pricelbl.Name = "pricelbl"
        Me.pricelbl.Size = New System.Drawing.Size(27, 19)
        Me.pricelbl.TabIndex = 3
        Me.pricelbl.Text = "$2"
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.addbtn.Image = CType(resources.GetObject("addbtn.Image"), System.Drawing.Image)
        Me.addbtn.ImageActive = Nothing
        Me.addbtn.Location = New System.Drawing.Point(344, 31)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(63, 54)
        Me.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addbtn.TabIndex = 4
        Me.addbtn.TabStop = False
        Me.addbtn.Zoom = 10
        '
        'idlbl
        '
        Me.idlbl.AutoSize = True
        Me.idlbl.Location = New System.Drawing.Point(252, 16)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(15, 13)
        Me.idlbl.TabIndex = 5
        Me.idlbl.Text = "id"
        Me.idlbl.Visible = False
        '
        'itemtemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.pricelbl)
        Me.Controls.Add(Me.descriptionlbl)
        Me.Controls.Add(Me.itemlbl)
        Me.Name = "itemtemplate"
        Me.Size = New System.Drawing.Size(418, 104)
        CType(Me.addbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents itemlbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents descriptionlbl As Label
    Friend WithEvents addbtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pricelbl As Label
    Friend WithEvents idlbl As Label
End Class
