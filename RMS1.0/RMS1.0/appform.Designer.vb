<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class appform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appform))
        Me.homebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.appetizerbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.maincoursebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.drinksbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dessertsbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.orderbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.homepanel = New System.Windows.Forms.Panel()
        Me.PanelUC = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnanim = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.cattransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.HideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Order1 = New RMS1._0.Order()
        Me.Homehub1 = New RMS1._0.Homehub()
        Me.CategoryUC1 = New RMS1._0.categoryUC()
        Me.homepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'homebtn
        '
        Me.homebtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homebtn.BorderRadius = 0
        Me.homebtn.ButtonText = "Inicio"
        Me.homebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cattransition.SetDecoration(Me.homebtn, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.homebtn, BunifuAnimatorNS.DecorationType.None)
        Me.homebtn.DisabledColor = System.Drawing.Color.Gray
        Me.homebtn.Iconcolor = System.Drawing.Color.Transparent
        Me.homebtn.Iconimage = Nothing
        Me.homebtn.Iconimage_right = CType(resources.GetObject("homebtn.Iconimage_right"), System.Drawing.Image)
        Me.homebtn.Iconimage_right_Selected = Nothing
        Me.homebtn.Iconimage_Selected = Nothing
        Me.homebtn.IconMarginLeft = 0
        Me.homebtn.IconMarginRight = 0
        Me.homebtn.IconRightVisible = True
        Me.homebtn.IconRightZoom = 0R
        Me.homebtn.IconVisible = True
        Me.homebtn.IconZoom = 90.0R
        Me.homebtn.IsTab = False
        Me.homebtn.Location = New System.Drawing.Point(-112, 40)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.homebtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.homebtn.OnHoverTextColor = System.Drawing.Color.White
        Me.homebtn.selected = False
        Me.homebtn.Size = New System.Drawing.Size(159, 48)
        Me.homebtn.TabIndex = 1
        Me.homebtn.Text = "Inicio"
        Me.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homebtn.Textcolor = System.Drawing.Color.White
        Me.homebtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'appetizerbtn
        '
        Me.appetizerbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.appetizerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.appetizerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.appetizerbtn.BorderRadius = 0
        Me.appetizerbtn.ButtonText = "Entradas"
        Me.appetizerbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cattransition.SetDecoration(Me.appetizerbtn, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.appetizerbtn, BunifuAnimatorNS.DecorationType.None)
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
        Me.appetizerbtn.Location = New System.Drawing.Point(-112, 100)
        Me.appetizerbtn.Name = "appetizerbtn"
        Me.appetizerbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.appetizerbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.appetizerbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.appetizerbtn.selected = False
        Me.appetizerbtn.Size = New System.Drawing.Size(159, 48)
        Me.appetizerbtn.TabIndex = 2
        Me.appetizerbtn.Text = "Entradas"
        Me.appetizerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.appetizerbtn.Textcolor = System.Drawing.Color.White
        Me.appetizerbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'maincoursebtn
        '
        Me.maincoursebtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.maincoursebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.maincoursebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.maincoursebtn.BorderRadius = 0
        Me.maincoursebtn.ButtonText = "Plato Fuerte"
        Me.maincoursebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cattransition.SetDecoration(Me.maincoursebtn, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.maincoursebtn, BunifuAnimatorNS.DecorationType.None)
        Me.maincoursebtn.DisabledColor = System.Drawing.Color.Gray
        Me.maincoursebtn.Iconcolor = System.Drawing.Color.Transparent
        Me.maincoursebtn.Iconimage = Nothing
        Me.maincoursebtn.Iconimage_right = CType(resources.GetObject("maincoursebtn.Iconimage_right"), System.Drawing.Image)
        Me.maincoursebtn.Iconimage_right_Selected = Nothing
        Me.maincoursebtn.Iconimage_Selected = Nothing
        Me.maincoursebtn.IconMarginLeft = 0
        Me.maincoursebtn.IconMarginRight = 0
        Me.maincoursebtn.IconRightVisible = True
        Me.maincoursebtn.IconRightZoom = 0R
        Me.maincoursebtn.IconVisible = True
        Me.maincoursebtn.IconZoom = 90.0R
        Me.maincoursebtn.IsTab = False
        Me.maincoursebtn.Location = New System.Drawing.Point(-112, 160)
        Me.maincoursebtn.Name = "maincoursebtn"
        Me.maincoursebtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.maincoursebtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.maincoursebtn.OnHoverTextColor = System.Drawing.Color.White
        Me.maincoursebtn.selected = False
        Me.maincoursebtn.Size = New System.Drawing.Size(159, 48)
        Me.maincoursebtn.TabIndex = 3
        Me.maincoursebtn.Text = "Plato Fuerte"
        Me.maincoursebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.maincoursebtn.Textcolor = System.Drawing.Color.White
        Me.maincoursebtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'drinksbtn
        '
        Me.drinksbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.drinksbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.drinksbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.drinksbtn.BorderRadius = 0
        Me.drinksbtn.ButtonText = "Bebidas"
        Me.drinksbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cattransition.SetDecoration(Me.drinksbtn, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.drinksbtn, BunifuAnimatorNS.DecorationType.None)
        Me.drinksbtn.DisabledColor = System.Drawing.Color.Gray
        Me.drinksbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.drinksbtn.Iconimage = Nothing
        Me.drinksbtn.Iconimage_right = CType(resources.GetObject("drinksbtn.Iconimage_right"), System.Drawing.Image)
        Me.drinksbtn.Iconimage_right_Selected = Nothing
        Me.drinksbtn.Iconimage_Selected = Nothing
        Me.drinksbtn.IconMarginLeft = 0
        Me.drinksbtn.IconMarginRight = 0
        Me.drinksbtn.IconRightVisible = True
        Me.drinksbtn.IconRightZoom = 0R
        Me.drinksbtn.IconVisible = True
        Me.drinksbtn.IconZoom = 90.0R
        Me.drinksbtn.IsTab = False
        Me.drinksbtn.Location = New System.Drawing.Point(-112, 220)
        Me.drinksbtn.Name = "drinksbtn"
        Me.drinksbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.drinksbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.drinksbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.drinksbtn.selected = False
        Me.drinksbtn.Size = New System.Drawing.Size(159, 48)
        Me.drinksbtn.TabIndex = 4
        Me.drinksbtn.Text = "Bebidas"
        Me.drinksbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.drinksbtn.Textcolor = System.Drawing.Color.White
        Me.drinksbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dessertsbtn
        '
        Me.dessertsbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dessertsbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.dessertsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dessertsbtn.BorderRadius = 0
        Me.dessertsbtn.ButtonText = "Postres"
        Me.dessertsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cattransition.SetDecoration(Me.dessertsbtn, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.dessertsbtn, BunifuAnimatorNS.DecorationType.None)
        Me.dessertsbtn.DisabledColor = System.Drawing.Color.Gray
        Me.dessertsbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.dessertsbtn.Iconimage = Nothing
        Me.dessertsbtn.Iconimage_right = CType(resources.GetObject("dessertsbtn.Iconimage_right"), System.Drawing.Image)
        Me.dessertsbtn.Iconimage_right_Selected = Nothing
        Me.dessertsbtn.Iconimage_Selected = Nothing
        Me.dessertsbtn.IconMarginLeft = 0
        Me.dessertsbtn.IconMarginRight = 0
        Me.dessertsbtn.IconRightVisible = True
        Me.dessertsbtn.IconRightZoom = 0R
        Me.dessertsbtn.IconVisible = True
        Me.dessertsbtn.IconZoom = 90.0R
        Me.dessertsbtn.IsTab = False
        Me.dessertsbtn.Location = New System.Drawing.Point(-112, 280)
        Me.dessertsbtn.Name = "dessertsbtn"
        Me.dessertsbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.dessertsbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.dessertsbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.dessertsbtn.selected = False
        Me.dessertsbtn.Size = New System.Drawing.Size(159, 48)
        Me.dessertsbtn.TabIndex = 5
        Me.dessertsbtn.Text = "Postres"
        Me.dessertsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dessertsbtn.Textcolor = System.Drawing.Color.White
        Me.dessertsbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'orderbtn
        '
        Me.orderbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.orderbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.orderbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.orderbtn.BorderRadius = 0
        Me.orderbtn.ButtonText = "Pedido"
        Me.orderbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cattransition.SetDecoration(Me.orderbtn, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.orderbtn, BunifuAnimatorNS.DecorationType.None)
        Me.orderbtn.DisabledColor = System.Drawing.Color.Gray
        Me.orderbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.orderbtn.Iconimage = Nothing
        Me.orderbtn.Iconimage_right = CType(resources.GetObject("orderbtn.Iconimage_right"), System.Drawing.Image)
        Me.orderbtn.Iconimage_right_Selected = Nothing
        Me.orderbtn.Iconimage_Selected = Nothing
        Me.orderbtn.IconMarginLeft = 0
        Me.orderbtn.IconMarginRight = 0
        Me.orderbtn.IconRightVisible = True
        Me.orderbtn.IconRightZoom = 0R
        Me.orderbtn.IconVisible = True
        Me.orderbtn.IconZoom = 90.0R
        Me.orderbtn.IsTab = False
        Me.orderbtn.Location = New System.Drawing.Point(-112, 340)
        Me.orderbtn.Name = "orderbtn"
        Me.orderbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.orderbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.orderbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.orderbtn.selected = False
        Me.orderbtn.Size = New System.Drawing.Size(159, 48)
        Me.orderbtn.TabIndex = 6
        Me.orderbtn.Text = "Pedido"
        Me.orderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.orderbtn.Textcolor = System.Drawing.Color.White
        Me.orderbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'homepanel
        '
        Me.homepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.homepanel.Controls.Add(Me.PanelUC)
        Me.cattransition.SetDecoration(Me.homepanel, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.homepanel, BunifuAnimatorNS.DecorationType.None)
        Me.homepanel.Location = New System.Drawing.Point(-2, 0)
        Me.homepanel.Name = "homepanel"
        Me.homepanel.Size = New System.Drawing.Size(49, 450)
        Me.homepanel.TabIndex = 8
        '
        'PanelUC
        '
        Me.cattransition.SetDecoration(Me.PanelUC, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.PanelUC, BunifuAnimatorNS.DecorationType.None)
        Me.PanelUC.Location = New System.Drawing.Point(44, 0)
        Me.PanelUC.Name = "PanelUC"
        Me.PanelUC.Size = New System.Drawing.Size(764, 450)
        Me.PanelUC.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cattransition.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.btnanim.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(-2, 357)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(49, 96)
        Me.Panel3.TabIndex = 9
        '
        'btnanim
        '
        Me.btnanim.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.btnanim.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.btnanim.DefaultAnimation = Animation2
        Me.btnanim.Interval = 15
        '
        'cattransition
        '
        Me.cattransition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.cattransition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.cattransition.DefaultAnimation = Animation1
        '
        'HideTimer
        '
        Me.HideTimer.Enabled = True
        Me.HideTimer.Interval = 500
        '
        'Order1
        '
        Me.Order1.BackColor = System.Drawing.Color.Gainsboro
        Me.btnanim.SetDecoration(Me.Order1, BunifuAnimatorNS.DecorationType.None)
        Me.cattransition.SetDecoration(Me.Order1, BunifuAnimatorNS.DecorationType.None)
        Me.Order1.Location = New System.Drawing.Point(166, 3)
        Me.Order1.Name = "Order1"
        Me.Order1.Size = New System.Drawing.Size(515, 441)
        Me.Order1.TabIndex = 12
        Me.Order1.Visible = False
        '
        'Homehub1
        '
        Me.btnanim.SetDecoration(Me.Homehub1, BunifuAnimatorNS.DecorationType.None)
        Me.cattransition.SetDecoration(Me.Homehub1, BunifuAnimatorNS.DecorationType.None)
        Me.Homehub1.Location = New System.Drawing.Point(45, -2)
        Me.Homehub1.Name = "Homehub1"
        Me.Homehub1.Size = New System.Drawing.Size(774, 453)
        Me.Homehub1.TabIndex = 11
        Me.Homehub1.Visible = False
        '
        'CategoryUC1
        '
        Me.CategoryUC1.AutoScroll = True
        Me.CategoryUC1.CategoryName = ""
        Me.btnanim.SetDecoration(Me.CategoryUC1, BunifuAnimatorNS.DecorationType.None)
        Me.cattransition.SetDecoration(Me.CategoryUC1, BunifuAnimatorNS.DecorationType.None)
        Me.CategoryUC1.Location = New System.Drawing.Point(42, -2)
        Me.CategoryUC1.Name = "CategoryUC1"
        Me.CategoryUC1.Size = New System.Drawing.Size(764, 452)
        Me.CategoryUC1.TabIndex = 10
        '
        'appform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.orderbtn)
        Me.Controls.Add(Me.dessertsbtn)
        Me.Controls.Add(Me.drinksbtn)
        Me.Controls.Add(Me.maincoursebtn)
        Me.Controls.Add(Me.appetizerbtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.homepanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Order1)
        Me.Controls.Add(Me.Homehub1)
        Me.Controls.Add(Me.CategoryUC1)
        Me.btnanim.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.cattransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "appform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.homepanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents homebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents appetizerbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents maincoursebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents drinksbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dessertsbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents orderbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents homepanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cattransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents CategoryUC1 As categoryUC
    Friend WithEvents PanelUC As Panel
    Friend WithEvents Homehub1 As Homehub
    Friend WithEvents Order1 As Order
    Friend WithEvents HideTimer As Timer
    Friend WithEvents btnanim As BunifuAnimatorNS.BunifuTransition
End Class
