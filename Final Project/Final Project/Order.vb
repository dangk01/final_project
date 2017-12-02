Public Class Order
    Private id As Integer
    Private title As String
    Private price As Decimal
    Private quantity As Integer

    Public ReadOnly Property bookid() As Integer
        Get
            Return id
        End Get
    End Property
    Public ReadOnly Property bookTitle() As String
        Get
            Return title
        End Get
    End Property


    Public ReadOnly Property bookPrice() As Decimal
        Get
            Return price
        End Get
    End Property

    Public ReadOnly Property orderedQuantity() As Integer
        Get
            Return quantity
        End Get
    End Property

    Public Sub New(ByVal pBookid As Integer, ByVal pTitle As String, ByVal pPrice As Decimal)
        id = pBookid
        title = pTitle
        price = pPrice
        quantity = 1

    End Sub
    Public Overrides Function ToString() As String
        Return id & "-" & title
    End Function
End Class
