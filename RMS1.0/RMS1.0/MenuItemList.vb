Imports System.Data.SqlClient

Public Class MenuItemList
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=DESKTOP-KGOILL4;Initial Catalog=SimpleMenu;Integrated Security=True"

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
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT id, name, description, category, price, special FROM Menu"
        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            menuItemsList.Add(New MenuItem(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5)))
        Loop

        myReader.Close()

        myConn.Close()

    End Sub

End Class
