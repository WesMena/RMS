Imports System.Data.SqlClient
Public Class orderlist
    Public Shared OrderId As Integer
    Private Sub admindgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderlistdgv.CellContentClick

    End Sub

    Private Sub orderlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrderDetail1.Visible = False

        Dim orderlist As New DataTable
        Dim connection As New SqlConnection(QueriesModule.connectionString)
        Dim commandselect As New SqlCommand("SELECT M.OrderId AS '# PEDIDO', M.total2pay AS 'TOTAL A PAGAR', M.clientname AS 'NOMBRE', M.clientsurname AS 'APELLIDOS' FROM Order_identifier M ", connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(orderlist)
        orderlistdgv.DataSource = orderlist



    End Sub
    Private Sub orderlistdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderlistdgv.CellClick
        Dim rowindex As Integer
        rowindex = e.RowIndex
        Dim row As DataGridViewRow = orderlistdgv.Rows(rowindex)
        OrderId = row.Cells(0).Value

    End Sub

    Private Sub orderDetailsbtn_Click(sender As Object, e As EventArgs) Handles orderDetailsbtn.Click
        OrderDetail1.Visible = Not OrderDetail1.Visible

    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        PrintDialog1.Document = PrintDocument1


        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            PrintDocument1.Print()

        End If


    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim graphics As Graphics = e.Graphics
        Dim font As Font = New Font("Courier New", 12)
        Dim fontheight As Double = font.GetHeight
        Dim startx As Integer = 10
        Dim starty As Integer = 10
        Dim offset As Integer = 40
        graphics.DrawString("Simple Menu", New Font("Courier New", 18), New SolidBrush(Color.Black), startx, starty)
        For i As Integer = 0 To AdminClient.Orderlist1.OrderDetail1.orderdetaildgv.Rows.Count - 2
            Dim itemname As String = OrderDetail1.orderdetaildgv.Rows(i).Cells(0).Value

            Dim unitprice As String = OrderDetail1.orderdetaildgv.Rows(i).Cells(1).Value
            Dim quantity As String = OrderDetail1.orderdetaildgv.Rows(i).Cells(2).Value
            Dim totalprice As String = OrderDetail1.orderdetaildgv.Rows(i).Cells(3).Value
            Dim prodline As String = quantity.PadRight(5) + itemname.PadRight(10) + unitprice.PadRight(5) + totalprice

            graphics.DrawString(prodline, font, New SolidBrush(Color.Black), startx, starty + offset)
            offset = offset + fontheight + 5

        Next

        offset = offset +20


    End Sub
End Class
