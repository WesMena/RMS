Public Class tablenumUC
    Private Sub paybtn_Click(sender As Object, e As EventArgs) Handles loadRSmenuBtn.Click
        appform.tablenumLbl.Text = tablenumTXT.Text

        appform.Show()
        ClientSelection.Hide()
        Me.Hide()
    End Sub

    Private Sub tablenumTXT_OnValueChanged(sender As Object, e As EventArgs) Handles tablenumTXT.OnValueChanged

    End Sub
End Class
