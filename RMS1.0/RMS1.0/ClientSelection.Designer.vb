<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientSelection))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientFormDragctrl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.menumanagerbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.startmenubtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(283, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 3
        '
        'ClientFormDragctrl
        '
        Me.ClientFormDragctrl.Fixed = True
        Me.ClientFormDragctrl.Horizontal = True
        Me.ClientFormDragctrl.TargetControl = Nothing
        Me.ClientFormDragctrl.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'menumanagerbtn
        '
        Me.menumanagerbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.menumanagerbtn.AutoSize = True
        Me.menumanagerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.menumanagerbtn.BackgroundImage = CType(resources.GetObject("menumanagerbtn.BackgroundImage"), System.Drawing.Image)
        Me.menumanagerbtn.BorderRadius = 0
        Me.menumanagerbtn.ButtonText = "Administrar Menú"
        Me.menumanagerbtn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.menumanagerbtn.DisabledColor = System.Drawing.Color.Gray
        Me.menumanagerbtn.Font = New System.Drawing.Font("Century", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menumanagerbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.menumanagerbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.menumanagerbtn.Iconimage = Nothing
        Me.menumanagerbtn.Iconimage_right = Nothing
        Me.menumanagerbtn.Iconimage_right_Selected = Nothing
        Me.menumanagerbtn.Iconimage_Selected = Nothing
        Me.menumanagerbtn.IconMarginLeft = 0
        Me.menumanagerbtn.IconMarginRight = 0
        Me.menumanagerbtn.IconRightVisible = True
        Me.menumanagerbtn.IconRightZoom = 0R
        Me.menumanagerbtn.IconVisible = True
        Me.menumanagerbtn.IconZoom = 90.0R
        Me.menumanagerbtn.IsTab = False
        Me.menumanagerbtn.Location = New System.Drawing.Point(-21, 0)
        Me.menumanagerbtn.Name = "menumanagerbtn"
        Me.menumanagerbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.menumanagerbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.menumanagerbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.menumanagerbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.menumanagerbtn.selected = False
        Me.menumanagerbtn.Size = New System.Drawing.Size(586, 458)
        Me.menumanagerbtn.TabIndex = 4
        Me.menumanagerbtn.Text = "Administrar Menú"
        Me.menumanagerbtn.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.menumanagerbtn.Textcolor = System.Drawing.Color.White
        Me.menumanagerbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'startmenubtn
        '
        Me.startmenubtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.startmenubtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.startmenubtn.BackgroundImage = CType(resources.GetObject("startmenubtn.BackgroundImage"), System.Drawing.Image)
        Me.startmenubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.startmenubtn.BorderRadius = 0
        Me.startmenubtn.ButtonText = "Iniciar Menú"
        Me.startmenubtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startmenubtn.DisabledColor = System.Drawing.Color.Gray
        Me.startmenubtn.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startmenubtn.Iconcolor = System.Drawing.Color.Transparent
        Me.startmenubtn.Iconimage = Nothing
        Me.startmenubtn.Iconimage_right = Nothing
        Me.startmenubtn.Iconimage_right_Selected = Nothing
        Me.startmenubtn.Iconimage_Selected = Nothing
        Me.startmenubtn.IconMarginLeft = 0
        Me.startmenubtn.IconMarginRight = 0
        Me.startmenubtn.IconRightVisible = True
        Me.startmenubtn.IconRightZoom = 0R
        Me.startmenubtn.IconVisible = True
        Me.startmenubtn.IconZoom = 90.0R
        Me.startmenubtn.IsTab = False
        Me.startmenubtn.Location = New System.Drawing.Point(403, 0)
        Me.startmenubtn.Name = "startmenubtn"
        Me.startmenubtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.startmenubtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.startmenubtn.OnHoverTextColor = System.Drawing.Color.White
        Me.startmenubtn.selected = False
        Me.startmenubtn.Size = New System.Drawing.Size(410, 458)
        Me.startmenubtn.TabIndex = 5
        Me.startmenubtn.Text = "Iniciar Menú"
        Me.startmenubtn.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.startmenubtn.Textcolor = System.Drawing.Color.White
        Me.startmenubtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'Textbox1
        '
        Me.Textbox1.BorderColorFocused = System.Drawing.Color.Transparent
        Me.Textbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.Textbox1.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.Textbox1.BorderThickness = 3
        Me.Textbox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Textbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Textbox1.isPassword = True
        Me.Textbox1.Location = New System.Drawing.Point(13, 269)
        Me.Textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(370, 44)
        Me.Textbox1.TabIndex = 9
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.Textbox1
        '
        'ClientSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.startmenubtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menumanagerbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClientSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents menumanagerbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents startmenubtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ClientFormDragctrl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
End Class
