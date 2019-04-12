<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablenumUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tablenumUC))
        Me.tablenumTXT = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.loadRSmenuBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SuspendLayout()
        '
        'tablenumTXT
        '
        Me.tablenumTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tablenumTXT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablenumTXT.ForeColor = System.Drawing.Color.White
        Me.tablenumTXT.HintForeColor = System.Drawing.Color.Empty
        Me.tablenumTXT.HintText = ""
        Me.tablenumTXT.isPassword = False
        Me.tablenumTXT.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.tablenumTXT.LineIdleColor = System.Drawing.Color.Gray
        Me.tablenumTXT.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.tablenumTXT.LineThickness = 4
        Me.tablenumTXT.Location = New System.Drawing.Point(80, 97)
        Me.tablenumTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.tablenumTXT.Name = "tablenumTXT"
        Me.tablenumTXT.Size = New System.Drawing.Size(214, 31)
        Me.tablenumTXT.TabIndex = 14
        Me.tablenumTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.namelbl.Location = New System.Drawing.Point(20, 33)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(352, 28)
        Me.namelbl.TabIndex = 11
        Me.namelbl.Text = "INGRESE EL NÚMERO DE MESA"
        '
        'loadRSmenuBtn
        '
        Me.loadRSmenuBtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.loadRSmenuBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.loadRSmenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loadRSmenuBtn.BorderRadius = 0
        Me.loadRSmenuBtn.ButtonText = "INGRESAR A RS MENU "
        Me.loadRSmenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadRSmenuBtn.DisabledColor = System.Drawing.Color.Gray
        Me.loadRSmenuBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.loadRSmenuBtn.Iconimage = Nothing
        Me.loadRSmenuBtn.Iconimage_right = CType(resources.GetObject("loadRSmenuBtn.Iconimage_right"), System.Drawing.Image)
        Me.loadRSmenuBtn.Iconimage_right_Selected = Nothing
        Me.loadRSmenuBtn.Iconimage_Selected = Nothing
        Me.loadRSmenuBtn.IconMarginLeft = 0
        Me.loadRSmenuBtn.IconMarginRight = 0
        Me.loadRSmenuBtn.IconRightVisible = True
        Me.loadRSmenuBtn.IconRightZoom = 0R
        Me.loadRSmenuBtn.IconVisible = True
        Me.loadRSmenuBtn.IconZoom = 90.0R
        Me.loadRSmenuBtn.IsTab = False
        Me.loadRSmenuBtn.Location = New System.Drawing.Point(42, 135)
        Me.loadRSmenuBtn.Name = "loadRSmenuBtn"
        Me.loadRSmenuBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.loadRSmenuBtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.loadRSmenuBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.loadRSmenuBtn.selected = False
        Me.loadRSmenuBtn.Size = New System.Drawing.Size(286, 48)
        Me.loadRSmenuBtn.TabIndex = 10
        Me.loadRSmenuBtn.Text = "INGRESAR A RS MENU "
        Me.loadRSmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loadRSmenuBtn.Textcolor = System.Drawing.Color.White
        Me.loadRSmenuBtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'tablenumUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Controls.Add(Me.tablenumTXT)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.loadRSmenuBtn)
        Me.Name = "tablenumUC"
        Me.Size = New System.Drawing.Size(400, 199)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tablenumTXT As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents namelbl As Label
    Friend WithEvents loadRSmenuBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
