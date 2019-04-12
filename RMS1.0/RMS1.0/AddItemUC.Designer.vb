<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItemUC))
        Me.saveAddButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cancelbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.browseFileButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.filenameLabel = New System.Windows.Forms.Label()
        Me.imageLabel = New System.Windows.Forms.Label()
        Me.descRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.specialCheckBox = New System.Windows.Forms.CheckBox()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.categoryLabel = New System.Windows.Forms.Label()
        Me.priceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.saveAddButton.Location = New System.Drawing.Point(415, 267)
        Me.saveAddButton.Name = "saveAddButton"
        Me.saveAddButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.saveAddButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.saveAddButton.OnHoverTextColor = System.Drawing.Color.White
        Me.saveAddButton.selected = False
        Me.saveAddButton.Size = New System.Drawing.Size(201, 48)
        Me.saveAddButton.TabIndex = 31
        Me.saveAddButton.Text = "Guardar"
        Me.saveAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.saveAddButton.Textcolor = System.Drawing.Color.White
        Me.saveAddButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cancelbtn.Location = New System.Drawing.Point(208, 267)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cancelbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cancelbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.cancelbtn.selected = False
        Me.cancelbtn.Size = New System.Drawing.Size(201, 48)
        Me.cancelbtn.TabIndex = 30
        Me.cancelbtn.Text = "Cancelar"
        Me.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelbtn.Textcolor = System.Drawing.Color.White
        Me.cancelbtn.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.browseFileButton.Location = New System.Drawing.Point(1, 267)
        Me.browseFileButton.Name = "browseFileButton"
        Me.browseFileButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.browseFileButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.browseFileButton.OnHoverTextColor = System.Drawing.Color.White
        Me.browseFileButton.selected = False
        Me.browseFileButton.Size = New System.Drawing.Size(201, 48)
        Me.browseFileButton.TabIndex = 29
        Me.browseFileButton.Text = "Seleccionar"
        Me.browseFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browseFileButton.Textcolor = System.Drawing.Color.White
        Me.browseFileButton.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'filenameLabel
        '
        Me.filenameLabel.AutoSize = True
        Me.filenameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameLabel.Location = New System.Drawing.Point(41, 247)
        Me.filenameLabel.Name = "filenameLabel"
        Me.filenameLabel.Size = New System.Drawing.Size(80, 19)
        Me.filenameLabel.TabIndex = 28
        Me.filenameLabel.Text = "filename"
        '
        'imageLabel
        '
        Me.imageLabel.AutoSize = True
        Me.imageLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.imageLabel.Location = New System.Drawing.Point(50, 228)
        Me.imageLabel.Name = "imageLabel"
        Me.imageLabel.Size = New System.Drawing.Size(71, 19)
        Me.imageLabel.TabIndex = 27
        Me.imageLabel.Text = "Imagen"
        '
        'descRichTextBox
        '
        Me.descRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descRichTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descRichTextBox.Location = New System.Drawing.Point(108, 68)
        Me.descRichTextBox.Name = "descRichTextBox"
        Me.descRichTextBox.Size = New System.Drawing.Size(292, 48)
        Me.descRichTextBox.TabIndex = 26
        Me.descRichTextBox.Text = ""
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(108, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(292, 20)
        Me.NameTextBox.TabIndex = 25
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.descLabel.Location = New System.Drawing.Point(178, 46)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(100, 19)
        Me.descLabel.TabIndex = 24
        Me.descLabel.Text = "Descripción"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.nameLabel.Location = New System.Drawing.Point(178, 1)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(73, 19)
        Me.nameLabel.TabIndex = 23
        Me.nameLabel.Text = "Nombre"
        '
        'specialCheckBox
        '
        Me.specialCheckBox.AutoSize = True
        Me.specialCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.specialCheckBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialCheckBox.Location = New System.Drawing.Point(419, 145)
        Me.specialCheckBox.Name = "specialCheckBox"
        Me.specialCheckBox.Size = New System.Drawing.Size(89, 25)
        Me.specialCheckBox.TabIndex = 22
        Me.specialCheckBox.Text = "Especial"
        Me.specialCheckBox.UseVisualStyleBackColor = True
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.priceLabel.Location = New System.Drawing.Point(178, 176)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(57, 19)
        Me.priceLabel.TabIndex = 21
        Me.priceLabel.Text = "Precio"
        '
        'categoryLabel
        '
        Me.categoryLabel.AutoSize = True
        Me.categoryLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.categoryLabel.Location = New System.Drawing.Point(178, 119)
        Me.categoryLabel.Name = "categoryLabel"
        Me.categoryLabel.Size = New System.Drawing.Size(87, 19)
        Me.categoryLabel.TabIndex = 20
        Me.categoryLabel.Text = "Categoria"
        '
        'priceNumericUpDown
        '
        Me.priceNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.priceNumericUpDown.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceNumericUpDown.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.priceNumericUpDown.Location = New System.Drawing.Point(108, 198)
        Me.priceNumericUpDown.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me.priceNumericUpDown.Name = "priceNumericUpDown"
        Me.priceNumericUpDown.Size = New System.Drawing.Size(292, 23)
        Me.priceNumericUpDown.TabIndex = 19
        Me.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'categoryComboBox
        '
        Me.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.categoryComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Items.AddRange(New Object() {"Entrada", "Principal", "Postre", "Bebida"})
        Me.categoryComboBox.Location = New System.Drawing.Point(108, 144)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(292, 29)
        Me.categoryComboBox.TabIndex = 18
        '
        'AddItemUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Name = "AddItemUC"
        Me.Size = New System.Drawing.Size(616, 316)
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents saveAddButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cancelbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents browseFileButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents filenameLabel As Label
    Friend WithEvents imageLabel As Label
    Friend WithEvents descRichTextBox As RichTextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents descLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents specialCheckBox As CheckBox
    Friend WithEvents priceLabel As Label
    Friend WithEvents categoryLabel As Label
    Friend WithEvents priceNumericUpDown As NumericUpDown
    Friend WithEvents categoryComboBox As ComboBox
End Class
