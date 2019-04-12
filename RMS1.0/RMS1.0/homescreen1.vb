Public Class homescreen1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles justlbl.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles itempicpb.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub homescreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub orderlbl_Click(sender As Object, e As EventArgs) Handles orderlbl.Click
        notification.StartPosition = FormStartPosition.Manual
        notification.Location = New Point(750, 160)
        notification.ShowDialog()

    End Sub
End Class
