Imports System.Data.SqlClient
Public Class Order
    Public Shared currentrow As Integer
    Public Shared id As Integer
    Public Shared totaltext As String

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles deleteselectedbtn.Click
        orderdgv.ClearSelection()
    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Estos son datos hard coded, hay que borrarlos antes de conectarle la base de datos'
        'orderdgv.Rows.Add("pollo", "3", "2300", "6900")
        'orderdgv.Rows.Add("Pizza", "1", "8000", "8000")
        'orderdgv.Rows.Add("Helado", "2", "1500", "3000")
        Dim totaltext = calculateTotal().ToString
        totalnumlbl.Text = totaltext

    End Sub

    Public Sub AddItem(name As String, n As Integer, price As Decimal)
        Dim total As Decimal = n * price

        orderdgv.Rows.Add(name, n.ToString, price.ToString, total.ToString)
    End Sub

    Public Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles paybtn.Click



        Customer_s_name.ShowDialog()

    End Sub

    Private Sub deleteorderbtn_Click(sender As Object, e As EventArgs) Handles deleteorderbtn.Click
        orderdgv.Rows.Clear()
    End Sub

    Private Function calculateTotal() As Decimal
        Dim sum As Decimal

        For i As Integer = 0 To orderdgv.Rows.Count - 1

            sum += orderdgv.Rows(i).Cells("totalprice").Value

        Next
        Return sum
    End Function

    Private Sub totaltext_lbl_Click(sender As Object, e As EventArgs) Handles totaltext_lbl.Click

    End Sub

    Private Sub Order_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        totaltext = calculateTotal().ToString
        totalnumlbl.Text = totaltext
    End Sub

    Private Sub totalnumlbl_Click(sender As Object, e As EventArgs) Handles totalnumlbl.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Public Sub sqltrigger_Textchanged(sender As Object, e As EventArgs) Handles sqltrigger.TextChanged
        Dim connection As New SqlConnection(QueriesModule.connectionString)
        Dim query As New SqlCommand("INSERT INTO Order_identifier(total2pay, clientname, clientsurname, tablenum) Values(@total2pay, @clientname, @clientsurname, @tablenum)", connection)
        Dim query2 As New SqlCommand("SELECT MAX (OrderId)  FROM Order_identifier ", connection)
        Dim query3 As New SqlCommand



        Dim OrderId As Integer
        With query
            .Parameters.AddWithValue("@total2pay", totaltext)
            .Parameters.AddWithValue("@clientname", Customer_s_name.firstname)
            .Parameters.AddWithValue("@clientsurname", Customer_s_name.surname)
            .Parameters.AddWithValue("@tablenum", appform.tablenumLbl.Text)

        End With
        connection.Open()
        query.ExecuteNonQuery()
        query.Dispose()

        With query2
            OrderId = query2.ExecuteScalar
        End With


        With query3
            For i As Integer = 0 To orderdgv.Rows.Count - 2
                .Parameters.Clear()
                query3.Connection = connection
                query3.CommandText = " INSERT INTO Order_lines(OrderId, name, unitprice,quantity,totalprice) Values(@OrderId, @name, @unitprice, @quantity, @totalprice)"
                .Parameters.AddWithValue("@OrderId", OrderId)

                .Parameters.AddWithValue("@name", orderdgv.Rows(i).Cells(0).Value)

                .Parameters.AddWithValue("@unitprice", orderdgv.Rows(i).Cells(2).Value)

                .Parameters.AddWithValue("@quantity", orderdgv.Rows(i).Cells(1).Value)

                .Parameters.AddWithValue("@totalprice", orderdgv.Rows(i).Cells(3).Value)


                query3.ExecuteNonQuery()


            Next




        End With



    End Sub

    Private Sub orderdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderdgv.CellValueChanged
        If orderdgv.Rows.Count > 1 Then
            currentrow = orderdgv.CurrentRow.Index
            orderdgv.Rows(currentrow).Cells(3).Value = orderdgv.Rows(currentrow).Cells(1).Value * orderdgv.Rows(currentrow).Cells(2).Value
            orderdgv.Update()
            totaltext = calculateTotal().ToString
            totalnumlbl.Text = totaltext
        End If

    End Sub


End Class
