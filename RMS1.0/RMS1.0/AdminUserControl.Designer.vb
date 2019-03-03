<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserControl
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.specialsButton = New System.Windows.Forms.Button()
        Me.appertizersButton = New System.Windows.Forms.Button()
        Me.mainCourseButton = New System.Windows.Forms.Button()
        Me.dessertButton = New System.Windows.Forms.Button()
        Me.drinksButton = New System.Windows.Forms.Button()
        Me.itemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.priceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.specialColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagePathColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.itemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Todos los Items"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'specialsButton
        '
        Me.specialsButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialsButton.Location = New System.Drawing.Point(28, 75)
        Me.specialsButton.Name = "specialsButton"
        Me.specialsButton.Size = New System.Drawing.Size(187, 50)
        Me.specialsButton.TabIndex = 1
        Me.specialsButton.Text = "Items Especiales"
        Me.specialsButton.UseVisualStyleBackColor = True
        '
        'appertizersButton
        '
        Me.appertizersButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appertizersButton.Location = New System.Drawing.Point(28, 131)
        Me.appertizersButton.Name = "appertizersButton"
        Me.appertizersButton.Size = New System.Drawing.Size(187, 50)
        Me.appertizersButton.TabIndex = 2
        Me.appertizersButton.Text = "Items de Entradas"
        Me.appertizersButton.UseVisualStyleBackColor = True
        '
        'mainCourseButton
        '
        Me.mainCourseButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainCourseButton.Location = New System.Drawing.Point(28, 187)
        Me.mainCourseButton.Name = "mainCourseButton"
        Me.mainCourseButton.Size = New System.Drawing.Size(187, 58)
        Me.mainCourseButton.TabIndex = 3
        Me.mainCourseButton.Text = "Items de Plato Fuerte"
        Me.mainCourseButton.UseVisualStyleBackColor = True
        '
        'dessertButton
        '
        Me.dessertButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessertButton.Location = New System.Drawing.Point(28, 251)
        Me.dessertButton.Name = "dessertButton"
        Me.dessertButton.Size = New System.Drawing.Size(187, 58)
        Me.dessertButton.TabIndex = 4
        Me.dessertButton.Text = "Items de Postre"
        Me.dessertButton.UseVisualStyleBackColor = True
        '
        'drinksButton
        '
        Me.drinksButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drinksButton.Location = New System.Drawing.Point(28, 315)
        Me.drinksButton.Name = "drinksButton"
        Me.drinksButton.Size = New System.Drawing.Size(187, 58)
        Me.drinksButton.TabIndex = 5
        Me.drinksButton.Text = "Items de Bebidas"
        Me.drinksButton.UseVisualStyleBackColor = True
        '
        'itemsDataGridView
        '
        Me.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.nameColumn, Me.descriptionColumn, Me.categoryColumn, Me.priceColumn, Me.specialColumn, Me.imagePathColumn})
        Me.itemsDataGridView.Location = New System.Drawing.Point(233, 19)
        Me.itemsDataGridView.Name = "itemsDataGridView"
        Me.itemsDataGridView.ReadOnly = True
        Me.itemsDataGridView.Size = New System.Drawing.Size(644, 354)
        Me.itemsDataGridView.TabIndex = 6
        '
        'idColumn
        '
        Me.idColumn.HeaderText = "idColumn"
        Me.idColumn.Name = "idColumn"
        Me.idColumn.ReadOnly = True
        Me.idColumn.Visible = False
        '
        'nameColumn
        '
        Me.nameColumn.HeaderText = "Nombre"
        Me.nameColumn.Name = "nameColumn"
        Me.nameColumn.ReadOnly = True
        '
        'descriptionColumn
        '
        Me.descriptionColumn.HeaderText = "Descripcion"
        Me.descriptionColumn.Name = "descriptionColumn"
        Me.descriptionColumn.ReadOnly = True
        '
        'categoryColumn
        '
        Me.categoryColumn.HeaderText = "Categoria"
        Me.categoryColumn.Name = "categoryColumn"
        Me.categoryColumn.ReadOnly = True
        '
        'priceColumn
        '
        Me.priceColumn.HeaderText = "Precio"
        Me.priceColumn.Name = "priceColumn"
        Me.priceColumn.ReadOnly = True
        '
        'specialColumn
        '
        Me.specialColumn.HeaderText = "Especial"
        Me.specialColumn.Name = "specialColumn"
        Me.specialColumn.ReadOnly = True
        '
        'imagePathColumn
        '
        Me.imagePathColumn.HeaderText = "Imagen"
        Me.imagePathColumn.Name = "imagePathColumn"
        Me.imagePathColumn.ReadOnly = True
        '
        'AdminUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.itemsDataGridView)
        Me.Controls.Add(Me.drinksButton)
        Me.Controls.Add(Me.dessertButton)
        Me.Controls.Add(Me.mainCourseButton)
        Me.Controls.Add(Me.appertizersButton)
        Me.Controls.Add(Me.specialsButton)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AdminUserControl"
        Me.Size = New System.Drawing.Size(920, 482)
        CType(Me.itemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents specialsButton As Button
    Friend WithEvents appertizersButton As Button
    Friend WithEvents mainCourseButton As Button
    Friend WithEvents dessertButton As Button
    Friend WithEvents drinksButton As Button
    Friend WithEvents itemsDataGridView As DataGridView
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents nameColumn As DataGridViewTextBoxColumn
    Friend WithEvents descriptionColumn As DataGridViewTextBoxColumn
    Friend WithEvents categoryColumn As DataGridViewTextBoxColumn
    Friend WithEvents priceColumn As DataGridViewTextBoxColumn
    Friend WithEvents specialColumn As DataGridViewTextBoxColumn
    Friend WithEvents imagePathColumn As DataGridViewTextBoxColumn
End Class
