<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notification
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notification))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.successlbl = New System.Windows.Forms.Label()
        Me.notiftransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.disappearTimer = New System.Windows.Forms.Timer(Me.components)
        Me.itemNameLabel = New System.Windows.Forms.Label()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.notiftransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(2, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(71, 74)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox1
        '
        Me.notiftransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(118, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'successlbl
        '
        Me.successlbl.AutoSize = True
        Me.notiftransition.SetDecoration(Me.successlbl, BunifuAnimatorNS.DecorationType.None)
        Me.successlbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.successlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.successlbl.Location = New System.Drawing.Point(91, 52)
        Me.successlbl.Name = "successlbl"
        Me.successlbl.Size = New System.Drawing.Size(183, 19)
        Me.successlbl.TabIndex = 2
        Me.successlbl.Text = "AGREGADO AL PEDIDO"
        '
        'notiftransition
        '
        Me.notiftransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.notiftransition.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.notiftransition.DefaultAnimation = Animation2
        Me.notiftransition.MaxAnimationTime = 250
        '
        'disappearTimer
        '
        Me.disappearTimer.Interval = 750
        '
        'itemNameLabel
        '
        Me.itemNameLabel.AutoSize = True
        Me.notiftransition.SetDecoration(Me.itemNameLabel, BunifuAnimatorNS.DecorationType.None)
        Me.itemNameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.itemNameLabel.Location = New System.Drawing.Point(91, 23)
        Me.itemNameLabel.Name = "itemNameLabel"
        Me.itemNameLabel.Size = New System.Drawing.Size(56, 19)
        Me.itemNameLabel.TabIndex = 3
        Me.itemNameLabel.Text = "name"
        '
        'notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(321, 92)
        Me.Controls.Add(Me.itemNameLabel)
        Me.Controls.Add(Me.successlbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.notiftransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "notification"
        Me.Text = "notification"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents successlbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents notiftransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents disappearTimer As Timer
    Friend WithEvents itemNameLabel As Label
End Class
