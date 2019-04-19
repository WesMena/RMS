<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyItemUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyItemUC))
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        Me.priceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.categoryLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.specialCheckBox = New System.Windows.Forms.CheckBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.descRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.imageLabel = New System.Windows.Forms.Label()
        Me.filenameLabel = New System.Windows.Forms.Label()
        Me.browseFileButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cancelbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.saveAddButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Espdesctxt = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryComboBox
        '
        Me.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.categoryComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Items.AddRange(New Object() {"Entrada", "Principal", "Postre", "Bebida"})
        Me.categoryComboBox.Location = New System.Drawing.Point(131, 163)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(292, 29)
        Me.categoryComboBox.TabIndex = 0
        '
        'priceNumericUpDown
        '
        Me.priceNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.priceNumericUpDown.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceNumericUpDown.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.priceNumericUpDown.Location = New System.Drawing.Point(131, 217)
        Me.priceNumericUpDown.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me.priceNumericUpDown.Name = "priceNumericUpDown"
        Me.priceNumericUpDown.Size = New System.Drawing.Size(292, 23)
        Me.priceNumericUpDown.TabIndex = 1
        Me.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'categoryLabel
        '
        Me.categoryLabel.AutoSize = True
        Me.categoryLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.categoryLabel.Location = New System.Drawing.Point(201, 138)
        Me.categoryLabel.Name = "categoryLabel"
        Me.categoryLabel.Size = New System.Drawing.Size(87, 19)
        Me.categoryLabel.TabIndex = 3
        Me.categoryLabel.Text = "Categoria"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.priceLabel.Location = New System.Drawing.Point(201, 195)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(57, 19)
        Me.priceLabel.TabIndex = 4
        Me.priceLabel.Text = "Precio"
        '
        'specialCheckBox
        '
        Me.specialCheckBox.AutoSize = True
        Me.specialCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.specialCheckBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialCheckBox.Location = New System.Drawing.Point(442, 164)
        Me.specialCheckBox.Name = "specialCheckBox"
        Me.specialCheckBox.Size = New System.Drawing.Size(89, 25)
        Me.specialCheckBox.TabIndex = 5
        Me.specialCheckBox.Text = "Especial"
        Me.specialCheckBox.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.nameLabel.Location = New System.Drawing.Point(201, 20)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(73, 19)
        Me.nameLabel.TabIndex = 6
        Me.nameLabel.Text = "Nombre"
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.descLabel.Location = New System.Drawing.Point(73, 65)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(173, 19)
        Me.descLabel.TabIndex = 7
        Me.descLabel.Text = "Descripción en inglés"
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(131, 42)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(292, 20)
        Me.NameTextBox.TabIndex = 8
        '
        'descRichTextBox
        '
        Me.descRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descRichTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descRichTextBox.Location = New System.Drawing.Point(33, 87)
        Me.descRichTextBox.Name = "descRichTextBox"
        Me.descRichTextBox.Size = New System.Drawing.Size(292, 48)
        Me.descRichTextBox.TabIndex = 9
        Me.descRichTextBox.Text = ""
        '
        'imageLabel
        '
        Me.imageLabel.AutoSize = True
        Me.imageLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.imageLabel.Location = New System.Drawing.Point(73, 247)
        Me.imageLabel.Name = "imageLabel"
        Me.imageLabel.Size = New System.Drawing.Size(71, 19)
        Me.imageLabel.TabIndex = 10
        Me.imageLabel.Text = "Imagen"
        '
        'filenameLabel
        '
        Me.filenameLabel.AutoSize = True
        Me.filenameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameLabel.Location = New System.Drawing.Point(64, 266)
        Me.filenameLabel.Name = "filenameLabel"
        Me.filenameLabel.Size = New System.Drawing.Size(80, 19)
        Me.filenameLabel.TabIndex = 11
        Me.filenameLabel.Text = "filename"
        '
        'browseFileButton
        '
        Me.browseFileButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.browseFileButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.browseFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.browseFileButton.BorderRadius = 0
        Me.browseFileButton.ButtonText = "Seleccionar"
        Me.browseFileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.browseFileButton.DisabledColor = System.Drawing.Color.Gray
        Me.browseFileButton.Iconcolor = System.Drawing.Color.Transparent
        Me.browseFileButton.Iconimage = Nothing
        Me.browseFileButton.Iconimage_right = CType(resources.GetObject("browseFileButton.Iconimage_right"), System.Drawing.Image)
        Me.browseFileButton.Iconimage_right_Selected = Nothing
        Me.browseFileButton.Iconimage_Selected = Nothing
        Me.browseFileButton.IconMarginLeft = 0
        Me.browseFileButton.IconMarginRight = 0
        Me.browseFileButton.IconRightVisible = True
        Me.browseFileButton.IconRightZoom = 0R
        Me.browseFileButton.IconVisible = True
        Me.browseFileButton.IconZoom = 90.0R
        Me.browseFileButton.IsTab = False
        Me.browseFileButton.Location = New System.Drawing.Point(24, 286)
        Me.browseFileButton.Name = "browseFileButton"
        Me.browseFileButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.browseFileButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.browseFileButton.OnHoverTextColor = System.Drawing.Color.White
        Me.browseFileButton.selected = False
        Me.browseFileButton.Size = New System.Drawing.Size(201, 48)
        Me.browseFileButton.TabIndex = 15
        Me.browseFileButton.Text = "Seleccionar"
        Me.browseFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browseFileButton.Textcolor = System.Drawing.Color.White
        Me.browseFileButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cancelbtn
        '
        Me.cancelbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelbtn.BorderRadius = 0
        Me.cancelbtn.ButtonText = "Cancelar"
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.DisabledColor = System.Drawing.Color.Gray
        Me.cancelbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.cancelbtn.Iconimage = Nothing
        Me.cancelbtn.Iconimage_right = CType(resources.GetObject("cancelbtn.Iconimage_right"), System.Drawing.Image)
        Me.cancelbtn.Iconimage_right_Selected = Nothing
        Me.cancelbtn.Iconimage_Selected = Nothing
        Me.cancelbtn.IconMarginLeft = 0
        Me.cancelbtn.IconMarginRight = 0
        Me.cancelbtn.IconRightVisible = True
        Me.cancelbtn.IconRightZoom = 0R
        Me.cancelbtn.IconVisible = True
        Me.cancelbtn.IconZoom = 90.0R
        Me.cancelbtn.IsTab = False
        Me.cancelbtn.Location = New System.Drawing.Point(231, 286)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cancelbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cancelbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.cancelbtn.selected = False
        Me.cancelbtn.Size = New System.Drawing.Size(201, 48)
        Me.cancelbtn.TabIndex = 16
        Me.cancelbtn.Text = "Cancelar"
        Me.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelbtn.Textcolor = System.Drawing.Color.White
        Me.cancelbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'saveAddButton
        '
        Me.saveAddButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.saveAddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.saveAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.saveAddButton.BorderRadius = 0
        Me.saveAddButton.ButtonText = "Guardar"
        Me.saveAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveAddButton.DisabledColor = System.Drawing.Color.Gray
        Me.saveAddButton.Iconcolor = System.Drawing.Color.Transparent
        Me.saveAddButton.Iconimage = Nothing
        Me.saveAddButton.Iconimage_right = CType(resources.GetObject("saveAddButton.Iconimage_right"), System.Drawing.Image)
        Me.saveAddButton.Iconimage_right_Selected = Nothing
        Me.saveAddButton.Iconimage_Selected = Nothing
        Me.saveAddButton.IconMarginLeft = 0
        Me.saveAddButton.IconMarginRight = 0
        Me.saveAddButton.IconRightVisible = True
        Me.saveAddButton.IconRightZoom = 0R
        Me.saveAddButton.IconVisible = True
        Me.saveAddButton.IconZoom = 90.0R
        Me.saveAddButton.IsTab = False
        Me.saveAddButton.Location = New System.Drawing.Point(438, 286)
        Me.saveAddButton.Name = "saveAddButton"
        Me.saveAddButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.saveAddButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.saveAddButton.OnHoverTextColor = System.Drawing.Color.White
        Me.saveAddButton.selected = False
        Me.saveAddButton.Size = New System.Drawing.Size(201, 48)
        Me.saveAddButton.TabIndex = 17
        Me.saveAddButton.Text = "Guardar"
        Me.saveAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.saveAddButton.Textcolor = System.Drawing.Color.White
        Me.saveAddButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Espdesctxt
        '
        Me.Espdesctxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Espdesctxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Espdesctxt.Location = New System.Drawing.Point(347, 87)
        Me.Espdesctxt.Name = "Espdesctxt"
        Me.Espdesctxt.Size = New System.Drawing.Size(292, 48)
        Me.Espdesctxt.TabIndex = 18
        Me.Espdesctxt.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(400, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Descripción en español"
        '
        'ModifyItemUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Espdesctxt)
        Me.Controls.Add(Me.saveAddButton)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.browseFileButton)
        Me.Controls.Add(Me.filenameLabel)
        Me.Controls.Add(Me.imageLabel)
        Me.Controls.Add(Me.descRichTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.specialCheckBox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.categoryLabel)
        Me.Controls.Add(Me.priceNumericUpDown)
        Me.Controls.Add(Me.categoryComboBox)
        Me.Name = "ModifyItemUC"
        Me.Size = New System.Drawing.Size(643, 342)
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents categoryComboBox As ComboBox
    Friend WithEvents priceNumericUpDown As NumericUpDown
    Friend WithEvents categoryLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents specialCheckBox As CheckBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents descLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents descRichTextBox As RichTextBox
    Friend WithEvents imageLabel As Label
    Friend WithEvents filenameLabel As Label
    Friend WithEvents browseFileButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cancelbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents saveAddButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Espdesctxt As RichTextBox
    Friend WithEvents Label1 As Label
End Class
