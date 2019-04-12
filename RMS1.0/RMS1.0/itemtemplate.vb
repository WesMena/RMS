Public Class itemtemplate
    Private _itemName As String
    Private _itemDescription As String
    Private _itemPrice As Double

    Public Property ItemName As String
        Get
            Return _itemName
        End Get
        Set(value As String)
            _itemName = value
        End Set
    End Property

    Public Property ItemDescription As String
        Get
            Return _itemDescription
        End Get
        Set(value As String)
            _itemDescription = value
        End Set
    End Property

    Public Property ItemPrice As Double
        Get
            Return _itemPrice
        End Get
        Set(value As Double)
            _itemPrice = value
        End Set
    End Property

    Private Sub itemlbl_Click(sender As Object, e As EventArgs) Handles itemNameLabel.Click

    End Sub

    Private Sub itemtemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemNameLabel.Text = Me.ItemName
        itemDescriptionLabel.Text = Me.ItemDescription
        itemPriceLabel.Text = "₡" & ItemPrice.ToString
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        appform.Order1.AddItem(Me.ItemName, 1, Me.ItemPrice)
        notification.itemNameLabel.Text = "1 " & Me.ItemName
        notification.StartPosition = FormStartPosition.Manual
        notification.Location = New Point(825, 160)
        notification.ShowDialog()
    End Sub
End Class
