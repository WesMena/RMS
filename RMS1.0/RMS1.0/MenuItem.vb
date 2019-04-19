Public Class MenuItem
    Private _id As Integer
    Private _name As String
    Private _description As String
    Private _category As String
    Private _price As Decimal
    Private _special As Boolean
    Private _imagepath As String
    Private _engdesc As String







    Public Sub New(id As Integer, name As String, description As String, category As String, price As Decimal, special As Boolean)
        'engdesc As String
        Me.Id = id
        Me.Name = name
        Me.Description = description
        Me.Category = category
        Me.Price = price
        Me.Special = special
        Me.Engdesc = Engdesc
    End Sub

    Public Sub New(id As Integer, name As String, description As String, category As String, price As Decimal, special As Boolean, imagepath As String, engdesc As String)
        Me.Id = id
        Me.Name = name
        Me.Description = description
        Me.Category = category
        Me.Price = price
        Me.Special = special
        Me.Imagepath = imagepath
        Me.Engdesc = engdesc
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
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

    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
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
    Public Property Engdesc As String
        Get
            Return _engdesc
        End Get
        Set(value As String)
            _engdesc = value
        End Set
    End Property
End Class
