Public Class Homehub
    Private specials As SpecialsList = New SpecialsList

    'Tamanho de la Lista de Items Especiales
    Private count As Integer

    Private current As Integer = 0

    Public Sub resetCurrent()
        current = 0
        updateItemInfo()
    End Sub


    Private Sub updateItemInfo()
        If specials IsNot Nothing Then

            Dim currentSpecial As MenuItem = specials.GetItemAt(current)
            SpecialsUserControl.titleLabel.Text = "Especial de Hoy"
            SpecialsUserControl.itemNameLabel.Text = currentSpecial.Name
            SpecialsUserControl.itemDescriptionLabel.Text = currentSpecial.Description
            SpecialsUserControl.priceLabel.Text = "₡" & currentSpecial.Price.ToString

            'Ojo aqui es donde hay que especificar el path entero de las imagenes que queremos ensenhar
            'entonces lo que recomiendo es solo cambiar el prefijo por el correspondiente a sus directorio
            ' y guardar el nombre de las imagenes en la base de datos (con extension) ejemplo: "quesoburguesa.png"

            'Dim path As String = "C:\Users\HP\Pictures\imagenes\" & currentSpecial.Imagepath
            Dim path As String = currentSpecial.Imagepath

            SpecialsUserControl.itemPhotoBox.Image = Image.FromFile(path)
        Else
            SpecialsUserControl.titleLabel.Text = "Vacio"
        End If
    End Sub



    ' Esta funcion lo que va a hacer es que si nos contamos hacia arriba y nos pasamos del numero de items, volvemos a cero
    ' Y viceverse, si contamos hacia abajo y bajamos de cero, empezamos por el "ultimo numero"
    Private Function WrapAroundLimits(i As Integer) As Integer
        count = specials.GetCount()
        If i >= count Then
            Return 0
        ElseIf i < 0 Then
            Return (count - 1)
        Else
            Return i
        End If
    End Function


    Private Sub SpecialsUserControl_Load(sender As Object, e As EventArgs) Handles SpecialsUserControl.Load
        updateItemInfo()
    End Sub

    Private Sub SpecialsUserControl_VisibleChanged(sender As Object, e As EventArgs) Handles SpecialsUserControl.VisibleChanged
        updateItemInfo()
    End Sub

    Private Sub currentminusbtn_Click_1(sender As Object, e As EventArgs) Handles currentminusbtn.Click
        Dim tmp = Me.current
        tmp = tmp - 1
        tmp = WrapAroundLimits(tmp)
        Me.current = tmp
        updateItemInfo()
    End Sub

    Private Sub currentplusbtn_Click_1(sender As Object, e As EventArgs) Handles currentplusbtn.Click
        Dim tmp = Me.current
        tmp = tmp + 1
        tmp = WrapAroundLimits(tmp)
        Me.current = tmp
        updateItemInfo()
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Dim currentItem As MenuItem = specials.GetItemAt(current)
        appform.Order1.AddItem(currentItem.Name, 1, currentItem.Price)
        notification.itemNameLabel.Text = "1 " & currentItem.Name
        notification.StartPosition = FormStartPosition.Manual
        notification.Location = New Point(825, 160)
        notification.ShowDialog()
    End Sub
End Class
