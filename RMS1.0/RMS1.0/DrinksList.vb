Imports System.Data.SqlClient

Public Class DrinksList

    Public drinksList As New ArrayList()

    Private quantity As Integer = drinksList.Count()

    Public Function GetCapacity() As Integer
        Return quantity
    End Function

    Public Function getItemsArrayList()
        Return drinksList
    End Function

    Public Function GetItemAt(index As Integer) As MenuItem
        Return drinksList(index)
    End Function

    Public Sub New()

        Dim query As String = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Bebida'"
        AddItemToArrayList(query, drinksList)

    End Sub

End Class
