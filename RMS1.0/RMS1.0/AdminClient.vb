Imports System.Data.SqlClient
Imports System.ComponentModel


Public Class AdminClient
    Public Shared id, espDesc As String

    Private Sub AdminClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Orderlist1.Visible = False

    End Sub

    Private Sub AdminClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClientSelection.Show()
    End Sub

    Private Sub AdminUserControl1_Load(sender As Object, e As EventArgs) Handles AdminUserControl1.Load

    End Sub


    Private Sub modifyItemButton_Click(sender As Object, e As EventArgs)
        'comentario de muestra
    End Sub

    Private Sub addItemButton_Click(sender As Object, e As EventArgs)
        modifyitem.IsUpdate = False
        modifyitem.Visible = True
    End Sub

    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles modifyItemButton.Click
        Dim dgvr As DataGridViewRow = AdminUserControl1.admindgv.CurrentRow
        modifyitem.Id = Integer.Parse(dgvr.Cells(0).Value)
        modifyitem.ItemName = dgvr.Cells(1).Value
        modifyitem.Description = dgvr.Cells(2).Value
        modifyitem.Category = dgvr.Cells(3).Value
        modifyitem.Price = Decimal.Parse(dgvr.Cells(4).Value)
        modifyitem.Special = Boolean.Parse(dgvr.Cells(5).Value)
        modifyitem.Imagepath = dgvr.Cells(6).Value
        modifyitem.Visible = True
        modifyitem.IsUpdate = True
        'Wes: lo hice así para no tener que cambiar ninguna parte del código de Francisco y que 
        'no aparecieran problemas al hacer merge
        id = Integer.Parse(dgvr.Cells(0).Value)

        Dim connection As New SqlConnection(QueriesModule.connectionString)
        Dim getespdesc As New SqlCommand("SELECT description FROM Menu WHERE id=" & id, connection)

        connection.Open()

        With getespdesc
            espDesc = getespdesc.ExecuteScalar
            .Dispose()

        End With

        modifyitem.Espdesctxt.Text = espDesc
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        Dim dgvr As DataGridViewRow = AdminUserControl1.admindgv.CurrentRow

        modifyitem.ItemName = ""
        modifyitem.Description = ""
        modifyitem.Category = ""
        modifyitem.Price = 2000
        modifyitem.Special = False
        modifyitem.Imagepath = ""
        modifyitem.Espdesctxt.Text = ""

        modifyitem.Visible = True
        modifyitem.IsUpdate = False
    End Sub

    Private Sub ShowOrderListbtn_Click(sender As Object, e As EventArgs) Handles ShowOrderListbtn.Click
        Orderlist1.Visible = Not Orderlist1.Visible

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class