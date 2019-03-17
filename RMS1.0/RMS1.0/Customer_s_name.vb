Public Class Customer_s_name
    Public Shared firstname As String
    Public Shared surname As String
    Private Sub paybtn_Click(sender As Object, e As EventArgs) Handles paybtn.Click
        firstname = nameTxt.Text
        surname = surnameTXT.Text
        appform.Order1.sqltrigger.Text = Math.Ceiling(Rnd() * 200000)

        Me.Close()
    End Sub
End Class