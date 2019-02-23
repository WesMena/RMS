Public Class Order
    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderdgv.CellContentClick

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles deleteselectedbtn.Click

    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Estos son datos hard coded, hay que borrarlos antes de conectarle la base de datos'
        orderdgv.Rows.Add("pollo", "3", "2300", "6900")
        orderdgv.Rows.Add("Pizza", "1", "8000", "8000")
        orderdgv.Rows.Add("Helado", "2", "1500", "3000")


    End Sub

    Private Sub appetizerbtn_Click(sender As Object, e As EventArgs) Handles paybtn.Click

    End Sub
End Class
