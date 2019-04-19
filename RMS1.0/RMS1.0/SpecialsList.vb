Imports System.Data.SqlClient
Public Class SpecialsList
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=grupo0.database.windows.net;Initial Catalog=RMS;Persist Security Info=True;User ID=grupo0;Password=Bada907817@"

    Public specialsList As New ArrayList()

    Private count As Integer

    Public Function GetCount() As Integer
        Return specialsList.Count()
    End Function

    Public Function GetItemAt(index As Integer) As MenuItem
        Return specialsList(index)
    End Function

    Public Function GetItemsArrayList()
        Return specialsList
    End Function

    ' Ahora me estoy dando cuenta que esto se repite en muchos lugares
    ' Entonces creo que seria bueno encapsularlo 
    ' Todo lo que pasa aqui adentro se podria poner en un modulo
    ' Una subrutina por ejemplo que tome dos atributos
    ' El "WHERE" del Query, y talvez el ArrayList donde vamos a agregar los objetos
    ' de tipo MenuItem.

    Public Sub New()
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT id, name, description, category, price, special, imagepath, Engdesc FROM Menu WHERE special = 1 "




        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            specialsList.Add(New MenuItem(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), myReader.GetValue(6), myReader.GetValue(7)))
        Loop

        myReader.Close()

        myConn.Close()

    End Sub

End Class
