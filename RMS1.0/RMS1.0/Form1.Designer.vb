<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.homebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.appetizerbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.maincoursebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.drinksbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dessertsbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.orderbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnanim = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.UserControl11 = New RMS1._0.UserControl1()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnanim.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(43, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 17)
        Me.Panel1.TabIndex = 0
        '
        'homebtn
        '
        Me.homebtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homebtn.BorderRadius = 0
        Me.homebtn.ButtonText = "Inicio"
        Me.homebtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.homebtn.Location = New System.Drawing.Point(-112, 91)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.homebtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.appetizerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.appetizerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.appetizerbtn.BorderRadius = 0
        Me.appetizerbtn.ButtonText = "Entradas"
        Me.appetizerbtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.appetizerbtn.Location = New System.Drawing.Point(-112, 134)
        Me.appetizerbtn.Name = "appetizerbtn"
        Me.appetizerbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.appetizerbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.maincoursebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.maincoursebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.maincoursebtn.BorderRadius = 0
        Me.maincoursebtn.ButtonText = "Plato Fuerte"
        Me.maincoursebtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.maincoursebtn.Location = New System.Drawing.Point(-112, 179)
        Me.maincoursebtn.Name = "maincoursebtn"
        Me.maincoursebtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.maincoursebtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.drinksbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.drinksbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.drinksbtn.BorderRadius = 0
        Me.drinksbtn.ButtonText = "Bebidas"
        Me.drinksbtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.drinksbtn.Location = New System.Drawing.Point(-112, 224)
        Me.drinksbtn.Name = "drinksbtn"
        Me.drinksbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.drinksbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.dessertsbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dessertsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dessertsbtn.BorderRadius = 0
        Me.dessertsbtn.ButtonText = "Postres"
        Me.dessertsbtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.dessertsbtn.Location = New System.Drawing.Point(-112, 269)
        Me.dessertsbtn.Name = "dessertsbtn"
        Me.dessertsbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dessertsbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
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
        Me.orderbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.orderbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.orderbtn.BorderRadius = 0
        Me.orderbtn.ButtonText = "Pedido"
        Me.orderbtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.orderbtn.Location = New System.Drawing.Point(-112, 313)
        Me.orderbtn.Name = "orderbtn"
        Me.orderbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.orderbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.orderbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.orderbtn.selected = False
        Me.orderbtn.Size = New System.Drawing.Size(159, 48)
        Me.orderbtn.TabIndex = 6
        Me.orderbtn.Text = "Pedido"
        Me.orderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.orderbtn.Textcolor = System.Drawing.Color.White
        Me.orderbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnanim.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(-2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(49, 96)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
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
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
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
        Me.btnanim.DefaultAnimation = Animation1
        '
        'UserControl11
        '
        Me.btnanim.SetDecoration(Me.UserControl11, BunifuAnimatorNS.DecorationType.None)
        Me.UserControl11.Location = New System.Drawing.Point(100, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(774, 453)
        Me.UserControl11.TabIndex = 10
        '
        'Form1
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
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserControl11)
        Me.btnanim.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents homebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents appetizerbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents maincoursebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents drinksbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dessertsbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents orderbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnanim As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents UserControl11 As UserControl1
End Class
