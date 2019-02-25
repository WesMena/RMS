Public Class Order


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

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles paybtn.Click
        MsgBox("Enseguida un Mesero Vendra a Cobrarle :) ")
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
        Dim totaltext = calculateTotal().ToString
        totalnumlbl.Text = totaltext
    End Sub
End Class
