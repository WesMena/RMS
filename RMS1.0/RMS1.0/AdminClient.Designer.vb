<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminClient
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
        Me.addItemButton = New System.Windows.Forms.Button()
        Me.modifyItemButton = New System.Windows.Forms.Button()
        Me.modifyitem = New RMS1._0.ModifyItemUC()
        Me.AdminUserControl1 = New RMS1._0.AdminUserControl()
        Me.SuspendLayout()
        '
        'addItemButton
        '
        Me.addItemButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addItemButton.Location = New System.Drawing.Point(690, 397)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(187, 50)
        Me.addItemButton.TabIndex = 5
        Me.addItemButton.Text = "Agregar Item"
        Me.addItemButton.UseVisualStyleBackColor = True
        '
        'modifyItemButton
        '
        Me.modifyItemButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifyItemButton.Location = New System.Drawing.Point(463, 397)
        Me.modifyItemButton.Name = "modifyItemButton"
        Me.modifyItemButton.Size = New System.Drawing.Size(187, 50)
        Me.modifyItemButton.TabIndex = 3
        Me.modifyItemButton.Text = "Modificar Item"
        Me.modifyItemButton.UseVisualStyleBackColor = True
        '
        'modifyitem
        '
        Me.modifyitem.Category = Nothing
        Me.modifyitem.Description = Nothing
        Me.modifyitem.Id = 0
        Me.modifyitem.Imagepath = Nothing
        Me.modifyitem.IsUpdate = False
        Me.modifyitem.ItemName = Nothing
        Me.modifyitem.Location = New System.Drawing.Point(1, -1)
        Me.modifyitem.Name = "modifyitem"
        Me.modifyitem.Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.modifyitem.Size = New System.Drawing.Size(934, 616)
        Me.modifyitem.Special = False
        Me.modifyitem.TabIndex = 6
        Me.modifyitem.Visible = False
        '
        'AdminUserControl1
        '
        Me.AdminUserControl1.Location = New System.Drawing.Point(1, -1)
        Me.AdminUserControl1.Name = "AdminUserControl1"
        Me.AdminUserControl1.Size = New System.Drawing.Size(934, 483)
        Me.AdminUserControl1.TabIndex = 0
        '
        'AdminClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(936, 479)
        Me.Controls.Add(Me.modifyitem)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.modifyItemButton)
        Me.Controls.Add(Me.AdminUserControl1)
        Me.Name = "AdminClient"
        Me.Text = "AdminClient"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminUserControl1 As AdminUserControl
    Friend WithEvents addItemButton As Button
    Friend WithEvents modifyItemButton As Button
    Friend WithEvents modifyitem As ModifyItemUC
End Class
