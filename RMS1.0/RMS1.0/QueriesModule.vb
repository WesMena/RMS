Imports System.Data.SqlClient

Module QueriesModule
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=LAPTOP-3U2PB6I2\WESMENA;Initial Catalog=SimpleMenu;Persist Security Info=True;User ID=sa;Password=wvjjk611"

    Public Sub AddItemToArrayList(query As String, arlist As ArrayList)
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = query
        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            arlist.Add(New MenuItem(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5)))
        Loop

        myReader.Close()

        myConn.Close()

    End Sub
End Module
