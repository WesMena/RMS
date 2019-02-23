<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homehub
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homehub))
        Me.currentplusbtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.currentminusbtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.hhubtransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Homescreen21 = New RMS1._0.homescreen2()
        Me.Homescreen31 = New RMS1._0.homescreen3()
        Me.Homescreen11 = New RMS1._0.homescreen1()
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
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.hhubtransition.DefaultAnimation = Animation1
        '
        'Homescreen21
        '
        Me.hhubtransition.SetDecoration(Me.Homescreen21, BunifuAnimatorNS.DecorationType.None)
        Me.Homescreen21.Location = New System.Drawing.Point(0, 0)
        Me.Homescreen21.Name = "Homescreen21"
        Me.Homescreen21.Size = New System.Drawing.Size(774, 453)
        Me.Homescreen21.TabIndex = 1
        '
        'Homescreen31
        '
        Me.hhubtransition.SetDecoration(Me.Homescreen31, BunifuAnimatorNS.DecorationType.None)
        Me.Homescreen31.Location = New System.Drawing.Point(3, 0)
        Me.Homescreen31.Name = "Homescreen31"
        Me.Homescreen31.Size = New System.Drawing.Size(774, 453)
        Me.Homescreen31.TabIndex = 0
        '
        'Homescreen11
        '
        Me.hhubtransition.SetDecoration(Me.Homescreen11, BunifuAnimatorNS.DecorationType.None)
        Me.Homescreen11.Location = New System.Drawing.Point(3, 3)
        Me.Homescreen11.Name = "Homescreen11"
        Me.Homescreen11.Size = New System.Drawing.Size(774, 453)
        Me.Homescreen11.TabIndex = 5
        '
        'homehub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.currentplusbtn)
        Me.Controls.Add(Me.currentminusbtn)
        Me.Controls.Add(Me.Homescreen21)
        Me.Controls.Add(Me.Homescreen31)
        Me.Controls.Add(Me.Homescreen11)
        Me.hhubtransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "homehub"
        Me.Size = New System.Drawing.Size(774, 453)
        CType(Me.currentplusbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentminusbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Homescreen31 As homescreen3
    Friend WithEvents Homescreen21 As homescreen2
    Friend WithEvents currentplusbtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents currentminusbtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents hhubtransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Homescreen11 As homescreen1
End Class
