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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminClient))
        Me.addItemButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.modifyItemButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ShowOrderListbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Orderlist1 = New RMS1._0.orderlist()
        Me.modifyitem = New RMS1._0.ModifyItemUC()
        Me.AdminUserControl1 = New RMS1._0.AdminUserControl()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.addItemButton.Location = New System.Drawing.Point(649, 461)
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
        Me.modifyItemButton.Location = New System.Drawing.Point(366, 461)
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
        'ShowOrderListbtn
        '
        Me.ShowOrderListbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ShowOrderListbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ShowOrderListbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShowOrderListbtn.BorderRadius = 0
        Me.ShowOrderListbtn.ButtonText = "Pedidos"
        Me.ShowOrderListbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowOrderListbtn.DisabledColor = System.Drawing.Color.Gray
        Me.ShowOrderListbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.ShowOrderListbtn.Iconimage = Nothing
        Me.ShowOrderListbtn.Iconimage_right = CType(resources.GetObject("ShowOrderListbtn.Iconimage_right"), System.Drawing.Image)
        Me.ShowOrderListbtn.Iconimage_right_Selected = Nothing
        Me.ShowOrderListbtn.Iconimage_Selected = Nothing
        Me.ShowOrderListbtn.IconMarginLeft = 0
        Me.ShowOrderListbtn.IconMarginRight = 0
        Me.ShowOrderListbtn.IconRightVisible = True
        Me.ShowOrderListbtn.IconRightZoom = 0R
        Me.ShowOrderListbtn.IconVisible = True
        Me.ShowOrderListbtn.IconZoom = 90.0R
        Me.ShowOrderListbtn.IsTab = False
        Me.ShowOrderListbtn.Location = New System.Drawing.Point(-2, 448)
        Me.ShowOrderListbtn.Name = "ShowOrderListbtn"
        Me.ShowOrderListbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ShowOrderListbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ShowOrderListbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.ShowOrderListbtn.selected = False
        Me.ShowOrderListbtn.Size = New System.Drawing.Size(238, 48)
        Me.ShowOrderListbtn.TabIndex = 11
        Me.ShowOrderListbtn.Text = "Pedidos"
        Me.ShowOrderListbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowOrderListbtn.Textcolor = System.Drawing.Color.White
        Me.ShowOrderListbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 41)
        Me.Panel1.TabIndex = 12
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), System.Drawing.Image)
        Me.closeBtn.ImageActive = Nothing
        Me.closeBtn.Location = New System.Drawing.Point(875, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(63, 41)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 21
        Me.closeBtn.TabStop = False
        Me.closeBtn.Zoom = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Orderlist1
        '
        Me.Orderlist1.Location = New System.Drawing.Point(236, 29)
        Me.Orderlist1.Name = "Orderlist1"
        Me.Orderlist1.Size = New System.Drawing.Size(710, 482)
        Me.Orderlist1.TabIndex = 9
        '
        'modifyitem
        '
        Me.modifyitem.Category = Nothing
        Me.modifyitem.Description = Nothing
        Me.modifyitem.Id = 0
        Me.modifyitem.Imagepath = Nothing
        Me.modifyitem.IsUpdate = False
        Me.modifyitem.ItemName = Nothing
        Me.modifyitem.Location = New System.Drawing.Point(236, 28)
        Me.modifyitem.Name = "modifyitem"
        Me.modifyitem.Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.modifyitem.Size = New System.Drawing.Size(703, 483)
        Me.modifyitem.Special = False
        Me.modifyitem.TabIndex = 6
        Me.modifyitem.Visible = False
        '
        'AdminUserControl1
        '
        Me.AdminUserControl1.Location = New System.Drawing.Point(-2, 28)
        Me.AdminUserControl1.Name = "AdminUserControl1"
        Me.AdminUserControl1.Size = New System.Drawing.Size(941, 483)
        Me.AdminUserControl1.TabIndex = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'AdminClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShowOrderListbtn)
        Me.Controls.Add(Me.Orderlist1)
        Me.Controls.Add(Me.modifyitem)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.modifyItemButton)
        Me.Controls.Add(Me.AdminUserControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminClient"
        Me.Panel1.ResumeLayout(False)
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminUserControl1 As AdminUserControl
    Friend WithEvents modifyitem As ModifyItemUC
    Friend WithEvents modifyItemButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents addItemButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Orderlist1 As orderlist
    Friend WithEvents ShowOrderListbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
