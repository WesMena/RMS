Public Class appform

    Public Sub toggleButtonVisibility(btn As Control, categoryName As String)
        If btn.Left = -112 Then
            btn.Visible = False
            btn.Left = -3
            btnanim.ShowSync(btn)
        Else
            scrollToTop()
            CategoryUC1.categoryNameLabel.Text = categoryName
            Homehub1.Visible = False
            Order1.Visible = False
            btn.Visible = False
            btn.Left = -112
            btnanim.ShowSync(btn)
        End If
    End Sub


    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        If homebtn.Left = -112 Then
            homebtn.Visible = False
            homebtn.Left = -3
            btnanim.ShowSync(homebtn)
        Else
            Homehub1.Visible = True
            homebtn.Visible = False
            homebtn.Left = -112
            btnanim.ShowSync(homebtn)
        End If
    End Sub

    Private Sub scrollToTop()
        CategoryUC1.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles appetizerbtn.Click
        toggleButtonVisibility(appetizerbtn, "Entradas")
    End Sub

    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles maincoursebtn.Click
        toggleButtonVisibility(maincoursebtn, "Plato Fuerte")
    End Sub

    Private Sub drinksbtn_Click(sender As Object, e As EventArgs) Handles drinksbtn.Click
        toggleButtonVisibility(drinksbtn, "Bebidas")
    End Sub

    Private Sub dessertsbtn_Click(sender As Object, e As EventArgs) Handles dessertsbtn.Click
        toggleButtonVisibility(dessertsbtn, "Postres")
    End Sub

    Private Sub orderbtn_Click(sender As Object, e As EventArgs) Handles orderbtn.Click
        Order1.Visible = Not Order1.Visible
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Homehub1.Visible = True
        Order1.Visible = False
        Order1.BringToFront()
    End Sub

    Private Sub Homehub1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoryUC1_Load(sender As Object, e As EventArgs)

    End Sub

End Class
