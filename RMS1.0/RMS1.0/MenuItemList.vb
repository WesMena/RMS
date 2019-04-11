Imports System.Data.SqlClient

Public Class MenuItemList
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=LAPTOP-3U2PB6I2\WESMENA;Initial Catalog=SimpleMenu;Persist Security Info=True;User ID=sa;Password=wvjjk611"

    Public menuItemsList As New ArrayList()

    Private quantity As Integer = menuItemsList.Count()

    Public Function GetCapacity() As Integer
        Return quantity
    End Function

    Public Function getItemsArrayList()
        Return menuItemsList
    End Function

    Public Function GetItemAt(index As Integer) As MenuItem
        Return menuItemsList(index)
    End Function

    Public Sub New()
        Dim query As String = "SELECT id, name, description, category, price, special FROM Menu"
        AddItemToArrayList(query, menuItemsList)

    End Sub

End Class
