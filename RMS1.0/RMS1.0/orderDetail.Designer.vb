<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderDetail))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.orderdetaildgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.closeBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Orderlbl = New System.Windows.Forms.Label()
        CType(Me.orderdetaildgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'orderdetaildgv
        '
        Me.orderdetaildgv.AllowUserToResizeColumns = False
        Me.orderdetaildgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.orderdetaildgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.orderdetaildgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.orderdetaildgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.orderdetaildgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.orderdetaildgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.orderdetaildgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderdetaildgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.orderdetaildgv.ColumnHeadersHeight = 35
        Me.orderdetaildgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.orderdetaildgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.orderdetaildgv.DoubleBuffered = True
        Me.orderdetaildgv.EnableHeadersVisualStyles = False
        Me.orderdetaildgv.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.orderdetaildgv.HeaderForeColor = System.Drawing.SystemColors.ButtonFace
        Me.orderdetaildgv.Location = New System.Drawing.Point(3, 48)
        Me.orderdetaildgv.MultiSelect = False
        Me.orderdetaildgv.Name = "orderdetaildgv"
        Me.orderdetaildgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.orderdetaildgv.RowHeadersVisible = False
        Me.orderdetaildgv.Size = New System.Drawing.Size(707, 434)
        Me.orderdetaildgv.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.closeBtn)
        Me.Panel2.Controls.Add(Me.Orderlbl)
        Me.Panel2.Location = New System.Drawing.Point(-9, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(719, 52)
        Me.Panel2.TabIndex = 19
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), System.Drawing.Image)
        Me.closeBtn.ImageActive = Nothing
        Me.closeBtn.Location = New System.Drawing.Point(628, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(63, 46)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 20
        Me.closeBtn.TabStop = False
        Me.closeBtn.Zoom = 10
        '
        'Orderlbl
        '
        Me.Orderlbl.AutoSize = True
        Me.Orderlbl.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orderlbl.ForeColor = System.Drawing.SystemColors.Control
        Me.Orderlbl.Location = New System.Drawing.Point(266, 13)
        Me.Orderlbl.Name = "Orderlbl"
        Me.Orderlbl.Size = New System.Drawing.Size(135, 32)
        Me.Orderlbl.TabIndex = 0
        Me.Orderlbl.Text = "ÓRDENES"
        '
        'orderDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.orderdetaildgv)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "orderDetail"
        Me.Size = New System.Drawing.Size(710, 482)
        CType(Me.orderdetaildgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents orderdetaildgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Orderlbl As Label
    Friend WithEvents closeBtn As Bunifu.Framework.UI.BunifuImageButton
End Class
