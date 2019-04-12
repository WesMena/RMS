Imports System.Data.SqlClient
Public Class ClientSelection
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)








    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        appform.Show()
        Me.Hide()
    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles menumanagerbtn.Click
        Dim connection As New SqlConnection(QueriesModule.connectionString)
        Dim command As New SqlCommand("SELECT * FROM login WHERE pass = @pass", connection)
        command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = passTXT.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count <= 0 Then
            wrongpass.StartPosition = FormStartPosition.Manual
            wrongpass.Location = New Point(290, 160)
            wrongpass.ShowDialog()
        Else
            AdminClient.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles startmenubtn.Click
        TablenumUC1.Visible = True


    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ClientSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub


End Class