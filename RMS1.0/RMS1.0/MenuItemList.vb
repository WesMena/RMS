Imports System.Data.SqlClient

Public Class MenuItemList
    Private myConn As SqlConnection

    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=grupo0.database.windows.net;Initial Catalog=RMS;Persist Security Info=True;User ID=grupo0;Password=Bada907817@"

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
