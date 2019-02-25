Imports System.Data.SqlClient

Public Class DessertList
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=DESKTOP-KGOILL4;Initial Catalog=SimpleMenu;Integrated Security=True"

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
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Postre'"
        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            dessertList.Add(New MenuItem(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5)))
        Loop

        myReader.Close()

        myConn.Close()

    End Sub



End Class
