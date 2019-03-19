<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminUserControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.drinksButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dessertButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.specialsButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.allitemsButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.mainCourseButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.appetizerbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.admindgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Special = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.categorylbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.admindgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.drinksButton)
        Me.Panel1.Controls.Add(Me.dessertButton)
        Me.Panel1.Controls.Add(Me.specialsButton)
        Me.Panel1.Controls.Add(Me.allitemsButton)
        Me.Panel1.Controls.Add(Me.mainCourseButton)
        Me.Panel1.Controls.Add(Me.appetizerbtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 482)
        Me.Panel1.TabIndex = 13
        '
        'drinksButton
        '
        Me.drinksButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.drinksButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.drinksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.drinksButton.BorderRadius = 0
        Me.drinksButton.ButtonText = "Bebidas"
        Me.drinksButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.drinksButton.DisabledColor = System.Drawing.Color.Gray
        Me.drinksButton.Iconcolor = System.Drawing.Color.Transparent
        Me.drinksButton.Iconimage = Nothing
        Me.drinksButton.Iconimage_right = CType(resources.GetObject("drinksButton.Iconimage_right"), System.Drawing.Image)
        Me.drinksButton.Iconimage_right_Selected = Nothing
        Me.drinksButton.Iconimage_Selected = Nothing
        Me.drinksButton.IconMarginLeft = 0
        Me.drinksButton.IconMarginRight = 0
        Me.drinksButton.IconRightVisible = True
        Me.drinksButton.IconRightZoom = 0R
        Me.drinksButton.IconVisible = True
        Me.drinksButton.IconZoom = 90.0R
        Me.drinksButton.IsTab = False
        Me.drinksButton.Location = New System.Drawing.Point(0, 354)
        Me.drinksButton.Name = "drinksButton"
        Me.drinksButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.drinksButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.drinksButton.OnHoverTextColor = System.Drawing.Color.White
        Me.drinksButton.selected = False
        Me.drinksButton.Size = New System.Drawing.Size(238, 48)
        Me.drinksButton.TabIndex = 9
        Me.drinksButton.Text = "Bebidas"
        Me.drinksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.drinksButton.Textcolor = System.Drawing.Color.White
        Me.drinksButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dessertButton
        '
        Me.dessertButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dessertButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.dessertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dessertButton.BorderRadius = 0
        Me.dessertButton.ButtonText = "Postres"
        Me.dessertButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dessertButton.DisabledColor = System.Drawing.Color.Gray
        Me.dessertButton.Iconcolor = System.Drawing.Color.Transparent
        Me.dessertButton.Iconimage = Nothing
        Me.dessertButton.Iconimage_right = CType(resources.GetObject("dessertButton.Iconimage_right"), System.Drawing.Image)
        Me.dessertButton.Iconimage_right_Selected = Nothing
        Me.dessertButton.Iconimage_Selected = Nothing
        Me.dessertButton.IconMarginLeft = 0
        Me.dessertButton.IconMarginRight = 0
        Me.dessertButton.IconRightVisible = True
        Me.dessertButton.IconRightZoom = 0R
        Me.dessertButton.IconVisible = True
        Me.dessertButton.IconZoom = 90.0R
        Me.dessertButton.IsTab = False
        Me.dessertButton.Location = New System.Drawing.Point(3, 291)
        Me.dessertButton.Name = "dessertButton"
        Me.dessertButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.dessertButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.dessertButton.OnHoverTextColor = System.Drawing.Color.White
        Me.dessertButton.selected = False
        Me.dessertButton.Size = New System.Drawing.Size(235, 48)
        Me.dessertButton.TabIndex = 10
        Me.dessertButton.Text = "Postres"
        Me.dessertButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dessertButton.Textcolor = System.Drawing.Color.White
        Me.dessertButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'specialsButton
        '
        Me.specialsButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.specialsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.specialsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.specialsButton.BorderRadius = 0
        Me.specialsButton.ButtonText = "Items Especiales"
        Me.specialsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.specialsButton.DisabledColor = System.Drawing.Color.Gray
        Me.specialsButton.Iconcolor = System.Drawing.Color.Transparent
        Me.specialsButton.Iconimage = Nothing
        Me.specialsButton.Iconimage_right = CType(resources.GetObject("specialsButton.Iconimage_right"), System.Drawing.Image)
        Me.specialsButton.Iconimage_right_Selected = Nothing
        Me.specialsButton.Iconimage_Selected = Nothing
        Me.specialsButton.IconMarginLeft = 0
        Me.specialsButton.IconMarginRight = 0
        Me.specialsButton.IconRightVisible = True
        Me.specialsButton.IconRightZoom = 0R
        Me.specialsButton.IconVisible = True
        Me.specialsButton.IconZoom = 90.0R
        Me.specialsButton.IsTab = False
        Me.specialsButton.Location = New System.Drawing.Point(3, 109)
        Me.specialsButton.Name = "specialsButton"
        Me.specialsButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.specialsButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.specialsButton.OnHoverTextColor = System.Drawing.Color.White
        Me.specialsButton.selected = False
        Me.specialsButton.Size = New System.Drawing.Size(238, 48)
        Me.specialsButton.TabIndex = 11
        Me.specialsButton.Text = "Items Especiales"
        Me.specialsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.specialsButton.Textcolor = System.Drawing.Color.White
        Me.specialsButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'allitemsButton
        '
        Me.allitemsButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.allitemsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.allitemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.allitemsButton.BorderRadius = 0
        Me.allitemsButton.ButtonText = "Todos los Items"
        Me.allitemsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.allitemsButton.DisabledColor = System.Drawing.Color.Gray
        Me.allitemsButton.Iconcolor = System.Drawing.Color.Transparent
        Me.allitemsButton.Iconimage = Nothing
        Me.allitemsButton.Iconimage_right = CType(resources.GetObject("allitemsButton.Iconimage_right"), System.Drawing.Image)
        Me.allitemsButton.Iconimage_right_Selected = Nothing
        Me.allitemsButton.Iconimage_Selected = Nothing
        Me.allitemsButton.IconMarginLeft = 0
        Me.allitemsButton.IconMarginRight = 0
        Me.allitemsButton.IconRightVisible = True
        Me.allitemsButton.IconRightZoom = 0R
        Me.allitemsButton.IconVisible = True
        Me.allitemsButton.IconZoom = 90.0R
        Me.allitemsButton.IsTab = False
        Me.allitemsButton.Location = New System.Drawing.Point(6, 48)
        Me.allitemsButton.Name = "allitemsButton"
        Me.allitemsButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.allitemsButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.allitemsButton.OnHoverTextColor = System.Drawing.Color.White
        Me.allitemsButton.selected = False
        Me.allitemsButton.Size = New System.Drawing.Size(235, 48)
        Me.allitemsButton.TabIndex = 12
        Me.allitemsButton.Text = "Todos los Items"
        Me.allitemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.allitemsButton.Textcolor = System.Drawing.Color.White
        Me.allitemsButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'mainCourseButton
        '
        Me.mainCourseButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mainCourseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.mainCourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainCourseButton.BorderRadius = 0
        Me.mainCourseButton.ButtonText = "Plato Fuerte"
        Me.mainCourseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainCourseButton.DisabledColor = System.Drawing.Color.Gray
        Me.mainCourseButton.Iconcolor = System.Drawing.Color.Transparent
        Me.mainCourseButton.Iconimage = Nothing
        Me.mainCourseButton.Iconimage_right = CType(resources.GetObject("mainCourseButton.Iconimage_right"), System.Drawing.Image)
        Me.mainCourseButton.Iconimage_right_Selected = Nothing
        Me.mainCourseButton.Iconimage_Selected = Nothing
        Me.mainCourseButton.IconMarginLeft = 0
        Me.mainCourseButton.IconMarginRight = 0
        Me.mainCourseButton.IconRightVisible = True
        Me.mainCourseButton.IconRightZoom = 0R
        Me.mainCourseButton.IconVisible = True
        Me.mainCourseButton.IconZoom = 90.0R
        Me.mainCourseButton.IsTab = False
        Me.mainCourseButton.Location = New System.Drawing.Point(3, 226)
        Me.mainCourseButton.Name = "mainCourseButton"
        Me.mainCourseButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.mainCourseButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.mainCourseButton.OnHoverTextColor = System.Drawing.Color.White
        Me.mainCourseButton.selected = False
        Me.mainCourseButton.Size = New System.Drawing.Size(238, 48)
        Me.mainCourseButton.TabIndex = 8
        Me.mainCourseButton.Text = "Plato Fuerte"
        Me.mainCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainCourseButton.Textcolor = System.Drawing.Color.White
        Me.mainCourseButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'appetizerbtn
        '
        Me.appetizerbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.appetizerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.appetizerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.appetizerbtn.BorderRadius = 0
        Me.appetizerbtn.ButtonText = "Entradas"
        Me.appetizerbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appetizerbtn.DisabledColor = System.Drawing.Color.Gray
        Me.appetizerbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.appetizerbtn.Iconimage = Nothing
        Me.appetizerbtn.Iconimage_right = CType(resources.GetObject("appetizerbtn.Iconimage_right"), System.Drawing.Image)
        Me.appetizerbtn.Iconimage_right_Selected = Nothing
        Me.appetizerbtn.Iconimage_Selected = Nothing
        Me.appetizerbtn.IconMarginLeft = 0
        Me.appetizerbtn.IconMarginRight = 0
        Me.appetizerbtn.IconRightVisible = True
        Me.appetizerbtn.IconRightZoom = 0R
        Me.appetizerbtn.IconVisible = True
        Me.appetizerbtn.IconZoom = 90.0R
        Me.appetizerbtn.IsTab = False
        Me.appetizerbtn.Location = New System.Drawing.Point(0, 163)
        Me.appetizerbtn.Name = "appetizerbtn"
        Me.appetizerbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.appetizerbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.appetizerbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.appetizerbtn.selected = False
        Me.appetizerbtn.Size = New System.Drawing.Size(238, 48)
        Me.appetizerbtn.TabIndex = 7
        Me.appetizerbtn.Text = "Entradas"
        Me.appetizerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.appetizerbtn.Textcolor = System.Drawing.Color.White
        Me.appetizerbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'admindgv
        '
        Me.admindgv.AllowUserToResizeColumns = False
        Me.admindgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.admindgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.admindgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.admindgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.admindgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.admindgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.admindgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.admindgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.admindgv.ColumnHeadersHeight = 35
        Me.admindgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.admindgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.itemname, Me.Description, Me.DataGridViewTextBoxColumn2, Me.Price, Me.Special, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.admindgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.admindgv.DoubleBuffered = True
        Me.admindgv.EnableHeadersVisualStyles = False
        Me.admindgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.admindgv.HeaderForeColor = System.Drawing.SystemColors.ButtonFace
        Me.admindgv.Location = New System.Drawing.Point(238, 48)
        Me.admindgv.MultiSelect = False
        Me.admindgv.Name = "admindgv"
        Me.admindgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.admindgv.RowHeadersVisible = False
        Me.admindgv.Size = New System.Drawing.Size(705, 376)
        Me.admindgv.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdColumn"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'itemname
        '
        Me.itemname.HeaderText = "Nombre"
        Me.itemname.Name = "itemname"
        '
        'Description
        '
        Me.Description.HeaderText = "Descripción"
        Me.Description.Name = "Description"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Price
        '
        Me.Price.HeaderText = "Precio"
        Me.Price.Name = "Price"
        '
        'Special
        '
        Me.Special.HeaderText = "Especial"
        Me.Special.Name = "Special"
        Me.Special.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Imagen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.categorylbl)
        Me.Panel2.Location = New System.Drawing.Point(238, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 52)
        Me.Panel2.TabIndex = 15
        '
        'categorylbl
        '
        Me.categorylbl.AutoSize = True
        Me.categorylbl.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorylbl.ForeColor = System.Drawing.SystemColors.Control
        Me.categorylbl.Location = New System.Drawing.Point(268, 13)
        Me.categorylbl.Name = "categorylbl"
        Me.categorylbl.Size = New System.Drawing.Size(316, 32)
        Me.categorylbl.TabIndex = 0
        Me.categorylbl.Text = "La categoría sale aquí "
        '
        'AdminUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.admindgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "AdminUserControl"
        Me.Size = New System.Drawing.Size(943, 482)
        Me.Panel1.ResumeLayout(False)
        CType(Me.admindgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents appetizerbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents mainCourseButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents drinksButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dessertButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents specialsButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents allitemsButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents admindgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents itemname As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Special As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents categorylbl As Label
End Class
