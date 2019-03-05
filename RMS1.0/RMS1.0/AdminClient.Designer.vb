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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminClient))
        Me.modifyitem = New RMS1._0.ModifyItemUC()
        Me.AdminUserControl1 = New RMS1._0.AdminUserControl()
        Me.modifyItemButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.addItemButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'modifyitem
        '
        Me.modifyitem.Category = Nothing
        Me.modifyitem.Description = Nothing
        Me.modifyitem.Id = 0
        Me.modifyitem.Imagepath = Nothing
        Me.modifyitem.IsUpdate = False
        Me.modifyitem.ItemName = Nothing
        Me.modifyitem.Location = New System.Drawing.Point(235, 1)
        Me.modifyitem.Name = "modifyitem"
        Me.modifyitem.Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.modifyitem.Size = New System.Drawing.Size(703, 481)
        Me.modifyitem.Special = False
        Me.modifyitem.TabIndex = 6
        Me.modifyitem.Visible = False
        '
        'AdminUserControl1
        '
        Me.AdminUserControl1.Location = New System.Drawing.Point(-3, -1)
        Me.AdminUserControl1.Name = "AdminUserControl1"
        Me.AdminUserControl1.Size = New System.Drawing.Size(941, 483)
        Me.AdminUserControl1.TabIndex = 0
        '
        'modifyItemButton
        '
        Me.modifyItemButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.modifyItemButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.modifyItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modifyItemButton.BorderRadius = 0
        Me.modifyItemButton.ButtonText = "Modificar Item"
        Me.modifyItemButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifyItemButton.DisabledColor = System.Drawing.Color.Gray
        Me.modifyItemButton.Iconcolor = System.Drawing.Color.Transparent
        Me.modifyItemButton.Iconimage = Nothing
        Me.modifyItemButton.Iconimage_right = CType(resources.GetObject("modifyItemButton.Iconimage_right"), System.Drawing.Image)
        Me.modifyItemButton.Iconimage_right_Selected = Nothing
        Me.modifyItemButton.Iconimage_Selected = Nothing
        Me.modifyItemButton.IconMarginLeft = 0
        Me.modifyItemButton.IconMarginRight = 0
        Me.modifyItemButton.IconRightVisible = True
        Me.modifyItemButton.IconRightZoom = 0R
        Me.modifyItemButton.IconVisible = True
        Me.modifyItemButton.IconZoom = 90.0R
        Me.modifyItemButton.IsTab = False
        Me.modifyItemButton.Location = New System.Drawing.Point(365, 432)
        Me.modifyItemButton.Name = "modifyItemButton"
        Me.modifyItemButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.modifyItemButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.modifyItemButton.OnHoverTextColor = System.Drawing.Color.White
        Me.modifyItemButton.selected = False
        Me.modifyItemButton.Size = New System.Drawing.Size(227, 48)
        Me.modifyItemButton.TabIndex = 7
        Me.modifyItemButton.Text = "Modificar Item"
        Me.modifyItemButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modifyItemButton.Textcolor = System.Drawing.Color.White
        Me.modifyItemButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'addItemButton
        '
        Me.addItemButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.addItemButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.addItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addItemButton.BorderRadius = 0
        Me.addItemButton.ButtonText = "Agregar Item"
        Me.addItemButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addItemButton.DisabledColor = System.Drawing.Color.Gray
        Me.addItemButton.Iconcolor = System.Drawing.Color.Transparent
        Me.addItemButton.Iconimage = Nothing
        Me.addItemButton.Iconimage_right = CType(resources.GetObject("addItemButton.Iconimage_right"), System.Drawing.Image)
        Me.addItemButton.Iconimage_right_Selected = Nothing
        Me.addItemButton.Iconimage_Selected = Nothing
        Me.addItemButton.IconMarginLeft = 0
        Me.addItemButton.IconMarginRight = 0
        Me.addItemButton.IconRightVisible = True
        Me.addItemButton.IconRightZoom = 0R
        Me.addItemButton.IconVisible = True
        Me.addItemButton.IconZoom = 90.0R
        Me.addItemButton.IsTab = False
        Me.addItemButton.Location = New System.Drawing.Point(648, 432)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.addItemButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.addItemButton.OnHoverTextColor = System.Drawing.Color.White
        Me.addItemButton.selected = False
        Me.addItemButton.Size = New System.Drawing.Size(227, 48)
        Me.addItemButton.TabIndex = 8
        Me.addItemButton.Text = "Agregar Item"
        Me.addItemButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addItemButton.Textcolor = System.Drawing.Color.White
        Me.addItemButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AdminClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(936, 479)
        Me.Controls.Add(Me.modifyitem)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.modifyItemButton)
        Me.Controls.Add(Me.AdminUserControl1)
        Me.Name = "AdminClient"
        Me.Text = "AdminClient"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminUserControl1 As AdminUserControl
    Friend WithEvents modifyitem As ModifyItemUC
    Friend WithEvents modifyItemButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents addItemButton As Bunifu.Framework.UI.BunifuFlatButton
End Class
