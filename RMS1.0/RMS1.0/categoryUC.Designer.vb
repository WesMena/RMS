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
        CType(Me.categoryPhotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryNameLabel
        '
        Me.categoryNameLabel.AutoSize = True
        Me.categoryNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.categoryNameLabel.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.categoryNameLabel.Location = New System.Drawing.Point(289, 1)
        Me.categoryNameLabel.Name = "categoryNameLabel"
        Me.categoryNameLabel.Size = New System.Drawing.Size(149, 36)
        Me.categoryNameLabel.TabIndex = 32
        Me.categoryNameLabel.Text = "Category"
        '
        'categoryPhotoBox
        '
        Me.categoryPhotoBox.Image = CType(resources.GetObject("categoryPhotoBox.Image"), System.Drawing.Image)
        Me.categoryPhotoBox.Location = New System.Drawing.Point(-28, 40)
        Me.categoryPhotoBox.Name = "categoryPhotoBox"
        Me.categoryPhotoBox.Size = New System.Drawing.Size(774, 99)
        Me.categoryPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.categoryPhotoBox.TabIndex = 33
        Me.categoryPhotoBox.TabStop = False
        '
        'categoryUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
End Class
