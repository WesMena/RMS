Public Class appform


    Public Sub toggleButtonVisibility(btn As Control, categoryName As String)
        Homehub1.Visible = False
        Order1.Visible = False

        CategoryUC1.Visible = False
        scrollToTop()
            CategoryUC1.categoryNameLabel.Text = categoryName
        cattransition.ShowSync(CategoryUC1)




    End Sub


    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click



        cattransition.Show(Homehub1)
        Homehub1.resetCurrent()


    End Sub



    Private Sub scrollToTop()
        CategoryUC1.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles appetizerbtn.Click
        toggleButtonVisibility(appetizerbtn, "Entradas")
        appetizerbtn.selected = True
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
        homebtn.selected = True
    End Sub

    Private Sub Homehub1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoryUC1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Homehub1_Load_1(sender As Object, e As EventArgs) Handles Homehub1.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles HideTimer.Tick

    End Sub



    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        toggleButtonVisibility(searchbtn, "Busqueda")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Homehub1.Visible = False
    End Sub

    Private Sub sidepanelsliderbtn_Click(sender As Object, e As EventArgs) Handles sidepanelsliderbtn.Click
        If sidepanel.Width = 48 Then
            sidepanel.Visible = False
            sidepanel.Width = 180
            sidepaneltransitionOUT.ShowSync(sidepanel)
        Else
            sidepanel.Visible = False
            sidepanel.Width = 48
            sidepaneltransitionIN.ShowSync(sidepanel)
        End If

        'nota para la demostración
    End Sub
End Class
