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
        If appform.langlbl.Text = "Spanish" Then
            Dim query As String = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Postre'"
            AddItemToArrayList(query, dessertList)
        Else
            Dim query As String = "SELECT id, name, Engdesc, category, price, special FROM Menu WHERE category = 'Postre'"
            AddItemToArrayList(query, dessertList)
        End If
    End Sub



End Class
