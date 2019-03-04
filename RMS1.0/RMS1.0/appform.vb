Public Class appform


    Public Sub toggleButtonVisibility(btn As Control, categoryName As String)
        If categoryName <> CategoryUC1.categoryNameLabel.Text Then
            btn.Visible = False
            btn.Left = -3
            btnanim.ShowSync(btn)
            CategoryUC1.Visible = False
            scrollToTop()
            CategoryUC1.categoryNameLabel.Text = categoryName
            cattransition.ShowSync(CategoryUC1)

            Homehub1.Visible = False
            Order1.Visible = False
            btn.Visible = False
            btn.Left = -112
            btnanim.HideSync(btn)
            btn.Visible = True
        End If


    End Sub


    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click


        If Homehub1.Visible = False Then
            homebtn.Visible = False
            homebtn.Left = -3
            btnanim.ShowSync(homebtn)
            cattransition.ShowSync(Homehub1)
            Homehub1.Visible = True
            Homehub1.resetCurrent()
            homebtn.Visible = False
            homebtn.Left = -112
            btnanim.ShowSync(homebtn)

        End If
        CategoryUC1.categoryNameLabel.Text = " "
    End Sub



    Private Sub scrollToTop()
        CategoryUC1.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub appetizerbtn_MouseHover(sender As Object, e As EventArgs) Handles appetizerbtn.MouseHover
        toggleButtonVisibility(appetizerbtn, "Entradas")
    End Sub
    Private Sub appetizerbtn_MouseLeave(sender As Object, e As EventArgs) Handles appetizerbtn.MouseLeave
        toggleButtonVisibility(appetizerbtn, "Entradas")
    End Sub

    Private Sub maincoursebtn_MouseHover(sender As Object, e As EventArgs) Handles maincoursebtn.MouseHover
        toggleButtonVisibility(maincoursebtn, "Plato Fuerte")
    End Sub
    Private Sub maincoursebtn_MouseLeave(sender As Object, e As EventArgs) Handles maincoursebtn.MouseLeave
        toggleButtonVisibility(maincoursebtn, "Plato Fuerte")
    End Sub

    Private Sub drinksbtn_MouseHover(sender As Object, e As EventArgs) Handles drinksbtn.MouseHover
        toggleButtonVisibility(drinksbtn, "Bebidas")
    End Sub

    Private Sub drinksbtn_MouseLeave(sender As Object, e As EventArgs) Handles drinksbtn.MouseLeave
        toggleButtonVisibility(drinksbtn, "Bebidas")
    End Sub

    Private Sub dessertsbtn_MouseHover(sender As Object, e As EventArgs) Handles dessertsbtn.MouseHover
        toggleButtonVisibility(dessertsbtn, "Postres")
    End Sub
    Private Sub dessertsbtn_MouseLeave(sender As Object, e As EventArgs) Handles dessertsbtn.MouseLeave
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

    Private Sub Homehub1_Load_1(sender As Object, e As EventArgs) Handles Homehub1.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles HideTimer.Tick

    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles appetizerbtn.Click

    End Sub
End Class
