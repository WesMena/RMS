Imports System.ComponentModel

Public Class AdminClient
    Private Sub AdminClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdminClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClientSelection.Show()
    End Sub

    Private Sub AdminUserControl1_Load(sender As Object, e As EventArgs) Handles AdminUserControl1.Load

    End Sub


    Private Sub modifyItemButton_Click(sender As Object, e As EventArgs) Handles modifyItemButton.Click
        Dim dgvr As DataGridViewRow = AdminUserControl1.itemsDataGridView.CurrentRow
        modifyitem.Id = Integer.Parse(dgvr.Cells(0).Value)
        modifyitem.ItemName = dgvr.Cells(1).Value
        modifyitem.Description = dgvr.Cells(2).Value
        modifyitem.Category = dgvr.Cells(3).Value
        modifyitem.Price = Decimal.Parse(dgvr.Cells(4).Value)
        modifyitem.Special = Boolean.Parse(dgvr.Cells(5).Value)
        modifyitem.Imagepath = dgvr.Cells(6).Value
        modifyitem.Visible = True
        modifyitem.IsUpdate = True
    End Sub

    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        modifyitem.IsUpdate = False
        modifyitem.Visible = True
    End Sub
End Class