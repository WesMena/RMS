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
        If appform.langlbl.Text = "Spanish" Then
            Dim query As String = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Entrada'"
            AddItemToArrayList(query, appetizerList)
        Else
            Dim query As String = "SELECT id, name, Engdesc, category, price, special FROM Menu WHERE category = 'Entrada'"
            AddItemToArrayList(query, appetizerList)
        End If
    End Sub



End Class
