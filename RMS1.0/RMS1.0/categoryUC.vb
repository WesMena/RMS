Public Class categoryUC
    Private _categoryName As String

    Private customButton As New itemtemplate()

    Dim itemtemplates() As itemtemplate

    Private categoryItems As ArrayList

    Private count As Integer


    Public Sub setCategoryItems(categoryList As ArrayList)
        categoryItems = categoryList
    End Sub

    Public Property CategoryName As String
        Get
            Return _categoryName
        End Get
        Set(value As String)
            _categoryName = value
        End Set
    End Property

    Private Sub categoryUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        categoryNameLabel.Text = Me.CategoryName
        Me.AutoScroll = True
        If categoryNameLabel.Text = "Busqueda" Then
            SearchTextBox.Visible = True
        Else
            SearchTextBox.Visible = False
        End If
    End Sub

    ' Selecciona la imagen de la categoria para el header
    Private Function getCategoryImg() As Image
        Dim img As Image
        Select Case Me.CategoryName
            Case "Entradas"
                SearchTextBox.Visible = False
                SearchButton.Visible = False
                categoryPhotoBox.Visible = True

                categoryNameLabel.ForeColor = Color.FromArgb(111, 224, 96)
                img = My.Resources.appetizerImg
                Dim appetizers As AppetizerList = New AppetizerList
                categoryItems = appetizers.GetItemsArrayList()
            Case "Plato Fuerte"
                SearchTextBox.Visible = False
                SearchButton.Visible = False
                categoryPhotoBox.Visible = True

                categoryNameLabel.ForeColor = Color.FromArgb(214, 157, 85)
                img = My.Resources.maincourseImg
                Dim maincourses As MainCourseList = New MainCourseList
                categoryItems = maincourses.GetItemsArrayList()
            Case "Postres"
                SearchTextBox.Visible = False
                SearchButton.Visible = False
                categoryPhotoBox.Visible = True

                categoryNameLabel.ForeColor = Color.FromArgb(255, 117, 150)
                img = My.Resources.dessertImg
                Dim desserts As DessertList = New DessertList
                categoryItems = desserts.GetItemsArrayList()
            Case "Bebidas"
                SearchTextBox.Visible = False
                SearchButton.Visible = False
                categoryPhotoBox.Visible = True

                categoryNameLabel.ForeColor = Color.FromArgb(87, 153, 204)
                img = My.Resources.drinksImg
                Dim drinks As DrinksList = New DrinksList
                categoryItems = drinks.getItemsArrayList()
            Case "Busqueda"
                SearchTextBox.Visible = True
                SearchButton.Visible = True
                categoryNameLabel.ForeColor = Color.FromArgb(87, 153, 204)
                categoryPhotoBox.Visible = False
                Dim search As ArrayList = New ArrayList

                categoryItems = search
            Case Else
                img = My.Resources.drinksImg
        End Select
        Return img
    End Function

    ' Este metodo es el que agarra el nombre
    ' TODO  Cambiar a usar el metodo
    Private Sub categoryNameLabel_TextChanged(sender As Object, e As EventArgs) Handles categoryNameLabel.TextChanged
        Me.CategoryName = categoryNameLabel.Text
        categoryPhotoBox.Image = getCategoryImg()
        clearItemTemplates()
        CreateCategoryItems()
    End Sub



    'Este metodo crea los botones como los de la clase itemtemplates
    'Los seapara con la misma distancia uno del otro y les pone
    ' el nombre. descipcion, y precio correspondientes
    Private Sub CreateCategoryItems()
        If categoryItems IsNot Nothing Then
            count = categoryItems.Count
            ReDim itemtemplates(count - 1)

            For i As Integer = 0 To count - 1
                itemtemplates(i) = New itemtemplate()
            Next

            For counter As Integer = 0 To count - 1
                With itemtemplates(counter)

                    Dim current As MenuItem = categoryItems(counter)

                    .Location = New System.Drawing.Point(143, (150 * (counter + 1)))

                    .ItemName = current.Name

                    .ItemDescription = current.Description

                    .ItemPrice = current.Price.ToString
                End With
            Next

            With Me.Controls
                For i As Integer = 0 To count - 1
                    .Add(itemtemplates(i))
                Next
            End With

        End If
    End Sub

    Public Sub clearItemTemplates()
        If itemtemplates IsNot Nothing Then
            For i As Integer = 0 To itemtemplates.Length - 1
                itemtemplates(i).Dispose()
            Next
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim searchinput As String = SearchTextBox.Text
        Dim searchitems As ArrayList = New ArrayList()
        clearItemTemplates()



        Dim query As String = "SELECT id, name, description, category, price, special FROM Menu WHERE  name LIKE  '%" & searchinput & "%'"
        AddItemToArrayList(query, searchitems)
        categoryItems = searchitems
        CreateCategoryItems()
    End Sub
End Class
