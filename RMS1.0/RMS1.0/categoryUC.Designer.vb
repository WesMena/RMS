<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class categoryUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(categoryUC))
        Me.categoryNameLabel = New System.Windows.Forms.Label()
        Me.categoryPhotoBox = New System.Windows.Forms.PictureBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        CType(Me.categoryPhotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryNameLabel
        '
        Me.categoryNameLabel.AutoSize = True
        Me.categoryNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.categoryNameLabel.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.categoryNameLabel.Location = New System.Drawing.Point(268, 1)
        Me.categoryNameLabel.Name = "categoryNameLabel"
        Me.categoryNameLabel.Size = New System.Drawing.Size(149, 36)
        Me.categoryNameLabel.TabIndex = 32
        Me.categoryNameLabel.Text = "Category"
        '
        'categoryPhotoBox
        '
        Me.categoryPhotoBox.Image = CType(resources.GetObject("categoryPhotoBox.Image"), System.Drawing.Image)
        Me.categoryPhotoBox.Location = New System.Drawing.Point(-18, 40)
        Me.categoryPhotoBox.Name = "categoryPhotoBox"
        Me.categoryPhotoBox.Size = New System.Drawing.Size(774, 99)
        Me.categoryPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.categoryPhotoBox.TabIndex = 33
        Me.categoryPhotoBox.TabStop = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(168, 53)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(349, 41)
        Me.SearchTextBox.TabIndex = 37
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(295, 100)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(94, 39)
        Me.SearchButton.TabIndex = 38
        Me.SearchButton.Text = "Buscar"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'categoryUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.categoryNameLabel)
        Me.Controls.Add(Me.categoryPhotoBox)
        Me.Name = "categoryUC"
        Me.Size = New System.Drawing.Size(756, 745)
        CType(Me.categoryPhotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents categoryNameLabel As Label
    Friend WithEvents categoryPhotoBox As PictureBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
End Class
