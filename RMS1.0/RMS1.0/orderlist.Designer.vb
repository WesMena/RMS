<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderlist
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderlist))
        Me.orderlistdgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Orderlbl = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.printbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.orderDetailsbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.OrderDetail1 = New RMS1._0.orderDetail()
        CType(Me.orderlistdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'orderlistdgv
        '
        Me.orderlistdgv.AllowUserToResizeColumns = False
        Me.orderlistdgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.orderlistdgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.orderlistdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.orderlistdgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.orderlistdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.orderlistdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.orderlistdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderlistdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.orderlistdgv.ColumnHeadersHeight = 35
        Me.orderlistdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.orderlistdgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.orderlistdgv.DoubleBuffered = True
        Me.orderlistdgv.EnableHeadersVisualStyles = False
        Me.orderlistdgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.orderlistdgv.HeaderForeColor = System.Drawing.SystemColors.ButtonFace
        Me.orderlistdgv.Location = New System.Drawing.Point(3, 47)
        Me.orderlistdgv.MultiSelect = False
        Me.orderlistdgv.Name = "orderlistdgv"
        Me.orderlistdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.orderlistdgv.RowHeadersVisible = False
        Me.orderlistdgv.Size = New System.Drawing.Size(714, 376)
        Me.orderlistdgv.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Orderlbl)
        Me.Panel2.Location = New System.Drawing.Point(3, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(714, 52)
        Me.Panel2.TabIndex = 17
        '
        'Orderlbl
        '
        Me.Orderlbl.AutoSize = True
        Me.Orderlbl.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orderlbl.ForeColor = System.Drawing.SystemColors.Control
        Me.Orderlbl.Location = New System.Drawing.Point(268, 13)
        Me.Orderlbl.Name = "Orderlbl"
        Me.Orderlbl.Size = New System.Drawing.Size(135, 32)
        Me.Orderlbl.TabIndex = 0
        Me.Orderlbl.Text = "ÓRDENES"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'printbtn
        '
        Me.printbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.printbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.printbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.printbtn.BorderRadius = 0
        Me.printbtn.ButtonText = "Imprimir"
        Me.printbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printbtn.DisabledColor = System.Drawing.Color.Gray
        Me.printbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.printbtn.Iconimage = Nothing
        Me.printbtn.Iconimage_right = CType(resources.GetObject("printbtn.Iconimage_right"), System.Drawing.Image)
        Me.printbtn.Iconimage_right_Selected = Nothing
        Me.printbtn.Iconimage_Selected = Nothing
        Me.printbtn.IconMarginLeft = 0
        Me.printbtn.IconMarginRight = 0
        Me.printbtn.IconRightVisible = True
        Me.printbtn.IconRightZoom = 0R
        Me.printbtn.IconVisible = True
        Me.printbtn.IconZoom = 90.0R
        Me.printbtn.IsTab = False
        Me.printbtn.Location = New System.Drawing.Point(369, 429)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.printbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.printbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.printbtn.selected = False
        Me.printbtn.Size = New System.Drawing.Size(177, 48)
        Me.printbtn.TabIndex = 18
        Me.printbtn.Text = "Imprimir"
        Me.printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.printbtn.Textcolor = System.Drawing.Color.White
        Me.printbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'orderDetailsbtn
        '
        Me.orderDetailsbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.orderDetailsbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.orderDetailsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.orderDetailsbtn.BorderRadius = 0
        Me.orderDetailsbtn.ButtonText = "Ver detalle"
        Me.orderDetailsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.orderDetailsbtn.DisabledColor = System.Drawing.Color.Gray
        Me.orderDetailsbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.orderDetailsbtn.Iconimage = Nothing
        Me.orderDetailsbtn.Iconimage_right = CType(resources.GetObject("orderDetailsbtn.Iconimage_right"), System.Drawing.Image)
        Me.orderDetailsbtn.Iconimage_right_Selected = Nothing
        Me.orderDetailsbtn.Iconimage_Selected = Nothing
        Me.orderDetailsbtn.IconMarginLeft = 0
        Me.orderDetailsbtn.IconMarginRight = 0
        Me.orderDetailsbtn.IconRightVisible = True
        Me.orderDetailsbtn.IconRightZoom = 0R
        Me.orderDetailsbtn.IconVisible = True
        Me.orderDetailsbtn.IconZoom = 90.0R
        Me.orderDetailsbtn.IsTab = False
        Me.orderDetailsbtn.Location = New System.Drawing.Point(128, 429)
        Me.orderDetailsbtn.Name = "orderDetailsbtn"
        Me.orderDetailsbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.orderDetailsbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.orderDetailsbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.orderDetailsbtn.selected = False
        Me.orderDetailsbtn.Size = New System.Drawing.Size(177, 48)
        Me.orderDetailsbtn.TabIndex = 19
        Me.orderDetailsbtn.Text = "Ver detalle"
        Me.orderDetailsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.orderDetailsbtn.Textcolor = System.Drawing.Color.White
        Me.orderDetailsbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OrderDetail1
        '
        Me.OrderDetail1.Location = New System.Drawing.Point(0, -1)
        Me.OrderDetail1.Name = "OrderDetail1"
        Me.OrderDetail1.Size = New System.Drawing.Size(717, 424)
        Me.OrderDetail1.TabIndex = 20
        '
        'orderlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OrderDetail1)
        Me.Controls.Add(Me.orderDetailsbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.orderlistdgv)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "orderlist"
        Me.Size = New System.Drawing.Size(717, 482)
        CType(Me.orderlistdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents orderlistdgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Orderlbl As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents orderDetailsbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents printbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents OrderDetail1 As orderDetail
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
