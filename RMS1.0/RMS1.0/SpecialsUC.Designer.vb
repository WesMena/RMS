<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecialsUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecialsUC))
        Me.itemDescriptionLabel = New System.Windows.Forms.Label()
        Me.itemNameLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.itemPhotoBox = New System.Windows.Forms.PictureBox()
        CType(Me.itemPhotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemDescriptionLabel
        '
        Me.itemDescriptionLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemDescriptionLabel.ForeColor = System.Drawing.Color.Black
        Me.itemDescriptionLabel.Location = New System.Drawing.Point(107, 225)
        Me.itemDescriptionLabel.Name = "itemDescriptionLabel"
        Me.itemDescriptionLabel.Size = New System.Drawing.Size(276, 74)
        Me.itemDescriptionLabel.TabIndex = 16
        Me.itemDescriptionLabel.Text = "Ojo de bife asado con hongos, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "romero y soya." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.itemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemNameLabel
        '
        Me.itemNameLabel.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemNameLabel.ForeColor = System.Drawing.Color.Black
        Me.itemNameLabel.Location = New System.Drawing.Point(104, 184)
        Me.itemNameLabel.Name = "itemNameLabel"
        Me.itemNameLabel.Size = New System.Drawing.Size(279, 41)
        Me.itemNameLabel.TabIndex = 15
        Me.itemNameLabel.Text = "Roast Beef "
        Me.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(254, 22)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(214, 36)
        Me.titleLabel.TabIndex = 14
        Me.titleLabel.Text = "PLATO DEL DÍA"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.priceLabel.Location = New System.Drawing.Point(73, 76)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(331, 108)
        Me.priceLabel.TabIndex = 13
        Me.priceLabel.Text = "₡5500"
        '
        'itemPhotoBox
        '
        Me.itemPhotoBox.Image = CType(resources.GetObject("itemPhotoBox.Image"), System.Drawing.Image)
        Me.itemPhotoBox.Location = New System.Drawing.Point(379, 92)
        Me.itemPhotoBox.Name = "itemPhotoBox"
        Me.itemPhotoBox.Size = New System.Drawing.Size(328, 267)
        Me.itemPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.itemPhotoBox.TabIndex = 18
        Me.itemPhotoBox.TabStop = False
        '
        'SpecialsUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.itemDescriptionLabel)
        Me.Controls.Add(Me.itemNameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.itemPhotoBox)
        Me.Name = "SpecialsUC"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.itemPhotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents itemDescriptionLabel As Label
    Friend WithEvents itemNameLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents itemPhotoBox As PictureBox
End Class
