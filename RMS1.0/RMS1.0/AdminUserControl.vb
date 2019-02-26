Public Class AdminUserControl
    Private menuitemslist As MenuItemList = New MenuItemList
    Private drinksList As DrinksList = New DrinksList
    Private dessertsList As DessertList = New DessertList
    Private appetizersList As AppetizerList = New AppetizerList
    Private maincouseList As MainCourseList = New MainCourseList
    Private specialsList As SpecialsList = New SpecialsList


    Public Sub PopulateDataGridView(itemlist As ArrayList)
        itemsDataGridView.Rows.Clear()
        For i As Integer = 0 To itemlist.Count - 1
            Dim currentItem As MenuItem = itemlist(i)
            itemsDataGridView.Rows.Add(currentItem.Id, currentItem.Name, currentItem.Description, currentItem.Category, currentItem.Price, currentItem.Special, currentItem.Imagepath)
        Next
    End Sub

    Private Sub AdminUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allitems As ArrayList = menuitemslist.getItemsArrayList()
        PopulateDataGridView(allitems)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim allitems As ArrayList = menuitemslist.getItemsArrayList()
        PopulateDataGridView(allitems)
    End Sub

    Private Sub specialsButton_Click(sender As Object, e As EventArgs) Handles specialsButton.Click
        Dim specialitems As ArrayList = specialsList.GetItemsArrayList()
        PopulateDataGridView(specialitems)
    End Sub

    Private Sub appertizersButton_Click(sender As Object, e As EventArgs) Handles appertizersButton.Click
        Dim appetizeritems As ArrayList = appetizersList.GetItemsArrayList()
        PopulateDataGridView(appetizeritems)
    End Sub

    Private Sub mainCourseButton_Click(sender As Object, e As EventArgs) Handles mainCourseButton.Click
        Dim mainitems As ArrayList = maincouseList.GetItemsArrayList()
        PopulateDataGridView(mainitems)
    End Sub

    Private Sub dessertButton_Click(sender As Object, e As EventArgs) Handles dessertButton.Click
        Dim dessertsitems As ArrayList = dessertsList.GetItemsArrayList()
        PopulateDataGridView(dessertsitems)

    End Sub

    Private Sub drinksButton_Click(sender As Object, e As EventArgs) Handles drinksButton.Click
        Dim drinkitems As ArrayList = drinksList.getItemsArrayList()
        PopulateDataGridView(drinkitems)
    End Sub

End Class
