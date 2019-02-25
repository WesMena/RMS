Public Class ClientSelection
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123456" Then
            AdminClient.Show()
            Me.Hide()
        Else
            Label1.Text = "Contraseña Invalida"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        appform.Show()
        Me.Hide()
    End Sub
End Class