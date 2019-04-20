<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_s_name
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_s_name))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.paybtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.nameTxt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.givenNlbl = New System.Windows.Forms.Label()
        Me.surnamelbl = New System.Windows.Forms.Label()
        Me.surnameTXT = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'paybtn
        '
        Me.paybtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.paybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.paybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.paybtn.BorderRadius = 0
        Me.paybtn.ButtonText = "CONFIRMAR PEDIDO"
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
        Me.paybtn.Location = New System.Drawing.Point(91, 157)
        Me.paybtn.Name = "paybtn"
        Me.paybtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.paybtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.paybtn.OnHoverTextColor = System.Drawing.Color.White
        Me.paybtn.selected = False
        Me.paybtn.Size = New System.Drawing.Size(286, 48)
        Me.paybtn.TabIndex = 4
        Me.paybtn.Text = "CONFIRMAR PEDIDO"
        Me.paybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.paybtn.Textcolor = System.Drawing.Color.White
        Me.paybtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.namelbl.Location = New System.Drawing.Point(3, 9)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(398, 28)
        Me.namelbl.TabIndex = 5
        Me.namelbl.Text = "INGRESE SU NOMBRE Y APELLIDOS"
        '
        'nameTxt
        '
        Me.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nameTxt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTxt.ForeColor = System.Drawing.Color.White
        Me.nameTxt.HintForeColor = System.Drawing.Color.Empty
        Me.nameTxt.HintText = ""
        Me.nameTxt.isPassword = False
        Me.nameTxt.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.nameTxt.LineIdleColor = System.Drawing.Color.Gray
        Me.nameTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.nameTxt.LineThickness = 4
        Me.nameTxt.Location = New System.Drawing.Point(13, 101)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(197, 38)
        Me.nameTxt.TabIndex = 6
        Me.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'givenNlbl
        '
        Me.givenNlbl.AutoSize = True
        Me.givenNlbl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.givenNlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.givenNlbl.Location = New System.Drawing.Point(58, 71)
        Me.givenNlbl.Name = "givenNlbl"
        Me.givenNlbl.Size = New System.Drawing.Size(89, 23)
        Me.givenNlbl.TabIndex = 7
        Me.givenNlbl.Text = "NOMBRE"
        '
        'surnamelbl
        '
        Me.surnamelbl.AutoSize = True
        Me.surnamelbl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surnamelbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.surnamelbl.Location = New System.Drawing.Point(296, 71)
        Me.surnamelbl.Name = "surnamelbl"
        Me.surnamelbl.Size = New System.Drawing.Size(105, 23)
        Me.surnamelbl.TabIndex = 9
        Me.surnamelbl.Text = "APELLIDOS"
        '
        'surnameTXT
        '
        Me.surnameTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.surnameTXT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surnameTXT.ForeColor = System.Drawing.Color.White
        Me.surnameTXT.HintForeColor = System.Drawing.Color.Empty
        Me.surnameTXT.HintText = ""
        Me.surnameTXT.isPassword = False
        Me.surnameTXT.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.surnameTXT.LineIdleColor = System.Drawing.Color.Gray
        Me.surnameTXT.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.surnameTXT.LineThickness = 4
        Me.surnameTXT.Location = New System.Drawing.Point(243, 101)
        Me.surnameTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.surnameTXT.Name = "surnameTXT"
        Me.surnameTXT.Size = New System.Drawing.Size(197, 38)
        Me.surnameTXT.TabIndex = 8
        Me.surnameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Customer_s_name
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 206)
        Me.Controls.Add(Me.surnamelbl)
        Me.Controls.Add(Me.surnameTXT)
        Me.Controls.Add(Me.givenNlbl)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.paybtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer_s_name"
        Me.Text = "Customer_s_name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents paybtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents surnamelbl As Label
    Friend WithEvents surnameTXT As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents givenNlbl As Label
    Friend WithEvents nameTxt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents namelbl As Label
End Class
