Public Class notification
    Private Sub notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'coordenadas de aparición
        Me.Top = appform.Top
        Me.Left = appform.Left + 500
        Me.Visible = False
        'animación de aparición
        notiftransition.ShowSync(Me)
        'activa el temporizador de desaparición
        disappearTimer.Start()

    End Sub
    Private Sub disappearTimer_tick(sender As Object, e As EventArgs) Handles disappearTimer.Tick
        'quita la notificación 
        Me.Close()
        'para el temporizador
        disappearTimer.Stop()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

    End Sub

    Private Sub itemNameLabel_Click(sender As Object, e As EventArgs) Handles itemNameLabel.Click

    End Sub
End Class