<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyItemUC
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
        Me.browseFileButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.saveAddButton = New System.Windows.Forms.Button()
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryComboBox
        '
        Me.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.categoryComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Items.AddRange(New Object() {"Entrada", "Principal", "Postre", "Bebida"})
        Me.categoryComboBox.Location = New System.Drawing.Point(225, 217)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(198, 29)
        Me.categoryComboBox.TabIndex = 0
        '
        'priceNumericUpDown
        '
        Me.priceNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.priceNumericUpDown.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceNumericUpDown.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.priceNumericUpDown.Location = New System.Drawing.Point(225, 297)
        Me.priceNumericUpDown.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me.priceNumericUpDown.Name = "priceNumericUpDown"
        Me.priceNumericUpDown.Size = New System.Drawing.Size(198, 23)
        Me.priceNumericUpDown.TabIndex = 1
        Me.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'categoryLabel
        '
        Me.categoryLabel.AutoSize = True
        Me.categoryLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryLabel.Location = New System.Drawing.Point(271, 191)
        Me.categoryLabel.Name = "categoryLabel"
        Me.categoryLabel.Size = New System.Drawing.Size(87, 19)
        Me.categoryLabel.TabIndex = 3
        Me.categoryLabel.Text = "Categoria"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.Location = New System.Drawing.Point(288, 260)
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
        Me.specialCheckBox.Location = New System.Drawing.Point(275, 340)
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
        Me.nameLabel.Location = New System.Drawing.Point(282, 20)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(73, 19)
        Me.nameLabel.TabIndex = 6
        Me.nameLabel.Text = "Nombre"
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descLabel.Location = New System.Drawing.Point(265, 84)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(100, 19)
        Me.descLabel.TabIndex = 7
        Me.descLabel.Text = "Descripción"
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(225, 46)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(198, 20)
        Me.NameTextBox.TabIndex = 8
        '
        'descRichTextBox
        '
        Me.descRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descRichTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descRichTextBox.Location = New System.Drawing.Point(225, 110)
        Me.descRichTextBox.Name = "descRichTextBox"
        Me.descRichTextBox.Size = New System.Drawing.Size(198, 66)
        Me.descRichTextBox.TabIndex = 9
        Me.descRichTextBox.Text = ""
        '
        'imageLabel
        '
        Me.imageLabel.AutoSize = True
        Me.imageLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imageLabel.Location = New System.Drawing.Point(282, 383)
        Me.imageLabel.Name = "imageLabel"
        Me.imageLabel.Size = New System.Drawing.Size(71, 19)
        Me.imageLabel.TabIndex = 10
        Me.imageLabel.Text = "Imagen"
        '
        'filenameLabel
        '
        Me.filenameLabel.AutoSize = True
        Me.filenameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameLabel.Location = New System.Drawing.Point(278, 416)
        Me.filenameLabel.Name = "filenameLabel"
        Me.filenameLabel.Size = New System.Drawing.Size(80, 19)
        Me.filenameLabel.TabIndex = 11
        Me.filenameLabel.Text = "filename"
        '
        'browseFileButton
        '
        Me.browseFileButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browseFileButton.Location = New System.Drawing.Point(254, 438)
        Me.browseFileButton.Name = "browseFileButton"
        Me.browseFileButton.Size = New System.Drawing.Size(131, 39)
        Me.browseFileButton.TabIndex = 12
        Me.browseFileButton.Text = "Seleccionar"
        Me.browseFileButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(151, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 39)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'saveAddButton
        '
        Me.saveAddButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveAddButton.Location = New System.Drawing.Point(324, 513)
        Me.saveAddButton.Name = "saveAddButton"
        Me.saveAddButton.Size = New System.Drawing.Size(131, 39)
        Me.saveAddButton.TabIndex = 14
        Me.saveAddButton.Text = "Guardar"
        Me.saveAddButton.UseVisualStyleBackColor = True
        '
        'ModifyItemUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.saveAddButton)
        Me.Controls.Add(Me.Button1)
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
        Me.Size = New System.Drawing.Size(643, 616)
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
    Friend WithEvents browseFileButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents saveAddButton As Button
End Class
