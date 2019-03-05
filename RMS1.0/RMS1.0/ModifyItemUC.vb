Imports System.Data.SqlClient

Public Class ModifyItemUC
    Private _isUpdate1 As Boolean
    Private _id As Integer
    Private _itemName As String
    Private _description As String
    Private _category As String
    Private _price As Decimal
    Private _special As Boolean
    Private _imagepath As String = ""

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private connectionString As String = "Data Source=LAPTOP-3U2PB6I2\WESMENA;Initial Catalog=SimpleMenu;Persist Security Info=True;User ID=sa;Password=wvjjk611"

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property

    Public Property IsUpdate As Boolean
        Get
            Return _isUpdate1
        End Get
        Set(value As Boolean)
            _isUpdate1 = value
        End Set
    End Property

    Public Property ItemName As String
        Get
            Return _itemName
        End Get
        Set(value As String)
            _itemName = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return _category
        End Get
        Set(value As String)
            _category = value
        End Set
    End Property

    Public Property Special As Boolean
        Get
            Return _special
        End Get
        Set(value As Boolean)
            _special = value
        End Set
    End Property

    Public Property Imagepath As String
        Get
            Return _imagepath
        End Get
        Set(value As String)
            _imagepath = value
        End Set
    End Property

    Private Sub saveAddButton_Click(sender As Object, e As EventArgs)


        ItemName = NameTextBox.Text
        Description = descRichTextBox.Text
        Category = categoryComboBox.Text
        Price = priceNumericUpDown.Value
        Special = specialCheckBox.Checked
        If requiredIsNull() Then
            MsgBox("Por favor llene todos los campos marcados con *")
        Else
            If IsUpdate Then
                If Imagepath = "" Then
                    Imagepath = "default"
                End If
                updateTable()
            Else
                If Imagepath = "" Then
                    Imagepath = "default"
                End If
                addToTable()
            End If
            MsgBox("Se han guardado los cambios")
            Me.Hide()
        End If
    End Sub

    Private Function requiredIsNull() As Boolean
        Dim n As Boolean = ItemName Is Nothing
        Dim cat As Boolean = Category Is Nothing
        Dim p As Boolean = Price = 0
        Dim img As Boolean = Special And Imagepath = ""
        If img Then
            MsgBox("Los Items especiales requieren una imagen", MsgBoxStyle.Exclamation)
        End If
        Return n Or cat Or p Or img

    End Function


    Private Sub addToTable()
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "INSERT INTO Menu(name, description , category , price , special , imagepath) VALUES (@name, @description, @category , @price , @special , @imagepath)"

        With myCmd
            .Parameters.AddWithValue("@name", ItemName)
            .Parameters.AddWithValue("@description", Description)
            .Parameters.AddWithValue("@category", Category)
            .Parameters.AddWithValue("@price", Price)
            .Parameters.AddWithValue("@special", Special)
            .Parameters.AddWithValue("@imagepath", Imagepath)
        End With


        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Private Sub updateTable()
        myConn = New SqlConnection(connectionString)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "UPDATE Menu SET name = @name, description = @description , category = @category , price = @price , special = @special , imagepath = @imagepath WHERE id = @id"

        With myCmd
            .Parameters.AddWithValue("@name", ItemName)
            .Parameters.AddWithValue("@description", Description)
            .Parameters.AddWithValue("@category", Category)
            .Parameters.AddWithValue("@price", Price)
            .Parameters.AddWithValue("@special", Special)
            .Parameters.AddWithValue("@imagepath", Imagepath)
            .Parameters.AddWithValue("@id", Id)
        End With


        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Private Sub ModifyItemUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsUpdate Then
            updateFields()
        Else
            clearFields()
        End If
    End Sub

    Private Sub updateFields()
        NameTextBox.Text = ItemName
        descRichTextBox.Text = Description
        categoryComboBox.Text = Category
        priceNumericUpDown.Value = Price
        If Special Then
            specialCheckBox.CheckState = CheckState.Checked
        Else
            specialCheckBox.CheckState = CheckState.Unchecked
        End If

        filenameLabel.Text = Imagepath
    End Sub

    Private Sub clearFields()
        NameTextBox.Clear()
        descRichTextBox.Clear()
        categoryComboBox.ResetText()
        priceNumericUpDown.ResetText()
        specialCheckBox.CheckState = CheckState.Unchecked
        filenameLabel.Text = Imagepath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub

    Private Sub ModifyItemUC_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        updateFields()
    End Sub

    Private Sub browseFileButton_Click(sender As Object, e As EventArgs)
        Dim ofd As OpenFileDialog = New OpenFileDialog
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Imagepath = ofd.FileName
        End If
    End Sub

    Private Sub BunifuiOSSwitch1_OnValueChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub maincoursebtn_Click(sender As Object, e As EventArgs) Handles browseFileButton.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Imagepath = ofd.FileName
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Visible = False
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles saveAddButton.Click

        ItemName = NameTextBox.Text
        Description = descRichTextBox.Text
        Category = categoryComboBox.Text
        Price = priceNumericUpDown.Value
        Special = specialCheckBox.Checked
        If requiredIsNull() Then
            MsgBox("Por favor llene todos los campos marcados con *")
        Else
            If IsUpdate Then
                If Imagepath = "" Then
                    Imagepath = "default"
                End If
                updateTable()
            Else
                If Imagepath = "" Then
                    Imagepath = "default"
                End If
                addToTable()
            End If
            MsgBox("Se han guardado los cambios")
            Me.Hide()
        End If
    End Sub
End Class
