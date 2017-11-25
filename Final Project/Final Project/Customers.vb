Public Class Customers
    Private adapter As New BookstoreDataSetTableAdapters.CustomersTableAdapter

    Public Function checkID(ByVal id As Integer) As Boolean
        Dim idExists As Boolean = True
        Dim count As Integer = adapter.CheckID(id)
        If count <> 1 Then
            idExists = False
        End If
        Return idExists
    End Function
End Class
