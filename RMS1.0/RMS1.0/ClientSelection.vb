Public Class ClientSelection
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "123456" Then
            AdminClient.Show()
            Me.Hide()
        Else
            Label1.Text = "Contraseña Invalida"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        appform.Show()
        Me.Hide()
    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles menumanagerbtn.Click
        If TextBox1.Text = "123456" Then
            AdminClient.Show()
            Me.Hide()
        Else
            wrongpass.Top = 0
            wrongpass.Left = 0
            wrongpass.ShowDialog()


        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles startmenubtn.Click
        appform.Show()

        Me.Hide()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ClientSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class