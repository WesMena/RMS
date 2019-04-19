Public Class appform
    Public Shared lang As String = "Spanish"
    Public Shared currentcat As Integer


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
        toggleButtonVisibility(appetizerbtn, appetizerbtn.Text)
        currentcat = 1
        appetizerbtn.selected = True
    End Sub


    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles maincoursebtn.Click
        toggleButtonVisibility(maincoursebtn, maincoursebtn.Text)
        currentcat = 2

    End Sub


    Private Sub drinksbtn_Click(sender As Object, e As EventArgs) Handles drinksbtn.Click
        toggleButtonVisibility(drinksbtn, drinksbtn.Text)
        currentcat = 3

    End Sub



    Private Sub dessertsbtn_Click(sender As Object, e As EventArgs) Handles dessertsbtn.Click
        toggleButtonVisibility(dessertsbtn, dessertsbtn.Text)
        currentcat = 4
    End Sub


    Private Sub orderbtn_Click(sender As Object, e As EventArgs) Handles orderbtn.Click
        Order1.Visible = Not Order1.Visible
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Homehub1.Visible = True
        Order1.Visible = False
        Order1.BringToFront()
        homebtn.selected = True
        langlbl.Text = "Spanish"
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
        toggleButtonVisibility(searchbtn, CategoryUC1.SearchButton.Text)
        currentcat = 5
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


    End Sub

    Private Sub langbtn_Click(sender As Object, e As EventArgs) Handles langbtn.Click

        If langlbl.Text = "Spanish" Then
            langlbl.Text = "English"
            lang = "English"
            Homehub1.updateItemInfo()
        Else
            langlbl.Text = "Spanish"
            lang = "Spanish"
            Homehub1.updateItemInfo()
        End If

    End Sub

    Private Sub langlbl_TextChanged(sender As Object, e As EventArgs) Handles langlbl.TextChanged
        If langlbl.Text = "Spanish" Then
            langbtn.Iconimage_right = Global.RMS1._0.My.Resources.Resources.FlagofSpain
            homebtn.Text = "Inicio"
            appetizerbtn.Text = "Entradas"
            maincoursebtn.Text = "Plato Fuerte"
            drinksbtn.Text = "Bebidas"
            dessertsbtn.Text = "Postres"
            orderbtn.Text = "Pedido"
            searchbtn.Text = "Buscar"
            Order1.Item.HeaderText = "PLATILLO"
            Order1.quantity.HeaderText = "CANTIDAD"
            Order1.unitprice.HeaderText = "P. UNITARIO"
            Order1.totalprice.HeaderText = "PRECIO TOTAL"
            Order1.deleteorderbtn.Text = "Cancelar"
            Order1.deleteselectedbtn.Text = "Borrar Item"
            Order1.paybtn.Text = "Pagar"
            Order1.orderlbl.Text = "ORDEN"
            Order1.totaltext_lbl.Text = " TOTAL A PAGAR: ₡"
            CategoryUC1.SearchButton.Text = "Buscar"
            Homehub1.OrderButton.Text = "Ordenar"
            notification.successlbl.Text = "AGREGADO AL PEDIDO"
            Homehub1.SpecialsUserControl.titleLabel.Text = "Especial de Hoy"
            Customer_s_name.namelbl.Text = "INGRESE SU NOMBRE Y APELLIDOS"
            Customer_s_name.paybtn.Text = "CONFIRMAR PEDIDO"
            Customer_s_name.givenNlbl.Text = "NOMBRE"
            Customer_s_name.surnamelbl.Text = "APELLIDOS"

        Else
            langbtn.Iconimage_right = Global.RMS1._0.My.Resources.Resources.USflag
            homebtn.Text = "Home"
            appetizerbtn.Text = "Appetizers"
            maincoursebtn.Text = "Main Courses"
            drinksbtn.Text = "Beverages"
            dessertsbtn.Text = "Desserts"
            orderbtn.Text = "Order"
            searchbtn.Text = "Search"
            Order1.Item.HeaderText = "ITEM"
            Order1.quantity.HeaderText = "QUANTITY"
            Order1.unitprice.HeaderText = "UNIT PRICE"
            Order1.totalprice.HeaderText = "TOTAL PRICE"
            Order1.deleteorderbtn.Text = "Cancel"
            Order1.deleteselectedbtn.Text = "Delete Item"
            Order1.paybtn.Text = "Pay"
            Order1.orderlbl.Text = "ORDER"
            Order1.totaltext_lbl.Text = "TOTAL TO PAY: ₡"
            CategoryUC1.SearchButton.Text = "Search"
            Homehub1.OrderButton.Text = "Order"
            notification.successlbl.Text = "ADDED TO ORDER"
            Homehub1.SpecialsUserControl.titleLabel.Text = "Today's special"
            Customer_s_name.namelbl.Text = "ENTER YOUR GIVEN NAME AND SURNAME"
            Customer_s_name.paybtn.Text = "CONFIRM ORDER"
            Customer_s_name.givenNlbl.Text = "GIVEN NAME"
            Customer_s_name.surnamelbl.Text = "SURNAME"

        End If
        Select Case (currentcat)
            Case 1
                CategoryUC1.categoryNameLabel.Text = appetizerbtn.Text
            Case 2
                CategoryUC1.categoryNameLabel.Text = maincoursebtn.Text
            Case 3
                CategoryUC1.categoryNameLabel.Text = drinksbtn.Text
            Case 4
                CategoryUC1.categoryNameLabel.Text = dessertsbtn.Text
            Case 5
                CategoryUC1.categoryNameLabel.Text = searchbtn.Text
        End Select
    End Sub

    Private Sub Order1_Load(sender As Object, e As EventArgs) Handles Order1.Load

    End Sub
End Class
