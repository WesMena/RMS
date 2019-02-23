Public Class notification
    Private Sub notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'coordenadas de aparición
        Me.Top = appform.Top - 120
        Me.Left = appform.Left + 600
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
End Class