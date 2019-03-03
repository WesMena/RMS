<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order))
        Me.orderdgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paybtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.deleteorderbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.deleteselectedbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.totaltext_lbl = New System.Windows.Forms.Label()
        Me.totalnumlbl = New System.Windows.Forms.Label()
        CType(Me.orderdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orderdgv
        '
        Me.orderdgv.AllowUserToResizeColumns = False
        Me.orderdgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.orderdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.orderdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.orderdgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.orderdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.orderdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.orderdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.orderdgv.ColumnHeadersHeight = 35
        Me.orderdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.orderdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.quantity, Me.unitprice, Me.totalprice})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.orderdgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.orderdgv.DoubleBuffered = True
        Me.orderdgv.EnableHeadersVisualStyles = False
        Me.orderdgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.orderdgv.HeaderForeColor = System.Drawing.SystemColors.ButtonFace
        Me.orderdgv.Location = New System.Drawing.Point(-2, 0)
        Me.orderdgv.MultiSelect = False
        Me.orderdgv.Name = "orderdgv"
        Me.orderdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.orderdgv.RowHeadersVisible = False
        Me.orderdgv.Size = New System.Drawing.Size(520, 332)
        Me.orderdgv.TabIndex = 0
        '
        'Item
        '
        Me.Item.HeaderText = "PLATILLO"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 103
        '
        'quantity
        '
        Me.quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quantity.HeaderText = "CANTIDAD"
        Me.quantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 98
        '
        'unitprice
        '
        Me.unitprice.HeaderText = "PRECIO UNITARIO"
        Me.unitprice.Name = "unitprice"
        Me.unitprice.ReadOnly = True
        Me.unitprice.Width = 175
        '
        'totalprice
        '
        Me.totalprice.HeaderText = "PRECIO TOTAL"
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        Me.totalprice.Width = 144
        '
        'paybtn
        '
        Me.paybtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.paybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.paybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.paybtn.BorderRadius = 0
        Me.paybtn.ButtonText = "Pagar"
        Me.paybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paybtn.DisabledColor = System.Drawing.Color.Gray
        Me.paybtn.Iconcolor = System.Drawing.Color.Transparent
        Me.paybtn.Iconimage = Nothing
        Me.paybtn.Iconimage_right = CType(resources.GetObject("paybtn.Iconimage_right"), System.Drawing.Image)
        Me.paybtn.Iconimage_right_Selected = Nothing
        Me.paybtn.Iconimage_Selected = Nothing
        Me.paybtn.IconMarginLeft = 0
        Me.paybtn.IconMarginRight = 0
        Me.paybtn.IconRightVisible = True
        Me.paybtn.IconRightZoom = 0R
        Me.paybtn.IconVisible = True
        Me.paybtn.IconZoom = 90.0R
        Me.paybtn.IsTab = False
        Me.paybtn.Location = New System.Drawing.Point(3, 399)
        Me.paybtn.Name = "paybtn"
        Me.paybtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.paybtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.paybtn.OnHoverTextColor = System.Drawing.Color.White
        Me.paybtn.selected = False
        Me.paybtn.Size = New System.Drawing.Size(146, 48)
        Me.paybtn.TabIndex = 3
        Me.paybtn.Text = "Pagar"
        Me.paybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.paybtn.Textcolor = System.Drawing.Color.White
        Me.paybtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'deleteorderbtn
        '
        Me.deleteorderbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.deleteorderbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.deleteorderbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteorderbtn.BorderRadius = 0
        Me.deleteorderbtn.ButtonText = "Cancelar"
        Me.deleteorderbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteorderbtn.DisabledColor = System.Drawing.Color.Gray
        Me.deleteorderbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.deleteorderbtn.Iconimage = Nothing
        Me.deleteorderbtn.Iconimage_right = CType(resources.GetObject("deleteorderbtn.Iconimage_right"), System.Drawing.Image)
        Me.deleteorderbtn.Iconimage_right_Selected = Nothing
        Me.deleteorderbtn.Iconimage_Selected = Nothing
        Me.deleteorderbtn.IconMarginLeft = 0
        Me.deleteorderbtn.IconMarginRight = 0
        Me.deleteorderbtn.IconRightVisible = True
        Me.deleteorderbtn.IconRightZoom = 0R
        Me.deleteorderbtn.IconVisible = True
        Me.deleteorderbtn.IconZoom = 90.0R
        Me.deleteorderbtn.IsTab = False
        Me.deleteorderbtn.Location = New System.Drawing.Point(347, 399)
        Me.deleteorderbtn.Name = "deleteorderbtn"
        Me.deleteorderbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.deleteorderbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.deleteorderbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.deleteorderbtn.selected = False
        Me.deleteorderbtn.Size = New System.Drawing.Size(168, 48)
        Me.deleteorderbtn.TabIndex = 4
        Me.deleteorderbtn.Text = "Cancelar"
        Me.deleteorderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.deleteorderbtn.Textcolor = System.Drawing.Color.White
        Me.deleteorderbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'deleteselectedbtn
        '
        Me.deleteselectedbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.deleteselectedbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.deleteselectedbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteselectedbtn.BorderRadius = 0
        Me.deleteselectedbtn.ButtonText = "Borrar Item"
        Me.deleteselectedbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteselectedbtn.DisabledColor = System.Drawing.Color.Gray
        Me.deleteselectedbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.deleteselectedbtn.Iconimage = Nothing
        Me.deleteselectedbtn.Iconimage_right = CType(resources.GetObject("deleteselectedbtn.Iconimage_right"), System.Drawing.Image)
        Me.deleteselectedbtn.Iconimage_right_Selected = Nothing
        Me.deleteselectedbtn.Iconimage_Selected = Nothing
        Me.deleteselectedbtn.IconMarginLeft = 0
        Me.deleteselectedbtn.IconMarginRight = 0
        Me.deleteselectedbtn.IconRightVisible = True
        Me.deleteselectedbtn.IconRightZoom = 0R
        Me.deleteselectedbtn.IconVisible = True
        Me.deleteselectedbtn.IconZoom = 90.0R
        Me.deleteselectedbtn.IsTab = False
        Me.deleteselectedbtn.Location = New System.Drawing.Point(151, 399)
        Me.deleteselectedbtn.Name = "deleteselectedbtn"
        Me.deleteselectedbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.deleteselectedbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.deleteselectedbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.deleteselectedbtn.selected = False
        Me.deleteselectedbtn.Size = New System.Drawing.Size(194, 48)
        Me.deleteselectedbtn.TabIndex = 5
        Me.deleteselectedbtn.Text = "Borrar Item"
        Me.deleteselectedbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.deleteselectedbtn.Textcolor = System.Drawing.Color.White
        Me.deleteselectedbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'totaltext_lbl
        '
        Me.totaltext_lbl.AutoSize = True
        Me.totaltext_lbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltext_lbl.ForeColor = System.Drawing.Color.Gray
        Me.totaltext_lbl.Location = New System.Drawing.Point(71, 335)
        Me.totaltext_lbl.Name = "totaltext_lbl"
        Me.totaltext_lbl.Size = New System.Drawing.Size(227, 28)
        Me.totaltext_lbl.TabIndex = 6
        Me.totaltext_lbl.Text = "TOTAL A PAGAR: ₡"
        '
        'totalnumlbl
        '
        Me.totalnumlbl.AutoSize = True
        Me.totalnumlbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalnumlbl.ForeColor = System.Drawing.Color.Gray
        Me.totalnumlbl.Location = New System.Drawing.Point(304, 335)
        Me.totalnumlbl.Name = "totalnumlbl"
        Me.totalnumlbl.Size = New System.Drawing.Size(77, 28)
        Me.totalnumlbl.TabIndex = 7
        Me.totalnumlbl.Text = "17900"
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.totalnumlbl)
        Me.Controls.Add(Me.totaltext_lbl)
        Me.Controls.Add(Me.paybtn)
        Me.Controls.Add(Me.orderdgv)
        Me.Controls.Add(Me.deleteselectedbtn)
        Me.Controls.Add(Me.deleteorderbtn)
        Me.Name = "Order"
        Me.Size = New System.Drawing.Size(515, 448)
        CType(Me.orderdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents orderdgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents paybtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents deleteorderbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents deleteselectedbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewComboBoxColumn
    Friend WithEvents unitprice As DataGridViewTextBoxColumn
    Friend WithEvents totalprice As DataGridViewTextBoxColumn
    Friend WithEvents totaltext_lbl As Label
    Friend WithEvents totalnumlbl As Label
End Class
