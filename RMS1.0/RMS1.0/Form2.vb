Imports System.Data.SqlClient

Public Class Form2



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FillDGV()
        Dim dateFrom As String = DateTimePickerFrom.Value
        Dim dateTo As String = DateTimePickerFrom.Value
        Dim condition As String = "dateOrdered >= '" & dateFrom & "'" ' AND dateOrdered <= '" & dateTo & "'"
        'MsgBox(condition)
        Dim orderdetail As New DataTable
        Dim connection As New SqlConnection("Connection String Aqui")
        Dim commandselect As New SqlCommand("SELECT name AS 'Nombre del Item', SUM(quantity) AS 'Cantidad' FROM Order_lines2 WHERE " & condition & "GROUP BY name, quantity ORDER BY 'Cantidad' DESC;", connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(orderdetail)
        topitemsdgv.DataSource = orderdetail

    End Sub

    Private Sub DateTimePickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFrom.ValueChanged
        FillDGV()
    End Sub

    Private Sub DateTimePickerTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerTo.ValueChanged
        FillDGV()
    End Sub

    Private Sub topitemsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles topitemsdgv.CellContentClick

    End Sub
End Class