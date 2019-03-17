Public Class AdminUserControl
    'Private menuitemslist As MenuItemList = New MenuItemList
    'Private drinksList As DrinksList = New DrinksList
    'Private dessertsList As DessertList = New DessertList
    'Private appetizersList As AppetizerList = New AppetizerList
    'Private maincouseList As MainCourseList = New MainCourseList
    'Private specialsList As SpecialsList = New SpecialsList


    Private menuitemslist As MenuItemList
    Private drinksList As DrinksList
    Private dessertsList As DessertList
    Private appetizersList As AppetizerList
    Private maincouseList As MainCourseList
    Private specialsList As SpecialsList
    Private modifyitem As ModifyItemUC = New ModifyItemUC

    Public Sub PopulateDataGridView(itemlist As ArrayList)
        admindgv.Rows.Clear()
        For i As Integer = 0 To itemlist.Count - 1
            Dim currentItem As MenuItem = itemlist(i)
            admindgv.Rows.Add(currentItem.Id, currentItem.Name, currentItem.Description, currentItem.Category, currentItem.Price, currentItem.Special, currentItem.Imagepath)
        Next
    End Sub

    Private Sub AdminUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeAllLists()
        modifyitem.Visible = False
        admindgv.MultiSelect = False
        Dim allitems As ArrayList = menuitemslist.getItemsArrayList()
        PopulateDataGridView(allitems)
        categorylbl.Text = "TODOS LOS ITEMS"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub specialsButton_Click(sender As Object, e As EventArgs)
        Dim specialitems As ArrayList = specialsList.GetItemsArrayList()
        PopulateDataGridView(specialitems)
    End Sub

    Private Sub appertizersButton_Click(sender As Object, e As EventArgs)
        Dim appetizeritems As ArrayList = appetizersList.GetItemsArrayList()
        PopulateDataGridView(appetizeritems)
    End Sub

    Private Sub mainCourseButton_Click(sender As Object, e As EventArgs)
        Dim mainitems As ArrayList = maincouseList.GetItemsArrayList()
        PopulateDataGridView(mainitems)
    End Sub

    Private Sub dessertButton_Click(sender As Object, e As EventArgs)
        Dim dessertsitems As ArrayList = dessertsList.GetItemsArrayList()
        PopulateDataGridView(dessertsitems)

    End Sub

    Private Sub drinksButton_Click(sender As Object, e As EventArgs)
        Dim drinkitems As ArrayList = drinksList.getItemsArrayList()
        PopulateDataGridView(drinkitems)
    End Sub

    Private Sub itemsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        admindgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub modifyButton_Click(sender As Object, e As EventArgs)
        Dim dgvr As DataGridViewRow = admindgv.CurrentRow
        modifyitem.Id = Integer.Parse(dgvr.Cells(0).Value)
        modifyitem.Name = dgvr.Cells(1).Value
        modifyitem.Description = dgvr.Cells(2).Value
        modifyitem.Category = dgvr.Cells(3).Value
        modifyitem.Price = Decimal.Parse(dgvr.Cells(4).Value)
        modifyitem.Special = Boolean.Parse(dgvr.Cells(5).Value)
        modifyitem.Imagepath = dgvr.Cells(6).Value
        modifyitem.Visible = True
    End Sub

    Private Sub InitializeAllLists()
        menuitemslist = New MenuItemList
        drinksList = New DrinksList
        dessertsList = New DessertList
        appetizersList = New AppetizerList
        maincouseList = New MainCourseList
        specialsList = New SpecialsList
    End Sub


    Private Sub AdminUserControl_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        InitializeAllLists()
    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles appetizerbtn.Click
        Dim appetizeritems As ArrayList = appetizersList.GetItemsArrayList()
        PopulateDataGridView(appetizeritems)
        categorylbl.Text = "ENTRADAS"
    End Sub

    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles mainCourseButton.Click
        Dim mainitems As ArrayList = maincouseList.GetItemsArrayList()
        PopulateDataGridView(mainitems)
        categorylbl.Text = "PLATO FUERTE"
    End Sub

    Private Sub drinksbtn_Click(sender As Object, e As EventArgs) Handles drinksButton.Click
        Dim drinkitems As ArrayList = drinksList.getItemsArrayList()
        PopulateDataGridView(drinkitems)
        categorylbl.Text = "BEBIDAS"
    End Sub

    Private Sub dessertsbtn_Click(sender As Object, e As EventArgs) Handles dessertButton.Click
        Dim dessertsitems As ArrayList = dessertsList.GetItemsArrayList()
        PopulateDataGridView(dessertsitems)
        categorylbl.Text = "POSTRES"
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles specialsButton.Click
        Dim specialitems As ArrayList = specialsList.GetItemsArrayList()
        PopulateDataGridView(specialitems)
        categorylbl.Text = "ESPECIALES"
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles allitemsButton.Click
        Dim allitems As ArrayList = menuitemslist.getItemsArrayList()
        PopulateDataGridView(allitems)
        categorylbl.Text = "TODOS LOS ITEMS"
    End Sub

    Private Sub admindgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles admindgv.CellContentClick

    End Sub

    Private Sub categorylbl_Click(sender As Object, e As EventArgs) Handles categorylbl.Click

    End Sub

    Private Sub showOrderListBtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class
