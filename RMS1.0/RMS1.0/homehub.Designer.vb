<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homehub
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homehub))
        Me.currentplusbtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.currentminusbtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.hhubtransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SpecialsUserControl = New RMS1._0.SpecialsUC()
        Me.OrderButton = New System.Windows.Forms.Button()
        CType(Me.currentplusbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentminusbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentplusbtn
        '
        Me.currentplusbtn.BackColor = System.Drawing.Color.Transparent
        Me.hhubtransition.SetDecoration(Me.currentplusbtn, BunifuAnimatorNS.DecorationType.None)
        Me.currentplusbtn.Image = CType(resources.GetObject("currentplusbtn.Image"), System.Drawing.Image)
        Me.currentplusbtn.ImageActive = Nothing
        Me.currentplusbtn.Location = New System.Drawing.Point(700, 175)
        Me.currentplusbtn.Name = "currentplusbtn"
        Me.currentplusbtn.Size = New System.Drawing.Size(71, 71)
        Me.currentplusbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.currentplusbtn.TabIndex = 3
        Me.currentplusbtn.TabStop = False
        Me.currentplusbtn.Zoom = 10
        '
        'currentminusbtn
        '
        Me.currentminusbtn.BackColor = System.Drawing.Color.Transparent
        Me.hhubtransition.SetDecoration(Me.currentminusbtn, BunifuAnimatorNS.DecorationType.None)
        Me.currentminusbtn.Image = CType(resources.GetObject("currentminusbtn.Image"), System.Drawing.Image)
        Me.currentminusbtn.ImageActive = Nothing
        Me.currentminusbtn.Location = New System.Drawing.Point(3, 175)
        Me.currentminusbtn.Name = "currentminusbtn"
        Me.currentminusbtn.Size = New System.Drawing.Size(71, 71)
        Me.currentminusbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.currentminusbtn.TabIndex = 4
        Me.currentminusbtn.TabStop = False
        Me.currentminusbtn.Zoom = 10
        '
        'hhubtransition
        '
        Me.hhubtransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.hhubtransition.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.hhubtransition.DefaultAnimation = Animation2
        '
        'SpecialsUserControl
        '
        Me.SpecialsUserControl.BackColor = System.Drawing.Color.White
        Me.hhubtransition.SetDecoration(Me.SpecialsUserControl, BunifuAnimatorNS.DecorationType.None)
        Me.SpecialsUserControl.Location = New System.Drawing.Point(0, 0)
        Me.SpecialsUserControl.Name = "SpecialsUserControl"
        Me.SpecialsUserControl.Size = New System.Drawing.Size(774, 453)
        Me.SpecialsUserControl.TabIndex = 5
        '
        'OrderButton
        '
        Me.OrderButton.BackColor = System.Drawing.Color.PaleVioletRed
        Me.hhubtransition.SetDecoration(Me.OrderButton, BunifuAnimatorNS.DecorationType.None)
        Me.OrderButton.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OrderButton.Location = New System.Drawing.Point(111, 308)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(239, 39)
        Me.OrderButton.TabIndex = 6
        Me.OrderButton.Text = "Ordenar"
        Me.OrderButton.UseVisualStyleBackColor = False
        '
        'Homehub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.currentplusbtn)
        Me.Controls.Add(Me.currentminusbtn)
        Me.Controls.Add(Me.SpecialsUserControl)
        Me.hhubtransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "Homehub"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.currentplusbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentminusbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents currentplusbtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents currentminusbtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents hhubtransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents SpecialsUserControl As SpecialsUC
    Friend WithEvents OrderButton As Button
End Class
