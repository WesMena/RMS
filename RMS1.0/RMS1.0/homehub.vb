Public Class homehub
    Public Shared current As Integer

    Private Sub homehub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Homescreen11.BringToFront()
        current = 1
        currentminusbtn.BringToFront()
        currentplusbtn.BringToFront()

    End Sub

    Private Sub currentplusbtn_Click(sender As Object, e As EventArgs) Handles currentplusbtn.Click
        current = current + 1
        If current > 3 Then
            current = 1
        End If
        currentscreen()

    End Sub

    Private Sub currentminusbtn_Click(sender As Object, e As EventArgs) Handles currentminusbtn.Click
        current = current - 1
        If current < 1 Then
            current = 3
        End If
        currentscreen()
    End Sub


    Private Sub Homescreen11_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Homescreen11_Load_1(sender As Object, e As EventArgs) Handles Homescreen11.Load

    End Sub

    Private Sub Homescreen21_Load(sender As Object, e As EventArgs) Handles Homescreen21.Load

    End Sub
End Class
