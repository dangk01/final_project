Public Class Books
    Private mId As Integer
    Private mTitle As String
    Private mAuthorName As String
    Private mPrice As Decimal
    Private mQuantityInStock As Integer


    Public ReadOnly Property id() As Integer
        Get
            Return mId
        End Get
    End Property

    Public ReadOnly Property title() As String
        Get
            Return mTitle
        End Get
    End Property
    Public ReadOnly Property AuthorName() As String
        Get
            Return mAuthorName
        End Get
    End Property

    Public ReadOnly Property price() As Decimal
        Get
            Return mPrice
        End Get
    End Property

    Public Property Quantity() As Integer
        Get
            Return mQuantityInStock
        End Get
        Set(ByVal value As Integer)
            mQuantityInStock = value
        End Set
    End Property

    Public Sub New(ByVal pId As Integer, ByVal pTitle As String,
                   ByVal pAuthorName As String,
                   ByVal pPrice As Decimal,
                   ByVal pQuantityInStock As Integer)
        mId = pId
        mTitle = pTitle
        mAuthorName = pAuthorName
        mPrice = pPrice
        mQuantityInStock = pQuantityInStock

    End Sub

End Class
