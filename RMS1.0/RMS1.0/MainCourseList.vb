﻿Imports System.Data.SqlClient

Public Class MainCourseList
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=DESKTOP-KGOILL4;Initial Catalog=SimpleMenu;Integrated Security=True"

    Public mainCourseList As New ArrayList()

    Private quantity As Integer = mainCourseList.Count()

    Public Function GetCapacity() As Integer
        Return quantity
    End Function

    Public Function GetItemAt(index As Integer) As MenuItem
        Return mainCourseList(index)
    End Function

    Public Function GetItemsArrayList()
        Return mainCourseList
    End Function

    Public Sub New()
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT id, name, description, category, price, special FROM Menu WHERE category = 'Principal'"
        'Open the connection.
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            mainCourseList.Add(New MenuItem(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5)))
        Loop

        myReader.Close()

        myConn.Close()

    End Sub

End Class