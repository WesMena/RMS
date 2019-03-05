Imports System.Data.SqlClient

Public Class AppetizerList

    Public appetizerList As New ArrayList()

    Private quantity As Integer = appetizerList.Count()

    Public Function GetCapacity() As Integer
        Return quantity
    End Function

    Public Function GetItemAt(index As Integer) As MenuItem
        Return appetizerList(index)
    End Function

    Public Function GetItemsArrayList()
        Return appetizerList
    End Function

    Public Sub New()
        Dim query As String = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Entrada'"
        AddItemToArrayList(query, appetizerList)

    End Sub



End Class
