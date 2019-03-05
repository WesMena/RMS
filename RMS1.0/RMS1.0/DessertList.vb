Imports System.Data.SqlClient

Public Class DessertList

    Public dessertList As New ArrayList()

    Private quantity As Integer = dessertList.Count()

    Public Function GetCapacity() As Integer
        Return quantity
    End Function

    Public Function GetItemAt(index As Integer) As MenuItem
        Return dessertList(index)
    End Function


    Public Function GetItemsArrayList()
        Return dessertList
    End Function

    Public Sub New()
        Dim query As String = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Postre'"
        AddItemToArrayList(query, dessertList)

    End Sub



End Class
