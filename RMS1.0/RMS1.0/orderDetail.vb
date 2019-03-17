Imports System.Data.SqlClient
Public Class orderDetail
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Visible = False
    End Sub

    Private Sub orderDetail_VisibleChange(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim orderdetail As New DataTable
        Dim connection As New SqlConnection(QueriesModule.connectionString)
        Dim commandselect As New SqlCommand("SELECT M.name AS 'PLATILLO', M.unitprice AS 'PRECIO UNITARIO', M.quantity AS 'CANTIDAD', M.totalprice AS 'PRECIO TOTAL' FROM Order_lines M WHERE OrderId=" & orderlist.OrderId, connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(orderdetail)
        orderdetaildgv.DataSource = orderdetail

    End Sub


End Class
