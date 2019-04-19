Public Class AddItemUC

    Public Shared itemname, description, category, imagepath As String

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs)
        Me.Visible = False

    End Sub

    Private Sub browseFileButton_Click(sender As Object, e As EventArgs)
        Dim ofd As OpenFileDialog = New OpenFileDialog
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            imagepath = ofd.FileName
        End If
    End Sub

    Private Sub saveAddButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class
