Public Class Cart
    Public Shared Property bookIDs As New ArrayList
    Public Shared discountRate As Decimal = 0
    Public Shared discountName As String = ""
    Private adapter As New BookstoreDataSetTableAdapters.OrdersTableAdapter
    Private adapter1 As New BookstoreDataSetTableAdapters.OrderLineTableAdapter
    Private adapter3 As New BookstoreDataSetTableAdapters.BooksTableAdapter
    Public Shared lastError As String

    Public Function Insert(ByVal custId As Integer, ByVal dateOrder As DateTime, ByVal sId As Integer, ByVal total As Decimal, ByVal promotionID As Integer) As Boolean
        Try
            adapter.Insert(custId, dateOrder, sId, total, promotionID)
            Return True
        Catch ex As Exception
            lastError = ex.Message
            Return False
        End Try

    End Function

    Public Function getMaxID() As Integer
        Return CInt(adapter.GetMaxID)
    End Function


    Public Function UpdateOrder(ByVal bonusID As Integer) As Boolean
        Try
            adapter.Update(bonusID, getMaxID())
            Return True
        Catch ex As Exception
            lastError = ex.Message
            Return False
        End Try
    End Function

    Public Function Insert(ByVal bookid As Integer) As Boolean
        Try
            adapter1.Insert(getMaxID(), bookid, 1)
            Return True
        Catch ex As Exception
            lastError = ex.Message
            Return False
        End Try
    End Function

    Public Function Update(ByVal bookID As Integer) As Boolean
        Try
            adapter3.Update(bookID)
            Return True
        Catch ex As Exception
            lastError = ex.Message
            Return False
        End Try
    End Function
End Class
