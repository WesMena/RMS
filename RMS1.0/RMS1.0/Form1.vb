Public Class Form1
    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        If homebtn.Left = -112 Then
            homebtn.Visible = False
            homebtn.Left = -3
            btnanim.ShowSync(homebtn)
        Else
            homebtn.Visible = False
            homebtn.Left = -112
            btnanim.ShowSync(homebtn)
        End If

    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles appetizerbtn.Click
        If appetizerbtn.Left = -112 Then
            appetizerbtn.Visible = False
            appetizerbtn.Left = -3
            btnanim.ShowSync(appetizerbtn)
        Else
            appetizerbtn.Visible = False
            appetizerbtn.Left = -112
            btnanim.ShowSync(appetizerbtn)
        End If

    End Sub

    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles maincoursebtn.Click
        If maincoursebtn.Left = -112 Then
            maincoursebtn.Visible = False
            maincoursebtn.Left = -3
            btnanim.ShowSync(maincoursebtn)
        Else
            maincoursebtn.Visible = False
            maincoursebtn.Left = -112
            btnanim.ShowSync(maincoursebtn)
        End If

    End Sub

    Private Sub drinksbtn_Click(sender As Object, e As EventArgs) Handles drinksbtn.Click
        If drinksbtn.Left = -112 Then
            drinksbtn.Visible = False
            drinksbtn.Left = -3
            btnanim.ShowSync(drinksbtn)
        Else
            drinksbtn.Visible = False
            drinksbtn.Left = -112
            btnanim.ShowSync(drinksbtn)
        End If

    End Sub

    Private Sub dessertsbtn_Click(sender As Object, e As EventArgs) Handles dessertsbtn.Click
        If dessertsbtn.Left = -112 Then
            dessertsbtn.Visible = False
            dessertsbtn.Left = -3
            btnanim.ShowSync(dessertsbtn)
        Else
            dessertsbtn.Visible = False
            dessertsbtn.Left = -112
            btnanim.ShowSync(dessertsbtn)
        End If

    End Sub

    Private Sub orderbtn_Click(sender As Object, e As EventArgs) Handles orderbtn.Click
        If orderbtn.Left = -112 Then
            orderbtn.Visible = False
            orderbtn.Left = -3
            btnanim.ShowSync(orderbtn)
        Else
            orderbtn.Visible = False
            orderbtn.Left = -112
            btnanim.ShowSync(orderbtn)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Comentario prueba github 
        'XD XD

    End Sub
End Class
