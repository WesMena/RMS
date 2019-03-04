Imports System.Data.SqlClient

Public Class AppetizerList
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=LAPTOP-3U2PB6I2\WESMENA;Initial Catalog=SimpleMenu;Persist Security Info=True;User ID=sa;Password=wvjjk611"

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
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Entrada'"
        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            appetizerList.Add(New MenuItem(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5)))
        Loop

        myReader.Close()

        myConn.Close()

    End Sub



End Class
