Imports System.ComponentModel

Public Class AdminClient
    Private Sub AdminClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdminClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClientSelection.Show()
    End Sub
End Class